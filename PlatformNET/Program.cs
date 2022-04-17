using System;

namespace PlatformNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    class Calc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    public interface IDraw
    {
        void Draw();
    }

    struct Point
    {
        public int xPos, yPos;

        public Point(int x, int y)
        {
            xPos = x; yPos = y;
        }

        public void PrintPosition()
        {
            Console.WriteLine("({0}, {1})", xPos, yPos);
        }
    }

    enum CharacterType
    {
        Wizard = 100,
        Fighter = 200,
        Thief = 300
    }
}


