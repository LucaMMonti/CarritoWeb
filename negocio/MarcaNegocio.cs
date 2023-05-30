using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listarMarcas()
        {

            List<Marca> listaMarca = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("Select id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.id = (int)datos.Lector["id"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarca.Add(aux);
                }
                return listaMarca;
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

