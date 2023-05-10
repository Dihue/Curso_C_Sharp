using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanas2
{
    public  class Contactos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }

        public Contactos(int id,string n,string d,int t)
        {

            this.id = id;
            this.nombre = n;    
            this.direccion = d; 
            this.telefono  = t;
        }




    }
}
