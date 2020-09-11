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
    public class TelevisionCD
    {
        static ConexionSql cnx = new ConexionSql();
        SqlConnection cn = cnx.getConexion();

        public DataTable listaMarca()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TB_PROVEEDOR", cn);
            da.Fill(dt);

            return dt;
        }

        public DataTable listaTecnologia()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TB_TIPO_TELEVISION", cn);
            da.Fill(dt);

            return dt;
        }

        public DataTable listaCategoria()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TB_CATEGORIA_TELEVISION", cn);
            da.Fill(dt);

            return dt;
        }

        /* public DataTable listaDatosAutos(int cod) {
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter("listadatosauto", cn);
             da.SelectCommand.CommandType = CommandType.StoredProcedure;
             da.SelectCommand.Parameters.Add("@cod", SqlDbType.Int).Value= cod;

             da.Fill(dt);

             return dt;
         }*/

        public DataTable listaTelevision()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listatelevision", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            return dt;
        }

        public DataTable listaTelevisionxMarca(string nro, string estado)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listatelevisionxmarca", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@modelo", SqlDbType.VarChar,15).Value = nro;
            da.SelectCommand.Parameters.Add("@idprov", SqlDbType.VarChar, 11).Value = estado;
            da.Fill(dt);

            return dt;
        }

        public DataTable listaTelevisionxTipopantalla(string nro, string estado)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listaTelevisionxTipopantalla", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 15).Value = nro;
            da.SelectCommand.Parameters.Add("@codtip", SqlDbType.VarChar, 6).Value = estado;
            da.Fill(dt);

            return dt;
        }

        public DataTable listaTelevisionxcategoria(string nro, string estado)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listaTelevisionxcategoria", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 15).Value = nro;
            da.SelectCommand.Parameters.Add("@codcat", SqlDbType.VarChar, 3).Value = estado;
            da.Fill(dt);
         
            return dt;
        }

        public string mantenerTelevision(TelevisionCE aut, string accion)
        //public string mantenerAuto(Autos aut)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_mantenimientotelevision";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@modelo", SqlDbType.VarChar,15).Value = aut.getModelo();
            cmd.Parameters.Add("@idprov", SqlDbType.Char,11).Value = aut.getIdprov();
            cmd.Parameters.Add("@codtip", SqlDbType.VarChar,6).Value = aut.getCodtip();
            cmd.Parameters.Add("@codcat", SqlDbType.VarChar,3).Value = aut.getCodcat();
            cmd.Parameters.Add("@resolucion", SqlDbType.VarChar,10).Value = aut.getResolucion();
            cmd.Parameters.Add("@tamaño", SqlDbType.Char,3).Value = aut.getTamaño();
            cmd.Parameters.Add("@caracteristica", SqlDbType.VarChar,200).Value = aut.getCaracteristica();

            cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = aut.getPrecio();
            cmd.Parameters.Add("@stock", SqlDbType.Int).Value = aut.getStock();
            cmd.Parameters.Add("@img", SqlDbType.VarChar,200).Value = aut.getImg();
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

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "registrarimagen";
            //cmd.Connection = cn;
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("@stock", SqlDbType.Int).Value = aut.getStock();
            //cmd.Parameters.Add("@url", SqlDbType.VarChar, 200).Value = aut.getUrl();

            //try
            //{
            //    cn.Open();
            //    cmd.ExecuteNonQuery();
            //    return "exito";
            //}
            //catch (Exception e)
            //{
            //    return "Error" + e.ToString();
            //}
            //finally
            //{
            //    cmd.Dispose();
            //    cn.Close();
            //}

        }
    }
}
