using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deivisejercicio
{
    public class Administrativo:Persona
    {

        public double salariobasico { get; set; }

        public int hextras { get; set; }

        public int diastrabajados { get; set; }

        public double aportes { get; set; }

        public override void CalcularSueldo()
        {
            double sueldo;

            sueldo=((salariobasico/30)*diastrabajados)+hextras * (salariobasico / 240) * 1.35 - aportes;

        }
    }
}
