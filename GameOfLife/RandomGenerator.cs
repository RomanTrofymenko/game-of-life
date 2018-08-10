using System;

namespace GameOfLife
{
    public class Generator
    {
        public bool[,] GenerateField(int size)
        {
            var field = new bool[size, size];
            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                {
                    field[i, j] = Convert.ToBoolean(new Random().Next(0, 2));
                }
            return field;
        }
    }
}