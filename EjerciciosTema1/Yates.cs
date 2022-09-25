using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjerciciosTema1
{
    internal class Yates:Barco
    {
		private int int_potenciaCV;

		public int PotenciaCV
		{
			get { return int_potenciaCV; }
			set { int_potenciaCV = value; }
		}
		private int int_NumCamarotes;

		public int NumCamarotes
		{
			get { return int_NumCamarotes; }
			set { int_NumCamarotes = value; }
		}

        public Yates(int CV,int camarotes, string mat, int eslora, int anyo) : base(mat, eslora, anyo)
        {
            PotenciaCV = CV;
			NumCamarotes = camarotes;
        }
        public override int calculo()
        {
            int aux = (Eslora * 10) * 12;
            return aux;
        }
    }
}
