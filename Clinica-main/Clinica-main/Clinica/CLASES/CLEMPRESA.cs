using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.CLASES
{
    class CLEMPRESA
    {
        private int id;
        private string nombre;
        private string direccion;
        private int telefono;
        private string representante_legal;
        private DateTime fecha;
        private string logo;

        public CLEMPRESA(int id, string nombre, string direccion, int telefono, string representante_legal, DateTime fecha, string logo)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.representante_legal = representante_legal;
            this.fecha = fecha;
            this.logo = logo;
        }
        public void grabar()
        {

        }
        public void consultar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }
    }
}
