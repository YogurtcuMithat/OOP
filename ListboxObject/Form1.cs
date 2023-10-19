using ListboxObject.Models;

namespace ListboxObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = textBox1.Text;
            student.Surname = textBox2.Text;
            student.Age = Convert.ToInt32(textBox3.Text);
            //listBox1.Items.Add(student);
            List<Student> students = new List<Student>();
            students.Add(student);
            foreach (Student s in students)
            {
                listBox1.Items.Add($"Name: {s.Name}, Surname: {s.Surname}, Age: {s.Age}");
            }
        }
    }
}