//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    class Student
//    {
//        private string firstName; 
//        private string lastName; 
//        private int age; 
//        public string group; // не рекомендуется использовать public для поля
//    }

//        class zad1
//    {
//        static void Main(string[] args)
//        {
//            Student student1 = new Student(); 
//            Student student2 = new Student(); 
//            student1.group = "Group1"; 
//            student2.group = "Group2"; 
//            Console.WriteLine(student1.group); // выводит на экран "Group1"
//            Console.Write(student2.group); 
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    class Student
//    {
//        private int year; //объявление закрытого поля  
//        public int Year //объявление свойства  
//            {     
//            get // аксессор чтения поля    
//                {       return year;     }    
//            set // аксессор записи в поле    
//                {       
//                if (value < 1)        
//                    year = 1;     
//                else if (value > 5)      
//                    year = 5;      
//                else year = value;     }   }}
//        class zad2
//    {
//        static void Main(string[] args)
//        {
//            Student st1 = new Student(); 
//            st1.Year = 0; // записываем в поле, используя аксессор set    
//            Console.WriteLine(st1.Year); // читаем поле, используя аксессор get, выведет 1    
//            Console.ReadKey();
//        }
//     }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    class Animal { public string Name { get; set; } public Animal(string name) { Name = name; } }
//    class Dog : Animal
//    {
//        public Dog(string name) : base(name) { }
//        public void Guard()
//        {    // собака охраняет 
//         }}
//         class Cat : Animal{ public Cat(string name) : base(name)  { } 
//        public void CatchMouse() 
//        {     // кошка ловит мышь  
//         }}
//    class zad3
//    {

//        static void Main(string[] args)
//        {
//            Dog dog1 = new Dog("Барбос"); 
//            Console.WriteLine(dog1 is Dog); // true  
//            Console.WriteLine(dog1 is Animal); // true
//            Console.WriteLine(dog1 is Cat); // false  
//             Console.ReadLine();
//        }
//    static void Main(string[] args)
//        //{
//        //    List<Animal> animals = new List<Animal>(); // создаем список указателей на базовый класс    
//        //    animals.Add(new Dog("Барбос")); 
//        //    animals.Add(new Cat("Барсик"));    
//        //    animals.Add(new Dog("Полкан"));   
//        //    foreach (Animal animal in animals)     
//        //    {       Console.WriteLine(animal.Name);     }
//        //    Console.ReadLine();
//        //} 
//        }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age) { Name = name; Age = age; }
        public virtual void ShowInfo() //объявление виртуального метода  
        { Console.WriteLine("Человек\nИмя: " + Name + "\n" + "Возраст: " + Age + "\n"); }
    }
    class Student : Person
    {
        public string HighSchoolName { get; set; }
        public Student(string name, int age, string hsName) : base(name, age) { HighSchoolName = hsName; }
        public override void ShowInfo() // переопределение метода  
        { Console.WriteLine("Студент\nИмя: " + Name + "\n" + "Возраст: " + Age + "\n" + "Название ВУЗа: " + HighSchoolName + "\n"); }
    }
    class Pupil : Person
    {
        public string Form { get; set; }
        public Pupil(string name, int age, string form) : base(name, age) { Form = form; }
        public override void ShowInfo() // переопределение метода
        { Console.WriteLine("Ученик(ца)\nИмя: " + Name + "\n" + "Возраст: " + Age + "\n" + "Класс: " + Form + "\n"); }
    }


    class zad4
    {
        static void Main(string[] args) { List<Person> persons = new List<Person>(); persons.Add(new Person("Василий", 32)); persons.Add(new Student("Андрей", 21, "МГУ")); persons.Add(new Pupil("Елена", 12, "7-Б")); foreach (Person p in persons) p.ShowInfo(); Console.ReadKey(); }
    }
}

