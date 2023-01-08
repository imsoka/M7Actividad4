using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad4.Model.Exceptions
{
    internal class ModelNotFoundException: Exception
    {
        public ModelNotFoundException() { }
        public ModelNotFoundException(string message) : base(message) { }

    }
}
