using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Controls;


using Fibonacci.Logica;

using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaDecimal;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaBinaria;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaHexadecimal;

using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaFeliz;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaCapicua;

namespace Fibonacci.InterfazGrafica.Botones
{
    class BottonSiguientePadovan : Button 
    {
        private String etiqueta;

        private Padovan padovan;
        private NumeroHexadecimal hexadecimal;
        private NumeroBinario.NumeroBinario binario;

        private LabelBinaria labelBinaria;
        private LabelHexadecimal labelHexadecimal;
        private LabelDecimal labelDecimal;

        private LabelCapicua labelcapicua;
        private LabelNumeroFeliz labelfeliz;
        private Capicua numerocapicua;
        private NumeroFeliz numerofeliz;

        public BottonSiguientePadovan(Padovan padovan, LabelDecimal labelDecimal,
                               LabelBinaria labelBinaria,LabelHexadecimal labelHexadecimal,
                                NumeroBinario.NumeroBinario binario, NumeroHexadecimal hexadecimal,
                                LabelCapicua labelcapicua, LabelNumeroFeliz labelfeliz)
        {
            this.labelfeliz = labelfeliz;
            this.labelcapicua = labelcapicua;
            this.labelDecimal = labelDecimal;
            this.labelBinaria = labelBinaria;
            this.labelHexadecimal = labelHexadecimal;
            this.padovan = padovan;
            this.binario = binario;
            this.hexadecimal = hexadecimal;
            this.numerocapicua = new Capicua();
            this.numerofeliz = new NumeroFeliz();


            this.Size = new Size(100,30);            
            etiqueta = "Siguiente -->";
            this.Text = etiqueta;
            this.Click += new EventHandler(click);
            this.Location = new Point(240,30);
            this.BackColor = Color.Aqua;
            
            ActualizarEtiquetaDecimal();
            ActualizarEtiquetaBinaria();
            ActualizarEtiquetaHexadecimal();
            ActualizarEtiquetaCapicua();
            ActualizarEtiquetaFeliz();
        }

        private void click(object sender, EventArgs e)
        {
            padovan.siguiente();
            ActualizarEtiquetaDecimal();
            ActualizarEtiquetaBinaria();
            ActualizarEtiquetaHexadecimal();
            ActualizarEtiquetaCapicua();
            ActualizarEtiquetaFeliz();

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


        public void println(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BottonSiguiente{");
            sb.Append("\n");
            sb.Append("text := " + etiqueta);
            sb.Append("\n");
            sb.Append("object := " + sender);
            sb.Append("\n");
            sb.Append("EventArgs := " + e);
            sb.Append("\n");
            sb.Append("}");
            Console.WriteLine(sb.ToString());
        }





    }
}
