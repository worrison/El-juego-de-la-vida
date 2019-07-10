using NUnit.Framework;
using juego_de_la_vida;

namespace Tests
{
    
    public class Tests
    {
        Celula cel = new Celula();
        
        [SetUp]
        public void Setup()
        {
        }
        /*
         
             int n = 7;
            bool resultado = matematicas.esPrimo(n);
            Assert.IsTrue(resultado);
            Assert.Pass();
             
             
             
             
             */
        [Test]
        public void isViva1()
        {
            bool resultado=cel.viva(true, 2);
            Assert.IsTrue(resultado);
        }
        [Test]
        public void isViva2()
        {
            bool resultado = cel.viva(true, 3);
            Assert.IsTrue(resultado);
        }
        [Test]
        public void isViva3()
        {
            bool resultado = cel.viva(true, 1);
            Assert.IsFalse(resultado);
        }
        [Test]
        public void isViva4()
        {
            bool resultado = cel.viva(true, 4);
            Assert.IsFalse(resultado);
        }
        [Test]
        public void isMuerta()
        {
            bool resultado = cel.muerta(true, 3);
            Assert.IsTrue(resultado);
        }
        [Test]
        public void isMuerta1()
        {
            bool resultado = cel.muerta(true, 1);
            Assert.IsFalse(resultado);
        }
        [Test]
        public void isMuerta2()
        {
            bool resultado = cel.muerta(true, 2);
            Assert.IsFalse(resultado);
        }
        [Test]
        public void isMuerta3()
        {
            bool resultado = cel.muerta(true, 4);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}