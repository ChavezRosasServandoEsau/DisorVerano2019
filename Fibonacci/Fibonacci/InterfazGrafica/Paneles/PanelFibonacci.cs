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

using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaCapicua;

using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaFeliz;
using Fibonacci.Logica;
using Fibonacci.InterfazGrafica.AntesObjetos;

namespace Fibonacci.InterfazGrafica.Paneles
{
    public class PanelFibonacci : Panel
    {
        AntesFibonacci anteriorfibo;

        public PanelFibonacci() {
            this.Visible = true;

            NumeroFibonacci fibonacci = new NumeroFibonacci();
            NumeroHexadecimal hexadecimal = new NumeroHexadecimal();
            NumeroBinario.NumeroBinario binario = new NumeroBinario.NumeroBinario();

            LabelDecimal label_decimal = new LabelDecimal();
            LabelBinaria label_binaria = new LabelBinaria();
            LabelHexadecimal label_hexadecimal = new LabelHexadecimal();
            LabelNumeroFeliz label_feliz = new LabelNumeroFeliz();
            LabelCapicua label_Capicua = new LabelCapicua();
            BottonSiguiente siguiente = new BottonSiguiente(fibonacci, label_decimal, label_binaria, label_hexadecimal, binario, hexadecimal,label_Capicua,label_feliz);
            this.anteriorfibo = new AntesFibonacci(fibonacci, label_decimal, label_binaria, label_hexadecimal, binario, hexadecimal, label_Capicua, label_feliz);

            BottonAudioHexadecimal audioHexadecimal = new BottonAudioHexadecimal(hexadecimal);
            BottonAudioDecimal audioDecimal = new BottonAudioDecimal(fibonacci);
            BottonAudioBinario audioBinario = new BottonAudioBinario(binario);


            this.Controls.Add(label_Capicua);
            this.Controls.Add(label_feliz);
            this.Controls.Add(audioHexadecimal);
            this.Controls.Add(audioDecimal);
            this.Controls.Add(audioBinario);
           // this.Controls.Add(anterior);
            this.Controls.Add(siguiente);
            this.Controls.Add(label_decimal);
            this.Controls.Add(label_binaria);
            this.Controls.Add(label_hexadecimal);

            this.Size = new Size(350,220);
            this.Location = new Point(10,20);

            Label etiqueta = new Label();
            etiqueta.Location = new Point(160, 5);
            etiqueta.Text = "Numero Fibonacci";
            this.Controls.Add(etiqueta);
        
        }


        public AntesFibonacci getAntesFibonacci() {
            return anteriorfibo;
        }
    }
}
