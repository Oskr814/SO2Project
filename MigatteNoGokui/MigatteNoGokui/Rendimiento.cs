using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            //Validar si ya se realizo el proceso de apagar los nucleos en caso de que sea oportuno
            sistema.validarEjecucion();
       


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
