using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FacturaDesktopApp.Services
{
    public class Conexion
    {
        string ServerLocal = @"WINDOWS-P4VOGQ5";
        public SqlConnection cnn;

        public Boolean Conectar(string db) 
        {
            try 
            { 
                cnn = new SqlConnection("server=" + ServerLocal +
                    ";initial catalog=FACTURA;integrated security=true");
                cnn.Open();
                return true;
            } 
            catch(SqlException ex)
            {
                MessageBox.Show("Error en conexion a la base de datos. Error Code: " + ex.Message);
                return false;
            }
        }
        public Boolean Desconectar() 
        {
            try 
            {
                if (cnn.State == System.Data.ConnectionState.Open)
                {
                    cnn.Close();
                    return true;
                }
                else
                { 
                    return false;
                }
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Error al desconectarse de la base de datos Error Code: " + ex.Message);
                return false;
            }
        }


    }
}
