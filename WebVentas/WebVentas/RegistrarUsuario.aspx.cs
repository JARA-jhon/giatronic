using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaReglas;
namespace WebVentas
{
    public partial class RegistrarUsuario : System.Web.UI.Page
    {
        UsuarioCR usuariobl = new UsuarioCR();
        UsuarioCE usu = new UsuarioCE();
        string accion = "";
        List<string> lista;
        string contraseña;

 

        protected void Page_PreInit(object sender, EventArgs e)
        {
            lista = (List<string>)Session["datos"];
            if (lista != null)
            {
                if (lista[9].ToString() == "ADM")
                {
                    this.MasterPageFile = "PrincipalAdministrador.Master";
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
//            cargarGridview();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            Button1.Enabled = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            btnEliminar.Attributes.Add("OnClick", "return confirm('¿Seguro que desea eliminar?');");
            btnActualizar.Attributes.Add("OnClick", "return confirm('¿Desea Continuar?');");
            Button1.Attributes.Add("OnClick", "return confirm('¿Desea Continuar?');");

            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    if (lista[9].ToString() == "ADM")
                    {
                        lblPerfil.Visible = true;
                        ddlPerfil.Visible = true;
                        cargarCombo();
                        cargarGridview();
                        btnEliminar.Enabled = false;
                        btnEliminar.Visible = true;
                        gvUsuarios.Enabled = true;
                        gvUsuarios.Visible = true;
                        btnActualizar.Enabled = false;
                        btnActualizar.Visible = true;
                    }
                }
                else
                {
                    ddlPerfil.Enabled = false;
                }
            }
        }


        void cargarCombo()
        {
            ddlPerfil.DataSource = usuariobl.listaPerfiles();
            ddlPerfil.DataTextField = "descperf";
            ddlPerfil.DataValueField = "codperf";
            ddlPerfil.DataBind();
        }

        void cargarGridview()
        {
            gvUsuarios.DataSource = usuariobl.listaUsuarios();
            gvUsuarios.DataBind();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
           
            accion = "R";
            string perfil = "";

            if (ddlPerfil.Enabled == true)
            {
                perfil = ddlPerfil.SelectedItem.Value.ToString();
            }

            if (txtNom.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
            else if (txtApep.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
            else if (txtPass.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete la contraseña de dicho usuario";
            }
            else if (txtApem.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
            else if (txtDir.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
            else if (txtTel.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
            else if (txtTel.Text.Length != 7 )
            {
                lblMensaje.Text = "El Numero de telefono es incorrecto";
            }
            else if (txtDni.Text.Trim() == "" )
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
            else if (txtDni.Text.Trim() == "00000000")
            {
                lblMensaje.Text = "00000000 es incorrecto";
            }
            else if (txtDni.Text.Length != 8)
            {
                lblMensaje.Text = "El DNI ingresado es Invalido";
            }
            else if (txtNic.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
            else if (txtEmail.Text.Trim() == "")
            {
                lblMensaje.Text = "Complete los Campos con *";
            }
       
            else
            {
                usu.setNombre(txtNom.Text);
                usu.setApellidop(txtApep.Text);
                usu.setApellidom(txtApem.Text);
                usu.setTelefono(txtTel.Text);
                usu.setDireccion(txtDir.Text);
                usu.setDni(txtDni.Text);
                usu.setNick(txtNic.Text);
                usu.setCorreo(txtEmail.Text);
                usu.setContraseña(txtPass.Text);
                usu.setPerfil(perfil);
                
                if (usuariobl.mantenerUsuario(usu, accion) == "exito")
                {
                    lblMensaje.Text = "Registro Realizado Con Éxito!";
                    limpiar();
                }
                else
                {
                    lblMensaje.Text = usuariobl.mantenerUsuario(usu, accion);
                }

                if (lista != null)
                {
                    if (lista[9].ToString() == "ADM")
                    {
                        cargarGridview();
                    }
                }
            }

        }
               void limpiar()
        {
            txtDni.Text = "";
            txtNom.Text = "";
            txtApep.Text = "";
            txtApem.Text = "";
            txtTel.Text = "";
            txtDir.Text = "";
            txtNic.Text = "";
            txtPass.Text = "";
            txtEmail.Text = "";
            //ddlPerfil.Text = "";
            txtDni.Enabled = true;

         
        }


               protected void Button2_Click(object sender, EventArgs e)
               {
                   if (ddlPerfil.Enabled == false)
                   {
                       Response.Redirect("Logueo.aspx");
                   }
                   else
                   {
                       //Response.Redirect("ConsultarAutos.aspx");
                   }
               }

               protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
               {
                   gvUsuarios.PageIndex = e.NewPageIndex;
                   cargarGridview();
               }


               protected void btnActualizar_Click(object sender, EventArgs e)
               {
                   accion = "A";
                   string perfil = "";

                   
                   if (txtNom.Text.Trim() == "")
                   {
                       lblMensaje.Text = "Complete los Campos con *";
                   }
                   else if (txtApep.Text.Trim() == "")
                   {
                       lblMensaje.Text = "Complete los Campos con *";
                   }          
                   else if (txtApem.Text.Trim() == "")
                   {
                       lblMensaje.Text = "Complete los Campos con *";
                   }
                   else if (txtDir.Text.Trim() == "")
                   {
                       lblMensaje.Text = "Complete los Campos con *";
                   }
                   else if (txtTel.Text.Trim() == "")
                   {
                       lblMensaje.Text = "Complete los Campos con *";
                   }
                   else if (txtDni.Text.Trim() == "")
                   {
                       lblMensaje.Text = "Complete los Campos con *";
                   }
                   else if (txtDni.Text.Length != 8)
                   {
                       lblMensaje.Text = "El DNI ingresado es Invalido";
                   }
                   else if (txtNic.Text.Trim() == "")
                   {
                       lblMensaje.Text = "Complete los Campos con *";
                   }
                   else if (txtEmail.Text.Trim() == "")
                   {
                      lblMensaje.Text = "Complete los Campos con *";
                   }

                  
                   else {
                       if (ddlPerfil.Enabled == true)
                       {
                           perfil = ddlPerfil.SelectedItem.Value.ToString();
                       }
                   usu.setNombre(txtNom.Text);
                   usu.setApellidop(txtApep.Text);
                   usu.setApellidom(txtApem.Text);
                   //ESTE estaba con el pass de arriba declarado
                  
                   usu.setDireccion(txtDir.Text);
                   usu.setDni(txtDni.Text);
                   usu.setCorreo(txtEmail.Text);
                   usu.setTelefono(txtTel.Text);
                   usu.setNick(txtNic.Text);
                   usu.setPerfil(perfil);
                   
                   if (txtPass.Text != "")
                 {
                     usu.setContraseña(txtPass.Text);
            
                }
                else
                {
                    usu.setContraseña(txtpass2.Text);
                }



                   if (usuariobl.mantenerUsuario(usu, accion) == "exito")
                   {
                       lblMensaje.Text = "Registro Actualizado Con Éxito!";
                       cargarGridview();
                       txtDni.Enabled = true;
                       Button1.Enabled = true;
                       btnEliminar.Enabled = false;
                       btnActualizar.Enabled = false;
                       limpiar();
                       ddlPerfil.SelectedIndex = 0;
                   }
                   else
                   {
                       lblMensaje.Text = "Complete las cajas con * o si no es el caso cambie el nombre de su nick";
                       txtDni.Enabled = false;
                      
                   }

               }
               }

               protected void btnEliminar_Click(object sender, EventArgs e)
               {
                   accion = "E";
                   string perfil = "";
                   string msg = "";

                   if (ddlPerfil.Enabled == true)
                   {
                       perfil = ddlPerfil.SelectedItem.Value.ToString();
                   }

                   usu.setDni(txtDni.Text);
                   usu.setNombre(txtNom.Text);
                   usu.setApellidop(txtApep.Text);
                   usu.setApellidom(txtApem.Text);
                   usu.setCorreo(txtEmail.Text);
                   usu.setTelefono(txtTel.Text);
                   usu.setDireccion(txtDir.Text);
                   usu.setNick(txtNic.Text);
                   usu.setContraseña(txtPass.Text);
                   usu.setPerfil(perfil);

                   msg = usuariobl.mantenerUsuario(usu, accion);

                   if (msg == "exito")
                   {
                       lblMensaje.Text = "Registro Eliminado!";
                       limpiar();
                   }
                   else
                   {
                       lblMensaje.Text = msg;
                   }

                   cargarGridview();
                   txtDni.Enabled = true;
                   Button1.Enabled = true;
               }

               protected void btnSalir_Click(object sender, EventArgs e)
               {
                   if (lista != null)
                   {
                       if (lista[9].ToString() != "USU")
                       {
                           Response.Redirect("Bienvenida.aspx");
                       }
                       else
                       {
                           Response.Redirect("Logueo.aspx");
                       }
                   }
                   else
                   {
                       Response.Redirect("Logueo.aspx");
                   }
               }

               protected void gvAutos_SelectedIndexChanged(object sender, EventArgs e)
               {
                  
                   string perfil = gvUsuarios.SelectedRow.Cells[9].Text;
                   contraseña = gvUsuarios.SelectedDataKey.Value.ToString();
                   

                   txtNom.Text = gvUsuarios.SelectedRow.Cells[1].Text;
                   txtApep.Text = gvUsuarios.SelectedRow.Cells[2].Text;
                   txtApem.Text = gvUsuarios.SelectedRow.Cells[3].Text;
                   txtTel.Text = gvUsuarios.SelectedRow.Cells[5].Text;
                   txtNic.Text = gvUsuarios.SelectedRow.Cells[7].Text;
                   txtpass2.Text = gvUsuarios.SelectedRow.Cells[8].Text;
                   //txtPass.Text = Convert.ToString(gvUsuarios.DataKeys[gvUsuarios.SelectedRow.RowIndex].Values["contraseña"]);
                   txtDir.Text = gvUsuarios.SelectedRow.Cells[6].Text;
                   txtDni.Text = gvUsuarios.SelectedRow.Cells[0].Text;
                   txtEmail.Text = gvUsuarios.SelectedRow.Cells[4].Text;

                   if (perfil == "ADMINISTRADOR")
                       perfil = "ADM";
                   else if (perfil == "EMPLEADO")
                       perfil = "EMP";
                   else
                       perfil = "USU";


                   ddlPerfil.SelectedValue = perfil;
                   txtDni.Enabled = false;

                   btnActualizar.Enabled = true;
                   btnEliminar.Enabled = true;
                   Button1.Enabled = false;
               }

               protected void ddlPerfil_SelectedIndexChanged(object sender, EventArgs e)
               {

               }

               protected void txtDni_TextChanged(object sender, EventArgs e)
               {

               }
          
        }

    }
