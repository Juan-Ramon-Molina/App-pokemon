using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace servicios
{
    public class AccesoDB
    {   //Clase que permite aceder a base de datos. atibutos de conexion, comando y lector.
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        //Lector public que permite el acceso desde otra clase.
        public SqlDataReader Lector { get { return lector; } }
        //Constructor con conexion y comando vacio.
        public AccesoDB()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS01; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();
        }
        //Metodo que establece consulta.
        public void SetearComando(string consulta)
        {
            comando.CommandType=System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        //Metodo que establece parametros de consulta. Remplaza variable por valor.
        public void SetearParametros(string columna,object objeto)
        {
            comando.Parameters.AddWithValue(columna,objeto);
        }
        public void EjecutarLectura()
        {
            comando.Connection=conexion;
            try
            {
                conexion.Open();
                lector=comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection=conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch ( Exception ex)
            {

                throw ex;
            }
        }
        public void CerrarConexion()
        {
            if (lector != null) 
                lector.Close();
            conexion.Close();
        }

    }
}
