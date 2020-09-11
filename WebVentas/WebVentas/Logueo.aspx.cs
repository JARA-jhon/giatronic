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
    public partial class Logueo : System.Web.UI.Page
    {

        UsuarioCR usuariocr = new UsuarioCR();
        UsuarioCE usuarioce = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        


            string usu = txtUsuario.Text;
            string pass = txtPass.Text;

            usuarioce = usuariocr.obtenerUsuario(usu, pass);

            if (usuarioce != null)
            {
                List<string> lista = new List<string>();
                lista.Add(usuarioce.getDni().ToString());
                lista.Add(usuarioce.getNombre().ToString());
                lista.Add(usuarioce.getApellidop().ToString());
                lista.Add(usuarioce.getApellidom().ToString());
                lista.Add(usuarioce.getCorreo().ToString());
                lista.Add(usuarioce.getTelefono().ToString());
                lista.Add(usuarioce.getDireccion().ToString());
                lista.Add(usuarioce.getNick().ToString());
                lista.Add(usuarioce.getContraseña().ToString());
                lista.Add(usuarioce.getPerfil().ToString());


                Session["datos"] = lista;

                Response.Redirect("Bienvenida.aspx");
            }
            else
            {
                lblMensaje.Text = "Error, Usuario o Password Incorrectos!";
                limpiar();
            }
         }

        void limpiar()
        {
            txtPass.Text = "";
            txtUsuario.Text = "";
        }

    }
}