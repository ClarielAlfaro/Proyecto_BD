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
    class CMarcas
    {

       
            MMarcas mMarca = new MMarcas();

            public void RegistrarMarca(Marcas m)
            {
                mMarca.RegistrarMarca(m);
            }

            public void ActualizarMarca(Marcas m)
            {
                mMarca.ActualizarMarca(m);
            }

            public void EliminarMarca(Marcas m)
            {
                mMarca.EliminarMarca(m);
            }

            public List<Marcas> ListadoMarcas()
            {
                return mMarca.ListadoMarcas();
            }

            public Marcas Consultar1Marca(int id)
            {
                return new Marcas();
            }
        

    }
}
