
namespace Practice_Terminal_Project
{
	partial class Form1
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
			this.btnSet = new System.Windows.Forms.Button();
			this.cbCOM = new System.Windows.Forms.ComboBox();
			this.cbBaud = new System.Windows.Forms.ComboBox();
			this.txtHistory = new System.Windows.Forms.RichTextBox();
			this.txtChatText = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.picPortIndicator = new System.Windows.Forms.Button();
			this.panelTerminal = new System.Windows.Forms.Panel();
			this.panelTerminal.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSet
			// 
			this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSet.Location = new System.Drawing.Point(185, 9);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(93, 23);
			this.btnSet.TabIndex = 0;
			this.btnSet.Text = "Connect";
			this.btnSet.UseVisualStyleBackColor = true;
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
			// 
			// cbCOM
			// 
			this.cbCOM.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbCOM.FormattingEnabled = true;
			this.cbCOM.Location = new System.Drawing.Point(14, 9);
			this.cbCOM.Name = "cbCOM";
			this.cbCOM.Size = new System.Drawing.Size(59, 21);
			this.cbCOM.TabIndex = 1;
			// 
			// cbBaud
			// 
			this.cbBaud.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbBaud.FormattingEnabled = true;
			this.cbBaud.Location = new System.Drawing.Point(79, 9);
			this.cbBaud.Name = "cbBaud";
			this.cbBaud.Size = new System.Drawing.Size(100, 21);
			this.cbBaud.TabIndex = 2;
			// 
			// txtHistory
			// 
			this.txtHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtHistory.BackColor = System.Drawing.Color.White;
			this.txtHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtHistory.Location = new System.Drawing.Point(13, 53);
			this.txtHistory.Name = "txtHistory";
			this.txtHistory.ReadOnly = true;
			this.txtHistory.Size = new System.Drawing.Size(398, 287);
			this.txtHistory.TabIndex = 3;
			this.txtHistory.Text = "";
			// 
			// txtChatText
			// 
			this.txtChatText.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtChatText.Location = new System.Drawing.Point(14, 344);
			this.txtChatText.Name = "txtChatText";
			this.txtChatText.Size = new System.Drawing.Size(302, 20);
			this.txtChatText.TabIndex = 4;
			this.txtChatText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtChatText_KeyUp);
			// 
			// btnSend
			// 
			this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSend.Location = new System.Drawing.Point(322, 344);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(90, 20);
			this.btnSend.TabIndex = 5;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// picPortIndicator
			// 
			this.picPortIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.picPortIndicator.Location = new System.Drawing.Point(284, 9);
			this.picPortIndicator.Name = "picPortIndicator";
			this.picPortIndicator.Size = new System.Drawing.Size(127, 23);
			this.picPortIndicator.TabIndex = 6;
			this.picPortIndicator.UseVisualStyleBackColor = true;
			// 
			// panelTerminal
			// 
			this.panelTerminal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelTerminal.Controls.Add(this.txtChatText);
			this.panelTerminal.Controls.Add(this.picPortIndicator);
			this.panelTerminal.Controls.Add(this.cbBaud);
			this.panelTerminal.Controls.Add(this.txtHistory);
			this.panelTerminal.Controls.Add(this.cbCOM);
			this.panelTerminal.Controls.Add(this.btnSend);
			this.panelTerminal.Controls.Add(this.btnSet);
			this.panelTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTerminal.Location = new System.Drawing.Point(0, 0);
			this.panelTerminal.Name = "panelTerminal";
			this.panelTerminal.Size = new System.Drawing.Size(424, 391);
			this.panelTerminal.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 391);
			this.Controls.Add(this.panelTerminal);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Terminal Project";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelTerminal.ResumeLayout(false);
			this.panelTerminal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.ComboBox cbCOM;
		private System.Windows.Forms.ComboBox cbBaud;
		private System.Windows.Forms.RichTextBox txtHistory;
		private System.Windows.Forms.TextBox txtChatText;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button picPortIndicator;
		private System.Windows.Forms.Panel panelTerminal;
	}
}
