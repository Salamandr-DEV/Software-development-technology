//using System;

//namespace Lec1
//{
//    class Hello
//    {
//        static void Main()
//        {
//            Console.WriteLine("Hello World!");

//            Console.WriteLine("Press any key to exit.");
//            Console.ReadKey();
//        }
//    }
//}

//using System;

//namespace YourNamespace
//{
//    class YourClass
//    { }

//    struct YourStruct
//    { }

//    interface IYourInterface
//    { }

//    delegate int YourDelegate();
//    enum YourEnum
//    { }

//    namespace YourNestedNamespace
//    {
//        struct YourStruct
//        { }
//    }

//    class YourMainClass
//    {
//        static void Main(string[] args)
//        {
//            //Your program starts here...
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    public struct PostalAddress
//    {
//        // Fields, properties, methods and events go here...
//    }
//}

//using System;

//namespace Lec1
//{
//    interface IEquatable<T>
//    {
//        bool Equals(T obj);
//    }

//    public class Car : IEquatable<Car>
//    {
//        public string Make { get; set; }
//        public string Model { get; set; }
//        public string Year { get; set; }

//        public bool Equals(Car car)
//        {
//            if (this.Make == car.Make &&
//                this.Model == car.Model &&
//                this.Year == car.Year)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }

//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            int a;
//            a = 5;
//            int b, c;
//            bool d;
//            d = true;
//            long e = 10;
//            float f = 5.5f;
//            char g = 'g';
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            int a = 35; short b = 10; a = b;
//            b = a; // Ошибка
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            int a = 35000;
//            short b = 10;
//            b = (short)a;

//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            const int months = 12;
//            months = 13; // Ошибка
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(100); 
//            Console.WriteLine("Hello!"); 
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            var number = 5;
//            var text = "some text";
//            var number2 = 0.5;
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args) 
//        { 
//            string hello = "Hello!"; 
//            Console.WriteLine(hello); 
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            int a = 0, b = 5; 
//            a++; // a=1;  
//            b--; // b=4
//        }
//    }
//}

//using System;

//namespace Lec1
//{
//    class Main_class
//    {
//        static void Main(string[] args)
//        {
//            int a = 2, b = 3, c, d = 3;
//            c = a + ++b;
//            c = a + d++;
//        }
//    }
//}

using System;

namespace Lec1
{
    class Main_class
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3; 
            a += b;
            a -= b; 
            a *= b; 
            a /= b; 
            a %= b; 
        }
    }
}