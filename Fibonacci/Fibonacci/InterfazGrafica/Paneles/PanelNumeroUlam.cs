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
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaFeliz;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaCapicua;
using Fibonacci.InterfazGrafica.Botones;
using Fibonacci.InterfazGrafica.AntesObjetos;
using Fibonacci.Logica.NumerUlam;


namespace Fibonacci.InterfazGrafica.Paneles
{
    public class PanelNumeroUlam : Panel
    {
        public PanelNumeroUlam() {


            this.Visible = true;

            Ulam ulam= new Ulam();
            NumeroHexadecimal hexadecimal = new NumeroHexadecimal();
            NumeroBinario.NumeroBinario binario = new NumeroBinario.NumeroBinario();

            LabelDecimal label_decimal = new LabelDecimal();
            LabelBinaria label_binaria = new LabelBinaria();
            LabelHexadecimal label_hexadecimal = new LabelHexadecimal();
            LabelNumeroFeliz label_feliz = new LabelNumeroFeliz();
            LabelCapicua label_Capicua = new LabelCapicua();

            BottonSiguienteUlam siguiente = new BottonSiguienteUlam(ulam, label_decimal, label_binaria, label_hexadecimal, binario, hexadecimal, label_Capicua, label_feliz);
          //BottonAnterior anterior = new BottonAnterior(fibonacci, label_decimal, label_binaria, label_hexadecimal, binario, hexadecimal);

            BottonAudioHexadecimal audioHexadecimal = new BottonAudioHexadecimal(hexadecimal);
            BottonAudioUlam audioDecimal = new BottonAudioUlam(ulam);
            BottonAudioBinario audioBinario = new BottonAudioBinario(binario);

            this.Controls.Add(label_feliz);
            this.Controls.Add(label_Capicua);
            this.Controls.Add(audioHexadecimal);
            this.Controls.Add(audioDecimal);
            this.Controls.Add(audioBinario);
            this.Controls.Add(siguiente);
            this.Controls.Add(label_decimal);
            this.Controls.Add(label_binaria);
            this.Controls.Add(label_hexadecimal);

            this.Size = new Size(350, 220);
            this.Location = new Point(10, 250);

            Label etiqueta = new Label();
            etiqueta.Location = new Point(160, 5);
            etiqueta.Text = "Numero Ulam";
            this.Controls.Add(etiqueta);
        
        
        }
    }
}
