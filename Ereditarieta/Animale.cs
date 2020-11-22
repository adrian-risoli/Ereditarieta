using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta
{
    public abstract class Animale
    {
        protected string nome;

        public Animale(string n)
        {
            nome = n;
        }
        public void mangia()
        {
            Console.WriteLine("Gnam gnam");
        }
        
        public virtual void verso()
        {
            Console.WriteLine("Gru gru");
        }
        public string getname()
        {
            return nome;
        }

       


    }
}
