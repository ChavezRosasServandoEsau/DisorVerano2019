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

namespace Fibonacci.InterfazGrafica.Botones.BotonAudio
{
    class BottonAudioBinario : Button
    {
        private String etiqueta;
        private SpeechSynthesizer synth;
        private NumeroBinario.NumeroBinario binario;

        public BottonAudioBinario(NumeroBinario.NumeroBinario binario) {
            this.binario = binario;
            etiqueta = "Audio Binario";
            this.Text = etiqueta;
            this.Click += new EventHandler(click);
            this.Location = new Point(240, 110);
            this.BackColor = Color.Aqua;
            this.Size = new Size(100,30);
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
        }

        private void click(object sender, EventArgs e)
        {
            synth.Speak(binario.getBinario());
        }

    }
}
