using NUnit.Framework;
using Banco;


namespace Tests
{
    public class Tests
    {
        Cuenta account = new Cuenta();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void testSaldo()
        {
            Assert.IsTrue(account.saldoActual >= 0);
        }
        [Test]
        public void sacarSaldo()
        {
            int cantidadSacar = 100;
            Assert.IsTrue(cantidadSacar <= account.saldoActual);
        }
        [Test]
        public void ingresoSaldo()
        {
            int cantidadSacar = 1;
            Assert.IsTrue(cantidadSacar > 0);
        }



    }
}