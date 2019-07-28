using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Logica
{
    public class Capicua
    {
        int numero;

        public Capicua() {
            this.numero = 0;
        }

        public void siguiente() {
            this.numero++;
        }

        public void setNumero(int numero) {

            this.numero = numero;
            esCapicua();
        }


        public Boolean esCapicua() {
            char[] chararray = numero.ToString().ToCharArray();
            Array.Reverse(chararray);
            String numeroreversa= new String(chararray);
            return numero.ToString().Equals(numeroreversa) ? true : false; 
        }

    }
}
