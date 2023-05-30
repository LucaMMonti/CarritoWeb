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
        public List<Categoria> listarCategoria()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select id, descripcion FROM Marcas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.iDCategoria = datos.Lector.GetInt32(0);
                    aux.descripcion = (string)datos.Lector["descripcion"];
                }
                return listaCategorias;
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
