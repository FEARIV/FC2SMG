/// Root Report class managing the different task-classes for the Reports.

using FC2SMG.Reports.Loader;
using ServerModGenerator;

namespace FC2SMG.Reports
{
    internal class ReportManager
    {
        internal GeneratorGUI GeneratorGui;
        internal ReportBuilder builder;
        internal ReportLoader loader;

        internal ReportManager(GeneratorGUI GeneratorGui)
        {
            this.GeneratorGui = GeneratorGui;
            builder = new(this);
            loader = new(this);
        }
    }
}
