namespace OAuthGenerator
{
	partial class FrmMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.grbKey = new System.Windows.Forms.GroupBox();
			this.lblAppSecret = new System.Windows.Forms.Label();
			this.lblAppKey = new System.Windows.Forms.Label();
			this.btn = new System.Windows.Forms.Button();
			this.rdbRedirect = new System.Windows.Forms.RadioButton();
			this.rdbPin = new System.Windows.Forms.RadioButton();
			this.txtAppSecret = new System.Windows.Forms.TextBox();
			this.txtAppKey = new System.Windows.Forms.TextBox();
			this.grbUser = new System.Windows.Forms.GroupBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserSecret = new System.Windows.Forms.Label();
			this.lblUserKey = new System.Windows.Forms.Label();
			this.txtUserSecret = new System.Windows.Forms.TextBox();
			this.txtUserKey = new System.Windows.Forms.TextBox();
			this.bgwLogin = new System.ComponentModel.BackgroundWorker();
			this.bgwGetToken = new System.ComponentModel.BackgroundWorker();
			this.grbKey.SuspendLayout();
			this.grbUser.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbKey
			// 
			this.grbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grbKey.Controls.Add(this.lblAppSecret);
			this.grbKey.Controls.Add(this.lblAppKey);
			this.grbKey.Controls.Add(this.btn);
			this.grbKey.Controls.Add(this.rdbRedirect);
			this.grbKey.Controls.Add(this.rdbPin);
			this.grbKey.Controls.Add(this.txtAppSecret);
			this.grbKey.Controls.Add(this.txtAppKey);
			this.grbKey.Location = new System.Drawing.Point(12, 12);
			this.grbKey.Name = "grbKey";
			this.grbKey.Size = new System.Drawing.Size(328, 105);
			this.grbKey.TabIndex = 0;
			this.grbKey.TabStop = false;
			this.grbKey.Text = "App";
			// 
			// lblAppSecret
			// 
			this.lblAppSecret.AutoSize = true;
			this.lblAppSecret.Location = new System.Drawing.Point(6, 79);
			this.lblAppSecret.Name = "lblAppSecret";
			this.lblAppSecret.Size = new System.Drawing.Size(66, 15);
			this.lblAppSecret.TabIndex = 4;
			this.lblAppSecret.Text = "App Secret";
			// 
			// lblAppKey
			// 
			this.lblAppKey.AutoSize = true;
			this.lblAppKey.Location = new System.Drawing.Point(6, 50);
			this.lblAppKey.Name = "lblAppKey";
			this.lblAppKey.Size = new System.Drawing.Size(52, 15);
			this.lblAppKey.TabIndex = 4;
			this.lblAppKey.Text = "App Key";
			// 
			// btn
			// 
			this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn.Location = new System.Drawing.Point(271, 47);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(51, 52);
			this.btn.TabIndex = 2;
			this.btn.Text = "발급";
			this.btn.UseVisualStyleBackColor = true;
			this.btn.Click += new System.EventHandler(this.btn_Click);
			// 
			// rdbRedirect
			// 
			this.rdbRedirect.AutoSize = true;
			this.rdbRedirect.Location = new System.Drawing.Point(6, 22);
			this.rdbRedirect.Name = "rdbRedirect";
			this.rdbRedirect.Size = new System.Drawing.Size(93, 19);
			this.rdbRedirect.TabIndex = 3;
			this.rdbRedirect.Text = "URL Redirect";
			this.rdbRedirect.UseVisualStyleBackColor = true;
			// 
			// rdbPin
			// 
			this.rdbPin.AutoSize = true;
			this.rdbPin.Checked = true;
			this.rdbPin.Location = new System.Drawing.Point(105, 22);
			this.rdbPin.Name = "rdbPin";
			this.rdbPin.Size = new System.Drawing.Size(42, 19);
			this.rdbPin.TabIndex = 4;
			this.rdbPin.TabStop = true;
			this.rdbPin.Text = "Pin";
			this.rdbPin.UseVisualStyleBackColor = true;
			// 
			// txtAppSecret
			// 
			this.txtAppSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAppSecret.Location = new System.Drawing.Point(78, 76);
			this.txtAppSecret.Name = "txtAppSecret";
			this.txtAppSecret.Size = new System.Drawing.Size(187, 23);
			this.txtAppSecret.TabIndex = 1;
			// 
			// txtAppKey
			// 
			this.txtAppKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAppKey.Location = new System.Drawing.Point(78, 47);
			this.txtAppKey.Name = "txtAppKey";
			this.txtAppKey.Size = new System.Drawing.Size(187, 23);
			this.txtAppKey.TabIndex = 0;
			// 
			// grbUser
			// 
			this.grbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grbUser.Controls.Add(this.lblUserName);
			this.grbUser.Controls.Add(this.txtUserName);
			this.grbUser.Controls.Add(this.lblUserSecret);
			this.grbUser.Controls.Add(this.lblUserKey);
			this.grbUser.Controls.Add(this.txtUserSecret);
			this.grbUser.Controls.Add(this.txtUserKey);
			this.grbUser.Location = new System.Drawing.Point(12, 123);
			this.grbUser.Name = "grbUser";
			this.grbUser.Size = new System.Drawing.Size(328, 109);
			this.grbUser.TabIndex = 1;
			this.grbUser.TabStop = false;
			this.grbUser.Text = "User Token";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(6, 25);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(66, 15);
			this.lblUserName.TabIndex = 10;
			this.lblUserName.Text = "User Name";
			// 
			// txtUserName
			// 
			this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
			this.txtUserName.Location = new System.Drawing.Point(78, 22);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(244, 23);
			this.txtUserName.TabIndex = 5;
			// 
			// lblUserSecret
			// 
			this.lblUserSecret.AutoSize = true;
			this.lblUserSecret.Location = new System.Drawing.Point(6, 83);
			this.lblUserSecret.Name = "lblUserSecret";
			this.lblUserSecret.Size = new System.Drawing.Size(67, 15);
			this.lblUserSecret.TabIndex = 7;
			this.lblUserSecret.Text = "User Secret";
			// 
			// lblUserKey
			// 
			this.lblUserKey.AutoSize = true;
			this.lblUserKey.Location = new System.Drawing.Point(6, 54);
			this.lblUserKey.Name = "lblUserKey";
			this.lblUserKey.Size = new System.Drawing.Size(53, 15);
			this.lblUserKey.TabIndex = 8;
			this.lblUserKey.Text = "User Key";
			// 
			// txtUserSecret
			// 
			this.txtUserSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUserSecret.BackColor = System.Drawing.SystemColors.Window;
			this.txtUserSecret.Location = new System.Drawing.Point(78, 80);
			this.txtUserSecret.Name = "txtUserSecret";
			this.txtUserSecret.ReadOnly = true;
			this.txtUserSecret.Size = new System.Drawing.Size(244, 23);
			this.txtUserSecret.TabIndex = 7;
			// 
			// txtUserKey
			// 
			this.txtUserKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUserKey.BackColor = System.Drawing.SystemColors.Window;
			this.txtUserKey.Location = new System.Drawing.Point(78, 51);
			this.txtUserKey.Name = "txtUserKey";
			this.txtUserKey.ReadOnly = true;
			this.txtUserKey.Size = new System.Drawing.Size(244, 23);
			this.txtUserKey.TabIndex = 6;
			// 
			// bgwLogin
			// 
			this.bgwLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLogin_DoWork);
			this.bgwLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLogin_RunWorkerCompleted);
			// 
			// bgwGetToken
			// 
			this.bgwGetToken.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetToken_DoWork);
			this.bgwGetToken.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetToken_RunWorkerCompleted);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 244);
			this.Controls.Add(this.grbUser);
			this.Controls.Add(this.grbKey);
			this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MinimumSize = new System.Drawing.Size(368, 282);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Twitter OAuth Token";
			this.grbKey.ResumeLayout(false);
			this.grbKey.PerformLayout();
			this.grbUser.ResumeLayout(false);
			this.grbUser.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbKey;
		private System.Windows.Forms.TextBox txtAppSecret;
		private System.Windows.Forms.TextBox txtAppKey;
		private System.Windows.Forms.RadioButton rdbRedirect;
		private System.Windows.Forms.RadioButton rdbPin;
		private System.Windows.Forms.Label lblAppSecret;
		private System.Windows.Forms.Label lblAppKey;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.GroupBox grbUser;
		private System.Windows.Forms.Label lblUserSecret;
		private System.Windows.Forms.Label lblUserKey;
		private System.Windows.Forms.TextBox txtUserSecret;
		private System.Windows.Forms.TextBox txtUserKey;
		private System.ComponentModel.BackgroundWorker bgwLogin;
		private System.ComponentModel.BackgroundWorker bgwGetToken;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
	}
}

