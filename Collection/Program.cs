// C# collection
class Program
{
    public static void Main(string[] args)
    {
        // List<T>
        List<string> student = new List<String>{"thu", "Thao", "Manh"};
        student.Add("Hoang");
        Console.WriteLine("List Student: ");
        foreach(var std in student)
        {
            Console.WriteLine(std);
        }

        //LinkedList<T>
        LinkedList<string> languages = new LinkedList<string>();
        languages.AddFirst("C#");
        languages.AddLast("Java");
        languages.AddFirst("Python");
        languages.AddFirst("Scala");
        Console.WriteLine("LinkedList of programming languages: ");
        foreach(var language in languages)
        {
            Console.WriteLine(language);
        }

        //Stack<T> LIFO: last in first out
        
    }
}