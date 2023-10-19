using Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form3 : Form
    {
        public Form3(User user)
        {
            InitializeComponent();
            userControl = user;
        }
        User userControl;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text==userControl.UserName && txtUserPassword.Text ==userControl.Password)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
                MessageBox.Show("Bilgiler hatalı.");
        }
    }
}
