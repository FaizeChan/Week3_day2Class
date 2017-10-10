using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day2Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Boat Poseidon = new Boat(3, "Poseidon", 15.4);
            Poseidon.Move();
            Poseidon.BoatInfo();

            Console.WriteLine();
            Boat Boat2 = new Boat(14, "Mermaid Man", 28.9);
            Boat2.BoatInfo();
        }
    }
}
