using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema1
{
    internal class Deportivas:Barco
    {
		private int int_PotenciaCV;

		public int PotenciaCV
		{
			get { return int_PotenciaCV; }
			set { int_PotenciaCV = value; }
		}
        public Deportivas(int CV, string mat, int eslora, int anyo) : base(mat, eslora, anyo)
        {
           PotenciaCV = CV;
        }
        public override int calculo()
        {
            int aux = (Eslora * 10) * 12;
            return aux;
        }
    }
}
