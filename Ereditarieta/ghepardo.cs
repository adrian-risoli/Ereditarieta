using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta
{
    class ghepardo:Animale
    {

        int velocità;

        public ghepardo(string n,int v) : base(n)
        {
            velocità = v;
        }

        public int getvelocità()
        {
            return velocità;
        }
        

        public void confronta_velocità(int v1, string n)
        {
            if (velocità > v1)
            {
                Console.WriteLine("ha vinto rodrigo");
            }
            else if (velocità < v1)
            {
                Console.WriteLine("ha vinto "+ n);
            }
            else
            {
                Console.WriteLine("cavolo rodrigo hai pareggiato!");
            }
        }
    }
}
