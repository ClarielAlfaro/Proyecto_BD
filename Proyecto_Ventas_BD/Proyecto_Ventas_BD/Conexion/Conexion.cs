using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas_BD.Conexion
{
    class Conexion
    {

        public static IDbConnection Conectar()
        {
            String cadena = "Data Source=CLARIEL\\SQLEXPRESS;Initial Catalog=PuntoDeVenta;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            IDbConnection conexion = cn;
            return conexion;
        }

    }
}
