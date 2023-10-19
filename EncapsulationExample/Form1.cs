using EncapsulationExample.Models;

namespace EncapsulationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player1=new Player(Convert.ToInt32(textBox1.Text));
            label1.Text="Şut gücü: "+player1.SutGucu.ToString();
            Player player2 = new Player(Convert.ToInt32(textBox2.Text));
            label2.Text = "Şut gücü: " + player2.SutGucu.ToString();
            Player player3 = new Player(Convert.ToInt32(textBox3.Text));
            label3.Text = "Şut gücü: " + player3.SutGucu.ToString();
        }
    }
}