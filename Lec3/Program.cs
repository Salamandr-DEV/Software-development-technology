//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class zad1
//    {

//        public static void ReplaceName(string[] names, string name, string newName) 
//        { 
//            for (int i = 0; i < names.Length; i++) 
//            { 
//                if (names[i] == name) names[i] = newName; } }
//        static void Main(string[] args)
//        {

//            string[] names = { "Sergey", "Maxim", "Andrey", "Oleg", "Andrey", "Ivan", "Sergey" };
//            Console.WriteLine("[{0}]", string.Join(", ", names));
//            ReplaceName(names, "Andrey", "Nikolay"); 
//            // вызов функции. Все строки "Andrey" в массиве будут заменены на "Nikolay"    
//            ReplaceName(names, "Ivan", "Vladimir");
//            Console.WriteLine("[{0}]", string.Join(", ", names));
//            Console.ReadLine();
//        }
//    }        
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class zad2
//    {
//        public static int GetMax(int[] array) 
//        { int max = array[0]; 
//            for (int i = 1; i < array.Length; i++) 
//            { 
//                if (array[i] > max) max = array[i]; 
//            } 
//            return max; 
//        }
//        static void Main(string[] args)
//        {
//            int[] number = { 1,35,46,7,2,8,15,8 };
//            Console.WriteLine("[{0}]", string.Join(", ", number));
//            Console.WriteLine(GetMax(number));
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class zad3
//    {
//        static void Main(string[] args) 
//        { 
//            string s = "Hello, World!"; 
//            Console.WriteLine(s);
//            char c = s[1]; // 'e'
//            Console.WriteLine(c);
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class zad4
//    {
//        static void Main(string[] args)
//        {
//            string s1 = null, s2 = "", s3 = "Hello";
//            Console.WriteLine(String.IsNullOrEmpty(s1));  
//            Console.WriteLine(String.IsNullOrEmpty(s2));
//            Console.WriteLine(String.IsNullOrEmpty(s3));
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class zad5
//    {
//        static void Main(string[] args)
//        {
//            string s1 = null, s2 = "\t", s3 = " ", s4 = "Hello";
//            Console.WriteLine(String.IsNullOrWhiteSpace(s1));  // True
//            Console.WriteLine(String.IsNullOrWhiteSpace(s2)); // True  
//            Console.WriteLine(String.IsNullOrWhiteSpace(s3)); // True
//            Console.WriteLine(String.IsNullOrWhiteSpace(s4)); // False 
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class zad6
//    {
//        static void Main(string[] args)
//        {
//            string result = ""; Console.WriteLine("Введите число:");
//            try
//            {
//                int a = Convert.ToInt32(Console.ReadLine()); //вводим данные, и конвертируем в целое число
//                result = "Вы ввели число " + a;
//            }
//            catch (FormatException)
//            {
//                result = "Ошибка. Вы ввели не число";
//            }
//            Console.WriteLine(result); Console.ReadLine();
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class zad7
//    {
//        static void Main(string[] args) 
//        { 
//            //File.Create("D:\\new_file.txt");
//            File.WriteAllText("D:\\new_file.txt", "текст");
//            File.AppendAllText("D:\\new_file.txt", "текст метода AppendAllText ()"); //допишет текст в конец файла
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class zad8
    {
        static void Main(string[] args)
        {
            FileStream file1 = new FileStream("d:\\test.txt", FileMode.Open); //создаем файловый поток 
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком   
            Console.WriteLine(reader.ReadToEnd()); //считываем все данные с потока и выводим на экран 
            reader.Close(); //закрываем поток
            Console.ReadLine();

        }
    }
}
