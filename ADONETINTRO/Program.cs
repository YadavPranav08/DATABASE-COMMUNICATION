using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETINTRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET DEMOS");

            TrainerDB db = new TrainerDB();
            List<Trainer> Trainers = db.AllTrainer();

            foreach (var t in Trainers)
            {
                Console.WriteLine($"ID: {t.ID} Name: {t.Name} City: {t.City} Experience: {t.Experience}");
            }

            Console.ReadLine();
        }
    }
}
