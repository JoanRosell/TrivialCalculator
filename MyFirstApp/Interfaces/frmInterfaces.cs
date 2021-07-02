using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Interfaces
{
    public partial class frmInterfaces : Form
    {
        public frmInterfaces()
        {
            InitializeComponent();
        }

        private void frmInterfaces_Load(object sender, EventArgs e)
        {
            IVehiculo avion = new Avion();
            avion.Acelerar(10);

            ICloneable clonable = new Avion();
            clonable.Clone();
        }
    }
}
