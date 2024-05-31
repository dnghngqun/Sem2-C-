using System;

// namespace Encapsulation //tính đóng gói
// {
//     class Student
//     {
//         public int Id;
//         private string _Name;

//         //getter và setter cho name
//         public string Name
//         { 
//         get{ return _Name; }
//         set{_Name = value; }
//         }
       
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student = new Student();//khởi tạo 1 đối tượng student

//             student.Id = 1;// gán giá trị cho biến id, vì id để public nên có thể gắn trực tiếp
//             Console.WriteLine(student.Id);//output: 1

//             student.Name = "Nguyen Van A";//gán giá trị cho biến name, vì name được private nên gắn qua trung gian là Name
//             Console.WriteLine(student.Name);//output: Nguyen Van A
//         }
//     }
// }

namespace Polymorphism //Tính đa hình
{

    //function overloading
    // class Function_overloading
    // {
    //     void print(int i)
    //     {
    //         Console.WriteLine("In so nguyen: {0}", i);
    //     }
    //     void print(double f)
    //     {
    //         Console.WriteLine("In so thuc: {0}", f);
    //     }
    //     void print(string s)
    //     {
    //         Console.WriteLine("In chuoi: {0}", s);
    //     }
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Tinh da hinh trong C#");
    //         Console.WriteLine("--------------------------");
    //         //tao doi tuong
    //         Function_overloading p = new Function_overloading();
    //         // goi ham print()
    //         p.print(5); //output: In so nguyen: 5
    //         p.print(100.69);//output: In so thuc: 100.69
    //         Console.ReadKey();//đợi ấn một phím bất kì không thì ctrinh chạy xong sẽ tự tắt
    //     }
    // }

    //operator overloading
    class Box
    {
        private double chieu_dai;
        private double chieu_cao;
        private double chieu_rong;

        //getter và setter 
        public double Chieu_dai
        {
            get{return chieu_dai;}
            set{ chieu_dai = value;}
        }
        public double Chieu_rong
        {
            get{return chieu_rong;}
            set{ chieu_rong = value;}
        }

        public double Chieu_cao
        {
            get{return chieu_cao;}
            set{ chieu_cao = value;}

        }
        public double tinhTheTich()
        {
            return chieu_dai * chieu_rong * chieu_cao;
        }
        // nap chong toan tu + de cong hai doi tuong Box.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.chieu_dai = b.chieu_dai + c.chieu_dai;
            box.chieu_rong = b.chieu_rong + c.chieu_rong;
            box.chieu_cao = b.chieu_cao + c.chieu_cao;
            return box;
        }
    }
    class Operator_overloading
    {
        static void Main(string[] args)
        {
            //tao cac doi tuong Box1, Box2 va Box3
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double the_tich = 0.0;
            // nhap thong tin Box1
            Box1.Chieu_dai = 3.0;
            Box1.Chieu_rong = 5.0;
            Box1.Chieu_cao = 4.0;
            // nhap thong tin Box2
            Box2.Chieu_dai = 6.0;
            Box2.Chieu_rong = 7.0;
            Box2.Chieu_cao = 5.0;
            // tinh va hien thi the tich Box1
            the_tich = Box1.tinhTheTich();
            Console.WriteLine("The tich cua Box1 la: {0}", the_tich);//output: The tich cua Box1 la: 60
            // tinh va hien thi the tich Box2
            the_tich = Box2.tinhTheTich();
            Console.WriteLine("The tich cua Box2 la: {0}", the_tich);//output: The tich cua Box2 la: 210
            // con hai doi tuong
            Box3 = Box1 + Box2 + Box1 + Box1+ Box1+ Box1+ Box1+ Box1+ Box1+ Box1+ Box1+ Box1+ Box1;
            // tinh va hien thi the tich Box3
            the_tich = Box3.tinhTheTich();
            Console.WriteLine("The tich cua Box3 la: {0}", the_tich);//output: The tich cua Box3 la: 972
            Console.ReadKey();
        }
    }

    // sealed class SealedClass
    // {
    //     public void Display()
    //     {
    //         Console.WriteLine("This is a sealed class.");
    //     }
    // }

    // public class DerivedClass : SealedClass // lỗi vì SealedClass là sealed và không thể bị kế thừa
    // {

    // }

    //đa hình dynamic
    abstract class Shape
    {
        public abstract int tinhDienTich();
    }

    class HinhChuNhat : Shape //kế thừa abstract class Shape
    {
        private int chieu_dai;
        private int chieu_rong;
        public HinhChuNhat(int a = 0, int b = 0)
        {
            chieu_dai = a;
            chieu_rong = b;
        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich hinh chu nhat:");
            return (chieu_rong * chieu_dai);
        }
    }    
}

//tính kế thừa
// namespace Inheritance{
//     class Nguoi 
//     { 
//         // Khai báo thuộc tính 
//         public string maso; 
//         public string hoten; 
//         public string gioitinh; 

//         // Constructor
//         public Nguoi(string maso, string hoten, string gioitinh) 
//         { 
//             this.maso = maso; 
//             this.hoten = hoten; 
//             this.gioitinh = gioitinh; 
//         }  
//     }

//     class NhanVien : Nguoi
//     {
//         private string bangcap;

//         public NhanVien(string maso, string hoten, string gioitinh, string bangcap) 
//         : base(maso, hoten, gioitinh) // giống với super trong java 
//         {
//             this.bangcap = bangcap;
//         }
//     }
// }

// namespace Abstraction
// {
//     abstract class Hinh
//     {
//         public abstract void Ve(); // Phương thức trừu tượng
//         public void MoTa()
//         {
//             Console.WriteLine("Đây là một hình.");
//         }
//     }

//     class HinhTron : Hinh
//     {
//         public override void Ve()
//         {
//             Console.WriteLine("Vẽ hình tròn.");
//         }
//     }   
// }

// namespace Interface
// {
//     public interface IVe
//     {
//         void Ve();
//     }

//     public class HinhVuong : IVe
//     {
//         public void Ve()
//         {
//             Console.WriteLine("Vẽ hình vuông.");
//         }
//     }
// }

