namespace Library
{
    /// <summary>
    /// Clase LogicInput
    /// </summary>
    public class LogicInput : IInput
    {
        /// <summary>
        /// Propiedad bool salida
        /// </summary>   
        public bool salida{get;set;}

        /// <summary>
        /// Constructor de Logic Input
        /// </summary>
        /// <param name="valor"></param>

        public LogicInput(bool valor)
        {
            this.salida = valor;
        }
        /// <summary>
        /// Metodo calculate que devuelve un booleano
        /// </summary>
        public bool Calculate()
        {
            return salida;
        }
    }
}