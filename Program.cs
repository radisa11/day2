using System;


namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Lion" , 4 ,250.5 ,true , "yellow");
            // Console.WriteLine(a.species);
            a.ShowStats();
            Animal b = new Animal("House cat",4,8.4,true,"white");
            b.ShowStats();
            System.Console.WriteLine(b.Weight);
            b.feed();
            Console.WriteLine(b.Weight);
        }
    }
}