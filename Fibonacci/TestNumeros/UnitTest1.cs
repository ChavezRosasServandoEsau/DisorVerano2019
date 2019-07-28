using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci.Logica.NumerUlam;
using Fibonacci.Logica;
namespace TestNumeros
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreacionNumeroUlam()
        {
            Ulam ulam = new Ulam();
            int valorEsperado = 0;
            int valorObtenido = ulam.getValor();

            Assert.AreEqual(valorEsperado,valorObtenido);
        }


        [TestMethod]
        public void ulamSiguiente()
        {
            Ulam ulam = new Ulam();
            int valorEsperado = 1;
            ulam.siguiente();
            int valorObtenido = ulam.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void ulamSiguiente2Veces()
        {
            Ulam ulam = new Ulam();
            int valorEsperado = 2;
            ulam.siguiente(); ulam.siguiente();
            int valorObtenido = ulam.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void ulamSiguiente3Veces()
        {
            Ulam ulam = new Ulam();
            int valorEsperado = 3;
            ulam.siguiente(); ulam.siguiente();
            ulam.siguiente();
            int valorObtenido = ulam.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void ulamSiguiente4Veces()
        {
            Ulam ulam = new Ulam();
            int valorEsperado = 4;
            ulam.siguiente(); ulam.siguiente();
            ulam.siguiente(); ulam.siguiente();
            int valorObtenido = ulam.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void ulamSiguiente5Veces()
        {
            Ulam ulam = new Ulam();
            int valorEsperado = 6;
            ulam.siguiente(); ulam.siguiente();
            ulam.siguiente(); ulam.siguiente();
            ulam.siguiente();
            int valorObtenido = ulam.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void CreacionNumeroFeliz()
        {
            NumeroFeliz feliz = new NumeroFeliz();
            Boolean valorEsperado = true;
            Boolean valorObtenido = feliz.esFelis(); ;

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        /*numero padovan*/
        [TestMethod]
        public void CreacionNumeroPadovan()
        {
            Padovan pado= new Padovan();
            int  valorEsperado = 1;
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void PadovanAvanzar1vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 1;
            pado.siguiente();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void PadovanAvanzar2vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 1;
            pado.siguiente(); pado.siguiente();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void PadovanAvanzar3vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 2;
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void PadovanAvanzar6vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 4;
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void PadovanAvanzar12vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 21;

            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void PadovanAvanzar12vecesRetroceder1vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 16;

            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.anterior();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }


        [TestMethod]
        public void PadovanAvanzar12vecesRetroceder2vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 12;

            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.anterior(); pado.anterior();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void PadovanAvanzar12vecesRetroceder3vez()
        {
            Padovan pado = new Padovan();
            int valorEsperado = 9;

            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.siguiente(); pado.siguiente(); pado.siguiente();
            pado.anterior(); pado.anterior(); pado.anterior();
            int valorObtenido = pado.getValor();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }



        /*Numero Capicua*/
        [TestMethod]
        public void Capicua()
        {
            Capicua pado = new Capicua();
            Boolean valorEsperado = true;
            pado.setNumero(33);
            Boolean valorObtenido = pado.esCapicua();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }


        /*Numero Feliz*/
        [TestMethod]
        public void CreacionFeliz()
        {
            NumeroFeliz feliz = new NumeroFeliz();
            Boolean valorEsperado = true;

            Boolean valorObtenido = feliz.esFelis();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void FelizSiguiente1vez()
        {
            NumeroFeliz feliz = new NumeroFeliz();
            Boolean valorEsperado = false;
            feliz.siguiente();
            Boolean valorObtenido = feliz.esFelis();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void Feliz100()
        {
            NumeroFeliz feliz = new NumeroFeliz();
            Boolean valorEsperado = true;
            feliz.setValor(3);
            Boolean valorObtenido = feliz.esFelis();

            Assert.AreEqual(valorEsperado, valorObtenido);
        }
    }
}
