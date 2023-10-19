using Polymorphism.Models;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Npc npc = new Npc();
            npc.Saldir();
            Buyucu buyucu = new Buyucu();
            buyucu.Saldir();
            Okcu okcu = new Okcu();
            okcu.Saldir();
        }
    }
}