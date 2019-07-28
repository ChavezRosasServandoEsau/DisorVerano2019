using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci.Logica;
using Fibonacci.InterfazGrafica.NumeroBinario;


namespace TestNumeroFibonacci
{
    [TestClass]
    public class UnitTest1
    {
        /*pruebas numero fibonacci*/
        [TestMethod]
        public void CreacionObjeto()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 0;
            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }


        [TestMethod]
        public void FibonacciAnterior()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 0;
            numerofibonacci.anterior();
            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void FibonacciSiguiente2Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 1;
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void FibonacciSiguiente3Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 1;
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void FibonacciSiguiente3VecesAnterior5Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 0;
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.anterior();
            numerofibonacci.anterior();
            numerofibonacci.anterior();
            numerofibonacci.anterior();
            numerofibonacci.anterior();

            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void FibonacciSiguiente10Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 34;
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();

            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void FibonacciSiguiente10VecesAnterior6Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 2;
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();

            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }


        [TestMethod]
        public void FibonacciSiguiente10VecesAnterior12Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 0;
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();

            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }


        [TestMethod]
        public void FibonacciSiguiente20Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 4181;
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            
            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void FibonacciSiguiente20VecesAnterior16Veces()
        {
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            int valorEsperado = 2;
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();
            numerofibonacci.siguiente(); numerofibonacci.siguiente();

            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();
            numerofibonacci.anterior(); numerofibonacci.anterior();


            int valorObtenido = numerofibonacci.getValor();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        /*Pruebas numero Binario*/

        [TestMethod]
        public void NumeroBinario()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "0";
            String obtenido = bin.getBinario();
            Assert.AreEqual(esperado,obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSiguiente2Veces()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "10";
            bin.siguiente();
            bin.siguiente();
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSiguiente10Veces()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "1010";
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSiguiente20Veces()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "10100";
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSiguiente40Veces()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "101000";
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
         
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSiguiente20Veces8VecesAnterior()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "10100";
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            bin.siguiente(); bin.siguiente();
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void NumeroBinarioSet79()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "1001111";
            bin.setDecimal(79);
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSet2()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "10";
            bin.setDecimal(2);
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSet22()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "10110";
            bin.setDecimal(22);
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSet22Siguiente2Veces()
        {
            NumeroBinario bin = new NumeroBinario();
            String esperado = "11000";
            bin.setDecimal(22);
            bin.siguiente(); bin.siguiente();
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroBinarioSetFibonacciSiguiente4veces()
        {
            NumeroBinario bin = new NumeroBinario();
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            String esperado = "10";
            bin.setDecimal(numerofibonacci.getValor());
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void NumeroBinarioSetFibonacciSiguiente4vecesAnterior5Veces()
        {
            NumeroBinario bin = new NumeroBinario();
            NumeroFibonacci numerofibonacci = new NumeroFibonacci();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.siguiente();
            numerofibonacci.anterior();
            numerofibonacci.anterior();
            numerofibonacci.anterior();
            numerofibonacci.anterior();
            numerofibonacci.anterior();
            String esperado = "0";
            bin.setDecimal(numerofibonacci.getValor());
            String obtenido = bin.getBinario();

            Assert.AreEqual(esperado, obtenido);
        }

        /*pruebas numero hexadecimal*/

        [TestMethod]
        public void NumeroHexadecimal()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "0";
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSiguiente5Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "5";
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); 
            String obtenido = hexa.getHexadecimal();
           
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSiguiente10Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "A";
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSiguiente30Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "1E";
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();

            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void NumeroHexadecimalSiguiente100Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "64";
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente(); 
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();

            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSet79()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "C8C";
            hexa.setDecimal(3212);
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSet9()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "9";
            hexa.setDecimal(9);
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSet999()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "3E7";
            hexa.setDecimal(999);
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSet7984()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "1F30";
            hexa.setDecimal(7984);
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void NumeroHexadecimalSet79Siguiente2Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "51";
            hexa.setDecimal(79);
            hexa.siguiente(); hexa.siguiente();
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSet1009Siguiente12Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "3FD";
            hexa.setDecimal(1009);
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSet9719Siguiente8Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "25FF";
            hexa.setDecimal(9719);
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            hexa.siguiente(); hexa.siguiente();
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacci()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "0";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente2Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "1";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente12Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "59";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente22Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "2AC2";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente32Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "148ADD";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            

            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente13Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "90";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente13VecesAnterior14Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "0";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente13VecesAnterior1Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "59";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.anterior(); 
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente13VecesAnterior1VeceshexaSiguiente()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "59";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.anterior();            
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente13VecesAnterior6VecesHexaSiguiente()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "8";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            hexa.siguiente();
            hexa.setDecimal(fibonacci.getValor());
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente2VecesHexaSiguiente()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "2";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();           
            hexa.setDecimal(fibonacci.getValor());
            hexa.siguiente();
            
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente5VecesHexaSiguiente()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "4";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            hexa.setDecimal(fibonacci.getValor());
            hexa.siguiente();

            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente10VecesHexaSiguiente2Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "24";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            hexa.setDecimal(fibonacci.getValor());
            hexa.siguiente();
            hexa.siguiente();
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente30VecesHexaSiguiente2Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "7D8B7";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            hexa.setDecimal(fibonacci.getValor());
            hexa.siguiente();
            hexa.siguiente();
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente30VecesAnterior5HexaSiguiente1Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "B521";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.anterior();
            fibonacci.anterior();
            fibonacci.anterior();
            fibonacci.anterior();
            fibonacci.anterior();
            hexa.setDecimal(fibonacci.getValor());
            hexa.siguiente();
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void NumeroHexadecimalSetFibonacciSiguiente30VecesAnterior32HexaSiguiente1Veces()
        {
            NumeroHexadecimal hexa = new NumeroHexadecimal();
            String esperado = "1";
            NumeroFibonacci fibonacci = new NumeroFibonacci();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente(); fibonacci.siguiente();
            fibonacci.siguiente();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();
            fibonacci.anterior(); fibonacci.anterior();

            hexa.setDecimal(fibonacci.getValor());
            hexa.siguiente();
            String obtenido = hexa.getHexadecimal();
            Assert.AreEqual(esperado, obtenido);
        }


    }
}
