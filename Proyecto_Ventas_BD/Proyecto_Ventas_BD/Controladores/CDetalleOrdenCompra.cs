using Proyecto_Ventas_BD.Entidades;
using Proyecto_Ventas_BD.Modelos;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas_BD.Controladores
{
    class CDetalleOrdenCompra
    {

       
            MDetallesOrdenCompra mDetallesOrden = new MDetallesOrdenCompra();

            public void RegistarDetallesOrdenCompra(DetallesOrdenCompra doc)
            {
                mDetallesOrden.RegistarDetallesOrdenCompra(doc);
            }

            public void ActualizarDetallesOrdenCompra(DetallesOrdenCompra doc)
            {
                mDetallesOrden.ActualizarDetallesOrdenCompra(doc);
            }

            public void EliminarDetallesOrdenCompra(DetallesOrdenCompra doc)
            {
                mDetallesOrden.EliminarDetallesOrdenCompra(doc);
            }

            public List<DetallesOrdenCompra> ListadoDetallesOrden()
            {
                return mDetallesOrden.ListadoDetallesOrden();
            }

            public DetallesOrdenCompra ConsultarDetallesOrden(int id)
            {
                return new DetallesOrdenCompra();
            }

            internal void GuardarMaestroDetalle(BindingList<DetallesOrdenCompra> detatlles)
            {
                mDetallesOrden.GuardarMaestroDetalle(detatlles);
            }
        

    }
}
