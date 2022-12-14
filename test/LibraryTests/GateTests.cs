//--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using Library;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Clase tests
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Crea los objetos true or false.
        /// </summary>
        LogicInput True = new LogicInput(true);
        LogicInput False = new LogicInput (false);

        /// <summary>
        /// Prueba circuito AND.
        /// </summary>
        [Test]
        public void ANDTest()
        {
            AND and1 = new AND("AND-1");
            and1.AgregarEntrada("A", True);
            and1.AgregarEntrada("B", False);
            Assert.AreEqual(false, and1.Calculate());
            try
            {
                and1.AgregarEntrada("C", True);
                and1.Calculate();
                Assert.Fail();
            }
            catch(ExceptionInput e)
            {
                Assert.Pass();
            }
        
        }
        

        /// <summary>
        /// Prueba circuito OR.
        /// </summary>
        [Test]
        public void ORTest()
        {
            OR or2 = new OR("OR-2");
            or2.AgregarEntrada("A", True);
            or2.AgregarEntrada("B", False);
            Assert.AreEqual(true, or2.Calculate());
            try
            {
                or2.AgregarEntrada("C", True);
                or2.Calculate();
                Assert.Fail();
            }
            catch(ExceptionInput e)
            {
                Assert.Pass();
            }

        }
        
        /// <summary>
        /// Prueba circuito NOT.
        /// </summary>
        [Test]
        public void NOTTest()
        {
            NOT not3 = new NOT("NOT-3");
            not3.AgregarEntrada("A", True);
            Assert.AreEqual(false, not3.Calculate());
            try
            {
                not3.AgregarEntrada("B", True);
                not3.Calculate();
                Assert.Fail();
            }
            catch(ExceptionInput e)
            {
                Assert.Pass();
            }
        }
        
        /// <summary>
        /// Prueba circuito ejercicio.
        /// </summary>
        [Test]
        public void CircuitoTest()
        {
            AND and1 = new AND("AND-1");
            and1.AgregarEntrada("A", True);
            and1.AgregarEntrada("B", False);

            OR or2 = new OR("OR-2");
            or2.AgregarEntrada(and1.Nombre, and1);
            or2.AgregarEntrada("C", False);

            NOT not3 = new NOT("NOT-3");
            not3.AgregarEntrada(or2.Nombre, or2);
            Assert.AreEqual(true, not3.Calculate());

            
        }
    }
}