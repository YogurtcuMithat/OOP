using protectedInternalprotected.Models;

namespace protectedInternalprotected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             deneme deneme = new deneme();
            deneme.internalProtectedProperty = 55  ;
            
        }
    }
}