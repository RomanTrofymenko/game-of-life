using System;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new RandomFieldGenerator().Generate(40);
            var printer = new FieldPrinter();
            var game = new Game();
            while (true)
            {
                Console.WriteLine(printer.Print(field, "██", "░░"));
                Thread.Sleep(300);
                field = game.Progress(field);
                Console.Clear();
            }
        }
    }
}
