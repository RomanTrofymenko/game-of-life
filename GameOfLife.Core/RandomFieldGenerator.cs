using System;

namespace GameOfLife
{
    public class RandomFieldGenerator
    {
        public bool[,] Generate(int size)
        {
            var field = new bool[size, size];
            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                {
                    field[i, j] = GetRandomBoolean();
                }
            return field;
        }

        private static bool GetRandomBoolean() => Convert.ToBoolean(new Random().Next(0, 2));
    }
}