
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
        
    }
}