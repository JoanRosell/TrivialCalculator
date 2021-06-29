using MyFirstApp.ForEachLoop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.forLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newStud = new Student();
            newStud.StudentId = Convert.ToInt32(txtStudentId.Text);
            newStud.Name = txtName.Text;
            newStud.Surname = txtSurname.Text;
            newStud.Age = Convert.ToInt32(txtStudentId.Text);
            var studentList = new List<Student>
            {
                newStud
            };

            for (int i = 0; i < studentList.Count; i++)
            {
                var student = studentList[i];
                MessageBox.Show($"{student.Name} {student.Surname}");
            }
        }
    }
}
