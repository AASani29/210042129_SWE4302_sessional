using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab009
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }


        public void checkUser(string str)
        {
            string user = $@"C:\Users\SANI\Downloads\Lab009-main\Lab009-main\Users\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string u in users)
                {
                    if (u.Contains("un:"))
                    {
                        if (usertxt.Text == u.Remove(0, 3))
                        {
                            foreach (string p in users)
                            {
                                if (p.Contains("pass:"))
                                {
                                    if (passtxt.Text == p.Remove(0, 5))
                                    {
                                        GlobalClass._userName = u.Remove(0,3);
                                        foreach (string n in users)
                                        {
                                            if(n.Contains("nm:"))
                                            {
                                                GlobalClass._name = n.Remove(0,3);
                                            }
                                        }
                                        this.Hide();
                                        new Dashboard().Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginClick_Click(object sender, EventArgs e)
        {
            checkUser(usertxt.Text);
        }
    }
}
