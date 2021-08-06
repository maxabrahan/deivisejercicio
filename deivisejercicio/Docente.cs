using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deivisejercicio
{
    public  class Docente:Persona
    {

        
        public double valorhora { get; set; }

        public int horasdictadas { get; set; }

        public double bonificacion { get; set; }

        public double sueldo { get; set; }


        public override void CalcularSueldo()
        {



            sueldo = (valorhora * horasdictadas) + bonificacion;
            


        }

    }

    
}
