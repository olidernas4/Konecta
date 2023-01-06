using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konecta.Conexion
{
    public class ConexionBD
    {
        SqlConnection con;
        public ConexionBD()
        {
            con = new SqlConnection("Server=(Local)\\Sqlexpress;Database=Ventas_Konect; integrated security=true");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

