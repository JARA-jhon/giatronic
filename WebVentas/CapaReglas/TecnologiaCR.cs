using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaDatos;


namespace CapaReglas
{
    public class TecnologiaCR
    {

        TecnologiaCD tecnologiadao = new TecnologiaCD();

        public DataTable listaTecnologia()
        {
            return tecnologiadao.listaTecnologia();
        }

        public string mantenerTecnologia(TecnologiaCE tec, string accion)
        {
            return tecnologiadao.mantenerTecnologia(tec,accion); 
        }

        public DataTable listacategoria()
        {
             return tecnologiadao.listacategoria();
        }

        public string mantenercategoria(TecnologiaCE tec, string accion)
        {
            return tecnologiadao.mantenercategoria(tec, accion);
        }


    }
}
