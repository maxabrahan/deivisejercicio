using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deivisejercicio
{
    public abstract class Persona
    {
        public string id { get; set; }

        public  string nombre { get; set; }

        public string apellido { get; set; }

        public string edad { get; set; }
    }
}
