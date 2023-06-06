using FC2modHandler;
using FC2SMG.GUI;
using FC2SMG.Reports;
using ServerModGenerator.GUI;
using System.Diagnostics;

// Add converter for combobox-names to XML weaponnames!
// Add option to select grenade or molotov (or disable?)

namespace ServerModGenerator
{
    public partial class GeneratorGUI : Form
    {
        //string version = "v20220327";
        public ComboBox[] WeaponDropdownAll { get; set; }
        public ComboBox[] WeaponDropDownPrimary { get; set; }
        public ComboBox[] WeaponDropDownSecondary { get; set; }
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
            ColorGUI();
            settings = new(this);
            controller = new GeneratorController(this);
            pWeaponPanels.AutoScroll = true;
            controller = new GeneratorController(this);
            weaponCollections = new WeaponCollections();
            SettingsCollection = new TextBox[] { tbDaytimeSpeed, tbRespawnTimes, tbSpawnShields, tbZoneDeathTimes, tbPreRoundTimes, tbPostRoundTimes }; // tbDayTimeValues, tbDayTimeNames, 
            XMLparser = new XMLParser(this);
            reportManager = new(this);
            controller.AddDefaultLoadout();
            FillDropDownCollections();
            controller.FillDropDowns();
            SetDefaultDropDownIndex();
            ArrangeDropDownEvents();
            tbPathPatchFile.ContextMenuStrip = new ContextMenuStrip();
            fc2slpanel = new(this);
            tabPage3.Controls.Add(fc2slpanel);
            AddGeneratedMods();
        }

        private void ColorGUI()
        {
            tabPage1.BackColor = ColorBox.backGround;
            pLoadOutControls.BackColor = ColorBox.backGround;
            pWeaponPanels.BackColor = ColorBox.backGround;
            comboxSingleWeaponPrimary.BackColor = ColorBox.backGround;
            comboxSingleWeaponSecondary.BackColor = ColorBox.backGround;
            comboxSingleWeaponPrimary.ForeColor = ColorBox.textContent;
            comboxSingleWeaponSecondary.ForeColor = ColorBox.textContent;
            lSingleWeaponPrimary.ForeColor = ColorBox.textTitle;
            lSingleWeaponSecondary.ForeColor = ColorBox.textTitle;
            lSingleWeapons.ForeColor = ColorBox.textContent;
            lWeaponLoadOut.ForeColor = ColorBox.textContent;

            tabPage2.BackColor = ColorBox.backGround;
            tabPage3.BackColor = ColorBox.backGround;
            lCollectionInfo.ForeColor = ColorBox.textContent;
            lDayTime.ForeColor = ColorBox.Disabled;
            lDayTimeNames.ForeColor = ColorBox.Disabled;
            lDayTimeSpeed.ForeColor = ColorBox.textTitle;
            lRespawnTimes.ForeColor = ColorBox.textTitle;
            lShields.ForeColor = ColorBox.textTitle;
            lZones.ForeColor = ColorBox.textTitle;
            lPreRound.ForeColor = ColorBox.textTitle;
            lPostRoundTimes.ForeColor = ColorBox.textTitle;
            tbDayTimeValues.BackColor = ColorBox.backGround;
            tbDayTimeNames.BackColor = ColorBox.backGround;
            tbDaytimeSpeed.BackColor = ColorBox.backGround;
            tbRespawnTimes.BackColor = ColorBox.backGround;
            tbSpawnShields.BackColor = ColorBox.backGround;
            tbZoneDeathTimes.BackColor = ColorBox.backGround;
            tbPreRoundTimes.BackColor = ColorBox.backGround;
            tbPostRoundTimes.BackColor = ColorBox.backGround;
            tbDayTimeValues.ForeColor = ColorBox.Disabled;
            tbDayTimeNames.ForeColor = ColorBox.Disabled;
            tbDaytimeSpeed.ForeColor = ColorBox.textContent;
            tbRespawnTimes.ForeColor = ColorBox.textContent;
            tbSpawnShields.ForeColor = ColorBox.textContent;
            tbZoneDeathTimes.ForeColor = ColorBox.textContent;
            tbPreRoundTimes.ForeColor = ColorBox.textContent;
            tbPostRoundTimes.ForeColor = ColorBox.textContent;

            comboxDefaultSpawnShield.BackColor = ColorBox.backGround;
            comboxDefaultSpawnShield.ForeColor = Color.Chartreuse;
            comboxDefaultRespawnTime.BackColor = ColorBox.backGround;
            comboxDefaultRespawnTime.ForeColor = Color.Chartreuse;
            comboxDefaultDaytimeSpeed.BackColor = ColorBox.backGround;
            comboxDefaultDaytimeSpeed.ForeColor = Color.Chartreuse;
            comboxDefaultZoneDeathTime.BackColor = ColorBox.backGround;
            comboxDefaultZoneDeathTime.ForeColor = Color.Chartreuse;
            comboxDefaultPreRoundTime.BackColor = ColorBox.backGround;
            comboxDefaultPreRoundTime.ForeColor = Color.Chartreuse;
            comboxDefaultPostRoundTime.BackColor = ColorBox.backGround;
            comboxDefaultPostRoundTime.ForeColor = Color.Chartreuse;
        }

        private void FillDropDownCollections()
        {
            List<ComboBox> AllWeapons = new();
            foreach (WeaponPanel weaponPanel in AllClassLoadOuts)
            {
                AllWeapons.AddRange(weaponPanel.GetAllWeaponDropDowns());
            }
            WeaponDropdownAll = AllWeapons.ToArray();

            List<ComboBox> PrimaryWeapons = new() { comboxSingleWeaponPrimary };
            foreach (WeaponPanel weaponPanel in AllClassLoadOuts)
            {
                PrimaryWeapons.AddRange(weaponPanel.GetPrimaryWeaponDropDowns());
            }
            WeaponDropDownPrimary = PrimaryWeapons.ToArray();

            List<ComboBox> SecondaryWeapons = new() { comboxSingleWeaponSecondary };
            foreach (WeaponPanel weaponPanel in AllClassLoadOuts)
            {
                SecondaryWeapons.AddRange(weaponPanel.GetSecondaryWeaponDropDowns());
            }
            WeaponDropDownSecondary = SecondaryWeapons.ToArray();
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
            comboxSingleWeaponPrimary.SelectedIndex = 0;
            comboxSingleWeaponSecondary.SelectedIndex = 0;
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

        private void comboxSingleWeaponPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboxSingleWeaponPrimary.Text.StartsWith("-"))
            {
                if (!comboxSingleWeaponPrimary.Text.StartsWith("="))
                {
                    foreach (ComboBox combobox in WeaponDropDownPrimary)
                    {
                        if (combobox.Text != comboxSingleWeaponPrimary.Text)
                        {
                            combobox.SelectedIndex = combobox.Items.IndexOf(comboxSingleWeaponPrimary.Text);
                        }
                    }
                }
                else
                {
                    comboxSingleWeaponPrimary.SelectedIndex = CachedDropDownIndex;
                }
            }
        }

        private void comboxSingleWeaponSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboxSingleWeaponSecondary.Text.StartsWith("-"))
            {
                foreach (ComboBox combobox in WeaponDropDownSecondary)
                {
                    if (combobox.Text != comboxSingleWeaponSecondary.Text)
                    {
                        combobox.SelectedIndex = combobox.Items.IndexOf(comboxSingleWeaponSecondary.Text);
                    }
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
                //combobox.ContextMenu = new ContextMenu();
            }
            comboxSingleWeaponPrimary.DropDownClosed += UnselectText;
            comboxSingleWeaponPrimary.KeyDown += PreventKey;
            //comboxSingleWeaponPrimary.ContextMenu = new ContextMenu();
            comboxSingleWeaponSecondary.DropDownClosed += UnselectText;
            comboxSingleWeaponSecondary.KeyDown += PreventKey;
            //comboxSingleWeaponSecondary.ContextMenu = new ContextMenu();
        }

        internal void AddGeneratedMods()
        {
            comboxModCollection.Items.Add("[None Selected]");
            // ..
            DirectoryInfo dir = new(Strings.PatchExportPath);
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                foreach (FileInfo file in subDir.GetFiles())
                {
                    if (file.Name.EndsWith(".dat") || file.Name.EndsWith(".fat") || (file.Name.Contains("ServerLauncher") && file.Name.EndsWith(".exe")))
                    {
                        // Add subdir to dropdown
                        // ..
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

        private void tbRespawnTimes_TextChanged(object sender, EventArgs e)
        {
            comboxDefaultRespawnTime.Items.Clear();

            if (tbRespawnTimes.Text.Length == 0)
            {
                return;
            }
            if (tbRespawnTimes.Text.Contains(';'))
            {
                string[] values = tbRespawnTimes.Text.Split(';');
                foreach (string value in values)
                {
                    if (value != "")
                    {
                        comboxDefaultRespawnTime.Items.Add(value);
                    }
                }
                comboxDefaultRespawnTime.SelectedIndex = 0;
            }
            else
            {
                comboxDefaultRespawnTime.Items.Add(tbRespawnTimes.Text);
                comboxDefaultRespawnTime.SelectedIndex = 0;
            }
        }

        private void tbSpawnShields_TextChanged(object sender, EventArgs e)
        {
            comboxDefaultSpawnShield.Items.Clear();

            if (tbSpawnShields.Text.Length == 0)
            {
                return;
            }
            if (tbSpawnShields.Text.Contains(';'))
            {
                string[] values = tbSpawnShields.Text.Split(';');
                foreach (string value in values)
                {
                    if (value != "")
                    {
                        comboxDefaultSpawnShield.Items.Add(value);
                    }
                }
                comboxDefaultSpawnShield.SelectedIndex = 0;
            }
            else
            {
                comboxDefaultSpawnShield.Items.Add(tbSpawnShields.Text);
                comboxDefaultSpawnShield.SelectedIndex = 0;
            }
        }

        private void tbDaytimeSpeed_TextChanged(object sender, EventArgs e)
        {
            comboxDefaultDaytimeSpeed.Items.Clear();

            if (tbDaytimeSpeed.Text.Length == 0)
            {
                return;
            }
            if (tbDaytimeSpeed.Text.Contains(';'))
            {
                string[] values = tbDaytimeSpeed.Text.Split(';');
                foreach (string value in values)
                {
                    if (value != "")
                    {
                        comboxDefaultDaytimeSpeed.Items.Add(value);
                    }
                }
                comboxDefaultDaytimeSpeed.SelectedIndex = 0;
            }
            else
            {
                comboxDefaultDaytimeSpeed.Items.Add(tbDaytimeSpeed.Text);
                comboxDefaultDaytimeSpeed.SelectedIndex = 0;
            }
        }

        private void tbZoneDeathTimes_TextChanged(object sender, EventArgs e)
        {
            comboxDefaultZoneDeathTime.Items.Clear();

            if (tbZoneDeathTimes.Text.Length == 0)
            {
                return;
            }
            if (tbZoneDeathTimes.Text.Contains(';'))
            {
                string[] values = tbZoneDeathTimes.Text.Split(';');
                foreach (string value in values)
                {
                    if (value != "")
                    {
                        comboxDefaultZoneDeathTime.Items.Add(value);
                    }
                }
                comboxDefaultZoneDeathTime.SelectedIndex = 0;
            }
            else
            {
                comboxDefaultZoneDeathTime.Items.Add(tbZoneDeathTimes.Text);
                comboxDefaultZoneDeathTime.SelectedIndex = 0;
            }
        }

        private void tbPreRoundTimes_TextChanged(object sender, EventArgs e)
        {
            comboxDefaultPreRoundTime.Items.Clear();

            if (tbPreRoundTimes.Text.Length == 0)
            {
                return;
            }
            if (tbPreRoundTimes.Text.Contains(';'))
            {
                string[] values = tbPreRoundTimes.Text.Split(';');
                foreach (string value in values)
                {
                    if (value != "")
                    {
                        comboxDefaultPreRoundTime.Items.Add(value);
                    }
                }
                comboxDefaultPreRoundTime.SelectedIndex = 0;
            }
            else
            {
                comboxDefaultPreRoundTime.Items.Add(tbPreRoundTimes.Text);
                comboxDefaultPreRoundTime.SelectedIndex = 0;
            }
        }

        private void tbPostRoundTimes_TextChanged(object sender, EventArgs e)
        {
            comboxDefaultPostRoundTime.Items.Clear();

            if (tbPostRoundTimes.Text.Length == 0)
            {
                return;
            }
            if (tbPostRoundTimes.Text.Contains(';'))
            {
                string[] values = tbPostRoundTimes.Text.Split(';');
                foreach (string value in values)
                {
                    if (value != "")
                    {
                        comboxDefaultPostRoundTime.Items.Add(value);
                    }
                }
                comboxDefaultPostRoundTime.SelectedIndex = 0;
            }
            else
            {
                comboxDefaultPostRoundTime.Items.Add(tbPostRoundTimes.Text);
                comboxDefaultPostRoundTime.SelectedIndex = 0;
            }
        }

        private void KeyDownPreventChars(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) && e.KeyCode != Keys.OemSemicolon && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Home && e.KeyCode != Keys.End)
            {
                e.SuppressKeyPress = true;
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
            reportManager.loader.LoadReport(Strings.PatchExportPath + "\\" + comboxModCollection.Text + "\\" + Strings.ReportFileName);
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
    }
}
