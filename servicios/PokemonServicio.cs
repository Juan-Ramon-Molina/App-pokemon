using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Data;
using Microsoft.SqlServer.Server;

namespace servicios
{
    public class PokemonServicio
    {   //metodo listar. Envia una lista de objetos.
        public List<Pokemon> Listar()
        {
            //Crear objetos
            List<Pokemon> ListaPokemon = new List<Pokemon>();
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                //Configurar lectura
                Conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=POKEDEX_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select Numero,p.Descripcion aspecto,Nombre,UrlImagen imagen, e.Descripcion Tipo, d.Descripcion Debilidad, p.Id, p.IdTipo, p.IdDebilidad from POKEMONS p inner join ELEMENTOS E on E.Id= p.IdTipo inner join ELEMENTOS D on d.id=p.IdDebilidad where p.activo=1";
                Comando.Connection = Conexion;
                //Abrir y leer
                Conexion.Open();
                Lector = Comando.ExecuteReader();
                //Guardar en variables, crear instancia.
                while (Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.id = (int)Lector["Id"];
                    aux.numero = (int)Lector["Numero"];
                    aux.nombre = (string)Lector["Nombre"];
                    aux.descripcion = (string)Lector["aspecto"];
                    //imagen es validado en caso de que sea null, no se lee. 
                    //uso del if con negacion en dbnull. si el dato !NO es null sera leido.
                    //Se debe validar siempre y cuando la columna sql acepte null.
                    //Si es NotNull no hace falta validar.
                    if (!(Lector["imagen"] is DBNull))
                    {
                        aux.imagen = (string)Lector["imagen"];
                    }
                    aux.tipo = new Elemento();
                    aux.tipo.descripcion = (string)Lector["Tipo"];
                    aux.tipo.id = (int)Lector["IdTipo"];
                    aux.debilidad = new Elemento();
                    aux.debilidad.descripcion = (string)Lector["Debilidad"];
                    aux.debilidad.id = (int)Lector["IdDebilidad"];
                    ListaPokemon.Add(aux);
                }
                //Poner Close() en un finally, funcionamiento optimo.
                Conexion.Close();
                return ListaPokemon;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        //Metodo nuevo pokemon. Recibe el objeto por parametros y lo ingresa en la base de datos.
        public void CrearPokemon(Pokemon nuevo)
        {
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("insert into POKEMONS (Numero,Nombre,Descripcion,Activo,IdTipo,IdDebilidad,UrlImagen) values (" + nuevo.numero + ",'" + nuevo.nombre + "','" + nuevo.descripcion + "',1,@IdTipo,@IdDebilidad,@Url)");
                datos.SetearParametros("@IdTipo", nuevo.tipo.id);
                datos.SetearParametros("@IdDebilidad", nuevo.debilidad.id);
                datos.SetearParametros("@Url", nuevo.imagen);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void ModificarPokemon(Pokemon modificado)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("update POKEMONS set Numero=@numero,Nombre=@nombre,Descripcion=@descripcion,UrlImagen=@urlimagen,IdTipo=@idtipo,IdDebilidad=@iddebilidad where id=@id");
                data.SetearParametros("@numero", modificado.numero);
                data.SetearParametros("@nombre", modificado.nombre);
                data.SetearParametros("@descripcion", modificado.descripcion);
                data.SetearParametros("@urlimagen", modificado.imagen);
                data.SetearParametros("@idtipo", modificado.tipo.id);
                data.SetearParametros("@iddebilidad", modificado.debilidad.id);
                data.SetearParametros("@id", modificado.id);
                data.EjecutarAccion();

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
        public void EliminacionFisica(Pokemon seleccionado)
        {
            AccesoDB data = new AccesoDB();
            try
            {

                data.SetearComando("delete from POKEMONS where id=@id");
                data.SetearParametros("@id", seleccionado.id);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CerrarConexion(); }

        }
        public void EliminacionLogica(Pokemon seleccionado)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("update POKEMONS set Activo=0 where id=@id");
                data.SetearParametros("@id", seleccionado.id);
                data.EjecutarAccion();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally { data.CerrarConexion(); };
        }
        public List<Pokemon> ListarInactivos()
        {
            List<Pokemon> inactivos = new List<Pokemon>();
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("select Numero,p.Descripcion aspecto,Nombre,UrlImagen imagen, e.Descripcion Tipo, d.Descripcion Debilidad, p.Id, p.IdTipo, p.IdDebilidad from POKEMONS p inner join ELEMENTOS E on E.Id= p.IdTipo inner join ELEMENTOS D on d.id=p.IdDebilidad where p.activo=0");
                data.EjecutarLectura();
                while (data.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.id = (int)data.Lector["Id"];
                    aux.numero = (int)data.Lector["Numero"];
                    aux.nombre = (string)data.Lector["Nombre"];
                    aux.descripcion = (string)data.Lector["aspecto"];
                    if (!(data.Lector["imagen"] is DBNull))
                    {
                        aux.imagen = (string)data.Lector["imagen"];
                    }
                    aux.tipo = new Elemento();
                    aux.tipo.id = (int)data.Lector["IdTipo"];
                    aux.tipo.descripcion = (string)data.Lector["Tipo"];
                    aux.debilidad = new Elemento();
                    aux.debilidad.id = (int)data.Lector["IdDebilidad"];
                    aux.debilidad.descripcion = (string)data.Lector["Debilidad"];

                    inactivos.Add(aux);

                }
                return inactivos;
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
        public void Activacion(int id)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("update POKEMONS set Activo=1 where id=@id");
                data.SetearParametros("@id", id);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { data.CerrarConexion(); }
        }
        public List<Pokemon> BusquedaAvanzada(string campo, string criterio, string filtro)
        {
            List<Pokemon> filtrados = new List<Pokemon>();
            AccesoDB data = new AccesoDB();
            try
            {
                String consulta = "select Numero,p.Descripcion aspecto,Nombre,UrlImagen imagen, e.Descripcion Tipo, d.Descripcion Debilidad, p.Id, p.IdTipo, p.IdDebilidad from POKEMONS p inner join ELEMENTOS E on E.Id= p.IdTipo inner join ELEMENTOS D on d.id=p.IdDebilidad where p.activo=1 and ";
                switch (campo)
                {
                    case "Numero":
                        switch (criterio)
                        {
                            case "Mayores a:":
                                consulta += "Numero > " + filtro;
                                break;
                            case "Menores a:":
                                consulta += "Numero < " + filtro;
                                break;
                            case "Iguales a:":
                                consulta += "Numero = " + filtro;
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Empieza con:":
                                consulta += "Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con:":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            case "Contiene:":
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Empieza con:":
                                consulta += "p.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con:":
                                consulta += "p.Descripcion like '%" + filtro + "'";
                                break;
                            case "Contiene:":
                                consulta += "p.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                     
                }
                data.SetearComando(consulta);
                data.EjecutarLectura();
                while (data.Lector.Read()) 
                {
                    Pokemon aux = new Pokemon();
                    aux.id = (int)data.Lector["Id"];
                    aux.numero = (int)data.Lector["Numero"];
                    aux.nombre = (string)data.Lector["Nombre"];
                    aux.descripcion = (string)data.Lector["aspecto"];
                    
                    if (!(data.Lector["imagen"] is DBNull))
                    {
                        aux.imagen = (string)data.Lector["imagen"];
                    }
                    aux.tipo = new Elemento();
                    aux.tipo.descripcion = (string)data.Lector["Tipo"];
                    aux.tipo.id = (int)data.Lector["IdTipo"];
                    aux.debilidad = new Elemento();
                    aux.debilidad.descripcion = (string)data.Lector["Debilidad"];
                    aux.debilidad.id = (int)data.Lector["IdDebilidad"];

                    filtrados.Add(aux);
                }

                return filtrados;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CerrarConexion(); }
            
        }
    }
   
}
