using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konecta.ModeloGetSet
{
    class EmpleadoBD
    {
        private string id_Empleado;
        private string nombre_Empleado;
        private string fecha_Ingreso;
        private string salario_Empleado;

       public EmpleadoBD()
        {
            this.id_Empleado = "";
            this.nombre_Empleado = "";
            this.fecha_Ingreso = "";
            this.salario_Empleado = "";
        }

        public string Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
        public string Nombre_Empleado { get => nombre_Empleado; set => nombre_Empleado = value; }
        public string Fecha_Ingreso { get => fecha_Ingreso; set => fecha_Ingreso = value; }
        public string Salario_Empleado { get => salario_Empleado; set => salario_Empleado = value; }
    }

}
