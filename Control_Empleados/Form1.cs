using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Control_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string RutaFoto;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult result = file.ShowDialog();
            RutaFoto = file.FileName;
            pictureBox1.ImageLocation = RutaFoto;
            //MessageBox.Show(ruta);
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Model.RRHHEntities hola = new Model.RRHHEntities();
            var Emp = new Model.Empleado();

            Emp.Cedula = Ced_TB.Text;
            Emp.Nombre = Nombre_TB.Text;
            Emp.Fecha_Nac = FechaNac_Date.Value;
            Emp.Direccion = Direccion_TB.Text;
            Emp.Departamento = Departa_TB.Text;
            Emp.Puesto = Puesto_TB.Text;
            Emp.Lider = Supervi_TB.Text;
            Emp.Fecha_Ing = FechaIng_Date.Value;
            Emp.Sueldo = Convert.ToDouble(Sueldo_TB.Text);
            Emp.Estados = Estado_TB.Text;
            Emp.Foto = File.ReadAllBytes(RutaFoto);

            hola.Empleados.Add(Emp);
            hola.SaveChanges();
            //Emp.Foto

            
        }
    }
}
