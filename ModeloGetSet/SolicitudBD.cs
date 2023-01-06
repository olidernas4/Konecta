using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konecta.ModeloGetSet
{
    class SolicitudBD
    {
        private string codigo_Solicitud;
        private string descripcion_Solicitud;
        private string resumen_Solicitud;
        private string nombre_Empleado;
        private string id_Empleado;
        private int id_Solicitud;


        public SolicitudBD()
        {
            this.codigo_Solicitud = "";
            this.descripcion_Solicitud = "";
            this.resumen_Solicitud = "";
            this.nombre_Empleado="";
            this.id_Empleado = "";
            this.id_Solicitud = 0;
        }

        public string Codigo_Solicitud { get => codigo_Solicitud; set => codigo_Solicitud = value; }
        public string Descripcion_Solicitud { get => descripcion_Solicitud; set => descripcion_Solicitud = value; }
        public string Resumen_Solicitud { get => resumen_Solicitud; set => resumen_Solicitud = value; }
        public string Nombre_Empleado { get => nombre_Empleado; set => nombre_Empleado = value; }
        public string Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
        public int Id_Solicitud { get => id_Solicitud; set => id_Solicitud = value; }
    }
}
