using System;
using System.Collections.Generic;
using H1_Planets.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planets.View
{
    /// <summary>
    /// Class <see cref="Gui"/> represents all the graphical
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// Writes all planets by name to user in the console
        /// </summary>
        /// <param name="planets"></param>
        public void ShowPlanets(List<Planet> planets)
        {
            // Loops thru evey single object in the list
            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Writes the amount of planets to user in the console
        /// </summary>
        /// <param name="planets">list of planets</param>
        public void ShowAmountOfPlanets(List<Planet> planets)
        {
            Console.WriteLine("Der er " + planets.Count + " planeter");
        }
    }
}
