using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema1
{
    internal class Veleros:Barco
    {
        private int int_NumVelas;

        public int NumVelas
        {
            get { return int_NumVelas; }
            set { int_NumVelas = value; }
        }
        //Barco a = new Barco("ttt",6,1945);

        
        public Veleros(int numv, string mat, int eslora, int anyo) :base(mat,eslora,anyo) {
            NumVelas = numv;    
        }
    }
}
