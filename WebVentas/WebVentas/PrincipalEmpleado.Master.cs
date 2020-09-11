using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVentas
{
    public partial class PrincipalEmpleado : System.Web.UI.MasterPage
    {
        List<string> lista;
        protected void Page_Load(object sender, EventArgs e)
        {             
            lista = (List<string>)Session["datos"];
            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    //lblUsuario.Text = Session["usuario"].ToString();
                    lblUsuario.Text = lista[1].ToString() + " " + lista[2].Substring(0, 1) + "." + lista[3].Substring(0, 1);
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Logueo.aspx");
        }
    }
}