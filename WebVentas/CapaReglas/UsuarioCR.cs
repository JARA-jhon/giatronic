using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaReglas
{
    public class UsuarioCR
    {
        UsuarioCD usuariocd = new UsuarioCD();


        public DataTable listaPerfiles()
        {
            return usuariocd.listaPerfiles();
        }

        public DataTable listaUsuarios()
        {
            return usuariocd.listaUsuarios();
        }

        public UsuarioCE obtenerUsuario(string usu, string pass)
        {
            return usuariocd.obtenerUsuario(usu, pass);
        }

        public string mantenerUsuario(UsuarioCE usuario, string accion)
        {
            return usuariocd.mantenerUsuario(usuario, accion);
        }

        public UsuarioCE obtieneDatosUsuario(string dni)
        {
            return usuariocd.obtieneDatosUsuario(dni);
        }

     
    }
}
