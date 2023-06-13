using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Conexion
{
    public class ConexionMaestra
    {
        public static string CadenaConexionMaestra = ConfigurationManager.ConnectionStrings["ConexionSQLServer"].ToString();
    }
}
