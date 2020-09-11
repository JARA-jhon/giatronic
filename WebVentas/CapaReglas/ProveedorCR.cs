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
    public class ProveedorCR
    {
        ProveedorCD proveedordao = new ProveedorCD();

        
        public DataTable listaProveedores()
        {
            return proveedordao.listaProveedores();
        }

        public string mantenerProveedor(ProveedorCE proveedor, string accion)
        {
            return proveedordao.mantenerProveedor(proveedor, accion);
         }


    }
}
