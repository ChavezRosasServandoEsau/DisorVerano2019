using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.InterfazGrafica.NumeroBinario
{
 
    public class NumeroBinario
    {
        int numeroDecimal;
        String numeroBinario;

        public NumeroBinario() {
            numeroBinario = "0";
            numeroDecimal = 0;
        }

        public void siguiente() {
            numeroDecimal++;
            actualizarBinario();  
        }
        public void anterior()
        {
            numeroDecimal--;
            actualizarBinario();
        
        }

        private void actualizarBinario() {
            numeroBinario = Convert.ToString(numeroDecimal,2);
        }

        public String getBinario() {
            return numeroBinario;
        }

        public void setDecimal(int numDecimal) {
            this.numeroDecimal = numDecimal;
            actualizarBinario();
        }
    }
}
