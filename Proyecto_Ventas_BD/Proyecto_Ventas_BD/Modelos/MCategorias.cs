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
    class MCategorias
    {

        public void RegistrarCategoria(Categorias c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", c.nombre, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarCategoria", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarCategoria(Categorias c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.categoriaId, DbType.Int32);
            parametros.Add("@nombreNuevo", c.nombre, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarCategoriaEspecifico", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarCategoria(Categorias c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.categoriaId, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarCategoriaEspecifica", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Categorias> ListadoCategorias()
        {
            List<Categorias> lista = new List<Categorias>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Categorias>("sp_ConsultarCategorias", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public Categorias Consultar1Categoria(int id)
        {
            return new Categorias();
        }

    }
}
