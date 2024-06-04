using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    // Interface
    interface IAnimal
    {
        void Say(); // phuong thuc interface khong co body
    }
    // Pig "implements" interface IAnimal
    class Pig : IAnimal
    {
        public void Say()
        {
            // Cung cap than ham Say() o day
            Console.WriteLine("The pig says: oik oik");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.Say();
        }
    }
}