using System;
using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Clase abstract Gate
    /// </summary>
    public abstract class Gate : IInput
    {

        /// <summary>
        /// Constructor de Gate.
        /// </summary>
        /// <param name="nombre"></param>
        public Gate(string nombre)
        {
            this.Nombre = nombre;
            this.ListaEntradas = new Dictionary<string, IInput>();
        }

        /// <summary>
        /// Propiedad string nombre
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Propiedad diccionario ListaEntradas
        /// </summary>
        public Dictionary<string, IInput> ListaEntradas { get;set; }

        /// <summary>
        /// Metodo calculate que devuelve un booleano
        /// </summary>

        public abstract bool Calculate();

        /// <summary>
        /// Metodo que agrega entradas a la ListaEntradas
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="valor"></param>
        public void AgregarEntrada(string nombre, IInput valor)
        {
            if (!ListaEntradas.ContainsKey(nombre))
            {
                ListaEntradas.Add(nombre, valor);
            }
            else
            {
                ListaEntradas[nombre] = valor;
            }
        }

    }
}