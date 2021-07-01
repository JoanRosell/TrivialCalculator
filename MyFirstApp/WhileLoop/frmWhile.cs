using MyFirstApp.ForEachLoop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.WhileLoop
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newStud = new Student
            {
                StudentId = Convert.ToInt32(txtStudentId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Age = Convert.ToInt32(txtStudentId.Text)
            };

            var students = new Dictionary<int, Student>
            {
                { newStud.StudentId, newStud }
            };

            int i = 0;
            while (i < students.Count)
            {
                var student = students.ElementAt(i).Value;
                if (student.Name == "Pepe")
                {
                    MessageBox.Show($"{student.Name} {student.Surname}");
                }
                i++;
            }
        }
    }
}
