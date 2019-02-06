The universe of the Game of Life is an infinite, two-dimensional orthogonal grid of square cells.

Each cell in one of two possible states - alive or dead.

Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent.

At each step in time, the following transitions occur:

* Any live cell with fewer than two live neighbors dies, as if by underpopulation.
* Any live cell with two or three live neighbors lives on to the next generation.
* Any live cell with more than three live neighbors dies, as if by overpopulation.
* Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

The initial pattern constitutes the seed of the system.

The first generation is created by applying the above rules simultaneously to every cell in the seed.

Births and deaths occur simultaneously.

Each generation is a pure function of the preceding one.

The rules continue to be applied repeatedly to create further generations.


==Examples of patterns==
Many different types of patterns occur in the ''Game of Life'', which are classified according to their behaviour. Common pattern types include: ''[[still life (CA)|still lifes]]'', which do not change from one generation to the next; ''[[oscillator (CA)|oscillators]]'', which return to their initial state after a finite number of generations; and ''[[spaceship (cellular automaton)|spaceships]]'', which translate themselves across the grid.

The earliest interesting patterns in the ''Game of Life'' were discovered without the use of computers. The simplest still lifes and oscillators were discovered while tracking the fates of various small starting configurations using [[graph paper]], [[blackboard]]s, and physical game boards, such as those used in [[Go (board game)|Go]]. During this early research, Conway discovered that the R-[[pentomino]] failed to stabilize in a small number of generations. In fact, it takes 1103 generations to stabilize, by which time it has a population of 116 and has generated six escaping [[Glider (Conway's Life)|gliders]];<ref>{{cite web|url=http://www.conwaylife.com/wiki/index.php?title=R-pentomino|title=R-pentomino|publisher=LifeWiki|accessdate=July 12, 2009}}</ref> these were the first spaceships ever discovered.<ref>{{cite web|url=http://www.argentum.freeserve.co.uk/lex_g.htm#glider|author=Stephen A. Silver|title=Glider|publisher=The Life Lexicon|accessdate=July 12, 2009|deadurl=yes|archiveurl=https://web.archive.org/web/20090418232240/http://www.argentum.freeserve.co.uk/lex_g.htm#glider|archivedate=April 18, 2009|df=}}
</ref>

Frequently occurring<ref>{{cite web|url=http://www.conwaylife.com/soup/census.asp?rule=B3/S23&sl=1&os=1&ss=1|archiveurl=https://web.archive.org/web/20090910010855/http://conwaylife.com/soup/census.asp?rule=B3%2FS23&sl=1&os=1&ss=1|archivedate=2009-09-10|title=Census Results in Conway's Game of Life|publisher=The Online Life-Like CA Soup Search|accessdate=July 12, 2009|deadurl=yes|df=}}
</ref><ref>{{cite web|url=http://wwwhomes.uni-bielefeld.de/achim/moving.html|title=Spontaneous appeared Spaceships out of Random Dust|publisher=Achim Flammenkamp (1995-12-09)|accessdate=July 10, 2012}}</ref> examples (in that they emerge frequently from a random starting configuration of cells) of the three aforementioned pattern types are shown below, with live cells shown in black and dead cells in white. ''Period'' refers to the number of ticks a pattern must iterate through before returning to its initial configuration.

{{col-begin|width=auto; margin:auto}}
{{col-break}}
{| class="wikitable"
|-
! colspan="2" | Still lifes
|-
| Block
| [[File:Game of life block with border.svg]]
|-
| Beehive
| [[File:Game of life beehive.svg]]
|-
| Loaf
| [[File:Game of life loaf.svg]]
|-
| Boat
| [[File:Game of life boat.svg]]
|-
| Tub
| [[File:Game of life flower.svg]]
|}
{{col-break|gap=1em}}
{| class="wikitable"
|-
! colspan="2" | Oscillators
|-
| Blinker (period 2)
| [[File:game of life blinker.gif]]
|-
| Toad (period 2)
| [[File:game of life toad.gif]]
|-
| Beacon (period 2)
| [[File:game of life beacon.gif]]
|-
| Pulsar (period 3)
| [[File:game of life pulsar.gif]]
|-
| Pentadecathlon (period 15)
| [[File:I-Column.gif]]
|}
{{col-break|gap=1em}}
{| class="wikitable"
|-
! colspan="2" | Spaceships
|-
| Glider
| [[File:Game of life animated glider.gif]]
|-
| Lightweight spaceship (LWSS)
| [[File:Game of life animated LWSS.gif]]
|-
| Middleweight spaceship (MWSS)
| [[File:Animated Mwss.gif]]
|-
| Heavyweight spaceship (HWSS)
| [[File:Animated Hwss.gif]]
|}
{{col-end}}

The ''pulsar''<ref>{{cite web|url=http://www.ericweisstein.com/encyclopedias/life/Pulsar.html |title=Pulsar |publisher=Eric Weisstein's Treasure Trove of Life |accessdate=2008-09-16}}
</ref> is the most common period 3 oscillator. The great majority of naturally occurring oscillators are period 2, like the blinker and the toad, but oscillators of many periods are known to exist,<ref>[http://entropymine.com/jason/life/status.html#oscper Game of Life Status page], Jason Summers, retrieved 2012-02-23.</ref> and oscillators of periods 4, 8, 14, 15, 30 and a few others have been seen to arise from random initial conditions.<ref>{{cite web|url=http://wwwhomes.uni-bielefeld.de/achim/freq_top_life.html |title=Most seen natural occurring ash objects in Game of Life |author=Achim Flammenkamp |date=2004-09-07 |accessdate=2008-09-16}}</ref> Patterns which evolve for long periods before stabilizing are called ''[[Methuselah (cellular automata)|Methuselahs]]'', the first-discovered of which was the R-pentomino. ''Diehard'' is a pattern that eventually disappears, rather than stabilizing, after 130 generations, which is conjectured to be maximal for patterns with seven or fewer cells.<ref>
{{cite web|url=http://www.argentum.freeserve.co.uk/lex_d.htm#diehard|title=Diehard|author=Stephen A. Silver|publisher=The Life Lexicon|accessdate=July 12, 2009|deadurl=yes|archiveurl=https://web.archive.org/web/20090719155710/http://www.argentum.freeserve.co.uk/lex_d.htm#diehard|archivedate=July 19, 2009|df=}}</ref> ''Acorn'' takes 5206 generations to generate 633 cells, including 13 escaped gliders.<ref>
{{cite web|url=http://pentadecathlon.com/lifeNews/2005/02/new_methuselah_records.html |title=New Methuselah Records |author=Koenig, H. |date=February 21, 2005 |accessdate=January 24, 2009}}</ref>

{|  style="margin:auto; text-align:center;"
|-
| [[File:Game of life fpento.svg|framed|The R-pentomino]]
| [[File:game of life diehard.svg|framed|Diehard]]
| [[File:game of life acorn.svg|framed|Acorn]]
|}

Conway originally conjectured that no pattern can grow indefinitely—i.e., that for any initial configuration with a finite number of living cells, the population cannot grow beyond some finite upper limit. In the game's original appearance in "Mathematical Games", Conway offered a prize of fifty dollars to the first person who could prove or disprove the conjecture before the end of 1970. The prize was won in November by a team from the [[Massachusetts Institute of Technology]], led by [[Bill Gosper]]; the "Gosper glider gun" produces its first glider on the 15th generation, and another glider every 30th generation from then on. For many years, this glider gun was the smallest one known.<ref>{{cite web|url=http://www.argentum.freeserve.co.uk/lex_g.htm#gosperglidergun|title=Gosper glider gun|author=Stephen A. Silver|publisher=The Life Lexicon|accessdate=July 12, 2009|deadurl=yes|archiveurl=https://web.archive.org/web/20090418232240/http://www.argentum.freeserve.co.uk/lex_g.htm#gosperglidergun|archivedate=April 18, 2009|df=}}</ref> In 2015, a gun called the "Simkin glider gun", which releases a glider every 120th generation, was discovered that has fewer live cells but which is spread out across a larger bounding box at its extremities.<ref>[http://conwaylife.com/forums/viewtopic.php?f=2&t=1599&start=200#p19125 The Hunting of the New Herschel Conduits], ConwayLife forums, April 28th, 2015, posts by Michael Simkin ("simsim314") and Dongook Lee ("Scorbie").</ref>

[[File:Game of life glider gun.svg|framed|center|Gosper glider gun]]

Smaller patterns were later found that also exhibit infinite growth. All three of the patterns shown below grow indefinitely. The first two create a single ''block-laying switch engine'': a configuration that leaves behind two-by-two still life blocks as its translates itself across the game's universe.<ref>
{{cite web|url=http://www.conwaylife.com/wiki/index.php?title=Block-laying_switch_engine|title=Block-laying switch engine|publisher=LifeWiki|accessdate=July 12, 2009}}</ref> The third configuration creates two such patterns. The first has only ten live cells, which has been proven to be minimal.<ref>{{cite web|url=http://www.ericweisstein.com/encyclopedias/life/InfiniteGrowth.html |title=Infinite Growth |publisher=Eric Weisstein's Treasure Trove of Life |accessdate=2008-09-16}}</ref> The second fits in a five-by-five square, and the third is only one cell high.

{|  style="margin:auto; text-align:center;"
|-
| [[File:game of life infinite1.svg]] &nbsp;&nbsp;&nbsp;&nbsp;[[File:game of life infinite2.svg]]
|-
| <br />[[File:game of life infinite3.svg]]
|}
Later discoveries included other ''[[gun (CA)|guns]]'', which are stationary, and which produce gliders or other spaceships; ''[[puffer train (CA)|puffer trains]]'', which move along leaving behind a trail of debris; and ''[[rake (cellular automaton)|rakes]]'', which move and emit spaceships.<ref>{{cite web|url=http://www.argentum.freeserve.co.uk/lex_r.htm#rake|title=Rake|author=Stephen A. Silver|publisher=The Life Lexicon|accessdate=July 12, 2009|deadurl=yes|archiveurl=https://web.archive.org/web/20081221152607/http://www.argentum.freeserve.co.uk/lex_r.htm#rake|archivedate=December 21, 2008|df=}}</ref> Gosper also constructed the first pattern with an [[asymptotically optimal]] [[quadratic growth|quadratic growth rate]], called a ''[[breeder (CA)|breeder]]'' or ''lobster'', which worked by leaving behind a trail of guns.

It is possible for gliders to interact with other objects in interesting ways. For example, if two gliders are shot at a block in a specific position, the block will move closer to the source of the gliders. If three gliders are shot in just the right way, the block will move farther away. This ''sliding block memory'' can be used to simulate a [[Counter (digital)|counter]]. It is possible to construct [[logic gate]]s such as ''[[logical conjunction|AND]]'', ''[[Logical disjunction|OR]]'' and ''[[Negation|NOT]]'' using gliders. It is possible to build a pattern that acts like a [[finite state machine]] connected to two counters. This has the same computational power as a [[universal Turing machine]], so the Game of Life is theoretically as powerful as any computer with unlimited memory and no time constraints; it is [[Turing complete]].<ref name="chapman"/><ref name="bcg"/> In fact, several different programmable computer architectures<ref>{{cite web|url=http://conwaylife.com/forums/viewtopic.php?f=2&t=2561#p37428|title=Programmable computer|publisher=conwaylife.com forums|accessdate=August 23, 2018}}</ref><ref>{{cite web|url=http://rendell-attic.org/gol/tm.htm|title=A Turing Machine in Conway's Game of Life, extendable to a Universal Turing Machine|publisher=Paul Rendell|accessdate=August 23, 2018}}</ref> have been implemented in Conway's Life, including a pattern that simulates Tetris.<ref>{{cite web|url=https://codegolf.stackexchange.com/questions/11880/build-a-working-game-of-tetris-in-conways-game-of-life/142673#142673|title=Build a working game of Tetris in Conway's Game of Life|publisher=StackExchange|accessdate=August 23, 2018}}</ref>

Furthermore, a pattern can contain a collection of guns that fire gliders in such a way as to construct new objects, including copies of the original pattern. A ''universal constructor'' can be built which contains a Turing complete computer, and which can build many types of complex objects, including more copies of itself.<ref name="bcg"/>

On March 6, 2018, the first truly elementary knightship, Sir Robin, was discovered by Adam P. Goucher.<ref>{{cite web|url=http://www.conwaylife.com/forums/viewtopic.php?f=2&t=3303|title=Elementary knightship|access-date=9 March 2018}}</ref> A ''knightship'' is a spaceship that moves two squares left for every one square it moves down, as opposed to normal spaceships which move side to side, or a glider which moves exactly diagonally. This is the first new spaceship movement pattern for an elementary spaceship found in forty-eight years. "Elementary" means that it cannot be decomposed into smaller interacting patterns such as gliders and still lifes.<ref>[http://conwaylife.com/wiki/Elementary "Elementary"], LifeWiki, retrieved 2018-11-21</ref>

