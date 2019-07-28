using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Logica
{
    public class NumeroFeliz
    {
        int valor;
        Boolean feliz;
        public NumeroFeliz() {
            this.valor = 1;
            feliz=true;
        }


        public void siguiente() {
            this.valor++;
            comprobarFelicidad();
        }

        public int getValor() {
            return valor;
        }

        public Boolean esFelis() {
            return feliz;
        }

        public void setValor(int valor){
            this.valor = valor;
            comprobarFelicidad();
        }


        private void comprobarFelicidad() {
            String cadenaValor = valor.ToString();


            for (int i = 0; i < 8; i++ )
            {
                if (Int32.Parse(cadenaValor) == 1)
                {
                    this.feliz = true;
                    break;
                }
                else {
                        this.feliz = false;
                        int sumatoriaCuadrados = 0;
                        for (int d = 0; d < cadenaValor.Length; d++ ) {
                            sumatoriaCuadrados += Int32.Parse(cadenaValor.Substring(d, 1)) * Int32.Parse(cadenaValor.Substring(d, 1));                                              
                        }
                        cadenaValor = sumatoriaCuadrados.ToString();

                }
            }        
        }



    }
}
