using Interface.Models;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void PrintPoint(IAnimal p)
        {
            MessageBox.Show("Alan: " + p.Distance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IAnimal p = new Dog(2,3);
            PrintPoint(p);
        }
    }
}