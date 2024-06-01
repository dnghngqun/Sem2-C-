using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int MaxAtom = 10;
            Atom[] atoms = new Atom[MaxAtom];
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            //input 
            for(int i = 0; i < MaxAtom; i++)
            {
                atoms[i] = new Atom();
                if(!atoms[i].Accept())
                {
                    Console.WriteLine("Invalid input, retry!");
                    i--;
                }
            }

            //display
            Console.WriteLine("------------------");
            foreach(Atom atom in atoms)
            {
                atom.Display();
            }
        }
    }
}
