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
using Control_Empleados.Model;


namespace Control_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Aquí declarará todas las variables globales que necesite
        string RutaFoto;

        //Aquí crearé todos los métodos de la clase Form1
        static void Limpiar(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is DateTime)
                {
                    ((DateTimePicker)c).ResetText();
                }
                
            }
 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult result = file.ShowDialog();
            RutaFoto = file.FileName;
            pictureBox1.ImageLocation = RutaFoto;
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

            Limpiar(this);
        }

        private void Consul_BT_Click(object sender, EventArgs e)
        {
            RRHHEntities db = new RRHHEntities();
            var datadata = db.Empleados.AsQueryable().Where(w => w.Cedula == Ced_TB.Text || w.Nombre.Contains(Nombre_TB.Text));
            dataGridView1.DataSource = datadata.ToList();
            //dataGridView1.Columns.Remove("Foto");
            dataGridView1.Columns["Foto"].Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var db = new RRHHEntities();
            var Edita = db.Empleados.FirstOrDefault(w => w.ID == 1);

            Edita.Cedula = Ced_TB.Text;
            Edita.Nombre = Nombre_TB.Text;
            Edita.Fecha_Nac = FechaNac_Date.Value;
            Edita.Direccion = Direccion_TB.Text;
            Edita.Departamento = Departa_TB.Text;
            Edita.Puesto = Puesto_TB.Text;
            Edita.Lider = Supervi_TB.Text;
            Edita.Fecha_Ing = FechaIng_Date.Value;
            Edita.Sueldo = Convert.ToDouble(Sueldo_TB.Text);
            Edita.Estados = Estado_TB.Text;
            if (RutaFoto != null)
            {Edita.Foto = File.ReadAllBytes(RutaFoto);}
            db.SaveChanges();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n > -1)
            {
                ID_TB.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
                Ced_TB.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
                Nombre_TB.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
                FechaNac_Date.Value = Convert.ToDateTime(dataGridView1.Rows[n].Cells[3].Value);
                Direccion_TB.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
                Departa_TB.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
                Puesto_TB.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
                Supervi_TB.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
                FechaIng_Date.Value = Convert.ToDateTime(dataGridView1.Rows[n].Cells[8].Value);
                Sueldo_TB.Text = dataGridView1.Rows[n].Cells[9].Value.ToString();
                Estado_TB.Text = dataGridView1.Rows[n].Cells[10].Value.ToString();
                byte[] img = (Byte[])dataGridView1.Rows[n].Cells[11].Value;
                MemoryStream mem = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(mem);
            }
        }

        private void Limpiar_BT_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }
    }
}
