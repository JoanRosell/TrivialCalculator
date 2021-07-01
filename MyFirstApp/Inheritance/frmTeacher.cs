using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Inheritance
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Name = "Pepe",
                Surname = "Soto",
                Subject = "Programación",
                Salary = 40000f,
            };

            MessageBox.Show($"Name: {teacher.Name}\nSurname: {teacher.Surname}\nSubject: {teacher.Subject}\nSalary: {teacher.Salary}");
            Person person = new Teacher() // Upcasting from Teacher to Person
            {
                Name = "Bob",
                Surname = "Ross",
                Subject = "Fine Arts",
                Salary = 40000f
            };

            // Unboxing (AKA cast or downcast)
            string bobSubject = ((Teacher)person).Subject;
            float bobSalary = ((Teacher)person).Salary;
            MessageBox.Show($"Name: {person.Name}\nSurname: {person.Surname}\nSubject: {bobSubject}\nSalary: {bobSalary}");
        }
    }
}
