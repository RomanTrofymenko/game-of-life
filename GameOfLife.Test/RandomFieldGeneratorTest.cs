
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.Test
{
    [TestClass]
    public class RandomGeneratorTest
    {

        [TestMethod]
        public void Generate_ReturnsFieldWithGivenWidth()
        {
            var subject = new RandomFieldGenerator();

            var result = subject.Generate(3);

            Assert.AreEqual(3, result.GetLength(0));
        }

        [TestMethod]
        public void Generate_ReturnsFieldWithGivenHeight()
        {
            var subject = new RandomFieldGenerator();

            var result = subject.Generate(3);

            Assert.AreEqual(3, result.GetLength(1));
        }
    }
}