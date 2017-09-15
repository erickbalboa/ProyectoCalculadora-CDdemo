using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using ProyectoCalculadora.Controllers;

namespace NUnit_ProyectoCalculadora
{
    [TestFixture]
    public class TestCalculadoraWithMoq
    {
        private Mock<ICalculadora> _calculadora; 

        [SetUp]
        public void SetupForTest()
        {
            _calculadora = new Mock<ICalculadora>();
            _calculadora
                .Setup(calc => calc.Suma(0, 0))
                .Returns(100);
        }

        [Test]
        public void TestSumaWithMock()
        {
            int resultMockA = _calculadora.Object.Suma(2, 3);
            Assert.AreEqual(resultMockA, 0);
            int resultMockB = _calculadora.Object.Suma(0, 0);
            Assert.AreEqual(resultMockB, 100);
        }
    }
}
