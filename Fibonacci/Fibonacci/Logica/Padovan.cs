using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Logica
{
    public class Padovan
    {
        int valorDosPosicionesAtras;
        int valorTresPosicionesAtras;
        int valor1pocisionAtras;
        int valor;
        int numeroVecesSiguiente;

        public Padovan()
        {
            this.valorDosPosicionesAtras = 1;
            this.valorTresPosicionesAtras = 1;
            this.valor = 1;
            this.valor1pocisionAtras = 1;
            this.numeroVecesSiguiente = 0;
        }

        public void siguiente() {

            this.numeroVecesSiguiente++;
            actualizarValores();
        }

        public void anterior() {
            this.numeroVecesSiguiente--;
            actualizarValoresRetroceso();
        }

        private void actualizarValoresRetroceso() {
            if (numeroVecesSiguiente <= 2 && numeroVecesSiguiente >=0)
            {
                this.valor = 1;
            }
            if (numeroVecesSiguiente > 2)
            {
             

                this.valor = this.valor1pocisionAtras;
                this.valor1pocisionAtras = this.valorDosPosicionesAtras;
                this.valorDosPosicionesAtras = this.valorTresPosicionesAtras;
                this.valorTresPosicionesAtras = this.valor1pocisionAtras - this.valorDosPosicionesAtras;

            }
        
        
        }

        private void actualizarValores() {
            if (numeroVecesSiguiente <= 2)
            {
                this.valor = 1;               
            }
            if (numeroVecesSiguiente > 2)
            {
                this.valorTresPosicionesAtras = this.valorDosPosicionesAtras;
                this.valorDosPosicionesAtras = this.valor1pocisionAtras;
                this.valor1pocisionAtras = this.valor;
                this.valor = valorDosPosicionesAtras + valorTresPosicionesAtras;    

            }
        }

        public int getValor() {
            return valor;
        }

    }
}
