using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Fibonacci.InterfazGrafica.Etiquetas.EtiquetaCapicua
{
    public class LabelCapicua : Label
    {
        private String etiqueta;
        public LabelCapicua()
         {
            etiqueta = "Numero Capicua?";
            this.Text = etiqueta;
            this.Location = new Point(240, 190);
            this.Size = new Size(400, 30);
        }


        public void cambiarFondoBoton(Color color) {
            this.BackColor = color;
        }
    }
}
