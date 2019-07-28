using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


using Fibonacci.InterfazGrafica.BotonSiguiente;
using Fibonacci.InterfazGrafica.BotonAnterior;
using Fibonacci.InterfazGrafica.Botones.BotonAudio;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaDecimal;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaBinaria;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaHexadecimal;
using Fibonacci.Logica;

namespace Fibonacci.InterfazGrafica.Paneles
{
    public class PanelNumeroDeLaSuerte : Panel
    {
        public PanelNumeroDeLaSuerte() {

            this.Visible = true;

            NumeroFibonacci fibonacci = new NumeroFibonacci();
            NumeroHexadecimal hexadecimal = new NumeroHexadecimal();
            NumeroBinario.NumeroBinario binario = new NumeroBinario.NumeroBinario();

            LabelDecimal label_decimal = new LabelDecimal();
            LabelBinaria label_binaria = new LabelBinaria();
            LabelHexadecimal label_hexadecimal = new LabelHexadecimal();

            //BottonSiguiente siguiente = new BottonSiguiente(fibonacci, label_decimal, label_binaria, label_hexadecimal, binario, hexadecimal);
            BottonAnterior anterior = new BottonAnterior(fibonacci, label_decimal, label_binaria, label_hexadecimal, binario, hexadecimal);

            BottonAudioHexadecimal audioHexadecimal = new BottonAudioHexadecimal(hexadecimal);
            BottonAudioDecimal audioDecimal = new BottonAudioDecimal(fibonacci);
            BottonAudioBinario audioBinario = new BottonAudioBinario(binario);

            this.Controls.Add(audioHexadecimal);
            this.Controls.Add(audioDecimal);
            this.Controls.Add(audioBinario);
            //this.Controls.Add(anterior);
            //this.Controls.Add(siguiente);
            this.Controls.Add(label_decimal);
            this.Controls.Add(label_binaria);
            this.Controls.Add(label_hexadecimal);

            this.Size = new Size(350, 170);
            this.Location = new Point(380, 20);

            Label etiqueta = new Label();
            etiqueta.Location = new Point(150, 5);
            etiqueta.Size = new Size(150,30);
            etiqueta.Text = "Numero De La Suerte";
            this.Controls.Add(etiqueta);
        
        }


    }
}
