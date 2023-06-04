using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public List<Imagen> Imagenes { get; set; } //para que se pueda acceder a la lista de imagenes desde el form
        public Articulo()
        {
            Imagenes = new List<Imagen>(); //inicializo la lista de imagenes
        }
        public int id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public Imagen Imagen { get; set; }
    


    }
}
