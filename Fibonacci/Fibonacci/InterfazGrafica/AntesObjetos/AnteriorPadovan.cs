using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fibonacci.Logica;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Controls;

using Fibonacci.InterfazGrafica.NumeroBinario;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaDecimal;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaBinaria;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaHexadecimal;

using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaFeliz;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaCapicua;

namespace Fibonacci.InterfazGrafica.AntesObjetos
{
    public class AnteriorPadovan
    {
        Padovan padovan;
        private NumeroHexadecimal hexadecimal;
        private NumeroBinario.NumeroBinario binario;
        private LabelBinaria labelBinaria;
        private LabelHexadecimal labelHexadecimal;
        private LabelDecimal labelDecimal;

        private LabelCapicua labelcapicua;
        private LabelNumeroFeliz labelfeliz;
        private Capicua numerocapicua;
        private NumeroFeliz numerofeliz;


        public AnteriorPadovan(Padovan padovan,LabelDecimal labelDecimal,
                               LabelBinaria labelBinaria, LabelHexadecimal labelHexadecimal,
                               NumeroBinario.NumeroBinario binario, NumeroHexadecimal hexadecimal, 
                               LabelCapicua labelcapicua, LabelNumeroFeliz labelfeliz)
        {
            this.labelDecimal = labelDecimal;
            this.labelBinaria = labelBinaria;
            this.labelHexadecimal = labelHexadecimal;            
            this.padovan = padovan; 
            this.binario = binario;
            this.hexadecimal = hexadecimal;

            this.labelfeliz = labelfeliz;
            this.labelcapicua = labelcapicua;
            this.numerocapicua = new Capicua();
            this.numerofeliz = new NumeroFeliz();
        
        }

        public void anteriorPadovan() {
            padovan.anterior();
            ActualizarEtiquetaDecimal();
            ActualizarEtiquetaBinaria();
            ActualizarEtiquetaHexadecimal();
            ActualizarEtiquetaCapicua();
            ActualizarEtiquetaFeliz();
        }

        private void ActualizarEtiquetaDecimal()
        {
            labelDecimal.setEtiqueta(padovan.getValor().ToString());
        }

        private void ActualizarEtiquetaBinaria()
        {
            binario.setDecimal(padovan.getValor());
            labelBinaria.setEtiqueta(binario.getBinario());
        }

        private void ActualizarEtiquetaHexadecimal()
        {
            hexadecimal.setDecimal(padovan.getValor());
            labelHexadecimal.setEtiqueta(hexadecimal.getHexadecimal());
        }

        private void ActualizarEtiquetaCapicua()
        {
            numerocapicua.setNumero(padovan.getValor());
            if (numerocapicua.esCapicua())
            {
                labelcapicua.cambiarFondoBoton(Color.Green);
            }
            else
            {
                labelcapicua.cambiarFondoBoton(Color.Red);
            }
        }

        private void ActualizarEtiquetaFeliz()
        {
            numerofeliz.setValor(padovan.getValor());
            if (numerofeliz.esFelis())
            {
                labelfeliz.cambiarFondoBoton(Color.Green);
            }
            else
            {
                labelfeliz.cambiarFondoBoton(Color.Red);
            }
        }

    }
}
