using System;

namespace ServerModGenerator
{
    public static class Strings
    {
        public static string SMG_Version { get { return "v20230606"; } }

        public static string MsgBox_TitleInfo { get { return "Setting Info"; } }

        // Paths
        static readonly string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string RootFC2SMG { get { return ApplicationData + @"\FC2SMG\"; } }
        public static string FC2SMGsettingsFile { get { return RootFC2SMG + @"settings.ini"; } }
        public static string ReportFileName { get { return "Report.txt"; } }
        public static string SelectedPatchFileName { get; set; } = "";
        public static string SelectedPatchFilePath { get; set; } = "";
        public static string GameFolderPath { get; set; } = "";
        public static string GibbedPath { get; set; } = "";
        public static string PatchExportPath { get; set; } = "";
        public static string DefaultPatchFile { get; set; } = "";
        public static string ServerLauncherPath { get; set; } = "";
    }
}
