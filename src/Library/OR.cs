using System.Collections.Generic;
using System.Linq;


namespace Library{
    /// <summary>
    /// Clase OR.
    /// </summary>

public class OR : Gate
{   
    /// <summary>
    /// Constructor de OR
    /// </summary>
    public OR(string nombre) : base(nombre)
    {        
    }

    /// <summary>
    /// Metodo calculate que devuelve un booleano
    /// </summary>
    public override bool Calculate()
    {
        bool salida = false;
        
        if(ListaEntradas.Count != 2)
        {
            throw new ExceptionInput("La compuerta no tiene 2 entradas");
        }
        
        foreach(IInput c in ListaEntradas.Values)
        {
            salida = salida || c.Calculate();           
        }
        return salida;
    }

}
}
