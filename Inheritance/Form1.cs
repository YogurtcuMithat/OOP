using Inheritance.Models;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Character c1 = new Wizard();
            Wizard wizard=c1 as Wizard;
            wizard.Magic();
        }
    }
}