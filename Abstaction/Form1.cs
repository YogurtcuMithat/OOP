using Abstaction.Models;
using Abstaction.Models.Araba;

namespace Abstaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Binek binek = new Binek();
            binek.Marka = "X";
            binek.Yıl = 1999;
            binek.Model = "xy";
            MessageBox.Show($"{binek.Marka} {binek.Model} {binek.Yıl}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tasit tasit = new Tasit();  
        }
    }
}