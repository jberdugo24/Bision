using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios.Lógica;


namespace Ejercicios.Datos
{
    class ClientesD
    {
        ConexionD conexion;

        public ClientesD()
        {
            conexion = new ConexionD();
        }

        public bool Agregar(ClientesL clientesL) {

            SqlCommand SQLComando = new SqlCommand("INSERT INTO cliente VALUES (@nombres, @telefono, @correo)");
            SQLComando.Parameters.Add("@nombres", SqlDbType.VarChar).Value = clientesL.nombreC;
            SQLComando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = clientesL.telefonoC;
            SQLComando.Parameters.Add("@correo", SqlDbType.VarChar).Value = clientesL.correoC;
            return conexion.ejecutarComando(SQLComando);           
        }

        public bool Eliminar(ClientesL clientesL)
        {
            SqlCommand SQLComando = new SqlCommand("DELETE FROM cliente WHERE ID = @ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = clientesL.ID;
            return conexion.ejecutarComando(SQLComando); 
        }

        public bool Modificar(ClientesL clientesL)
        {
            SqlCommand SQLComando = new SqlCommand("UPDATE cliente SET nombres=@Nombre, telefono=@Telefono, correo=@Correo WHERE ID=@ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = clientesL.ID;
            SQLComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = clientesL.nombreC;
            SQLComando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = clientesL.telefonoC;
            SQLComando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = clientesL.correoC;            
            return conexion.ejecutarComando(SQLComando);


            
        }

        public DataSet MostrarClientes()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM cliente");

            return conexion.ejecutarSentencia(sentencia);

        }

    }
}
