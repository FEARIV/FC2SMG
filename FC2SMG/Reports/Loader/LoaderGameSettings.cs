
using FC2SMG.Enums;
/// Loader class that handles Setting Lines for game collection settings.
namespace FC2SMG.Reports.Loader
{
    internal class LoaderGameSettings
    {
        ReportLoader reportLoader;

        internal LoaderGameSettings(ReportLoader parent)
        {
            reportLoader = parent;
        }

        internal void HandleGameSettingsLine(string[] splitLine)
        {
            if (splitLine.Length != 4)
            {
                return;
            }

            Enum_SettingsGame testGameSettings;

            try
            {
                testGameSettings = (Enum_SettingsGame)Enum.Parse(typeof(Enum_SettingsGame), splitLine[1]);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Couldn't parse the following Setting Name:\r\n" + splitLine[1]);
                return;
            }

            string collectionSettings = splitLine[2];
            string collectionDefaultValue = splitLine[3];

            if (testGameSettings == Enum_SettingsGame.DAYSPEED)
            {
                reportLoader.reportManager.GeneratorGui.SetDaytimeSpeedCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.POSTROUND)
            {
                reportLoader.reportManager.GeneratorGui.SetPostRoundTimeCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.PREROUND)
            {
                reportLoader.reportManager.GeneratorGui.SetPreRoundTimeCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.RESPAWN)
            {
                reportLoader.reportManager.GeneratorGui.SetRespawnTimeCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.SCOREDM)
            {
                reportLoader.reportManager.GeneratorGui.SetScoresDMCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.SCORETDM)
            {
                reportLoader.reportManager.GeneratorGui.SetScoresTDMCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.SCORECTD)
            {
                reportLoader.reportManager.GeneratorGui.SetScoresCTDCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.SCOREUPR)
            {
                reportLoader.reportManager.GeneratorGui.SetScoresUPRCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.SHIELD)
            {
                reportLoader.reportManager.GeneratorGui.SetSpawnShieldCollection(collectionSettings, collectionDefaultValue);
            }
            else if (testGameSettings == Enum_SettingsGame.ZONE)
            {
                reportLoader.reportManager.GeneratorGui.SetZoneDeathTimeCollection(collectionSettings, collectionDefaultValue);
            }
        }
    }
}
