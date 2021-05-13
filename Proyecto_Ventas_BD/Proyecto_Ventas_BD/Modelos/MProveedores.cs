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
    class MProveedores
    {

        public void RegistrarProveedor(Proveedores pr)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", pr.nombre, DbType.String);
            parametros.Add("@nombreComercial", pr.nombreComercial, DbType.String);
            parametros.Add("@nit", pr.nit, DbType.String);
            parametros.Add("@nrc", pr.nrc, DbType.String);
            parametros.Add("@email", pr.email, DbType.String);
            parametros.Add("@telefono", pr.telefono, DbType.Int32);
            cn.Open();
            cn.Execute("sp_InsertarProveedor", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarProveedor(Proveedores pr)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", pr.proveedorId, DbType.Int32);
            parametros.Add("@nombre", pr.nombre, DbType.String);
            parametros.Add("@nombreComercial", pr.nombreComercial, DbType.String);
            parametros.Add("@nit", pr.nit, DbType.String);
            parametros.Add("@nrc", pr.nrc, DbType.String);
            parametros.Add("@email", pr.email, DbType.String);
            parametros.Add("@telefono", pr.telefono, DbType.Int32);
            cn.Open();
            cn.Execute("sp_ModificarProveedorEspecifico", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarProveedor(Proveedores pr)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", pr.proveedorId, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarProveedorEspecifica", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Proveedores> ListadoProveedores()
        {
            List<Proveedores> lista = new List<Proveedores>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Proveedores>("sp_ConsultarProveedores", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public Proveedores ConsultarProveedor(int id)
        {
            return new Proveedores();
        }

    }
}
