using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCalculadora.Controllers;
using NUnit.Framework;

namespace NUnit_ProyectoCalculadora
{
    [TestFixture]
    public class TestCalculadora
    {
        private Calculadora _calculadora = null;

        [SetUp]
        public void SetUpTest()
        {
            _calculadora = new Calculadora();
        }


        [Test]
        public void TestSuma()
        {
            var result = _calculadora.Suma(1, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestDivision()
        {
            var ex = Assert.Throws<Exception>(() => _calculadora.Division(2, 3));
            Assert.That(ex.Message, Is.EqualTo("Division entre 0"));
        }
    }
}
