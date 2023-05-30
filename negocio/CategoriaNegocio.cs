using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> listarCategorias()
        {

            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("Select id, Descripcion from Categorias");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.iDCategoria = (int)datos.Lector["id"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    listaCategoria.Add(aux);
                }
                return listaCategoria;
            }


            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                datos.cerrarConexion();
            }


        }

    }
}
