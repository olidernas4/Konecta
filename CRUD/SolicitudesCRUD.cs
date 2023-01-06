using Konecta.Conexion;
using Konecta.ModeloGetSet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konecta.CRUD
{
    class SolicitudesCRUD
    {
        public static bool GuardarSolicitud(SolicitudBD e)
        {
            try
            {
                ConexionBD con = new ConexionBD();
                string sql = "Insert into Solicitud values('" + e.Nombre_Empleado+ "','" +e.Codigo_Solicitud + "','" + e.Descripcion_Solicitud +  "','" + e.Resumen_Solicitud + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.Desconectar();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable Listar()
        {
            try
            {
                ConexionBD con = new ConexionBD();
                string sql = "SELECT dbo.Solicitud.Codigo_Solicitud, dbo.Solicitud.Descripcion_Solicitud, dbo.Solicitud.Resumen_Solicitud, dbo.Empleado.Nombre_Empleado FROM dbo.Solicitud INNER JOIN dbo.Empleado ON dbo.Solicitud.Id_Empleado = dbo.Empleado.Id_Empleado";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con.Desconectar();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<EmpleadoBD> MostrarEmpleado()
        {
            try
            {
                ConexionBD con = new ConexionBD();
                string sql = "SELECT * FROM Empleado;";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();
                var em = new List<EmpleadoBD>();


                while (dr.Read())
                {
                    EmpleadoBD Sold = new EmpleadoBD();
                    Sold.Nombre_Empleado = dr["Empleado"].ToString();
                    Sold.Id_Empleado = dr["IdEmpleado"].ToString();
                    em.Add(Sold);
                }
                con.Desconectar();
                return em;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static SolicitudBD Consultar(string solicitud)
        {
            try
            {
                ConexionBD con = new ConexionBD();
                string sql = "SELECT dbo.Solicitud.Descripcion_Solicitud, dbo.Solicitud.Resumen_Solicitud, dbo.Empleado.Nombre_Empleado, dbo.Solicitud.Codigo_Solicitud, dbo.Solicitud.Id_Solicitud, dbo.Empleado.Id_Empleado FROM dbo.Solicitud INNER JOIN dbo.Empleado ON dbo.Solicitud.Id_Empleado = dbo.Empleado.Id_Empleado='" + solicitud  + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();
                SolicitudBD em = new SolicitudBD();
                if (dr.Read())

                {
                    em.Codigo_Solicitud = dr["Codigo_Solicitud"].ToString();
                    em.Descripcion_Solicitud = dr["Descripcion_Solicitud"].ToString();
                    em.Resumen_Solicitud = dr["Resumen_Solicitud"].ToString();
                    em.Id_Empleado = dr["Id_Empleado"].ToString();
                    em.Id_Solicitud = Int32.Parse(dr["Id_Solicitud"].ToString());
                   
                    con.Desconectar();
                    return em;
                }
                else
                {
                    con.Desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
