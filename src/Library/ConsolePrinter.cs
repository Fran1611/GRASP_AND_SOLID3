using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    /* La clase ConsolePrinter implementa la interfaz Iprinter
    haciendo uso de la operacion polimorifica PrintRecipe para imprimir por consola la receta.
    La clase ConsolePrinter es subtipo de IPrinter.
    Cumple con SRP ya que no existe mas de una razon de cambio de la clase*/
    public class ConsolePrinter : IPrinter
    { 
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}