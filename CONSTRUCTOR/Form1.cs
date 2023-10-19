using CONSTRUCTOR.Model;

namespace CONSTRUCTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bebek bebek = new Bebek(3, "Erkek", 3.22);
            Bebek bebek1 = new Bebek(3, "", 0);
        }
        int karsiGuc = 25;
        private void button1_Click(object sender, EventArgs e)
        {
            Futbolcu futbolcu = new Futbolcu(textBox1.Text, textBox2.Text);
            karsiGuc -= futbolcu.SutGucu;
            string gol = 0 > (karsiGuc) ? "goool" : "Gol olmadı";
            MessageBox.Show(gol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int red = trackBarR.Value;
            int green = trackBarG.Value;
            int blue = trackBarB.Value;
            Form2 form2 =new Form2(red, green, blue);
            form2.Show();
        }
    }
}