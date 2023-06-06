using ServerModGenerator;

namespace FC2SMG.GUI
{
    public partial class Settings : Form
    {
        GeneratorGUI generatorGui;
        public Settings(GeneratorGUI generatorGui)
        {
            InitializeComponent();
            this.generatorGui = generatorGui;
            CheckSettingsFile();
        }

        private void CheckSettingsFile()
        {
            if (!Directory.Exists(Strings.RootFC2SMG))
            {
                Directory.CreateDirectory(Strings.RootFC2SMG);
            }
            if (File.Exists(Strings.FC2SMGsettingsFile))
            {
                string[] settings = File.ReadAllLines(Strings.FC2SMGsettingsFile);
                foreach (string setting in settings)
                {
                    if (setting.StartsWith("GibbedPath="))
                    {
                        SetGibbedPath(setting.Split('=')[1]);
                    }
                    else if (setting.StartsWith("PatchFile="))
                    {
                        SetDefaultPatchfile(setting.Split('=')[1]);
                        generatorGui.SetSelectedPatchFile(Strings.DefaultPatchFile);
                    }
                    else if (setting.StartsWith("FC2SLPath="))
                    {
                        SetFC2SLPath(setting.Split('=')[1]);
                    }
                    else if (setting.StartsWith("ExportPath="))
                    {
                        SetExportFolder(setting.Split('=')[1]);
                    }
                    else if (setting.StartsWith("GamePath="))
                    {
                        SetGameFolderPath(setting.Split('=')[1]);
                    }
                }
            }
        }

        private void bGibbedPath_Click(object sender, EventArgs e)
        {
            PickGibbedPath();
        }

        public void PickGibbedPath()
        {
            FolderBrowserDialog pickedFolder = new()
            {
                Description = "Chose folder containing Gibbed tools.",

                RootFolder = Environment.SpecialFolder.MyComputer
            };
            DialogResult result = pickedFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!File.Exists(pickedFolder.SelectedPath + "\\Gibbed.Dunia.Unpack.exe"))
                {
                    MessageBox.Show("Missing required file(s)...", "Invalid Location!");
                    return;
                }

                SetGibbedPath(pickedFolder.SelectedPath);
            }
        }

        private void SetGibbedPath(string path)
        {
            Strings.GibbedPath = path;
            lGibbedPath.Text = path;
        }

        private void bPatchFile_Click(object sender, EventArgs e)
        {
            PickPatchFile();
        }

        private void PickPatchFile()
        {
            OpenFileDialog openFileDialog1 = new()
            {
                Filter = "FC2 Server Patchfile|*.dat",
                Title = "Select a Server Patchfile on your system."
            };
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetDefaultPatchfile(openFileDialog1.FileName);
            }
        }

        private void SetDefaultPatchfile(string filePath)
        {
            Strings.DefaultPatchFile = filePath;
            lPatchFile.Text = filePath;
        }

        private void bServerLauncherPath_Click(object sender, EventArgs e)
        {
            PickServerLauncherPath();
        }

        private void PickServerLauncherPath()
        {
            OpenFileDialog openFileDialog1 = new()
            {
                Filter = "FC2 ServerLauncher|FC2ServerLauncher.exe;[*]FC2ServerLauncher.exe;FC2UPatch104ServerLauncher_R3.exe",
                Title = "Find the ServerLauncher on your system."
            };
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetFC2SLPath(openFileDialog1.FileName);
            }
        }

        private void SetFC2SLPath(string filePath)
        {
            Strings.ServerLauncherPath = filePath;
            lServerLauncherPath.Text = filePath;
        }

        private void bExportFolder_Click(object sender, EventArgs e)
        {
            PickExportFolder();
        }

        public void PickExportFolder()
        {
            FolderBrowserDialog pickedFolder = new()
            {
                Description = "Chose folder to place generated Patchfiles.",

                RootFolder = Environment.SpecialFolder.MyComputer
            };
            DialogResult result = pickedFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                SetExportFolder(pickedFolder.SelectedPath);
            }
        }

        private void SetExportFolder(string path)
        {
            Strings.PatchExportPath = path;
            lExportPath.Text = path;
        }

        private void bSaveSettings_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Strings.FC2SMGsettingsFile, "GibbedPath=" + Strings.GibbedPath + Environment.NewLine + "PatchFile=" + Strings.DefaultPatchFile + Environment.NewLine + "FC2SLPath=" + Strings.ServerLauncherPath + Environment.NewLine + "ExportPath=" + Strings.PatchExportPath + Environment.NewLine + "GamePath=" + Strings.GameFolderPath);
        }

        private void bGameFolder_Click(object sender, EventArgs e)
        {
            PickGameFolderPath();
        }

        private void PickGameFolderPath()
        {
            FolderBrowserDialog pickedFolder = new()
            {
                Description = "Chose root folder of installed FC2 game.",

                RootFolder = Environment.SpecialFolder.MyComputer
            };
            DialogResult result = pickedFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                SetGameFolderPath(pickedFolder.SelectedPath);
            }
        }

        private void SetGameFolderPath(string path)
        {
            Strings.GameFolderPath = path;
            lGameFolder.Text = path;
        }
    }
}
