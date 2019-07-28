using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Fibonacci.InterfazGrafica.Etiquetas.EtiquetaBinaria
{
    public class LabelBinaria : Label
    {
         private String etiqueta;
         public LabelBinaria()
         {
            etiqueta = "Binaria";
            this.Text = etiqueta;
            this.Location = new Point(40, 120);
            this.Size = new Size(400, 30);
        }
         public void setEtiqueta(String texto)
         {
             this.etiqueta = texto;
             this.Text = etiqueta;
         }
    }
}
