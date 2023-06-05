using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace carrito_web
{
    public partial class Default : System.Web.UI.Page
    {   
        public List<Articulo> listaArticulos { get; set; }

        public bool FiltroAvanzado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FiltroAvanzado = swtAvanzado.Checked;
            if (!IsPostBack)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Session.Add("listaArticulos", negocio.listar());
                Repeater1.DataSource = Session["listaArticulos"];
                Repeater1.DataBind();
            }
      
        }

        protected void Filtro_textChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = (List<Articulo>)Session["listaArticulos"];
            List<Articulo> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            Repeater1.DataSource = listaFiltrada;
            Repeater1.DataBind();
        }

        protected void swtAvanzado_CheckedChanged(object sender, EventArgs e) 
        {
            
            FiltroAvanzado = swtAvanzado.Checked;
            txtFiltro.Enabled = !FiltroAvanzado;

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Repeater1.DataSource = negocio.filtar(
                    ddlCampo.SelectedItem.ToString(),
                    ddlCriterio.SelectedItem.ToString(), 
                    txtFiltroAvanzado.Text);
                Repeater1.DataBind();
            }
            catch (Exception ex) 
            {
                Session.Add("error", ex);
                throw;
            }
        }

        /*protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ddlCriterio.Items.Clear();

            if (ddlCampo.SelectedItem.ToString() == "Categoria")
            {
                ddlCriterio.Items.Add("Igual a");    
                ddlCriterio.Items.Add("Menor a");
                ddlCriterio.Items.Add("Mayor a");
            }
            else
            { 
                ddlCriterio.Items.Add("Contiene");
                ddlCriterio.Items.Add("Comienza con");
                ddlCriterio.Items.Add("Termina con");
            }

        } */
    }
}