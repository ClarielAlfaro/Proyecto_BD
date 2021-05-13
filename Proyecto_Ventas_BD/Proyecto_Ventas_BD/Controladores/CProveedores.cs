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
    class CProveedores
    {

       
            MProveedores mProveedores = new MProveedores();

            public void RegistrarProveedor(Proveedores pr)
            {
                mProveedores.RegistrarProveedor(pr);
            }

            public void ActualizarProveedor(Proveedores pr)
            {
                mProveedores.ActualizarProveedor(pr);
            }

            public void EliminarProveedor(Proveedores pr)
            {
                mProveedores.EliminarProveedor(pr);
            }

            public List<Proveedores> ListadoProveedores()
            {
                return mProveedores.ListadoProveedores();
            }

            public Proveedores Consultar1Marca(int id)
            {
                return new Proveedores();
            }
        

    }
}
