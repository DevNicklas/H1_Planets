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
            Planet mercury = new Planet("Merkur", 167, 4879, 0.330f, 5427, 3.7f, 1407.6f, 4222.6f, 57.9f, 88f, 47.4f, 0, false);
            Planet venus = new Planet("Venus", 464, 12104, 4.87f, 5243, 8.9f, -5832.5f, 2802f, 108.2f, 224.7f, 35f, 0, false);
            Planet earth = new Planet("Jorden", 15, 12756, 5.97f, 5514, 9.8f, 23.9f, 24.0f, 149.6f, 365.2f, 29.8f, 1, false);
            Planet mars = new Planet("Mars", -65, 6792, 0.642f, 3933, 3.7f, 24.6f, 24.7f, 227.9f, 687f, 24.1f, 2, false);
            Planet jupiter = new Planet("Jupiter", -110, 142984, 1898f, 1326, 23.1f, 9.9f, 9.9f, 778.6f, 4331f, 13.1f, 67, true);
            Planet saturn = new Planet("Saturn", -140, 120536, 568f, 687, 9f, 10.7f, 10.7f, 1433.5f, 10747f, 9.7f, 62, true);
            Planet uranus = new Planet("Uranus", -195, 51118, 86.8f, 1271, 8.7f, -17.2f, 17.2f, 2872.5f, 30589f, 6.8f, 27, true);
            Planet neptune = new Planet("Neptun", -200, 49528, 102f, 1638, 11f, 16.1f, 16.1f, 4495.1f, 59.8f, 5.4f, 14, true);
            Planet pluto = new Planet("Pluto", -225, 2370, 0.0146f, 2095, 0.7f, -153.3f, 153.3f, 5906.4f, 90.56f, 4.7f, 5, true);
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
