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
    public class TelevisionCR
    {
        TelevisionCD televisioncd = new TelevisionCD();

        public DataTable listaMarca()
        {
            return televisioncd.listaMarca();
        }

        public DataTable listaTecnologia()
        {
            return televisioncd.listaTecnologia();
        }

        public DataTable listaCategoria()
        {
            return televisioncd.listaCategoria();
        }

  
        public DataTable listaTelevision()
        {
            return televisioncd.listaTelevision();
        }

        public DataTable listaTelevisionxMarca(string nro, string estado)
        {
            return televisioncd.listaTelevisionxMarca(nro,estado);
        }

        public DataTable listaTelevisionxTipopantalla(string nro, string estado)
        {
            return televisioncd.listaTelevisionxTipopantalla(nro, estado);
        }

        public DataTable listaTelevisionxcategoria(string nro, string estado)
        {
            return televisioncd.listaTelevisionxcategoria(nro, estado);
        }
        
        public string mantenerTelevision(TelevisionCE aut, string accion)
        {
            return televisioncd.mantenerTelevision(aut, accion);
        }

    }
}
