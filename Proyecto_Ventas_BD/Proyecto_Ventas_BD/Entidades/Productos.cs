using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ventas_BD.Entidades
{
    class Productos
    {

        public int productoId { get; set; }

        public string nombre { get; set; }

        public string codigointerno { get; set; }

        public int marcaId { get; set; }

        public int proveedor { get; set; }

        public int categoria { get; set; }

    }
}
