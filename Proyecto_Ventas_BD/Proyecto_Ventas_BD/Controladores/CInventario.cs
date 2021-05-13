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
    class CInventario
    {

       
            MInventario mInv = new MInventario();

            public void RegistarInventario(Inventarioo inv)
            {
                mInv.RegistarInventario(inv);
            }

            public void ActualizarInventario(Inventarioo inv)
            {
                mInv.ActualizarInventario(inv);
            }

            public void EliminarInventario(Inventarioo inv)
            {
                mInv.EliminarInventario(inv);
            }

            public List<Inventarioo> ListadoInventario()
            {
                return mInv.ListadoInventario();
            }
        

    }
}
