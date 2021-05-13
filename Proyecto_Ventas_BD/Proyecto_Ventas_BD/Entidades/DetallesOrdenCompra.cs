using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas_BD.Entidades
{
    class DetallesOrdenCompra
    {

        public int detalleId { get; set; }

        public int ordenId { get; set; }

        public int productoId { get; set; }

        public int cantidad { get; set; }

        public double costo { get; set; }
    }
}
