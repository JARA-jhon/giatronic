using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;


namespace CapaReglas
{
    public class PedidoCR
    {
         PedidoCD pedidocd = new PedidoCD();
         private DataTable carrito;

        public PedidoCR() { 
            carrito = new DataTable();
            carrito = pedidocd.getCarrito();
        }

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
            pedidocd.setCarrito(carrito);
            pedidocd.agregarCarrito(ped);
            carrito = pedidocd.getCarrito();
        }

        public Decimal Total()
        {
            pedidocd.setCarrito(carrito);
            return pedidocd.Total();
        }
        public Decimal Igv()
        {
            pedidocd.setCarrito(carrito);
            return pedidocd.Igv();
        }
    
        public int codigo()
        {
            pedidocd.setCarrito(carrito);
            return pedidocd.codigo();
        }
 

        public Decimal Neto()
        {
            pedidocd.setCarrito(carrito);
            return pedidocd.Neto();
        }
        public Decimal Des()
        {
            pedidocd.setCarrito(carrito);
            return pedidocd.Des();
        }

        public void eliminarCarrito(string cod)
        {
            pedidocd.setCarrito(carrito);
            pedidocd.Eliminar(cod);
            carrito = pedidocd.getCarrito();
        }

        public string registrarPedido(PedidoCE pedido, DataTable tabla)
        {
            return pedidocd.registrarPedido(pedido, tabla);
        }

        //cliente administrador
        public DataTable listaEstados()
        {
            return pedidocd.listaEstados();
        }

        //cliente
        public DataTable listaPedidosCliente(string dni, int idped, string estado)
        {
            return pedidocd.listaPedidosCliente(dni, idped, estado);
        }

        public string mantenerpedido(PedidoCE aut, string accion)       
        {
            return pedidocd.mantenerpedido(aut, accion);
        }

        public DataTable listaPedidoDetalle(int cod)
        {
            return pedidocd.listaPedidoDetalle(cod);
        }

        public DataTable listaPedidos()
        {
            return pedidocd.listaPedidos();
        }
        
        public DataTable listaPedido()
        {
            return pedidocd.listaPedido();
        }

        public DataTable listaPedidoxEstado(int nro, string estado)
        {
            return pedidocd.listaPedidoxEstado(nro,estado);
        }
    }
}
