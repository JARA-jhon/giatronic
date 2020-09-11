using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaReglas;


namespace WebVentas
{
    public partial class Bienvenida : System.Web.UI.Page
    {
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
                else if (lista[9].ToString() == "EMP")
                {
                    this.MasterPageFile = "PrincipalEmpleado.Master";
                }
                else
                {
                    this.MasterPageFile = "PrincipalUsuario.Master";
                }
            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (lista == null)
                {
                    Response.Redirect("Logueo.aspx");
                }
                else
                {

                }
            }
        }


       
    }
}