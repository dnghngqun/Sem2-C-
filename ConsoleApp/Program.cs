// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Hello, world!");

            Console.ReadKey();//đợi ấn một phím bất kì không thì ctrinh chạy xong sẽ tự tắt
            
            //nhập xuất trong c#
            Console.Write("Trong này là đoạn chữ, giá trị cần in ra màn hình");
            // In ra màn hình số 10
            Console.Write(10); 

            // In ra màn hình số 10.9 (f biểu thị cho kiểu dữ liệu float)
            Console.Write(10.9f); 

            // In ra màn hình chữ true của kiểu dữ liệu boolean
            Console.Write(true); 

            Console.WriteLine("Trong này cũng giống write nhưng in xong tự xuống dòng");

            Console.Read();//đọc kí tự từ bàn phím, trả về kiểu số nguyên
			//chú ý: lệnh này không đọc được các phím chức năng như Ctrl, Shift, Alt, Caps Lock, Tab, . . .

            Console.ReadLine();//đọc kí tự từ bàn phím cho đến khi gặp kí tự xuống dòng
			//giá trị luôn đọc được là chuỗi

            //Console.ReadKey(<Tham số kiểu boolean>): để đọc một ký tự từ bàn phím nhưng trả về kiểu ConsoleKeyInfo 
			//(là một kiểu dữ liệu có cấu trúc được định nghĩa sẵn để chứa 
			//những ký tự của bàn phím bao gồm các phím chức năng).
			//Tham số kiểu bool bao gồm 2 giá trị: true hoặc false
            Console.ReadKey(); // không truyền tham số vào thì mặc định là false.
       		Console.ReadKey(false); // hiển thị phím ấn lên màn hình.
       		Console.ReadKey(true); // Không hiển thị phím ấn lên màn hình.

	        //khai báo biến
	        int BienKieuSoNguyen;

	        float BienKieuSoThuc;

	        string BienKieuChuoi;

	        bool BienKieuLuanLy;

	        char BienKieuKyTu;
	        
	        decimal BienKieuSoThapPhan;
	        //Có độ chính xác đến 28 con số và giá trị thập phân, được dùng trong tính toán tài chính
	        
	        /*
	         * Giá trị của kiểu char sẽ nằm trong dấu ‘ ’ (nháy đơn).
	           Giá trị của kiểu string sẽ nằm trong dấu “ ” (nháy kép).
	           Giá trị của biến kiểu float phải có chữ F hoặc f làm hậu tố.
	           Giá trị của biến kiểu decimal phải có chữ m hoặc M làm hậu tố.
	         */

	        //goto
	        //Bản chất của goto là nhảy đến bất cứ nơi đâu có label. Mọi câu lệnh khác khi goto bỏ qua đều bị trình biên dịch bỏ qua.
	        int a = 2;
	        switch(a)
	        {

		        case 1:             // label case 1
			        Console.WriteLine("Case 1");
			        break;
		        case 2:             // label case 2
			        Console.WriteLine("Case 2");
			        goto case 1;    // dịch chuyển tới label case 1
			        //break;          // Đoạn code này thừa vì sẽ không bao giờ thực thi
		        case 3:             // label case 3
			        Console.WriteLine("Case 3");
			        goto nhan1;
			       // break;
	        }


	        //khai báo nhãn(label)
        	nhan1:
	        {
		        Console.WriteLine("Đây là nhãn 3");
            }

        }
    }

 
}