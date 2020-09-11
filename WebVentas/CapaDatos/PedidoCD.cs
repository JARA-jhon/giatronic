using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

using System.Configuration;

namespace CapaDatos
{
    public class PedidoCD
    {  
        static ConexionSql cnx = new ConexionSql();
        static SqlConnection cn = cnx.getConexion();
        private DataTable carrito;

        public PedidoCD() {
            carrito = new DataTable();

            carrito.Columns.Add("idprov", Type.GetType("System.String"));
            carrito.Columns.Add("modelo", Type.GetType("System.String"));
          
            //carrito.Columns.Add("codtip", Type.GetType("System.String"));
            //carrito.Columns.Add("codcat", Type.GetType("System.String"));
            //carrito.Columns.Add("resolucion", Type.GetType("System.String"));
            //carrito.Columns.Add("tamaño", Type.GetType("System.String"));
            //carrito.Columns.Add("caracteristica", Type.GetType("System.String"));

            carrito.Columns.Add("precio", Type.GetType("System.Decimal"));
            carrito.Columns.Add("cantidad", Type.GetType("System.Int32"));
            carrito.Columns.Add("subtotal", Type.GetType("System.Decimal"), "precio*cantidad");
          
        }
        
         //private string usuario;

        public DataTable getCarrito()
        {
            return carrito;
        }

        public void setCarrito(DataTable carrito)
        {
            this.carrito = carrito;
        }

        public void agregarCarrito(PedidoCE ped)
        {
            DataRow fila = carrito.NewRow();
            fila[0] = ped.getProveedor();
            fila[1] = ped.getModelo();
            fila[2] = ped.getMonto();
            fila[3] = ped.getCantidad();
            // fila[4] = ped.getCliente();

            carrito.Rows.Add(fila);
        }


        public void Eliminar(string id)
        {
            string msg = "";
            try
            {
                getCarrito();
                foreach (DataRow r in carrito.Rows)
                {
                    if ((string)r[1] == id)
                    {
                        r.Delete();
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                msg = "Error!" + e.ToString();
            }
        }


        public Decimal Total()
        {
            decimal t = 0;        

            if (carrito != null)
            {
                if (carrito.Rows.Count > 0)
                {
                    t = (decimal)carrito.Compute("Sum(subtotal)", "");
                }
            }
            else
            {
                t = 0;
            }
            return t;
        }

        public int codigo()
        {
            int cod = generarCodigo();
            return cod;
        }


        public Decimal Igv()
        {
            decimal t = 0;
             decimal i = 0;
            decimal c = 0.18m;
            
            if (carrito != null)
            {
                if (carrito.Rows.Count > 0)
                {
                    t = (decimal)carrito.Compute("Sum(subtotal)", "");
                if (t > 0)
                    {
                        i = c * (t);
                    }                  
                }
            }
            else
            {
                t = 0;
            }
            return i;
        }

        public Decimal Des()
        {
            decimal t = 0;
            decimal d = 0;
            decimal c = 0.1m;
          
            if (carrito != null)
            {
                if (carrito.Rows.Count > 0)
                {
                    t = (decimal)carrito.Compute("Sum(subtotal)", "");

                    if (t > 3000)
                    {
                        d = c * (t);
                    }                   
                }
            }
            else
            {
                t = 0;
            }

            return d;
        }

        public Decimal Neto()
        {
            decimal t = 0;
            decimal n = 0;
            decimal d = 0;
            decimal i = 0;
            decimal cd = 0.1m;
            decimal ci = 0.18m;

            if (carrito != null)
            {
                if (carrito.Rows.Count > 0)
                {
                    t = (decimal)carrito.Compute("Sum(subtotal)", "");

                    if (t > 3000)
                    {
                        d = cd * (t);
                    }
                    if (t > 0)
                    {
                        i = ci * (t);
                    }
                    if (t > 0)
                    {
                        n = ((t - d) + i);
                    }
                }
            }
            else
            {
                t = 0;
            }
            return n;
        }

    
        //generarcodigo
        private static int traerCodigo()
        {
            int cod = 0;
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select isnull(max(pedcod),0) from tb_pedidos(nolock)");
            cmd.Connection = cn;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        cod = dr.GetInt32(0);
                    }
                }
                else
                {
                    cod = 0;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                cod = 0;
            }
            finally
            {
                cmd.Dispose();
                //cn.Close();
            }

            return cod;
        }

        //registrarpedido
        private static int generarCodigo()
        {
            int cod = traerCodigo();
            if (cod != 0)
            {
                cod += 1;
            }
            else
            {
                cod = 1;
            }

            return cod;
        }

        public string registrarPedido(PedidoCE ped, DataTable tabla)
        {
            string msg = "";
            int cod = generarCodigo();
            SqlTransaction tr = cn.BeginTransaction(IsolationLevel.Serializable);
            SqlCommand com = new SqlCommand("sp_registrarpedidocab", cn, tr);

            try
            {
                //cn.Open();

                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@pedcod", SqlDbType.Int).Value = cod;
                com.Parameters.Add("@dni", SqlDbType.VarChar, 9).Value = ped.getCliente();
                com.Parameters.Add("@monto", SqlDbType.Decimal).Value = ped.getMonto();

                com.ExecuteNonQuery();

                foreach (DataRow r in tabla.Rows)
                {
                    com = new SqlCommand("sp_registrarpedidodet", cn, tr);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@pedcod", SqlDbType.Int).Value = cod;
                    //string proveedor = r["proveedor"].ToString();
                    com.Parameters.Add("@nomprov", SqlDbType.VarChar, 50).Value = r["idprov"];
                    com.Parameters.Add("@modelo", SqlDbType.VarChar, 15).Value = r["modelo"];
                    com.Parameters.Add("@precio", SqlDbType.Decimal).Value = r["precio"];
                    com.Parameters.Add("@cantidad", SqlDbType.Int).Value = r["cantidad"];
                    com.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = r["subtotal"];
                    com.ExecuteNonQuery();
                }

                tr.Commit();
                carrito.Clear();
                msg = "exito";
            }
            catch (Exception e)
            {
                tr.Rollback();
                msg = "Error!" + e.ToString();
            }
            finally
            {
                com.Dispose();
                cn.Close();
            }

            return msg;
        }


          public string mantenerpedido(PedidoCE aut, string accion)
        //public string mantenerAuto(Autos aut)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_mantenimientopedido";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pedcod", SqlDbType.Int).Value = aut.getCodigo();
            cmd.Parameters.Add("@dni", SqlDbType.VarChar,25).Value = aut.getCliente();
            cmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = aut.getMonto();
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = aut.getFecha();
            cmd.Parameters.Add("@codest", SqlDbType.Char,2).Value = aut.getEstado();
            
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

        //CLIENTE ADMINISTADOR
        public DataTable listaEstados()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listaestados", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            return dt;
        }

        //CLIENTE
        public DataTable listaPedidosCliente(string dni, int idped, string estado)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listapedidoscliente", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 25).Value = dni;
            da.SelectCommand.Parameters.Add("@idped", SqlDbType.Int).Value = idped;
            da.SelectCommand.Parameters.Add("@estado", SqlDbType.Char, 1).Value = estado;
            da.Fill(dt);

            return dt;
        }

        //CLIENTE ADMINSITRADOR
        public DataTable listaPedidoDetalle(int cod)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listapedidosdet", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idped", SqlDbType.Int).Value = cod;
            da.Fill(dt);

            return dt;
        }

        //ADMINISTRADOR
        public DataTable listaPedidos()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listapedidos", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            return dt;
        }

        public DataTable listaPedido()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listapedido", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);


            return dt;
        }

       
     

        //ADMINISTRADOR
        public DataTable listaPedidoxEstado(int nro, string estado)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_listapedidosxestado", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idped", SqlDbType.Int).Value = nro;
            da.SelectCommand.Parameters.Add("@estado", SqlDbType.Char, 2).Value = estado;
            da.Fill(dt);

            return dt;
        }

    }
}
