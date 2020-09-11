using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProveedorCE
    {
        private string ruc;
        private string nomprov;
        private string direccion;
        private string telefono;
        private string contacto;
        private string correo;
        private string productos;


        public string getRuc()
        {
            return ruc;
        }
        public void setRuc(string ruc)
        {
            this.ruc = ruc;
        }

        public string getNomprov()
        {
            return nomprov;
        }
        public void setNomprov(string nomprov)
        {
            this.nomprov = nomprov;
        }


        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }


        public string getTelefono()
        {
            return telefono;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }

       
        public string getContacto()
        {
            return contacto;
        }
        public void setContacto(string contacto)
        {
            this.contacto = contacto;
        }

      
        public string getCorreo()
        {
            return correo;
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        }


        public string getProductos()
        {
            return productos;
        }
        public void setProductos(string productos)
        {
            this.productos = productos;
        }



    }
}
