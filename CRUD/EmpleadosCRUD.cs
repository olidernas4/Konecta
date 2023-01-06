using Konecta.ModeloGetSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Konecta.Conexion;

namespace Konecta.CRUD
{
    class EmpleadosCRUD
    {

        public static bool InsertarUsuario(EmpleadoBD e)
        {
            try
            {
                ConexionBD con = new ConexionBD();
                string sql = "Insert into Empleado values ('" + e.Nombre_Empleado + "','" + e.Fecha_Ingreso + "','" + e.Salario_Empleado + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {

                    con.Desconectar();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public static EmpleadoBD Consultar(string Empleado)
        {
            try
            {
                ConexionBD con = new ConexionBD();
                string sql = "SELECT * FROM Empleado WHERE Nombre_Empleado = '" + Empleado + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();
                EmpleadoBD em = new EmpleadoBD();
                if (dr.Read())

                {
                    //em.Id_Empleado = dr["Id_Empleado"].ToString();
                    em.Nombre_Empleado = dr["nombre_Empleado"].ToString();
                    em.Fecha_Ingreso = dr["Fecha_Ingreso"].ToString();
                    em.Salario_Empleado = dr["Salario_Empleado"].ToString();
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

        public static DataTable Listar()
        {
            try
            {
                ConexionBD con = new ConexionBD();
                string sql = "SELECT * FROM Empleado;";
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


    }
}
