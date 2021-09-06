using System;
using System.Collections.Generic;
using System.Text;

namespace RivenMonch
{
    public static class Search
    {
        public static uint BAD_SEED = 1184201285U;

        public static List<uint> UndoSeed(uint seed, uint start, uint end) {
            ScummRand randomizer = new ScummRand(seed);
            uint calls = 0;
            uint currSeed;
            if (seed > start && seed < end)
                return new List<uint>() {seed, 0};
            do
            {
                currSeed = randomizer.undoSeed();
                calls++;
            } while (!(start < currSeed && currSeed < end));
            return new List<uint>() { seed, calls };
        }

        public static uint? BruteSeed(List<uint> combos, uint seedStart, uint seedEnd) {
            for (uint i = seedStart; i < seedEnd; i++)
            {
                if (i == BAD_SEED)
                {
                    continue;
                }
                ScummRand randomizer = new ScummRand(i);
                if (checkCombos(randomizer.generateFromSeed(), combos))
                {
                    return i;
                }
            }
            //null indicates "fuck if i know"
            return null;
        }

        public static List<List<uint>> CreateComboList(uint start, uint end, uint games)
        {
            List<List<uint>> seedList = new List<List<uint>>();
            for (uint i = start; i < end; i++)
            {
                ScummRand randomizer = new ScummRand(i);
                seedList.Add(randomizer.generateFromSeed(games));
            }
            return seedList;
        }

        public static List<List<uint>> FilterComboList(List<List<uint>> genCombos, List<uint> findCombo) {
            List<List<uint>> filteredList = new List<List<uint>>();
            foreach (List<uint> combo in genCombos) {
                if (checkCombos(combo, findCombo))
                    filteredList.Add(combo);
            }
            return filteredList;
        }

        public static List<ScummRand> CreateRandList(uint start, uint end, uint games)
        {
            List<ScummRand> randList = new List<ScummRand>();
            for (uint i = start; i < end; i++)
            {
                randList.Add(new ScummRand(i));
            }
            return randList;
        }

        public static ScummRand IterateRandList(List<ScummRand> randList, List<uint> findCombos, out List<ScummRand> retList) {
            foreach (ScummRand rand in randList) {
                ScummRand savedRand = rand;
                if (checkCombos(rand.generateFromSeed(), findCombos)) {
                    retList = randList;
                    return savedRand;
                }
            }
            retList = randList;
            return null;
        }

        private static bool checkCombos(List<uint> genCombos, List<uint> findCombos)
        {
            //iterate through all the riven numbers to check
            return checkTenCombo(genCombos[0], findCombos[0]) && checkTenCombo(genCombos[1], findCombos[1]) && checkDomeCombo(genCombos[2], findCombos[2]);
        }

        private static bool checkTenCombo(uint genCombo, uint findCombo)
        {
            //the generated combination will have all digits in place
            //however, the combo to find may have 0s in places
            //thus, they are treated differently
            for (uint i = 0; i < 5; i++)
            {
                //if it's not a 0, check the comparison
                if (findCombo % 10 != 0 && (findCombo % 10 != genCombo % 10))
                    return false;
                //move to the next digit if we're good
                genCombo /= 10;
                findCombo /= 10;
            }
            //if it gets through the barrage, it's a match!
            return true;
        }

        private static bool checkDomeCombo(uint genCombo, uint findCombo)
        {
            for (uint i = 0; i < 5; i++)
            {
                if (findCombo % 100 != 0)
                {
                    //if we find this digit anywhere in the gencombo, it's good
                    //this is in case there's gaps or incorrect directions
                    //dome combo is a combo, not a permo huehuehue
                    uint digit = findCombo % 100;
                    if ((genCombo - digit) % 100 == 0 ||
                       (genCombo / 100 - digit) % 100 == 0 ||
                       (genCombo / 10000 - digit) % 100 == 0 ||
                       (genCombo / 1000000 - digit) % 100 == 0 ||
                       (genCombo / 100000000 - digit) % 100 == 0)
                    {
                        //good :)
                    }
                    else
                    {
                        //bad :(
                        return false;
                    }

                }
                findCombo /= 100;
            }
            return true;
        }
    }
}
