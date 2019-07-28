using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Synthesis;

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Controls;

using Fibonacci.Logica;

namespace Fibonacci.InterfazGrafica.Botones.BotonAudio
{
    class BottonAudioDecimal : Button
    {
        private String etiqueta;
        private SpeechSynthesizer synth;
        private NumeroFibonacci fibo;

        public BottonAudioDecimal(NumeroFibonacci fibo) {
            this.fibo = fibo;
            etiqueta = "Audio Decimal";
            this.Text = etiqueta;
            this.Click += new EventHandler(click);
            this.Location = new Point(240, 80);
            this.BackColor = Color.Aqua;
            this.Size = new Size(100,30);
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

        }

        private void click(object sender, EventArgs e)
        {
            synth.Speak(fibo.getValor().ToString());
        }

    }
}
