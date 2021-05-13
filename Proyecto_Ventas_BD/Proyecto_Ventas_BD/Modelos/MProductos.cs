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
    class MProductos
    {

        public void RegistarProd(Productos p)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", p.nombre, DbType.String);
            parametros.Add("@codigoInterno", p.codigointerno, DbType.String);
            parametros.Add("@marca", p.marcaId, DbType.Int32);
            parametros.Add("@proveedor", p.proveedor, DbType.Int32);
            parametros.Add("@categoria", p.categoria, DbType.Int32);
            cn.Open();
            cn.Execute("sp_InsertarProducto", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarProd(Productos p)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombreNuevo", p.nombre, DbType.String);
            parametros.Add("@codigoInterno", p.codigointerno, DbType.String);
            parametros.Add("@marcaid", p.marcaId, DbType.Int32);
            parametros.Add("@proveedor", p.proveedor, DbType.Int32);
            parametros.Add("@categoria", p.categoria, DbType.Int32);
            parametros.Add("@id", p.productoId, DbType.Int32);
            cn.Open();
            cn.Execute("sp_ModificarProductoEspecifico", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarProd(Productos p)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", p.productoId, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarProductoEspecifico", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Productos> ListadoProd()
        {
            List<Productos> lista = new List<Productos>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Productos>("sp_ConsultarProductos", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public Productos Consultar1Prod(int id)
        {
            return new Productos();
        }

    }
}
