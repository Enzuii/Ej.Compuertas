using System.Collections.Generic;
using System.Linq;

namespace Library{

/// <summary>
/// Clase AND
/// </summary>

public class AND : Gate
{   
    /// <summary>
    /// Constructor de AND.
    /// </summary>
    /// <param name="nombre"></param>
    public AND(string nombre) : base(nombre)
    {        
    }

    /// <summary>
    /// Metodo calculate que devuelve un booleano
    /// </summary>

    public override bool Calculate()
    {
        bool salida = true;
        
        if(ListaEntradas.Count != 2)
        {
            throw new System.Exception("La compuerta no tiene 2 entradas");
        }
        
        foreach(IInput c in ListaEntradas.Values)
        {
            salida = salida && c.Calculate();
        }
        return salida;
    }

}
}
