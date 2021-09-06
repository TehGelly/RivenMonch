
namespace RivenMonch
{
    partial class RivenMonchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RivenMonchForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDome = new System.Windows.Forms.Panel();
            this.rnDome = new RivenMonch.RivenNumber();
            this.lblDome = new System.Windows.Forms.Label();
            this.pnlScope = new System.Windows.Forms.Panel();
            this.rnTele = new RivenMonch.RivenNumber();
            this.lblScope = new System.Windows.Forms.Label();
            this.pnlPrison = new System.Windows.Forms.Panel();
            this.rnPrison = new RivenMonch.RivenNumber();
            this.lblPrison = new System.Windows.Forms.Label();
            this.nmupSeed = new System.Windows.Forms.NumericUpDown();
            this.lblSeed = new System.Windows.Forms.Label();
            this.btnBasicRandomize = new System.Windows.Forms.Button();
            this.btnBasicBrute = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbBasic = new System.Windows.Forms.TabPage();
            this.lblBasicFound = new System.Windows.Forms.Label();
            this.tbSeed = new System.Windows.Forms.TabPage();
            this.btnSeedSearch = new System.Windows.Forms.Button();
            this.lblSeedFound = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmupSeedRemaining = new System.Windows.Forms.NumericUpDown();
            this.nmupSeedGame = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmupSeedEnd = new System.Windows.Forms.NumericUpDown();
            this.nmupSeedStart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGame = new System.Windows.Forms.TabPage();
            this.lblGameFound = new System.Windows.Forms.Label();
            this.btnGameSearch = new System.Windows.Forms.Button();
            this.lblGameGames = new System.Windows.Forms.Label();
            this.nmupGameGames = new System.Windows.Forms.NumericUpDown();
            this.nmupGameMax = new System.Windows.Forms.NumericUpDown();
            this.lblGameMax = new System.Windows.Forms.Label();
            this.nmupGameEnd = new System.Windows.Forms.NumericUpDown();
            this.nmupGameStart = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbnCalls = new System.Windows.Forms.RadioButton();
            this.rbnGames = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblUndoFound = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.nmupUndoEnd = new System.Windows.Forms.NumericUpDown();
            this.nmupUndoStart = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDome.SuspendLayout();
            this.pnlScope.SuspendLayout();
            this.pnlPrison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbBasic.SuspendLayout();
            this.tbSeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedStart)).BeginInit();
            this.tbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameStart)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupUndoEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupUndoStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RivenMonch.Properties.Resources.gehnKappa3;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Riven", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(121, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 117);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "RivenMonch";
            // 
            // pnlDome
            // 
            this.pnlDome.Controls.Add(this.rnDome);
            this.pnlDome.Controls.Add(this.lblDome);
            this.pnlDome.Location = new System.Drawing.Point(3, 151);
            this.pnlDome.Name = "pnlDome";
            this.pnlDome.Size = new System.Drawing.Size(375, 92);
            this.pnlDome.TabIndex = 2;
            // 
            // rnDome
            // 
            this.rnDome.Location = new System.Drawing.Point(118, 3);
            this.rnDome.MaxDigit = ((uint)(5u));
            this.rnDome.Modulo = ((uint)(10u));
            this.rnDome.Name = "rnDome";
            this.rnDome.Size = new System.Drawing.Size(257, 83);
            this.rnDome.TabIndex = 10;
            this.rnDome.val = ((uint)(0u));
            // 
            // lblDome
            // 
            this.lblDome.AutoSize = true;
            this.lblDome.Font = new System.Drawing.Font("Riven", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDome.Location = new System.Drawing.Point(3, 23);
            this.lblDome.Name = "lblDome";
            this.lblDome.Size = new System.Drawing.Size(120, 45);
            this.lblDome.TabIndex = 9;
            this.lblDome.Text = "Dome:";
            // 
            // pnlScope
            // 
            this.pnlScope.Controls.Add(this.rnTele);
            this.pnlScope.Controls.Add(this.lblScope);
            this.pnlScope.Location = new System.Drawing.Point(3, 347);
            this.pnlScope.Name = "pnlScope";
            this.pnlScope.Size = new System.Drawing.Size(375, 89);
            this.pnlScope.TabIndex = 3;
            // 
            // rnTele
            // 
            this.rnTele.Location = new System.Drawing.Point(118, 3);
            this.rnTele.MaxDigit = ((uint)(5u));
            this.rnTele.Modulo = ((uint)(10u));
            this.rnTele.Name = "rnTele";
            this.rnTele.Size = new System.Drawing.Size(257, 83);
            this.rnTele.TabIndex = 12;
            this.rnTele.val = ((uint)(0u));
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Font = new System.Drawing.Font("Riven", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScope.Location = new System.Drawing.Point(3, 24);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(96, 45);
            this.lblScope.TabIndex = 11;
            this.lblScope.Text = "Tele:";
            // 
            // pnlPrison
            // 
            this.pnlPrison.Controls.Add(this.rnPrison);
            this.pnlPrison.Controls.Add(this.lblPrison);
            this.pnlPrison.Location = new System.Drawing.Point(3, 249);
            this.pnlPrison.Name = "pnlPrison";
            this.pnlPrison.Size = new System.Drawing.Size(375, 92);
            this.pnlPrison.TabIndex = 3;
            // 
            // rnPrison
            // 
            this.rnPrison.Location = new System.Drawing.Point(118, 3);
            this.rnPrison.MaxDigit = ((uint)(5u));
            this.rnPrison.Modulo = ((uint)(10u));
            this.rnPrison.Name = "rnPrison";
            this.rnPrison.Size = new System.Drawing.Size(257, 83);
            this.rnPrison.TabIndex = 11;
            this.rnPrison.val = ((uint)(0u));
            // 
            // lblPrison
            // 
            this.lblPrison.AutoSize = true;
            this.lblPrison.Font = new System.Drawing.Font("Riven", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrison.Location = new System.Drawing.Point(3, 24);
            this.lblPrison.Name = "lblPrison";
            this.lblPrison.Size = new System.Drawing.Size(124, 45);
            this.lblPrison.TabIndex = 10;
            this.lblPrison.Text = "Prison:";
            // 
            // nmupSeed
            // 
            this.nmupSeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nmupSeed.Location = new System.Drawing.Point(227, 114);
            this.nmupSeed.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupSeed.Name = "nmupSeed";
            this.nmupSeed.Size = new System.Drawing.Size(120, 23);
            this.nmupSeed.TabIndex = 4;
            // 
            // lblSeed
            // 
            this.lblSeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(163, 116);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(35, 15);
            this.lblSeed.TabIndex = 5;
            this.lblSeed.Text = "Seed:";
            // 
            // btnBasicRandomize
            // 
            this.btnBasicRandomize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBasicRandomize.Location = new System.Drawing.Point(56, 74);
            this.btnBasicRandomize.Name = "btnBasicRandomize";
            this.btnBasicRandomize.Size = new System.Drawing.Size(155, 23);
            this.btnBasicRandomize.TabIndex = 6;
            this.btnBasicRandomize.Text = "Randomize Next Game";
            this.btnBasicRandomize.UseVisualStyleBackColor = true;
            this.btnBasicRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnBasicBrute
            // 
            this.btnBasicBrute.Location = new System.Drawing.Point(56, 167);
            this.btnBasicBrute.Name = "btnBasicBrute";
            this.btnBasicBrute.Size = new System.Drawing.Size(155, 23);
            this.btnBasicBrute.TabIndex = 11;
            this.btnBasicBrute.Text = "Brute Force Solution";
            this.btnBasicBrute.UseVisualStyleBackColor = true;
            this.btnBasicBrute.Click += new System.EventHandler(this.btnBrute_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbBasic);
            this.tabControl1.Controls.Add(this.tbSeed);
            this.tabControl1.Controls.Add(this.tbGame);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(434, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(276, 287);
            this.tabControl1.TabIndex = 16;
            // 
            // tbBasic
            // 
            this.tbBasic.Controls.Add(this.lblBasicFound);
            this.tbBasic.Controls.Add(this.btnBasicRandomize);
            this.tbBasic.Controls.Add(this.btnBasicBrute);
            this.tbBasic.Location = new System.Drawing.Point(4, 24);
            this.tbBasic.Name = "tbBasic";
            this.tbBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tbBasic.Size = new System.Drawing.Size(268, 259);
            this.tbBasic.TabIndex = 0;
            this.tbBasic.Text = "Basic";
            this.tbBasic.UseVisualStyleBackColor = true;
            // 
            // lblBasicFound
            // 
            this.lblBasicFound.AutoSize = true;
            this.lblBasicFound.Location = new System.Drawing.Point(56, 193);
            this.lblBasicFound.Name = "lblBasicFound";
            this.lblBasicFound.Size = new System.Drawing.Size(0, 15);
            this.lblBasicFound.TabIndex = 12;
            // 
            // tbSeed
            // 
            this.tbSeed.Controls.Add(this.btnSeedSearch);
            this.tbSeed.Controls.Add(this.lblSeedFound);
            this.tbSeed.Controls.Add(this.label4);
            this.tbSeed.Controls.Add(this.nmupSeedRemaining);
            this.tbSeed.Controls.Add(this.nmupSeedGame);
            this.tbSeed.Controls.Add(this.label3);
            this.tbSeed.Controls.Add(this.nmupSeedEnd);
            this.tbSeed.Controls.Add(this.nmupSeedStart);
            this.tbSeed.Controls.Add(this.label2);
            this.tbSeed.Controls.Add(this.label1);
            this.tbSeed.Location = new System.Drawing.Point(4, 24);
            this.tbSeed.Name = "tbSeed";
            this.tbSeed.Padding = new System.Windows.Forms.Padding(3);
            this.tbSeed.Size = new System.Drawing.Size(268, 259);
            this.tbSeed.TabIndex = 1;
            this.tbSeed.Text = "Seed Search";
            this.tbSeed.UseVisualStyleBackColor = true;
            // 
            // btnSeedSearch
            // 
            this.btnSeedSearch.Location = new System.Drawing.Point(64, 175);
            this.btnSeedSearch.Name = "btnSeedSearch";
            this.btnSeedSearch.Size = new System.Drawing.Size(122, 23);
            this.btnSeedSearch.TabIndex = 25;
            this.btnSeedSearch.Text = "Search!";
            this.btnSeedSearch.UseVisualStyleBackColor = true;
            this.btnSeedSearch.Click += new System.EventHandler(this.btnSeedSearch_Click);
            // 
            // lblSeedFound
            // 
            this.lblSeedFound.AutoSize = true;
            this.lblSeedFound.Location = new System.Drawing.Point(6, 216);
            this.lblSeedFound.Name = "lblSeedFound";
            this.lblSeedFound.Size = new System.Drawing.Size(0, 15);
            this.lblSeedFound.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Seeds Remaining:";
            // 
            // nmupSeedRemaining
            // 
            this.nmupSeedRemaining.Enabled = false;
            this.nmupSeedRemaining.Location = new System.Drawing.Point(145, 116);
            this.nmupSeedRemaining.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupSeedRemaining.Name = "nmupSeedRemaining";
            this.nmupSeedRemaining.Size = new System.Drawing.Size(109, 23);
            this.nmupSeedRemaining.TabIndex = 22;
            // 
            // nmupSeedGame
            // 
            this.nmupSeedGame.Location = new System.Drawing.Point(6, 116);
            this.nmupSeedGame.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmupSeedGame.Name = "nmupSeedGame";
            this.nmupSeedGame.Size = new System.Drawing.Size(109, 23);
            this.nmupSeedGame.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Game Count:";
            // 
            // nmupSeedEnd
            // 
            this.nmupSeedEnd.Location = new System.Drawing.Point(145, 48);
            this.nmupSeedEnd.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupSeedEnd.Name = "nmupSeedEnd";
            this.nmupSeedEnd.Size = new System.Drawing.Size(109, 23);
            this.nmupSeedEnd.TabIndex = 19;
            this.nmupSeedEnd.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nmupSeedStart
            // 
            this.nmupSeedStart.Location = new System.Drawing.Point(6, 48);
            this.nmupSeedStart.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupSeedStart.Name = "nmupSeedStart";
            this.nmupSeedStart.Size = new System.Drawing.Size(109, 23);
            this.nmupSeedStart.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Seed Range:";
            // 
            // tbGame
            // 
            this.tbGame.Controls.Add(this.lblGameFound);
            this.tbGame.Controls.Add(this.btnGameSearch);
            this.tbGame.Controls.Add(this.lblGameGames);
            this.tbGame.Controls.Add(this.nmupGameGames);
            this.tbGame.Controls.Add(this.nmupGameMax);
            this.tbGame.Controls.Add(this.lblGameMax);
            this.tbGame.Controls.Add(this.nmupGameEnd);
            this.tbGame.Controls.Add(this.nmupGameStart);
            this.tbGame.Controls.Add(this.label5);
            this.tbGame.Controls.Add(this.label6);
            this.tbGame.Controls.Add(this.rbnCalls);
            this.tbGame.Controls.Add(this.rbnGames);
            this.tbGame.Location = new System.Drawing.Point(4, 24);
            this.tbGame.Name = "tbGame";
            this.tbGame.Padding = new System.Windows.Forms.Padding(3);
            this.tbGame.Size = new System.Drawing.Size(268, 259);
            this.tbGame.TabIndex = 2;
            this.tbGame.Text = "Game Search";
            this.tbGame.UseVisualStyleBackColor = true;
            // 
            // lblGameFound
            // 
            this.lblGameFound.AutoSize = true;
            this.lblGameFound.Location = new System.Drawing.Point(64, 205);
            this.lblGameFound.Name = "lblGameFound";
            this.lblGameFound.Size = new System.Drawing.Size(0, 15);
            this.lblGameFound.TabIndex = 29;
            // 
            // btnGameSearch
            // 
            this.btnGameSearch.Location = new System.Drawing.Point(64, 175);
            this.btnGameSearch.Name = "btnGameSearch";
            this.btnGameSearch.Size = new System.Drawing.Size(122, 23);
            this.btnGameSearch.TabIndex = 28;
            this.btnGameSearch.Text = "Search!";
            this.btnGameSearch.UseVisualStyleBackColor = true;
            this.btnGameSearch.Click += new System.EventHandler(this.btnGameSearch_Click);
            // 
            // lblGameGames
            // 
            this.lblGameGames.AutoSize = true;
            this.lblGameGames.Location = new System.Drawing.Point(145, 98);
            this.lblGameGames.Name = "lblGameGames";
            this.lblGameGames.Size = new System.Drawing.Size(46, 15);
            this.lblGameGames.TabIndex = 27;
            this.lblGameGames.Text = "Games:";
            // 
            // nmupGameGames
            // 
            this.nmupGameGames.Enabled = false;
            this.nmupGameGames.Location = new System.Drawing.Point(145, 116);
            this.nmupGameGames.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupGameGames.Name = "nmupGameGames";
            this.nmupGameGames.Size = new System.Drawing.Size(109, 23);
            this.nmupGameGames.TabIndex = 26;
            // 
            // nmupGameMax
            // 
            this.nmupGameMax.Location = new System.Drawing.Point(6, 116);
            this.nmupGameMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmupGameMax.Name = "nmupGameMax";
            this.nmupGameMax.Size = new System.Drawing.Size(109, 23);
            this.nmupGameMax.TabIndex = 25;
            this.nmupGameMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblGameMax
            // 
            this.lblGameMax.AutoSize = true;
            this.lblGameMax.Location = new System.Drawing.Point(6, 98);
            this.lblGameMax.Name = "lblGameMax";
            this.lblGameMax.Size = new System.Drawing.Size(72, 15);
            this.lblGameMax.TabIndex = 24;
            this.lblGameMax.Text = "Max Games:";
            // 
            // nmupGameEnd
            // 
            this.nmupGameEnd.Location = new System.Drawing.Point(145, 48);
            this.nmupGameEnd.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupGameEnd.Name = "nmupGameEnd";
            this.nmupGameEnd.Size = new System.Drawing.Size(109, 23);
            this.nmupGameEnd.TabIndex = 23;
            this.nmupGameEnd.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nmupGameStart
            // 
            this.nmupGameStart.Location = new System.Drawing.Point(6, 48);
            this.nmupGameStart.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupGameStart.Name = "nmupGameStart";
            this.nmupGameStart.Size = new System.Drawing.Size(109, 23);
            this.nmupGameStart.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Starting Seed Range:";
            // 
            // rbnCalls
            // 
            this.rbnCalls.AutoSize = true;
            this.rbnCalls.Location = new System.Drawing.Point(145, 145);
            this.rbnCalls.Name = "rbnCalls";
            this.rbnCalls.Size = new System.Drawing.Size(77, 19);
            this.rbnCalls.TabIndex = 1;
            this.rbnCalls.Text = "RNG Calls";
            this.rbnCalls.UseVisualStyleBackColor = true;
            // 
            // rbnGames
            // 
            this.rbnGames.AutoSize = true;
            this.rbnGames.Checked = true;
            this.rbnGames.Location = new System.Drawing.Point(6, 145);
            this.rbnGames.Name = "rbnGames";
            this.rbnGames.Size = new System.Drawing.Size(61, 19);
            this.rbnGames.TabIndex = 0;
            this.rbnGames.TabStop = true;
            this.rbnGames.Text = "Games";
            this.rbnGames.UseVisualStyleBackColor = true;
            this.rbnGames.CheckedChanged += new System.EventHandler(this.rbnGames_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblUndoFound);
            this.tabPage1.Controls.Add(this.btnUndo);
            this.tabPage1.Controls.Add(this.nmupUndoEnd);
            this.tabPage1.Controls.Add(this.nmupUndoStart);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 259);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Undo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblUndoFound
            // 
            this.lblUndoFound.AutoSize = true;
            this.lblUndoFound.Location = new System.Drawing.Point(60, 201);
            this.lblUndoFound.Name = "lblUndoFound";
            this.lblUndoFound.Size = new System.Drawing.Size(0, 15);
            this.lblUndoFound.TabIndex = 29;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(60, 175);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(139, 23);
            this.btnUndo.TabIndex = 28;
            this.btnUndo.Text = "Undo Seed to Range";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // nmupUndoEnd
            // 
            this.nmupUndoEnd.Location = new System.Drawing.Point(145, 48);
            this.nmupUndoEnd.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupUndoEnd.Name = "nmupUndoEnd";
            this.nmupUndoEnd.Size = new System.Drawing.Size(109, 23);
            this.nmupUndoEnd.TabIndex = 27;
            this.nmupUndoEnd.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nmupUndoStart
            // 
            this.nmupUndoStart.Location = new System.Drawing.Point(6, 48);
            this.nmupUndoStart.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nmupUndoStart.Name = "nmupUndoStart";
            this.nmupUndoStart.Size = new System.Drawing.Size(109, 23);
            this.nmupUndoStart.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Starting Seed Range:";
            // 
            // RivenMonchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.nmupSeed);
            this.Controls.Add(this.pnlPrison);
            this.Controls.Add(this.pnlScope);
            this.Controls.Add(this.pnlDome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RivenMonchForm";
            this.Text = "RivenMonch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDome.ResumeLayout(false);
            this.pnlDome.PerformLayout();
            this.pnlScope.ResumeLayout(false);
            this.pnlScope.PerformLayout();
            this.pnlPrison.ResumeLayout(false);
            this.pnlPrison.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbBasic.ResumeLayout(false);
            this.tbBasic.PerformLayout();
            this.tbSeed.ResumeLayout(false);
            this.tbSeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupSeedStart)).EndInit();
            this.tbGame.ResumeLayout(false);
            this.tbGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupGameStart)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmupUndoEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmupUndoStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDome;
        private System.Windows.Forms.Panel pnlScope;
        private System.Windows.Forms.Panel pnlPrison;
        private System.Windows.Forms.NumericUpDown nmupSeed;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Button btnBasicRandomize;
        private System.Windows.Forms.Label lblDome;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.Label lblPrison;
        private System.Windows.Forms.Button btnBasicBrute;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbBasic;
        private System.Windows.Forms.TabPage tbSeed;
        private System.Windows.Forms.TabPage tbGame;
        private RivenNumber rnDome;
        private RivenNumber rnTele;
        private RivenNumber rnPrison;
        private System.Windows.Forms.Button btnSeedSearch;
        private System.Windows.Forms.Label lblSeedFound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmupSeedRemaining;
        private System.Windows.Forms.NumericUpDown nmupSeedGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmupSeedEnd;
        private System.Windows.Forms.NumericUpDown nmupSeedStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBasicFound;
        private System.Windows.Forms.RadioButton rbnCalls;
        private System.Windows.Forms.RadioButton rbnGames;
        private System.Windows.Forms.Label lblGameGames;
        private System.Windows.Forms.NumericUpDown nmupGameGames;
        private System.Windows.Forms.NumericUpDown nmupGameMax;
        private System.Windows.Forms.Label lblGameMax;
        private System.Windows.Forms.NumericUpDown nmupGameEnd;
        private System.Windows.Forms.NumericUpDown nmupGameStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGameSearch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.NumericUpDown nmupUndoEnd;
        private System.Windows.Forms.NumericUpDown nmupUndoStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGameFound;
        private System.Windows.Forms.Label lblUndoFound;
    }
}

