using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.Test
{
    [TestClass]
    public class GameTest
    {
		[TestMethod]
		public void Progress_KillsCells_WhithLessThanTwoNeighbors()
		{
			var initial = new bool[,] { { true, false }, { false, false } };

			var next = new Game().Progress(initial);

			Assert.IsFalse(next[0, 0]);
		}

		[TestMethod]
		public void Progress_Lives_TwoLiveNeighborsLives()
		{
			var initial = new bool[,] { { true, false }, { true, true } };

			var next = new Game().Progress(initial);

			Assert.IsTrue(next[0, 0]);
			Assert.IsTrue(next[1, 0]);
			Assert.IsTrue(next[1, 1]);
		}

		[TestMethod]
		public void Progress_KeepsDimensions()
		{
			var initial = new bool[3, 4];

			var next = new Game().Progress(initial);

			Assert.AreEqual(3, next.GetLength(0));
			Assert.AreEqual(4, next.GetLength(1));
		}
	}
}
