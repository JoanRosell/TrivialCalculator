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

namespace MyFirstApp.ForEachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newStud = new Student();
            newStud.StudentId = Convert.ToInt32(txtStudentId.Text);
            newStud.Name = txtName.Text;
            newStud.Surname = txtSurname.Text;
            newStud.Age = Convert.ToInt32(txtStudentId.Text);
            var studentList = new ArrayList();
            studentList.Add(newStud);

            foreach (Student student in studentList)
            {
                MessageBox.Show($"{student.Name} {student.Surname}");
            }
            
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
