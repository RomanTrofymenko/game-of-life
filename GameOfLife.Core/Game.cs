using System;

namespace GameOfLife
{
    public class Game
    {
        public bool[,] Progress(bool[,] initial)
        {
            var result = new bool[initial.GetLength(0),initial.GetLength(1)];
            for(var cellX = 0; cellX < initial.GetLength(0); cellX++)
                for(var cellY = 0; cellY < initial.GetLength(1); cellY++)
                {
                    var neighborsAlive = GetNeighborsAlive(cellX, cellY, initial);
                    result[cellX,cellY] = neighborsAlive == 3 || (neighborsAlive == 2 && initial[cellX, cellY]);
                }
            return result;
        }

        private int GetNeighborsAlive(int cellX, int cellY, bool[,] initial)
        {
            var result = 0;
            for(var neighborX = cellX-1; neighborX < cellX+2; neighborX++)
                for(var neighborY = cellY-1; neighborY < cellY+2; neighborY++)
                {
                    if(IsInBounds(neighborX, neighborY, initial)
                    && IsNeighbor(neighborX, neighborY, cellX, cellY)
                    && initial[neighborX, neighborY])
                        result++;
                }
            return result;
        }

        private bool IsNeighbor(int neighborX, int neighborY, int cellX, int cellY)
        {
            var result = neighborX != cellX || neighborY != cellY;
            return result;
        }

        private bool IsInBounds(int neighborX, int neighborY, bool[,] initial)
        {
            var width = initial.GetLength(0);
            var height = initial.GetLength(1);
            var yInBounds = neighborY >= 0 && neighborY < height;
            bool xInBounds = neighborX >= 0 && neighborX < width;
            var result = xInBounds && yInBounds;
            return result;
        }
    }
}