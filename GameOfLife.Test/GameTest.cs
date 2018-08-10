using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Progress_KillsCell_WhenItHasLessThanTwoNeighbors()
        {
            var input = new bool[,]{{true,false},{false,false}};
            var subject = new Game();

            var output = subject.Progress(input);

            Assert.IsFalse(output[0,0]);
        }

        [TestMethod]
        public void Progress_KillsCell_WhenItHasMoreThanThreeNeighbors()
        {
            var input = new bool[,]{{true,true,true},{true,false,true}};
            var subject = new Game();

            var output = subject.Progress(input);

            Assert.IsFalse(output[0,1]);
        }
        
        [TestMethod]
        public void Progress_KeepsCell_WhenItHasTwoNeighbors()
        {
            var input = new bool[,]{{true,true},{true,false}};
            var subject = new Game();

            var output = subject.Progress(input);

            Assert.IsTrue(output[0,0]);
        }
        
        [TestMethod]
        public void Progress_RevivesCell_WhenItHasThreeNeighbors()
        {
            var input = new bool[,]{{true,true},{true,false}};
            var subject = new Game();

            var output = subject.Progress(input);

            Assert.IsTrue(output[1,1]);
        }
    }
}
