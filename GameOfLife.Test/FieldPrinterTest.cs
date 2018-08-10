
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.Test
{
    [TestClass]
    public class FieldPrinterTest
    {

        [TestMethod]
        public void Print_ReturnsDeadCellSymbols_WhenDeadCellsPresent()
        {
            var subject = new FieldPrinter();

            var result = subject.Print(new bool[,]{{false}}, "!", ".");

            StringAssert.Contains(result, ".");
        }

        [TestMethod]
        public void Print_ReturnsLiveCellSymbols_WhenLiveCellsPresent()
        {
            var subject = new FieldPrinter();

            var result = subject.Print(new bool[,]{{true}}, "!", ".");

            StringAssert.Contains(result, "!");
        }
    }
}