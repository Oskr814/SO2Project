using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigatteNoGokui
{
    public partial class Rendimiento : Form
    {
        //instancia clase so2 
        So2 sistema = new So2();

        public Rendimiento()
        {
            InitializeComponent();
            sistema.validarEjecucion();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
