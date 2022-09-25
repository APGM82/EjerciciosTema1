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

        
        public Veleros(int numv, string Mat, int Eslo, int An, String Nombre, String Dni, int Amarre) :base(Mat,Eslo,An,Nombre,Dni,Amarre) {
            NumVelas = numv;    
        }
        public override int calculo()
        {
            int aux = (Eslora * 10) * 12;
            return aux;
        }

    }
}
