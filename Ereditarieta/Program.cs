using System;
using System.Collections.Generic;

namespace Ereditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            List<ghepardo> ghepardi = new List<ghepardo>();
            int num_ghepardi;
            Random rnd = new Random();
            ghepardo rodrigo = new ghepardo("rodrigo", 20);

            Console.WriteLine("quanti ghepardi vuoi?: ");
            num_ghepardi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num_ghepardi; i++)
            {
                int r = rnd.Next(0, 50);
                Console.WriteLine("come vuoi chiamare il ghepardo?: ");
                string n = Console.ReadLine();
                ghepardo ghepardo = new ghepardo(n,r);
                ghepardi.Add(ghepardo);
            }
            foreach (ghepardo item in ghepardi)
            {
                rodrigo.confronta_velocità(item.getvelocità(),item.getname());
            }
        }
        
    }
}
