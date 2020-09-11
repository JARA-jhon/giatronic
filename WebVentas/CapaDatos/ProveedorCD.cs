using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;
using CapaEntidad; 


namespace CapaDatos
{
    public class ProveedorCD
    {
        static ConexionSql con = new ConexionSql();
        SqlConnection cn = con.getConexion();

        
        public DataTable listaProveedores()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listaproveedores", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            return dt;
        }

        public string mantenerProveedor(ProveedorCE prov, string accion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_mantenimientoproveedor";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 20).Value = prov.getRuc();
            cmd.Parameters.Add("@nom", SqlDbType.VarChar, 50).Value = prov.getNomprov();
            cmd.Parameters.Add("@dir", SqlDbType.VarChar, 100).Value = prov.getDireccion();
            cmd.Parameters.Add("@tel", SqlDbType.VarChar, 15).Value = prov.getTelefono();
            cmd.Parameters.Add("@con", SqlDbType.VarChar, 100).Value = prov.getContacto();
            cmd.Parameters.Add("@cor", SqlDbType.VarChar, 100).Value = prov.getCorreo();
            cmd.Parameters.Add("@pro", SqlDbType.VarChar, 100).Value = prov.getProductos();
            cmd.Parameters.Add("@accion", SqlDbType.Char, 1).Value = accion;
            
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                return "exito";
            }
            catch (Exception e)
            {
                return "Error" + e.ToString();
            }
            finally
            {
                cmd.Dispose();
                cn.Close();
            }
        }



    }
}
