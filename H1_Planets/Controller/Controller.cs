using H1_Planets.Model;
using H1_Planets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planets.Controller
{
    /// <summary>
    /// Class <see cref="Controller"/> controls the program
    /// </summary>
    internal class Controller
    {
        /// <summary>
        /// Starts the program and control it fully
        /// </summary>
        public void Start()
        {
            #region Planets
            Planet mercury = new Planet("Merkur", 167, 4879.4f);
            Planet venus = new Planet("Venus", 462, 12104f);
            Planet earth = new Planet("Jorden", 15, 12742f);
            Planet mars = new Planet("Mars", -60, 6779f);
            Planet jupiter = new Planet("Jupiter", -145, 142800f);
            Planet saturn = new Planet("Saturn", -178, 116460f);
            Planet uranus = new Planet("Uranus", -195, 50724f);
            Planet neptune = new Planet("Neptun", -214, 55528f);
            Planet pluto = new Planet("Pluto", -232, 2376.6f);
            #endregion
             
            List<Planet> planets = new List<Planet>()
            {
                mercury, earth, mars, jupiter, saturn, uranus, neptune, pluto
            };

            List<Planet> planetsLowTemperture = new List<Planet>();

            List<Planet> planetsCertainDiameter = new List<Planet>();

            // Shows all planets to user
            Gui gui = new Gui();
            gui.ShowPlanets(planets);

            // Insert venus after mercury
            planets.Insert(planets.IndexOf(mercury) + 1, venus);

            // Shows all planets to user
            gui.ShowPlanets(planets);

            // Removes pluto from list of planets
            planets.Remove(pluto);

            // Shows all planets to user
            gui.ShowPlanets(planets);

            // Adds pluto to list of planets
            planets.Add(pluto);

            // Shows amount of planets to user
            gui.ShowAmountOfPlanets(planets);

            // Adds all planets with a temperature below 0 to a new list
            foreach (Planet planet in planets)
            {
                if (planet.Temperature < 0)
                {
                    planetsLowTemperture.Add(planet);
                }
            }

            // Adds all planets with a diameter between 10000 and 50000 km to a new list
            foreach (Planet planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    planetsCertainDiameter.Add(planet);
                }
            }

            planets.Clear();
        }
    }
}
