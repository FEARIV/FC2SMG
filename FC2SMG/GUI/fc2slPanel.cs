using FC2modHandler;
using FC2SMG.Enums;
using ServerModGenerator;
using System.Text;

namespace FC2SMG.GUI
{
    public partial class fc2slPanel : UserControl
    {
        GeneratorGUI parent;

        internal fc2slPanel(GeneratorGUI parent)
        {
            InitializeComponent();
            this.parent = parent;
            ColorGUI();
        }

        // Set Hostname for Patchfile (if changed before, loaded from report)
        // public void SetHostName() { }
        // Set PatchFileName for Patchfile
        // public void SetPatchName() { }

        private void ColorGUI()
        {
            pMain.BackColor = ColorBox.backGround;
            lHostName.ForeColor = ColorBox.textTitle;
            tbHostName.BackColor = ColorBox.backGround;
            tbHostName.ForeColor = ColorBox.textContent;
            lHostNameDefault.ForeColor = ColorBox.Disabled;
            lPatchName.ForeColor = ColorBox.textTitle;
            tbPatchName.BackColor = ColorBox.backGround;
            tbPatchName.ForeColor = ColorBox.textContent;
            lPatchNameDefault.ForeColor = ColorBox.Disabled;
        }

        public bool IsLauncherNeeded()
        {
            return tbHostName.Text != "" || tbPatchName.Text != "";
        }

        public void CreateServerLauncher(string outputName)
        {
            string newLauncherPath = PrepareDirectories(outputName);

            HandleCustomHostName(newLauncherPath);
            HandleCustomPatchName(newLauncherPath);
        }

        private string PrepareDirectories(string outputName)
        {
            // Copy picked fc2sl to output folder.
            string OutputDir = Strings.PatchExportPath + "\\" + outputName;
            if (!Directory.Exists(OutputDir))
            {
                Directory.CreateDirectory(OutputDir);
            }

            string newLauncherPath = OutputDir + "\\[" + outputName + "]FC2ServerLauncher.exe";
            if (File.Exists(Strings.ServerLauncherPath))
            {
                File.Copy(Strings.ServerLauncherPath, newLauncherPath, true);
            }

            return newLauncherPath;
        }

        private void HandleCustomHostName(string newLauncherPath)
        {
            if (tbHostName.Text.Length > 0)
            {
                int hostNameIndex = FC2SLhandler.GetIndexOfHostName(newLauncherPath);
                if (hostNameIndex != -1)
                {
                    BinaryWriter writer = new(File.OpenWrite(newLauncherPath), Encoding.Default);
                    writer.BaseStream.Seek(hostNameIndex + 1, SeekOrigin.Begin);
                    writer.Write(Encoding.Default.GetBytes(tbHostName.Text));
                    if (tbHostName.Text.Length < 9)
                    {
                        for (int i = 0; i < 9 - tbHostName.Text.Length; i++)
                        {
                            writer.Write(new char());
                        }
                    }
                    writer.Close();
                }
                parent.reportManager.builder.AddReportLineForServerLauncher(Enum_ModType.LAUNCHER, Enum_SettingsLauncher.HOSTNAME, tbHostName.Text);
            }
        }

        private void HandleCustomPatchName(string newLauncherPath)
        {
            if (tbPatchName.Text.Length > 0)
            {
                int patchNameIndex = FC2SLhandler.GetIndexOfPatchName(newLauncherPath);
                if (patchNameIndex != -1)
                {
                    BinaryWriter writer = new(File.OpenWrite(newLauncherPath), Encoding.Default);
                    writer.BaseStream.Seek(patchNameIndex + 1, SeekOrigin.Begin);
                    writer.Write(Encoding.Default.GetBytes(tbPatchName.Text + ".dat"));
                    if (tbPatchName.Text.Length < 9)
                    {
                        for (int i = 0; i < 9 - tbPatchName.Text.Length; i++)
                        {
                            writer.Write(new char());
                        }
                    }
                    writer.Close();
                }
                parent.reportManager.builder.AddReportLineForServerLauncher(Enum_ModType.LAUNCHER, Enum_SettingsLauncher.PATCHNAME, tbPatchName.Text);
            }
        }

        internal void SetHostName(string value)
        {
            tbHostName.Text = value;
        }

        internal string GetPatchName()
        {
            return tbPatchName.Text;
        }

        internal void SetPatchName(string value)
        {
            tbPatchName.Text = value;
        }

        private void cbHiddenUbiMaps_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHiddenUbiMaps.Checked)
            {
                cbHiddenUbiMaps.CheckState = CheckState.Unchecked;
            }
        }
    }
}
