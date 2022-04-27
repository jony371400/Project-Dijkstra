using System;

namespace HelloWorld
{
    class Program
    {
        static public DataHandler? _DataHandler;
        static public string? StartPos;
        static public string? EndPos;

        static void Main(string[] args)
        {
            Console.WriteLine("------------------Procedule Start!------------------");
            Console.WriteLine("");

            _DataHandler = new DataHandler();
            _DataHandler.ReadJsonFile();

            // Input();

            Dijkstra _Dijkstra = new Dijkstra(_DataHandler);

            // if (StartPos != null && EndPos != null)
                _Dijkstra.Algotithm_Start(StartPos, EndPos);

            Console.WriteLine("");
            Console.WriteLine("------------------Procedule End!------------------");
        }

        // static void Input()
        // {
        //     #region Input Para
        //     Console.Write("Input Your Start Pos : ");
        //     StartPos = Console.ReadLine();
        //     // Console.WriteLine("Your Start Pos : " + StartPos);

        //     Console.Write("Input Your End Pos : ");
        //     EndPos = Console.ReadLine();
        //     // Console.WriteLine("Your End Pos : " + EndPos);
        //     #endregion
        // }
    }
}
