using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Procedule Start!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Points _Points = new Points();
            _Points.ReadJsonFile();
            _Points.ReadJsonData();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Procedule End!");
        }

        // static void Input()
        // {
        //     #region Input Para
        //     // Console.WriteLine("Input Your Start Pos : ");
        //     // int StartPos = int.Parse(Console.ReadLine());
        //     // Console.WriteLine("Your Start Pos : " + StartPos.ToString());

        //     // Console.WriteLine("Input Your End Pos : ");
        //     // int EndPos = int.Parse(Console.ReadLine());
        //     // Console.WriteLine("Your End Pos : " + EndPos.ToString());
        //     #endregion
        // }
    }
}
