using System;

namespace GameOfLife
{
    public class Game
    {
        public bool[,] Progress(bool[,] initial)
        {
			var result = new bool[initial.GetLength(0), initial.GetLength(1)];

			for(int i = 0; i < initial.GetLength(0); i++)
			{
				for(int j = 0; j < initial.GetLength(1); j++)
				{
					int count = 0;
					var neighborValue = GetValueSafely(initial, i, j);
					if (GetValueSafely(initial, i-1, j-1) == true)
						count++;
					if(GetValueSafely(initial, i-1, j) == true)
						count++;
					if(GetValueSafely(initial, i-1, j + 1) == true)
						count++;
					if (GetValueSafely(initial, i, j-1) == true)
						count++;
					if (GetValueSafely(initial, i, j + 1) == true)
						count++;
					if (GetValueSafely(initial, i + 1, j-1) == true)
						count++;
					if (GetValueSafely(initial, i + 1, j) == true)
						count++;
					if (GetValueSafely(initial, i + 1, j + 1) == true)
						count++;

					if(count >=2 && initial[i,j] == true)
					{
						result[i, j] = true;
					}
				}
			}

			return result;
		}

		private static bool GetValueSafely(bool[,] initial, int i, int j)
		{
			try
			{
				return initial[i, j];
			}
			catch (IndexOutOfRangeException)
			{

				return false;
			}
		}
	}
}