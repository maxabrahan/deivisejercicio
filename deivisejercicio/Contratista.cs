using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deivisejercicio
{
    public class Contratista:Persona
    {
        public double valormensual { get; set; }

        public int diastrabajados { get; set; }

        public double valordescontado { get; set; }

        public void calcularSueldo()
        {

            double sueldo;


            sueldo = ((valormensual / 30) * diastrabajados) - valordescontado;

        }
    }
}
