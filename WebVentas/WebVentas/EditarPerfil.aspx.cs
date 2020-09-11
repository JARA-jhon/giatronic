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
    public partial class EditarPerfil : System.Web.UI.Page
    {
        UsuarioCR usubl = new UsuarioCR();
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
            btnGCambios.Attributes.Add("OnClick", "return confirm('¿Desea Guardar cambios?');");

            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    cargarDatos();
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }
        }

        void cargarDatos()
        {
            UsuarioCE usu = usubl.obtieneDatosUsuario(lista[0].ToString());

            if (usu != null)
            {
                txtNom.Text = usu.getNombre();
                txtApep.Text = usu.getApellidop();
                txtApem.Text = usu.getApellidom();
                txtEmail.Text = usu.getCorreo();
                txtTel.Text = usu.getTelefono();
                txtDir.Text = usu.getDireccion();
                txtNic.Text = usu.getNick();
                
            }
            else
            {
                lblMensaje.Text = "Error!: Consulte a su Departamento de Sistemas";
            }

        }


        protected void btnGCambios_Click(object sender, EventArgs e)
        {
            string accion = "A";
            string msg = "";

            UsuarioCE usu = new UsuarioCE();
            usu.setNombre(txtNom.Text);
            usu.setApellidop(txtApep.Text);
            usu.setApellidom(txtApem.Text);
            usu.setCorreo(txtEmail.Text);
            usu.setTelefono(txtTel.Text);
            usu.setDireccion(txtDir.Text);
            usu.setNick(txtNic.Text);
            usu.setDni(lista[0].ToString());
            usu.setPerfil(lista[9].ToString());

            if (txtPas.Text != "" || txtCPas.Text != "")
            {
                if (txtPas.Text == txtCPas.Text)
                {
                    usu.setContraseña(txtCPas.Text);

                    msg = usubl.mantenerUsuario(usu, accion);
                    if (msg == "exito")
                    {
                        lblMensaje.Text = "Cambios Guardados";
                        limpiar();
                    }
                    else
                    {
                        lblMensaje.Text = msg;
                    }
                }
                else
                {
                    if (txtPas.Text == "")
                    {
                        lblMensaje.Text = "Ingrese Nueva Contraseña!";
                    }
                    else if (txtCPas.Text == "")
                    {
                        lblMensaje.Text = "Falta Confirmar Contraseña!";
                    }
                    else
                    {
                        lblMensaje.Text = "Las Contraseñas no Coinciden!";
                        limpiar();
                    }
                }
            }
            else
            {
                usu.setContraseña(lista[8].ToString());

                msg = usubl.mantenerUsuario(usu, accion);
                if (msg == "exito")
                {
                    lblMensaje.Text = "Cambios Guardados";
                    limpiar();
                }
                else
                {
                    lblMensaje.Text = msg;
                }
            }
        }

        void limpiar()
        {
            txtPas.Text = "";
            txtCPas.Text = "";
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bienvenida.aspx");
        }



    }
}