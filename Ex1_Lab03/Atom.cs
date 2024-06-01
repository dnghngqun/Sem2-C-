using System;
using System.Security.Cryptography.X509Certificates;

class Atom
{
    private int AtomicNumber;//so hieu nguyen tu
    private string AtomicSymbol;//ky hieu hoa hoc
    private string AtomicName;//ten nguyen tu
    private double AtomicWeight;//nguyen tu khoi
    public bool Accept()
    {
        Console.Write("Enter Atomic Number: ");
        if (!int.TryParse(Console.ReadLine(), out int Num) || Num <= 0)
        {
            Console.WriteLine("Invalid input atomic number!");
            return false;
        }
        this.AtomicNumber = Num;
        Console.Write("Enter symbol: ");
        this.AtomicSymbol = Console.ReadLine();
        Console.Write("Enter full name: ");
        this.AtomicName = Console.ReadLine();
        Console.Write("Enter atomic weight: ");
        if(!double.TryParse(Console.ReadLine(), out double Weight) || Weight <= 0)
        {
            Console.WriteLine("Invalid input atomic weight!");
            return false;
        }
        this.AtomicWeight = Weight;
        return true;
    }
    public void Display()
    {
        Console.WriteLine(this.AtomicNumber + " " + this.AtomicSymbol + " " + this.AtomicName + " " + this.AtomicWeight );
    }
}
