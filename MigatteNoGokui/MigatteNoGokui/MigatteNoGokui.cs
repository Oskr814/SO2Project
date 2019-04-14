using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigatteNoGokui
{
    public partial class MigatteNoGokui : Form
    {   
        //Inicio Declaracion variables proceso analisis
        int vuelta = 1; //Contador proceso analisis
        int mover = 1; //Movimiento del objeto, unidad: pixels
        //Timers
        System.Windows.Forms.Timer timerAnimation = new System.Windows.Forms.Timer(); //Temporizador para animacion progressbar
        System.Windows.Forms.Timer timerTextAnimation = new System.Windows.Forms.Timer(); //Temporizador animacion texto analisis
        //Fin Declaracion variables proceso analisis

        //Instancia analisis: clase para hacer la animacion del proceso de analisis de virus.
        
        public MigatteNoGokui()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            if (this.Container.Controls.Count > 0)
                this.Container.Controls.RemoveAt(0);
            this.Container.Controls.Add(panel_estado);
            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }
            Rendimiento rendimiento = new Rendimiento();
            Form form = rendimiento as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Container.Controls.Add(form);
            this.Container.Tag = form;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Container.Controls.RemoveAt(0);
            this.Container.Controls.Add(panel_analisis);
            panel_analisis.Show();
            timerAnimation.Tick += new EventHandler(move);
            timerAnimation.Interval = 5;
            timerAnimation.Start();

            timerTextAnimation.Tick += new EventHandler(cambiarTexto);
            timerTextAnimation.Interval = 5000;
            timerTextAnimation.Start();
            

        }
        
        
        void move(object sender, EventArgs e)
        {
            panel_progressbar.Left += mover;

            if (panel_progressbar.Left > 253)
            {
                mover = -2;
            }

            if (panel_progressbar.Left < 0)
            {
                mover = 2;
            }
        }

        void cambiarTexto(object sender, EventArgs e)
        {
            switch (vuelta)
            {
                case 1:
                    label_analisis.Text = "Iniciando rutinas de  analisis...";
                    vuelta++;
                    break;
                case 2:
                    label_analisis.Text = "Virus detectado, iniciando Kame hame haaaa!";
                    vuelta++;
                    break;
                case 3:
                    label_analisis.Text = "Amenaza eliminada!";
                    vuelta++;
                    break;
                case 4:
                    label_analisis.Text = "Maldito Freezer!";
                    vuelta++;
                    break;
                case 5:
                    label_analisis.Text = "Analisis completado, sistema libre de amenazas";
                    vuelta++;
                    break;
                case 6:
                    this.Container.Controls.RemoveAt(0);
                    this.Container.Controls.Add(panel_estado);
                    timerTextAnimation.Stop();
                    timerAnimation.Stop();
                    vuelta = 1;
                    break;
                default:
                    break;
            }

        }
    }
}
