namespace MigatteNoGokui
{
    partial class Rendimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendimiento));
            this.label_static_usocpu = new System.Windows.Forms.Label();
            this.circularProgressBarCPU = new CircularProgressBar.CircularProgressBar();
            this.label_static_ramdisponible = new System.Windows.Forms.Label();
            this.panel_InfoSystem = new System.Windows.Forms.Panel();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.label_static_voltage = new System.Windows.Forms.Label();
            this.labelClockSpeed = new System.Windows.Forms.Label();
            this.label_static_frecuencia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_temperatura = new System.Windows.Forms.Label();
            this.label_static_temperatura = new System.Windows.Forms.Label();
            this.label_estado_disco = new System.Windows.Forms.Label();
            this.label_static_estado_disco = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.label_static_nombreCpu = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelCores = new System.Windows.Forms.Label();
            this.label_static_ram = new System.Windows.Forms.Label();
            this.label_static_cores = new System.Windows.Forms.Label();
            this.label_infoSystem = new System.Windows.Forms.Label();
            this.circularProgressBarRam = new CircularProgressBar.CircularProgressBar();
            this.panel_InfoSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_static_usocpu
            // 
            this.label_static_usocpu.AutoSize = true;
            this.label_static_usocpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_usocpu.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_usocpu.Location = new System.Drawing.Point(586, 200);
            this.label_static_usocpu.Name = "label_static_usocpu";
            this.label_static_usocpu.Size = new System.Drawing.Size(86, 24);
            this.label_static_usocpu.TabIndex = 0;
            this.label_static_usocpu.Text = "Uso CPU";
            // 
            // circularProgressBarCPU
            // 
            this.circularProgressBarCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPU.AnimationSpeed = 500;
            this.circularProgressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarCPU.ForeColor = System.Drawing.Color.White;
            this.circularProgressBarCPU.InnerColor = System.Drawing.Color.DarkSlateGray;
            this.circularProgressBarCPU.InnerMargin = 2;
            this.circularProgressBarCPU.InnerWidth = -1;
            this.circularProgressBarCPU.Location = new System.Drawing.Point(536, 8);
            this.circularProgressBarCPU.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPU.Name = "circularProgressBarCPU";
            this.circularProgressBarCPU.OuterColor = System.Drawing.Color.CornflowerBlue;
            this.circularProgressBarCPU.OuterMargin = -25;
            this.circularProgressBarCPU.OuterWidth = 26;
            this.circularProgressBarCPU.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.circularProgressBarCPU.ProgressWidth = 25;
            this.circularProgressBarCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.circularProgressBarCPU.Size = new System.Drawing.Size(193, 189);
            this.circularProgressBarCPU.StartAngle = 270;
            this.circularProgressBarCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.circularProgressBarCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPU.SubscriptText = "%";
            this.circularProgressBarCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPU.SuperscriptText = "";
            this.circularProgressBarCPU.TabIndex = 3;
            this.circularProgressBarCPU.Text = "0";
            this.circularProgressBarCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPU.Value = 50;
            // 
            // label_static_ramdisponible
            // 
            this.label_static_ramdisponible.AutoSize = true;
            this.label_static_ramdisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_ramdisponible.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_ramdisponible.Location = new System.Drawing.Point(568, 424);
            this.label_static_ramdisponible.Name = "label_static_ramdisponible";
            this.label_static_ramdisponible.Size = new System.Drawing.Size(146, 24);
            this.label_static_ramdisponible.TabIndex = 2;
            this.label_static_ramdisponible.Text = "RAM Disponible";
            // 
            // panel_InfoSystem
            // 
            this.panel_InfoSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.panel_InfoSystem.Controls.Add(this.labelVoltage);
            this.panel_InfoSystem.Controls.Add(this.label_static_voltage);
            this.panel_InfoSystem.Controls.Add(this.labelClockSpeed);
            this.panel_InfoSystem.Controls.Add(this.label_static_frecuencia);
            this.panel_InfoSystem.Controls.Add(this.pictureBox1);
            this.panel_InfoSystem.Controls.Add(this.label_temperatura);
            this.panel_InfoSystem.Controls.Add(this.label_static_temperatura);
            this.panel_InfoSystem.Controls.Add(this.label_estado_disco);
            this.panel_InfoSystem.Controls.Add(this.label_static_estado_disco);
            this.panel_InfoSystem.Controls.Add(this.labelCPU);
            this.panel_InfoSystem.Controls.Add(this.label_static_nombreCpu);
            this.panel_InfoSystem.Controls.Add(this.labelRam);
            this.panel_InfoSystem.Controls.Add(this.labelCores);
            this.panel_InfoSystem.Controls.Add(this.label_static_ram);
            this.panel_InfoSystem.Controls.Add(this.label_static_cores);
            this.panel_InfoSystem.Controls.Add(this.label_infoSystem);
            this.panel_InfoSystem.Location = new System.Drawing.Point(77, 46);
            this.panel_InfoSystem.Name = "panel_InfoSystem";
            this.panel_InfoSystem.Size = new System.Drawing.Size(439, 392);
            this.panel_InfoSystem.TabIndex = 5;
            this.panel_InfoSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.ForeColor = System.Drawing.Color.White;
            this.labelVoltage.Location = new System.Drawing.Point(181, 168);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(0, 13);
            this.labelVoltage.TabIndex = 17;
            this.labelVoltage.Text = sistema.getProcessorInfo()[3];
            // 
            // label_static_voltage
            // 
            this.label_static_voltage.AutoSize = true;
            this.label_static_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_voltage.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_voltage.Location = new System.Drawing.Point(51, 164);
            this.label_static_voltage.Name = "label_static_voltage";
            this.label_static_voltage.Size = new System.Drawing.Size(60, 17);
            this.label_static_voltage.TabIndex = 16;
            this.label_static_voltage.Text = "Voltage:";
            // 
            // labelClockSpeed
            // 
            this.labelClockSpeed.AutoSize = true;
            this.labelClockSpeed.ForeColor = System.Drawing.Color.White;
            this.labelClockSpeed.Location = new System.Drawing.Point(181, 138);
            this.labelClockSpeed.Name = "labelClockSpeed";
            this.labelClockSpeed.Size = new System.Drawing.Size(0, 13);
            this.labelClockSpeed.TabIndex = 15;
            this.labelClockSpeed.Text = sistema.getProcessorInfo()[2];
            // 
            // label_static_frecuencia
            // 
            this.label_static_frecuencia.AutoSize = true;
            this.label_static_frecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_frecuencia.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_frecuencia.Location = new System.Drawing.Point(51, 134);
            this.label_static_frecuencia.Name = "label_static_frecuencia";
            this.label_static_frecuencia.Size = new System.Drawing.Size(82, 17);
            this.label_static_frecuencia.TabIndex = 14;
            this.label_static_frecuencia.Text = "Frecuencia:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label_temperatura
            // 
            this.label_temperatura.AutoSize = true;
            this.label_temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperatura.ForeColor = System.Drawing.SystemColors.Control;
            this.label_temperatura.Location = new System.Drawing.Point(181, 269);
            this.label_temperatura.Name = "label_temperatura";
            this.label_temperatura.Size = new System.Drawing.Size(52, 13);
            this.label_temperatura.TabIndex = 10;
            this.label_temperatura.Text = "Normal :v";
            // 
            // label_static_temperatura
            // 
            this.label_static_temperatura.AutoSize = true;
            this.label_static_temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_temperatura.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_temperatura.Location = new System.Drawing.Point(51, 269);
            this.label_static_temperatura.Name = "label_static_temperatura";
            this.label_static_temperatura.Size = new System.Drawing.Size(94, 17);
            this.label_static_temperatura.TabIndex = 9;
            this.label_static_temperatura.Text = "Temperatura:";
            // 
            // label_estado_disco
            // 
            this.label_estado_disco.AutoSize = true;
            this.label_estado_disco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado_disco.ForeColor = System.Drawing.SystemColors.Control;
            this.label_estado_disco.Location = new System.Drawing.Point(181, 242);
            this.label_estado_disco.Name = "label_estado_disco";
            this.label_estado_disco.Size = new System.Drawing.Size(38, 13);
            this.label_estado_disco.TabIndex = 8;
            this.label_estado_disco.Text = "Bueno";
            // 
            // label_static_estado_disco
            // 
            this.label_static_estado_disco.AutoSize = true;
            this.label_static_estado_disco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_estado_disco.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_estado_disco.Location = new System.Drawing.Point(51, 242);
            this.label_static_estado_disco.Name = "label_static_estado_disco";
            this.label_static_estado_disco.Size = new System.Drawing.Size(95, 17);
            this.label_static_estado_disco.TabIndex = 7;
            this.label_static_estado_disco.Text = "Estado Disco:";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.ForeColor = System.Drawing.Color.White;
            this.labelCPU.Location = new System.Drawing.Point(181, 108);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(0, 13);
            this.labelCPU.TabIndex = 6;
            this.labelCPU.Text = sistema.getProcessorInfo()[0];
            // 
            // label_static_nombreCpu
            // 
            this.label_static_nombreCpu.AutoSize = true;
            this.label_static_nombreCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_nombreCpu.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_nombreCpu.Location = new System.Drawing.Point(51, 108);
            this.label_static_nombreCpu.Name = "label_static_nombreCpu";
            this.label_static_nombreCpu.Size = new System.Drawing.Size(94, 17);
            this.label_static_nombreCpu.TabIndex = 5;
            this.label_static_nombreCpu.Text = "Nombre CPU:";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.ForeColor = System.Drawing.Color.White;
            this.labelRam.Location = new System.Drawing.Point(181, 220);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(0, 13);
            this.labelRam.TabIndex = 4;
            this.labelRam.Text = sistema.getRamVal().ToString() + "Mb";
            // 
            // labelCores
            // 
            this.labelCores.AutoSize = true;
            this.labelCores.ForeColor = System.Drawing.Color.White;
            this.labelCores.Location = new System.Drawing.Point(181, 195);
            this.labelCores.Name = "labelCores";
            this.labelCores.Size = new System.Drawing.Size(0, 13);
            this.labelCores.TabIndex = 3;
            this.labelCores.Text = sistema.getProcessorInfo()[1];
            // 
            // label_static_ram
            // 
            this.label_static_ram.AutoSize = true;
            this.label_static_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_ram.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_ram.Location = new System.Drawing.Point(51, 216);
            this.label_static_ram.Name = "label_static_ram";
            this.label_static_ram.Size = new System.Drawing.Size(41, 17);
            this.label_static_ram.TabIndex = 2;
            this.label_static_ram.Text = "Ram:";
            // 
            // label_static_cores
            // 
            this.label_static_cores.AutoSize = true;
            this.label_static_cores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_static_cores.ForeColor = System.Drawing.SystemColors.Control;
            this.label_static_cores.Location = new System.Drawing.Point(51, 191);
            this.label_static_cores.Name = "label_static_cores";
            this.label_static_cores.Size = new System.Drawing.Size(49, 17);
            this.label_static_cores.TabIndex = 1;
            this.label_static_cores.Text = "Cores:";
            // 
            // label_infoSystem
            // 
            this.label_infoSystem.AutoSize = true;
            this.label_infoSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoSystem.ForeColor = System.Drawing.SystemColors.Control;
            this.label_infoSystem.Location = new System.Drawing.Point(41, 39);
            this.label_infoSystem.Name = "label_infoSystem";
            this.label_infoSystem.Size = new System.Drawing.Size(230, 24);
            this.label_infoSystem.TabIndex = 0;
            this.label_infoSystem.Text = "Informacion del sistema";
            // 
            // circularProgressBarRam
            // 
            this.circularProgressBarRam.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarRam.AnimationSpeed = 500;
            this.circularProgressBarRam.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarRam.ForeColor = System.Drawing.Color.White;
            this.circularProgressBarRam.InnerColor = System.Drawing.Color.DarkSlateGray;
            this.circularProgressBarRam.InnerMargin = 2;
            this.circularProgressBarRam.InnerWidth = -1;
            this.circularProgressBarRam.Location = new System.Drawing.Point(536, 227);
            this.circularProgressBarRam.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarRam.Name = "circularProgressBarRam";
            this.circularProgressBarRam.OuterColor = System.Drawing.Color.MediumSpringGreen;
            this.circularProgressBarRam.OuterMargin = -25;
            this.circularProgressBarRam.OuterWidth = 26;
            this.circularProgressBarRam.ProgressColor = System.Drawing.Color.MediumSeaGreen;
            this.circularProgressBarRam.ProgressWidth = 25;
            this.circularProgressBarRam.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.circularProgressBarRam.Size = new System.Drawing.Size(193, 194);
            this.circularProgressBarRam.StartAngle = 270;
            this.circularProgressBarRam.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.circularProgressBarRam.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarRam.SubscriptText = "%";
            this.circularProgressBarRam.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBarRam.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarRam.SuperscriptText = "MB";
            this.circularProgressBarRam.TabIndex = 8;
            this.circularProgressBarRam.Text = "0000";
            this.circularProgressBarRam.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarRam.Value = 50;
            // 
            // Rendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circularProgressBarRam);
            this.Controls.Add(this.panel_InfoSystem);
            this.Controls.Add(this.circularProgressBarCPU);
            this.Controls.Add(this.label_static_ramdisponible);
            this.Controls.Add(this.label_static_usocpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rendimiento";
            this.Text = "Rendimiento";
            this.panel_InfoSystem.ResumeLayout(false);
            this.panel_InfoSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_static_usocpu;
        public  CircularProgressBar.CircularProgressBar circularProgressBarCPU;
        private System.Windows.Forms.Label label_static_ramdisponible;
        private System.Windows.Forms.Panel panel_InfoSystem;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label_static_nombreCpu;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelCores;
        private System.Windows.Forms.Label label_static_ram;
        private System.Windows.Forms.Label label_static_cores;
        private System.Windows.Forms.Label label_infoSystem;
        private System.Windows.Forms.Label label_temperatura;
        private System.Windows.Forms.Label label_static_temperatura;
        private System.Windows.Forms.Label label_estado_disco;
        private System.Windows.Forms.Label label_static_estado_disco;
        private System.Windows.Forms.PictureBox pictureBox1;
        public CircularProgressBar.CircularProgressBar circularProgressBarRam;
        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.Label label_static_voltage;
        private System.Windows.Forms.Label labelClockSpeed;
        private System.Windows.Forms.Label label_static_frecuencia;
    }
}