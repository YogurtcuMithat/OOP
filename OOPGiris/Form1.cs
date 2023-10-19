using OOPGiris.Models; //Dosyanın altındaki sınıfın modeli
using OOPGiris.Models.AccessModifiers;
using OOPGiris.Models.Oyuncu;
using OOPGiris.Models.Yazar;
using System.Numerics;

namespace OOPGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.Brand = "Reno";
            araba.Model = "Mustang";
            araba.YearOfProduction = 2015;
            araba.Speed = 100;
            araba.Gear = 1;
            MessageBox.Show(araba.Model.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.Name = "Mustafa Kemal";
            yazar.Surname = "Atatürk";
            yazar.Yaz("Nutuk");

        }

        Oyuncu Oyuncu = new Oyuncu();
        private void button3_Click(object sender, EventArgs e)
        {
            Oyuncu.Name = txtOyuncu.Text;
            Oyuncu.Irk = txtBrans.Text;
            Oyuncu.Silah = txtSilah.Text;
            Oyuncu.Brans = txtBrans.Text;
            Oyuncu.Saldir();

        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            int DusmanCani = label1.Width;
            DusmanCani -= Oyuncu.Saldir();
            label1.Width = DusmanCani;
            MessageBox.Show($"{Oyuncu.Saldir()} hasar");
            MessageBox.Show($"{label1.Width} bar");
            if (DusmanCani <= 0)
                MessageBox.Show($"{Oyuncu.Name} oyunu kazandı");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Models.AccessModifiers.Plane plane = new Models.AccessModifiers.Plane();
        }
    }
}