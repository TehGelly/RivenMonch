using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RivenMonch
{
    public partial class RivenNumber : UserControl
    {
        public static Size RESIZE = new Size(45, 35);
        public static System.Resources.ResourceSet resources = Properties.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);
        public List<PictureBox> pbxList;

        public uint val
        {
            get { return (uint)nmupVal.Value; }
            set { nmupVal.Value = value; }
        }

        private uint maxDigit;
        public uint MaxDigit {
            get { return maxDigit; }
            set {
                maxDigit = value;
                //(modulo^5 -1)/(modulo - 1) overflows uint for modulo = 100
                //instead we opt for 1+10+100+1000+10000
                // i hope ye enjoy ;)
                nmupVal.Maximum = maxDigit * (1 + mod + mod * mod + mod * mod * mod + mod * mod * mod * mod); }
        }

        private uint mod;
        public uint Modulo {
            get { return mod; }
            set {
                mod = value;
                nmupVal.Maximum = maxDigit * (1 + mod + mod * mod + mod * mod * mod + mod * mod * mod * mod);
            }
        }

        public RivenNumber()
        {
            InitializeComponent();
            MaxDigit = 5;
            Modulo = 10;
            pbxList = new List<PictureBox>() { this.pbx1, this.pbx2, this.pbx3, this.pbx4, this.pbx5 };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            uint runningPlace = 1;
            for (int i = 0; i < 5; i++) {
                //cap off digits that are too big
                uint digit = (val / runningPlace) % Modulo;
                if (digit > MaxDigit) {
                    val -= digit * runningPlace;
                    val += MaxDigit * runningPlace;
                    digit = MaxDigit;
                }
                setDigit(pbxList[4-i], digit);
                runningPlace *= Modulo;
            }
        }

        private void setDigit(PictureBox pbx, uint digit)
        {
            if (digit == 0)
            {
                pbx.Image = null;
                return;
            }

            foreach (DictionaryEntry entry in resources)
            {
                if ((string)entry.Key == "riven" + digit)
                {
                    pbx.Image = new Bitmap((Image)entry.Value, RESIZE);
                    return;
                }
            }
        }
    }
}
