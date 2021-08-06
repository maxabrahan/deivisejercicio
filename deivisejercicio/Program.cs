using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deivisejercicio
{
    
    class Program
    {
        static List<Docente> docentes = new List<Docente>(); 

        public static void Main(string[] args)
        {
            

            menu();
        }

        static void menu()
        {
            int opc;
            do {
                Console.WriteLine("1.Registrar");
                Console.WriteLine("2.Informe");
                Console.WriteLine("3.salir");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Registro();
                        break;
                    case 2:
                        informe();
                        break;
                    case 3:
                        break;


                }



            } while (opc != 3);



        }

        public static void Registro()
        {
            int opc;

            do
            {


                Console.WriteLine("1.Registrar Docente");
                Console.WriteLine("2.Registrar Administrativo");
                Console.WriteLine("3.Registrar contratista");
                Console.WriteLine("4.salir");

                opc = Convert.ToInt32(Console.ReadLine());

                if (opc.Equals(1))
                {
                    registroDocente();
                } else if (opc.Equals(2))
                {
                    registroAdministrativo();
                } else if (opc.Equals(3))
                {
                    registroContratista();
                }
            } while (opc == 3);

        }

        public static  void registroDocente()
        {
            string resp;
           
            do {
                Docente docente = new Docente();

                Console.WriteLine("digite su id");
                docente.id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su nombre");
                docente.nombre= Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su apellido");
                docente.apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su edad");
                docente.edad = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Dgite el valor pagado por horas");
                docente.valorhora = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de horas dictadas");
                docente.horasdictadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la bonificacion");
                docente.bonificacion = Convert.ToInt32(Console.ReadLine());


                docente.CalcularSueldo();

                Console.WriteLine("Desea seguir registrando datos???");
                resp = Convert.ToString(Console.ReadLine());

            } while (resp.Equals("si"));
        }

        public static void registroAdministrativo()
        {
            string resp;
            

            do
            {

                Administrativo administrativo = new Administrativo();

                Console.WriteLine("digite su id");
                administrativo.id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su nombre");
                administrativo.nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su apellido");
                administrativo.apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su edad");
                administrativo.edad = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su salario basico");
                administrativo.salariobasico = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de horas extras");
                administrativo.hextras = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de horas trabajadas");
                administrativo.diastrabajados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el valor de los aportes");
                administrativo.aportes = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Desea seguir registrandod datos???");
                resp = Convert.ToString(Console.ReadLine());

            } while (resp.Equals("si"));


        }

        public static void registroContratista()
        {
            string resp;
            
            do
            {
                Contratista contratista = new Contratista();

                Console.WriteLine("digite su id");
                contratista.id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su nombre");
                contratista.nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su apellido");
                contratista.apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite su edad");
                contratista.edad = Convert.ToString(Console.ReadLine());


                Console.WriteLine("Digite el valor mensual");
                contratista.valormensual = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero de dias trabajados");
                contratista.diastrabajados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el valor descontado");
                contratista.valordescontado = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Desea seguir registrando datos????");
                resp = Convert.ToString(Console.ReadLine());

            } while (resp.Equals("si"));



        }

        public static void informe()
        {
            int opc;
            Console.WriteLine("1.Informe Docente");
            Console.WriteLine("2.Informe Administrativo");
            Console.WriteLine("3.Informe contratista");
            Console.WriteLine("4.salir");

            opc = Convert.ToInt32(Console.ReadLine());


            if (opc.Equals(1))
            {
                informeDocente();
            }else if (opc.Equals(2))
            {
                informeAdministrativo();
            }
            else if (opc.Equals(3))
            {
                informeContratista();
            }

        }

        

        public static void informeDocente()
        {
            foreach (var i in docentes)
            {
                Console.WriteLine($"Identificacion : \n {i.id}");
                Console.WriteLine($"Nombre:  \n {i.nombre}");
                Console.WriteLine($"Apellido: \n {i.apellido}");
                Console.WriteLine($"Valor por hora: \n {i.valorhora}");
                Console.WriteLine($"numero de horas dictadas: \n{i.horasdictadas}");
                Console.WriteLine($"Bonificacion: \n {i.bonificacion}");
                Console.WriteLine($"el sueldo es de: { i.sueldo}");
            }
        }

        private static void informeAdministrativo()
        {
            
        }

        private static void informeContratista()
        {
            
        }

    }
}
     

        

        

        
    

