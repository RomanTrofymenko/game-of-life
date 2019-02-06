namespace GameOfLife {
    public static class OscillatingStructures {
        public static bool[,] Blinker => new bool[,] {
                {false,false,false,false,false},
                {false,false,false,false,false},
                {false,true,true,true,false},
                {false,false,false,false,false},
                {false,false,false,false,false}
            };
        public static bool[,] Toad => new bool[,] {
                {false,false,false,false,false,false},
                {false,false,false,false,false,false},
                {false,false,true,true,true,false},
                {false,true,true,true,false,false},
                {false,false,false,false,false,false},
                {false,false,false,false,false,false}
            };
        public static bool[,] Beacon => new bool[,] {
                {false,false,false,false,false,false},
                {false,true,true,false,false,false},
                {false,true,false,false,false,false},
                {false,false,false,false,true,false},
                {false,false,false,true,true,false},
                {false,false,false,false,false,false}
            };
        public static bool[,] Pentadecathlon => new bool[,] {
                {false,false,false,false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,true,false,true,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,true,false,true,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,false,true,false,false,false,false,false},
                {false,false,false,false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false,false,false,false},
                {false,false,false,false,false,false,false,false,false,false,false},
            };
    }
} 