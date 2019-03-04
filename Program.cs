using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Miller", "Michael", 40000);
            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 999999999);
            chuckNorris.Lead();

            Trainee Gladys = new Trainee(32, 8, "Smith", "Gladys", 10000);
            Gladys.Learn();
            Gladys.Work();
            Console.ReadKey();
        }
    }
}
