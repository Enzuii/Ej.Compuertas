//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            try
            {
                AND and1 = new AND("AND-1");
                LogicInput valorA = new LogicInput(true);
                LogicInput valorB = new LogicInput(false);
                and1.AgregarEntrada("A", valorA);
                and1.AgregarEntrada("B", valorB);

                OR or2 = new OR("OR-2");
                LogicInput valorC = new LogicInput(false);
                or2.AgregarEntrada(and1.Nombre, and1);
                or2.AgregarEntrada("C", valorC);

                NOT not3 = new NOT("NOT-3");
                not3.AgregarEntrada(or2.Nombre, or2);

                Console.WriteLine($"El resultado es: {not3.Calculate()}");
            }
            catch (ExceptionInput e)
            {
                Console.WriteLine("El string no puede ser vacío");
            }

        }
    }
}