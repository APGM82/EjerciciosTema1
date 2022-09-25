using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema1
{
    internal class Fechas
    {
        private static int a;
        private int m;
        private int d;
        private int compraracion;
        private String textoFecha;
        public String TextoFecha   // property
        {
            get { return textoFecha; }   // get method
            set { textoFecha = value; }  // set method
        }

        public Fechas()
        {
            a = Anyo();
            m = Mes();
            d = Dia(a, m);
            Console.WriteLine("La fecha elegida es: " + d + "/" + m + "/" + a);
            textoFecha = (d + "/" + m + "/" + a);

        }
        static int Anyo()
        {
            bool prueba;
            int numSalida;

            do
            {
                Console.WriteLine("Introduzca un valor adecuado para el Año");
                var leer = Console.ReadLine();
                prueba = (int.TryParse(leer, out numSalida));
                {
                    if (!prueba | numSalida > 9999 | numSalida < 1)
                    {
                        Console.WriteLine("Número no válido");

                    }

                }
            } while (!prueba | numSalida > 9999 | numSalida < 1);
            return numSalida;
        }
        static int Mes()
        {
            bool prueba;
            int numSalida;

            do
            {
                Console.WriteLine("Introduzca un valor adecuado para el mes");
                var leer = Console.ReadLine();
                prueba = (int.TryParse(leer, out numSalida));
                {
                    if (!prueba | numSalida > 12 | numSalida < 1)
                    {
                        Console.WriteLine("Número no válido");

                    }

                }
            } while (!prueba | numSalida > 12 | numSalida < 1);
            return numSalida;
        }
        static int Dia(int anno, int mes)
        {
            bool prueba;
            int numSalida;

            do
            {
                Console.WriteLine("Introduzca un valor adecuado para el dia");
                var leer = Console.ReadLine();
                prueba = (int.TryParse(leer, out numSalida));
                {
                    if (!prueba | numSalida > System.DateTime.DaysInMonth(anno, mes))
                    {
                        Console.WriteLine("Número no válido");

                    }

                }
            } while (!prueba | numSalida > System.DateTime.DaysInMonth(anno, mes));
            return numSalida;
        }
        public static void Selector()
        {
            Console.WriteLine("Seleccione la ocion deseada: ");
            Console.WriteLine("1: Día de la semana");
            Console.WriteLine("2: Incrementar Fecha");
            Console.WriteLine("3: Diferencia Fechas");
            Console.WriteLine("4: Compara Fechas");
            Console.WriteLine("5: Mostrar fecha en formato largo");
            int select = 0;
            string sel = Console.ReadLine();
            if (!int.TryParse(sel, out select))
            {
                // Parsing failed, handle the error however you like
            }
            switch (select)
            {
                case 1:
                    Fechas f = new Fechas();
                    DateTime dt = DateTime.Parse(f.TextoFecha);
                    Console.WriteLine(dt.ToString("dddd", new CultureInfo("es-ES")));
                    break;
                case 2:
                    Fechas f2 = new Fechas();
                    DateTime dt2 = DateTime.Parse(f2.TextoFecha);
                    Console.WriteLine("Escriba un número de dias para sumarle");
                    double diasmas = double.Parse(Console.ReadLine());
                    Console.WriteLine(dt2.AddDays(diasmas));
                    break;
                case 3:
                    Console.WriteLine("FECHA INICIAL");
                    Fechas f3 = new Fechas();
                    DateTime dt3 = DateTime.Parse(f3.TextoFecha);
                    Console.WriteLine("FECHA A RESTAR");
                    Fechas f31 = new Fechas();
                    DateTime dt31 = DateTime.Parse(f31.TextoFecha);
                    var diferenciaFechas = dt3.Subtract(dt31);
                    Console.WriteLine("Diferencia: {0}", diferenciaFechas);
                    break;
                case 4:
                    Console.WriteLine("Primera fecha: ");
                    Fechas f4 = new Fechas();
                    DateTime dt4 = DateTime.Parse(f4.TextoFecha);
                    Console.WriteLine("Segunda fecha: ");
                    Fechas f41 = new Fechas();
                    DateTime dt41 = DateTime.Parse(f41.TextoFecha);
                    int comparacion = DateTime.Compare(dt4, dt41);
                    String relacion;
                    if (comparacion < 0)
                        relacion = " es anterior a ";
                    else if (comparacion == 0)
                        relacion = " es la misma que ";
                    else
                        relacion = " es posterior a ";

                    Console.WriteLine("{0} {1} {2}", dt4, relacion, dt41);
                    break;
                case 5:
                    Fechas f5 = new Fechas();
                    DateTime dt5 = DateTime.Parse(f5.TextoFecha);
                    Console.WriteLine(dt5.ToString("D", CultureInfo.CreateSpecificCulture("es-ES")));
                    break;

            }
        }
    }
}
