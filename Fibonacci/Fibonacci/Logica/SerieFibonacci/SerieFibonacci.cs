using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Logica.SerieFibonacci
{
   public class SerieFibonacci
    {

        private NumeroFibonacci numero = new NumeroFibonacci();
        private int cantidad;
        private int[] serie;
        public SerieFibonacci(int cantidad)
        {
            this.cantidad = cantidad;
            this.serie = new int[cantidad];
            this.actualizarSerie();
        }
       
        public int[] getSerie()
        {
            return this.serie;
        }
       
        private void actualizarSerie()
        {
            for (int x = 0; x < cantidad; x++)
            {
                this.numero.siguiente();
                this.serie[x] = numero.getValor();
            }
        }
    }
}
