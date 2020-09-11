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
    public partial class MantenerProveedor : System.Web.UI.Page
    {

        ProveedorCR proveedorbl = new ProveedorCR();
        ProveedorCE prov = new ProveedorCE();
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

        void cargarGridview()
        {
            gvProveedores.DataSource = proveedorbl.listaProveedores();
            gvProveedores.DataBind();
        }

        void limpiar()
        {
            txtruc.Text = "";
            txtruc.Enabled = true;
            txtNom.Text = "";
            txtFono.Text = "";
            txtDir.Text = "";
            txtcon.Text = "";
            txtcor.Text = "";
            txtpro.Text = "";
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            accion = "R";

            if (txtruc.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            if (txtruc.Text.Length != 11)
            {
                lblMensaje.Text = "Favor corriga la cantidad de caracteres del ruc";
            }
            else if (txtNom.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtDir.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtFono.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtFono.Text.Length != 7)
            {
                lblMensaje.Text = "El Numero de telefono es incorrecto";
            }
            else if (txtcon.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtpro.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else
            {
                prov.setRuc(txtruc.Text);
                prov.setNomprov(txtNom.Text);
                prov.setTelefono(txtFono.Text);
                prov.setDireccion(txtDir.Text);
                prov.setContacto(txtcon.Text);
                prov.setCorreo(txtcor.Text);
                prov.setProductos(txtpro.Text);

                if (proveedorbl.mantenerProveedor(prov, accion) == "exito")
                {
                    lblMensaje.Text = "Registro Realizado Con Éxito!";
                    limpiar();
                }
                else
                {
                    lblMensaje.Text = "El codigo que esta ingresando ya existe, Por favor ingrese otro"; 
                    //lblMensaje.Text = proveedorbl.mantenerProveedor(prov, accion);
                }

                cargarGridview();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            accion = "A";

            prov.setRuc(txtruc.Text);
            prov.setNomprov(txtNom.Text);
            prov.setTelefono(txtFono.Text);
            prov.setDireccion(txtDir.Text);

            prov.setCorreo(txtcor.Text);
            prov.setContacto(txtcon.Text);
            prov.setProductos(txtpro.Text);

           if (txtruc.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
           if (txtruc.Text.Length != 11)
           {
               lblMensaje.Text = "Favor corriga la cantidad de caracteres del ruc";
           }
            else if (txtNom.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtDir.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtFono.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
           else if (txtFono.Text.Length != 7)
           {
               lblMensaje.Text = "El Numero de telefono es incorrecto";
           }
            else if (txtcon.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }
            else if (txtpro.Text.Trim() == "")
            {
                lblMensaje.Text = "Favor Complete los campos con *";
            }

           else if (proveedorbl.mantenerProveedor(prov, accion) == "exito")
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
                lblMensaje.Text = proveedorbl.mantenerProveedor(prov, accion);
            }

        
 
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            accion = "E";

            prov.setRuc(txtruc.Text);
            prov.setNomprov(txtNom.Text);
            prov.setTelefono(txtFono.Text);
            prov.setDireccion(txtDir.Text);

            prov.setContacto(txtcon.Text);
            prov.setCorreo(txtcor.Text);
            prov.setProductos(txtpro.Text);
          
            if (proveedorbl.mantenerProveedor(prov, accion) == "exito")
            {
                lblMensaje.Text = "Registro Eliminado!";
                limpiar();
            }
            else
            {
                lblMensaje.Text = proveedorbl.mantenerProveedor(prov, accion);
            }

            cargarGridview();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnRegistrar.Enabled = true;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            cargarGridview();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnRegistrar.Enabled = true;
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bienvenida.aspx");
        }

        protected void gvProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtruc.Text = gvProveedores.SelectedRow.Cells[0].Text;
            txtNom.Text = gvProveedores.SelectedRow.Cells[1].Text;
            txtFono.Text = gvProveedores.SelectedRow.Cells[3].Text;
            txtDir.Text = gvProveedores.SelectedRow.Cells[2].Text;

            txtcon.Text = gvProveedores.SelectedRow.Cells[4].Text;
            txtcor.Text = gvProveedores.SelectedRow.Cells[5].Text;
            txtpro.Text = gvProveedores.SelectedRow.Cells[6].Text;

            txtruc.Enabled = false;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnRegistrar.Enabled = false;
        }

        protected void gvProveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProveedores.PageIndex = e.NewPageIndex;
            cargarGridview();
        }

    }
}