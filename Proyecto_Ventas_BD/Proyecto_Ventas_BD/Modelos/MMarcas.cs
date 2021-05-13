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
    class MMarcas
    {

        public void RegistrarMarca(Marcas m)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", m.nombre, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarMarca", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarMarca(Marcas m)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", m.marcaId, DbType.Int32);
            parametros.Add("@nombreNuevo", m.nombre, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarMarcaEspecifica", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarMarca(Marcas m)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", m.marcaId, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarMarcaEspecifica", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Marcas> ListadoMarcas()
        {
            List<Marcas> lista = new List<Marcas>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Marcas>("sp_ConsultarMarcas", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public Marcas ConsultarMarca(int id)
        {
            return new Marcas();
        }

    }
}
