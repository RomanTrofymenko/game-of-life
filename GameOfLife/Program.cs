using System;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = GenerateInput();
            var game = new Game();
            while (true)
            {
                Print(field);
                Thread.Sleep(300);
                field = game.Progress(field);
                Console.Clear();
            }
        }

        private static void Print(bool[,] field)
        {
            for (var i = 0; i < field.GetLength(0); i++)
            {
                for (var j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j] ? "@ " : "* ");
                }
                Console.WriteLine();
            }
        }

        private static bool[,] GenerateInput()
        {
            var field = new bool[20, 20];
            for (var i = 0; i < 20; i++)
                for (var j = 0; j < 20; j++)
                {
                    field[i, j] = Convert.ToBoolean(new Random().Next(0, 2));
                }
            return field;
        }
    }
}
