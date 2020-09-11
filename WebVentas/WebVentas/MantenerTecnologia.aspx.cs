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
    public partial class MantenerTecnologia : System.Web.UI.Page
    {
        TecnologiaCR tecnologiacr = new TecnologiaCR();
        TecnologiaCE tec = new TecnologiaCE();
        string accion = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> lista = (List<string>)Session["datos"];

            btnEliminar.Attributes.Add("OnClick", "return confirm('¿Seguro que desea eliminar?');");
            btnActualizar.Attributes.Add("OnClick", "return confirm('¿Desea Continuar?');");
            btnRegistrar.Attributes.Add("OnClick", "return confirm('¿Desea Continuar?');");

            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    if (lista[9].ToString() == "ADM")
                    {
                        cargarGridview();
                        btnActualizar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }

        }

        private void cargarGridview()
        {
            gvTecnologia.DataSource = tecnologiacr.listaTecnologia();
            gvTecnologia.DataBind();
        }

        void limpiar()
        {
            txtcodtip.Text = "";
            txtcodtip.Enabled = true;
            txtdestip.Text = "";
            txtdurabilidad.Text = "";
        
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            accion = "R";

            if (txtcodtip.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtdestip.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtdurabilidad.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else
            {
                tec.setCodtip(txtcodtip.Text);
                tec.setDestip(txtdestip.Text);
                tec.setDurabilidad(txtdurabilidad.Text);
                

                if (tecnologiacr.mantenerTecnologia(tec, accion) == "exito")
                {
                    lblMensaje.Text = "Registro Realizado Con Éxito!";
                    limpiar();
                }
                else
                {
                   // lblMensaje.Text = tecnologiacr.mantenerTecnologia(tec, accion);
                    lblMensaje.Text = "El codigo que esta ingresando ya existe, Por favor ingrese otro";
                }

                cargarGridview();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            accion = "A";

            tec.setCodtip(txtcodtip.Text);
            tec.setDestip(txtdestip.Text);
            tec.setDurabilidad(txtdurabilidad.Text);
            
          
            if (txtdestip.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtdurabilidad.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (tecnologiacr.mantenerTecnologia(tec, accion) == "exito")
            {
                lblMensaje.Text = "Registro Actualizado Con Éxito!";
                limpiar();
                cargarGridview();
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                btnRegistrar.Enabled = true;
            }
    
            else
            {
                lblMensaje.Text = tecnologiacr.mantenerTecnologia(tec, accion);
            }

         
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            accion = "E";

            tec.setCodtip(txtcodtip.Text);
            tec.setDestip(txtdestip.Text);
            tec.setDurabilidad(txtdurabilidad.Text);
            

            if (tecnologiacr.mantenerTecnologia(tec, accion) == "exito")
            {
                lblMensaje.Text = "Registro Eliminado!";
                limpiar();
            }
            else
            {
                lblMensaje.Text = "No se puede eliminar la tecnologia por que esta en uso por la tabla Producto";
                //tecnologiacr.mantenerTecnologia(tec, accion)
            }

            cargarGridview();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnRegistrar.Enabled = true;
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bienvenida.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            cargarGridview();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnRegistrar.Enabled = true;
        }

        protected void gvTecnologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcodtip.Text = gvTecnologia.SelectedRow.Cells[0].Text;
            txtdestip.Text = gvTecnologia.SelectedRow.Cells[1].Text;
            txtdurabilidad.Text = gvTecnologia.SelectedRow.Cells[2].Text;
            
            txtcodtip.Enabled = false;

            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnRegistrar.Enabled = false;
        }

        protected void gvTecnologia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTecnologia.PageIndex = e.NewPageIndex;
            cargarGridview();
        }


    }
}