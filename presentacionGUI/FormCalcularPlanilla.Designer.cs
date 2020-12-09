namespace presentacionGUI
{
    partial class FormCalcularPlanilla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonFiltro = new System.Windows.Forms.Button();
            this.TextIdDomiciliariofiltro = new System.Windows.Forms.ComboBox();
            this.DateTimeFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridPlanillas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlanillas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1016, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 720);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonFiltro);
            this.panel2.Controls.Add(this.TextIdDomiciliariofiltro);
            this.panel2.Controls.Add(this.DateTimeFechaFiltro);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 173);
            this.panel2.TabIndex = 22;
            // 
            // BotonFiltro
            // 
            this.BotonFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonFiltro.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.BotonFiltro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonFiltro.Location = new System.Drawing.Point(359, 109);
            this.BotonFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.BotonFiltro.Name = "BotonFiltro";
            this.BotonFiltro.Size = new System.Drawing.Size(205, 50);
            this.BotonFiltro.TabIndex = 26;
            this.BotonFiltro.Text = "Filtrar";
            this.BotonFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonFiltro.UseVisualStyleBackColor = true;
            this.BotonFiltro.Click += new System.EventHandler(this.BotonFiltro_Click);
            // 
            // TextIdDomiciliariofiltro
            // 
            this.TextIdDomiciliariofiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextIdDomiciliariofiltro.FormattingEnabled = true;
            this.TextIdDomiciliariofiltro.Items.AddRange(new object[] {
            "Todos"});
            this.TextIdDomiciliariofiltro.Location = new System.Drawing.Point(20, 59);
            this.TextIdDomiciliariofiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdDomiciliariofiltro.Name = "TextIdDomiciliariofiltro";
            this.TextIdDomiciliariofiltro.Size = new System.Drawing.Size(279, 24);
            this.TextIdDomiciliariofiltro.TabIndex = 10;
            // 
            // DateTimeFechaFiltro
            // 
            this.DateTimeFechaFiltro.Location = new System.Drawing.Point(337, 60);
            this.DateTimeFechaFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeFechaFiltro.Name = "DateTimeFechaFiltro";
            this.DateTimeFechaFiltro.Size = new System.Drawing.Size(265, 22);
            this.DateTimeFechaFiltro.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.label16.Location = new System.Drawing.Point(333, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 18);
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
            this.label15.Size = new System.Drawing.Size(147, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Filtrar por Domiciliario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtros Disponibles";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1016, 46);
            this.panel6.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista De Domiciliarios ";
            // 
            // DataGridPlanillas
            // 
            this.DataGridPlanillas.AllowUserToDeleteRows = false;
            this.DataGridPlanillas.AllowUserToOrderColumns = true;
            this.DataGridPlanillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPlanillas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridPlanillas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.DataGridPlanillas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridPlanillas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPlanillas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPlanillas.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridPlanillas.EnableHeadersVisualStyles = false;
            this.DataGridPlanillas.GridColor = System.Drawing.Color.CadetBlue;
            this.DataGridPlanillas.Location = new System.Drawing.Point(0, 46);
            this.DataGridPlanillas.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridPlanillas.Name = "DataGridPlanillas";
            this.DataGridPlanillas.ReadOnly = true;
            this.DataGridPlanillas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPlanillas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridPlanillas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridPlanillas.Size = new System.Drawing.Size(1016, 645);
            this.DataGridPlanillas.TabIndex = 19;
            // 
            // FormCalcularPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1645, 720);
            this.Controls.Add(this.DataGridPlanillas);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCalcularPlanilla";
            this.Text = "FormCalcularPlanilla";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlanillas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateTimeFechaFiltro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TextIdDomiciliariofiltro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView DataGridPlanillas;
        private System.Windows.Forms.Button BotonFiltro;
    }
}