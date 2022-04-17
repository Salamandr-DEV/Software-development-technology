//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a; Console.WriteLine("Введите число:"); 
//            a = Convert.ToInt32(Console.ReadLine()); 
//            if (a % 2 == 0) 
//            {   
//                Console.WriteLine("Число " + a + " - чётное");  
//            }  
//            else   
//            {    
//                Console.WriteLine("Число " + a + " - нечётное");
//            }

//            Console.ReadKey();
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        { 
//            int a, b; Console.WriteLine("Введите первое число:"); 
//            a = Convert.ToInt32(Console.ReadLine()); 
//            Console.WriteLine("Введите второе число:"); 
//            b = Convert.ToInt32(Console.ReadLine());
//            if (a > b)
//            {
//                Console.WriteLine("Первое число больше второго");
//            }
//            else if (a < b)
//            {
//                Console.WriteLine("Второе число больше первого");
//            }
//            else
//            {
//                Console.WriteLine("Числа равны"); Console.ReadKey();
//            }
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int t; Console.WriteLine("Введите температуру во дворе");
//            t = Convert.ToInt32(Console.ReadLine());
//            if (t < -20 || t > 40)
//            {
//                Console.WriteLine("Вам лучше посидеть дома!");
//            }
//            else
//            {
//                Console.WriteLine("Можете идти гулять");
//            }

//            Console.ReadKey();
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        { 
//            int a; Console.WriteLine("Введите порядковый номер дня недели:"); 
//            a = Convert.ToInt32(Console.ReadLine()); 
//            switch (a) 
//            { 
//                case 1: Console.WriteLine("Понедельник"); 
//                    break;
//                case 2: Console.WriteLine("Вторник"); 
//                    break; 
//                case 3: Console.WriteLine("Среда"); 
//                    break; 
//                case 4: Console.WriteLine("Четверг"); 
//                    break; 
//                case 5: Console.WriteLine("Пятница"); 
//                    break; 
//                case 6: Console.WriteLine("Суббота"); 
//                    break; 
//                case 7: Console.WriteLine("Воскресенье"); 
//                    break; 
//                default: Console.WriteLine("Ошибка");
//                    break; 
//            } 
//            Console.ReadKey(); 
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        { 
//            int a; Console.WriteLine("Введите число:");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(a % 2 == 0 ? "Число чётное" : "Число нечётное"); 
//            Console.ReadKey(); 
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        { 
//            int a, b, max; 
//            Console.WriteLine("Введите первое число:"); 
//            a = Convert.ToInt32(Console.ReadLine()); 
//            Console.WriteLine("Введите второе число:"); 
//            b = Convert.ToInt32(Console.ReadLine()); 
//            max = a > b ? a : b; 
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = new int[5]; 
//            string[] seasons = new string[4] {"зима","весна","лето","осень"};

//            int[,] numbers1 = new int[2, 2];
//            int[,,] numbers2 = new int[2, 2 ,3]; 
//            int[,] numbers3 = new int[3, 2] { {6, 0}, {5, 7}, {8, 9} }; 


//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[][] array = new int[3][]; 
//            array [0] = new int[3]; 
//            array [1] = new int[2]; 
//            array [2] = new int[5];
//        }
//    }
//}


//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[5]; 
//            int size = numbers.Length; 
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> teams = new List<string>();  
//            teams.Add("Barcelona"); 
//            teams.Add("Chelsea");
//            teams.Add("Arsenal");   
//            List<string> teams2 = new List<string>() 
//            {"Dynamo", "CSKA"}; 
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 4, 7, 1, 23, 43 };
//            int s = 0;
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                s += numbers[i];
//            }
//            Console.WriteLine(s);
//            Console.ReadKey();
//        }
//    }
//}


//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true) 
//            { 
//                Console.WriteLine("Вечный цикл"); 
//            }
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        { 
//            int number; 
//            do 
//            { 
//                Console.WriteLine("Введите число 5"); 
//                number = Convert.ToInt32(Console.ReadLine()); 
//            } 
//            while (number != 5); 
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args) 
//        { 
//            int[] numbers = { 4, 7, 14, 20, 33, 23, 54 }; 
//            bool b = false; 
//            for (int i = 0; i < numbers.Length; i++) 
//            { 
//                if (numbers[i] % 13 == 0) 
//                { 
//                    b = true; 
//                    break;
//                } 
//            } 
//            Console.WriteLine(b ? "В массиве есть число кратное 13" : "В массиве нет числа кратного 13"); 
//            Console.ReadKey(); 
//        }
//    }
//}

//using System;

//namespace Lec2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 4, 7, 13, 20, 33, 23, 54 }; int s = 0; 
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (numbers[i] % 2 == 0)
//                {
//                    continue;
//                }
//                s += numbers[i];
//            }
//            Console.WriteLine(s);
//            Console.ReadKey();
//        }
//    }
//}

using System;

namespace Lec2
{
    class Program
    {
        static void Main(string[] args) 
        { 
            int[] numbers = { 4, 7, 13, 20, 33, 23, 54 }; 
            int s = 0; 
            foreach (int el in numbers) 
            { 
                s += el; 
            } 
            Console.WriteLine(s); 
            Console.ReadKey(); 
        }
    }
}