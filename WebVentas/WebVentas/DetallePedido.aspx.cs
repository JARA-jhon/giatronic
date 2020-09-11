using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using CapaReglas;



namespace WebVentas
{
    public partial class DetallePedido : System.Web.UI.Page
    {
        PedidoCR pedidobl = new PedidoCR();
        int cod = 0;
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
                else
                {
                    this.MasterPageFile = "PrincipalCliente.Master";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lista = (List<string>)Session["datos"];
            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    if (Request.Cookies["pedido"] != null)
                    {
                        cargarDataList();
                    }
                    else
                    {
                        Response.Redirect("ConsultarPedido.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }
        }

        void cargarDataList()
        {
            cod = Convert.ToInt32(Request.Cookies["pedido"]["codigo"].ToString());

            dlDetalle.DataSource = pedidobl.listaPedidoDetalle(cod);
            dlDetalle.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarPedido.aspx");
        }

        protected void btnimprimir_Click(object sender, EventArgs e)
        {
            
            Document Documento = new Document();
            Paragraph parraf = new Paragraph();
            PdfPTable tablademo = new PdfPTable(6);
            PdfWriter.GetInstance(Documento, new FileStream("D:/FACTURA.pdf", FileMode.Create));


            Documento.Open();

            parraf.Alignment = Element.ALIGN_RIGHT;
            parraf.Add("ID:" + "ssss" );
              
            //parraf.Add(lista);
            Documento.Add(parraf);


            

            Documento.Close();

            //abre el PDF
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment;filename=D:/FACTURA.pdf");
            Response.TransmitFile("D:/FACTURA.pdf");
        }

        protected void dlDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}