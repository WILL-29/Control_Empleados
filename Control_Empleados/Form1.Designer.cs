namespace Control_Empleados
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ID_LB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.Ced_TB = new System.Windows.Forms.TextBox();
            this.Ced_LB = new System.Windows.Forms.Label();
            this.Nombre_TB = new System.Windows.Forms.TextBox();
            this.Nombre_LB = new System.Windows.Forms.Label();
            this.FechaNac_LB = new System.Windows.Forms.Label();
            this.Direccion_TB = new System.Windows.Forms.TextBox();
            this.Direccion_LB = new System.Windows.Forms.Label();
            this.FechaNac_Date = new System.Windows.Forms.DateTimePicker();
            this.Departa_TB = new System.Windows.Forms.TextBox();
            this.Depart_LB = new System.Windows.Forms.Label();
            this.Puesto_TB = new System.Windows.Forms.TextBox();
            this.Puesto_LB = new System.Windows.Forms.Label();
            this.FechaIng_Date = new System.Windows.Forms.DateTimePicker();
            this.FechaIng_LB = new System.Windows.Forms.Label();
            this.Supervi_TB = new System.Windows.Forms.TextBox();
            this.Supervi_LB = new System.Windows.Forms.Label();
            this.Sueldo_TB = new System.Windows.Forms.TextBox();
            this.Sueldo_LB = new System.Windows.Forms.Label();
            this.Estado_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FotoSel_BT = new System.Windows.Forms.Button();
            this.Registrar_BT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Consul_BT = new System.Windows.Forms.Button();
            this.GuardarMod_BT = new System.Windows.Forms.Button();
            this.Limpiar_BT = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminar_BT = new System.Windows.Forms.Button();
            this.Reporte_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_LB
            // 
            this.ID_LB.AutoSize = true;
            this.ID_LB.Location = new System.Drawing.Point(168, 31);
            this.ID_LB.Name = "ID_LB";
            this.ID_LB.Size = new System.Drawing.Size(85, 13);
            this.ID_LB.TabIndex = 0;
            this.ID_LB.Text = "ID del Empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(28, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ID_TB
            // 
            this.ID_TB.Enabled = false;
            this.ID_TB.Location = new System.Drawing.Point(276, 24);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.ReadOnly = true;
            this.ID_TB.Size = new System.Drawing.Size(147, 20);
            this.ID_TB.TabIndex = 2;
            // 
            // Ced_TB
            // 
            this.Ced_TB.Location = new System.Drawing.Point(276, 51);
            this.Ced_TB.Name = "Ced_TB";
            this.Ced_TB.Size = new System.Drawing.Size(147, 20);
            this.Ced_TB.TabIndex = 1;
            // 
            // Ced_LB
            // 
            this.Ced_LB.AutoSize = true;
            this.Ced_LB.Location = new System.Drawing.Point(168, 58);
            this.Ced_LB.Name = "Ced_LB";
            this.Ced_LB.Size = new System.Drawing.Size(40, 13);
            this.Ced_LB.TabIndex = 3;
            this.Ced_LB.Text = "Cédula";
            // 
            // Nombre_TB
            // 
            this.Nombre_TB.Location = new System.Drawing.Point(276, 77);
            this.Nombre_TB.Name = "Nombre_TB";
            this.Nombre_TB.Size = new System.Drawing.Size(147, 20);
            this.Nombre_TB.TabIndex = 2;
            // 
            // Nombre_LB
            // 
            this.Nombre_LB.AutoSize = true;
            this.Nombre_LB.Location = new System.Drawing.Point(168, 84);
            this.Nombre_LB.Name = "Nombre_LB";
            this.Nombre_LB.Size = new System.Drawing.Size(44, 13);
            this.Nombre_LB.TabIndex = 5;
            this.Nombre_LB.Text = "Nombre";
            // 
            // FechaNac_LB
            // 
            this.FechaNac_LB.AutoSize = true;
            this.FechaNac_LB.Location = new System.Drawing.Point(168, 108);
            this.FechaNac_LB.Name = "FechaNac_LB";
            this.FechaNac_LB.Size = new System.Drawing.Size(108, 13);
            this.FechaNac_LB.TabIndex = 7;
            this.FechaNac_LB.Text = "Fecha de Nacimiento";
            // 
            // Direccion_TB
            // 
            this.Direccion_TB.Location = new System.Drawing.Point(276, 128);
            this.Direccion_TB.Name = "Direccion_TB";
            this.Direccion_TB.Size = new System.Drawing.Size(147, 20);
            this.Direccion_TB.TabIndex = 4;
            // 
            // Direccion_LB
            // 
            this.Direccion_LB.AutoSize = true;
            this.Direccion_LB.Location = new System.Drawing.Point(168, 135);
            this.Direccion_LB.Name = "Direccion_LB";
            this.Direccion_LB.Size = new System.Drawing.Size(52, 13);
            this.Direccion_LB.TabIndex = 9;
            this.Direccion_LB.Text = "Dirección";
            // 
            // FechaNac_Date
            // 
            this.FechaNac_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNac_Date.Location = new System.Drawing.Point(276, 102);
            this.FechaNac_Date.Name = "FechaNac_Date";
            this.FechaNac_Date.Size = new System.Drawing.Size(147, 20);
            this.FechaNac_Date.TabIndex = 3;
            // 
            // Departa_TB
            // 
            this.Departa_TB.Location = new System.Drawing.Point(276, 159);
            this.Departa_TB.Name = "Departa_TB";
            this.Departa_TB.Size = new System.Drawing.Size(147, 20);
            this.Departa_TB.TabIndex = 5;
            // 
            // Depart_LB
            // 
            this.Depart_LB.AutoSize = true;
            this.Depart_LB.Location = new System.Drawing.Point(168, 166);
            this.Depart_LB.Name = "Depart_LB";
            this.Depart_LB.Size = new System.Drawing.Size(74, 13);
            this.Depart_LB.TabIndex = 12;
            this.Depart_LB.Text = "Departamento";
            // 
            // Puesto_TB
            // 
            this.Puesto_TB.Location = new System.Drawing.Point(276, 184);
            this.Puesto_TB.Name = "Puesto_TB";
            this.Puesto_TB.Size = new System.Drawing.Size(147, 20);
            this.Puesto_TB.TabIndex = 6;
            // 
            // Puesto_LB
            // 
            this.Puesto_LB.AutoSize = true;
            this.Puesto_LB.Location = new System.Drawing.Point(168, 191);
            this.Puesto_LB.Name = "Puesto_LB";
            this.Puesto_LB.Size = new System.Drawing.Size(40, 13);
            this.Puesto_LB.TabIndex = 14;
            this.Puesto_LB.Text = "Puesto";
            // 
            // FechaIng_Date
            // 
            this.FechaIng_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaIng_Date.Location = new System.Drawing.Point(276, 243);
            this.FechaIng_Date.Name = "FechaIng_Date";
            this.FechaIng_Date.Size = new System.Drawing.Size(147, 20);
            this.FechaIng_Date.TabIndex = 8;
            // 
            // FechaIng_LB
            // 
            this.FechaIng_LB.AutoSize = true;
            this.FechaIng_LB.Location = new System.Drawing.Point(168, 249);
            this.FechaIng_LB.Name = "FechaIng_LB";
            this.FechaIng_LB.Size = new System.Drawing.Size(90, 13);
            this.FechaIng_LB.TabIndex = 16;
            this.FechaIng_LB.Text = "Fecha de Ingreso";
            // 
            // Supervi_TB
            // 
            this.Supervi_TB.Location = new System.Drawing.Point(276, 214);
            this.Supervi_TB.Name = "Supervi_TB";
            this.Supervi_TB.Size = new System.Drawing.Size(147, 20);
            this.Supervi_TB.TabIndex = 7;
            // 
            // Supervi_LB
            // 
            this.Supervi_LB.AutoSize = true;
            this.Supervi_LB.Location = new System.Drawing.Point(168, 221);
            this.Supervi_LB.Name = "Supervi_LB";
            this.Supervi_LB.Size = new System.Drawing.Size(69, 13);
            this.Supervi_LB.TabIndex = 18;
            this.Supervi_LB.Text = "Líder Directo";
            // 
            // Sueldo_TB
            // 
            this.Sueldo_TB.Location = new System.Drawing.Point(276, 271);
            this.Sueldo_TB.Name = "Sueldo_TB";
            this.Sueldo_TB.Size = new System.Drawing.Size(147, 20);
            this.Sueldo_TB.TabIndex = 9;
            // 
            // Sueldo_LB
            // 
            this.Sueldo_LB.AutoSize = true;
            this.Sueldo_LB.Location = new System.Drawing.Point(168, 278);
            this.Sueldo_LB.Name = "Sueldo_LB";
            this.Sueldo_LB.Size = new System.Drawing.Size(40, 13);
            this.Sueldo_LB.TabIndex = 20;
            this.Sueldo_LB.Text = "Sueldo";
            // 
            // Estado_TB
            // 
            this.Estado_TB.Location = new System.Drawing.Point(276, 300);
            this.Estado_TB.Name = "Estado_TB";
            this.Estado_TB.Size = new System.Drawing.Size(147, 20);
            this.Estado_TB.TabIndex = 10;
            this.Estado_TB.TextChanged += new System.EventHandler(this.Estado_TB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Estado";
            // 
            // FotoSel_BT
            // 
            this.FotoSel_BT.Location = new System.Drawing.Point(28, 182);
            this.FotoSel_BT.Name = "FotoSel_BT";
            this.FotoSel_BT.Size = new System.Drawing.Size(125, 23);
            this.FotoSel_BT.TabIndex = 11;
            this.FotoSel_BT.Text = "Seleccionar foto";
            this.FotoSel_BT.UseVisualStyleBackColor = true;
            this.FotoSel_BT.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registrar_BT
            // 
            this.Registrar_BT.Location = new System.Drawing.Point(28, 223);
            this.Registrar_BT.Name = "Registrar_BT";
            this.Registrar_BT.Size = new System.Drawing.Size(125, 23);
            this.Registrar_BT.TabIndex = 12;
            this.Registrar_BT.Text = "Registrar Empleados";
            this.Registrar_BT.UseVisualStyleBackColor = true;
            this.Registrar_BT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(476, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 296);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Consul_BT
            // 
            this.Consul_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Consul_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Consul_BT.Location = new System.Drawing.Point(476, 340);
            this.Consul_BT.Name = "Consul_BT";
            this.Consul_BT.Size = new System.Drawing.Size(113, 23);
            this.Consul_BT.TabIndex = 13;
            this.Consul_BT.Text = "Consultar";
            this.Consul_BT.UseVisualStyleBackColor = true;
            this.Consul_BT.Click += new System.EventHandler(this.Consul_BT_Click);
            // 
            // GuardarMod_BT
            // 
            this.GuardarMod_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuardarMod_BT.Location = new System.Drawing.Point(595, 340);
            this.GuardarMod_BT.Name = "GuardarMod_BT";
            this.GuardarMod_BT.Size = new System.Drawing.Size(102, 23);
            this.GuardarMod_BT.TabIndex = 14;
            this.GuardarMod_BT.Text = "Guardar Cambios";
            this.GuardarMod_BT.UseVisualStyleBackColor = true;
            this.GuardarMod_BT.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Limpiar_BT
            // 
            this.Limpiar_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Limpiar_BT.Location = new System.Drawing.Point(788, 340);
            this.Limpiar_BT.Name = "Limpiar_BT";
            this.Limpiar_BT.Size = new System.Drawing.Size(79, 23);
            this.Limpiar_BT.TabIndex = 15;
            this.Limpiar_BT.Text = "Limpiar";
            this.Limpiar_BT.UseVisualStyleBackColor = true;
            this.Limpiar_BT.Click += new System.EventHandler(this.Limpiar_BT_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Eliminar_BT
            // 
            this.Eliminar_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Eliminar_BT.Location = new System.Drawing.Point(703, 340);
            this.Eliminar_BT.Name = "Eliminar_BT";
            this.Eliminar_BT.Size = new System.Drawing.Size(79, 23);
            this.Eliminar_BT.TabIndex = 27;
            this.Eliminar_BT.Text = "Eliminar";
            this.Eliminar_BT.UseVisualStyleBackColor = true;
            this.Eliminar_BT.Click += new System.EventHandler(this.Eliminar_BT_Click);
            // 
            // Reporte_BT
            // 
            this.Reporte_BT.Location = new System.Drawing.Point(873, 340);
            this.Reporte_BT.Name = "Reporte_BT";
            this.Reporte_BT.Size = new System.Drawing.Size(75, 23);
            this.Reporte_BT.TabIndex = 28;
            this.Reporte_BT.Text = "Reporte";
            this.Reporte_BT.UseVisualStyleBackColor = true;
            this.Reporte_BT.Click += new System.EventHandler(this.Reporte_BT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1085, 371);
            this.Controls.Add(this.Reporte_BT);
            this.Controls.Add(this.Eliminar_BT);
            this.Controls.Add(this.Limpiar_BT);
            this.Controls.Add(this.GuardarMod_BT);
            this.Controls.Add(this.Consul_BT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Registrar_BT);
            this.Controls.Add(this.FotoSel_BT);
            this.Controls.Add(this.Estado_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sueldo_TB);
            this.Controls.Add(this.Sueldo_LB);
            this.Controls.Add(this.Supervi_TB);
            this.Controls.Add(this.Supervi_LB);
            this.Controls.Add(this.FechaIng_Date);
            this.Controls.Add(this.FechaIng_LB);
            this.Controls.Add(this.Puesto_TB);
            this.Controls.Add(this.Puesto_LB);
            this.Controls.Add(this.Departa_TB);
            this.Controls.Add(this.Depart_LB);
            this.Controls.Add(this.FechaNac_Date);
            this.Controls.Add(this.Direccion_TB);
            this.Controls.Add(this.Direccion_LB);
            this.Controls.Add(this.FechaNac_LB);
            this.Controls.Add(this.Nombre_TB);
            this.Controls.Add(this.Nombre_LB);
            this.Controls.Add(this.Ced_TB);
            this.Controls.Add(this.Ced_LB);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ID_LB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema De Control De Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_LB;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.TextBox Ced_TB;
        private System.Windows.Forms.Label Ced_LB;
        private System.Windows.Forms.TextBox Nombre_TB;
        private System.Windows.Forms.Label Nombre_LB;
        private System.Windows.Forms.Label FechaNac_LB;
        private System.Windows.Forms.TextBox Direccion_TB;
        private System.Windows.Forms.Label Direccion_LB;
        private System.Windows.Forms.DateTimePicker FechaNac_Date;
        private System.Windows.Forms.TextBox Departa_TB;
        private System.Windows.Forms.Label Depart_LB;
        private System.Windows.Forms.TextBox Puesto_TB;
        private System.Windows.Forms.Label Puesto_LB;
        private System.Windows.Forms.DateTimePicker FechaIng_Date;
        private System.Windows.Forms.Label FechaIng_LB;
        private System.Windows.Forms.TextBox Supervi_TB;
        private System.Windows.Forms.Label Supervi_LB;
        private System.Windows.Forms.TextBox Sueldo_TB;
        private System.Windows.Forms.Label Sueldo_LB;
        private System.Windows.Forms.TextBox Estado_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FotoSel_BT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Registrar_BT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Consul_BT;
        private System.Windows.Forms.Button GuardarMod_BT;
        private System.Windows.Forms.Button Limpiar_BT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Eliminar_BT;
        private System.Windows.Forms.Button Reporte_BT;
    }
}

