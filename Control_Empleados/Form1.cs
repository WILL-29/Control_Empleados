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
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                    ((DataGridView)c).Refresh();
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
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
            if (Sueldo_TB.Text.Any(x=> !char.IsNumber(x)))
               errorProvider1.SetError(Sueldo_TB, "Solo debe introducir números");
            else if (Ced_TB.Text == "" || Nombre_TB.Text == "" || Puesto_TB.Text == "" || Estado_TB.Text == "" || Sueldo_TB.Text == "")
            {
                MessageBox.Show("Debe rellenar los campos cédula, Nombre, Puesto, Estado y Sueldo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                hola.Empleados.Add(Emp);
                hola.SaveChanges();
                MessageBox.Show("El Empleado ha sido agregado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar(this);
            }  
        }

        private void Consul_BT_Click(object sender, EventArgs e)
        {
            RRHHEntities db = new RRHHEntities();
            var datadata = db.Empleados.AsQueryable().Where(w => w.Cedula == Ced_TB.Text || w.Nombre.Contains(Nombre_TB.Text));
            dataGridView1.DataSource = datadata.ToList();
            dataGridView1.Columns["Foto"].Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (ID_TB.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún registor para modificar","Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Sueldo_TB.Text.Any(x => !char.IsNumber(x)))
                errorProvider1.SetError(Sueldo_TB, "Solo debe introducir números");
            else if (Ced_TB.Text == "" || Nombre_TB.Text == "" || Puesto_TB.Text == "" || Estado_TB.Text == "" || Sueldo_TB.Text == "")
            {
                MessageBox.Show("Debe rellenar los campos cédula, Nombre, Puesto, Estado y Sueldo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var db = new RRHHEntities();
                int id = Convert.ToInt32(ID_TB.Text);
                var Edita = db.Empleados.FirstOrDefault(w => w.ID == id);

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
                { Edita.Foto = File.ReadAllBytes(RutaFoto); }
                db.SaveChanges();
                Limpiar(this);
                MessageBox.Show("Cambios realizados correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
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
                if (dataGridView1.Rows[n].Cells[11].Value != null)
                {
                    byte[] img = (Byte[])dataGridView1.Rows[n].Cells[11].Value;
                    MemoryStream mem = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(mem);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void Limpiar_BT_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }

        private void Eliminar_BT_Click(object sender, EventArgs e)
        {
            if (ID_TB.Text == "")
            {
                MessageBox.Show("No ha realizado ningún cambio en ningún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var db = new RRHHEntities();
                int id = Convert.ToInt32(ID_TB.Text);
                var Empeli = db.Empleados.FirstOrDefault(w => w.ID == id);
                if (Empeli != null)
                {
                    db.Empleados.Remove(Empeli);
                    db.SaveChanges();
                    MessageBox.Show("El empleado ha sido eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Limpiar(this);
            }
        }

        private void Estado_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reporte_BT_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //From2_Reporte fr = new From2_Reporte();
            
        }
    }
}
