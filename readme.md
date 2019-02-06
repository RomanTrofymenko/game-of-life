# Rules
The universe of the Game of Life is an infinite, two-dimensional orthogonal grid of square cells.  
Each cell in one of two possible states - alive or dead.  
Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent.  
At each step in time, the following transitions occur:  
1. Any live cell with fewer than two live neighbors dies, as if by underpopulation.
2. Any live cell with two or three live neighbors lives on to the next generation.
3. Any live cell with more than three live neighbors dies, as if by overpopulation.
4. Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

The initial pattern constitutes the seed of the system.  
The first generation is created by applying the above rules simultaneously to every cell in the seed.  
Births and deaths occur simultaneously.  
Each generation is a pure function of the preceding one.  
The rules continue to be applied repeatedly to create further generations.

# Program
The program has set up entry point, Random Field Generator, Static Structure Generator and a visualization tool.  
The goal of the excercise is to implement the rules of the game in `Game.Progress(bool[,] field)` method that would accept that existing field and return the next generation of the field.  
Tests to the `Progress()` method should be placed in `GameTest` file.

For more information visit [Conway's Game of Life on Wikipedia](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)