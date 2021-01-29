using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            MyList<int> number = new MyList<int>();
            names.Add("İbrahim");
            names.Add("Ali");
            number.Add(52);
            number.Add(23);

            Console.WriteLine("Hello World!");
        }
    }
}
