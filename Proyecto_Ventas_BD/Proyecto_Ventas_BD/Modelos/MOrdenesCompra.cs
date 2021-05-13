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
    class MOrdenesCompra
    {

        
            public void RegistrarOrdenCompra(OrdenesCompra oc)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@fechaCreacion", oc.fechaCreacion, DbType.Date);
                parametros.Add("@fechaRecepcion", oc.fechaRecepcion, DbType.Date);
                parametros.Add("@proveedorId", oc.proveedorId, DbType.Int32);
                parametros.Add("@estado", oc.estado, DbType.String);
                cn.Open();
                cn.Execute("sp_InsertarOrdenCompra", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }

            public void ActualizarOrdenCompra(OrdenesCompra oc)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", oc.ordenId, DbType.Int32);
                parametros.Add("@fechaCreacion", oc.fechaCreacion, DbType.Date);
                parametros.Add("@fechaRecepcion", oc.fechaRecepcion, DbType.Date);
                parametros.Add("@proveedorId", oc.proveedorId, DbType.Int32);
                parametros.Add("@estado", oc.estado, DbType.String);
                cn.Open();
                cn.Execute("sp_ModificarOrdenCompraEspecifico", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }

            public void EliminarOrdenCompra(OrdenesCompra oc)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", oc.ordenId, DbType.Int32);
                cn.Open();
                cn.Execute("sp_EliminarOrdenCompraEspecifica", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }

            public List<OrdenesCompra> ListadoOrdenesCompra()
            {
                List<OrdenesCompra> lista = new List<OrdenesCompra>();
                IDbConnection cn = Conexion.Conexion.Conectar();
                cn.Open();
                lista = cn.Query<OrdenesCompra>("sp_ConsultarOrdenesCompra", commandType: CommandType.StoredProcedure).ToList();
                cn.Close();
                return lista;
            }

            public OrdenesCompra Consultar1OrdenCompra(int id)
            {
                return new OrdenesCompra();
            }

            public void RecibirOrden(OrdenesCompra oc)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@id", oc.ordenId, DbType.Int32);
                cn.Open();
                cn.Execute("sp_RecibirOrden", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }

        
    }
}
