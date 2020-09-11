using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using CapaReglas;
using CapaEntidad;

namespace WebVentas
{
    public partial class MantenerTelevision : System.Web.UI.Page
    {
        TelevisionCR televisioncr = new TelevisionCR();
        TelevisionCE aut = new TelevisionCE();
        string img = "";
        string accion = "";
        List<string> lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            lista = (List<string>)Session["datos"];
            btnEliminar.Attributes.Add("OnClick", "return confirm('¿Seguro que desea eliminar?');");
            btnRegistrar.Attributes.Add("OnClick", "return confirm('¿Desea Continuar?');");
            btnActualizar.Attributes.Add("OnClick", "return confirm('¿Desea Continuar?');");

            if (!Page.IsPostBack)
            {
                if (lista != null)
                {
                    cargarComboprov();
                    cargarCombotec();
                    cargarCombocat();
                    cargarGrid();
                }
                else
                {
                    Response.Redirect("Logueo.aspx");
                }
            }
        }

        void cargarCombocat()
        {
            ddlcodcat.DataSource = televisioncr.listaCategoria();
            ddlcodcat.DataTextField = "descat";
            ddlcodcat.DataValueField = "codcat";
            ddlcodcat.DataBind();

            ddlcodcat.Items.Insert(0, "Seleccione Categoria");
        }

        void cargarCombotec()
        {
            ddlcodtip.DataSource = televisioncr.listaTecnologia();
            ddlcodtip.DataTextField = "destip";
            ddlcodtip.DataValueField = "codtip";
            ddlcodtip.DataBind();

            ddlcodtip.Items.Insert(0, "Seleccione Tecnologia");
        }

        void cargarComboprov()
        {
            ddlidprov.DataSource = televisioncr.listaMarca();
            ddlidprov.DataTextField = "nomprov";
            ddlidprov.DataValueField = "ruc";
            ddlidprov.DataBind();

            ddlidprov.Items.Insert(0, "Seleccione Proveedor");
        }


         void cargarGrid()
        {
            gvTelevision.DataSource = televisioncr.listaTelevision();
            gvTelevision.DataBind();
        }

         protected void btnRegistrar_Click(object sender, EventArgs e)
         {
             accion = "R";
             lblMensaje.Text = "";
             string prov = ddlidprov.SelectedItem.Value;
             string tec = ddlcodtip.SelectedItem.Value;
             string cat = ddlcodcat.SelectedItem.Value;
             string msg = "";

             if (ddlidprov.SelectedIndex == 0)
             {
                 lblMensaje.Text = "Seleccione un Proveedor!";
             }
             else if (ddlcodtip.SelectedIndex == 0)
             {
                 lblMensaje.Text = "Seleccione una Tecnologia!";
             }
             else if (ddlcodcat.SelectedIndex == 0)
             {
                 lblMensaje.Text = "Seleccione una Categoria!";
             }

             else if (txtmodelo.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtprecio.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtprecio.Text.Length < 3)
             {
                 lblMensaje.Text = "Favor corriga el precio";
             }
             else if (txtcaracteristica.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtresolucion.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtstock.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txttamaño.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txttamaño.Text.Length == 1 || txttamaño.Text.Trim() == "0" || txttamaño.Text.Length > 2)
             {
                 lblMensaje.Text = "Favor corriga las pulgadas de la tv";
             }



             else if (cargarImagen() == false)
             {
                 lblMensaje.Text = "Seleccione una Imagen";
             }

             else
             {
                 aut.setModelo(txtmodelo.Text);
                 aut.setIdprov(prov);
                 aut.setCodtip(tec);
                 aut.setCodcat(cat);
                 aut.setResolucion(txtresolucion.Text);
                 aut.setTamaño(txttamaño.Text + "\"");
                 aut.setCaracteristica(txtcaracteristica.Text);
                 aut.setPrecio(Convert.ToDouble(txtprecio.Text));
                 aut.setStock(Convert.ToInt32(txtstock.Text));

                 if (img != "")
                 {
                     aut.setImg(img);
                 }

                 msg = televisioncr.mantenerTelevision(aut, accion);
                 if (msg == "exito")
                 {
                     lblMensaje.Text = "Registro Realizado Con Éxito!";
                     limpiar();
                 }
                 else
                 {
                     lblMensaje.Text = "El codigo que esta ingresando ya existe, Por favor ingrese otro"; 
                     //lblMensaje.Text = msg;
                 }

                 cargarGrid();
             }

             //if (cargarImagen() == false)
             //{
             //    lblMensaje.Text = "Error";
             //}
             //else {
             //    aut.setStock(Convert.ToInt32(txtStock.Text));
             //    aut.setUrl(url);

             //    if (autobl.mantenerAuto(aut) == "exito")
             //    {
             //        lblMensaje.Text = "Registro Exitoso!";
             //    }
             //    else {
             //        lblMensaje.Text = "error";
             //    }
             //}


         }

         void limpiar()
         {
             txtmodelo.Text = "";
             txtprecio.Text = "";

             txtstock.Text = "";
             txtresolucion.Text = "";
             txttamaño.Text = "";
             txtcaracteristica.Text = "";
             ddlidprov.SelectedIndex = 0;
             ddlcodtip.SelectedIndex = 0;
             ddlcodcat.SelectedIndex = 0;
            
             txtmodelo.Enabled = true;
            // FileUpload1.Visible = true;
             Label1.Visible = true;
         }

         protected void btnActualizar_Click(object sender, EventArgs e)
         {
             accion = "A";
            // lblMensaje.Text = "";
             string prov = ddlidprov.SelectedItem.Value;
             string tec = ddlcodtip.SelectedItem.Value;
             string cat = ddlcodcat.SelectedItem.Value;
            // string msg = "";

             if (ddlidprov.SelectedIndex == 0)
             {
                 lblMensaje.Text = "Seleccione un Proveedor!";
             }
    
             else if (ddlcodtip.SelectedIndex == 0)
             {
                 lblMensaje.Text = "Seleccione una Tecnologia!";
             }
        
             else if (ddlcodcat.SelectedIndex == 0)
             {
                 lblMensaje.Text = "Seleccione una Categoria!";
             }

             else if (txtmodelo.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtprecio.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtprecio.Text.Length < 3)
             {
                 lblMensaje.Text = "Favor corriga el precio";
             }
             else if (txtcaracteristica.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtresolucion.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txtstock.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txttamaño.Text.Trim() == "")
             {
                 lblMensaje.Text = "Favor Complete los campos con *";
             }
             else if (txttamaño.Text.Length == 1 || txttamaño.Text.Trim() == "0" || txttamaño.Text.Length > 2)
             {
                 lblMensaje.Text = "Favor corriga las pulgadas de la tv";
             }

             else 
             {
                 aut.setModelo(txtmodelo.Text);
                 aut.setIdprov(prov);
                 aut.setCodtip(tec);
                 aut.setCodcat(cat);
                 aut.setResolucion(txtresolucion.Text);
                 aut.setTamaño(txttamaño.Text + "\"");
                 aut.setCaracteristica(txtcaracteristica.Text);
                 aut.setPrecio(Convert.ToDouble(txtprecio.Text));
                 aut.setStock(Convert.ToInt32(txtstock.Text));
                 aut.setImg(img);

                 lblMensaje.Text = televisioncr.mantenerTelevision(aut, accion);
                 if (lblMensaje.Text == "exito")
                 {
                     lblMensaje.Text = "Registro Actualizado Con Éxito!";
                     btnEliminar.Enabled = false;
                     btnActualizar.Enabled = false;
                     btnRegistrar.Enabled = true;
                     FileUpload1.Visible = true;
                     
                     limpiar();

                    
                     
                 }
                 else
                 {
                     lblMensaje.Text = "sucedio algo";
                 }

                 cargarGrid();
             }

             
         }

         protected void btnEliminar_Click(object sender, EventArgs e)
         {
             accion = "E";
             string prov = ddlidprov.SelectedItem.Value;
             string tec = ddlcodtip.SelectedItem.Value;
             string cat = ddlcodcat.SelectedItem.Value;
             string msg = "";

             aut.setModelo(txtmodelo.Text);
             aut.setIdprov(prov);
             aut.setCodtip(tec);
             aut.setCodcat(cat);
             aut.setResolucion(txtresolucion.Text);
             aut.setTamaño(txttamaño.Text);
             aut.setCaracteristica(txtcaracteristica.Text);
             aut.setPrecio(Convert.ToDouble(txtprecio.Text));
             aut.setStock(Convert.ToInt32(txtstock.Text));
             aut.setImg(img);

             msg = televisioncr.mantenerTelevision(aut, accion);
             if (msg == "exito")
             {
                 lblMensaje.Text = "Registro Eliminado!";
                 btnEliminar.Enabled = false;
                 btnActualizar.Enabled = false;
                 btnRegistrar.Enabled = true;
                
                 FileUpload1.Visible = true;
                 limpiar();
             }
             else
             {
                 lblMensaje.Text = msg;
             }

             cargarGrid();
         }

         protected void gvTelevision_SelectedIndexChanged(object sender, EventArgs e)
         {
             lblMensaje.Text = "";

             string perfil = gvTelevision.SelectedRow.Cells[2].Text;
             string perfil1 = gvTelevision.SelectedRow.Cells[3].Text;
             string perfil2 = gvTelevision.SelectedRow.Cells[1].Text;
             //limpiar();
             //txtprecio.Attributes.Remove("Value");
             txtmodelo.Text = gvTelevision.SelectedRow.Cells[0].Text;
             //ddlidprov.SelectedItem.Value = gvTelevision.SelectedRow.Cells[1].Text;
             //ddlcodtip.SelectedItem.Value = gvTelevision.SelectedRow.Cells[2].Text;
             //ddlcodcat.SelectedItem.Value = gvTelevision.SelectedRow.Cells[3].Text;
             
             txtresolucion.Text = gvTelevision.SelectedRow.Cells[4].Text;
             txttamaño.Text = gvTelevision.SelectedRow.Cells[5].Text;
             

             txtcaracteristica.Text = gvTelevision.SelectedRow.Cells[6].Text;
             //txtprecio.Attributes.Add("Value", gvTelevision.SelectedRow.Cells[7].Text);
             txtprecio.Text = gvTelevision.SelectedRow.Cells[7].Text;
             txtstock.Text = gvTelevision.SelectedRow.Cells[8].Text;
             img = gvTelevision.SelectedDataKey.Value.ToString();

             try
             {
                 if (perfil == "Pantalla de cristal liquido")
                     perfil = "LCD";
                 else if (perfil == "Diodo emisor de luz")
                     perfil = "LED";
                 else if (perfil == "Panel formado por micro capsulas con gas xenon y neon")
                     perfil = "PLASMA";
                 else
                     perfil = "seleccione algo";
                  ddlcodtip.SelectedValue = perfil;
             }
             catch {
                 
                 //ddlcodtip.Items.Insert(0, "Seleccione Tecnologia");
                 ddlcodtip.SelectedIndex = -1;
             }


              try
             {
             if (perfil1 == "3D")
                 perfil1 = "3D";
             else if (perfil1 == "ESTANDAR")
                 perfil1 = "EST";
             else if (perfil1 == "SMART TV + 3D")
                 perfil1 = "S3D";
             else if (perfil1 == "SMART TV")
                 perfil1 = "STV";
             else if (perfil1 == "ULTRA HD")
                 perfil1 = "UHD";
             else
                 perfil1 = "Seleccione";

             ddlcodcat.SelectedValue = perfil1;
             }
               catch {
                   //ddlcodcat.Items.Insert(0, "Seleccione Categoria");
                   ddlcodcat.SelectedIndex = -1;
             }

                try
             {
             if (perfil2 == "PANASONIC")
                 perfil2 = "20100165849";
             else if (perfil2 == "SAMSUNG")
                 perfil2 = "20300263578";
             else if (perfil2 == "SONY")
                 perfil2 = "20372706288";
             else if (perfil2 == "LG")
                 perfil2 = "20375755344";
             else
                 perfil2 = "Seleccione";

             ddlidprov.SelectedValue = perfil2;
             }
                catch
                {
                    //ddlidprov.Items.Insert(0, "Seleccione Proveedor");
                    ddlidprov.SelectedIndex = -1;
             }

             
             txtmodelo.Enabled = false;
             FileUpload1.Visible = false;
             Label1.Visible = false;
             btnEliminar.Enabled = true;
             btnActualizar.Enabled = true;
             btnRegistrar.Enabled = false;

            

         }

         Boolean cargarImagen()
         {
             Boolean fileOK = false;
             Boolean resp = false;
             String path = Server.MapPath("~/images/");

             if (FileUpload1.HasFile)
             {
                 String fileExtension =
                     System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                 String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                 for (int i = 0; i < allowedExtensions.Length; i++)
                 {
                     if (fileExtension == allowedExtensions[i])
                     {
                         fileOK = true;
                     }
                 }
             }

             if (fileOK)
             {
                 try
                 {
                     FileUpload1.PostedFile.SaveAs(path
                         + FileUpload1.FileName);
                     //url = path + FileUpload1.FileName;
                     img = "~/images/" + FileUpload1.FileName;
                     resp = true;
                 }
                 catch (Exception ex)
                 {
                     resp = false;
                 }
             }
             else
             {
                 resp = false;
             }

             return resp;
         }

         protected void gvTelevision_PageIndexChanging(object sender, GridViewPageEventArgs e)
         {
             gvTelevision.PageIndex = e.NewPageIndex;
             cargarGrid();
         }

         protected void btnSalir_Click(object sender, EventArgs e)
         {
             Response.Redirect("Bienvenida.aspx");
         }

         protected void btnCancelar_Click(object sender, EventArgs e)
         {
             limpiar();
             cargarGrid();
             btnEliminar.Enabled = false;
             btnActualizar.Enabled = false;
             btnRegistrar.Enabled = true;
         }


       
    }
}