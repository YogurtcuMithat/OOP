using Encapsulation.Models;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User user = new User(txtUserName.Text,txtUserPassword.Text);
            user.

        }
    }
}