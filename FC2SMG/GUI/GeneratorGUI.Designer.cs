
namespace ServerModGenerator
{
    partial class GeneratorGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorGUI));
            pWeaponPanels = new Panel();
            comboxFilterWeaponSecondaryAll = new ComboBox();
            lSingleWeaponSecondary = new Label();
            comboxFilterWeaponPrimaryAll = new ComboBox();
            lSingleWeapons = new Label();
            lSingleWeaponPrimary = new Label();
            lWeaponLoadOut = new Label();
            bDisable = new Glass.GlassButton();
            bDefault = new Glass.GlassButton();
            bGeneratePatch = new Glass.GlassButton();
            lInputFile = new Label();
            tbPathPatchFile = new TextBox();
            bPathPatch = new Glass.GlassButton();
            lOutPutFolderName = new Label();
            tbOutputName = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pLoadOutControls = new Panel();
            comboxFilterWeaponSecondary2 = new ComboBox();
            lSingleSecondary2 = new Label();
            comboxFilterWeaponSecondary1 = new ComboBox();
            lSingleSecondary1 = new Label();
            comboxFilterWeaponPrimary3 = new ComboBox();
            lSinglePrimary3 = new Label();
            comboxFilterWeaponPrimary2 = new ComboBox();
            lSinglePrimary2 = new Label();
            comboxFilterWeaponPrimary1 = new ComboBox();
            lSinglePrimary1 = new Label();
            tabPage2 = new TabPage();
            pScoreCollections = new Panel();
            bAddDefaultScoresTDM = new Glass.GlassButton();
            lScoresTDM = new Label();
            comboxDefaultScoreTDM = new ComboBox();
            tbScoresTDM = new TextBox();
            lScoresUPR = new Label();
            comboxDefaultScoreUPR = new ComboBox();
            tbScoresUPR = new TextBox();
            bAddDefaultScoresDM = new Glass.GlassButton();
            lScoresDM = new Label();
            comboxDefaultScoreDM = new ComboBox();
            tbScoresDM = new TextBox();
            bAddDefaultScoresCTD = new Glass.GlassButton();
            lScoresCTD = new Label();
            comboxDefaultScoreCTD = new ComboBox();
            tbScoresCTD = new TextBox();
            lScores = new Label();
            pWaitTimes = new Panel();
            comboxDefaultPreRoundTime = new ComboBox();
            comboxDefaultPostRoundTime = new ComboBox();
            tbPostRoundTimes = new TextBox();
            lPostRoundTimes = new Label();
            tbPreRoundTimes = new TextBox();
            lPreRound = new Label();
            comboxDefaultZoneDeathTime = new ComboBox();
            tbZoneDeathTimes = new TextBox();
            lZones = new Label();
            comboxDefaultDaytimeSpeed = new ComboBox();
            comboxDefaultRespawnTime = new ComboBox();
            comboxDefaultSpawnShield = new ComboBox();
            tbSpawnShields = new TextBox();
            lShields = new Label();
            tbRespawnTimes = new TextBox();
            lRespawnTimes = new Label();
            bGenerateDayTimeNames = new Glass.GlassButton();
            bDayTimeAddAll = new Glass.GlassButton();
            tbDayTimeNames = new TextBox();
            lDayTimeNames = new Label();
            tbDayTimeValues = new TextBox();
            lDayTime = new Label();
            lCollectionInfo = new Label();
            tbDaytimeSpeed = new TextBox();
            lDayTimeSpeed = new Label();
            tabPage3 = new TabPage();
            tbDebugOutPut = new TextBox();
            bSettings = new Glass.GlassButton();
            pbOpenGenerationFolder = new PictureBox();
            lModCollection = new Label();
            bLoadReport = new Glass.GlassButton();
            bInstall = new Glass.GlassButton();
            comboxModCollection = new ComboBox();
            lCredits = new Label();
            lDiscordLink = new LinkLabel();
            pbOpenGameBinFolder = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pLoadOutControls.SuspendLayout();
            tabPage2.SuspendLayout();
            pScoreCollections.SuspendLayout();
            pWaitTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOpenGenerationFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOpenGameBinFolder).BeginInit();
            SuspendLayout();
            // 
            // pWeaponPanels
            // 
            pWeaponPanels.Location = new Point(0, 88);
            pWeaponPanels.Margin = new Padding(4, 3, 4, 3);
            pWeaponPanels.Name = "pWeaponPanels";
            pWeaponPanels.Size = new Size(928, 245);
            pWeaponPanels.TabIndex = 25;
            // 
            // comboxFilterWeaponSecondaryAll
            // 
            comboxFilterWeaponSecondaryAll.BackColor = Color.Black;
            comboxFilterWeaponSecondaryAll.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxFilterWeaponSecondaryAll.ForeColor = Color.Gold;
            comboxFilterWeaponSecondaryAll.FormattingEnabled = true;
            comboxFilterWeaponSecondaryAll.Items.AddRange(new object[] { "-----------------------------" });
            comboxFilterWeaponSecondaryAll.Location = new Point(170, 56);
            comboxFilterWeaponSecondaryAll.Margin = new Padding(4, 3, 4, 3);
            comboxFilterWeaponSecondaryAll.Name = "comboxFilterWeaponSecondaryAll";
            comboxFilterWeaponSecondaryAll.Size = new Size(142, 21);
            comboxFilterWeaponSecondaryAll.TabIndex = 23;
            comboxFilterWeaponSecondaryAll.SelectedIndexChanged += comboxFilterWeaponSecondaryAll_SelectedIndexChanged;
            comboxFilterWeaponSecondaryAll.Click += CacheCurrentIndex;
            // 
            // lSingleWeaponSecondary
            // 
            lSingleWeaponSecondary.AutoSize = true;
            lSingleWeaponSecondary.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lSingleWeaponSecondary.ForeColor = Color.DarkOrange;
            lSingleWeaponSecondary.Location = new Point(98, 57);
            lSingleWeaponSecondary.Margin = new Padding(4, 0, 4, 0);
            lSingleWeaponSecondary.Name = "lSingleWeaponSecondary";
            lSingleWeaponSecondary.Size = new Size(70, 17);
            lSingleWeaponSecondary.TabIndex = 8;
            lSingleWeaponSecondary.Text = "Secondary";
            // 
            // comboxFilterWeaponPrimaryAll
            // 
            comboxFilterWeaponPrimaryAll.BackColor = Color.Black;
            comboxFilterWeaponPrimaryAll.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxFilterWeaponPrimaryAll.ForeColor = Color.Gold;
            comboxFilterWeaponPrimaryAll.FormattingEnabled = true;
            comboxFilterWeaponPrimaryAll.Items.AddRange(new object[] { "-----------------------------" });
            comboxFilterWeaponPrimaryAll.Location = new Point(170, 28);
            comboxFilterWeaponPrimaryAll.Margin = new Padding(4, 3, 4, 3);
            comboxFilterWeaponPrimaryAll.Name = "comboxFilterWeaponPrimaryAll";
            comboxFilterWeaponPrimaryAll.Size = new Size(142, 21);
            comboxFilterWeaponPrimaryAll.TabIndex = 20;
            comboxFilterWeaponPrimaryAll.SelectedIndexChanged += comboxFilterWeaponPrimaryAll_SelectedIndexChanged;
            comboxFilterWeaponPrimaryAll.Click += CacheCurrentIndex;
            // 
            // lSingleWeapons
            // 
            lSingleWeapons.AutoSize = true;
            lSingleWeapons.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lSingleWeapons.ForeColor = Color.Gold;
            lSingleWeapons.Location = new Point(97, 0);
            lSingleWeapons.Margin = new Padding(4, 0, 4, 0);
            lSingleWeapons.Name = "lSingleWeapons";
            lSingleWeapons.Size = new Size(165, 21);
            lSingleWeapons.TabIndex = 8;
            lSingleWeapons.Text = "Single Weapon only";
            // 
            // lSingleWeaponPrimary
            // 
            lSingleWeaponPrimary.AutoSize = true;
            lSingleWeaponPrimary.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lSingleWeaponPrimary.ForeColor = Color.DarkOrange;
            lSingleWeaponPrimary.Location = new Point(98, 29);
            lSingleWeaponPrimary.Margin = new Padding(4, 0, 4, 0);
            lSingleWeaponPrimary.Name = "lSingleWeaponPrimary";
            lSingleWeaponPrimary.Size = new Size(52, 17);
            lSingleWeaponPrimary.TabIndex = 8;
            lSingleWeaponPrimary.Text = "Primary";
            // 
            // lWeaponLoadOut
            // 
            lWeaponLoadOut.AutoSize = true;
            lWeaponLoadOut.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lWeaponLoadOut.ForeColor = Color.Gold;
            lWeaponLoadOut.Location = new Point(3, 0);
            lWeaponLoadOut.Margin = new Padding(4, 0, 4, 0);
            lWeaponLoadOut.Name = "lWeaponLoadOut";
            lWeaponLoadOut.Size = new Size(86, 21);
            lWeaponLoadOut.TabIndex = 8;
            lWeaponLoadOut.Text = "LOADOUT";
            // 
            // bDisable
            // 
            bDisable.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bDisable.Location = new Point(7, 53);
            bDisable.Margin = new Padding(4, 3, 4, 3);
            bDisable.Name = "bDisable";
            bDisable.Size = new Size(75, 23);
            bDisable.TabIndex = 19;
            bDisable.Text = "Disable All";
            bDisable.Click += bDisable_Click;
            // 
            // bDefault
            // 
            bDefault.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bDefault.Location = new Point(7, 24);
            bDefault.Margin = new Padding(4, 3, 4, 3);
            bDefault.Name = "bDefault";
            bDefault.Size = new Size(75, 23);
            bDefault.TabIndex = 18;
            bDefault.Text = "Set Default";
            bDefault.Click += bDefault_Click;
            // 
            // bGeneratePatch
            // 
            bGeneratePatch.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bGeneratePatch.Location = new Point(15, 412);
            bGeneratePatch.Margin = new Padding(4, 3, 4, 3);
            bGeneratePatch.Name = "bGeneratePatch";
            bGeneratePatch.Size = new Size(153, 30);
            bGeneratePatch.TabIndex = 24;
            bGeneratePatch.Text = "Generate File(s)";
            bGeneratePatch.Click += bGeneratePatch_Click;
            // 
            // lInputFile
            // 
            lInputFile.AutoSize = true;
            lInputFile.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lInputFile.Location = new Point(10, 6);
            lInputFile.Margin = new Padding(4, 0, 4, 0);
            lInputFile.Name = "lInputFile";
            lInputFile.Size = new Size(97, 17);
            lInputFile.TabIndex = 24;
            lInputFile.Text = "Input Patchfile:";
            // 
            // tbPathPatchFile
            // 
            tbPathPatchFile.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPathPatchFile.Location = new Point(105, 5);
            tbPathPatchFile.Margin = new Padding(4, 3, 4, 3);
            tbPathPatchFile.Name = "tbPathPatchFile";
            tbPathPatchFile.Size = new Size(803, 21);
            tbPathPatchFile.TabIndex = 2;
            tbPathPatchFile.KeyDown += tbPathPatchFile_KeyDown;
            // 
            // bPathPatch
            // 
            bPathPatch.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bPathPatch.Location = new Point(912, 4);
            bPathPatch.Margin = new Padding(4, 3, 4, 3);
            bPathPatch.Name = "bPathPatch";
            bPathPatch.Size = new Size(27, 23);
            bPathPatch.TabIndex = 24;
            bPathPatch.Text = "..";
            bPathPatch.Click += bPathPatch_Click;
            // 
            // lOutPutFolderName
            // 
            lOutPutFolderName.AutoSize = true;
            lOutPutFolderName.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lOutPutFolderName.Location = new Point(10, 31);
            lOutPutFolderName.Margin = new Padding(4, 0, 4, 0);
            lOutPutFolderName.Name = "lOutPutFolderName";
            lOutPutFolderName.Size = new Size(93, 17);
            lOutPutFolderName.TabIndex = 26;
            lOutPutFolderName.Text = "Output Name:";
            // 
            // tbOutputName
            // 
            tbOutputName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbOutputName.Location = new Point(105, 30);
            tbOutputName.Margin = new Padding(4, 3, 4, 3);
            tbOutputName.Name = "tbOutputName";
            tbOutputName.Size = new Size(164, 21);
            tbOutputName.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 54);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 355);
            tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(pLoadOutControls);
            tabPage1.Controls.Add(pWeaponPanels);
            tabPage1.Location = new Point(4, 22);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(922, 329);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Weapons";
            // 
            // pLoadOutControls
            // 
            pLoadOutControls.BorderStyle = BorderStyle.FixedSingle;
            pLoadOutControls.Controls.Add(comboxFilterWeaponSecondary2);
            pLoadOutControls.Controls.Add(lSingleSecondary2);
            pLoadOutControls.Controls.Add(comboxFilterWeaponSecondary1);
            pLoadOutControls.Controls.Add(lSingleSecondary1);
            pLoadOutControls.Controls.Add(comboxFilterWeaponPrimary3);
            pLoadOutControls.Controls.Add(lSinglePrimary3);
            pLoadOutControls.Controls.Add(comboxFilterWeaponPrimary2);
            pLoadOutControls.Controls.Add(lSinglePrimary2);
            pLoadOutControls.Controls.Add(comboxFilterWeaponPrimary1);
            pLoadOutControls.Controls.Add(lSinglePrimary1);
            pLoadOutControls.Controls.Add(lWeaponLoadOut);
            pLoadOutControls.Controls.Add(comboxFilterWeaponSecondaryAll);
            pLoadOutControls.Controls.Add(bDefault);
            pLoadOutControls.Controls.Add(lSingleWeaponSecondary);
            pLoadOutControls.Controls.Add(bDisable);
            pLoadOutControls.Controls.Add(comboxFilterWeaponPrimaryAll);
            pLoadOutControls.Controls.Add(lSingleWeaponPrimary);
            pLoadOutControls.Controls.Add(lSingleWeapons);
            pLoadOutControls.Location = new Point(0, 0);
            pLoadOutControls.Margin = new Padding(4, 3, 4, 3);
            pLoadOutControls.Name = "pLoadOutControls";
            pLoadOutControls.Size = new Size(924, 85);
            pLoadOutControls.TabIndex = 1;
            // 
            // comboxFilterWeaponSecondary2
            // 
            comboxFilterWeaponSecondary2.BackColor = Color.Black;
            comboxFilterWeaponSecondary2.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxFilterWeaponSecondary2.ForeColor = Color.Gold;
            comboxFilterWeaponSecondary2.FormattingEnabled = true;
            comboxFilterWeaponSecondary2.Items.AddRange(new object[] { "-----------------------------" });
            comboxFilterWeaponSecondary2.Location = new Point(623, 31);
            comboxFilterWeaponSecondary2.Margin = new Padding(4, 3, 4, 3);
            comboxFilterWeaponSecondary2.Name = "comboxFilterWeaponSecondary2";
            comboxFilterWeaponSecondary2.Size = new Size(142, 21);
            comboxFilterWeaponSecondary2.TabIndex = 37;
            comboxFilterWeaponSecondary2.SelectedIndexChanged += comboxFilterWeaponSecondary2_SelectedIndexChanged;
            // 
            // lSingleSecondary2
            // 
            lSingleSecondary2.AutoSize = true;
            lSingleSecondary2.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lSingleSecondary2.ForeColor = Color.DarkOrange;
            lSingleSecondary2.Location = new Point(546, 32);
            lSingleSecondary2.Margin = new Padding(4, 0, 4, 0);
            lSingleSecondary2.Name = "lSingleSecondary2";
            lSingleSecondary2.Size = new Size(77, 17);
            lSingleSecondary2.TabIndex = 36;
            lSingleSecondary2.Text = "Secondary2";
            // 
            // comboxFilterWeaponSecondary1
            // 
            comboxFilterWeaponSecondary1.BackColor = Color.Black;
            comboxFilterWeaponSecondary1.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxFilterWeaponSecondary1.ForeColor = Color.Gold;
            comboxFilterWeaponSecondary1.FormattingEnabled = true;
            comboxFilterWeaponSecondary1.Items.AddRange(new object[] { "-----------------------------" });
            comboxFilterWeaponSecondary1.Location = new Point(623, 4);
            comboxFilterWeaponSecondary1.Margin = new Padding(4, 3, 4, 3);
            comboxFilterWeaponSecondary1.Name = "comboxFilterWeaponSecondary1";
            comboxFilterWeaponSecondary1.Size = new Size(142, 21);
            comboxFilterWeaponSecondary1.TabIndex = 35;
            comboxFilterWeaponSecondary1.SelectedIndexChanged += comboxFilterWeaponSecondary1_SelectedIndexChanged;
            // 
            // lSingleSecondary1
            // 
            lSingleSecondary1.AutoSize = true;
            lSingleSecondary1.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lSingleSecondary1.ForeColor = Color.DarkOrange;
            lSingleSecondary1.Location = new Point(546, 5);
            lSingleSecondary1.Margin = new Padding(4, 0, 4, 0);
            lSingleSecondary1.Name = "lSingleSecondary1";
            lSingleSecondary1.Size = new Size(77, 17);
            lSingleSecondary1.TabIndex = 34;
            lSingleSecondary1.Text = "Secondary1";
            // 
            // comboxFilterWeaponPrimary3
            // 
            comboxFilterWeaponPrimary3.BackColor = Color.Black;
            comboxFilterWeaponPrimary3.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxFilterWeaponPrimary3.ForeColor = Color.Gold;
            comboxFilterWeaponPrimary3.FormattingEnabled = true;
            comboxFilterWeaponPrimary3.Items.AddRange(new object[] { "-----------------------------" });
            comboxFilterWeaponPrimary3.Location = new Point(392, 58);
            comboxFilterWeaponPrimary3.Margin = new Padding(4, 3, 4, 3);
            comboxFilterWeaponPrimary3.Name = "comboxFilterWeaponPrimary3";
            comboxFilterWeaponPrimary3.Size = new Size(142, 21);
            comboxFilterWeaponPrimary3.TabIndex = 33;
            comboxFilterWeaponPrimary3.SelectedIndexChanged += comboxFilterWeaponPrimary3_SelectedIndexChanged;
            // 
            // lSinglePrimary3
            // 
            lSinglePrimary3.AutoSize = true;
            lSinglePrimary3.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lSinglePrimary3.ForeColor = Color.DarkOrange;
            lSinglePrimary3.Location = new Point(333, 59);
            lSinglePrimary3.Margin = new Padding(4, 0, 4, 0);
            lSinglePrimary3.Name = "lSinglePrimary3";
            lSinglePrimary3.Size = new Size(59, 17);
            lSinglePrimary3.TabIndex = 32;
            lSinglePrimary3.Text = "Primary3";
            // 
            // comboxFilterWeaponPrimary2
            // 
            comboxFilterWeaponPrimary2.BackColor = Color.Black;
            comboxFilterWeaponPrimary2.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxFilterWeaponPrimary2.ForeColor = Color.Gold;
            comboxFilterWeaponPrimary2.FormattingEnabled = true;
            comboxFilterWeaponPrimary2.Items.AddRange(new object[] { "-----------------------------" });
            comboxFilterWeaponPrimary2.Location = new Point(392, 31);
            comboxFilterWeaponPrimary2.Margin = new Padding(4, 3, 4, 3);
            comboxFilterWeaponPrimary2.Name = "comboxFilterWeaponPrimary2";
            comboxFilterWeaponPrimary2.Size = new Size(142, 21);
            comboxFilterWeaponPrimary2.TabIndex = 31;
            comboxFilterWeaponPrimary2.SelectedIndexChanged += comboxFilterWeaponPrimary2_SelectedIndexChanged;
            // 
            // lSinglePrimary2
            // 
            lSinglePrimary2.AutoSize = true;
            lSinglePrimary2.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lSinglePrimary2.ForeColor = Color.DarkOrange;
            lSinglePrimary2.Location = new Point(333, 32);
            lSinglePrimary2.Margin = new Padding(4, 0, 4, 0);
            lSinglePrimary2.Name = "lSinglePrimary2";
            lSinglePrimary2.Size = new Size(59, 17);
            lSinglePrimary2.TabIndex = 30;
            lSinglePrimary2.Text = "Primary2";
            // 
            // comboxFilterWeaponPrimary1
            // 
            comboxFilterWeaponPrimary1.BackColor = Color.Black;
            comboxFilterWeaponPrimary1.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxFilterWeaponPrimary1.ForeColor = Color.Gold;
            comboxFilterWeaponPrimary1.FormattingEnabled = true;
            comboxFilterWeaponPrimary1.Items.AddRange(new object[] { "-----------------------------" });
            comboxFilterWeaponPrimary1.Location = new Point(392, 4);
            comboxFilterWeaponPrimary1.Margin = new Padding(4, 3, 4, 3);
            comboxFilterWeaponPrimary1.Name = "comboxFilterWeaponPrimary1";
            comboxFilterWeaponPrimary1.Size = new Size(142, 21);
            comboxFilterWeaponPrimary1.TabIndex = 29;
            comboxFilterWeaponPrimary1.SelectedIndexChanged += comboxFilterWeaponPrimary1_SelectedIndexChanged;
            // 
            // lSinglePrimary1
            // 
            lSinglePrimary1.AutoSize = true;
            lSinglePrimary1.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lSinglePrimary1.ForeColor = Color.DarkOrange;
            lSinglePrimary1.Location = new Point(333, 5);
            lSinglePrimary1.Margin = new Padding(4, 0, 4, 0);
            lSinglePrimary1.Name = "lSinglePrimary1";
            lSinglePrimary1.Size = new Size(59, 17);
            lSinglePrimary1.TabIndex = 28;
            lSinglePrimary1.Text = "Primary1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(pScoreCollections);
            tabPage2.Controls.Add(pWaitTimes);
            tabPage2.Controls.Add(comboxDefaultZoneDeathTime);
            tabPage2.Controls.Add(tbZoneDeathTimes);
            tabPage2.Controls.Add(lZones);
            tabPage2.Controls.Add(comboxDefaultDaytimeSpeed);
            tabPage2.Controls.Add(comboxDefaultRespawnTime);
            tabPage2.Controls.Add(comboxDefaultSpawnShield);
            tabPage2.Controls.Add(tbSpawnShields);
            tabPage2.Controls.Add(lShields);
            tabPage2.Controls.Add(tbRespawnTimes);
            tabPage2.Controls.Add(lRespawnTimes);
            tabPage2.Controls.Add(bGenerateDayTimeNames);
            tabPage2.Controls.Add(bDayTimeAddAll);
            tabPage2.Controls.Add(tbDayTimeNames);
            tabPage2.Controls.Add(lDayTimeNames);
            tabPage2.Controls.Add(tbDayTimeValues);
            tabPage2.Controls.Add(lDayTime);
            tabPage2.Controls.Add(lCollectionInfo);
            tabPage2.Controls.Add(tbDaytimeSpeed);
            tabPage2.Controls.Add(lDayTimeSpeed);
            tabPage2.Location = new Point(4, 22);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(922, 329);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Collections";
            // 
            // pScoreCollections
            // 
            pScoreCollections.Controls.Add(bAddDefaultScoresTDM);
            pScoreCollections.Controls.Add(lScoresTDM);
            pScoreCollections.Controls.Add(comboxDefaultScoreTDM);
            pScoreCollections.Controls.Add(tbScoresTDM);
            pScoreCollections.Controls.Add(lScoresUPR);
            pScoreCollections.Controls.Add(comboxDefaultScoreUPR);
            pScoreCollections.Controls.Add(tbScoresUPR);
            pScoreCollections.Controls.Add(bAddDefaultScoresDM);
            pScoreCollections.Controls.Add(lScoresDM);
            pScoreCollections.Controls.Add(comboxDefaultScoreDM);
            pScoreCollections.Controls.Add(tbScoresDM);
            pScoreCollections.Controls.Add(bAddDefaultScoresCTD);
            pScoreCollections.Controls.Add(lScoresCTD);
            pScoreCollections.Controls.Add(comboxDefaultScoreCTD);
            pScoreCollections.Controls.Add(tbScoresCTD);
            pScoreCollections.Controls.Add(lScores);
            pScoreCollections.Location = new Point(2, 177);
            pScoreCollections.Name = "pScoreCollections";
            pScoreCollections.Size = new Size(920, 66);
            pScoreCollections.TabIndex = 50;
            // 
            // bAddDefaultScoresTDM
            // 
            bAddDefaultScoresTDM.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bAddDefaultScoresTDM.Location = new Point(339, 41);
            bAddDefaultScoresTDM.Margin = new Padding(4, 3, 4, 3);
            bAddDefaultScoresTDM.Name = "bAddDefaultScoresTDM";
            bAddDefaultScoresTDM.Size = new Size(100, 23);
            bAddDefaultScoresTDM.TabIndex = 63;
            bAddDefaultScoresTDM.Text = "Add Default";
            bAddDefaultScoresTDM.Click += bAddDefaultScoresTDM_Click;
            // 
            // lScoresTDM
            // 
            lScoresTDM.AutoSize = true;
            lScoresTDM.Cursor = Cursors.Hand;
            lScoresTDM.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lScoresTDM.ForeColor = Color.DarkOrange;
            lScoresTDM.Location = new Point(3, 43);
            lScoresTDM.Margin = new Padding(4, 0, 4, 0);
            lScoresTDM.Name = "lScoresTDM";
            lScoresTDM.Size = new Size(42, 17);
            lScoresTDM.TabIndex = 61;
            lScoresTDM.Text = "TDM:";
            // 
            // comboxDefaultScoreTDM
            // 
            comboxDefaultScoreTDM.BackColor = Color.Black;
            comboxDefaultScoreTDM.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultScoreTDM.ForeColor = Color.Chartreuse;
            comboxDefaultScoreTDM.FormattingEnabled = true;
            comboxDefaultScoreTDM.Location = new Point(273, 42);
            comboxDefaultScoreTDM.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultScoreTDM.Name = "comboxDefaultScoreTDM";
            comboxDefaultScoreTDM.Size = new Size(62, 21);
            comboxDefaultScoreTDM.TabIndex = 62;
            // 
            // tbScoresTDM
            // 
            tbScoresTDM.BackColor = Color.Black;
            tbScoresTDM.ForeColor = Color.Gold;
            tbScoresTDM.Location = new Point(45, 42);
            tbScoresTDM.Margin = new Padding(4, 3, 4, 3);
            tbScoresTDM.Name = "tbScoresTDM";
            tbScoresTDM.Size = new Size(220, 20);
            tbScoresTDM.TabIndex = 60;
            // 
            // lScoresUPR
            // 
            lScoresUPR.AutoSize = true;
            lScoresUPR.Cursor = Cursors.Hand;
            lScoresUPR.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lScoresUPR.ForeColor = Color.DarkOrange;
            lScoresUPR.Location = new Point(483, 42);
            lScoresUPR.Margin = new Padding(4, 0, 4, 0);
            lScoresUPR.Name = "lScoresUPR";
            lScoresUPR.Size = new Size(37, 17);
            lScoresUPR.TabIndex = 57;
            lScoresUPR.Text = "UPR:";
            // 
            // comboxDefaultScoreUPR
            // 
            comboxDefaultScoreUPR.BackColor = Color.Black;
            comboxDefaultScoreUPR.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultScoreUPR.ForeColor = Color.Chartreuse;
            comboxDefaultScoreUPR.FormattingEnabled = true;
            comboxDefaultScoreUPR.Location = new Point(748, 41);
            comboxDefaultScoreUPR.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultScoreUPR.Name = "comboxDefaultScoreUPR";
            comboxDefaultScoreUPR.Size = new Size(62, 21);
            comboxDefaultScoreUPR.TabIndex = 58;
            // 
            // tbScoresUPR
            // 
            tbScoresUPR.BackColor = Color.Black;
            tbScoresUPR.ForeColor = Color.Gold;
            tbScoresUPR.Location = new Point(520, 41);
            tbScoresUPR.Margin = new Padding(4, 3, 4, 3);
            tbScoresUPR.Name = "tbScoresUPR";
            tbScoresUPR.Size = new Size(220, 20);
            tbScoresUPR.TabIndex = 56;
            // 
            // bAddDefaultScoresDM
            // 
            bAddDefaultScoresDM.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bAddDefaultScoresDM.Location = new Point(339, 16);
            bAddDefaultScoresDM.Margin = new Padding(4, 3, 4, 3);
            bAddDefaultScoresDM.Name = "bAddDefaultScoresDM";
            bAddDefaultScoresDM.Size = new Size(100, 23);
            bAddDefaultScoresDM.TabIndex = 55;
            bAddDefaultScoresDM.Text = "Add Default";
            bAddDefaultScoresDM.Click += bAddDefaultScoresDM_Click;
            // 
            // lScoresDM
            // 
            lScoresDM.AutoSize = true;
            lScoresDM.Cursor = Cursors.Hand;
            lScoresDM.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lScoresDM.ForeColor = Color.DarkOrange;
            lScoresDM.Location = new Point(3, 18);
            lScoresDM.Margin = new Padding(4, 0, 4, 0);
            lScoresDM.Name = "lScoresDM";
            lScoresDM.Size = new Size(34, 17);
            lScoresDM.TabIndex = 53;
            lScoresDM.Text = "DM:";
            // 
            // comboxDefaultScoreDM
            // 
            comboxDefaultScoreDM.BackColor = Color.Black;
            comboxDefaultScoreDM.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultScoreDM.ForeColor = Color.Chartreuse;
            comboxDefaultScoreDM.FormattingEnabled = true;
            comboxDefaultScoreDM.Location = new Point(273, 17);
            comboxDefaultScoreDM.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultScoreDM.Name = "comboxDefaultScoreDM";
            comboxDefaultScoreDM.Size = new Size(62, 21);
            comboxDefaultScoreDM.TabIndex = 54;
            // 
            // tbScoresDM
            // 
            tbScoresDM.BackColor = Color.Black;
            tbScoresDM.ForeColor = Color.Gold;
            tbScoresDM.Location = new Point(45, 17);
            tbScoresDM.Margin = new Padding(4, 3, 4, 3);
            tbScoresDM.Name = "tbScoresDM";
            tbScoresDM.Size = new Size(220, 20);
            tbScoresDM.TabIndex = 52;
            // 
            // bAddDefaultScoresCTD
            // 
            bAddDefaultScoresCTD.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bAddDefaultScoresCTD.Location = new Point(814, 15);
            bAddDefaultScoresCTD.Margin = new Padding(4, 3, 4, 3);
            bAddDefaultScoresCTD.Name = "bAddDefaultScoresCTD";
            bAddDefaultScoresCTD.Size = new Size(100, 23);
            bAddDefaultScoresCTD.TabIndex = 51;
            bAddDefaultScoresCTD.Text = "Add Default";
            bAddDefaultScoresCTD.Click += bAddDefaultScoresCTD_Click;
            // 
            // lScoresCTD
            // 
            lScoresCTD.AutoSize = true;
            lScoresCTD.Cursor = Cursors.Hand;
            lScoresCTD.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lScoresCTD.ForeColor = Color.DarkOrange;
            lScoresCTD.Location = new Point(483, 17);
            lScoresCTD.Margin = new Padding(4, 0, 4, 0);
            lScoresCTD.Name = "lScoresCTD";
            lScoresCTD.Size = new Size(37, 17);
            lScoresCTD.TabIndex = 48;
            lScoresCTD.Text = "CTD:";
            // 
            // comboxDefaultScoreCTD
            // 
            comboxDefaultScoreCTD.BackColor = Color.Black;
            comboxDefaultScoreCTD.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultScoreCTD.ForeColor = Color.Chartreuse;
            comboxDefaultScoreCTD.FormattingEnabled = true;
            comboxDefaultScoreCTD.Location = new Point(748, 16);
            comboxDefaultScoreCTD.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultScoreCTD.Name = "comboxDefaultScoreCTD";
            comboxDefaultScoreCTD.Size = new Size(62, 21);
            comboxDefaultScoreCTD.TabIndex = 49;
            // 
            // tbScoresCTD
            // 
            tbScoresCTD.BackColor = Color.Black;
            tbScoresCTD.ForeColor = Color.Gold;
            tbScoresCTD.Location = new Point(520, 16);
            tbScoresCTD.Margin = new Padding(4, 3, 4, 3);
            tbScoresCTD.Name = "tbScoresCTD";
            tbScoresCTD.Size = new Size(220, 20);
            tbScoresCTD.TabIndex = 47;
            // 
            // lScores
            // 
            lScores.AutoSize = true;
            lScores.Cursor = Cursors.Hand;
            lScores.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lScores.ForeColor = Color.DarkOrange;
            lScores.Location = new Point(0, -4);
            lScores.Margin = new Padding(4, 0, 4, 0);
            lScores.Name = "lScores";
            lScores.Size = new Size(59, 21);
            lScores.TabIndex = 50;
            lScores.Text = "Scores";
            // 
            // pWaitTimes
            // 
            pWaitTimes.Controls.Add(comboxDefaultPreRoundTime);
            pWaitTimes.Controls.Add(comboxDefaultPostRoundTime);
            pWaitTimes.Controls.Add(tbPostRoundTimes);
            pWaitTimes.Controls.Add(lPostRoundTimes);
            pWaitTimes.Controls.Add(tbPreRoundTimes);
            pWaitTimes.Controls.Add(lPreRound);
            pWaitTimes.Location = new Point(2, 242);
            pWaitTimes.Name = "pWaitTimes";
            pWaitTimes.Size = new Size(920, 61);
            pWaitTimes.TabIndex = 46;
            // 
            // comboxDefaultPreRoundTime
            // 
            comboxDefaultPreRoundTime.BackColor = Color.Black;
            comboxDefaultPreRoundTime.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultPreRoundTime.ForeColor = Color.Chartreuse;
            comboxDefaultPreRoundTime.FormattingEnabled = true;
            comboxDefaultPreRoundTime.Location = new Point(718, 2);
            comboxDefaultPreRoundTime.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultPreRoundTime.Name = "comboxDefaultPreRoundTime";
            comboxDefaultPreRoundTime.Size = new Size(92, 21);
            comboxDefaultPreRoundTime.TabIndex = 47;
            // 
            // comboxDefaultPostRoundTime
            // 
            comboxDefaultPostRoundTime.BackColor = Color.Black;
            comboxDefaultPostRoundTime.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultPostRoundTime.ForeColor = Color.Chartreuse;
            comboxDefaultPostRoundTime.FormattingEnabled = true;
            comboxDefaultPostRoundTime.Location = new Point(718, 29);
            comboxDefaultPostRoundTime.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultPostRoundTime.Name = "comboxDefaultPostRoundTime";
            comboxDefaultPostRoundTime.Size = new Size(92, 21);
            comboxDefaultPostRoundTime.TabIndex = 46;
            // 
            // tbPostRoundTimes
            // 
            tbPostRoundTimes.BackColor = Color.Black;
            tbPostRoundTimes.ForeColor = Color.Gold;
            tbPostRoundTimes.Location = new Point(115, 29);
            tbPostRoundTimes.Margin = new Padding(4, 3, 4, 3);
            tbPostRoundTimes.Name = "tbPostRoundTimes";
            tbPostRoundTimes.Size = new Size(595, 20);
            tbPostRoundTimes.TabIndex = 44;
            // 
            // lPostRoundTimes
            // 
            lPostRoundTimes.AutoSize = true;
            lPostRoundTimes.Cursor = Cursors.Hand;
            lPostRoundTimes.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lPostRoundTimes.ForeColor = Color.DarkOrange;
            lPostRoundTimes.Location = new Point(0, 30);
            lPostRoundTimes.Margin = new Padding(4, 0, 4, 0);
            lPostRoundTimes.Name = "lPostRoundTimes";
            lPostRoundTimes.Size = new Size(117, 17);
            lPostRoundTimes.TabIndex = 45;
            lPostRoundTimes.Text = "Postround Times:";
            lPostRoundTimes.Click += lPostRoundTimes_Click;
            // 
            // tbPreRoundTimes
            // 
            tbPreRoundTimes.BackColor = Color.Black;
            tbPreRoundTimes.ForeColor = Color.Gold;
            tbPreRoundTimes.Location = new Point(115, 3);
            tbPreRoundTimes.Margin = new Padding(4, 3, 4, 3);
            tbPreRoundTimes.Name = "tbPreRoundTimes";
            tbPreRoundTimes.Size = new Size(595, 20);
            tbPreRoundTimes.TabIndex = 42;
            // 
            // lPreRound
            // 
            lPreRound.AutoSize = true;
            lPreRound.Cursor = Cursors.Hand;
            lPreRound.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lPreRound.ForeColor = Color.DarkOrange;
            lPreRound.Location = new Point(0, 4);
            lPreRound.Margin = new Padding(4, 0, 4, 0);
            lPreRound.Name = "lPreRound";
            lPreRound.Size = new Size(110, 17);
            lPreRound.TabIndex = 43;
            lPreRound.Text = "Preround Times:";
            lPreRound.Click += lPreRound_Click;
            // 
            // comboxDefaultZoneDeathTime
            // 
            comboxDefaultZoneDeathTime.BackColor = Color.Black;
            comboxDefaultZoneDeathTime.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultZoneDeathTime.ForeColor = Color.Chartreuse;
            comboxDefaultZoneDeathTime.FormattingEnabled = true;
            comboxDefaultZoneDeathTime.Location = new Point(720, 153);
            comboxDefaultZoneDeathTime.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultZoneDeathTime.Name = "comboxDefaultZoneDeathTime";
            comboxDefaultZoneDeathTime.Size = new Size(92, 21);
            comboxDefaultZoneDeathTime.TabIndex = 45;
            // 
            // tbZoneDeathTimes
            // 
            tbZoneDeathTimes.BackColor = Color.Black;
            tbZoneDeathTimes.ForeColor = Color.Gold;
            tbZoneDeathTimes.Location = new Point(117, 153);
            tbZoneDeathTimes.Margin = new Padding(4, 3, 4, 3);
            tbZoneDeathTimes.Name = "tbZoneDeathTimes";
            tbZoneDeathTimes.Size = new Size(595, 20);
            tbZoneDeathTimes.TabIndex = 43;
            // 
            // lZones
            // 
            lZones.AutoSize = true;
            lZones.Cursor = Cursors.Hand;
            lZones.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lZones.ForeColor = Color.DarkOrange;
            lZones.Location = new Point(2, 154);
            lZones.Margin = new Padding(4, 0, 4, 0);
            lZones.Name = "lZones";
            lZones.Size = new Size(116, 17);
            lZones.TabIndex = 44;
            lZones.Text = "ZoneDeathTimes:";
            lZones.Click += lZones_Click;
            // 
            // comboxDefaultDaytimeSpeed
            // 
            comboxDefaultDaytimeSpeed.BackColor = Color.Black;
            comboxDefaultDaytimeSpeed.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultDaytimeSpeed.ForeColor = Color.Chartreuse;
            comboxDefaultDaytimeSpeed.FormattingEnabled = true;
            comboxDefaultDaytimeSpeed.Location = new Point(720, 74);
            comboxDefaultDaytimeSpeed.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultDaytimeSpeed.Name = "comboxDefaultDaytimeSpeed";
            comboxDefaultDaytimeSpeed.Size = new Size(92, 21);
            comboxDefaultDaytimeSpeed.TabIndex = 42;
            // 
            // comboxDefaultRespawnTime
            // 
            comboxDefaultRespawnTime.BackColor = Color.Black;
            comboxDefaultRespawnTime.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultRespawnTime.ForeColor = Color.Chartreuse;
            comboxDefaultRespawnTime.FormattingEnabled = true;
            comboxDefaultRespawnTime.Location = new Point(720, 100);
            comboxDefaultRespawnTime.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultRespawnTime.Name = "comboxDefaultRespawnTime";
            comboxDefaultRespawnTime.Size = new Size(92, 21);
            comboxDefaultRespawnTime.TabIndex = 41;
            // 
            // comboxDefaultSpawnShield
            // 
            comboxDefaultSpawnShield.BackColor = Color.Black;
            comboxDefaultSpawnShield.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxDefaultSpawnShield.ForeColor = Color.Chartreuse;
            comboxDefaultSpawnShield.FormattingEnabled = true;
            comboxDefaultSpawnShield.Location = new Point(720, 127);
            comboxDefaultSpawnShield.Margin = new Padding(4, 3, 4, 3);
            comboxDefaultSpawnShield.Name = "comboxDefaultSpawnShield";
            comboxDefaultSpawnShield.Size = new Size(92, 21);
            comboxDefaultSpawnShield.TabIndex = 40;
            // 
            // tbSpawnShields
            // 
            tbSpawnShields.BackColor = Color.Black;
            tbSpawnShields.ForeColor = Color.Gold;
            tbSpawnShields.Location = new Point(117, 127);
            tbSpawnShields.Margin = new Padding(4, 3, 4, 3);
            tbSpawnShields.Name = "tbSpawnShields";
            tbSpawnShields.Size = new Size(595, 20);
            tbSpawnShields.TabIndex = 38;
            // 
            // lShields
            // 
            lShields.AutoSize = true;
            lShields.Cursor = Cursors.Hand;
            lShields.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lShields.ForeColor = Color.DarkOrange;
            lShields.Location = new Point(2, 128);
            lShields.Margin = new Padding(4, 0, 4, 0);
            lShields.Name = "lShields";
            lShields.Size = new Size(95, 17);
            lShields.TabIndex = 39;
            lShields.Text = "SpawnShields:";
            lShields.Click += lShields_Click;
            // 
            // tbRespawnTimes
            // 
            tbRespawnTimes.BackColor = Color.Black;
            tbRespawnTimes.ForeColor = Color.Gold;
            tbRespawnTimes.Location = new Point(117, 101);
            tbRespawnTimes.Margin = new Padding(4, 3, 4, 3);
            tbRespawnTimes.Name = "tbRespawnTimes";
            tbRespawnTimes.Size = new Size(595, 20);
            tbRespawnTimes.TabIndex = 36;
            // 
            // lRespawnTimes
            // 
            lRespawnTimes.AutoSize = true;
            lRespawnTimes.Cursor = Cursors.Hand;
            lRespawnTimes.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lRespawnTimes.ForeColor = Color.DarkOrange;
            lRespawnTimes.Location = new Point(2, 102);
            lRespawnTimes.Margin = new Padding(4, 0, 4, 0);
            lRespawnTimes.Name = "lRespawnTimes";
            lRespawnTimes.Size = new Size(102, 17);
            lRespawnTimes.TabIndex = 37;
            lRespawnTimes.Text = "RespawnTimes:";
            lRespawnTimes.Click += lRespawnTime_Click;
            // 
            // bGenerateDayTimeNames
            // 
            bGenerateDayTimeNames.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bGenerateDayTimeNames.Location = new Point(818, 48);
            bGenerateDayTimeNames.Margin = new Padding(4, 3, 4, 3);
            bGenerateDayTimeNames.Name = "bGenerateDayTimeNames";
            bGenerateDayTimeNames.Size = new Size(97, 23);
            bGenerateDayTimeNames.TabIndex = 35;
            bGenerateDayTimeNames.Text = "Generate";
            bGenerateDayTimeNames.Click += bGenerateDayTimeNames_Click;
            // 
            // bDayTimeAddAll
            // 
            bDayTimeAddAll.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bDayTimeAddAll.Location = new Point(818, 22);
            bDayTimeAddAll.Margin = new Padding(4, 3, 4, 3);
            bDayTimeAddAll.Name = "bDayTimeAddAll";
            bDayTimeAddAll.Size = new Size(97, 23);
            bDayTimeAddAll.TabIndex = 30;
            bDayTimeAddAll.Text = "Add All";
            bDayTimeAddAll.Click += bDayTimeAddAll_Click;
            // 
            // tbDayTimeNames
            // 
            tbDayTimeNames.BackColor = Color.Black;
            tbDayTimeNames.ForeColor = Color.Gray;
            tbDayTimeNames.Location = new Point(117, 49);
            tbDayTimeNames.Margin = new Padding(4, 3, 4, 3);
            tbDayTimeNames.Name = "tbDayTimeNames";
            tbDayTimeNames.Size = new Size(695, 20);
            tbDayTimeNames.TabIndex = 33;
            // 
            // lDayTimeNames
            // 
            lDayTimeNames.AutoSize = true;
            lDayTimeNames.Cursor = Cursors.Hand;
            lDayTimeNames.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lDayTimeNames.ForeColor = Color.Gray;
            lDayTimeNames.Location = new Point(2, 50);
            lDayTimeNames.Margin = new Padding(4, 0, 4, 0);
            lDayTimeNames.Name = "lDayTimeNames";
            lDayTimeNames.Size = new Size(113, 17);
            lDayTimeNames.TabIndex = 34;
            lDayTimeNames.Text = "DayTime Names:";
            lDayTimeNames.Click += lDayTimeNames_Click;
            // 
            // tbDayTimeValues
            // 
            tbDayTimeValues.BackColor = Color.Black;
            tbDayTimeValues.ForeColor = Color.Gray;
            tbDayTimeValues.Location = new Point(117, 23);
            tbDayTimeValues.Margin = new Padding(4, 3, 4, 3);
            tbDayTimeValues.Name = "tbDayTimeValues";
            tbDayTimeValues.Size = new Size(695, 20);
            tbDayTimeValues.TabIndex = 31;
            // 
            // lDayTime
            // 
            lDayTime.AutoSize = true;
            lDayTime.Cursor = Cursors.Hand;
            lDayTime.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lDayTime.ForeColor = Color.Gray;
            lDayTime.Location = new Point(2, 24);
            lDayTime.Margin = new Padding(4, 0, 4, 0);
            lDayTime.Name = "lDayTime";
            lDayTime.Size = new Size(108, 17);
            lDayTime.TabIndex = 32;
            lDayTime.Text = "DayTime Hours:";
            lDayTime.Click += lDayTime_Click;
            // 
            // lCollectionInfo
            // 
            lCollectionInfo.AutoSize = true;
            lCollectionInfo.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lCollectionInfo.ForeColor = Color.Gold;
            lCollectionInfo.Location = new Point(2, 3);
            lCollectionInfo.Margin = new Padding(4, 0, 4, 0);
            lCollectionInfo.Name = "lCollectionInfo";
            lCollectionInfo.Size = new Size(234, 17);
            lCollectionInfo.TabIndex = 30;
            lCollectionInfo.Text = "Add values to collections ( Split by ; )";
            // 
            // tbDaytimeSpeed
            // 
            tbDaytimeSpeed.BackColor = Color.Black;
            tbDaytimeSpeed.ForeColor = Color.Gold;
            tbDaytimeSpeed.Location = new Point(117, 75);
            tbDaytimeSpeed.Margin = new Padding(4, 3, 4, 3);
            tbDaytimeSpeed.Name = "tbDaytimeSpeed";
            tbDaytimeSpeed.Size = new Size(595, 20);
            tbDaytimeSpeed.TabIndex = 27;
            // 
            // lDayTimeSpeed
            // 
            lDayTimeSpeed.AutoSize = true;
            lDayTimeSpeed.Cursor = Cursors.Hand;
            lDayTimeSpeed.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lDayTimeSpeed.ForeColor = Color.DarkOrange;
            lDayTimeSpeed.Location = new Point(2, 76);
            lDayTimeSpeed.Margin = new Padding(4, 0, 4, 0);
            lDayTimeSpeed.Name = "lDayTimeSpeed";
            lDayTimeSpeed.Size = new Size(105, 17);
            lDayTimeSpeed.TabIndex = 28;
            lDayTimeSpeed.Text = "Daytime Speed:";
            lDayTimeSpeed.Click += lDayTimeSpeed_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Black;
            tabPage3.Location = new Point(4, 22);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(922, 329);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "fc2sl";
            // 
            // tbDebugOutPut
            // 
            tbDebugOutPut.Location = new Point(848, 30);
            tbDebugOutPut.Margin = new Padding(4, 3, 4, 3);
            tbDebugOutPut.Multiline = true;
            tbDebugOutPut.Name = "tbDebugOutPut";
            tbDebugOutPut.Size = new Size(91, 39);
            tbDebugOutPut.TabIndex = 26;
            tbDebugOutPut.Visible = false;
            // 
            // bSettings
            // 
            bSettings.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bSettings.Location = new Point(878, 47);
            bSettings.Margin = new Padding(4, 3, 4, 3);
            bSettings.Name = "bSettings";
            bSettings.Size = new Size(61, 23);
            bSettings.TabIndex = 33;
            bSettings.Text = "Settings";
            bSettings.Click += bSettings_Click;
            // 
            // pbOpenGenerationFolder
            // 
            pbOpenGenerationFolder.Cursor = Cursors.Hand;
            pbOpenGenerationFolder.Image = (Image)resources.GetObject("pbOpenGenerationFolder.Image");
            pbOpenGenerationFolder.Location = new Point(275, 32);
            pbOpenGenerationFolder.Name = "pbOpenGenerationFolder";
            pbOpenGenerationFolder.Size = new Size(16, 16);
            pbOpenGenerationFolder.TabIndex = 34;
            pbOpenGenerationFolder.TabStop = false;
            pbOpenGenerationFolder.Click += pbOpenGenerationFolder_Click;
            // 
            // lModCollection
            // 
            lModCollection.AutoSize = true;
            lModCollection.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lModCollection.Location = new Point(309, 31);
            lModCollection.Margin = new Padding(4, 0, 4, 0);
            lModCollection.Name = "lModCollection";
            lModCollection.Size = new Size(112, 17);
            lModCollection.TabIndex = 36;
            lModCollection.Text = "Generated Mods:";
            // 
            // bLoadReport
            // 
            bLoadReport.Enabled = false;
            bLoadReport.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bLoadReport.Location = new Point(544, 29);
            bLoadReport.Margin = new Padding(4, 3, 4, 3);
            bLoadReport.Name = "bLoadReport";
            bLoadReport.Size = new Size(44, 23);
            bLoadReport.TabIndex = 38;
            bLoadReport.Text = "Load";
            bLoadReport.Click += bLoadReport_Click;
            // 
            // bInstall
            // 
            bInstall.Enabled = false;
            bInstall.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bInstall.Location = new Point(591, 29);
            bInstall.Margin = new Padding(4, 3, 4, 3);
            bInstall.Name = "bInstall";
            bInstall.Size = new Size(50, 23);
            bInstall.TabIndex = 39;
            bInstall.Text = "Install";
            bInstall.Click += bInstall_Click;
            // 
            // comboxModCollection
            // 
            comboxModCollection.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxModCollection.FormattingEnabled = true;
            comboxModCollection.Location = new Point(423, 30);
            comboxModCollection.Margin = new Padding(4, 3, 4, 3);
            comboxModCollection.Name = "comboxModCollection";
            comboxModCollection.Size = new Size(117, 21);
            comboxModCollection.TabIndex = 40;
            comboxModCollection.SelectedIndexChanged += comboxModCollection_SelectedIndexChanged;
            comboxModCollection.DropDownClosed += UnselectText;
            comboxModCollection.KeyDown += PreventKey;
            // 
            // lCredits
            // 
            lCredits.AutoSize = true;
            lCredits.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lCredits.Location = new Point(603, 416);
            lCredits.Margin = new Padding(4, 0, 4, 0);
            lCredits.Name = "lCredits";
            lCredits.Size = new Size(200, 23);
            lCredits.TabIndex = 41;
            lCredits.Text = "Created by FEARIV";
            // 
            // lDiscordLink
            // 
            lDiscordLink.AutoSize = true;
            lDiscordLink.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lDiscordLink.Location = new Point(802, 415);
            lDiscordLink.Name = "lDiscordLink";
            lDiscordLink.Size = new Size(142, 22);
            lDiscordLink.TabIndex = 42;
            lDiscordLink.TabStop = true;
            lDiscordLink.Text = "https://dsc.gg/FC2";
            lDiscordLink.LinkClicked += lDiscordLink_LinkClicked;
            // 
            // pbOpenGameBinFolder
            // 
            pbOpenGameBinFolder.Cursor = Cursors.Hand;
            pbOpenGameBinFolder.Image = (Image)resources.GetObject("pbOpenGameBinFolder.Image");
            pbOpenGameBinFolder.Location = new Point(646, 32);
            pbOpenGameBinFolder.Name = "pbOpenGameBinFolder";
            pbOpenGameBinFolder.Size = new Size(16, 16);
            pbOpenGameBinFolder.TabIndex = 43;
            pbOpenGameBinFolder.TabStop = false;
            pbOpenGameBinFolder.Click += pbOpenGameBinFolder_Click;
            // 
            // GeneratorGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 446);
            Controls.Add(pbOpenGameBinFolder);
            Controls.Add(lDiscordLink);
            Controls.Add(lCredits);
            Controls.Add(comboxModCollection);
            Controls.Add(bInstall);
            Controls.Add(bLoadReport);
            Controls.Add(lModCollection);
            Controls.Add(pbOpenGenerationFolder);
            Controls.Add(bSettings);
            Controls.Add(tbDebugOutPut);
            Controls.Add(tabControl1);
            Controls.Add(tbOutputName);
            Controls.Add(bGeneratePatch);
            Controls.Add(lOutPutFolderName);
            Controls.Add(bPathPatch);
            Controls.Add(tbPathPatchFile);
            Controls.Add(lInputFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "GeneratorGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FarCry2 ServerMod-Generator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pLoadOutControls.ResumeLayout(false);
            pLoadOutControls.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pScoreCollections.ResumeLayout(false);
            pScoreCollections.PerformLayout();
            pWaitTimes.ResumeLayout(false);
            pWaitTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOpenGenerationFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOpenGameBinFolder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Glass.GlassButton bDisable;
        private Glass.GlassButton bDefault;
        private Label lWeaponLoadOut;
        private ComboBox comboxFilterWeaponSecondaryAll;
        private Label lSingleWeaponSecondary;
        private ComboBox comboxFilterWeaponPrimaryAll;
        private Label lSingleWeapons;
        private Label lSingleWeaponPrimary;
        private Label lInputFile;
        private TextBox tbPathPatchFile;
        private Glass.GlassButton bPathPatch;
        private Label lOutPutFolderName;
        private TextBox tbOutputName;
        private Glass.GlassButton bGeneratePatch;
        private Panel pWeaponPanels;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel pLoadOutControls;
        private TextBox tbDaytimeSpeed;
        private Label lDayTimeSpeed;
        private TextBox tbDebugOutPut;
        private Label lCollectionInfo;
        private Glass.GlassButton bDayTimeAddAll;
        private TextBox tbDayTimeNames;
        private Label lDayTimeNames;
        private TextBox tbDayTimeValues;
        private Label lDayTime;
        private Glass.GlassButton bGenerateDayTimeNames;
        private TextBox tbSpawnShields;
        private Label lShields;
        private TextBox tbRespawnTimes;
        private Label lRespawnTimes;
        private ComboBox comboxDefaultSpawnShield;
        private ComboBox comboxDefaultRespawnTime;
        private ComboBox comboxDefaultDaytimeSpeed;
        private ComboBox comboxDefaultZoneDeathTime;
        private TextBox tbZoneDeathTimes;
        private Label lZones;
        private TabPage tabPage3;
        private Glass.GlassButton bSettings;
        private PictureBox pbOpenGenerationFolder;
        private Panel pWaitTimes;
        private ComboBox comboxDefaultPreRoundTime;
        private ComboBox comboxDefaultPostRoundTime;
        private TextBox tbPostRoundTimes;
        private Label lPostRoundTimes;
        private TextBox tbPreRoundTimes;
        private Label lPreRound;
        private Label lModCollection;
        private Glass.GlassButton bLoadReport;
        private Glass.GlassButton bInstall;
        private ComboBox comboxModCollection;
        private Label lCredits;
        private LinkLabel lDiscordLink;
        private Panel pScoreCollections;
        private Label lScores;
        private Label lScoresCTD;
        private ComboBox comboxDefaultScoreCTD;
        private TextBox tbScoresCTD;
        private Glass.GlassButton bAddDefaultScoresCTD;
        private Glass.GlassButton bAddDefaultScoresTDM;
        private Label lScoresTDM;
        private ComboBox comboxDefaultScoreTDM;
        private TextBox tbScoresTDM;
        private Label lScoresUPR;
        private ComboBox comboxDefaultScoreUPR;
        private TextBox tbScoresUPR;
        private Glass.GlassButton bAddDefaultScoresDM;
        private Label lScoresDM;
        private ComboBox comboxDefaultScoreDM;
        private TextBox tbScoresDM;
        private PictureBox pbOpenGameBinFolder;
        private ComboBox comboxFilterWeaponSecondary2;
        private Label lSingleSecondary2;
        private ComboBox comboxFilterWeaponSecondary1;
        private Label lSingleSecondary1;
        private ComboBox comboxFilterWeaponPrimary3;
        private Label lSinglePrimary3;
        private ComboBox comboxFilterWeaponPrimary2;
        private Label lSinglePrimary2;
        private ComboBox comboxFilterWeaponPrimary1;
        private Label lSinglePrimary1;
    }
}

