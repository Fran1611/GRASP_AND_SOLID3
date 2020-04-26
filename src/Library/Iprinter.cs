using System;

namespace Full_GRASP_And_SOLID.Library
{
    /* La interface IPrinter define la operacion PrintRecipe para imprimir una receta.
    PrintRecipe es polimorfica es utilizada por dos objetos de distinto tipo y no pregunta por el destino de impresion.
    Cumple con el principio de sustitución de Liskov ya que tanto al imprimir por consola
    como al imprimir en un archivo de texto, la receta no se altera*/
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}