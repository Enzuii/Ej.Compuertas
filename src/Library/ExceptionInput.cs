namespace Library
{
    /// <summary>
    /// Clase ExceptionInput crea una excepción personalizada para este caso 
    /// </summary>
    public class ExceptionInput : System.Exception
    {
        /// <summary>
        /// Constructor de ExceptionInput
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public ExceptionInput(string message) : base(message)
        {

        }
    }
}