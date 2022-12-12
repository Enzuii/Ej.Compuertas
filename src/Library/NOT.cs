using System.Collections.Generic;
using System.Linq;

namespace Library{
    
/// <summary>
/// Clase NOT
/// </summary>
public class NOT : Gate
{ 
    /// <summary>
    /// Constructor de NOT
    /// </summary>
    public NOT(string nombre) : base(nombre)
    {        
    }

    /// <summary>
    /// Metodo calculate que devuelve un booleano
    /// </summary>
    public override bool Calculate()
    {
        bool salida = true;
        
        if(ListaEntradas.Count != 1)
        {
            throw new System.Exception("La compuerta no tiene 1 entrada");
        }

        foreach (IInput c in ListaEntradas.Values)
        {
            salida = !c.Calculate();
        }
        return salida;
    }

}
}
