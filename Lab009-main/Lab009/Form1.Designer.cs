namespace Lab009
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.passtxt = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.loginClick = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.regLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(345, 200);
            this.usertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(198, 26);
            this.usertxt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(345, 273);
            this.passtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(198, 26);
            this.passtxt.TabIndex = 2;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Bisque;
            this.LoginLabel.Location = new System.Drawing.Point(402, 121);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(95, 37);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login";
            // 
            // loginClick
            // 
            this.loginClick.BackColor = System.Drawing.Color.Lavender;
            this.loginClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginClick.Location = new System.Drawing.Point(393, 351);
            this.loginClick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginClick.Name = "loginClick";
            this.loginClick.Size = new System.Drawing.Size(98, 50);
            this.loginClick.TabIndex = 4;
            this.loginClick.Text = "Login";
            this.loginClick.UseVisualStyleBackColor = false;
            this.loginClick.Click += new System.EventHandler(this.loginClick_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.SystemColors.Info;
            this.passLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(204, 268);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(111, 30);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Password";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.SystemColors.Info;
            this.userLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(197, 196);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(118, 30);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "Username";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.BackColor = System.Drawing.Color.Transparent;
            this.regLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.ForeColor = System.Drawing.Color.White;
            this.regLabel.Location = new System.Drawing.Point(252, 467);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(211, 24);
            this.regLabel.TabIndex = 8;
            this.regLabel.Text = "Don\'t have an account?";
            // 
            // regLink
            // 
            this.regLink.AutoSize = true;
            this.regLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.regLink.Location = new System.Drawing.Point(469, 470);
            this.regLink.Name = "regLink";
            this.regLink.Size = new System.Drawing.Size(96, 20);
            this.regLink.TabIndex = 9;
            this.regLink.TabStop = true;
            this.regLink.Text = "Create one!!";
            this.regLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab009.Properties.Resources.cute_panda_seamless_pattern_background_cartoon_panda_bears_illustration_creative_kids_for_fabric_wrapping_textile_wallpaper_apparel_free_vector;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.regLink);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginClick);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button loginClick;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.LinkLabel regLink;
    }
}

