using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Logica
{
    public class NumeroFibonacci
    {
        private int numAnterior, valor;
        private int NumeroVecesActualziado;

        public NumeroFibonacci() {
            this.NumeroVecesActualziado = 0;
            this.numAnterior = 0;
            this.valor = 0;
        
        }

        private void actualizar()
        {
            if (NumeroVecesActualziado == 0)
            {
                valor = 0;
            }
            if (NumeroVecesActualziado == 1)
            {
                valor = 1;
            }
            if (NumeroVecesActualziado >= 2)
            {
                valor = valor + numAnterior;
                numAnterior = valor - numAnterior;
            }
        }

        private void actualizarAnterior() {
        if(NumeroVecesActualziado==0){
 
        }
        else{
            int respaldoActual=this.valor;
            this.valor=numAnterior;
            this.numAnterior=respaldoActual-this.numAnterior;          
       }       
    }
    
    
        public void siguiente(){
            if (NumeroVecesActualziado < 45)
            {
                actualizar();
                NumeroVecesActualziado++;            
            }
            }
    
    
        public void anterior() {
            if(valor > 0){
                actualizarAnterior();
                NumeroVecesActualziado--;
            }           
        }

        public int getValor() {
            return valor;
        }

    }
}
