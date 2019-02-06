using System;

namespace GameOfLife
{
    public class StaticStructureGenerator
    {
        //....
        //.!!.
        //.!!.
        //....
        public bool[,] Block => new bool[,] { {false, false, false, false}, {false, true, true, false}, {false, true, true, false}, {false, false, false, false} };

        //.....
        //..!..
        //.!.!.
        //..!..
        //.....
        public bool[,] Tube => new bool[,] { {false, false, false, false, false}, {false, false, true, false, false}, {false, true, false, true, false}, {false, false, true, false, false}, {false, false, false, false, false} };

        //.....
        //.!!..
        //.!.!.
        //..!..
        //.....
        public bool[,] Boat => new bool[,] { {false, false, false, false, false}, {false, true, true, false, false}, {false, true, false, true, false}, {false, false, true, false, false}, {false, false, false, false, false} };

        //......
        //..!!..
        //.!..!.
        //..!!..
        //......
        public bool[,] Beehive => new bool[,] { {false, false, false, false, false, false}, {false, false, true, true, false, false}, {false, true, false, false, true, false}, {false, false, true, true, false, false}, {false, false, false, false, false, false} };

        //......
        //..!!..
        //.!..!.
        //..!.!.
        //...!..
        //......
        public bool[,] Loaf => new bool[,] { {false, false, false, false, false, false}, {false, false, true, true, false, false}, {false, true, false, false, true, false}, {false, false, true, false, true, false}, {false, false, false, true, false, false}, {false, false, false, false, false, false} };

    }
}