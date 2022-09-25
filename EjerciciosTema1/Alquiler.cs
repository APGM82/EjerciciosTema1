using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema1
{
    internal class Alquiler
    {
        private static string matricula;
        public static int eslora;
        public static int anyo;

        private String str_Nombre;
        public String Nombre
        {
            get { return str_Nombre; }
            set { str_Nombre = value; }
        }

        private String str_Dni;

        public String Dni
        {
            get { return str_Dni; }
            set { str_Dni = value; }
        }

        private DateTime date_FechaInicial;

        public DateTime FechaInicial
        {
            get { return date_FechaInicial; }
            set { date_FechaInicial = value; }
        }
        private DateTime date_FechaFinal;

        public DateTime FechaFinal
        {
            get { return date_FechaFinal; }
            set { date_FechaFinal = value; }
        }

        private int int_amarre;

        public int Amarre
        {
            get { return int_amarre; }
            set { int_amarre = value; }
        }

        //Aqui va el barco (con yate, o velero o deportiva)
    }
}
