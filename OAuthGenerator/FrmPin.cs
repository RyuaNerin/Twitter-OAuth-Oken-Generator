using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace OAuthGenerator
{
	public partial class FrmPin : Form
	{
		private bool			m_usePin;
		private HttpListener	m_http;

		public FrmPin(bool usePin)
		{
			InitializeComponent();

			this.m_usePin = usePin;

			this.prg.Visible	= !usePin;
			this.txtPin.Visible	=  usePin;

			if (!usePin)
			{
				this.m_http = new HttpListener();
				this.m_http.Prefixes.Add("http://localhost:58776/");
				this.m_http.Start();
				this.m_http.BeginGetContext(this.GetContext, null);
			}
		}

		private static byte[] m_succ = Encoding.UTF8.GetBytes("<HTML><HEAD><TITLE></TITLE></HEAD><BODY>SUCCESS</BODY></HTML>");
		private static byte[] m_fail = Encoding.UTF8.GetBytes("<HTML><HEAD><TITLE></TITLE></HEAD><BODY>FAIL</BODY></HTML>");
		private void GetContext(IAsyncResult e)
		{
			var context = this.m_http.EndGetContext(e);
			string res = null;
			
			if (context.Request.HttpMethod == "GET")
			{
				foreach (string key in context.Request.QueryString.Keys)
				{
					if (key == "oauth_verifier")
					{
						res = context.Request.QueryString[key];
						break;
					}
				}
			}

			if (res != null)
			{
				context.Response.Headers.Add(HttpResponseHeader.ContentType, "text/html; charset=utf-8");
				context.Response.OutputStream.Write(FrmPin.m_succ, 0, FrmPin.m_succ.Length);
				context.Response.Close();

				this.Invoke(new Action<int>(ee =>
				{
					this.Tag = res;
					this.DialogResult = DialogResult.OK;
					this.Close();
				}), 0);
			}
			else
			{
				context.Response.Headers.Add(HttpResponseHeader.ContentType, "text/html; charset=utf-8");
				context.Response.OutputStream.Write(FrmPin.m_fail, 0, FrmPin.m_succ.Length);
				context.Response.Close();
			}
		}
		
		private void txtPin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				this.Tag = this.txtPin.Text;
				this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}
		}

		private void FrmPin_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!this.m_usePin)
				this.m_http.Close();
		}
	}
}
