using System;
using H1_Planets.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller ctrl = new Controller.Controller();
            ctrl.Start();
            Console.ReadLine();
        }
    }
}
