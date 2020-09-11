
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using CapaReglas;
using CapaEntidad;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace WebVentas
{
    public partial class MantenerPedido : System.Web.UI.Page
    {

     PedidoCR televisioncr = new PedidoCR();
     PedidoCE aut = new PedidoCE();
        string img = "";
        string accion = "";
        List<string> lista;

        protected void Page_Load(object sender, EventArgs e)
        {
  lista = (List<string>)Session["datos"];
            btnEliminar.Attributes.Add("OnClick", "return confirm('¿Seguro que desea eliminar?');");
            
            btnActualizar.Attributes.Add("OnClick", "return confirm('¿Desea Continuar?');");

            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
               
                    cargarCombocat();
                    cargarGrid();
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }
        }

        void cargarCombocat()
        {
            ddlcodcat.DataSource = televisioncr.listaEstados();
            ddlcodcat.DataTextField = "estdesc";
            ddlcodcat.DataValueField = "codest";
            ddlcodcat.DataBind();

            ddlcodcat.Items.Insert(0, "Seleccione Estado");
        }       


         void cargarGrid()
        {
            gvTelevision.DataSource = televisioncr.listaPedido();
            gvTelevision.DataBind();
        }

     

         void limpiar()
         {
             txtmodelo.Text = "";
          
             txtresolucion.Text = "";
             txttamaño.Text = "";
             txtcaracteristica.Text = "";
          
             ddlcodcat.SelectedIndex = 0;
            
             txtmodelo.Enabled = true;
          
            
         }

         protected void btnActualizar_Click(object sender, EventArgs e)
         {
             accion = "A";
             // lblMensaje.Text = "";
          
             string cat = ddlcodcat.SelectedItem.Value;
             // string msg = "";

           if (ddlcodcat.SelectedIndex == 0)
             {
                 lblMensaje.Text = "Seleccione una Categoria!";
             }

             else if (txtmodelo.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
            
             else if (txtcaracteristica.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtresolucion.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
            
             else if (txttamaño.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
          

             else
             {
                 aut.setCodigo(Convert.ToInt32(txtmodelo.Text));
               
                 aut.setEstado(cat);
                 aut.setCliente(txtresolucion.Text);
                 aut.setMonto(Convert.ToDouble(txttamaño.Text));
                 aut.setFecha(Convert.ToDateTime(txtcaracteristica.Text));

                 //aut.setPrecio(Convert.ToDouble(txtprecio.Text));
                 //aut.setStock(Convert.ToInt32(txtstock.Text));
               

                 lblMensaje.Text = televisioncr.mantenerpedido(aut, accion);
                 if (lblMensaje.Text == "exito")
                 {
                     lblMensaje.Text = "Registro Actualizado Con Éxito!";
                     btnEliminar.Enabled = false;
                     btnActualizar.Enabled = false;
                    
                   

                     limpiar();

                 }
                 else
                 {
                     lblMensaje.Text = "sucedio algo";
                 }

                 cargarGrid();
             }

             
         }

         protected void btnEliminar_Click(object sender, EventArgs e)
         {
             accion = "E";
 
             string cat = ddlcodcat.SelectedItem.Value;
             string msg = "";
           
             aut.setCodigo(Convert.ToInt32(txtmodelo.Text));

             aut.setEstado(cat);
             aut.setCliente(txtresolucion.Text);
             aut.setMonto(Convert.ToDouble(txttamaño.Text));
             aut.setFecha(Convert.ToDateTime(txtcaracteristica.Text));


             msg =  televisioncr.mantenerpedido(aut, accion);

             if (msg == "exito")
             {
                 lblMensaje.Text = "Registro Eliminado!";
                 btnEliminar.Enabled = false;
                 btnActualizar.Enabled = false;
               
                 limpiar();
             }
             else
             {
                 lblMensaje.Text = msg;
             }

             cargarGrid();
         }

         protected void gvTelevision_SelectedIndexChanged(object sender, EventArgs e)
         {
             lblMensaje.Text = "";
            
             string perfil1 = gvTelevision.SelectedRow.Cells[4].Text;                     
             txtmodelo.Text = gvTelevision.SelectedRow.Cells[0].Text;            
             txtresolucion.Text = gvTelevision.SelectedRow.Cells[1].Text;
             txttamaño.Text = gvTelevision.SelectedRow.Cells[2].Text;
             txtcaracteristica.Text = gvTelevision.SelectedRow.Cells[3].Text;            

            try
             {
             if (perfil1 == "PENDIENTE")
                 ddlcodcat.SelectedIndex = 2;
             else if (perfil1 == "ATENDIDO")
                 ddlcodcat.SelectedIndex = 1;
             else
                 perfil1 = "Seleccione";             
             }
               catch {                  
                   ddlcodcat.SelectedIndex = -1;
             }
             
             txtmodelo.Enabled = false;
         
             btnEliminar.Enabled = true;
             btnActualizar.Enabled = true;
             

         }

 
         protected void gvTelevision_PageIndexChanging(object sender, GridViewPageEventArgs e)
         {
             gvTelevision.PageIndex = e.NewPageIndex;
             cargarGrid();
         }

         protected void btnSalir_Click(object sender, EventArgs e)
         {
             Response.Redirect("Bienvenida.aspx");
         }

         protected void btnCancelar_Click(object sender, EventArgs e)
         {
             limpiar();
             cargarGrid();
             btnEliminar.Enabled = false;
             btnActualizar.Enabled = false;
             
         }

         static ConexionSql cnx = new ConexionSql();
         
         protected void TextBox1_TextChanged(object sender, EventArgs e)
         {
              SqlConnection cn =  cnx.getConexion();
             {
                 cn.Open();

                 string query = "select [pedcod],[dni],[monto],[fecha],e.[estdesc] as codest from TB_PEDIDOS p inner join TB_ESTADOS e on p.codest=e.codest WHERE pedcod like @cod+'%'";
                 //pedcod like '%'+@cod+'%'"
                 SqlCommand cmd = new SqlCommand(query, cn);
                 cmd.Parameters.AddWithValue("@cod", TextBox1.Text);
                
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 gvTelevision.DataSource = dt;
                 gvTelevision.DataBind();
                 cn.Close();
             }
         }


       
    }
}

