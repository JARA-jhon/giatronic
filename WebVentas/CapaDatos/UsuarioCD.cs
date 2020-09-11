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
     public class UsuarioCD 
        {
            static ConexionSql con = new ConexionSql();
            SqlConnection cn = con.getConexion();



            public DataTable listaPerfiles()
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("sp_listaperfiles", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);

                return dt;
            }

            public DataTable listaUsuarios()
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("sp_listausuarios", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);

                return dt;
            }

            public UsuarioCE obtenerUsuario(string usu, string pass)
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand("sp_obtenerusuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usu", SqlDbType.VarChar, 25).Value = usu;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar, 25).Value = pass;

                UsuarioCE uce = new UsuarioCE();
                try{
                    cn.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows == true){
                        while (dr.Read()){
                            uce.setDni(dr.GetString(0));
                            uce.setNombre(dr.GetString(1));
                            uce.setApellidop(dr.GetString(2));
                            uce.setApellidom(dr.GetString(3));
                            uce.setCorreo(dr.GetString(4));
                            uce.setTelefono(dr.GetString(5));
                            uce.setDireccion(dr.GetString(6));
                            uce.setNick(dr.GetString(7));
                            uce.setContraseña(dr.GetString(8));
                            uce.setPerfil(dr.GetString(9));
                         }
                    }else{
                        uce = null;
                    }
                }catch (Exception e){
                    uce = null;
                }
                cn.Close();
                return uce;
            }


            public string mantenerUsuario(UsuarioCE usuario, string accion)
            {
                string msg = "";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_mantenimientousuario";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dni", SqlDbType.VarChar, 25).Value = usuario.getDni();
                cmd.Parameters.Add("@nom", SqlDbType.VarChar, 25).Value = usuario.getNombre();
                cmd.Parameters.Add("@apep", SqlDbType.VarChar, 25).Value = usuario.getApellidop();
                cmd.Parameters.Add("@apem", SqlDbType.VarChar, 25).Value = usuario.getApellidom();
                cmd.Parameters.Add("@corr", SqlDbType.VarChar, 100).Value = usuario.getCorreo();
                cmd.Parameters.Add("@tel", SqlDbType.VarChar, 10).Value = usuario.getTelefono();
                cmd.Parameters.Add("@dir", SqlDbType.VarChar, 100).Value = usuario.getDireccion();
                cmd.Parameters.Add("@nic", SqlDbType.VarChar, 25).Value = usuario.getNick();
                cmd.Parameters.Add("@con", SqlDbType.VarChar, 25).Value = usuario.getContraseña();
                cmd.Parameters.Add("@perfil", SqlDbType.Char, 3).Value = usuario.getPerfil();
                cmd.Parameters.Add("@accion", SqlDbType.Char, 1).Value = accion;


                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    msg = "exito";
                }
                catch (SqlException e)
                {
                    msg = "Advertencia: " + e.Message.ToString();
                }
                finally
                {
                    cmd.Dispose();
                    cn.Close();
                }

                return msg;
            }


            public UsuarioCE obtieneDatosUsuario(string dni)
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand("sp_obtienedatosusuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@dni", SqlDbType.VarChar, 25).Value = dni;

                UsuarioCE u = new UsuarioCE();
                try
                {
                    cn.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            u.setDni(dr.GetString(0));
                            u.setNombre(dr.GetString(1));
                            u.setApellidop(dr.GetString(2));
                            u.setApellidom(dr.GetString(3));
                            u.setCorreo(dr.GetString(4));
                            u.setTelefono(dr.GetString(5));
                            u.setDireccion(dr.GetString(6));
                            u.setNick(dr.GetString(7));
                            u.setContraseña(dr.GetString(8));
                            u.setPerfil(dr.GetString(9));
                        }
                    }
                    else
                    {
                        u = null;
                    }
                }
                catch (Exception e)
                {
                    u = null;
                }

                cn.Close();
                return u;
            }



      } 
 } 
