using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_Previo_2.Helpers
{
    public class BaseDeDatos
    {
        public SqlConnection conexion;
        public List<string> cadenasExec;

        // Get Conexion
        private void getConexion()
        {
            string connStr = "Data Source=(LocalDb)/MSSQLLocalDB;AttachDbFilename=C:/Users/User/Desktop/Diseño/TP/TP-Previo/TP-Previo/TP-Previo-2/App_Data/aspnet-TP-Previo-2-20180422024037.mdf;Initial Catalog=aspnet-TP-Previo-2-20180422024037;Integrated Security=True";
            conexion = new SqlConnection(connStr);
            try
            {
                conexion.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // ExecQuery
        public void ExecQuery(string sql)
        {
            if (conexion == null)
                this.getConexion();

            try
            {
                SqlCommand myCommand = new SqlCommand(sql, this.conexion);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(sql);
            }
        }

        // ExecQuery Select
        public SqlDataReader ExecQuerySelect(string sql)
        {
            if (conexion == null)
                this.getConexion();

            try
            {
                SqlCommand myCommand = new SqlCommand(sql, this.conexion);
                return myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(sql);
                return null;
            }
        }
        
    }
}