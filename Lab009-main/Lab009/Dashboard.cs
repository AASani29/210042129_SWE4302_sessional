using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab009
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        
        private void logoutClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Logged in as : {GlobalClass._userName}","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            userLabel.Text = GlobalClass._userName;
        }
    }
}
