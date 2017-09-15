using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoCalculadora.Controllers;

namespace UnitTests_ProyectoCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            var calculadora = new Calculadora();
            var result = calculadora.Suma(1, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Division entre cero no permitida.")]
        public void TestDivisionEntreCero()
        {
            var calculadora = new Calculadora();
            var result = calculadora.Division(2, 0);
        }
    }
}
