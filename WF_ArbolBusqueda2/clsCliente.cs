using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ArbolBusqueda2
{
    class clsCliente
    {
        public string lStrNombreCliente { get; set; }
        string lStrNitCliente {  get; set; }
        public string lStrDireccionCliente { get; set;}

        public clsCliente(string vlStrNombre, string vlStrNit, string vlStrDireccion) 
        {
            this.lStrNombreCliente = vlStrNombre;
            this.lStrNitCliente = vlStrNit;
            this.lStrDireccionCliente = vlStrDireccion;
        }

        public override string ToString()
        {
            return lStrNombreCliente;
        }
    }
}
