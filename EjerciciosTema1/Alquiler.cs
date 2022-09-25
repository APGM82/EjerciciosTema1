using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema1
{
    internal class Alquiler
    {
        private static string matricula;
        public static int eslora;
        public static int anyo;
        private static bool Valido = true;

        private static String str_Nombre;
        public static String Nombre
        {
            get { return str_Nombre; }
            set { str_Nombre = value; }
        }

        private static String str_Dni;

        public static String Dni
        {
            get { return str_Dni; }
            set { str_Dni = value; }
        }

        private static DateTime date_FechaInicial;

        public static DateTime FechaInicial
        {
            get { return date_FechaInicial; }
            set { date_FechaInicial = value; }
        }
        private static DateTime date_FechaFinal;

        public static DateTime FechaFinal
        {
            get { return date_FechaFinal; }
            set { date_FechaFinal = value; }
        }

        private static int int_amarre;

        public static int Amarre
        {
            get { return int_amarre; }
            set { int_amarre = value; }
        }


        private static List<Barco> ListaBarcos = new List<Barco>();

        public Alquiler()
        {

            Selector();
            if (Valido) { Console.WriteLine("El precio de alquiler del barco es: " + alquiler()); }


        }


        private static Barco b;
        static int ComprobarInt(String texto)
        {
            bool Correcta;
            int num;
            do
            {
                Console.WriteLine(texto);
                Correcta = int.TryParse(Console.ReadLine(), out num);
                if (!Correcta) { Console.WriteLine("Numero no Correcta"); }
                if (num < 0) { Correcta = false; }
            } while (!Correcta);
            return num;
        }
        static DateTime Comprobar_Fecha()
        {
            bool Correcta;
            DateTime f1 = new DateTime();
            do
            {
                string FechaComprobar = Console.ReadLine();
                Correcta = DateTime.TryParse(FechaComprobar, out f1);
                if (!Correcta)
                {
                    Console.WriteLine("La fecha introducida no es válida, intentelo de nuevo.");
                }
                if (f1 < DateTime.Today) { Correcta = false; }
            } while (!Correcta);
            return f1;
        }

        static void datoscomunes()
        {
            Console.WriteLine("Nombre del Propietario:");
            Nombre = Console.ReadLine();
            Console.WriteLine("DNI:");
            Dni = Console.ReadLine();
            FechaInicial = DateTime.Today;
            Console.WriteLine("Fecha de finalizacion:");
            FechaFinal = Comprobar_Fecha();
            Console.WriteLine("Punto de Amarre:");
            int fuera;
            bool z=true;
            while (z) 
            {
                String nn =Console.ReadLine();
                if (!int.TryParse(nn, out fuera))
                {
                    z = true;
                }
                else 
                {
                    z=false;
                    fuera = Amarre;
                }
            }
            
            Console.WriteLine("Introduzca la matricula del barco");
            matricula = Console.ReadLine();
            String texto = ("Introduzca los metros de eslora");
            eslora = ComprobarInt(texto);
            texto = ("Introduzca el año de fabricación");
            anyo = ComprobarInt(texto);
        }


        public static void Selector()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1-Velero");
            Console.WriteLine("2-Barco Deportivo");
            Console.WriteLine("3-Yate de lujo");
            Console.WriteLine("4-Ver barcos");
            int aux = ComprobarInt("");
            switch (aux)
            {
                case 1:
                    Valido = true;
                    datoscomunes();
                    String texto = ("Número de velas: ");
                    int velas = ComprobarInt(texto);
                    b = new Veleros(velas, matricula, eslora, anyo, Nombre, Dni, Amarre);
                    ListaBarcos.Add(b);
                    for (int i = 0; i < ListaBarcos.Count; i++)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Punto de Amarre :" + Amarre);
                        Console.WriteLine("Matrícula: " + matricula);
                        Console.WriteLine("Nombre del propietario : " + Nombre);
                        Console.WriteLine("DNI : " + Dni);
                        Console.WriteLine("Precio: " + alquiler());
                        Console.WriteLine("=========================");
                    }
                    break;
                case 2:
                    Valido = true;
                    datoscomunes();
                    texto = ("Caballos de potencia:");
                    int cv = ComprobarInt(texto);
                    b = new Deportivas(cv, matricula, eslora, anyo, Nombre, Dni, Amarre);
                    ListaBarcos.Add(b);
                    for (int i = 0; i < ListaBarcos.Count; i++)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Punto de Amarre :" + Amarre);
                        Console.WriteLine("Matrícula: " + matricula);
                        Console.WriteLine("Nombre del propietario : " + Nombre);
                        Console.WriteLine("DNI : " + Dni);
                        Console.WriteLine("Precio: " + alquiler());
                        Console.WriteLine("=========================");
                    }
                    break;
                case 3:
                    Valido = true;
                    datoscomunes();
                    texto = ("Caballos de potencia:");
                    cv = ComprobarInt(texto);
                    texto = ("Número de camarotes:");
                    int camaro = ComprobarInt(texto);
                    b = new Yates(cv, camaro, matricula, eslora, anyo, Nombre, Dni, Amarre);
                    ListaBarcos.Add(b);
                    for (int i = 0; i < ListaBarcos.Count; i++)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Punto de Amarre :" + Amarre);
                        Console.WriteLine("Matrícula: " + matricula);
                        Console.WriteLine("Nombre del propietario : " + Nombre);
                        Console.WriteLine("DNI : " + Dni);
                        Console.WriteLine("Precio: " + alquiler());
                        Console.WriteLine("=========================");
                    }
                    break;
            
                default:
                    Console.WriteLine("Escoge una opcion valida");
                    Valido = false;
                    break;
            }
        }

        public static int alquiler()
        {
            int precio = -1; ;
            double dias = (FechaFinal - FechaInicial).TotalDays;
            precio = (int)dias * b.calculo();
            return precio;
        }

    }
}
