using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Control_Empleados.Model;


namespace Control_Empleados
{
    public partial class From2_Reporte : Form 
    {
        public From2_Reporte()
        {
            InitializeComponent();
        }

        private void From2_Reporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource fuente = new ReportDataSource();
            //fuente = 
            reportViewer1.LocalReport.DataSources.Add(fuente);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
