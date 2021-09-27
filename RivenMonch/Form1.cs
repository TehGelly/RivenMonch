using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RivenMonch

{
    public partial class RivenMonchForm : Form
    {
        public static uint BRUTE_UPDATE = 10000;

        public static List<List<uint>> seedList = new List<List<uint>>();
        public static List<List<uint>> currList = new List<List<uint>>();
        private static bool isSearching = false;

        public static bool finishedChecking = true;

        #region Constructor
        public RivenMonchForm()
        {
            InitializeComponent();
            rnDome.Modulo = 100;
            rnDome.MaxDigit = 25;
            rnPrison.MaxDigit = 3;
            //adding the events directly to the nmups in the rns
            rnDome.nmupVal.ValueChanged += new EventHandler(rn_Update);
            rnPrison.nmupVal.ValueChanged += new EventHandler(rn_Update);
            rnTele.nmupVal.ValueChanged += new EventHandler(rn_Update);
        }
        #endregion Constructor

        #region Private Methods
        private void SetSeed(List<uint> combos)
        {
            nmupSeed.Value = combos[3];
            rnDome.val = combos[2];
            rnPrison.val = combos[1];
            rnTele.val = combos[0];
        }

        private void EnableNonTab(bool enable) {
            //able the common elements
            rnDome.Enabled = enable;
            rnPrison.Enabled = enable;
            rnTele.Enabled = enable;
            nmupSeed.Enabled = enable;
        }

        private void EnableCurrentTab(bool enable) {
            foreach (Control ctr in tabControl1.SelectedTab.Controls)
                ctr.Enabled = enable;
            tabControl1.Enabled = enable;
            //disable the ones that should be disabled all the time
            nmupGameGames.Enabled = false;
            nmupSeedRemaining.Enabled = false;
        }
        #endregion Private Methods

        #region Events
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            //randomize based on seed
            if (nmupSeed.Value == 1184201285)
            {
                btnBasicRandomize.Text = "You bastard.";
                return;
            }
            else if (nmupSeed.Value == 42069)
            {
                pictureBox1.Image = global::RivenMonch.Properties.Resources.gehnKappa4;
            }
            btnBasicRandomize.Text = "Randomize Next Game";
            ScummRand rando = new ScummRand((uint)nmupSeed.Value);
            List<uint> combos = rando.generateFromSeed(0);
            combos[3] = rando.seed;
            SetSeed(combos);
        }

        private void btnBrute_Click(object sender, EventArgs e)
        {
            EnableNonTab(false);
            EnableCurrentTab(false);
            lblBasicFound.Text = "";
            List<uint> findCombos = new List<uint>() { rnTele.val, rnPrison.val, rnDome.val };
            nmupSeed.Value = 0;
            uint i = 0;
            uint? seed;
            for (i = 0; i < uint.MaxValue / BRUTE_UPDATE; i++)
            {
                //run bruteseed on a range of size brute_update
                seed = Search.BruteSeed(findCombos, i * BRUTE_UPDATE, (i + 1) * BRUTE_UPDATE);
                if (seed != null)
                {
                    SetSeed(new ScummRand((uint)seed).generateFromSeed(0));
                    lblBasicFound.Text = "Found! Seed = " + seed.ToString();
                    EnableNonTab(true);
                    EnableCurrentTab(true);
                    return;
                }
                nmupSeed.Value += BRUTE_UPDATE;
                nmupSeed.Refresh();
            }

            //if we're here, this means that the last dregs of the seed contain it
            seed = Search.BruteSeed(findCombos, i, uint.MaxValue);
            if (seed != null)
            {
                nmupSeed.Value = (decimal)seed;
                lblBasicFound.Text = "Found! Seed = " + seed.ToString();
                EnableNonTab(true);
                EnableCurrentTab(true);
                return;
            }

            //or it doesn't exist lmao
            nmupSeed.Value = 0;
            EnableNonTab(true);
            EnableCurrentTab(true);
            return;
        }

        private void btnSeedSearch_Click(object sender, EventArgs e)
        {
            EnableCurrentTab(false);
            seedList.Clear();
            seedList = Search.CreateComboList((uint)nmupSeedStart.Value, (uint)nmupSeedEnd.Value, (uint)nmupSeedGame.Value);
            nmupSeedRemaining.Value = seedList.Count();
            lblSeedFound.Text = "";
            isSearching = true;
        }

        private void rn_Update(object sender, EventArgs e) {
            //if it's not searching for seeds, this is irrelevant
            if (!isSearching)
                return;

            //if it is searching, we filter the list based on the combos
            List<uint> findCombos = new List<uint>() { rnTele.val, rnPrison.val, rnDome.val };

            currList = Search.FilterComboList(seedList, findCombos);
            nmupSeedRemaining.Value = currList.Count();
            if (currList.Count() == 0)
            {
                EnableCurrentTab(true);
                isSearching = false;
            }
            else if (currList.Count() == 1) {
                SetSeed(currList[0]);
                lblSeedFound.Text = "Found! Initial Seed = " + currList[0][3].ToString();
                EnableCurrentTab(true);
                isSearching = false;
            }
        }

        private void rbnGames_CheckedChanged(object sender, EventArgs e)
        {
            lblGameMax.Text = (rbnGames.Checked) ? "Max Games:" : "Max Calls:";
            lblGameGames.Text = (rbnGames.Checked) ? "Games:" : "Calls";
        }

        private void btnGameSearch_Click(object sender, EventArgs e)
        {
            EnableNonTab(false);
            EnableCurrentTab(false);

            List<ScummRand> randList = Search.CreateRandList((uint)nmupGameStart.Value, (uint)nmupGameEnd.Value, 0);
            uint max = (uint)nmupGameMax.Value;
            nmupGameGames.Value = 0;
            List<uint> findCombos = new List<uint>() { rnTele.val, rnPrison.val, rnDome.val };
            if (rbnGames.Checked)
            {
                for (uint i = 0; i < max; i++)
                {
                    ScummRand result = Search.IterateRandList(randList, findCombos, out randList);
                    if (result != null)
                    {
                        result.seed = result.prevSeed;
                        SetSeed(result.generateFromSeed(0));
                        lblGameFound.Text = "Found! Initial Seed = " + result.initseed.ToString();
                        break;
                    }
                    nmupGameGames.Value++;
                    nmupGameGames.Refresh();
                }
            }
            else
            {
                for (uint i = 0; i < max; i++)
                {
                    nmupGameGames.Value = 1; //obo error due to initing prevseed
                    foreach (ScummRand rand in randList)
                    {
                        rand.seed = rand.prevSeed;
                        rand.MixSeed();
                    }

                    ScummRand result = Search.IterateRandList(randList, findCombos, out _);
                    if (result != null)
                    {
                        nmupSeed.Value = result.seed;
                        lblGameFound.Text = "Found! Initial Seed = " + result.initseed.ToString();
                        break;
                    }
                    nmupGameGames.Value++;
                    nmupGameGames.Refresh();
                }
            }

            EnableNonTab(true);
            EnableCurrentTab(true);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ScummRand rand = new ScummRand((uint)nmupSeed.Value);
            uint start = (uint)nmupUndoStart.Value;
            uint end = (uint)nmupUndoEnd.Value;
            uint calls = 0;
            while (!(rand.seed >= start && rand.seed <= end))
            {
                calls++;
                rand.undoSeed();
            }

            lblUndoFound.Text = "Calls = " + calls.ToString();
            nmupSeed.Value = rand.seed;
        }

        #endregion Events


    }
}
