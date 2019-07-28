using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


using Fibonacci.InterfazGrafica.NumeroBinario;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaDecimal;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaBinaria;
using Fibonacci.InterfazGrafica.Etiquetas.EtiquetaHexadecimal;
using Fibonacci.Logica;
using Fibonacci.InterfazGrafica.AntesObjetos;

namespace Fibonacci.InterfazGrafica.Botones.BottonAnteriorGeneral
{
    public class BottonAnterior : Button
    {
        AntesFibonacci fibo;
        AnteriorPadovan padovan;
        String etiqueta;

        public BottonAnterior(AntesFibonacci fibo,AnteriorPadovan padovan) {
            etiqueta = "Anterior";
            this.Text = etiqueta;
            this.Click += new EventHandler(click);
            this.Location = new Point(400, 520);
            this.BackColor = Color.Aqua;

            this.fibo = fibo;
            this.padovan = padovan;
        }

        private void click(object sender, EventArgs e)
        {
            fibo.anteriorFibonacci();
            padovan.anteriorPadovan();
        }

        
    }
}
