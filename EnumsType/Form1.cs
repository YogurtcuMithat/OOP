using EnumsType.Enum;
using EnumsType.Models;

namespace EnumsType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User();
            user.KanGrubu = KanGrubu.ABRHN;
            MessageBox.Show(user.KanGrubu.ToString());
        }
    }
}