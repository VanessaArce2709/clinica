using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.CLASES
{
    class CLUSUARIOS
    {
        private int id;
        private string email;
        private DateTime fecha;        
        private int idrole;
        private string telefono;
        private string nombre;
        private string password;
        private int idempresa;
        private string imagen;
        //private string login;
        //private string condicion;
        //private string imagen;

        public CLUSUARIOS (int id)
        {
            this.id = id;
        }

        public CLUSUARIOS(string nombre)
        {
            this.nombre = nombre;
        }

        public CLUSUARIOS (string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public CLUSUARIOS(int id, string email, DateTime fecha, int idrole, string telefono, string nombre, string password, int idempresa, string imagen)
        {
            this.id = id;
            this.email = email;
            this.fecha = fecha;
            this.idrole = idrole;
            this.telefono = telefono;
            this.nombre = nombre;
            this.password = password;
            this.idempresa = idempresa;
            this.imagen = imagen;
        }

        public string ingresar()
        {
            // selecciona todas las columnas de usuarios y filtra por correo y contraseña
            return ("select * from tblusuarios where email ='"+this.email+"' and password ='"+ this.password +"'");
        }
        public string buscarporclave()
        {
            return ("select * from tblusuarios where id='" + this.id + "'");
        }
        public string buscarpornombre()
        {
            // busca todas las columnas de usuarios
            return ("select * from tblusuarios where nombre='" + this.nombre + "'");
        }
    }
}
