using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Fibonacci.InterfazGrafica.Etiquetas.EtiquetaFeliz
{
    public class LabelNumeroFeliz : Label
    {
         private String etiqueta;
         public LabelNumeroFeliz()
         {
            etiqueta = "Numero Feliz?";
            this.Text = etiqueta;
            this.Location = new Point(40, 190);
            this.Size = new Size(100, 30);
        }

         public void cambiarFondoBoton(Color color)
         {
             this.BackColor = color;
         }
    }
}
