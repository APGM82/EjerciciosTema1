using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema1
{
    abstract class Barco
    {
        private String str_Matricula;

        public String Matricula
        {
            get { return str_Matricula; }
            set { str_Matricula = value; }
        }

        private int int_Eslora;

        public int Eslora
        {
            get { return int_Eslora; }
            set { int_Eslora = value; }
        }
        private int date_Anyo;

        public int Anyo
        {
            get { return date_Anyo; }
            set { date_Anyo = value; }
        }

        public Barco(string Mat, int Eslo, int An) 
        {
            Matricula = Mat ;
            Eslora = Eslo;
            Anyo = An;  
        }
        
    }
}
