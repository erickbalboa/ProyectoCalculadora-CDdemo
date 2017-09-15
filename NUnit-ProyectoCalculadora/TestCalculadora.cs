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
        [Test]
        public void TestSuma()
        {
            var calculadora = new Calculadora();
            var result = calculadora.Suma(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
