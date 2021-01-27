using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Datos
{
    class ConexionD
    {
        private string CadenaConexion = "Data Source = SURFACE-JB\\SQLEXPRESS; Initial Catalog = bision; Integrated Security = True";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion ()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;

        }
  /*      public bool ejecutarComando(string strcomando) {
            try
            {
                
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strcomando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;

            } catch            
            {
                return false;
            }
        }
  */
        public bool ejecutarComando(SqlCommand SQLcomando)
        {
            try
            {

                SqlCommand Comando = SQLcomando;                
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public DataSet ejecutarSentencia (SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch
            {
                return DS;
            }
        }

    }
}
