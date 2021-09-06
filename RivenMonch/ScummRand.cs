using System.Collections.Generic;

namespace RivenMonch
{
    public class ScummRand
    {
        #region Members & Properties
        public uint seed { get; set; }
        public uint initseed { get; set; }
        public uint prevSeed { get; set; }
        #endregion Members & Properties

        #region Constructor
        public ScummRand(uint seed)
        {
            this.seed = seed;
            this.initseed = seed;
            this.prevSeed = seed;
        }
        #endregion Constructor

        #region Public Methods
        public uint randomNumber(uint max)
        {
            MixSeed();
            return ((seed) % ((uint)max + 1));
        }

        public uint randomBit()
        {
            MixSeed();
            return seed & 1;
        }

        public uint randomRange(uint min, uint max)
        {
            return randomNumber(max - min) + min;
        }

        public List<uint> generateFromSeed(uint games)
        {
            uint saveSeed = (uint)seed;
            for (uint i = 0; i < games; i++)
                quickGenerate();

            prevSeed = seed;
            List<uint> seedList = generateFromSeed();
            seedList.Add(saveSeed);
            return seedList;
        }

        public List<uint> generateFromSeed()
        {
            prevSeed = seed;
            uint telecombo = 0;
            for (uint i = 0; i < 5; i++)
            {
                telecombo *= 10;
                telecombo += randomRange(1, 5);
            }

            uint prisoncombo = 0;
            for (uint i = 0; i < 5; i++)
            {
                prisoncombo *= 10;
                prisoncombo += randomRange(1, 3);
            }

            uint domecombo = 0;
            uint domeNum = 0;
            List<uint> domeList = new List<uint>();
            for (uint bitsSet = 0; bitsSet < 5;)
            {
                uint rand = randomNumber(24);
                uint randomBit = 1u << ((int)(24 - rand));

                // Don't overwrite a bit we already set, and throw out the bottom five bits being set
                if (domeList.Contains(rand + 1) || (domecombo | randomBit) == 0x1f)
                    continue;

                domecombo |= randomBit;
                bitsSet++;
                domeList.Add((rand + 1));
            }
            domeList.Sort();
            for (int i = 0; i < 5; i++) {
                domeNum *= 100;
                domeNum += domeList[i];
            }

            return new List<uint>() { telecombo, prisoncombo, domeNum };
        }

        public void quickGenerate()
        {
            for (uint i = 0; i < 10; i++)
                MixSeed();

            List<uint> domeList = new List<uint>();
            uint domecombo = 0;
            for (uint bitsSet = 0; bitsSet < 5;)
            {
                uint rand = randomNumber(24);
                uint randomBit = 1u << ((int)(24 - rand));

                // Don't overwrite a bit we already set, and throw out the bottom five bits being set
                if (domeList.Contains(rand+1) || (domecombo | randomBit) == 0x1f)
                    continue;

                domecombo |= randomBit;
                bitsSet++;
                domeList.Add((rand + 1));
            }
        }

        public uint undoSeed() {
            UnmixSeed();
            return seed;
        }

        #endregion Public Methods

        #region Private Methods
        public void MixSeed()
        {
            seed = 0xDEADBF03 * (seed + 1);
            seed = (seed >> 13) | (seed << 19);
            return;
        }

        private void UnmixSeed()
        {
            seed = (seed << 13) | (seed >> 19);
            seed -= 0xDEADBF03;
            seed *= 0x099C23AB;
        }
        #endregion Private Methods
    }
}