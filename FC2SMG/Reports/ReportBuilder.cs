/// Responsible for the Report content while adapting files in background
/// and eventually writing the final Report file.

using FC2SMG.Enums;
using ServerModGenerator;

namespace FC2SMG.Reports
{
    internal class ReportBuilder
    {
        ReportManager parent;
        List<string> reportList;

        internal ReportBuilder(ReportManager parent)
        {
            this.parent = parent;
            reportList = new();
        }

        internal void AddReportLineForWeapon(Enum_ModType modType, Enum_SettingsWeapon settingName, int weaponIndex, string content)
        {
            reportList.Add(modType.ToString() + "|" + settingName.ToString() + "|" + weaponIndex + "|" + content);
        }
        internal void AddReportLineForWeapon(Enum_ModType modType, Enum_SettingsWeapon settingName, string value, string content)
        {
            reportList.Add(modType.ToString() + "|" + settingName.ToString() + "|" + value + "|" + content);
        }

        internal void AddReportLineForServerLauncher(Enum_ModType modType, Enum_SettingsLauncher settingName, string content)
        {
            reportList.Add(modType.ToString() + "|" + settingName.ToString() + "|" + content);
        }

        internal void AddReportLineForCollection(Enum_ModType modType, Enum_SettingsGame settingName, string collectionValues, string selectedDefaultValue)
        {
            reportList.Add(modType.ToString() + "|" + settingName.ToString() + "|" + collectionValues + "|" + selectedDefaultValue);
        }

        internal void WriteReportFile()
        {
            string modPath = Strings.PatchExportPath + "\\" + parent.GeneratorGui.GetModFolderName() + "\\" + Strings.ReportFileName;
            File.WriteAllLines(modPath, reportList);
        }

        internal void ClearReportData()
        {
            reportList.Clear();
        }
    }
}
