
using FC2SMG.Enums;
/// Loader class that handles Setting Lines for serverlauncher related settings.
namespace FC2SMG.Reports.Loader
{
    internal class LoaderLauncherSettings
    {
        ReportLoader reportLoader;

        internal LoaderLauncherSettings(ReportLoader parent)
        {
            reportLoader = parent;
        }

        internal void HandleLauncherSettingsLine(string[] splitLine)
        {
            if (splitLine.Length != 3)
            {
                return;
            }

            Enum_SettingsLauncher testLauncherSettings;

            try
            {
                testLauncherSettings = (Enum_SettingsLauncher)Enum.Parse(typeof(Enum_SettingsLauncher), splitLine[1]);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Couldn't parse the following Setting Name:\r\n" + splitLine[1]);
                return;
            }

            string value = splitLine[2];

            if (testLauncherSettings == Enum_SettingsLauncher.HOSTNAME)
            {
                reportLoader.reportManager.GeneratorGui.getLauncherPanel().SetHostName(value);
            }
            else if (testLauncherSettings == Enum_SettingsLauncher.PATCHNAME)
            {
                reportLoader.reportManager.GeneratorGui.getLauncherPanel().SetPatchName(value);
            }
        }
    }
}
