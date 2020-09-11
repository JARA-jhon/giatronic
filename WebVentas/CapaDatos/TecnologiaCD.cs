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
    public class TecnologiaCD
    {

        static ConexionSql con = new ConexionSql();
        SqlConnection cn = con.getConexion();


        public DataTable listaTecnologia()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listatecnologia", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            return dt;
        }

        public string mantenerTecnologia(TecnologiaCE tec, string accion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_mantenimientotecnologia";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@codtip", SqlDbType.VarChar, 6).Value = tec.getCodtip();
            cmd.Parameters.Add("@destip", SqlDbType.VarChar, 100).Value = tec.getDestip();
            cmd.Parameters.Add("@dur", SqlDbType.VarChar, 10).Value = tec.getDurabilidad();
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

        public DataTable listacategoria()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listacategoria", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            return dt;
        }

        public string mantenercategoria(TecnologiaCE tec, string accion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_mantenimientocategoria";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@codcat", SqlDbType.VarChar, 3).Value = tec.getCodcat();
            cmd.Parameters.Add("@descat", SqlDbType.VarChar, 100).Value = tec.getDescat();
            cmd.Parameters.Add("@detalle", SqlDbType.VarChar, 200).Value = tec.getDetalle();
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
