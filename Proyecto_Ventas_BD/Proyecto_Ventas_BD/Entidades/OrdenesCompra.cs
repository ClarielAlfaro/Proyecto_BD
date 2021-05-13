using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas_BD.Entidades
{
    class OrdenesCompra
    {

        public int ordenId { get; set; }

        public DateTime fechaCreacion { get; set; }

        public DateTime fechaRecepcion { get; set; }

        public int proveedorId { get; set; }

        public string estado { get; set; }


        public List<DetallesOrdenCompra> detalles { get; set; }

        public OrdenesCompra()
        {
            detalles = new List<DetallesOrdenCompra>();
        }

        public void AgregarOrden(DetallesOrdenCompra detalle)
        {
            detalle.ordenId = this.ordenId;
            detalles.Add(detalle);
        }

    }
}
