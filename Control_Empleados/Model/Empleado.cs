//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Control_Empleados.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Fecha_Nac { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string Lider { get; set; }
        public System.DateTime Fecha_Ing { get; set; }
        public double Sueldo { get; set; }
        public string Estados { get; set; }
        public byte[] Foto { get; set; }
    }
}
