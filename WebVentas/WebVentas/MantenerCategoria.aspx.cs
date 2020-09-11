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
    public partial class MantenerCategoria : System.Web.UI.Page
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
            gvTecnologia.DataSource = tecnologiacr.listacategoria();
            gvTecnologia.DataBind();
        }

        void limpiar()
        {
            txtcodcat.Text = "";
            txtcodcat.Enabled = true;
            txtdescat.Text = "";
            txtdetalle.Text = "";

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            accion = "R";

            if (txtcodcat.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtdescat.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtdetalle.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else
            {
                tec.setCodcat(txtcodcat.Text);
                tec.setDescat(txtdescat.Text);
                tec.setDetalle(txtdetalle.Text);


                if (tecnologiacr.mantenercategoria(tec, accion) == "exito")
                {
                    lblMensaje.Text = "Registro Realizado Con Éxito!";
                    limpiar();
                }
                else
                {
                    lblMensaje.Text = "El codigo que esta ingresando ya existe, Por favor ingrese otro";
                    //lblMensaje.Text = tecnologiacr.mantenercategoria(tec, accion);
                }

                cargarGridview();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            accion = "A";

            tec.setCodcat(txtcodcat.Text);
            tec.setDescat(txtdescat.Text);
            tec.setDetalle(txtdetalle.Text);

            if (txtdescat.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtdetalle.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            } 
            else if (tecnologiacr.mantenercategoria(tec, accion) == "exito")
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
                lblMensaje.Text = tecnologiacr.mantenercategoria(tec, accion);
            }

       
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            accion = "E";

            tec.setCodcat(txtcodcat.Text);
            tec.setDescat(txtdescat.Text);
            tec.setDetalle(txtdetalle.Text);


            if (tecnologiacr.mantenercategoria(tec, accion) == "exito")
            {
                lblMensaje.Text = "Registro Eliminado!";
                limpiar();
            }
            else
            {
                lblMensaje.Text = "No se puede eliminar la categoria por que esta en uso por la tabla Producto";
                //lblMensaje.Text = tecnologiacr.mantenercategoria(tec, accion);
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
            txtcodcat.Text = gvTecnologia.SelectedRow.Cells[0].Text;
            txtdescat.Text = gvTecnologia.SelectedRow.Cells[1].Text;
            txtdetalle.Text = gvTecnologia.SelectedRow.Cells[2].Text;

            txtcodcat.Enabled = false;

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