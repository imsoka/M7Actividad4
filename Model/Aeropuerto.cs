using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad4.Model
{
    internal class Aeropuerto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Nacional { get; set; }
        public Aeropuerto(string id, string nombre, string siglas, string nacional) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Siglas = siglas;
            this.Nacional= nacional;
        }
    }
}
