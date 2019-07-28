using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Logica
{
    public class NumeroHexadecimal
    {
        int numeroDecimal;
        String numeroHexadecimal;

        public NumeroHexadecimal() {
            numeroHexadecimal = "0";
            numeroDecimal = 0;
        }

        public void siguiente()
        {
            numeroDecimal++;
            actualizarHexadecimal();

        }

        private void actualizarHexadecimal()
        {
            numeroHexadecimal =numeroDecimal.ToString("X");
        }

        public String getHexadecimal()
        {
            return numeroHexadecimal;
        }

        public void setDecimal(int numDecimal)
        {
            this.numeroDecimal = numDecimal;
            actualizarHexadecimal();
        }


    }
}
