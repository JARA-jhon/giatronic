using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaReglas;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace WebVentas
{
    public partial class DetalleCarrito : System.Web.UI.Page
    {
        PedidoCR pedidobl;
        PedidoCE pedido;
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
                else
                {
                    this.MasterPageFile = "PrincipalCliente.Master";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            btnAgregar.Attributes.Add("OnClick", "return confirm('El Auto se Agregará al Carrito de Compras ¿Desea Continuar?');");

            lista = (List<string>)Session["datos"];

            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    if (Request.Cookies["auto"] != null)
                    {
                        if (Session["carrito"] == null)
                        {
                            Session["carrito"] = pedidobl.getCarrito();
                        }
                        cargaDatos();
                    }
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }

            }
        }

        void cargaDatos()
        {
            lblCodigo.Text = Request.Cookies["auto"]["codigo"].ToString();
            lblProveedor.Text = Request.Cookies["auto"]["proveedor"].ToString();
            lblTecnologia.Text = Request.Cookies["auto"]["tecnologia"].ToString();
            lblCategoria.Text = Request.Cookies["auto"]["categoria"].ToString();
            lblResolucion.Text = Request.Cookies["auto"]["resolucion"].ToString();
            lblPulgadas.Text = Request.Cookies["auto"]["pulgadas"].ToString();
            lblCaracteristicas.Text = Request.Cookies["auto"]["Caracteristicas"].ToString();
            lblCliente.Text = lista[1].ToString() + " " + lista[2].ToString() + " " + lista[3].ToString();
            lblPrecio.Text = Request.Cookies["auto"]["precio"].ToString();
            lblStock.Text = Request.Cookies["auto"]["stock"].ToString();
            Image1.ImageUrl = Request.Cookies["auto"]["imagen"].ToString(); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarTelevision.aspx");
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
      {
            int cantidad=0;
            
            if (txtCantidad.Text == "0" || txtCantidad.Text == "")
            {
                txtCantidad.Text = "";
                lblMensaje.Text = "Cantidad no Aceptada";
            }
            else {
                cantidad = Int32.Parse(lblStock.Text) - Int32.Parse(txtCantidad.Text);
            if (cantidad >= 0)
            {
               
                pedido = new PedidoCE();
                pedido.setModelo(lblCodigo.Text);
                pedido.setProveedor(lblProveedor.Text);
                //  pedido.setCliente(lista[3].ToString());
                pedido.setMonto(Double.Parse(lblPrecio.Text));
                pedido.setCantidad(Int32.Parse(txtCantidad.Text));


                pedidobl = new PedidoCR();
                pedidobl.setCarrito((DataTable)Session["carrito"]);
                pedidobl.agregarCarrito(pedido);
                Session["carrito"] = pedidobl.getCarrito();


                txtCantidad.Text = "";
                lblMensaje.Text = "Registro Agregado";
            }
            else {
                txtCantidad.Text = "";
                lblMensaje.Text = "Cantidad no Aceptada";
            }
            }

        }
    }
}