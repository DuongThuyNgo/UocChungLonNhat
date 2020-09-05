using System;
using System.Text;

namespace SoNguyenTo
{
    class Program
    {
        static int n;

        static void Nhap()
        {
            do
            {
                Console.Write("Nhập n= ");
                n = int.Parse(Console.ReadLine());
            } while (n < 2);
        }
       
        static void SNT()
        {
            bool[] isPrime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            { 
                isPrime[i] = true;
            }
            isPrime[0] = false;
            isPrime[1] = false;
            for (int i = 2; i*i <= n; i++)
            {
                if (isPrime[i]==true)
                {
                    for (int j = i * i; j <= n; j = j + i)
                    {                  
                         isPrime[j] = false;
   
                    }
                    
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                    Console.WriteLine(i);
            }      
        }

       
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("\t\t\tTìm số nguyên tố từ 2->N ");

            while (true)
            {
                Nhap();
                Console.WriteLine("Số nguyên tố là:");
                SNT();
                Console.WriteLine("\t\t\t****************************");
                Console.WriteLine("Bạn có muốn nhập tiếp không???");
                Console.WriteLine("Nhấn A để nhập tiếp, nhấn phím bất kỳ để thoát!!!! ");
                string tiep = Console.ReadLine();
                if (tiep != "A") break;
                Console.WriteLine("\t\t\t****************************");
            }
            
        }
    }
}
