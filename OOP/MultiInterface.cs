using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Interface
{
   interface IFirstInterface
    {
        void myMethod(); // phuong thuc interface
    }
 
    interface ISecondInterface
    {
        void myOtherMethod(); // phuong thuc interface
    }
 
    // Implement nhiều interface
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Kiem tra IFirstInterface...");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Kiem tra ISecondInterface...");
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}