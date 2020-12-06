namespace presentacionGUI
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCalculoPlanillas = new System.Windows.Forms.Button();
            this.btnRegistrarDomicilios = new System.Windows.Forms.Button();
            this.btnGestionarClientes = new System.Windows.Forms.Button();
            this.btnGestionDomiciliarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.MouseDetected = new System.Windows.Forms.Timer(this.components);
            this.listaDeLogos = new System.Windows.Forms.ImageList(this.components);
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(194)))));
            this.pnlMenu.Controls.Add(this.btnCalculoPlanillas);
            this.pnlMenu.Controls.Add(this.btnRegistrarDomicilios);
            this.pnlMenu.Controls.Add(this.btnGestionarClientes);
            this.pnlMenu.Controls.Add(this.btnGestionDomiciliarios);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(54, 743);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCalculoPlanillas
            // 
            this.btnCalculoPlanillas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculoPlanillas.FlatAppearance.BorderSize = 0;
            this.btnCalculoPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculoPlanillas.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCalculoPlanillas.Image = global::presentacionGUI.Properties.Resources.consumidor;
            this.btnCalculoPlanillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculoPlanillas.Location = new System.Drawing.Point(0, 270);
            this.btnCalculoPlanillas.Name = "btnCalculoPlanillas";
            this.btnCalculoPlanillas.Size = new System.Drawing.Size(54, 42);
            this.btnCalculoPlanillas.TabIndex = 11;
            this.btnCalculoPlanillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculoPlanillas.UseVisualStyleBackColor = true;
            this.btnCalculoPlanillas.Click += new System.EventHandler(this.btnCalculoPlanillas_Click);
            // 
            // btnRegistrarDomicilios
            // 
            this.btnRegistrarDomicilios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarDomicilios.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDomicilios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDomicilios.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRegistrarDomicilios.Image = global::presentacionGUI.Properties.Resources.servicio_al_cliente;
            this.btnRegistrarDomicilios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDomicilios.Location = new System.Drawing.Point(0, 228);
            this.btnRegistrarDomicilios.Name = "btnRegistrarDomicilios";
            this.btnRegistrarDomicilios.Size = new System.Drawing.Size(54, 42);
            this.btnRegistrarDomicilios.TabIndex = 12;
            this.btnRegistrarDomicilios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarDomicilios.UseVisualStyleBackColor = true;
            this.btnRegistrarDomicilios.Click += new System.EventHandler(this.btnRegistrarDomicilios_Click);
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarClientes.FlatAppearance.BorderSize = 0;
            this.btnGestionarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarClientes.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGestionarClientes.Image = global::presentacionGUI.Properties.Resources.cliente;
            this.btnGestionarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarClientes.Location = new System.Drawing.Point(0, 186);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(54, 42);
            this.btnGestionarClientes.TabIndex = 10;
            this.btnGestionarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarClientes.UseVisualStyleBackColor = true;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);
            // 
            // btnGestionDomiciliarios
            // 
            this.btnGestionDomiciliarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionDomiciliarios.FlatAppearance.BorderSize = 0;
            this.btnGestionDomiciliarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionDomiciliarios.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGestionDomiciliarios.Image = global::presentacionGUI.Properties.Resources.vespa__1_;
            this.btnGestionDomiciliarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionDomiciliarios.Location = new System.Drawing.Point(0, 144);
            this.btnGestionDomiciliarios.Name = "btnGestionDomiciliarios";
            this.btnGestionDomiciliarios.Size = new System.Drawing.Size(54, 42);
            this.btnGestionDomiciliarios.TabIndex = 9;
            this.btnGestionDomiciliarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionDomiciliarios.UseVisualStyleBackColor = true;
            this.btnGestionDomiciliarios.Click += new System.EventHandler(this.btnGestionDomiciliarios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnInicio.Image = global::presentacionGUI.Properties.Resources.pagina_principal;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 102);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(54, 42);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 102);
            this.panel3.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = global::presentacionGUI.Properties.Resources.a1252af9_6175_4ed5_9f83_6fdef74eb9f4_200x200;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(54, 102);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(54, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1266, 41);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(6, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HASS System";
            // 
            // MouseDetected
            // 
            this.MouseDetected.Enabled = true;
            this.MouseDetected.Tick += new System.EventHandler(this.MouseDetected_Tick);
            // 
            // listaDeLogos
            // 
            this.listaDeLogos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaDeLogos.ImageStream")));
            this.listaDeLogos.TransparentColor = System.Drawing.Color.Transparent;
            this.listaDeLogos.Images.SetKeyName(0, "87e89749-9e99-4f85-9cf2-5da8c9f9c644_200x200.png");
            this.listaDeLogos.Images.SetKeyName(1, "a1252af9-6175-4ed5-9f83-6fdef74eb9f4_200x200.png");
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.pnlPrincipal.Controls.Add(this.pictureBox1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.Location = new System.Drawing.Point(54, 41);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1266, 702);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::presentacionGUI.Properties.Resources._87e89749_9e99_4f85_9cf2_5da8c9f9c644_200x200;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(267, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 743);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPrincipal";
            this.Text = "HASS System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer MouseDetected;
        private System.Windows.Forms.ImageList listaDeLogos;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnCalculoPlanillas;
        private System.Windows.Forms.Button btnRegistrarDomicilios;
        private System.Windows.Forms.Button btnGestionarClientes;
        private System.Windows.Forms.Button btnGestionDomiciliarios;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

