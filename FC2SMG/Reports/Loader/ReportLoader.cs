
using FC2SMG.Enums;
/// Main Report Loader that determines which Setting-Loader class needs to be called for each line.
namespace FC2SMG.Reports.Loader
{
    internal class ReportLoader
    {
        internal ReportManager reportManager;
        LoaderGameSettings gameSettings;
        LoaderLauncherSettings launcherSettings;
        LoaderWeaponSettings weaponSettings;

        internal ReportLoader(ReportManager parent)
        {
            reportManager = parent;
            gameSettings = new(this);
            launcherSettings = new(this);
            weaponSettings = new(this);
        }

        internal void LoadReport(string reportPath)
        {
            string[] content = File.ReadAllLines(reportPath);
            foreach (string line in content)
            {
                string[] splitLine = line.Split('|');
                Enum_ModType testModType;

                try
                {
                    testModType = (Enum_ModType)Enum.Parse(typeof(Enum_ModType), splitLine[0]);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Couldn't parse the ModType to determine setting!\r\n>>> " + line);
                    return;
                }

                if (testModType == Enum_ModType.WEAPON)
                {
                    weaponSettings.HandleWeaponSettingsLine(splitLine);
                }
                else if (testModType == Enum_ModType.GAMESETTING)
                {
                    gameSettings.HandleGameSettingsLine(splitLine);
                }
                else if (testModType == Enum_ModType.LAUNCHER)
                {
                    launcherSettings.HandleLauncherSettingsLine(splitLine);
                }
            }
        }
    }
}
