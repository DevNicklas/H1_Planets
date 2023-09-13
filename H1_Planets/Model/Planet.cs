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
        private int _diameter;
        private float _mass;
        private short _density;
        private float _gravity;
        private float _rotationPeriod;
        private float _dayLength;
        private float _sunDistance;
        private float _orbitPeriod;
        private float _orbitVelocity;
        private ushort _moonAmount;
        private bool _hasRingSystem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Planet"/> class, using multiple arguments
        /// </summary>
        /// <param name="name">name of planet</param>
        /// <param name="temperature">temperatur of planet</param>
        /// <param name="diameter">diameter of planet</param>
        public Planet(string name, float temperature, int diameter, float mass, short density, float gravity, float rotationPeriod, float dayLength, float sunDistance, float orbitPeriod, float orbitVelocity, ushort moonAmount, bool hasRingSystem)
        {
            _name = name;
            _temperature = temperature;
            _diameter = diameter;
            _mass = mass;
            _density = density;
            _gravity = gravity;
            _rotationPeriod = rotationPeriod;
            _dayLength = dayLength;
            _sunDistance = sunDistance;
            _orbitPeriod = orbitPeriod;
            _orbitVelocity = orbitVelocity;
            _moonAmount = moonAmount;
            _hasRingSystem = hasRingSystem;
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

        public int Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public float Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public short Density
        {
            get { return _density; }
            set { _density = value; }
        }

        public float Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }

        public float RotationPeriod
        {
            get { return _rotationPeriod; }
            set { _rotationPeriod = value; }
        }

        public float DayLength
        {
            get { return _dayLength; }
            set { _dayLength = value; }
        }

        public float SunDistance
        {
            get { return _sunDistance; }
            set { _sunDistance = value; }
        }

        public float OrbitPeriod
        {
            get { return _orbitPeriod; }
            set { _orbitPeriod = value; }
        }

        public float OrbitVelocity
        {
            get { return _orbitVelocity; }
            set { _orbitVelocity = value; }
        }

        public ushort MoonAmount
        {
            get { return _moonAmount; }
            set { _moonAmount = value; }
        }

        public bool HasRingSystem
        {
            get { return _hasRingSystem; }
            set { _hasRingSystem = value; }
        }
    }
}
