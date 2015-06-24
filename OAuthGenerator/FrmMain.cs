using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TOAuthLib;

namespace OAuthGenerator
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private string ParseQueryStringParameter(string parameterName, string text)
		{
			Match expressionMatch = Regex.Match(text, string.Format(@"{0}=(?<value>[^&]+)", parameterName));

			if (!expressionMatch.Success)
				return null;

			return expressionMatch.Groups["value"].Value;
		}

		private void btn_Click(object sender, EventArgs e)
		{
			this.btn.Enabled = false;
			this.txtAppKey.ReadOnly	= this.txtAppSecret.ReadOnly = true;
			this.rdbPin.Enabled     = this.rdbRedirect.Enabled   = false;

			var dic = new StringDictionary();
			dic.Add("AppToken",  this.txtAppKey.Text);
			dic.Add("AppSecret", this.txtAppSecret.Text);
			dic.Add("UsePin",    this.rdbPin.Checked ? "1" : "0");

			this.bgwLogin.RunWorkerAsync(dic);
		}

		private void bgwLogin_DoWork(object sender, DoWorkEventArgs e)
		{
			var dic = (StringDictionary)e.Argument;

			var t = new TOAuth(dic["AppToken"], dic["AppSecret"]);

			try
			{
				if (dic["UsePin"] == "1")
				{
					string body = t.Call("POST", "https://api.twitter.com/oauth/request_token", "");

					dic.Add("UserToken", this.ParseQueryStringParameter("oauth_token", body));
					dic.Add("UserSecret", this.ParseQueryStringParameter("oauth_token_secret", body));
				}
				else
				{
					string body = t.Call("POST", "https://api.twitter.com/oauth/request_token", "", TOAuth.ContentType, "http://localhost:58776/");

					dic.Add("UserToken", this.ParseQueryStringParameter("oauth_token", body));
					dic.Add("UserSecret", this.ParseQueryStringParameter("oauth_token_secret", body));
				}
			}
			catch (TOAuth.TwitterException ex)
			{
				dic.Add("Error", ex.Message);
			}

			e.Result = dic;
		}

		private void bgwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var dic = (StringDictionary)e.Result;
			if (dic.ContainsKey("Error"))
			{
				MessageBox.Show(this, dic["Error"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					// authorize
					// authenticate
					if (dic["UsePin"] == "1")
						Process.Start("explorer", "\"https://api.twitter.com/oauth/authenticate?oauth_token=\"" + dic["UserToken"]);
					else
						Process.Start("explorer", "\"https://api.twitter.com/oauth/authorize?oauth_token=\"" + dic["UserToken"]);
				}
				catch
				{ }


				using (var form = new FrmPin(dic["UsePin"] == "1"))
				{
					if (form.ShowDialog() == DialogResult.OK)
					{
						dic.Add("OauthVerifier", (string)form.Tag);
						this.bgwGetToken.RunWorkerAsync(dic);
						return;
					}
				}
			}

			this.btn.Enabled = true;
			this.txtAppKey.ReadOnly	= this.txtAppSecret.ReadOnly = false;
			this.rdbPin.Enabled     = this.rdbRedirect.Enabled   = true;
		}

		private void bgwGetToken_DoWork(object sender, DoWorkEventArgs e)
		{
			var dic = (StringDictionary)e.Argument;
			var t = new TOAuth(dic["AppToken"], dic["AppSecret"], dic["UserToken"], dic["UserSecret"]);
			
			try
			{
				string body = t.Call("POST", "https://api.twitter.com/oauth/access_token", new { oauth_verifier = dic["OauthVerifier"] });

				dic["UserToken"]  = this.ParseQueryStringParameter("oauth_token", body);
				dic["UserSecret"] = this.ParseQueryStringParameter("oauth_token_secret", body);

				dic.Add("UserName", this.ParseQueryStringParameter("screen_name", body));
			}
			catch (TOAuth.TwitterException ex)
			{
				dic.Add("Error", ex.Message);
			}

			e.Result = dic;
		}

		private void bgwGetToken_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var dic = (StringDictionary)e.Result;

			if (dic.ContainsKey("Error"))
			{
				this.txtUserName.Text	= "";
				this.txtUserKey.Text	= "";
				this.txtUserSecret.Text	= "";

				MessageBox.Show(this, dic["Error"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.txtUserName.Text	= dic["UserName"];
				this.txtUserKey.Text	= dic["UserToken"];
				this.txtUserSecret.Text	= dic["UserSecret"];
			}

			this.btn.Enabled = true;
			this.txtAppKey.ReadOnly	= this.txtAppSecret.ReadOnly = false;
			this.rdbPin.Enabled     = this.rdbRedirect.Enabled   = true;
		}
	}
}
