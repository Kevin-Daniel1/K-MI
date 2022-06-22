using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_MI
{
    public partial class kmi : Form
    {
        public kmi()
        {
            InitializeComponent();
        }

        private void buscarLibros_Click(object sender, EventArgs e)
        {
            var busqueda = new Busqueda();
            busqueda.ShowDialog();
        }
    }
}
