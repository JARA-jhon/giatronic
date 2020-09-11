using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TelevisionCE
    {
        private string modelo;
        private string idprov;
        private string codtip;
        private string codcat;
        private string resolucion;
        private string tamaño;
        private string caracteristica;
        private double precio;
        private int stock;
        private int cantidad;
        //private string usuario;
        private string img;


        public string getModelo()
        {
            return modelo;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getIdprov()
        {
            return idprov;
        }

        public void setIdprov(string idprov)
        {
            this.idprov = idprov;
        }

        public string getCodtip()
        {
            return codtip;
        }

        public void setCodtip(string codtip)
        {
            this.codtip = codtip;
        }

        public string getCodcat()
        {
            return codcat;
        }

        public void setCodcat(string codcat)
        {
            this.codcat = codcat;
        }


        public string getResolucion()
        {
            return resolucion;
        }

        public void setResolucion(string resolucion)
        {
            this.resolucion = resolucion;
        }


        public string getTamaño()
        {
            return tamaño;
        }

        public void setTamaño(string tamaño)
        {
            this.tamaño = tamaño;
        }


        public string getCaracteristica()
        {
            return caracteristica;
        }

        public void setCaracteristica(string caracteristica)
        {
            this.caracteristica = caracteristica;
        }



        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }


        public int getStock()
        {
            return stock;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }


        public string getImg()
        {
            return img;
        }

        public void setImg(string img)
        {
            this.img = img;
        }


        //public string getUsuario()
        //{
        //    return usuario;
        //}

        //public void setUsuario(string usuario)
        //{
        //    this.usuario = usuario;
        //}

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

    }
}
