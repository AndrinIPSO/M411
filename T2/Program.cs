using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiieren der Figuren Liste
            Figuren<ActionFigure> figures = new Figuren<ActionFigure>();

            // Hinzufügen von 10 ActionFiguren(Objekten)
            for (int i = 0; i < 10; i++)
            {
                figures.Add(new ActionFigure());
            }
            Console.WriteLine($"Add:\t\t\t{figures.Count}");

            // Löschen eines Objektes
            figures.Remove(figures[1]);
            Console.WriteLine($"Remove:\t\t\t{figures.Count}");

            // ändern eines feldes
            figures[1].Speed = 69;
            Console.WriteLine($"Speed von figur[1]:\t{figures.FindByIndex(1).Speed.ToString()}");

            // Enum Test
            figures[2].Direction = ActionFigure.DirectionTyp.Down;

            // Clear Funktion
            figures.Clear();
            Console.WriteLine($"Clear:\t\t\t{figures.Count}");
            Console.ReadLine();

        }


    }
}
