using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaReglas;

namespace WebVentas
{
    public partial class ConsultarPedido : System.Web.UI.Page
    {
        PedidoCR pedidobl = new PedidoCR();
        List<string> lista;
        string dni = "";

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
            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    if (lista[9].ToString() == "ADM")
                    {
                        cargarCombo();
                        cargarGrid();
                    }
                    else
                    {
                        dni = lista[0].ToString();
                        cargarCombo();
                        cargarGrid(dni);
                    }
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }
        }

        void cargarCombo()
        {
            ddlEstado.DataSource = pedidobl.listaEstados();
            ddlEstado.DataTextField = "estdesc";
            ddlEstado.DataValueField = "codest";
            ddlEstado.DataBind();

            ddlEstado.Items.Insert(0, "Seleccione Estado");
        }


        void cargarGrid(string dni)
        {
            string est = "";
            int cod = 0;

            try
            {
                cod = Convert.ToInt32(txtNroPedido.Text);
            }
            catch (Exception e)
            {
                cod = 0;
            }

            if (ddlEstado.SelectedIndex == 0)
            {
                est = "";
            }
            else
            {
                est = ddlEstado.SelectedItem.Value;
            }

            gvPedido.DataSource = pedidobl.listaPedidosCliente(dni, cod, est);
            gvPedido.DataBind();

            txtCant.Text = gvPedido.Rows.Count.ToString();
        }


        void cargarGrid()
        {
            gvPedido.DataSource = pedidobl.listaPedidos();
            gvPedido.DataBind();

            txtCant.Text = gvPedido.Rows.Count.ToString();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (lista[9].ToString() == "ADM")
            {
                consultarADM();
            }
            else
            {
                consultarUSU();
            }
        }


        void consultarADM()
        {
            int nro;
            string est;

            try
            {
                nro = Convert.ToInt32(txtNroPedido.Text.Trim());
            }
            catch (Exception a)
            {
                nro = 0;
            }

            if (ddlEstado.SelectedIndex == 0)
            {
                est = "";
            }
            else
            {
                est = ddlEstado.SelectedItem.Value;
            }

            gvPedido.DataSource = pedidobl.listaPedidoxEstado(nro, est);
            gvPedido.DataBind();

            txtCant.Text = gvPedido.Rows.Count.ToString();
        }


        void consultarUSU()
        {
            int nro;
            string est;
            string dni = lista[0].ToString();

            try
            {
                nro = Convert.ToInt32(txtNroPedido.Text.Trim());
            }
            catch (Exception a)
            {
                nro = 0;
            }

            if (ddlEstado.SelectedIndex == 0)
            {
                est = "";
            }
            else
            {
                est = ddlEstado.SelectedItem.Value;
            }

            gvPedido.DataSource = pedidobl.listaPedidosCliente(dni, nro, est);
            gvPedido.DataBind();

            txtCant.Text = gvPedido.Rows.Count.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bienvenida.aspx");
        }

        protected void gvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = gvPedido.SelectedRow.Cells[0].Text;

            HttpCookie cookie = new HttpCookie("pedido");
            cookie.Values.Add("codigo", codigo);

            Response.Cookies.Add(cookie);
            Response.Redirect("DetallePedido.aspx");
        }

        protected void gvPedido_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPedido.PageIndex = e.NewPageIndex;
            gvPedido.DataSource = pedidobl.listaPedidos();
            gvPedido.DataBind();

            txtCant.Text = gvPedido.Rows.Count.ToString();
        }

 
    }
}