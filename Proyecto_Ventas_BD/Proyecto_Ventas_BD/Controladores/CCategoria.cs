using System;
using Proyecto_Ventas_BD.Entidades;
using Proyecto_Ventas_BD.Modelos;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas_BD.Controladores
{
    class CCategoria
    {

       
            MCategorias mCategoria = new MCategorias();

            public void RegistrarCategoria(Categorias c)
            {
                mCategoria.RegistrarCategoria(c);
            }

            public void ActualizarCategoria(Categorias c)
            {
                mCategoria.ActualizarCategoria(c);
            }

            public void EliminarCategoria(Categorias c)
            {
                mCategoria.EliminarCategoria(c);
            }

            public List<Categorias> ListadoCategorias()
            {
                return mCategoria.ListadoCategorias();
            }

            public Categorias Consultar1Categoria(int id)
            {
                return new Categorias();
            }
        

    }
}
