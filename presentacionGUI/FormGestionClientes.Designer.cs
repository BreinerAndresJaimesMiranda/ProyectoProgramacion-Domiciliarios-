namespace presentacionGUI
{
    partial class FormGestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextDireccion = new System.Windows.Forms.TextBox();
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.TextIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonGuardarRegistro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridClientes = new System.Windows.Forms.DataGridView();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.TextDireccion);
            this.panel1.Controls.Add(this.TextTelefono);
            this.panel1.Controls.Add(this.TextIdentificacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BotonGuardarRegistro);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextApellido);
            this.panel1.Controls.Add(this.TextNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1038, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 768);
            this.panel1.TabIndex = 8;
            // 
            // TextDireccion
            // 
            this.TextDireccion.Location = new System.Drawing.Point(5, 254);
            this.TextDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextDireccion.Name = "TextDireccion";
            this.TextDireccion.Size = new System.Drawing.Size(215, 22);
            this.TextDireccion.TabIndex = 26;
            // 
            // TextTelefono
            // 
            this.TextTelefono.Location = new System.Drawing.Point(299, 254);
            this.TextTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(215, 22);
            this.TextTelefono.TabIndex = 25;
            // 
            // TextIdentificacion
            // 
            this.TextIdentificacion.Location = new System.Drawing.Point(8, 85);
            this.TextIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextIdentificacion.Name = "TextIdentificacion";
            this.TextIdentificacion.Size = new System.Drawing.Size(215, 22);
            this.TextIdentificacion.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Identificacion Del Cliente";
            // 
            // BotonGuardarRegistro
            // 
            this.BotonGuardarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonGuardarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonGuardarRegistro.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGuardarRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonGuardarRegistro.Image = global::presentacionGUI.Properties.Resources.flexible;
            this.BotonGuardarRegistro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonGuardarRegistro.Location = new System.Drawing.Point(424, 506);
            this.BotonGuardarRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonGuardarRegistro.Name = "BotonGuardarRegistro";
            this.BotonGuardarRegistro.Size = new System.Drawing.Size(189, 50);
            this.BotonGuardarRegistro.TabIndex = 21;
            this.BotonGuardarRegistro.Text = "Guardar Registro";
            this.BotonGuardarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonGuardarRegistro.UseVisualStyleBackColor = true;
            this.BotonGuardarRegistro.Click += new System.EventHandler(this.BotonGuardarRegistro_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(218)))));
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label8.Location = new System.Drawing.Point(7, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(573, 148);
            this.label8.TabIndex = 9;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label7.Location = new System.Drawing.Point(295, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefono Del Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label6.Location = new System.Drawing.Point(7, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Direccion Del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label5.Location = new System.Drawing.Point(295, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido Del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre Del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informacion Del Cliente";
            // 
            // TextApellido
            // 
            this.TextApellido.Location = new System.Drawing.Point(299, 164);
            this.TextApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(215, 22);
            this.TextApellido.TabIndex = 1;
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(5, 164);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(215, 22);
            this.TextNombre.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1038, 46);
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
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista De Clientes";
            // 
            // DataGridClientes
            // 
            this.DataGridClientes.AllowUserToDeleteRows = false;
            this.DataGridClientes.AllowUserToOrderColumns = true;
            this.DataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.DataGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridClientes.EnableHeadersVisualStyles = false;
            this.DataGridClientes.GridColor = System.Drawing.Color.CadetBlue;
            this.DataGridClientes.Location = new System.Drawing.Point(0, 46);
            this.DataGridClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridClientes.Name = "DataGridClientes";
            this.DataGridClientes.ReadOnly = true;
            this.DataGridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridClientes.Size = new System.Drawing.Size(1038, 374);
            this.DataGridClientes.TabIndex = 18;
            // 
            // lblRecordatorio
            // 
            this.lblRecordatorio.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordatorio.Location = new System.Drawing.Point(429, 506);
            this.lblRecordatorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(421, 50);
            this.lblRecordatorio.TabIndex = 21;
            this.lblRecordatorio.Text = "Recordatorio: Si desea modificar o eliminar un cliente  debe seleccionarlo primer" +
    "o.";
            this.lblRecordatorio.Visible = false;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(229)))));
            this.BotonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(229)))));
            this.BotonEliminar.Image = global::presentacionGUI.Properties.Resources.eliminar_usuario;
            this.BotonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonEliminar.Location = new System.Drawing.Point(212, 506);
            this.BotonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(189, 50);
            this.BotonEliminar.TabIndex = 20;
            this.BotonEliminar.Text = "Eliminar Registro";
            this.BotonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonEditar
            // 
            this.BotonEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(229)))));
            this.BotonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEditar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(229)))));
            this.BotonEditar.Image = global::presentacionGUI.Properties.Resources.pagina_de_inicio;
            this.BotonEditar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonEditar.Location = new System.Drawing.Point(13, 506);
            this.BotonEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(173, 50);
            this.BotonEditar.TabIndex = 19;
            this.BotonEditar.Text = "Editar Registro";
            this.BotonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonEditar.UseVisualStyleBackColor = true;
            this.BotonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // FormGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1667, 768);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonEditar);
            this.Controls.Add(this.DataGridClientes);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGestionClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormGestionClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonGuardarRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextApellido;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextIdentificacion;
        private System.Windows.Forms.TextBox TextDireccion;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridClientes;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonEditar;
    }
}