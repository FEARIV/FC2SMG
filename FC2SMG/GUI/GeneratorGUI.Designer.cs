
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
            this.pWeaponPanels = new System.Windows.Forms.Panel();
            this.comboxSingleWeaponSecondary = new System.Windows.Forms.ComboBox();
            this.lSingleWeaponSecondary = new System.Windows.Forms.Label();
            this.comboxSingleWeaponPrimary = new System.Windows.Forms.ComboBox();
            this.lSingleWeapons = new System.Windows.Forms.Label();
            this.lSingleWeaponPrimary = new System.Windows.Forms.Label();
            this.lWeaponLoadOut = new System.Windows.Forms.Label();
            this.bDisable = new Glass.GlassButton();
            this.bDefault = new Glass.GlassButton();
            this.bGeneratePatch = new Glass.GlassButton();
            this.lInputFile = new System.Windows.Forms.Label();
            this.tbPathPatchFile = new System.Windows.Forms.TextBox();
            this.bPathPatch = new Glass.GlassButton();
            this.lOutPutFolderName = new System.Windows.Forms.Label();
            this.tbOutputName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pLoadOutControls = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pWaitTimes = new System.Windows.Forms.Panel();
            this.comboxDefaultPreRoundTime = new System.Windows.Forms.ComboBox();
            this.comboxDefaultPostRoundTime = new System.Windows.Forms.ComboBox();
            this.tbPostRoundTimes = new System.Windows.Forms.TextBox();
            this.lPostRoundTimes = new System.Windows.Forms.Label();
            this.tbPreRoundTimes = new System.Windows.Forms.TextBox();
            this.lPreRound = new System.Windows.Forms.Label();
            this.comboxDefaultZoneDeathTime = new System.Windows.Forms.ComboBox();
            this.tbZoneDeathTimes = new System.Windows.Forms.TextBox();
            this.lZones = new System.Windows.Forms.Label();
            this.comboxDefaultDaytimeSpeed = new System.Windows.Forms.ComboBox();
            this.comboxDefaultRespawnTime = new System.Windows.Forms.ComboBox();
            this.comboxDefaultSpawnShield = new System.Windows.Forms.ComboBox();
            this.tbSpawnShields = new System.Windows.Forms.TextBox();
            this.lShields = new System.Windows.Forms.Label();
            this.tbRespawnTimes = new System.Windows.Forms.TextBox();
            this.lRespawnTimes = new System.Windows.Forms.Label();
            this.bGenerateDayTimeNames = new Glass.GlassButton();
            this.bDayTimeAddAll = new Glass.GlassButton();
            this.tbDayTimeNames = new System.Windows.Forms.TextBox();
            this.lDayTimeNames = new System.Windows.Forms.Label();
            this.tbDayTimeValues = new System.Windows.Forms.TextBox();
            this.lDayTime = new System.Windows.Forms.Label();
            this.lCollectionInfo = new System.Windows.Forms.Label();
            this.tbDaytimeSpeed = new System.Windows.Forms.TextBox();
            this.lDayTimeSpeed = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbDebugOutPut = new System.Windows.Forms.TextBox();
            this.bSettings = new Glass.GlassButton();
            this.pbOpenGenerationFolder = new System.Windows.Forms.PictureBox();
            this.lModCollection = new System.Windows.Forms.Label();
            this.bLoadReport = new Glass.GlassButton();
            this.bInstall = new Glass.GlassButton();
            this.comboxModCollection = new System.Windows.Forms.ComboBox();
            this.lCredits = new System.Windows.Forms.Label();
            this.lDiscordLink = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pLoadOutControls.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pWaitTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenGenerationFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // pWeaponPanels
            // 
            this.pWeaponPanels.Location = new System.Drawing.Point(0, 67);
            this.pWeaponPanels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pWeaponPanels.Name = "pWeaponPanels";
            this.pWeaponPanels.Size = new System.Drawing.Size(820, 253);
            this.pWeaponPanels.TabIndex = 25;
            // 
            // comboxSingleWeaponSecondary
            // 
            this.comboxSingleWeaponSecondary.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxSingleWeaponSecondary.FormattingEnabled = true;
            this.comboxSingleWeaponSecondary.Items.AddRange(new object[] {
            "------------------------"});
            this.comboxSingleWeaponSecondary.Location = new System.Drawing.Point(303, 40);
            this.comboxSingleWeaponSecondary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxSingleWeaponSecondary.Name = "comboxSingleWeaponSecondary";
            this.comboxSingleWeaponSecondary.Size = new System.Drawing.Size(121, 21);
            this.comboxSingleWeaponSecondary.TabIndex = 23;
            this.comboxSingleWeaponSecondary.SelectedIndexChanged += new System.EventHandler(this.comboxSingleWeaponSecondary_SelectedIndexChanged);
            this.comboxSingleWeaponSecondary.Click += new System.EventHandler(this.CacheCurrentIndex);
            // 
            // lSingleWeaponSecondary
            // 
            this.lSingleWeaponSecondary.AutoSize = true;
            this.lSingleWeaponSecondary.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSingleWeaponSecondary.Location = new System.Drawing.Point(300, 21);
            this.lSingleWeaponSecondary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSingleWeaponSecondary.Name = "lSingleWeaponSecondary";
            this.lSingleWeaponSecondary.Size = new System.Drawing.Size(70, 17);
            this.lSingleWeaponSecondary.TabIndex = 8;
            this.lSingleWeaponSecondary.Text = "Secondary";
            // 
            // comboxSingleWeaponPrimary
            // 
            this.comboxSingleWeaponPrimary.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxSingleWeaponPrimary.FormattingEnabled = true;
            this.comboxSingleWeaponPrimary.Items.AddRange(new object[] {
            "------------------------"});
            this.comboxSingleWeaponPrimary.Location = new System.Drawing.Point(173, 40);
            this.comboxSingleWeaponPrimary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxSingleWeaponPrimary.Name = "comboxSingleWeaponPrimary";
            this.comboxSingleWeaponPrimary.Size = new System.Drawing.Size(121, 21);
            this.comboxSingleWeaponPrimary.TabIndex = 20;
            this.comboxSingleWeaponPrimary.SelectedIndexChanged += new System.EventHandler(this.comboxSingleWeaponPrimary_SelectedIndexChanged);
            this.comboxSingleWeaponPrimary.Click += new System.EventHandler(this.CacheCurrentIndex);
            // 
            // lSingleWeapons
            // 
            this.lSingleWeapons.AutoSize = true;
            this.lSingleWeapons.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSingleWeapons.Location = new System.Drawing.Point(169, 0);
            this.lSingleWeapons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSingleWeapons.Name = "lSingleWeapons";
            this.lSingleWeapons.Size = new System.Drawing.Size(165, 21);
            this.lSingleWeapons.TabIndex = 8;
            this.lSingleWeapons.Text = "Single Weapon only";
            // 
            // lSingleWeaponPrimary
            // 
            this.lSingleWeaponPrimary.AutoSize = true;
            this.lSingleWeaponPrimary.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSingleWeaponPrimary.Location = new System.Drawing.Point(170, 21);
            this.lSingleWeaponPrimary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSingleWeaponPrimary.Name = "lSingleWeaponPrimary";
            this.lSingleWeaponPrimary.Size = new System.Drawing.Size(52, 17);
            this.lSingleWeaponPrimary.TabIndex = 8;
            this.lSingleWeaponPrimary.Text = "Primary";
            // 
            // lWeaponLoadOut
            // 
            this.lWeaponLoadOut.AutoSize = true;
            this.lWeaponLoadOut.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lWeaponLoadOut.Location = new System.Drawing.Point(3, 0);
            this.lWeaponLoadOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWeaponLoadOut.Name = "lWeaponLoadOut";
            this.lWeaponLoadOut.Size = new System.Drawing.Size(86, 21);
            this.lWeaponLoadOut.TabIndex = 8;
            this.lWeaponLoadOut.Text = "LOADOUT";
            // 
            // bDisable
            // 
            this.bDisable.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDisable.Location = new System.Drawing.Point(85, 24);
            this.bDisable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bDisable.Name = "bDisable";
            this.bDisable.Size = new System.Drawing.Size(75, 23);
            this.bDisable.TabIndex = 19;
            this.bDisable.Text = "Disable All";
            this.bDisable.Click += new System.EventHandler(this.bDisable_Click);
            // 
            // bDefault
            // 
            this.bDefault.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDefault.Location = new System.Drawing.Point(7, 24);
            this.bDefault.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bDefault.Name = "bDefault";
            this.bDefault.Size = new System.Drawing.Size(75, 23);
            this.bDefault.TabIndex = 18;
            this.bDefault.Text = "Set Default";
            this.bDefault.Click += new System.EventHandler(this.bDefault_Click);
            // 
            // bGeneratePatch
            // 
            this.bGeneratePatch.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bGeneratePatch.Location = new System.Drawing.Point(15, 392);
            this.bGeneratePatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGeneratePatch.Name = "bGeneratePatch";
            this.bGeneratePatch.Size = new System.Drawing.Size(153, 30);
            this.bGeneratePatch.TabIndex = 24;
            this.bGeneratePatch.Text = "Generate File(s)";
            this.bGeneratePatch.Click += new System.EventHandler(this.bGeneratePatch_Click);
            // 
            // lInputFile
            // 
            this.lInputFile.AutoSize = true;
            this.lInputFile.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lInputFile.Location = new System.Drawing.Point(10, 6);
            this.lInputFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lInputFile.Name = "lInputFile";
            this.lInputFile.Size = new System.Drawing.Size(97, 17);
            this.lInputFile.TabIndex = 24;
            this.lInputFile.Text = "Input Patchfile:";
            // 
            // tbPathPatchFile
            // 
            this.tbPathPatchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPathPatchFile.Location = new System.Drawing.Point(105, 5);
            this.tbPathPatchFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPathPatchFile.Name = "tbPathPatchFile";
            this.tbPathPatchFile.Size = new System.Drawing.Size(694, 21);
            this.tbPathPatchFile.TabIndex = 2;
            this.tbPathPatchFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPathPatchFile_KeyDown);
            // 
            // bPathPatch
            // 
            this.bPathPatch.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPathPatch.Location = new System.Drawing.Point(805, 4);
            this.bPathPatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bPathPatch.Name = "bPathPatch";
            this.bPathPatch.Size = new System.Drawing.Size(27, 23);
            this.bPathPatch.TabIndex = 24;
            this.bPathPatch.Text = "..";
            this.bPathPatch.Click += new System.EventHandler(this.bPathPatch_Click);
            // 
            // lOutPutFolderName
            // 
            this.lOutPutFolderName.AutoSize = true;
            this.lOutPutFolderName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOutPutFolderName.Location = new System.Drawing.Point(10, 31);
            this.lOutPutFolderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOutPutFolderName.Name = "lOutPutFolderName";
            this.lOutPutFolderName.Size = new System.Drawing.Size(93, 17);
            this.lOutPutFolderName.TabIndex = 26;
            this.lOutPutFolderName.Text = "Output Name:";
            // 
            // tbOutputName
            // 
            this.tbOutputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOutputName.Location = new System.Drawing.Point(105, 30);
            this.tbOutputName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbOutputName.Name = "tbOutputName";
            this.tbOutputName.Size = new System.Drawing.Size(164, 21);
            this.tbOutputName.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 335);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pWeaponPanels);
            this.tabPage1.Controls.Add(this.pLoadOutControls);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(822, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weapons";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pLoadOutControls
            // 
            this.pLoadOutControls.Controls.Add(this.lWeaponLoadOut);
            this.pLoadOutControls.Controls.Add(this.comboxSingleWeaponSecondary);
            this.pLoadOutControls.Controls.Add(this.bDefault);
            this.pLoadOutControls.Controls.Add(this.lSingleWeaponSecondary);
            this.pLoadOutControls.Controls.Add(this.bDisable);
            this.pLoadOutControls.Controls.Add(this.comboxSingleWeaponPrimary);
            this.pLoadOutControls.Controls.Add(this.lSingleWeaponPrimary);
            this.pLoadOutControls.Controls.Add(this.lSingleWeapons);
            this.pLoadOutControls.Location = new System.Drawing.Point(0, 0);
            this.pLoadOutControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pLoadOutControls.Name = "pLoadOutControls";
            this.pLoadOutControls.Size = new System.Drawing.Size(429, 65);
            this.pLoadOutControls.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pWaitTimes);
            this.tabPage2.Controls.Add(this.comboxDefaultZoneDeathTime);
            this.tabPage2.Controls.Add(this.tbZoneDeathTimes);
            this.tabPage2.Controls.Add(this.lZones);
            this.tabPage2.Controls.Add(this.comboxDefaultDaytimeSpeed);
            this.tabPage2.Controls.Add(this.comboxDefaultRespawnTime);
            this.tabPage2.Controls.Add(this.comboxDefaultSpawnShield);
            this.tabPage2.Controls.Add(this.tbSpawnShields);
            this.tabPage2.Controls.Add(this.lShields);
            this.tabPage2.Controls.Add(this.tbRespawnTimes);
            this.tabPage2.Controls.Add(this.lRespawnTimes);
            this.tabPage2.Controls.Add(this.bGenerateDayTimeNames);
            this.tabPage2.Controls.Add(this.bDayTimeAddAll);
            this.tabPage2.Controls.Add(this.tbDayTimeNames);
            this.tabPage2.Controls.Add(this.lDayTimeNames);
            this.tabPage2.Controls.Add(this.tbDayTimeValues);
            this.tabPage2.Controls.Add(this.lDayTime);
            this.tabPage2.Controls.Add(this.lCollectionInfo);
            this.tabPage2.Controls.Add(this.tbDaytimeSpeed);
            this.tabPage2.Controls.Add(this.lDayTimeSpeed);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(822, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Collections";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pWaitTimes
            // 
            this.pWaitTimes.Controls.Add(this.comboxDefaultPreRoundTime);
            this.pWaitTimes.Controls.Add(this.comboxDefaultPostRoundTime);
            this.pWaitTimes.Controls.Add(this.tbPostRoundTimes);
            this.pWaitTimes.Controls.Add(this.lPostRoundTimes);
            this.pWaitTimes.Controls.Add(this.tbPreRoundTimes);
            this.pWaitTimes.Controls.Add(this.lPreRound);
            this.pWaitTimes.Location = new System.Drawing.Point(2, 176);
            this.pWaitTimes.Name = "pWaitTimes";
            this.pWaitTimes.Size = new System.Drawing.Size(815, 128);
            this.pWaitTimes.TabIndex = 46;
            // 
            // comboxDefaultPreRoundTime
            // 
            this.comboxDefaultPreRoundTime.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxDefaultPreRoundTime.FormattingEnabled = true;
            this.comboxDefaultPreRoundTime.Location = new System.Drawing.Point(618, 2);
            this.comboxDefaultPreRoundTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxDefaultPreRoundTime.Name = "comboxDefaultPreRoundTime";
            this.comboxDefaultPreRoundTime.Size = new System.Drawing.Size(92, 21);
            this.comboxDefaultPreRoundTime.TabIndex = 47;
            // 
            // comboxDefaultPostRoundTime
            // 
            this.comboxDefaultPostRoundTime.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxDefaultPostRoundTime.FormattingEnabled = true;
            this.comboxDefaultPostRoundTime.Location = new System.Drawing.Point(618, 29);
            this.comboxDefaultPostRoundTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxDefaultPostRoundTime.Name = "comboxDefaultPostRoundTime";
            this.comboxDefaultPostRoundTime.Size = new System.Drawing.Size(92, 21);
            this.comboxDefaultPostRoundTime.TabIndex = 46;
            // 
            // tbPostRoundTimes
            // 
            this.tbPostRoundTimes.Location = new System.Drawing.Point(115, 29);
            this.tbPostRoundTimes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPostRoundTimes.Name = "tbPostRoundTimes";
            this.tbPostRoundTimes.Size = new System.Drawing.Size(495, 20);
            this.tbPostRoundTimes.TabIndex = 44;
            this.tbPostRoundTimes.TextChanged += new System.EventHandler(this.tbPostRoundTimes_TextChanged);
            this.tbPostRoundTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPreventChars);
            // 
            // lPostRoundTimes
            // 
            this.lPostRoundTimes.AutoSize = true;
            this.lPostRoundTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lPostRoundTimes.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lPostRoundTimes.Location = new System.Drawing.Point(0, 30);
            this.lPostRoundTimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPostRoundTimes.Name = "lPostRoundTimes";
            this.lPostRoundTimes.Size = new System.Drawing.Size(117, 17);
            this.lPostRoundTimes.TabIndex = 45;
            this.lPostRoundTimes.Text = "Postround Times:";
            this.lPostRoundTimes.Click += new System.EventHandler(this.lPostRoundTimes_Click);
            // 
            // tbPreRoundTimes
            // 
            this.tbPreRoundTimes.Location = new System.Drawing.Point(115, 3);
            this.tbPreRoundTimes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPreRoundTimes.Name = "tbPreRoundTimes";
            this.tbPreRoundTimes.Size = new System.Drawing.Size(495, 20);
            this.tbPreRoundTimes.TabIndex = 42;
            this.tbPreRoundTimes.TextChanged += new System.EventHandler(this.tbPreRoundTimes_TextChanged);
            this.tbPreRoundTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPreventChars);
            // 
            // lPreRound
            // 
            this.lPreRound.AutoSize = true;
            this.lPreRound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lPreRound.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lPreRound.Location = new System.Drawing.Point(0, 4);
            this.lPreRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPreRound.Name = "lPreRound";
            this.lPreRound.Size = new System.Drawing.Size(110, 17);
            this.lPreRound.TabIndex = 43;
            this.lPreRound.Text = "Preround Times:";
            this.lPreRound.Click += new System.EventHandler(this.lPreRound_Click);
            // 
            // comboxDefaultZoneDeathTime
            // 
            this.comboxDefaultZoneDeathTime.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxDefaultZoneDeathTime.FormattingEnabled = true;
            this.comboxDefaultZoneDeathTime.Location = new System.Drawing.Point(620, 153);
            this.comboxDefaultZoneDeathTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxDefaultZoneDeathTime.Name = "comboxDefaultZoneDeathTime";
            this.comboxDefaultZoneDeathTime.Size = new System.Drawing.Size(92, 21);
            this.comboxDefaultZoneDeathTime.TabIndex = 45;
            // 
            // tbZoneDeathTimes
            // 
            this.tbZoneDeathTimes.Location = new System.Drawing.Point(117, 153);
            this.tbZoneDeathTimes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbZoneDeathTimes.Name = "tbZoneDeathTimes";
            this.tbZoneDeathTimes.Size = new System.Drawing.Size(495, 20);
            this.tbZoneDeathTimes.TabIndex = 43;
            this.tbZoneDeathTimes.TextChanged += new System.EventHandler(this.tbZoneDeathTimes_TextChanged);
            this.tbZoneDeathTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPreventChars);
            // 
            // lZones
            // 
            this.lZones.AutoSize = true;
            this.lZones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lZones.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lZones.Location = new System.Drawing.Point(2, 154);
            this.lZones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lZones.Name = "lZones";
            this.lZones.Size = new System.Drawing.Size(116, 17);
            this.lZones.TabIndex = 44;
            this.lZones.Text = "ZoneDeathTimes:";
            this.lZones.Click += new System.EventHandler(this.lZones_Click);
            // 
            // comboxDefaultDaytimeSpeed
            // 
            this.comboxDefaultDaytimeSpeed.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxDefaultDaytimeSpeed.FormattingEnabled = true;
            this.comboxDefaultDaytimeSpeed.Location = new System.Drawing.Point(620, 74);
            this.comboxDefaultDaytimeSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxDefaultDaytimeSpeed.Name = "comboxDefaultDaytimeSpeed";
            this.comboxDefaultDaytimeSpeed.Size = new System.Drawing.Size(92, 21);
            this.comboxDefaultDaytimeSpeed.TabIndex = 42;
            // 
            // comboxDefaultRespawnTime
            // 
            this.comboxDefaultRespawnTime.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxDefaultRespawnTime.FormattingEnabled = true;
            this.comboxDefaultRespawnTime.Location = new System.Drawing.Point(620, 100);
            this.comboxDefaultRespawnTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxDefaultRespawnTime.Name = "comboxDefaultRespawnTime";
            this.comboxDefaultRespawnTime.Size = new System.Drawing.Size(92, 21);
            this.comboxDefaultRespawnTime.TabIndex = 41;
            // 
            // comboxDefaultSpawnShield
            // 
            this.comboxDefaultSpawnShield.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxDefaultSpawnShield.FormattingEnabled = true;
            this.comboxDefaultSpawnShield.Location = new System.Drawing.Point(620, 127);
            this.comboxDefaultSpawnShield.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxDefaultSpawnShield.Name = "comboxDefaultSpawnShield";
            this.comboxDefaultSpawnShield.Size = new System.Drawing.Size(92, 21);
            this.comboxDefaultSpawnShield.TabIndex = 40;
            // 
            // tbSpawnShields
            // 
            this.tbSpawnShields.Location = new System.Drawing.Point(117, 127);
            this.tbSpawnShields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSpawnShields.Name = "tbSpawnShields";
            this.tbSpawnShields.Size = new System.Drawing.Size(495, 20);
            this.tbSpawnShields.TabIndex = 38;
            this.tbSpawnShields.TextChanged += new System.EventHandler(this.tbSpawnShields_TextChanged);
            this.tbSpawnShields.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPreventChars);
            // 
            // lShields
            // 
            this.lShields.AutoSize = true;
            this.lShields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lShields.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lShields.Location = new System.Drawing.Point(2, 128);
            this.lShields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShields.Name = "lShields";
            this.lShields.Size = new System.Drawing.Size(95, 17);
            this.lShields.TabIndex = 39;
            this.lShields.Text = "SpawnShields:";
            this.lShields.Click += new System.EventHandler(this.lShields_Click);
            // 
            // tbRespawnTimes
            // 
            this.tbRespawnTimes.Location = new System.Drawing.Point(117, 101);
            this.tbRespawnTimes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbRespawnTimes.Name = "tbRespawnTimes";
            this.tbRespawnTimes.Size = new System.Drawing.Size(495, 20);
            this.tbRespawnTimes.TabIndex = 36;
            this.tbRespawnTimes.TextChanged += new System.EventHandler(this.tbRespawnTimes_TextChanged);
            this.tbRespawnTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPreventChars);
            // 
            // lRespawnTimes
            // 
            this.lRespawnTimes.AutoSize = true;
            this.lRespawnTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lRespawnTimes.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lRespawnTimes.Location = new System.Drawing.Point(2, 102);
            this.lRespawnTimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRespawnTimes.Name = "lRespawnTimes";
            this.lRespawnTimes.Size = new System.Drawing.Size(102, 17);
            this.lRespawnTimes.TabIndex = 37;
            this.lRespawnTimes.Text = "RespawnTimes:";
            this.lRespawnTimes.Click += new System.EventHandler(this.lRespawnTime_Click);
            // 
            // bGenerateDayTimeNames
            // 
            this.bGenerateDayTimeNames.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bGenerateDayTimeNames.Location = new System.Drawing.Point(718, 48);
            this.bGenerateDayTimeNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGenerateDayTimeNames.Name = "bGenerateDayTimeNames";
            this.bGenerateDayTimeNames.Size = new System.Drawing.Size(97, 23);
            this.bGenerateDayTimeNames.TabIndex = 35;
            this.bGenerateDayTimeNames.Text = "Generate";
            this.bGenerateDayTimeNames.Click += new System.EventHandler(this.bGenerateDayTimeNames_Click);
            // 
            // bDayTimeAddAll
            // 
            this.bDayTimeAddAll.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDayTimeAddAll.Location = new System.Drawing.Point(718, 22);
            this.bDayTimeAddAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bDayTimeAddAll.Name = "bDayTimeAddAll";
            this.bDayTimeAddAll.Size = new System.Drawing.Size(97, 23);
            this.bDayTimeAddAll.TabIndex = 30;
            this.bDayTimeAddAll.Text = "Add All";
            this.bDayTimeAddAll.Click += new System.EventHandler(this.bDayTimeAddAll_Click);
            // 
            // tbDayTimeNames
            // 
            this.tbDayTimeNames.Location = new System.Drawing.Point(117, 49);
            this.tbDayTimeNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDayTimeNames.Name = "tbDayTimeNames";
            this.tbDayTimeNames.Size = new System.Drawing.Size(595, 20);
            this.tbDayTimeNames.TabIndex = 33;
            // 
            // lDayTimeNames
            // 
            this.lDayTimeNames.AutoSize = true;
            this.lDayTimeNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lDayTimeNames.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDayTimeNames.Location = new System.Drawing.Point(2, 50);
            this.lDayTimeNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDayTimeNames.Name = "lDayTimeNames";
            this.lDayTimeNames.Size = new System.Drawing.Size(113, 17);
            this.lDayTimeNames.TabIndex = 34;
            this.lDayTimeNames.Text = "DayTime Names:";
            this.lDayTimeNames.Click += new System.EventHandler(this.lDayTimeNames_Click);
            // 
            // tbDayTimeValues
            // 
            this.tbDayTimeValues.Location = new System.Drawing.Point(117, 23);
            this.tbDayTimeValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDayTimeValues.Name = "tbDayTimeValues";
            this.tbDayTimeValues.Size = new System.Drawing.Size(595, 20);
            this.tbDayTimeValues.TabIndex = 31;
            // 
            // lDayTime
            // 
            this.lDayTime.AutoSize = true;
            this.lDayTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lDayTime.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDayTime.Location = new System.Drawing.Point(2, 24);
            this.lDayTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDayTime.Name = "lDayTime";
            this.lDayTime.Size = new System.Drawing.Size(108, 17);
            this.lDayTime.TabIndex = 32;
            this.lDayTime.Text = "DayTime Hours:";
            this.lDayTime.Click += new System.EventHandler(this.lDayTime_Click);
            // 
            // lCollectionInfo
            // 
            this.lCollectionInfo.AutoSize = true;
            this.lCollectionInfo.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCollectionInfo.Location = new System.Drawing.Point(2, 3);
            this.lCollectionInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCollectionInfo.Name = "lCollectionInfo";
            this.lCollectionInfo.Size = new System.Drawing.Size(234, 17);
            this.lCollectionInfo.TabIndex = 30;
            this.lCollectionInfo.Text = "Add values to collections ( Split by ; )";
            // 
            // tbDaytimeSpeed
            // 
            this.tbDaytimeSpeed.Location = new System.Drawing.Point(117, 75);
            this.tbDaytimeSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDaytimeSpeed.Name = "tbDaytimeSpeed";
            this.tbDaytimeSpeed.Size = new System.Drawing.Size(495, 20);
            this.tbDaytimeSpeed.TabIndex = 27;
            this.tbDaytimeSpeed.TextChanged += new System.EventHandler(this.tbDaytimeSpeed_TextChanged);
            this.tbDaytimeSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPreventChars);
            // 
            // lDayTimeSpeed
            // 
            this.lDayTimeSpeed.AutoSize = true;
            this.lDayTimeSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lDayTimeSpeed.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDayTimeSpeed.Location = new System.Drawing.Point(2, 76);
            this.lDayTimeSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDayTimeSpeed.Name = "lDayTimeSpeed";
            this.lDayTimeSpeed.Size = new System.Drawing.Size(105, 17);
            this.lDayTimeSpeed.TabIndex = 28;
            this.lDayTimeSpeed.Text = "Daytime Speed:";
            this.lDayTimeSpeed.Click += new System.EventHandler(this.lDayTimeSpeed_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(822, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "fc2sl";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbDebugOutPut
            // 
            this.tbDebugOutPut.Location = new System.Drawing.Point(741, 30);
            this.tbDebugOutPut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDebugOutPut.Multiline = true;
            this.tbDebugOutPut.Name = "tbDebugOutPut";
            this.tbDebugOutPut.Size = new System.Drawing.Size(91, 39);
            this.tbDebugOutPut.TabIndex = 26;
            this.tbDebugOutPut.Visible = false;
            // 
            // bSettings
            // 
            this.bSettings.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSettings.Location = new System.Drawing.Point(771, 47);
            this.bSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(61, 23);
            this.bSettings.TabIndex = 33;
            this.bSettings.Text = "Settings";
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // pbOpenGenerationFolder
            // 
            this.pbOpenGenerationFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOpenGenerationFolder.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenGenerationFolder.Image")));
            this.pbOpenGenerationFolder.Location = new System.Drawing.Point(275, 32);
            this.pbOpenGenerationFolder.Name = "pbOpenGenerationFolder";
            this.pbOpenGenerationFolder.Size = new System.Drawing.Size(16, 16);
            this.pbOpenGenerationFolder.TabIndex = 34;
            this.pbOpenGenerationFolder.TabStop = false;
            this.pbOpenGenerationFolder.Click += new System.EventHandler(this.pbOpenGenerationFolder_Click);
            // 
            // lModCollection
            // 
            this.lModCollection.AutoSize = true;
            this.lModCollection.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lModCollection.Location = new System.Drawing.Point(309, 31);
            this.lModCollection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lModCollection.Name = "lModCollection";
            this.lModCollection.Size = new System.Drawing.Size(112, 17);
            this.lModCollection.TabIndex = 36;
            this.lModCollection.Text = "Generated Mods:";
            // 
            // bLoadReport
            // 
            this.bLoadReport.Enabled = false;
            this.bLoadReport.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bLoadReport.Location = new System.Drawing.Point(544, 29);
            this.bLoadReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bLoadReport.Name = "bLoadReport";
            this.bLoadReport.Size = new System.Drawing.Size(44, 23);
            this.bLoadReport.TabIndex = 38;
            this.bLoadReport.Text = "Load";
            this.bLoadReport.Click += new System.EventHandler(this.bLoadReport_Click);
            // 
            // bInstall
            // 
            this.bInstall.Enabled = false;
            this.bInstall.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bInstall.Location = new System.Drawing.Point(591, 29);
            this.bInstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bInstall.Name = "bInstall";
            this.bInstall.Size = new System.Drawing.Size(50, 23);
            this.bInstall.TabIndex = 39;
            this.bInstall.Text = "Install";
            this.bInstall.Click += new System.EventHandler(this.bInstall_Click);
            // 
            // comboxModCollection
            // 
            this.comboxModCollection.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxModCollection.FormattingEnabled = true;
            this.comboxModCollection.Location = new System.Drawing.Point(423, 30);
            this.comboxModCollection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxModCollection.Name = "comboxModCollection";
            this.comboxModCollection.Size = new System.Drawing.Size(117, 21);
            this.comboxModCollection.TabIndex = 40;
            this.comboxModCollection.SelectedIndexChanged += new System.EventHandler(this.comboxModCollection_SelectedIndexChanged);
            this.comboxModCollection.DropDownClosed += new System.EventHandler(this.UnselectText);
            this.comboxModCollection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreventKey);
            // 
            // lCredits
            // 
            this.lCredits.AutoSize = true;
            this.lCredits.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lCredits.Location = new System.Drawing.Point(501, 396);
            this.lCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCredits.Name = "lCredits";
            this.lCredits.Size = new System.Drawing.Size(200, 23);
            this.lCredits.TabIndex = 41;
            this.lCredits.Text = "Created by FEARIV";
            // 
            // lDiscordLink
            // 
            this.lDiscordLink.AutoSize = true;
            this.lDiscordLink.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDiscordLink.Location = new System.Drawing.Point(700, 395);
            this.lDiscordLink.Name = "lDiscordLink";
            this.lDiscordLink.Size = new System.Drawing.Size(142, 22);
            this.lDiscordLink.TabIndex = 42;
            this.lDiscordLink.TabStop = true;
            this.lDiscordLink.Text = "https://dsc.gg/FC2";
            this.lDiscordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lDiscordLink_LinkClicked);
            // 
            // GeneratorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 426);
            this.Controls.Add(this.lDiscordLink);
            this.Controls.Add(this.lCredits);
            this.Controls.Add(this.comboxModCollection);
            this.Controls.Add(this.bInstall);
            this.Controls.Add(this.bLoadReport);
            this.Controls.Add(this.lModCollection);
            this.Controls.Add(this.pbOpenGenerationFolder);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.tbDebugOutPut);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbOutputName);
            this.Controls.Add(this.bGeneratePatch);
            this.Controls.Add(this.lOutPutFolderName);
            this.Controls.Add(this.bPathPatch);
            this.Controls.Add(this.tbPathPatchFile);
            this.Controls.Add(this.lInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "GeneratorGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FarCry2 ServerMod-Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pLoadOutControls.ResumeLayout(false);
            this.pLoadOutControls.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pWaitTimes.ResumeLayout(false);
            this.pWaitTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenGenerationFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Glass.GlassButton bDisable;
        private Glass.GlassButton bDefault;
        private System.Windows.Forms.Label lWeaponLoadOut;
        private System.Windows.Forms.ComboBox comboxSingleWeaponSecondary;
        private System.Windows.Forms.Label lSingleWeaponSecondary;
        private System.Windows.Forms.ComboBox comboxSingleWeaponPrimary;
        private System.Windows.Forms.Label lSingleWeapons;
        private System.Windows.Forms.Label lSingleWeaponPrimary;
        private System.Windows.Forms.Label lInputFile;
        private System.Windows.Forms.TextBox tbPathPatchFile;
        private Glass.GlassButton bPathPatch;
        private System.Windows.Forms.Label lOutPutFolderName;
        private System.Windows.Forms.TextBox tbOutputName;
        private Glass.GlassButton bGeneratePatch;
        private System.Windows.Forms.Panel pWeaponPanels;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pLoadOutControls;
        private System.Windows.Forms.TextBox tbDaytimeSpeed;
        private System.Windows.Forms.Label lDayTimeSpeed;
        private System.Windows.Forms.TextBox tbDebugOutPut;
        private System.Windows.Forms.Label lCollectionInfo;
        private Glass.GlassButton bDayTimeAddAll;
        private System.Windows.Forms.TextBox tbDayTimeNames;
        private System.Windows.Forms.Label lDayTimeNames;
        private System.Windows.Forms.TextBox tbDayTimeValues;
        private System.Windows.Forms.Label lDayTime;
        private Glass.GlassButton bGenerateDayTimeNames;
        private System.Windows.Forms.TextBox tbSpawnShields;
        private System.Windows.Forms.Label lShields;
        private System.Windows.Forms.TextBox tbRespawnTimes;
        private System.Windows.Forms.Label lRespawnTimes;
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
    }
}

