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
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;

using CapaReglas;
using CapaEntidad;

namespace WebVentas
{
    public partial class VerCarrito : System.Web.UI.Page
    {
        PedidoCR p = new PedidoCR();
        
        List<string> lista;
        DataTable tabla;
    

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
            gvCarrito.Attributes.Add("OnClick", "return confirm('¿Seguro que desea eliminar?');");
            
            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    if (Session["carrito"] != null)
                    {
                        cargarDatos();
                        //Label2.Text = p.codigo().ToString();
                        
                    }
                    else
                    {
                        Label1.Visible = false;
                        lblTotal.Text = "No Hay Productos en el Carrito";
                        Button2.Enabled = false;
                        //Label2.Text = p.codigo().ToString();
                    }
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarTelevision.aspx");
        }

        protected void gvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabla = (DataTable)Session["carrito"];
            p.setCarrito(tabla);
            string modelo = gvCarrito.SelectedRow.Cells[1].Text;
       
            p.eliminarCarrito(modelo);
          
            cargarDatos();
            gvCarrito.DataBind();
        }

        private void cargarDatos()
        {
            tabla = (DataTable)Session["carrito"];
            p.setCarrito(tabla);
            gvCarrito.DataSource = p.getCarrito();
            gvCarrito.DataBind();

            lblmensaje2.Text = "Al Realizar el Pedido el sistema <br>generará un documento con los datos <br>del producto previamente solicitado.<br> Su pedido sera atendido cuando <br>se verifique la respectiva cancelacion. <br> Para cualquier consulta o <br>molestia usted puede mandarnos <br>su mensaje a nuestra pagina <br>de ";
            lblTotal.Text = p.Total().ToString();
            lbligv.Text = p.Igv().ToString();
            lblneto.Text = p.Neto().ToString();
            lbldescuento.Text = p.Des().ToString();
            
                           
            //Button2.Enabled = true;
        }

        public void generardoc() {
         
            PrepareForExport(gvCarrito);
            ExportToPDF();
        }

        private void PrepareForExport(Control ctrl)
        {            
            foreach (Control childControl in ctrl.Controls)
            {           
                if (childControl.GetType() == typeof(LinkButton))
                { ctrl.Controls.Remove(childControl);
                }else if (childControl.HasControls()){
                    PrepareForExport(childControl);
                }
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        { }

        private void ExportToPDF()
        {             
            int colCount = gvCarrito.Columns.Count - 1;
             
    PdfPTable table = new PdfPTable(colCount);           
    table.HorizontalAlignment = 0;
     
    int[] colWidths = new int[gvCarrito.Columns.Count];
 
    PdfPCell cell;
    string cellText;
    
    for (int colIndex = 0; colIndex < colCount; colIndex++)
    {
        colWidths[colIndex] = (int)gvCarrito.Columns[colIndex].ItemStyle.Width.Value;
        cellText = Server.HtmlDecode(gvCarrito.HeaderRow.Cells[colIndex].Text);
        cell = new PdfPCell(new Phrase(cellText));
        cell.BackgroundColor = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#d1dbe0"));
        table.AddCell(cell);
    }
     for (int rowIndex = 0; rowIndex < gvCarrito.Rows.Count; rowIndex++)
    {
        if (gvCarrito.Rows[rowIndex].RowType == DataControlRowType.DataRow)
        {
            for (int j = 0; j < gvCarrito.Columns.Count - 1; j++)
            {          
                cellText = Server.HtmlDecode(gvCarrito.Rows[rowIndex].Cells[j].Text);
 
                cell = new PdfPCell(new Phrase(cellText));
                
                if (rowIndex % 2 != 0)
                {
                 cell.BackgroundColor = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#9ab2ca"));                       
                }
                else
                {
                 cell.BackgroundColor = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#f1f5f6"));
                }
              
                table.AddCell(cell);
            }
        }
    } 

    Document pdfDoc = new Document(PageSize.A4, 30f, 30f, 30f, 30f);

    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
     
    pdfDoc.Open();

    //imagen
 //   iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("C:/Users/-Dabiddo/Desktop/Nueva carpeta (4)/AplicacionGiantronic/WebVentas/WebVentas/images/Encabezado.jpg");
            //C:/Users/-Dabiddo/Desktop/Nueva carpeta (4)/WebVentas/WebVentas
            //C:/Users/-Dabiddo/Desktop/Empezando con web form/WebVentas/WebVentas/images/Encabezado.jpg
//C:/Users/-Dabiddo/Desktop/Nueva carpeta (4)/AplicacionGiantronic/WebVentas/WebVentas/images/Encabezado.jpg
            
    //tamaño
   // PNG.ScalePercent(64f);
    //posicion
    

    //PNG.ScaleToFit(50f, 100f);

  //  iTextSharp.text.Image PNG4 = iTextSharp.text.Image.GetInstance("C:/Users/-Dabiddo/Desktop/Nueva carpeta (4)/AplicacionGiantronic/WebVentas/WebVentas/images/4k.jpg");
            //C:/Users/-Dabiddo/Desktop/Empezando con web form/WebVentas/WebVentas/images/4k.jpg

    //tamaño
    //PNG4.ScalePercent(67f);
    //PNG4.SetAbsolutePosition(pdfDoc.PageSize.Width - 100f - 410f, pdfDoc.PageSize.Height - 130f - 700f);
    
    Paragraph cuerpoExt = new Paragraph("Monto Total :", new Font(Font.NORMAL, 12));
    Paragraph codigo = new Paragraph("CODIGO DE PAGO       :", new Font(Font.NORMAL, 16));
    Paragraph pedido = new Paragraph("N°Pedido       :", new Font(Font.NORMAL, 16));
    Paragraph orden = new Paragraph("N° de Orden       :", new Font(Font.NORMAL, 14));
    Paragraph cliente = new Paragraph("DATOS DEL CLIENTE:", new Font(Font.NORMAL, 14));
    Paragraph dni = new Paragraph("Dni       :", new Font(Font.NORMAL, 12));
    Paragraph Nombre = new Paragraph("Nombre    :", new Font(Font.NORMAL, 12));
    Paragraph Apellidos = new Paragraph("Apellidos :", new Font(Font.NORMAL, 12));
    Paragraph Destino = new Paragraph("Destino   :", new Font(Font.NORMAL, 12));
    Paragraph separador = new Paragraph("-----------------------------------------------------------", new Font(Font.NORMAL, 14));
    Paragraph enter = new Paragraph("                                                               ", new Font(Font.NORMAL, 14 ));
    Paragraph producto = new Paragraph("DATOS DEL PRODUCTO:", new Font(Font.NORMAL, 14));
    Paragraph pago = new Paragraph("DATOS DE PRECIO", new Font(Font.NORMAL, 14));
    Paragraph bruto = new Paragraph("Bruto      :", new Font(Font.NORMAL, 12));
    Paragraph igv = new Paragraph("Igv        :", new Font(Font.NORMAL, 12));
    Paragraph descuento = new Paragraph("Descuento  :", new Font(Font.NORMAL, 12));
    Paragraph neto = new Paragraph("Neto       :", new Font(Font.NORMAL, 12));
   
    cuerpoExt.Alignment = Element.ALIGN_RIGHT;    
           
    codigo.Add(" " + 00000001716618);
            pedido.Add("" + (p.codigo()-1).ToString());
            cuerpoExt.Add(" "+lblTotal.Text);
            dni.Add(" " + lista[0].ToString());
            Nombre.Add(" " + lista[1].ToString());
            Apellidos.Add(" " + lista[2].ToString() + " " + lista[3].ToString());
            Destino.Add(" " + lista[6].ToString());

            bruto.Add(" " + lblTotal.Text);
            igv.Add(" " + lbligv.Text);
            descuento.Add(" " + lbldescuento.Text);
            neto.Add(" " + lblneto.Text);

   // pdfDoc.Add(PNG);
    pdfDoc.Add(enter);
    pdfDoc.Add(codigo);
    pdfDoc.Add(pedido);
    //pdfDoc.Add(orden);           
    pdfDoc.Add(separador); 
    pdfDoc.Add(cliente);
    pdfDoc.Add(separador);
    pdfDoc.Add(dni);
    pdfDoc.Add(Nombre);
    pdfDoc.Add(Apellidos);
    pdfDoc.Add(Destino);
            
    pdfDoc.Add(separador);
    pdfDoc.Add(producto);
    pdfDoc.Add(separador);
    pdfDoc.Add(table);

    pdfDoc.Add(separador);
    pdfDoc.Add(pago);
    pdfDoc.Add(separador);
    pdfDoc.Add(bruto);
    pdfDoc.Add(igv);
    pdfDoc.Add(descuento);
    pdfDoc.Add(neto);
   // pdfDoc.Add(PNG4);

    pdfDoc.Close();
 
    Response.ContentType = "application/pdf";
    Response.AddHeader("content-disposition", "attachment;" + "filename=Product.pdf");
    Response.Cache.SetCacheability(HttpCacheability.NoCache);
    Response.Write(pdfDoc);
    Response.End();

}
        protected void Button2_Click(object sender, EventArgs e)
        {
          
            tabla = (DataTable)Session["carrito"];
            string msg = "";
            PedidoCE pedido = new PedidoCE();
           
            
            if (lblTotal.Text == "0")
                {
                    lblTotal.Text = "0";
                    lblMensaje.Text = "No hay productos";
                    limpiar();

                }

                if (lblTotal.Text != "0")
                {
                
                    pedido.setCliente(lista[0].ToString());
                    pedido.setMonto(Convert.ToDouble(lblTotal.Text));
                    msg = p.registrarPedido(pedido, tabla);

                    if (msg == "exito")
                    {


                      
                        Session.Remove("carrito");
                        generardoc();
                        cargarDatos();
                        Button2.Enabled = false;
                        
                        gvCarrito.Enabled = false;                   
                    }
                    else
                    {
                        lblTotal.Text = "0";
                        lblMensaje.Text = "No hay productos";
                        limpiar();
                        
                    }
                }
            }
                      
        

        protected void Button3_Click(object sender, EventArgs e)
        {
            limpiar();
         }

        

        void limpiar() {
            gvCarrito.DataSourceID = "";
            gvCarrito.DataBind();
            cargarDatos();
        }
    }
}