using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstructurasDatosPG3CS.ArbolesBinarios;

namespace WF_ArbolBusqueda2
{
    class clsProyectos : clsComparador
    {
        public string lStrNombreProyecto { get; set; }
        public string lStrDescripcionProyecto { get; set; }
        public object clsCliente { get; set; }
        public string lStrFechaProyecto { get; set; }

        public clsProyectos(string vlStrNombre, string vlStrDescripcion, clsCliente clsCliente, string vlStrFecha)
        {
            this.lStrNombreProyecto = vlStrNombre;
            this.lStrDescripcionProyecto= vlStrDescripcion;
            this.clsCliente = clsCliente;
            this.lStrFechaProyecto = vlStrFecha;
        }

        bool clsComparador.igualQue(Object op2)
        {
            clsProyectos miProyecto = (clsProyectos)op2;
            return lStrNombreProyecto == miProyecto.lStrNombreProyecto;
        }

        bool clsComparador.menorQue(Object op2)
        {
            clsProyectos miProyecto = (clsProyectos)op2;
            if (lStrNombreProyecto.CompareTo(miProyecto.lStrNombreProyecto) < 0)
                return true;
            else
                return false;
        }

        bool clsComparador.menorIgualQue(Object op2)
        {
            clsProyectos miProyecto = (clsProyectos)op2;
            if (lStrNombreProyecto.CompareTo(miProyecto.lStrNombreProyecto) <= 0)
                return true;
            else
                return false;
        }

        bool clsComparador.mayorQue(Object op2)
        {
            clsProyectos miProyecto = (clsProyectos)op2;
            if (lStrNombreProyecto.CompareTo(miProyecto.lStrNombreProyecto) > 0)
                return true;
            else
                return false;
        }

        bool clsComparador.mayorIgualQue(Object op2)
        {
            clsProyectos miProyecto = (clsProyectos)op2;
            if (lStrNombreProyecto.CompareTo(miProyecto.lStrNombreProyecto) >= 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "(Tarea: " + lStrNombreProyecto + " Descripcion: " + lStrDescripcionProyecto + " Fecha: " + lStrFechaProyecto + ")";
        }
    }
}
