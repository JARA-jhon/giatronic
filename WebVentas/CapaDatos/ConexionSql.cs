using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class ConexionSql
    {
        public ConexionSql() { }

        SqlConnection cn = new SqlConnection("server=.;database=GIANTRONIC;uid=sa;pwd=sql");

        public SqlConnection getConexion()
        {
            return cn;
        }

    }
}
