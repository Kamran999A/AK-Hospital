using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace AK_Hospital
{
    class Doctor : Human
    {
        public int Id { get; set; }
        static int staticId { get; set; } = 0;
        public int Workyear { get; set; }
        public bool[] ReserveOrNot { get; set; } = { false, false, false };
        public  static void PrintTimes(Department dep, List<Time> times, int id)
        {
            for (int i = 0; i < times.Count; i++)
            {
                if (dep.doctors[id].ReserveOrNot[i] == false)
                {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(times[i]);
                }
                else
                {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{times[i]} - Reserved");
                }
            }
        }
        public void Meeting(int id)
        {
            if (id > 0 && id <= 3)
            {
                ReserveOrNot[id - 1] = true;
            }
            else 
            {
                Console.WriteLine("Sorry, I am busy...");
            }
        }
        public Doctor()
        {
            Id = ++staticId;
        }
        public override string ToString()
        {
            return $"\nId){Id}\n{base.ToString()}\nWork year - {Workyear}";
        }

    }
}