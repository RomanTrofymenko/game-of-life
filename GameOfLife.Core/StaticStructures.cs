using System;

namespace GameOfLife
{
    public static class StaticStructures
    {
        public static bool[,] Block => new bool[,] {
            {false, false, false, false},
            {false, true, true, false},
            {false, true, true, false},
            {false, false, false, false}
        };

        public static bool[,] Tube => new bool[,] {
            {false, false, false, false, false},
            {false, false, true, false, false},
            {false, true, false, true, false},
            {false, false, true, false, false},
            {false, false, false, false, false}
        };

        public static bool[,] Boat => new bool[,] {
            {false, false, false, false, false},
            {false, true, true, false, false},
            {false, true, false, true, false},
            {false, false, true, false, false},
            {false, false, false, false, false}
        };

        public static bool[,] LongBoat => new bool[,] {
            {false, false, false, false, false},
            {false, true, true, false, false},
            {false, true, false, true, false},
            {false, false, true, true, false},
            {false, false, false, false, false}
        };

        public static bool[,] Beehive => new bool[,] {
            {false, false, false, false, false, false},
            {false, false, true, true, false, false},
            {false, true, false, false, true, false},
            {false, false, true, true, false, false},
            {false, false, false, false, false, false}
        };

        public static bool[,] Loaf => new bool[,] {
            {false, false, false, false, false, false},
            {false, false, true, true, false, false},
            {false, true, false, false, true, false},
            {false, false, true, false, true, false},
            {false, false, false, true, false, false},
            {false, false, false, false, false, false}
        };

    }
}