namespace OAuthGenerator
{
	partial class FrmPin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtPin = new System.Windows.Forms.TextBox();
			this.prg = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// txtPin
			// 
			this.txtPin.Location = new System.Drawing.Point(12, 12);
			this.txtPin.MaxLength = 10;
			this.txtPin.Name = "txtPin";
			this.txtPin.Size = new System.Drawing.Size(123, 23);
			this.txtPin.TabIndex = 0;
			this.txtPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPin_KeyDown);
			// 
			// prg
			// 
			this.prg.Location = new System.Drawing.Point(12, 12);
			this.prg.Name = "prg";
			this.prg.Size = new System.Drawing.Size(123, 23);
			this.prg.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.prg.TabIndex = 1;
			this.prg.Visible = false;
			// 
			// FrmPin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(147, 47);
			this.Controls.Add(this.txtPin);
			this.Controls.Add(this.prg);
			this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmPin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Twitter OAuth Token";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPin_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPin;
		private System.Windows.Forms.ProgressBar prg;

	}
}