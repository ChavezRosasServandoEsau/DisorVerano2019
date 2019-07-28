using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;


namespace Fibonacci.Logica.NumerUlam
{
    public class Ulam
    {
        ArrayList serie;
        int numeroActual;
        int numeroDeVeces;

        public Ulam()
        {
            serie = new ArrayList();
            this.numeroActual = 0;
            this.numeroDeVeces = 0;
        }

        public void siguiente()
        {
            this.numeroDeVeces++;

            if (this.numeroDeVeces == 1)
            {
                this.numeroActual = 1;
                serie.Add(this.numeroActual);
            }
            else if (this.numeroDeVeces == 2)
            {
                this.numeroActual = 2;
                serie.Add(this.numeroActual);
            }
            else if (this.numeroDeVeces > 2)
            {

                while (!esValido(this.numeroDeVeces))
                {
                    this.numeroDeVeces++;
                }
                this.serie.Add(this.numeroDeVeces);
                this.numeroActual = this.numeroDeVeces;
            }

        }


        private Boolean esValido(int numero)
        {
            ArrayList validos = new ArrayList();
            for (int i = 0; i < this.serie.Count; i++)
            {

                for (int j = 0; j < this.serie.Count; j++)
                {

                    if (Int64.Parse(this.serie[i].ToString()) + Int64.Parse(this.serie[j].ToString()) == numero)
                    {
                        int numv =
                        validos.Add(Int64.Parse(this.serie[i].ToString()) + Int64.Parse(this.serie[j].ToString()));
                    }

                }
            }
            return validos.Count == 1 ? true : false;
        }

        public int getValor()
        {
            return this.numeroActual;
        }



        
    }
}
