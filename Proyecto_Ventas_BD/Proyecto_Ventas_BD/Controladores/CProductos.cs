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
    class CProductos
    {

        
            MProductos mProducto = new MProductos();

            public void RegistarProd(Productos p)
            {
                mProducto.RegistarProd(p);
            }

            public void ActualizarProd(Productos p)
            {
                mProducto.ActualizarProd(p);
            }

            public void EliminarProd(Productos p)
            {
                mProducto.EliminarProd(p);
            }

            public List<Productos> ListadoProd()
            {
                return mProducto.ListadoProd();
            }

            public Productos Consultar1Prod(int id)
            {
                return new Productos();
            }
        

    }
}
