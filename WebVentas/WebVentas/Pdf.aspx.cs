using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace WebVentas
{
    public partial class Pdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridViewData();
            }
        }

        // ADO.NET code to retrieve data from database
        private void BindGridViewData()
        {
            SqlConnection cn = new SqlConnection("server=.;database=GIANTRONIC;uid=sa;pwd=sql");
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from TB_PEDIDOS", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
        //    Document Documento=new Document();
        //    Paragraph parraf=new Paragraph();
        //    PdfPTable tablademo=new PdfPTable(6);
        //    PdfWriter.GetInstance(Documento, new FileStream("D:/FACTURA.pdf", FileMode.Create));
        

        //Documento.Open();
        
        //parraf.Alignment = Element.ALIGN_RIGHT;
        //parraf.Add("ID:" + " " + lblhola.Text);
        
        //parraf.Add(lblhola.Text);
        //Documento.Add(parraf);



        //Documento.Close();

        ////abre el PDF
        //Response.ContentType = "application/pdf";
        //Response.AddHeader("Content-Disposition", "attachment;filename=D:/FACTURA.pdf");
        //Response.TransmitFile("D:/FACTURA.pdf");





        
            int columnsCount = GridView1.HeaderRow.Cells.Count;
            // Create the PDF Table specifying the number of columns
            PdfPTable pdfTable = new PdfPTable(columnsCount);
            
            // Loop thru each cell in GrdiView header row
            foreach (TableCell gridViewHeaderCell in GridView1.HeaderRow.Cells)
            {
                // Create the Font Object for PDF document
                Font font = new Font();
                // Set the font color to GridView header row font color
                font.Color = new BaseColor(GridView1.HeaderStyle.ForeColor);

                // Create the PDF cell, specifying the text and font
                PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));

                // Set the PDF cell backgroundcolor to GridView header row BackgroundColor color
                pdfCell.BackgroundColor = new BaseColor(GridView1.HeaderStyle.BackColor);

                // Add the cell to PDF table
                pdfTable.AddCell(pdfCell);
            }

            // Loop thru each datarow in GrdiView
            foreach (GridViewRow gridViewRow in GridView1.Rows)
            {
                if (gridViewRow.RowType == DataControlRowType.DataRow)
                {
                    // Loop thru each cell in GrdiView data row
                    foreach (TableCell gridViewCell in gridViewRow.Cells)
                    {
                        Font font = new Font();
                        font.Color = new BaseColor(GridView1.RowStyle.ForeColor);

                        PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                        pdfCell.BackgroundColor = new BaseColor(GridView1.RowStyle.BackColor);

                        pdfTable.AddCell(pdfCell);
                    }
                }
            }

            // Create the PDF document specifying page size and margins
            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            //Imagen
            pdfDocument.Open();
          
            //  iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("prod2.jpg");
            
            //tamaño
            //PNG.ScalePercent(25f);
            //posicion
            //PNG.SetAbsolutePosition(pdfDocument.PageSize.Width - 36f - 72f, pdfDocument.PageSize.Height - 36f - 216.6f);

            //  PNG.ScaleToFit(50f,100f);


            //border
            //PNG.Border = iTextSharp.text.Rectangle.BOX;
            //PNG.BorderColor = iTextSharp.text.BaseColor.YELLOW;
            //PNG.BorderWidth = 5f;




            // pdfDocument.Add(PNG);
            pdfDocument.Add(pdfTable);
        
            pdfDocument.Close();
       
            

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition",
                "attachment;filename=Employees.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }
    }
}