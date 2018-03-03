using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(5);

            s.Push(10);
            s.Push(29);

            System.Console.WriteLine(s.Pop());
            System.Console.WriteLine(s.Pop());
            s.Pop();
        }
    }
}
