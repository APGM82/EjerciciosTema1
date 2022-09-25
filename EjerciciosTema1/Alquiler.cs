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
            Console.WriteLine("Dime el nombre del barco");
            Nombre = Console.ReadLine();
            Console.WriteLine("Dime el DNI");
            Dni = Console.ReadLine();
            FechaInicial = DateTime.Today;
            Console.WriteLine("Dime la fecha de finalizacion");
            FechaFinal = Comprobar_Fecha();
            Console.WriteLine("Dime la posicion del barco");
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


        static void Selector()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1-Velero");
            Console.WriteLine("2-Barco Deportivo");
            Console.WriteLine("3-Yate de lujo");
            int aux = ComprobarInt("");
            switch (aux)
            {
                case 1:
                    Valido = true;
                    datoscomunes();
                    String texto = ("¿Cuantas velas tiene el barco?");
                    int velas = ComprobarInt(texto);
                    b = new Veleros(velas, matricula, eslora, anio_fab);
                    barquitos.Add(b);
                    break;
                case 2:
                    Valido = true;
                    datoscomunes();
                    texto = ("¿Cuantas CV tiene el barco?");
                    int cv = ComprobarInt(texto);
                    b = new Deportivas(cv, matricula, eslora, anyo);
                    barquitos.Add(b);
                    break;
                case 3:
                    Valido = true;
                    datoscomunes();
                    texto = ("¿Cuantas CV tiene el barco?");
                    cv = ComprobarInt(texto);
                    texto = ("¿Cuantas camarotes tiene el barco?");
                    int cama = ComprobarInt(texto);
                    b = new Yates(cv, cama, matricula, eslora, anyo);
                    barquitos.Add(b);
                    break;
                default:
                    Console.WriteLine("Escoge una opcion valida");
                    Valido = false;
                    break;
            }
        }

        public int alquiler()
        {
            int precio = -1; ;
            double dias = (Fecha_fin - Fecha_ini).TotalDays;
            precio = (int)dias * b.calculo();
            return precio;
        }

    }
}
