using Proyecto_Ventas_BD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas_BD.Modelos
{
    class MInventario
    {

       
            public void RegistarInventario(Inventarioo inv)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@productoId", inv.productoId, DbType.Int32);
                parametros.Add("@costo", inv.costo, DbType.Double);
                parametros.Add("@cantidad", inv.cantidad, DbType.Int32);
                cn.Open();
                cn.Execute("sp_InsertarInventario", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }

            public void ActualizarInventario(Inventarioo inv)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@idInventario", inv.idInventario, DbType.Int32);
                parametros.Add("@productoId", inv.productoId, DbType.Int32);
                parametros.Add("@costo", inv.costo, DbType.Double);
                parametros.Add("@cantidad", inv.cantidad, DbType.Int32);
                cn.Open();
                cn.Execute("sp_ModificarInventario", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }

            public void EliminarInventario(Inventarioo inv)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", inv.idInventario, DbType.Int32);
                cn.Open();
                cn.Execute("sp_EliminarInventario", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }

            public List<Inventarioo> ListadoInventario()
            {
                List<Inventarioo> lista = new List<Inventarioo>();
                IDbConnection cn = Conexion.Conexion.Conectar();
                cn.Open();
                lista = cn.Query<Inventarioo>("sp_ConsultarInventario", commandType: CommandType.StoredProcedure).ToList();
                cn.Close();
                return lista;
            }

        
    }
}
