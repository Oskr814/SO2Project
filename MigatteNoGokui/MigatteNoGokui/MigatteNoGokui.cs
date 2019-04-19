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
using System.Management;
namespace MigatteNoGokui
{
    public partial class MigatteNoGokui : Form
    {   
        //Declaracion variables proceso analisis
        int vuelta = 1; //Contador proceso analisis
        
        //Timers
        System.Windows.Forms.Timer timerAnimation = new System.Windows.Forms.Timer(); //Temporizador para animacion progressbar
        System.Windows.Forms.Timer timerTextAnimation = new System.Windows.Forms.Timer(); //Temporizador animacion texto analisis  
        

        //Instancia so2
        So2 sistema = new So2();
        
        //Instancias para obtener el uso del cpu y la ram
        private PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter RAM = new PerformanceCounter("Memory", "Available MBytes");

        //Instancia clase rendimiento
        Rendimiento rendimiento = new Rendimiento();

        //Constructor
        public MigatteNoGokui()
        {
            InitializeComponent();
            migatteNoGokui();
            
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

        private void panel_analisis_Paint(object sender, PaintEventArgs e)
        {

        }

        //Minimizar
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            //Similar a programacion web, cambiar color de boton activo y inactivo
            this.btn_rendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            //Comprobar si hay elementos en el panel, remover todo
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }
            //Agregar panel estado
            this.Container.Controls.Add(panel_estado);
            panel_analisis.Visible = false;
            rendimiento.Visible = false;
            panel_estado.Show();
            
            //Para cancelar hilo ejecucion asincrono
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                //Cancelamos tarea asincrona
                backgroundWorker1.CancelAsync();

                //Para iniciar ver btne_rendimiento_Click
            }



        }

        /*Metodo para mostrar el panel de rendimiento*/
        private void btn_rendimiento_Click(object sender, EventArgs e)
        {
            //Similar a programacion web, cambiar color de boton activo y inactivo
            this.btnestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btn_rendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));

            //Comprobar si hay elementos en el panel, remover todo
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }

            //Ocultar paneles restantes
            panel_estado.Visible = false;
            panel_analisis.Visible = false;

            //Crear un Objeto Form para manipular las propiedades de un panel
            Form form = rendimiento as Form;
            //Especificamos que no es TopLevel: No es el panel padre, necesario.
            form.TopLevel = false;
            //Se utiliza para que cubra todo el espacio disponible del panel padre, se estira :v
            form.Dock = DockStyle.Fill;
            //Agregamos al panel padre
            this.Container.Controls.Add(form);
            this.Container.Tag = form;
            //Mostramos el panel, opcional: Lo hago por si se da el caso de que este en oculto
            form.Show();

            /*BackgroundWorker: Encargado de manipular los elementos de la interfaz, es un hilo
                No se permite que la interfaz sea manipulada por un hilo que no sea el creador
                Mediante este elemento se apunta al creador :v
            */

            //Comprobamos si esta libre, desocupado
            if (backgroundWorker1.IsBusy != true)
            {
                //Ejecutamos tarea asincrona, mediante dicho hilo.
                backgroundWorker1.RunWorkerAsync();

                //Para cancelar ver btnestado_Click
            }


        }

        /*Metodo para mostrar panel de analisis, simulacion busqueda de virus*/
        private void btn_analisis_Click(object sender, EventArgs e)
        {
            //Comprobar si hay elementos en el panel, verdadero: eliminar todo.
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }
            //Agregar panel analisis, usado para simular busqueda de virus :v
            this.Container.Controls.Add(panel_analisis);
            //Ocultar paneles restantes, para evitar cualquier inconveniente nada mas (opcional)
            panel_estado.Visible = false;
            panel_analisis.Visible = true;
            rendimiento.Visible = false;
            //Mostrar panel de analisis
            panel_analisis.Show();

            //Especificar que tarea sera ejecutada cada intervalo de tiempo.
            timerAnimation.Tick += new EventHandler(move);
            //Intervalo de tiempo en milisegundos.
            timerAnimation.Interval = 5;
            //Iniciar la ejecucion periodica
            timerAnimation.Start();

            //Especificar que tarea sera ejecutada cada intervalo de tiempo.
            timerTextAnimation.Tick += new EventHandler(cambiarTexto);
            //Intervalo de tiempo en milisegundos.
            timerTextAnimation.Interval = 1000;
            //Iniciar la ejecucion periodica
            timerTextAnimation.Start();

        }

        /*Metodo para simular movimiento de la barra de carga en el proceso de analisis*/
        void move(object sender, EventArgs e) 
        {
            int mover = 2; //Movimiento del objeto, unidad: pixels

            //cambiar posicion, mover hacia la izq
            panel_progressbar.Left += mover;

            //Comprobar si llego al tope en la izquierda, cambiar sentido
            if (panel_progressbar.Left > 253)
            {
                mover = -2;
            }

            //Comprobar si llego al tope en la derecha, cambiar sentido
            if (panel_progressbar.Left < 0)
            {
                mover = 2;
            }
        }

        //Metodo para simular un proceso de analisis de antivirus
        void cambiarTexto(object sender, EventArgs e)
        {
            //Cambiar texto secuencialmente
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
                //Volver al panel estado
                case 6:
                    if (this.Container.Controls.Count > 0)
                    {
                        this.Container.Controls.RemoveAt(0);
                    }
                    this.Container.Controls.Add(panel_estado);
                    panel_analisis.Visible = false;
                    rendimiento.Visible = false;
                    panel_estado.Show();
                    //Parar la ejecucion periodica
                    timerTextAnimation.Stop();
                    timerAnimation.Stop();

                    //Reiniciar maquina para aplicar cambios en los nucleos
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
        
        //Metodo encargado de hacer el trabajo asincrono mediante el BackgroundWorker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {   
            BackgroundWorker worker = sender as BackgroundWorker;

            //Mientras peticion de cancelacion tarea asincrona sea falsa
            while (worker.CancellationPending == false)
            {
                //Salir del ciclo si hay peticion de cancelacion
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                //Declaracion variables para asignar campos de CircularProgressBar
                int usoCpu;
                int usoRam;
                int usoRamMB;
                int totalRam = sistema.getRamVal(); //Memoria Ram total del sistema
                
                usoCpu = Convert.ToInt32(cpu.NextValue()); //Valor de uso del CPU
                usoRam = Convert.ToInt32(RAM.NextValue() / totalRam * 100); //Porcentaje libre
                usoRamMB = Convert.ToInt32(RAM.NextValue());

                //Delegar control a hilo asincrono
                try
                {
                    Invoke((MethodInvoker)delegate {

                        //Establecer valores 
                        rendimiento.circularProgressBarCPU.Value = usoCpu;
                        rendimiento.circularProgressBarCPU.Text = usoCpu.ToString();
                        rendimiento.circularProgressBarRam.Value = usoRam;
                        rendimiento.circularProgressBarRam.Text = usoRamMB.ToString();
                        rendimiento.circularProgressBarRam.SubscriptText = usoRam.ToString() + "%";
                        //Actualizar valores
                        rendimiento.circularProgressBarCPU.Update();
                        rendimiento.circularProgressBarRam.Update();
                    });
                    Thread.Sleep(1000); //Actualizar graficas cada segundo
                }
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }
  
        //Metodo para establecer un hilo en un nucleo
        private void migatteNoGokui()
        {
            //Creacion variable que contendra el hilo, asignando la tarea mediante una funcion de flecha
            var link = new Thread(() => //Hilo programacion concurrente, "secuestrar nucleos"
            {
                
                while( true )            
                {
                    
                    if( rendimiento.circularProgressBarCPU.Value > 50)
                    {
                        Console.WriteLine("Fin");
                        break;
                    }
                }
                
            }

            );

            link.Priority = ThreadPriority.Highest;
            link.Start();
        }

        private void MigatteNoGokui_Resize(object sender, EventArgs e)
        {
            //Si la aplicacion esta minimizada, ocultar y mostrar icono en System Tray
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
