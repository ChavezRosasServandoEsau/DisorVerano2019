using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

using Fibonacci.InterfazGrafica.Botones.BottonAnteriorGeneral;

using Fibonacci.InterfazGrafica.Paneles;

namespace Fibonacci.InterfazGrafica.VentanaPrincipal
{
    public partial class VentanaPrincipal : Form
    {
        String label;
        

        public VentanaPrincipal() {

            PanelFibonacci panel_fibo = new PanelFibonacci();
            PanelNumeroDeLaSuerte panel_delaSuerte = new PanelNumeroDeLaSuerte();
            PanelNumeroUlam panel_Ulam = new PanelNumeroUlam();
            PanelNumeroPadovan panel_padovan = new PanelNumeroPadovan();
            
            BottonAnterior anterior = new BottonAnterior(panel_fibo.getAntesFibonacci(),panel_padovan.getAnteriorPadovan());

            this.Controls.Add(anterior);
            this.Controls.Add(panel_padovan);
            this.Controls.Add(panel_Ulam);
            this.Controls.Add(panel_delaSuerte);
            this.Controls.Add(panel_fibo);
            label = "Numero Fibonacci";
            this.Text = label;
            this.Size = new Size(940,600);
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }


        [STAThread]
        public static void Main() {
            
            Application.EnableVisualStyles();           
            Application.Run(new VentanaPrincipal());
        }

    }
}
