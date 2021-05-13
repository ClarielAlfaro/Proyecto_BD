using Proyecto_Ventas_BD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Proyecto_Ventas_BD.Modelos
{
    class MDetallesOrdenCompra
    {

        public void RegistarDetallesOrdenCompra(DetallesOrdenCompra doc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ordenId", doc.ordenId, DbType.Int32);
            parametros.Add("@productoId", doc.productoId, DbType.Int32);
            parametros.Add("@cantidad", doc.cantidad, DbType.Int32);
            parametros.Add("@costo", doc.costo, DbType.Double);
            cn.Open();
            cn.Execute("sp_InsertarDetallesOrdenCompra", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarDetallesOrdenCompra(DetallesOrdenCompra doc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@detalleId", doc.detalleId, DbType.Int32);
            parametros.Add("@ordenId", doc.ordenId, DbType.Int32);
            parametros.Add("@productoId", doc.productoId, DbType.Int32);
            parametros.Add("@cantidad", doc.cantidad, DbType.Int32);
            parametros.Add("@costo", doc.cantidad, DbType.Double);
            cn.Open();
            cn.Execute("sp_ModificarDetallesOrdenCompraEspecifico", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarDetallesOrdenCompra(DetallesOrdenCompra doc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", doc.detalleId, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarDetallesOrdenCompraEspecifica", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<DetallesOrdenCompra> ListadoDetallesOrden()
        {
            List<DetallesOrdenCompra> lista = new List<DetallesOrdenCompra>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<DetallesOrdenCompra>("sp_ConsultarDetallesOrdenesCompra", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public DetallesOrdenCompra ConsultarDetallesOrden(int id)
        {
            return new DetallesOrdenCompra();
        }

        internal void GuardarMaestroDetalle(BindingList<DetallesOrdenCompra> detatlles)
        {
            foreach (DetallesOrdenCompra det in detatlles)
            {
                IDbConnection cn = Conexion.Conexion.Conectar();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@productoId", det.productoId, DbType.Int32);
                parametros.Add("@cantidad", det.cantidad, DbType.Int32);
                parametros.Add("@costo", det.costo, DbType.Double);
                cn.Open();
                cn.Execute("sp_MaestroDetalle", parametros, commandType: CommandType.StoredProcedure);
                cn.Close();
            }
        }

    }
}
