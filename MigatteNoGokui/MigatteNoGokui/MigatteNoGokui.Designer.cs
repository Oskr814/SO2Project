namespace MigatteNoGokui
{
    partial class MigatteNoGokui
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MigatteNoGokui));
            this.navbar = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label_nameLogo = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btn_rendimiento = new System.Windows.Forms.Button();
            this.panel_btnestado = new System.Windows.Forms.Panel();
            this.btnestado = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.label_grupo = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.panel_estado = new System.Windows.Forms.Panel();
            this.label_recomendacion = new System.Windows.Forms.Label();
            this.label_estadoSistema = new System.Windows.Forms.Label();
            this.btn_analisis = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_analisis = new System.Windows.Forms.Panel();
            this.labelProcesoAnalisis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_progressbar_container = new System.Windows.Forms.Panel();
            this.panel_progressbar = new System.Windows.Forms.Panel();
            this.label_analisis = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel_btnestado.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Container.SuspendLayout();
            this.panel_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_analisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_progressbar_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.navbar.Controls.Add(this.btn_minimizar);
            this.navbar.Controls.Add(this.label_nameLogo);
            this.navbar.Controls.Add(this.Logo);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Margin = new System.Windows.Forms.Padding(2);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(960, 36);
            this.navbar.TabIndex = 0;
            this.navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.BackgroundImage")));
            this.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Location = new System.Drawing.Point(924, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(36, 36);
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // label_nameLogo
            // 
            this.label_nameLogo.AutoSize = true;
            this.label_nameLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.label_nameLogo.Location = new System.Drawing.Point(53, 12);
            this.label_nameLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nameLogo.Name = "label_nameLogo";
            this.label_nameLogo.Size = new System.Drawing.Size(88, 13);
            this.label_nameLogo.TabIndex = 1;
            this.label_nameLogo.Text = "Migatte no Gokui";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(4, -3);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(60, 44);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.sidebar.Controls.Add(this.btn_rendimiento);
            this.sidebar.Controls.Add(this.panel_btnestado);
            this.sidebar.Controls.Add(this.label_version);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 36);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(137, 526);
            this.sidebar.TabIndex = 1;
            // 
            // btn_rendimiento
            // 
            this.btn_rendimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rendimiento.FlatAppearance.BorderSize = 0;
            this.btn_rendimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rendimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rendimiento.Image = ((System.Drawing.Image)(resources.GetObject("btn_rendimiento.Image")));
            this.btn_rendimiento.Location = new System.Drawing.Point(0, 98);
            this.btn_rendimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rendimiento.Name = "btn_rendimiento";
            this.btn_rendimiento.Size = new System.Drawing.Size(137, 95);
            this.btn_rendimiento.TabIndex = 3;
            this.btn_rendimiento.Text = "Rendimiento";
            this.btn_rendimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rendimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rendimiento.UseVisualStyleBackColor = true;
            this.btn_rendimiento.Click += new System.EventHandler(this.btn_rendimiento_Click);
            // 
            // panel_btnestado
            // 
            this.panel_btnestado.Controls.Add(this.btnestado);
            this.panel_btnestado.Location = new System.Drawing.Point(2, -1);
            this.panel_btnestado.Margin = new System.Windows.Forms.Padding(2);
            this.panel_btnestado.Name = "panel_btnestado";
            this.panel_btnestado.Size = new System.Drawing.Size(135, 97);
            this.panel_btnestado.TabIndex = 3;
            // 
            // btnestado
            // 
            this.btnestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            this.btnestado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnestado.FlatAppearance.BorderSize = 0;
            this.btnestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnestado.Image = ((System.Drawing.Image)(resources.GetObject("btnestado.Image")));
            this.btnestado.Location = new System.Drawing.Point(0, 0);
            this.btnestado.Margin = new System.Windows.Forms.Padding(2);
            this.btnestado.Name = "btnestado";
            this.btnestado.Size = new System.Drawing.Size(135, 95);
            this.btnestado.TabIndex = 2;
            this.btnestado.Text = "Estado";
            this.btnestado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnestado.UseVisualStyleBackColor = true;
            this.btnestado.Click += new System.EventHandler(this.btnestado_Click);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.ForeColor = System.Drawing.SystemColors.Control;
            this.label_version.Location = new System.Drawing.Point(33, 504);
            this.label_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(60, 13);
            this.label_version.TabIndex = 0;
            this.label_version.Text = "Version 1.0";
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            this.Footer.Controls.Add(this.label_grupo);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(137, 526);
            this.Footer.Margin = new System.Windows.Forms.Padding(2);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(823, 36);
            this.Footer.TabIndex = 2;
            // 
            // label_grupo
            // 
            this.label_grupo.AutoSize = true;
            this.label_grupo.Font = new System.Drawing.Font("Sitka Banner", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grupo.ForeColor = System.Drawing.SystemColors.Control;
            this.label_grupo.Location = new System.Drawing.Point(364, 12);
            this.label_grupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_grupo.Name = "label_grupo";
            this.label_grupo.Size = new System.Drawing.Size(96, 16);
            this.label_grupo.TabIndex = 0;
            this.label_grupo.Text = "Grupo Los Saiyajin";
            this.label_grupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Container.Controls.Add(this.panel_estado);
            this.Container.Controls.Add(this.panel_analisis);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(137, 36);
            this.Container.Margin = new System.Windows.Forms.Padding(2);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(823, 490);
            this.Container.TabIndex = 0;
            this.Container.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Paint);
            // 
            // panel_estado
            // 
            this.panel_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.panel_estado.Controls.Add(this.label_recomendacion);
            this.panel_estado.Controls.Add(this.label_estadoSistema);
            this.panel_estado.Controls.Add(this.btn_analisis);
            this.panel_estado.Controls.Add(this.pictureBox3);
            this.panel_estado.Location = new System.Drawing.Point(204, 62);
            this.panel_estado.Margin = new System.Windows.Forms.Padding(2);
            this.panel_estado.Name = "panel_estado";
            this.panel_estado.Size = new System.Drawing.Size(392, 327);
            this.panel_estado.TabIndex = 2;
            // 
            // label_recomendacion
            // 
            this.label_recomendacion.AutoSize = true;
            this.label_recomendacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_recomendacion.ForeColor = System.Drawing.SystemColors.Control;
            this.label_recomendacion.Location = new System.Drawing.Point(36, 241);
            this.label_recomendacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_recomendacion.Name = "label_recomendacion";
            this.label_recomendacion.Size = new System.Drawing.Size(310, 26);
            this.label_recomendacion.TabIndex = 3;
            this.label_recomendacion.Text = "Analizar el equipo en busca de posibles amenazas, esto permite \r\nmanterner el ord" +
    "enador en optimas condiciones.";
            this.label_recomendacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_estadoSistema
            // 
            this.label_estadoSistema.AutoSize = true;
            this.label_estadoSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estadoSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(220)))), ((int)(((byte)(107)))));
            this.label_estadoSistema.Location = new System.Drawing.Point(128, 152);
            this.label_estadoSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_estadoSistema.Name = "label_estadoSistema";
            this.label_estadoSistema.Size = new System.Drawing.Size(141, 24);
            this.label_estadoSistema.TabIndex = 2;
            this.label_estadoSistema.Text = "Estas Protegido";
            // 
            // btn_analisis
            // 
            this.btn_analisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(220)))), ((int)(((byte)(107)))));
            this.btn_analisis.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_analisis.FlatAppearance.BorderSize = 0;
            this.btn_analisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analisis.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analisis.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_analisis.Location = new System.Drawing.Point(131, 187);
            this.btn_analisis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_analisis.Name = "btn_analisis";
            this.btn_analisis.Size = new System.Drawing.Size(131, 33);
            this.btn_analisis.TabIndex = 1;
            this.btn_analisis.Text = "Analisar ahora";
            this.btn_analisis.UseVisualStyleBackColor = false;
            this.btn_analisis.Click += new System.EventHandler(this.btn_analisis_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, 44);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel_analisis
            // 
            this.panel_analisis.Controls.Add(this.labelProcesoAnalisis);
            this.panel_analisis.Controls.Add(this.pictureBox1);
            this.panel_analisis.Controls.Add(this.panel_progressbar_container);
            this.panel_analisis.Controls.Add(this.label_analisis);
            this.panel_analisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_analisis.Location = new System.Drawing.Point(0, 0);
            this.panel_analisis.Name = "panel_analisis";
            this.panel_analisis.Size = new System.Drawing.Size(823, 490);
            this.panel_analisis.TabIndex = 3;
            this.panel_analisis.Visible = false;
            this.panel_analisis.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_analisis_Paint);
            // 
            // labelProcesoAnalisis
            // 
            this.labelProcesoAnalisis.AutoSize = true;
            this.labelProcesoAnalisis.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProcesoAnalisis.Location = new System.Drawing.Point(351, 284);
            this.labelProcesoAnalisis.Name = "labelProcesoAnalisis";
            this.labelProcesoAnalisis.Size = new System.Drawing.Size(94, 13);
            this.labelProcesoAnalisis.TabIndex = 5;
            this.labelProcesoAnalisis.Text = "Por favor espere...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel_progressbar_container
            // 
            this.panel_progressbar_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_progressbar_container.Controls.Add(this.panel_progressbar);
            this.panel_progressbar_container.Location = new System.Drawing.Point(243, 260);
            this.panel_progressbar_container.Name = "panel_progressbar_container";
            this.panel_progressbar_container.Size = new System.Drawing.Size(333, 5);
            this.panel_progressbar_container.TabIndex = 3;
            // 
            // panel_progressbar
            // 
            this.panel_progressbar.BackColor = System.Drawing.Color.Cyan;
            this.panel_progressbar.Location = new System.Drawing.Point(253, 0);
            this.panel_progressbar.Name = "panel_progressbar";
            this.panel_progressbar.Size = new System.Drawing.Size(80, 5);
            this.panel_progressbar.TabIndex = 2;
            // 
            // label_analisis
            // 
            this.label_analisis.AutoSize = true;
            this.label_analisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_analisis.ForeColor = System.Drawing.SystemColors.Control;
            this.label_analisis.Location = new System.Drawing.Point(239, 225);
            this.label_analisis.Name = "label_analisis";
            this.label_analisis.Size = new System.Drawing.Size(344, 20);
            this.label_analisis.TabIndex = 2;
            this.label_analisis.Text = "Analizando el sistema en busca de virus...";
            this.label_analisis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Migatte no Gokui";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // MigatteNoGokui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(960, 562);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MigatteNoGokui";
            this.Text = "Migatte no Gokui";
            this.Resize += new System.EventHandler(this.MigatteNoGokui_Resize);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel_btnestado.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.Container.ResumeLayout(false);
            this.panel_estado.ResumeLayout(false);
            this.panel_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_analisis.ResumeLayout(false);
            this.panel_analisis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_progressbar_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel Footer;
        public System.Windows.Forms.Panel Container;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_nameLogo;
        private System.Windows.Forms.Label label_grupo;
        private System.Windows.Forms.Button btnestado;
        private System.Windows.Forms.Button btn_rendimiento;
        private System.Windows.Forms.Panel panel_btnestado;
        private System.Windows.Forms.Button btn_minimizar;
        public System.Windows.Forms.Panel panel_estado;
        private System.Windows.Forms.Label label_recomendacion;
        private System.Windows.Forms.Label label_estadoSistema;
        private System.Windows.Forms.Button btn_analisis;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_analisis;
        private System.Windows.Forms.Panel panel_progressbar_container;
        private System.Windows.Forms.Panel panel_progressbar;
        private System.Windows.Forms.Label label_analisis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProcesoAnalisis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}



