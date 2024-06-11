// C# collection
using System.Net.Security;
using Collection;

class Program
{
    public static void Main(string[] args)
    {
        // List<T>: phù hợp tring việc đọc, truy xuất thông tin
        List<string> student = new List<String>{"thu", "Thao", "Manh"};
        student.Add("Hoang");
        Console.WriteLine("List Student: ");
        foreach(var std in student)
        {
            Console.WriteLine(std);
        }

        //LinkedList<T>: phù hợp với đọc liên kết hai chiều, khi cần truy xuất thêm sửa xoá dữ liệu liên tục, thường xuyên
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

        //Stack<T> LIFO: last in first out, xử lý ngược của giá trị thêm vào
        Stack<string> books = new Stack<string>();
        books.Push("Java");
        books.Push("C#");
        books.Push("Python");
        Console.WriteLine("Stack of books: ");
        while(books.Count > 0)
        {
            Console.WriteLine(books.Pop());
        }

        // Queue<T> FIFO: First in first out, xử lý theo thứ tự, trình tự
        Queue<string> customers = new Queue<string>();
        customers.Enqueue("cus1");
        customers.Enqueue("cus2");
        customers.Enqueue("cus3");
        customers.Enqueue("cus4");
        Console.WriteLine("Queue of Customers: ");
        while(customers.Count > 0)
        {
            Console.WriteLine(customers.Dequeue());
        }

        // Dictionary<key, value>: truy xuất nhanh, truy cập nhanh chóng đến giá trị qua key, giống HashMap
        Dictionary<int, string> studentGrade = new Dictionary<int, string> { { 1, "A" }, { 2, "B" } };
        studentGrade.Add(3, "C");
        studentGrade.Add(4, "D");
        studentGrade.Add(5, "E");

        // HashSet<T>: không trùng lặp giá trị, không sắp xếp, đảm bảo giá trị duy nhất
        HashSet<string> cities = new HashSet<string>() { "Hanoi", "Tp.HCM", "Hai phong" };
        cities.Add("Ha tinh");
        cities.Add("Nam dinh");
        Console.WriteLine("HashSet of Cities: ");

        foreach(var city in cities)
        {
            Console.WriteLine(city);
        }
        //tao repository cho student
        EntityRepository<Student> studentRepository = new EntityRepository<Student>();
        // tao repository cho SchoolClass
        EntityRepository<SchoolClass> schoolRepository = new EntityRepository<SchoolClass>();

        // tao repository cho Teacher
        EntityRepository<Teacher> teacherRepository = new EntityRepository<Teacher>();

        studentRepository.Add(new Student { Id = 1, Name = "Gia Minh" });
        foreach(var Student in studentRepository.GetAll())
        {
            Console.WriteLine(Student.ToString());
        }
        
        schoolRepository.Add(new SchoolClass { Id = 123, Name = "10A1" });
        foreach(var sClass in schoolRepository.GetAll())
        {
            Console.WriteLine(sClass.ToString());
        }

        teacherRepository.Add(new Teacher { Id = 1, Name = "Nguyen Tuan" });
        foreach(var Teacher in teacherRepository.GetAll())
        {
            Console.WriteLine(Teacher.ToString());
        }
    }    
}