namespace presentacionGUI
{
    partial class FormRegistrarDomicilios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.TextIdDomiciliario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextDestinoFinal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TextIdClienteFiltro = new System.Windows.Forms.ComboBox();
            this.TextIdDomiciliarioFiltro = new System.Windows.Forms.ComboBox();
            this.FechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumCosto = new System.Windows.Forms.NumericUpDown();
            this.TextIdCliente = new System.Windows.Forms.ComboBox();
            this.TextTelefonoCliente = new System.Windows.Forms.TextBox();
            this.TextDestinoInicial = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridServicios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCosto)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TextIdDomiciliario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TextDescripcion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TextDestinoFinal);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BotonGuardar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NumCosto);
            this.panel1.Controls.Add(this.TextIdCliente);
            this.panel1.Controls.Add(this.TextTelefonoCliente);
            this.panel1.Controls.Add(this.TextDestinoInicial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1016, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 720);
            this.panel1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label10.Location = new System.Drawing.Point(333, 523);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Seleccionar Domiciliario";
            // 
            // TextIdDomiciliario
            // 
            this.TextIdDomiciliario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextIdDomiciliario.FormattingEnabled = true;
            this.TextIdDomiciliario.Location = new System.Drawing.Point(332, 549);
            this.TextIdDomiciliario.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdDomiciliario.Name = "TextIdDomiciliario";
            this.TextIdDomiciliario.Size = new System.Drawing.Size(275, 24);
            this.TextIdDomiciliario.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label9.Location = new System.Drawing.Point(21, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Descripcion Del Domicilio";
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.Location = new System.Drawing.Point(24, 370);
            this.TextDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TextDescripcion.Multiline = true;
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Size = new System.Drawing.Size(579, 131);
            this.TextDescripcion.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label8.Location = new System.Drawing.Point(333, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Destino Final";
            // 
            // TextDestinoFinal
            // 
            this.TextDestinoFinal.Location = new System.Drawing.Point(336, 299);
            this.TextDestinoFinal.Margin = new System.Windows.Forms.Padding(4);
            this.TextDestinoFinal.Name = "TextDestinoFinal";
            this.TextDestinoFinal.Size = new System.Drawing.Size(271, 22);
            this.TextDestinoFinal.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F);
            this.label14.Location = new System.Drawing.Point(0, 158);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(413, 32);
            this.label14.TabIndex = 23;
            this.label14.Text = "Registrar Informacion Del Domicilio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonFiltrar);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.TextIdClienteFiltro);
            this.panel2.Controls.Add(this.TextIdDomiciliarioFiltro);
            this.panel2.Controls.Add(this.FechaFiltro);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 158);
            this.panel2.TabIndex = 22;
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonFiltrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonFiltrar.Location = new System.Drawing.Point(382, 104);
            this.BotonFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(189, 50);
            this.BotonFiltrar.TabIndex = 30;
            this.BotonFiltrar.Text = "Filtrar";
            this.BotonFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonFiltrar.UseVisualStyleBackColor = true;
            this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label17.Location = new System.Drawing.Point(21, 102);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(225, 22);
            this.label17.TabIndex = 12;
            this.label17.Text = "Filtrar por Cliente Registrado\r\n";
            // 
            // TextIdClienteFiltro
            // 
            this.TextIdClienteFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextIdClienteFiltro.FormattingEnabled = true;
            this.TextIdClienteFiltro.Items.AddRange(new object[] {
            "Todos",
            "No aplica"});
            this.TextIdClienteFiltro.Location = new System.Drawing.Point(20, 128);
            this.TextIdClienteFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdClienteFiltro.Name = "TextIdClienteFiltro";
            this.TextIdClienteFiltro.Size = new System.Drawing.Size(279, 24);
            this.TextIdClienteFiltro.TabIndex = 11;
            // 
            // TextIdDomiciliarioFiltro
            // 
            this.TextIdDomiciliarioFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextIdDomiciliarioFiltro.FormattingEnabled = true;
            this.TextIdDomiciliarioFiltro.Items.AddRange(new object[] {
            "Todos"});
            this.TextIdDomiciliarioFiltro.Location = new System.Drawing.Point(20, 59);
            this.TextIdDomiciliarioFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdDomiciliarioFiltro.Name = "TextIdDomiciliarioFiltro";
            this.TextIdDomiciliarioFiltro.Size = new System.Drawing.Size(279, 24);
            this.TextIdDomiciliarioFiltro.TabIndex = 10;
            // 
            // FechaFiltro
            // 
            this.FechaFiltro.Location = new System.Drawing.Point(337, 60);
            this.FechaFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.FechaFiltro.Name = "FechaFiltro";
            this.FechaFiltro.Size = new System.Drawing.Size(265, 22);
            this.FechaFiltro.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label16.Location = new System.Drawing.Point(333, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 22);
            this.label16.TabIndex = 8;
            this.label16.Text = "Filtrar por Fecha";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label15.Location = new System.Drawing.Point(16, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(256, 22);
            this.label15.TabIndex = 7;
            this.label15.Text = "Filtrar por Domiciliario Asignado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtros Disponibles";
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonGuardar.Image = global::presentacionGUI.Properties.Resources.flexible;
            this.BotonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonGuardar.Location = new System.Drawing.Point(424, 593);
            this.BotonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(189, 50);
            this.BotonGuardar.TabIndex = 21;
            this.BotonGuardar.Text = "Guardar Registro";
            this.BotonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label7.Location = new System.Drawing.Point(23, 523);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Costo Del Domicilio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label6.Location = new System.Drawing.Point(21, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Aplicar a Cliente Registrado\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label5.Location = new System.Drawing.Point(333, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono Del Cliente\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label4.Location = new System.Drawing.Point(21, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destino Inicial\r\n";
            // 
            // NumCosto
            // 
            this.NumCosto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumCosto.Location = new System.Drawing.Point(27, 549);
            this.NumCosto.Margin = new System.Windows.Forms.Padding(4);
            this.NumCosto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumCosto.Name = "NumCosto";
            this.NumCosto.Size = new System.Drawing.Size(216, 22);
            this.NumCosto.TabIndex = 3;
            // 
            // TextIdCliente
            // 
            this.TextIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextIdCliente.FormattingEnabled = true;
            this.TextIdCliente.Items.AddRange(new object[] {
            "No aplica"});
            this.TextIdCliente.Location = new System.Drawing.Point(20, 226);
            this.TextIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdCliente.Name = "TextIdCliente";
            this.TextIdCliente.Size = new System.Drawing.Size(275, 24);
            this.TextIdCliente.TabIndex = 2;
            // 
            // TextTelefonoCliente
            // 
            this.TextTelefonoCliente.Location = new System.Drawing.Point(337, 226);
            this.TextTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TextTelefonoCliente.Name = "TextTelefonoCliente";
            this.TextTelefonoCliente.Size = new System.Drawing.Size(265, 22);
            this.TextTelefonoCliente.TabIndex = 1;
            // 
            // TextDestinoInicial
            // 
            this.TextDestinoInicial.Location = new System.Drawing.Point(24, 299);
            this.TextDestinoInicial.Margin = new System.Windows.Forms.Padding(4);
            this.TextDestinoInicial.Name = "TextDestinoInicial";
            this.TextDestinoInicial.Size = new System.Drawing.Size(271, 22);
            this.TextDestinoInicial.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1016, 46);
            this.panel6.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista De Domicilios Realizados";
            // 
            // DataGridServicios
            // 
            this.DataGridServicios.AllowUserToDeleteRows = false;
            this.DataGridServicios.AllowUserToOrderColumns = true;
            this.DataGridServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.DataGridServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridServicios.EnableHeadersVisualStyles = false;
            this.DataGridServicios.GridColor = System.Drawing.Color.CadetBlue;
            this.DataGridServicios.Location = new System.Drawing.Point(0, 46);
            this.DataGridServicios.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridServicios.Name = "DataGridServicios";
            this.DataGridServicios.ReadOnly = true;
            this.DataGridServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridServicios.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridServicios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridServicios.Size = new System.Drawing.Size(1016, 393);
            this.DataGridServicios.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(218)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label1.Location = new System.Drawing.Point(3, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 148);
            this.label1.TabIndex = 19;
            this.label1.Text = "Recordatorio: \r\nSi en el campo \"Cliente Registrado\" aparece el texto \"No aplico\"," +
    " \r\nsignifica que domicilio no fue solicitado por un cliente registrado.\r\n";
            // 
            // BotonConsultar
            // 
            this.BotonConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(229)))));
            this.BotonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonConsultar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(229)))));
            this.BotonConsultar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonConsultar.Location = new System.Drawing.Point(349, 507);
            this.BotonConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonConsultar.Name = "BotonConsultar";
            this.BotonConsultar.Size = new System.Drawing.Size(173, 50);
            this.BotonConsultar.TabIndex = 23;
            this.BotonConsultar.Text = "Consultar Registros";
            this.BotonConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonConsultar.UseVisualStyleBackColor = true;
            this.BotonConsultar.Click += new System.EventHandler(this.BotonConsultar_Click);
            // 
            // FormRegistrarDomicilios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1645, 720);
            this.Controls.Add(this.BotonConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridServicios);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistrarDomicilios";
            this.Text = "FormRegistrarDomicilios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCosto)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumCosto;
        private System.Windows.Forms.ComboBox TextIdCliente;
        private System.Windows.Forms.TextBox TextTelefonoCliente;
        private System.Windows.Forms.TextBox TextDestinoInicial;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox TextIdClienteFiltro;
        private System.Windows.Forms.ComboBox TextIdDomiciliarioFiltro;
        private System.Windows.Forms.DateTimePicker FechaFiltro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextDestinoFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TextIdDomiciliario;
        private System.Windows.Forms.Button BotonConsultar;
        private System.Windows.Forms.Button BotonFiltrar;
    }
}