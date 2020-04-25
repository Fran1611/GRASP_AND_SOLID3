using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /*La clase FilePrinter implementa la interfaz IPrinter...
    ...haciendo uso de la operacion polimorfica PrintRecipe para "imprimir" la receta en un archivo de texto.
    Cumple con SRP ya que no existe mas de una razon de cambio de la clase
    La clase FilePrinter es subtipo de IPrinter.*/
    public class FilePrinter : IPrinter
    { 
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}