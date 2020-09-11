using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class UsuarioCE
    {
        private string dni;
        private string nombre;
        private string apellidop;
        private string apellidom;
        private string correo;
        private string telefono;
        private string direccion;
        private string nick;
        private string contraseña;
        private string perfil;

        public string getDni()
        {
            return dni;
        }
        public void setDni(string dni)
        {
            this.dni = dni;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellidop()
        {
            return apellidop;
        }
        public void setApellidop(string apellidop)
        {
            this.apellidop = apellidop;
        }

        public string getApellidom()
        {
            return apellidom;
        }
        public void setApellidom(string apellidom)
        {
            this.apellidom = apellidom;
        }

        public string getCorreo()
        {
            return correo;
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        }

        public string getTelefono()
        {
            return telefono;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getNick()
        {
            return nick;
        }
        public void setNick(string nick)
        {
            this.nick = nick;
        }

        public string getContraseña()
        {
            return contraseña;
        }
        public void setContraseña(string contraseña)
        {
            this.contraseña = contraseña;
        }

        public string getPerfil()
        {
            return perfil;
        }
        public void setPerfil(string perfil)
        {
            this.perfil = perfil;
        }

    }
}
