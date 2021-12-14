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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_LB
            // 
            this.ID_LB.AutoSize = true;
            this.ID_LB.Location = new System.Drawing.Point(186, 31);
            this.ID_LB.Name = "ID_LB";
            this.ID_LB.Size = new System.Drawing.Size(85, 13);
            this.ID_LB.TabIndex = 0;
            this.ID_LB.Text = "ID del Empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(28, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 139);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(294, 24);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.Size = new System.Drawing.Size(111, 20);
            this.ID_TB.TabIndex = 2;
            // 
            // Ced_TB
            // 
            this.Ced_TB.Location = new System.Drawing.Point(294, 51);
            this.Ced_TB.Name = "Ced_TB";
            this.Ced_TB.Size = new System.Drawing.Size(111, 20);
            this.Ced_TB.TabIndex = 4;
            // 
            // Ced_LB
            // 
            this.Ced_LB.AutoSize = true;
            this.Ced_LB.Location = new System.Drawing.Point(186, 58);
            this.Ced_LB.Name = "Ced_LB";
            this.Ced_LB.Size = new System.Drawing.Size(40, 13);
            this.Ced_LB.TabIndex = 3;
            this.Ced_LB.Text = "Cédula";
            // 
            // Nombre_TB
            // 
            this.Nombre_TB.Location = new System.Drawing.Point(294, 77);
            this.Nombre_TB.Name = "Nombre_TB";
            this.Nombre_TB.Size = new System.Drawing.Size(111, 20);
            this.Nombre_TB.TabIndex = 6;
            // 
            // Nombre_LB
            // 
            this.Nombre_LB.AutoSize = true;
            this.Nombre_LB.Location = new System.Drawing.Point(186, 84);
            this.Nombre_LB.Name = "Nombre_LB";
            this.Nombre_LB.Size = new System.Drawing.Size(44, 13);
            this.Nombre_LB.TabIndex = 5;
            this.Nombre_LB.Text = "Nombre";
            // 
            // FechaNac_LB
            // 
            this.FechaNac_LB.AutoSize = true;
            this.FechaNac_LB.Location = new System.Drawing.Point(186, 108);
            this.FechaNac_LB.Name = "FechaNac_LB";
            this.FechaNac_LB.Size = new System.Drawing.Size(108, 13);
            this.FechaNac_LB.TabIndex = 7;
            this.FechaNac_LB.Text = "Fecha de Nacimiento";
            // 
            // Direccion_TB
            // 
            this.Direccion_TB.Location = new System.Drawing.Point(294, 128);
            this.Direccion_TB.Name = "Direccion_TB";
            this.Direccion_TB.Size = new System.Drawing.Size(111, 20);
            this.Direccion_TB.TabIndex = 10;
            // 
            // Direccion_LB
            // 
            this.Direccion_LB.AutoSize = true;
            this.Direccion_LB.Location = new System.Drawing.Point(186, 135);
            this.Direccion_LB.Name = "Direccion_LB";
            this.Direccion_LB.Size = new System.Drawing.Size(52, 13);
            this.Direccion_LB.TabIndex = 9;
            this.Direccion_LB.Text = "Dirección";
            // 
            // FechaNac_Date
            // 
            this.FechaNac_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNac_Date.Location = new System.Drawing.Point(294, 102);
            this.FechaNac_Date.Name = "FechaNac_Date";
            this.FechaNac_Date.Size = new System.Drawing.Size(111, 20);
            this.FechaNac_Date.TabIndex = 11;
            // 
            // Departa_TB
            // 
            this.Departa_TB.Location = new System.Drawing.Point(294, 159);
            this.Departa_TB.Name = "Departa_TB";
            this.Departa_TB.Size = new System.Drawing.Size(111, 20);
            this.Departa_TB.TabIndex = 13;
            // 
            // Depart_LB
            // 
            this.Depart_LB.AutoSize = true;
            this.Depart_LB.Location = new System.Drawing.Point(186, 166);
            this.Depart_LB.Name = "Depart_LB";
            this.Depart_LB.Size = new System.Drawing.Size(74, 13);
            this.Depart_LB.TabIndex = 12;
            this.Depart_LB.Text = "Departamento";
            // 
            // Puesto_TB
            // 
            this.Puesto_TB.Location = new System.Drawing.Point(294, 184);
            this.Puesto_TB.Name = "Puesto_TB";
            this.Puesto_TB.Size = new System.Drawing.Size(111, 20);
            this.Puesto_TB.TabIndex = 15;
            // 
            // Puesto_LB
            // 
            this.Puesto_LB.AutoSize = true;
            this.Puesto_LB.Location = new System.Drawing.Point(186, 191);
            this.Puesto_LB.Name = "Puesto_LB";
            this.Puesto_LB.Size = new System.Drawing.Size(40, 13);
            this.Puesto_LB.TabIndex = 14;
            this.Puesto_LB.Text = "Puesto";
            // 
            // FechaIng_Date
            // 
            this.FechaIng_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaIng_Date.Location = new System.Drawing.Point(294, 243);
            this.FechaIng_Date.Name = "FechaIng_Date";
            this.FechaIng_Date.Size = new System.Drawing.Size(111, 20);
            this.FechaIng_Date.TabIndex = 17;
            // 
            // FechaIng_LB
            // 
            this.FechaIng_LB.AutoSize = true;
            this.FechaIng_LB.Location = new System.Drawing.Point(186, 249);
            this.FechaIng_LB.Name = "FechaIng_LB";
            this.FechaIng_LB.Size = new System.Drawing.Size(90, 13);
            this.FechaIng_LB.TabIndex = 16;
            this.FechaIng_LB.Text = "Fecha de Ingreso";
            // 
            // Supervi_TB
            // 
            this.Supervi_TB.Location = new System.Drawing.Point(294, 214);
            this.Supervi_TB.Name = "Supervi_TB";
            this.Supervi_TB.Size = new System.Drawing.Size(111, 20);
            this.Supervi_TB.TabIndex = 19;
            // 
            // Supervi_LB
            // 
            this.Supervi_LB.AutoSize = true;
            this.Supervi_LB.Location = new System.Drawing.Point(186, 221);
            this.Supervi_LB.Name = "Supervi_LB";
            this.Supervi_LB.Size = new System.Drawing.Size(69, 13);
            this.Supervi_LB.TabIndex = 18;
            this.Supervi_LB.Text = "Líder Directo";
            // 
            // Sueldo_TB
            // 
            this.Sueldo_TB.Location = new System.Drawing.Point(294, 271);
            this.Sueldo_TB.Name = "Sueldo_TB";
            this.Sueldo_TB.Size = new System.Drawing.Size(111, 20);
            this.Sueldo_TB.TabIndex = 21;
            // 
            // Sueldo_LB
            // 
            this.Sueldo_LB.AutoSize = true;
            this.Sueldo_LB.Location = new System.Drawing.Point(186, 278);
            this.Sueldo_LB.Name = "Sueldo_LB";
            this.Sueldo_LB.Size = new System.Drawing.Size(40, 13);
            this.Sueldo_LB.TabIndex = 20;
            this.Sueldo_LB.Text = "Sueldo";
            // 
            // Estado_TB
            // 
            this.Estado_TB.Location = new System.Drawing.Point(294, 300);
            this.Estado_TB.Name = "Estado_TB";
            this.Estado_TB.Size = new System.Drawing.Size(111, 20);
            this.Estado_TB.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 307);
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
            this.FotoSel_BT.TabIndex = 24;
            this.FotoSel_BT.Text = "Seleccionar foto";
            this.FotoSel_BT.UseVisualStyleBackColor = true;
            this.FotoSel_BT.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 398);
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
            this.Name = "Form1";
            this.Text = "Sistema De Control De Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

