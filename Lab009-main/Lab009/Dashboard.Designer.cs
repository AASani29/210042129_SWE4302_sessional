namespace Lab009
{
    partial class Dashboard
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
            this.dashLabel = new System.Windows.Forms.Label();
            this.logoutClick = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dashLabel
            // 
            this.dashLabel.AutoSize = true;
            this.dashLabel.BackColor = System.Drawing.Color.Transparent;
            this.dashLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashLabel.Location = new System.Drawing.Point(220, 236);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(243, 37);
            this.dashLabel.TabIndex = 19;
            this.dashLabel.Text = "Welcome, User :";
            // 
            // logoutClick
            // 
            this.logoutClick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutClick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutClick.Location = new System.Drawing.Point(392, 339);
            this.logoutClick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutClick.Name = "logoutClick";
            this.logoutClick.Size = new System.Drawing.Size(98, 50);
            this.logoutClick.TabIndex = 18;
            this.logoutClick.Text = "Log Out";
            this.logoutClick.UseVisualStyleBackColor = false;
            this.logoutClick.Click += new System.EventHandler(this.logoutClick_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.userLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(475, 236);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(155, 37);
            this.userLabel.TabIndex = 20;
            this.userLabel.Text = "username";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab009.Properties.Resources.cute_panda_seamless_pattern_background_cartoon_panda_bears_illustration_creative_kids_for_fabric_wrapping_textile_wallpaper_apparel_free_vector;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.dashLabel);
            this.Controls.Add(this.logoutClick);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.Button logoutClick;
        private System.Windows.Forms.Label userLabel;
    }
}