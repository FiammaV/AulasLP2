using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite {
    class Program {
        static void Main(string[] args) {

            FNPlayer p1 = new FNPlayer();
            FNPlayer p2 = new FNPlayer(100, 50);

            Console.WriteLine("P2's health before: " + p2.health);
            p1.Attack(p2);
            Console.WriteLine("P2's health after: " + p2.health);
        }
    }
}
