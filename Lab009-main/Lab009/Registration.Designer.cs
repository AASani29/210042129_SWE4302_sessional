namespace Lab009
{
    partial class Registration
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
            this.regLabel = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.regClick = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repasstxt = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.BackColor = System.Drawing.Color.Transparent;
            this.regLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.regLabel.Location = new System.Drawing.Point(381, 99);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(134, 37);
            this.regLabel.TabIndex = 7;
            this.regLabel.Text = "Register";
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametxt.Location = new System.Drawing.Point(370, 228);
            this.nametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(198, 19);
            this.nametxt.TabIndex = 6;
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Location = new System.Drawing.Point(370, 174);
            this.usertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(198, 19);
            this.usertxt.TabIndex = 5;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtxt.Location = new System.Drawing.Point(370, 280);
            this.passtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(198, 19);
            this.passtxt.TabIndex = 9;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // regClick
            // 
            this.regClick.BackColor = System.Drawing.Color.Lavender;
            this.regClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regClick.Location = new System.Drawing.Point(388, 381);
            this.regClick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regClick.Name = "regClick";
            this.regClick.Size = new System.Drawing.Size(98, 50);
            this.regClick.TabIndex = 10;
            this.regClick.Text = "Register";
            this.regClick.UseVisualStyleBackColor = false;
            this.regClick.Click += new System.EventHandler(this.regClick_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.SystemColors.Info;
            this.passLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(238, 272);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(111, 30);
            this.passLabel.TabIndex = 11;
            this.passLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirm Password";
            // 
            // repasstxt
            // 
            this.repasstxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.repasstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repasstxt.Location = new System.Drawing.Point(370, 328);
            this.repasstxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repasstxt.Name = "repasstxt";
            this.repasstxt.Size = new System.Drawing.Size(198, 19);
            this.repasstxt.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Info;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(273, 220);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 30);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.SystemColors.Info;
            this.userLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(231, 166);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(118, 30);
            this.userLabel.TabIndex = 15;
            this.userLabel.Text = "Username";
            // 
            // loginLink
            // 
            this.loginLink.ActiveLinkColor = System.Drawing.Color.Red;
            this.loginLink.AutoSize = true;
            this.loginLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginLink.Location = new System.Drawing.Point(495, 466);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(54, 20);
            this.loginLink.TabIndex = 17;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Log In";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Don\'t have an account?";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab009.Properties.Resources.cute_panda_seamless_pattern_background_cartoon_panda_bears_illustration_creative_kids_for_fabric_wrapping_textile_wallpaper_apparel_free_vector1;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repasstxt);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.regClick);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.usertxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button regClick;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repasstxt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label label2;
    }
}