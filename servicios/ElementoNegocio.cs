using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace servicios
{
    public class ElementoNegocio
    {
        //Metodo listar. Trabaja con la clase accesoDB que establece la conexion, setea comandos, ejecuta y cierra en un finally.
        public List<Elemento> ListarElementos()
        {
            List<Elemento> elementos = new List<Elemento>();
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("select Id,Descripcion from ELEMENTOS");
                data.EjecutarLectura();
                while (data.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.id = (int)data.Lector["Id"];
                    aux.descripcion=(string)data.Lector["Descripcion"];
                    elementos.Add(aux);
                }
                return elementos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.CerrarConexion();
            }
        }
    }
}
