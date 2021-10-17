# OtherStuff
I created this folder for a menagerie of files that are RivenMonch-adjacent, but really won't fit anywhere else.
Shoving it in a random, vaguely-related place seemed like the play.

## Self-Determination
Originally a Google Sheet, this is all the data related to taking the WR Best Ending combos (manually grabbed from videos), then run through RivenMonch to determine original seeds, RNG calls from start, final seed that results in that game, and, if it lines up, the potential game reset count.
It's probable that one of these games has a game count that is innaccurate, as it's possible to get the RNG calls to line up with what game resets would provide, and my suspicions lie on the zaustus 37 game run, but it's left in to reflect that it's indeed on a game boundary.
The Jaffra runs are so elusive in results that I have left the calls and seed blank, although the BF seed is still possible to determine, at least confirming it's highly likely to be a ScummVm game.

There's an entire csv dedicated to all of Jaffra's Best Ending runs, WR or no, to try and pin down the missing slots. After a lot of crying and doing moving windows to see what would be most probable, the two most likely results are thus:
Seed 2006, RNG calls 6.1 million (which, given the RNG call rates of the path area, would be equivalent to leaving the game on for ~14 hours - though I have not looked to see if there's a part of the game where the RNG call rate is much, much higher).
Seed 28312, RNG calls 1144. The call count drastically deviates from the expected graph if you expect the seed and range to be unrelated, so my best guess is either it's unlikely and I've inadvertantly p-hacked my way into a result, or it's accurate and Jaffra opened ScummVM without steam. For the record, Jaffra claims all runs were opened with steam, so I've just thrown up my hands and left em blank.
(it's also possible there's another BF seed that gives the _exact_ same game but i highly doubt it. didn't check it tho)

## cyclesizes
The old ScummVM RNG implementation, which has been replaced with Xorshift* as of 2.3, is highly non-standard and made up as hell. Someone mentioned chi-squared for the constant 0xDEADBF03 in like 2004 but that's about it in terms of striving for a good algorithm. Due to this, the algorithm that's used has a lot of weird ideosyncracies, such as a non-maximum period length, where seeds loop through the range in smaller than expected, but weird period lengths. The motivation was to increase odds of hitting a 12345 dome combo seed by manipulating the starting seed, but it looks like that's not really a thing.

## Inevitability
Instructions on how to get yourself games that are better than average just by resetting a couple (hundred) times. Each line is formatted like so:

SEED: telecombos = (TELE1, TELE2), best game is game   G, with (TELES,PRISN,\[C, O, M, B, O\]) of metric M

TELE1 and TELE2 are the telescope combos for game 1 and game 2 given a clean restart and seed SEED. The way this can be used to uniquely determine your seed, though arduous, is to start a fresh Riven instance from steam, rifle through and test all the TELE1s to get a hit, and then start new game and confirm TELE2 to confirm the seed. One telescope combo is not enough to uniquely determine the seed on the range (500, 2000), but 2 are.

Once you've determined your seed, you are on game 2. Reset however many times until your game count is G, and you will then get a game with TELES, PRISN, and COMBO as the combos, which has optimized the dome combo metric down to M.

The metric is calculated by adding 100 per slider you have to move, and then is added to however many total ticks all the sliders have to move in total. This metric attempts to reduce total movement, but it's relatively easy to modify the code to create a different metric to optimize inevitability further.

inevitability.txt just finds the best metrics for 500 to 2000, up to a total of 200 games.

inevitability2.txt increases the game limit up to 1000, with only providing the results to get metrics of 0 (COMBO = \[1,2,3,4,5\]).

## perfectseeds
All the raw seeds that lead to dome combos of 12345. Shamelessly ripped from Exodust's `result.json`, which also included the prison and telescope combos, and 1184201285 as the seed that freezes Riven
