﻿using System;
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

        //Instancia so2
        So2 sistema = new So2();

        Rendimiento rendimiento = new Rendimiento();

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
            {
                this.Container.Controls.RemoveAt(0);
            }
            this.Container.Controls.Add(panel_estado);
            panel_analisis.Visible = false;
            rendimiento.Visible = false;
            panel_estado.Show();

            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }
            panel_estado.Visible = false;
            panel_analisis.Visible = false;
            Form form = rendimiento as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Container.Controls.Add(form);
            this.Container.Tag = form;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }
            this.Container.Controls.Add(panel_analisis);
            panel_estado.Visible = false;
            panel_analisis.Visible = true;
            rendimiento.Visible = false;
            panel_analisis.Show();
            timerAnimation.Tick += new EventHandler(move);
            timerAnimation.Interval = 5;
            timerAnimation.Start();

            timerTextAnimation.Tick += new EventHandler(cambiarTexto);
            timerTextAnimation.Interval = 1000;
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
                    if (this.Container.Controls.Count > 0)
                    {
                        this.Container.Controls.RemoveAt(0);
                    }
                    this.Container.Controls.Add(panel_estado);
                    panel_analisis.Visible = false;
                    rendimiento.Visible = false;
                    panel_estado.Show();
                    Console.Write(sistema.getEstadoEjecucion());
                    timerTextAnimation.Stop();
                    timerAnimation.Stop();

                    if( sistema.getEstadoEjecucion() == 1)
                    {
                        sistema.ejecutarComando("shutdown /r");
                        sistema.setEstadoEjecucion("registro.mng", "estado,2");
                    }
                    vuelta = 1;
                    break;
                default:
                    break;
            }

        }
    }
}
