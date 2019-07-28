using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Forms.Layout;

using Fibonacci.Logica;

using Fibonacci.InterfazGrafica.NumeroBinario;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaDecimal;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaBinaria;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaHexadecimal;


namespace Fibonacci.InterfazGrafica.BotonAnterior
{
    public class BottonAnterior : Button
    {
        private String etiqueta;
     
        private NumeroFibonacci fibonacci;
        private NumeroHexadecimal hexadecimal;
        private NumeroBinario.NumeroBinario binario;

        private LabelBinaria labelBinaria;
        private LabelHexadecimal labelHexadecimal;
        private LabelDecimal labelDecimal;

        public BottonAnterior(NumeroFibonacci fibonacci, LabelDecimal labelDecimal,
                               LabelBinaria labelBinaria, LabelHexadecimal labelHexadecimal,
                               NumeroBinario.NumeroBinario binario,NumeroHexadecimal hexadecimal)
        {
            this.labelDecimal = labelDecimal;
            this.labelBinaria = labelBinaria;
            this.labelHexadecimal = labelHexadecimal;
            
            this.fibonacci = fibonacci; 
            etiqueta = "Anterior";
            this.binario = binario;
            this.hexadecimal = hexadecimal;
            
            this.Text = etiqueta;
            this.Click += new EventHandler(click);
            this.Location = new Point(740, 30);
            this.BackColor = Color.Aqua;
            ActualizarEtiquetaDecimal();
            
        }


        private void click(object sender, EventArgs e)
        {
            fibonacci.anterior();
            ActualizarEtiquetaDecimal();
            ActualizarEtiquetaBinaria();
            ActualizarEtiquetaHexadecimal();

        }

        private void ActualizarEtiquetaDecimal()
        {
            labelDecimal.setEtiqueta(fibonacci.getValor().ToString());
        }

        private void ActualizarEtiquetaBinaria() {
            binario.setDecimal(fibonacci.getValor());
            labelBinaria.setEtiqueta(binario.getBinario());
        }

        private void ActualizarEtiquetaHexadecimal() {
            hexadecimal.setDecimal(fibonacci.getValor());
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
