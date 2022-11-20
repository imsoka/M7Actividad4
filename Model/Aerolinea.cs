using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad2.Model
{
    internal class Aerolinea
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set;}

        public Aerolinea(string id, string nombre, string codigo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Codigo = codigo;
        }
    }
}
