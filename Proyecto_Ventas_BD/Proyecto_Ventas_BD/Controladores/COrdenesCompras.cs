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
    class COrdenesCompras
    {

       
            MOrdenesCompra mOrdenCompra = new MOrdenesCompra();

            public void RegistrarOrdenCompra(OrdenesCompra oc)
            {
                mOrdenCompra.RegistrarOrdenCompra(oc);
            }

            public void ActualizarOrdenCompra(OrdenesCompra oc)
            {
                mOrdenCompra.ActualizarOrdenCompra(oc);
            }

            public void EliminarOrdenCompra(OrdenesCompra oc)
            {
                mOrdenCompra.EliminarOrdenCompra(oc);
            }

            public List<OrdenesCompra> ListadoOrdenesCompra()
            {
                return mOrdenCompra.ListadoOrdenesCompra();
            }

            public OrdenesCompra Consultar1OrdenCompra(int id)
            {
                return new OrdenesCompra();
            }

            public void RecibirOrden(OrdenesCompra oc)
            {
                mOrdenCompra.RecibirOrden(oc);
            }
        

    }
}
