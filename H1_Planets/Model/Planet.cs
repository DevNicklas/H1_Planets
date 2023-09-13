using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planets.Model
{
    /// <summary>
    /// Class <see cref="Planet"/> represents a planet with a name, temperature and diameter
    /// </summary>
    internal class Planet
    {
        private string _name;
        private float _temperature;
        private float _diameter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Planet"/> class, using multiple arguments
        /// </summary>
        /// <param name="name">name of planet</param>
        /// <param name="temperature">temperatur of planet</param>
        /// <param name="diameter">diameter of planet</param>
        public Planet(string name, float temperature, float diameter)
        {
            _name = name;
            _temperature = temperature;
            _diameter = diameter;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public float Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }
    }
}
