using System;//import on java
using System.Collections.Generic;//generic same in java

namespace StudentManagement
{
    class Student
    {
        public int Id{get;set;}//getter and setter in java
        public string Name{get;set;}

        public int Age{get;set;}

        public String Major{get;set;}

    
        public override string ToString(){
            // return "Id: " + Id + " Name: " + Name + " Age: " + Age + " Major: " + Major;
            return $"Id: {Id} Name: {Name} Age: {Age} Major: {Major}";
        }
    }

    class Program
    {
        static List<Student> students = new List<Student>();
        static int currentID = 1;
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Student Management");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display all Student");
                Console.WriteLine("3. Search student by Id");
                Console.WriteLine("4. Delete student by Id");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());//scanner
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayAllStudent();
                        break;
                    case 3:
                        SearchByID();
                        break;
                    case 4:
                        DeleteByID();
                        break;
                    case 5:
                        return;//thoát 
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
        static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid age. Pls enter again: ");
                Console.Write("Enter student age: ");
            }

            Console.Write("Enter student major: ");
            string major = Console.ReadLine();

            Student student = new Student
            {
                Id = currentID++,
                Name = name,
                Age = age,
                Major = major
            };

            students.Add(student);
            Console.WriteLine("Student added successfully");

        }

        static void DisplayAllStudent()
        {
            Console.WriteLine("Display all students");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void SearchByID()
        {
            Console.WriteLine("Search student by ID");
            Console.Write("Enter student ID: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID. Pls enter again: ");
                Console.Write("Enter student ID: ");
            }

            var student = students.Find(item => item.Id == id);
            if (student != null)
            {
                Console.WriteLine("Student found:");
                Console.WriteLine(student.ToString());
            }
            else
            {
                Console.WriteLine("Student not found!");
            }

            // foreach(var std in students)
            // {
            //     if(std.Id == id){
            //         Console.WriteLine("Student found:");    
            //         Console.WriteLine(std.ToString());
            //     }
            // }

        }

        static void DeleteByID()
        {
            Console.WriteLine("Delete student by ID");
            Console.Write("Enter student ID: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID. Pls enter again: ");
                Console.Write("Enter student ID: ");
            }
            int count = students.RemoveAll(item => item.Id == id);
            if (count > 0)
            {
                Console.WriteLine("Student deleted successfully");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void UpdateByID()
        {
            Console.WriteLine("Update student by ID");
            Console.Write("Enter student ID: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID. Pls enter again: ");
                Console.Write("Enter student ID: ");
            }
            var student = students.Find(item => item.Id == id);
            if (student != null)
            {
                Console.WriteLine("Student found:");
                Console.WriteLine(student.ToString());
                Console.Write("Enter new name: ");
                student.Name = Console.ReadLine();
                Console.Write("Enter new age: ");
                int age;
                while(!int.TryParse(Console.ReadLine(), out age)){
                    Console.WriteLine("Invalid age. Pls enter again: ");
                    Console.Write("Enter new age: ");
                }
                student.Age = age;
                Console.WriteLine("Enter new major: ");
                student.Major = Console.ReadLine();
                Console.WriteLine("Student updated successfully");
                Console.WriteLine(student.ToString());
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}