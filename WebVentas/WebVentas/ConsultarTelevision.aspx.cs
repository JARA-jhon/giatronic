using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaReglas;
using CapaEntidad;


namespace WebVentas
{
    public partial class ConsultarTelevision : System.Web.UI.Page
    {
        TelevisionCR telebl = new TelevisionCR();
        PedidoCR pedidobl = new PedidoCR();
        List<string> lista;

        protected void Page_PreInit(object sender, EventArgs e)
        {
            lista = (List<string>)Session["datos"];
            if (lista != null)
            {
                if (lista[9].ToString() == "ADM")
                {
                    this.MasterPageFile = "PrincipalAdministrador.Master";
                }
                  else if (lista[9].ToString() == "USU")
                {
                    this.MasterPageFile = "PrincipalCliente.Master";
                }
                else
                    this.MasterPageFile = "PrincipalEmpleado.Master";


                //  else
                //{
                //    this.MasterPageFile = "PrincipalCliente.Master";
                //}     


            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            lista = (List<string>)Session["datos"];
            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    if (Session["carrito"] == null)
                        Session["carrito"] = pedidobl.getCarrito();

                    dlAutos.DataSource = telebl.listaTelevision();
                    dlAutos.DataBind();
                    cargarComboMarca();
                    cargarComboPantalla();
                    cargarComboTecnologia();
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                    cargarComboMarca();
                    cargarComboPantalla();
                    cargarComboTecnologia();
                }
            }
        }

        void cargarComboMarca()
        {
            ddlMarca.DataSource = telebl.listaMarca();
            ddlMarca.DataTextField = "nomprov";
            ddlMarca.DataValueField = "ruc";
            ddlMarca.DataBind();

            ddlMarca.Items.Insert(0, "Seleccione Marca");
        }

        void cargarComboPantalla()
        {
            ddlPantalla.DataSource = telebl.listaTecnologia();
            ddlPantalla.DataTextField = "codtip";
            ddlPantalla.DataValueField = "codtip";
            ddlPantalla.DataBind();

            ddlPantalla.Items.Insert(0, "Seleccione Pantalla");
        }

        void cargarComboTecnologia()
        {
            ddlTecnologia.DataSource = telebl.listaCategoria();
            ddlTecnologia.DataTextField = "descat";
            ddlTecnologia.DataValueField = "codcat";
            ddlTecnologia.DataBind();

            ddlTecnologia.Items.Insert(0, "Seleccione Tecnologia");
        }

        protected void dlAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label codigo = (Label)dlAutos.SelectedItem.FindControl("lblCodigo");
            Label proveedor = (Label)dlAutos.SelectedItem.FindControl("lblProveedor");
            Label tecnologia = (Label)dlAutos.SelectedItem.FindControl("lblTecnologia");
            Label categoria = (Label)dlAutos.SelectedItem.FindControl("lblCategoria");
            Label Resolucion = (Label)dlAutos.SelectedItem.FindControl("lblResolucion");
            Label Pulgadas = (Label)dlAutos.SelectedItem.FindControl("lblPulgadas");
            Label Caracteristicas = (Label)dlAutos.SelectedItem.FindControl("lblCaracteristicas");
            Label precio = (Label)dlAutos.SelectedItem.FindControl("lblPrecio");
            Label stock = (Label)dlAutos.SelectedItem.FindControl("lblStock");
            Image img = (Image)dlAutos.SelectedItem.FindControl("image1");

            HttpCookie auto = new HttpCookie("auto");
            auto.Values.Add("codigo", codigo.Text);
            auto.Values.Add("proveedor", proveedor.Text);
            auto.Values.Add("tecnologia", tecnologia.Text);
            auto.Values.Add("categoria", categoria.Text);
            auto.Values.Add("Resolucion", Resolucion.Text);
            auto.Values.Add("Pulgadas", Pulgadas.Text);
            auto.Values.Add("Caracteristicas", Caracteristicas.Text);
            auto.Values.Add("precio", precio.Text);
            auto.Values.Add("stock", stock.Text);
            auto.Values.Add("imagen", img.ImageUrl);

            Response.Cookies.Add(auto);
            Response.Redirect("Television.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerCarrito.aspx");
           
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bienvenida.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            string nro;
            string est;

            try
            {
                nro = "";
            }
            catch (Exception a)
            {
                nro = "";
            }

            if (ddlMarca.SelectedIndex == 0)
            {
                est = "";
            }
            else
            {
                est = ddlMarca.SelectedItem.Value;
            }

            dlAutos.DataSource = telebl.listaTelevisionxMarca(nro, est);
            dlAutos.DataBind();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            string nro;
            string est;

            try
            {
                nro = "";
            }
            catch (Exception a)
            {
                nro = "";
            }

            if (ddlPantalla.SelectedIndex == 0)
            {
                est = "";
            }
            else
            {
                est = ddlPantalla.SelectedItem.Value;
            }

            dlAutos.DataSource = telebl.listaTelevisionxTipopantalla(nro, est);
            dlAutos.DataBind();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            string nro;
            string est;

            try
            {
                nro = "";
            }
            catch (Exception a)
            {
                nro = "";
            }

            if (ddlTecnologia.SelectedIndex == 0)
            {
                est = "";
            }
            else
            {
                est = ddlTecnologia.SelectedItem.Value;
            }

            dlAutos.DataSource = telebl.listaTelevisionxcategoria(nro, est);
            dlAutos.DataBind();
        }


    }
}