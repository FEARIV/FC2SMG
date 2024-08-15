using FC2modHandler;
using FC2SMG.GUI;
using FC2SMG.Reports;
using ServerModGenerator.GUI;
using System.Diagnostics;

// Add option for knife-only weapon mod.
// Add option to select grenade or molotov (or disable?) and maybe amount too.

namespace ServerModGenerator
{
    public partial class GeneratorGUI : Form
    {
        public ComboBox[] WeaponDropdownAll { get; set; }
        public ComboBox[] PrimaryAllLoadout { get; set; }
        public ComboBox[] Primary1Loadout { get; set; }
        public ComboBox[] Primary2Loadout { get; set; }
        public ComboBox[] Primary3Loadout { get; set; }
        public ComboBox[] FiltersPrimary { get; set; }
        public ComboBox[] SecondaryAllLoadout { get; set; }
        public ComboBox[] Secondary1Loadout { get; set; }
        public ComboBox[] Secondary2Loadout { get; set; }
        public ComboBox[] FiltersSecondary { get; set; }

        private Dictionary<TextBox, ComboBox> _textBoxComboBoxMap;
        public TextBox[] SettingsCollection = Array.Empty<TextBox>();
        private GeneratorController controller;
        private WeaponCollections weaponCollections;
        private fc2slPanel fc2slpanel;
        private XMLParser XMLparser;
        private Settings settings;
        internal ReportManager reportManager;

        // ========== NEW ==========
        public List<WeaponPanel> AllClassLoadOuts = new();

        public GeneratorGUI()
        {
            InitializeComponent();
            Text += " " + Strings.SMG_Version;
            settings = new(this);
            controller = new GeneratorController(this);
            pWeaponPanels.AutoScroll = true;
            controller = new GeneratorController(this);
            weaponCollections = new WeaponCollections();
            SettingsCollection = new TextBox[] { tbDaytimeSpeed, tbRespawnTimes, tbSpawnShields, tbZoneDeathTimes, tbScoresCTD, tbPreRoundTimes, tbPostRoundTimes }; // tbDayTimeValues, tbDayTimeNames, 
            XMLparser = new XMLParser(this);
            reportManager = new(this);
            controller.AddDefaultLoadout();
            FillDropDownCollections();
            controller.FillDropDowns();
            SetDefaultDropDownIndex();
            ArrangeDropDownEvents();
            InitializeTextBoxComboBoxMap();
            foreach (TextBox valueCollection in SettingsCollection)
            {
                valueCollection.KeyPress += KeyPressPreventChars;
                valueCollection.TextChanged += TextChangedValidateInput;
            }
            foreach (var textBox in _textBoxComboBoxMap.Keys)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }
            tbPathPatchFile.ContextMenuStrip = new ContextMenuStrip();
            fc2slpanel = new(this);
            tabPage3.Controls.Add(fc2slpanel);
            AddGeneratedMods();
        }

        private void InitializeTextBoxComboBoxMap()
        {
            _textBoxComboBoxMap = new Dictionary<TextBox, ComboBox>
            {
                { tbRespawnTimes, comboxDefaultRespawnTime },
                { tbSpawnShields, comboxDefaultSpawnShield },
                { tbDaytimeSpeed, comboxDefaultDaytimeSpeed },
                { tbZoneDeathTimes, comboxDefaultZoneDeathTime },
                { tbPreRoundTimes, comboxDefaultPreRoundTime },
                { tbPostRoundTimes, comboxDefaultPostRoundTime },
                { tbScoresDM, comboxDefaultScoreDM },
                { tbScoresTDM, comboxDefaultScoreTDM },
                { tbScoresCTD, comboxDefaultScoreCTD },
                { tbScoresUPR, comboxDefaultScoreUPR }
            };
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && _textBoxComboBoxMap.TryGetValue(textBox, out ComboBox comboBox))
            {
                UpdateLinkedDropdownValues(textBox, comboBox);
            }
        }

        private void FillDropDownCollections()
        {
            PrimaryAllLoadout = CollectWeaponDropdowns(weaponPanel => weaponPanel.GetPrimaryWeaponDropDowns(),
                new List<ComboBox> { comboxFilterWeaponPrimaryAll }
            );
            SecondaryAllLoadout = CollectWeaponDropdowns(weaponPanel => weaponPanel.GetSecondaryWeaponDropDowns(),
                new List<ComboBox> { comboxFilterWeaponSecondaryAll }
            );
            WeaponDropdownAll = CollectWeaponDropdowns(weaponPanel => weaponPanel.GetAllWeaponDropDowns());
            Primary1Loadout = CollectWeaponDropdowns(weaponPanel => new[] { weaponPanel.GetFirstPrimaryWeaponDropDown() });
            Primary2Loadout = CollectWeaponDropdowns(weaponPanel => new[] { weaponPanel.GetSecondPrimaryWeaponDropDown() });
            Primary3Loadout = CollectWeaponDropdowns(weaponPanel => new[] { weaponPanel.GetFinalPrimaryWeaponDropDown() });
            Secondary1Loadout = CollectWeaponDropdowns(weaponPanel => new[] { weaponPanel.GetFirstSecondaryWeaponDropdown() });
            Secondary2Loadout = CollectWeaponDropdowns(weaponPanel => new[] { weaponPanel.GetUpgradedSecondaryWeaponDropdown() });
            FiltersPrimary = new ComboBox[] { comboxFilterWeaponPrimary1, comboxFilterWeaponPrimary2, comboxFilterWeaponPrimary3 };
            FiltersSecondary = new ComboBox[] { comboxFilterWeaponSecondary1, comboxFilterWeaponSecondary2 };
        }

        private ComboBox[] CollectWeaponDropdowns(Func<WeaponPanel, IEnumerable<ComboBox>> selector, List<ComboBox>? initialDropdowns = null)
        {
            // Initialize the list if not provided
            initialDropdowns ??= new List<ComboBox>();

            foreach (WeaponPanel weaponPanel in AllClassLoadOuts)
            {
                initialDropdowns.AddRange(selector(weaponPanel));
            }

            return initialDropdowns.ToArray();
        }

        internal void AddWeaponPanel(WeaponPanel weaponPanel)
        {
            pWeaponPanels.Controls.Add(weaponPanel);
            AllClassLoadOuts.Add(weaponPanel);
        }

        public void AddDebugOutPut(string content)
        {
            tbDebugOutPut.Text += content + Environment.NewLine;
        }

        private void SetDefaultDropDownIndex()
        {
            foreach (ComboBox combobox in WeaponDropdownAll)
            {
                combobox.SelectedIndex = 0;
            }
            comboxFilterWeaponPrimaryAll.SelectedIndex = 0;
            comboxFilterWeaponPrimary1.SelectedIndex = 0;
            comboxFilterWeaponPrimary2.SelectedIndex = 0;
            comboxFilterWeaponPrimary3.SelectedIndex = 0;
            comboxFilterWeaponSecondaryAll.SelectedIndex = 0;
            comboxFilterWeaponSecondary1.SelectedIndex = 0;
            comboxFilterWeaponSecondary2.SelectedIndex = 0;
        }

        private bool IsAnyWeaponReplaced()
        {
            foreach (ComboBox cb in WeaponDropdownAll)
            {
                if (cb.SelectedIndex > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsAnyCollectionAdded()
        {
            foreach (TextBox tb in SettingsCollection)
            {
                if (tb.Text.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void bDefault_Click(object sender, EventArgs e)
        {
            SetDefaultDropDownIndex();
        }

        private void bDisable_Click(object sender, EventArgs e)
        {
            foreach (ComboBox combobox in WeaponDropdownAll)
            {
                combobox.SelectedIndex = combobox.Items.Count - 1;
            }
        }

        private void comboxFilterWeaponPrimaryAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSingleWeaponIndexChanged(comboxFilterWeaponPrimaryAll, FiltersPrimary);
        }

        private void comboxFilterWeaponPrimary1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSingleWeaponIndexChanged(comboxFilterWeaponPrimary1, Primary1Loadout);
        }

        private void comboxFilterWeaponPrimary2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSingleWeaponIndexChanged(comboxFilterWeaponPrimary2, Primary2Loadout);
        }

        private void comboxFilterWeaponPrimary3_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSingleWeaponIndexChanged(comboxFilterWeaponPrimary3, Primary3Loadout);
        }

        private void comboxFilterWeaponSecondaryAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSingleWeaponIndexChanged(comboxFilterWeaponSecondaryAll, FiltersSecondary);
        }

        private void comboxFilterWeaponSecondary1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSingleWeaponIndexChanged(comboxFilterWeaponSecondary1, Secondary1Loadout);
        }

        private void comboxFilterWeaponSecondary2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSingleWeaponIndexChanged(comboxFilterWeaponSecondary2, Secondary2Loadout);
        }

        private void HandleSingleWeaponIndexChanged(ComboBox sourceSingleWeaponDropdown, ComboBox[] collectionWeaponDropdowns)
        {
            if (!sourceSingleWeaponDropdown.Text.StartsWith("-"))
            {
                if (!sourceSingleWeaponDropdown.Text.StartsWith("="))
                {
                    foreach (ComboBox combobox in collectionWeaponDropdowns)
                    {
                        if (combobox.Text != sourceSingleWeaponDropdown.Text)
                        {
                            combobox.SelectedIndex = combobox.Items.IndexOf(sourceSingleWeaponDropdown.Text);
                        }
                    }
                }
                else
                {
                    sourceSingleWeaponDropdown.SelectedIndex = CachedDropDownIndex;
                }
            }
        }

        public WeaponCollections GetWeaponCollections()
        {
            return weaponCollections;
        }

        internal fc2slPanel getLauncherPanel()
        {
            return fc2slpanel;
        }

        internal string GetModFolderName()
        {
            return tbOutputName.Text;
        }

        private void bGeneratePatch_Click(object sender, EventArgs e)
        {
            if (!IsValidStateToGenerate())
            {
                return;
            }

            if (IsAnyWeaponReplaced() || IsAnyCollectionAdded())
            {
                GibbedPatchHandler gibbedPatchHandler = new();

                // Copy patchfiles to temp.
                string result = gibbedPatchHandler.CopyPatchFiles(Strings.SelectedPatchFilePath + Strings.SelectedPatchFileName + ".dat", Strings.SelectedPatchFileName);

                if (result != "OK")
                {
                    MessageBox.Show(result, "Error");
                    return;
                }

                // Unpack the patchfiles.
                bool success = gibbedPatchHandler.RunGibbedUnpackProcess(Strings.GibbedPath, Strings.SelectedPatchFileName + ".dat");

                if (!success)
                {
                    MessageBox.Show("Something went wrong unpacking the patchfiles...", "Error");
                    return;
                }

                // Do your generate stuff here...
                XMLparser.ParseXML(gibbedPatchHandler, tbOutputName.Text);

                // Pack the patchfiles.
                success = gibbedPatchHandler.RunGibbedPackProcess(Strings.GibbedPath, Strings.SelectedPatchFileName);

                if (success)
                {
                    string DirectoryToUse = Strings.PatchExportPath + "\\" + tbOutputName.Text;
                    if (!Directory.Exists(DirectoryToUse))
                    {
                        Directory.CreateDirectory(DirectoryToUse);
                    }
                    gibbedPatchHandler.MovePatchFilesToGivenLocation(DirectoryToUse, Strings.SelectedPatchFileName, fc2slpanel.GetPatchName());
                }

                gibbedPatchHandler.DeletePatchData(Strings.SelectedPatchFileName);
            }

            // Create ServerLauncher if needed.
            if (fc2slpanel.IsLauncherNeeded())
            {
                fc2slpanel.CreateServerLauncher(tbOutputName.Text);
            }

            if (Directory.Exists(Strings.PatchExportPath + "\\" + tbOutputName.Text))
            {
                reportManager.builder.WriteReportFile();
                DirectoryInfo dir = new(Strings.PatchExportPath + "\\" + tbOutputName.Text);

                foreach (FileInfo file in dir.GetFiles())
                {
                    if (file.Name.EndsWith(".dat") || file.Name.EndsWith(".fat") || (file.Name.Contains("ServerLauncher") && file.Name.EndsWith(".exe")))
                    {
                        comboxModCollection.Items.Add(dir.Name);
                        comboxModCollection.SelectedIndex = comboxModCollection.Items.IndexOf(dir.Name);
                        break;
                    }
                }
            }

            reportManager.builder.ClearReportData();
        }

        private bool IsValidStateToGenerate()
        {
            if (tbPathPatchFile.Text == "" && (IsAnyWeaponReplaced() || IsAnyCollectionAdded()))
            {
                MessageBox.Show("Load a FC2 server patchfile first!");
                return false;
            }
            if (tbOutputName.Text == "")
            {
                MessageBox.Show("Please enter an Output Name first!");
                return false;
            }
            if (Strings.GibbedPath == "" && (IsAnyWeaponReplaced() || IsAnyCollectionAdded()))
            {
                MessageBox.Show("Select folder with Gibbed Tools in Settings!");
                return false;
            }
            if (Strings.ServerLauncherPath == "" && fc2slpanel.IsLauncherNeeded())
            {
                MessageBox.Show("Select (default) input ServerLauncher in Settings!");
                return false;
            }
            if (Strings.PatchExportPath == "")
            {
                MessageBox.Show("Select folder to export files in Settings!");
                return false;
            }
            return true;
        }

        private void ArrangeDropDownEvents()
        {
            foreach (ComboBox combobox in WeaponDropdownAll)
            {
                combobox.DropDownClosed += UnselectText;
                combobox.KeyDown += PreventKey;
            }
            comboxFilterWeaponPrimaryAll.DropDownClosed += UnselectText;
            comboxFilterWeaponPrimaryAll.KeyDown += PreventKey;
            comboxFilterWeaponPrimary1.DropDownClosed += UnselectText;
            comboxFilterWeaponPrimary1.KeyDown += PreventKey;
            comboxFilterWeaponPrimary2.DropDownClosed += UnselectText;
            comboxFilterWeaponPrimary2.KeyDown += PreventKey;
            comboxFilterWeaponPrimary3.DropDownClosed += UnselectText;
            comboxFilterWeaponPrimary3.KeyDown += PreventKey;
            comboxFilterWeaponSecondaryAll.DropDownClosed += UnselectText;
            comboxFilterWeaponSecondaryAll.KeyDown += PreventKey;
            comboxFilterWeaponSecondary1.DropDownClosed += UnselectText;
            comboxFilterWeaponSecondary1.KeyDown += PreventKey;
            comboxFilterWeaponSecondary2.DropDownClosed += UnselectText;
            comboxFilterWeaponSecondary2.KeyDown += PreventKey;
        }

        internal void AddGeneratedMods()
        {
            comboxModCollection.Items.Add("[None Selected]");

            if (Strings.PatchExportPath == "")
            {
                return;
            }

            DirectoryInfo dir = new(Strings.PatchExportPath);
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                foreach (FileInfo file in subDir.GetFiles())
                {
                    if (file.Name.EndsWith(".dat") || file.Name.EndsWith(".fat") || (file.Name.Contains("ServerLauncher") && file.Name.EndsWith(".exe")))
                    {
                        comboxModCollection.Items.Add(subDir.Name);
                        break;
                    }
                }
            }
            comboxModCollection.SelectedIndex = 0;
        }

        private void UnselectText(object sender, EventArgs e)
        {
            lInputFile.Focus();
        }

        private void PreventKey(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void bPathPatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                Title = "Select FarCry2 server Patchfile",
                Filter = "FC2 Patchfile|*.dat"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                tbPathPatchFile.Text = openFile.FileName;
                Strings.SelectedPatchFilePath = Path.GetDirectoryName(openFile.FileName) + "\\";
                Strings.SelectedPatchFileName = openFile.SafeFileName.Replace(".dat", "");
            }
        }

        private void tbPathPatchFile_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private int CachedDropDownIndex = -1;
        private void CacheCurrentIndex(object sender, EventArgs e)
        {
            ComboBox activeBox = (ComboBox)sender;
            CachedDropDownIndex = activeBox.SelectedIndex;
        }

        private void bDayTimeAddAll_Click(object sender, EventArgs e)
        {
            string allValues = "";
            for (int i = 0; i < 24; i++)
            {
                allValues += i + ";";
            }
            tbDayTimeValues.Text = allValues.Substring(0, allValues.Length - 1);
        }

        private void bGenerateDayTimeNames_Click(object sender, EventArgs e)
        {
            if (tbDayTimeValues.Text.Length == 0)
            {
                return;
            }

            string nameCollection = "";
            string[] allHours = tbDayTimeValues.Text.Split(';');
            foreach (string hour in allHours)
            {
                nameCollection += hour + ":00;";
            }
            tbDayTimeNames.Text = nameCollection.Substring(0, nameCollection.Length - 1);
        }

        private void lDayTimeSpeed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daytime Speed:\r\nChanges the speed time passes by.\r\n0 freezes time, max tested = 999999999\r\n\r\nGame Default: 10", Strings.MsgBox_TitleInfo);
        }

        private void lDayTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DayTime:\r\nSet the hour of the day for all maps on the server.\r\nAll 24 hours (ranging from 0-23) are valid values.", Strings.MsgBox_TitleInfo);
        }

        private void lDayTimeNames_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DayTime Names:\r\nGive a 'name' for daytime, to show in the dropdowns (extender).\r\nFC2 default uses Night/Midday etc, the button generates X:00 values instead.", Strings.MsgBox_TitleInfo);
        }

        private void lRespawnTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RespawnTime:\r\nAdd values (in sec) representing the max time a player has to wait before spawning after death.\r\nThis value is combined with the 'respawn wave', otherwise it won't work in-game.", Strings.MsgBox_TitleInfo);
        }

        private void lShields_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SpawnShield:\r\nAdd values (in sec) that a shield is active after a player spawned.\r\n\r\nGame Default: 10", Strings.MsgBox_TitleInfo);
        }

        private void lZones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ZoneDeathTime:\r\nAdd values (in sec) a player is allowed outside the playzone before dying.\r\n\r\nGame Default: 10", Strings.MsgBox_TitleInfo);
        }

        private void lPreRound_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preround Time:\r\nAdd values (in sec) of time before a match starts.\r\nWARNING: Setting it to 0 will make it infinite waiting!\r\n\r\nGame Default: 15", Strings.MsgBox_TitleInfo);
        }

        private void lPostRoundTimes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Postround Time:\r\nAdd values (in sec) of time after a match ended, showing score details.\r\nWARNING: Setting it to 0 will make it infinite waiting!\r\n\r\nGame Default: 25", Strings.MsgBox_TitleInfo);
        }

        private void UpdateLinkedDropdownValues(TextBox modeScoreCollection, ComboBox defaultScore)
        {
            defaultScore.Items.Clear();
            defaultScore.Text = string.Empty;

            if (modeScoreCollection.Text.Length == 0)
            {
                return;
            }
            if (modeScoreCollection.Text.Contains(';'))
            {
                string[] values = modeScoreCollection.Text.Split(';');
                foreach (string value in values)
                {
                    if (value != "")
                    {
                        defaultScore.Items.Add(value);
                    }
                }
                defaultScore.SelectedIndex = 0;
            }
            else
            {
                defaultScore.Items.Add(modeScoreCollection.Text);
                defaultScore.SelectedIndex = 0;
            }
        }

        //private void KeyDownPreventChars(object sender, KeyEventArgs e)
        //{
        //    if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) && e.KeyCode != Keys.OemSemicolon && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Home && e.KeyCode != Keys.End)
        //    {
        //        e.SuppressKeyPress = true;
        //    }
        //}

        private void KeyPressPreventChars(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit or a semicolon
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ';' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void TextChangedValidateInput(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Retain only digits and semicolons
                string validText = new(textBox.Text.Where(c => char.IsDigit(c) || c == ';').ToArray());

                // If there's any invalid character, update the text
                if (textBox.Text != validText)
                {
                    textBox.Text = validText;

                    // Move the cursor to the end of the text
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }



        public string GetRespawnTimeCollection()
        {
            return tbRespawnTimes.Text;
        }

        public string GetRespawnTimeDefaultValue()
        {
            return comboxDefaultRespawnTime.Text;
        }

        internal void SetRespawnTimeCollection(string collection, string defaultValue)
        {
            tbRespawnTimes.Text = collection;
            if (comboxDefaultRespawnTime.Items.Contains(defaultValue))
            {
                comboxDefaultRespawnTime.SelectedIndex = comboxDefaultRespawnTime.Items.IndexOf(defaultValue);
            }
        }

        public string GetSpawnShieldCollection()
        {
            return tbSpawnShields.Text;
        }

        public string GetSpawnShieldDefaultValue()
        {
            return comboxDefaultSpawnShield.Text;
        }

        internal void SetSpawnShieldCollection(string collection, string defaultValue)
        {
            tbSpawnShields.Text = collection;
            if (comboxDefaultSpawnShield.Items.Contains(defaultValue))
            {
                comboxDefaultSpawnShield.SelectedIndex = comboxDefaultSpawnShield.Items.IndexOf(defaultValue);
            }
        }

        public string GetDaytimeSpeedCollection()
        {
            return tbDaytimeSpeed.Text;
        }

        public string GetDaytimeSpeedDefaultValue()
        {
            return comboxDefaultDaytimeSpeed.Text;
        }

        internal void SetDaytimeSpeedCollection(string collection, string defaultValue)
        {
            tbDaytimeSpeed.Text = collection;
            if (comboxDefaultDaytimeSpeed.Items.Contains(defaultValue))
            {
                comboxDefaultDaytimeSpeed.SelectedIndex = comboxDefaultDaytimeSpeed.Items.IndexOf(defaultValue);
            }
        }

        public string GetZoneDeathTimeCollection()
        {
            return tbZoneDeathTimes.Text;
        }

        public string GetZoneDeathTimeDefaultValue()
        {
            return comboxDefaultZoneDeathTime.Text;
        }

        internal void SetZoneDeathTimeCollection(string collection, string defaultValue)
        {
            tbZoneDeathTimes.Text = collection;
            if (comboxDefaultZoneDeathTime.Items.Contains(defaultValue))
            {
                comboxDefaultZoneDeathTime.SelectedIndex = comboxDefaultZoneDeathTime.Items.IndexOf(defaultValue);
            }
        }

        public string GetScoresDMCollection()
        {
            return tbScoresDM.Text;
        }

        public string GetScoresDMDefaultValue()
        {
            return comboxDefaultScoreDM.Text;
        }

        public void SetScoresDMCollection(string collection, string defaultValue)
        {
            tbScoresDM.Text = collection;
            if (comboxDefaultScoreDM.Items.Contains(defaultValue))
            {
                comboxDefaultScoreDM.SelectedIndex = comboxDefaultScoreDM.Items.IndexOf(defaultValue);
            }
        }

        public string GetScoresTDMCollection()
        {
            return tbScoresTDM.Text;
        }

        public string GetScoresTDMDefaultValue()
        {
            return comboxDefaultScoreTDM.Text;
        }

        public void SetScoresTDMCollection(string collection, string defaultValue)
        {
            tbScoresTDM.Text = collection;
            if (comboxDefaultScoreTDM.Items.Contains(defaultValue))
            {
                comboxDefaultScoreTDM.SelectedIndex = comboxDefaultScoreTDM.Items.IndexOf(defaultValue);
            }
        }

        public string GetScoresCTDCollection()
        {
            return tbScoresCTD.Text;
        }

        public string GetScoresCTDDefaultValue()
        {
            return comboxDefaultScoreCTD.Text;
        }

        public void SetScoresCTDCollection(string collection, string defaultValue)
        {
            tbScoresCTD.Text = collection;
            if (comboxDefaultScoreCTD.Items.Contains(defaultValue))
            {
                comboxDefaultScoreCTD.SelectedIndex = comboxDefaultScoreCTD.Items.IndexOf(defaultValue);
            }
        }

        public string GetScoresUPRCollection()
        {
            return tbScoresUPR.Text;
        }

        public string GetScoresUPRDefaultValue()
        {
            return comboxDefaultScoreUPR.Text;
        }

        public void SetScoresUPRCollection(string collection, string defaultValue)
        {
            tbScoresUPR.Text = collection;
            if (comboxDefaultScoreUPR.Items.Contains(defaultValue))
            {
                comboxDefaultScoreUPR.SelectedIndex = comboxDefaultScoreUPR.Items.IndexOf(defaultValue);
            }
        }

        public string GetPreRoundTimeCollection()
        {
            return tbPreRoundTimes.Text;
        }

        public string GetPreRoundTimeDefaultValue()
        {
            return comboxDefaultPreRoundTime.Text;
        }

        internal void SetPreRoundTimeCollection(string collection, string defaultValue)
        {
            tbPreRoundTimes.Text = collection;
            if (comboxDefaultPreRoundTime.Items.Contains(defaultValue))
            {
                comboxDefaultPreRoundTime.SelectedIndex = comboxDefaultPreRoundTime.Items.IndexOf(defaultValue);
            }
        }

        public string GetPostRoundTimeCollection()
        {
            return tbPostRoundTimes.Text;
        }

        public string GetPostRoundTimeDefaultValue()
        {
            return comboxDefaultPostRoundTime.Text;
        }

        internal void SetPostRoundTimeCollection(string collection, string defaultValue)
        {
            tbPostRoundTimes.Text = collection;
            if (comboxDefaultPostRoundTime.Items.Contains(defaultValue))
            {
                comboxDefaultPostRoundTime.SelectedIndex = comboxDefaultPostRoundTime.Items.IndexOf(defaultValue);
            }
        }

        internal void SetWeaponDropdownValue(int weaponCollectionIndex, string weaponName)
        {
            WeaponDropdownAll[weaponCollectionIndex].SelectedIndex = WeaponDropdownAll[weaponCollectionIndex].Items.IndexOf(weaponName);
        }

        public void SetSelectedPatchFile(string filePath)
        {
            tbPathPatchFile.Text = filePath;
            Strings.SelectedPatchFilePath = Path.GetDirectoryName(filePath) + "\\";
            Strings.SelectedPatchFileName = Path.GetFileNameWithoutExtension(filePath);
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void pbOpenGenerationFolder_Click(object sender, EventArgs e)
        {
            if (Strings.PatchExportPath != "")
            {
                Process.Start("explorer.exe", Strings.PatchExportPath);
                return;
            }
        }

        private void pbOpenGameBinFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Strings.GameFolderPath + "\\bin"))
            {
                Process.Start("explorer.exe", Strings.GameFolderPath + "\\bin");
            }
        }

        private void comboxModCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            bLoadReport.Enabled = false;
            bInstall.Enabled = false;

            if (comboxModCollection.SelectedIndex == 0)
            {
                return;
            }

            DirectoryInfo modDir = new(Strings.PatchExportPath + "\\" + comboxModCollection.Text);
            foreach (FileInfo file in modDir.GetFiles())
            {
                if (file.Name == Strings.ReportFileName)
                {
                    bLoadReport.Enabled = true;
                }
                else if (file.Name.EndsWith(".dat") || file.Name.EndsWith(".fat") || (file.Name.Contains("ServerLauncher") && file.Name.EndsWith(".exe")))
                {
                    bInstall.Enabled = Strings.GameFolderPath != "";
                }
            }
        }

        private void bLoadReport_Click(object sender, EventArgs e)
        {
            ResetGeneratorGUI();
            tbOutputName.Text = comboxModCollection.Text;
            reportManager.loader.LoadReport(Strings.PatchExportPath + "\\" + comboxModCollection.Text + "\\" + Strings.ReportFileName);
        }

        internal void ResetGeneratorGUI()
        {
            SetDefaultDropDownIndex();
            tbDayTimeValues.Clear();
            tbDayTimeNames.Clear();
            tbDaytimeSpeed.Clear();
            tbRespawnTimes.Clear();
            tbSpawnShields.Clear();
            tbZoneDeathTimes.Clear();
            tbScoresDM.Clear();
            tbScoresTDM.Clear();
            tbScoresCTD.Clear();
            tbScoresUPR.Clear();
            tbPreRoundTimes.Clear();
            tbPostRoundTimes.Clear();
            fc2slpanel.ResetFields();
        }

        private void bInstall_Click(object sender, EventArgs e)
        {
            DirectoryInfo modDir = new(Strings.PatchExportPath + "\\" + comboxModCollection.Text);
            foreach (FileInfo file in modDir.GetFiles())
            {
                if (file.Name.EndsWith(".dat") || file.Name.EndsWith(".fat"))
                {
                    if (Directory.Exists(Strings.GameFolderPath + "\\Data_Win32"))
                    {
                        File.Copy(file.FullName, Strings.GameFolderPath + "\\Data_Win32\\" + file.Name, true);
                    }
                }
                else if (file.Name.Contains("ServerLauncher") && file.Name.EndsWith(".exe"))
                {
                    if (Directory.Exists(Strings.GameFolderPath + "\\bin"))
                    {
                        if (!File.Exists(Strings.GameFolderPath + "\\bin\\" + file.Name))
                        {
                            File.Copy(file.FullName, Strings.GameFolderPath + "\\bin\\" + file.Name);
                            MessageBox.Show("Serverlauncher copied to " + Strings.GameFolderPath + "\\" + "bin\r\nDon't forget to set proper Compatibility settings!");
                        }
                        else
                        {
                            // Could crash SMG if process still running when FSLM crashed.
                            File.Copy(file.FullName, Strings.GameFolderPath + "\\bin\\" + file.Name, true);
                        }
                    }
                }
            }
        }

        private void lDiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(((LinkLabel)sender).Text) { UseShellExecute = true });
        }

        private void bAddDefaultScoresDM_Click(object sender, EventArgs e)
        {
            tbScoresDM.Text = "0;5;10;15;20;25;30;40;50;100";
        }

        private void bAddDefaultScoresTDM_Click(object sender, EventArgs e)
        {
            tbScoresTDM.Text = "0;5;10;15;20;25;30;40;50;100;200";
        }

        private void bAddDefaultScoresCTD_Click(object sender, EventArgs e)
        {
            tbScoresCTD.Text = "0;3;5;10;20;30;40;50;100";
        }
    }
}
