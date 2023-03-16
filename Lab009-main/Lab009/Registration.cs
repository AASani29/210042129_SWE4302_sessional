using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab009
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        public void regUser(string str)
        {
            string newUser = $@"C:\Users\SANI\Downloads\Lab009-main\Lab009-main\Users\{str}.txt";

            using (StreamWriter writer = new StreamWriter(newUser))
            {
                writer.Write("un:" + usertxt.Text);
                writer.Write('\n');
                if (passtxt.Text.Length >= 6)
                {
                    if (passtxt.Text == repasstxt.Text)
                    {
                        writer.Write("pass:" + passtxt.Text);
                        writer.Write('\n');
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                writer.Write("nm:" + nametxt.Text);
                writer.Write('\n');
            }
        }

        private void regClick_Click(object sender, EventArgs e)
        {
            if (passtxt.Text.Length >= 6)
            {

                if (passtxt.Text == repasstxt.Text)
                {
                    regUser(usertxt.Text);
                    User _temp = new User(usertxt.Text, passtxt.Text, nametxt.Text);
                    MessageBox.Show("Account successfully created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
