using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class MarcaNegocio
    {


        public List<Marca> listarMarca()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select id, descripcion FROM Marcas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.iDMarca = datos.Lector.GetInt32(0);
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                }
                return listaMarcas;
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





