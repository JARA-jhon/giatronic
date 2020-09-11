using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PedidoCE
    {
     
        private int codigo;
        private string cli;
        private string proveedor;
        private string modelo;
        private double monto;
        private int cantidad;
        private string estado;
        private DateTime fecha;

        public DateTime getFecha()
        {
            return fecha;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string getCliente()
        {
            return cli;
        }

        public void setCliente(string cli)
        {
            this.cli = cli;
        }

        public string getProveedor()
        {
            return proveedor;
        }

        public void setProveedor(string proveedor)
        {
            this.proveedor = proveedor;
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public double getMonto()
        {
            return monto;
        }

        public void setMonto(double monto)
        {
            this.monto = monto;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public string getEstado()
        {
            return estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

    }
}
