/// Loader class that handles Setting Lines for Weapon Classes.

using FC2SMG.Enums;

namespace FC2SMG.Reports.Loader
{
    internal class LoaderWeaponSettings
    {
        ReportLoader reportLoader;

        internal LoaderWeaponSettings(ReportLoader parent)
        {
            reportLoader = parent;
        }

        internal void HandleWeaponSettingsLine(string[] splitLine)
        {
            if (splitLine.Length != 4)
            {
                return;
            }

            Enum_SettingsWeapon testWeaponSettings;

            try
            {
                testWeaponSettings = (Enum_SettingsWeapon)Enum.Parse(typeof(Enum_SettingsWeapon), splitLine[1]);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Couldn't parse the following Setting Name:\r\n" + splitLine[1]);
                return;
            }

            if (testWeaponSettings == Enum_SettingsWeapon.GUN)
            {
                int weaponIndex = Convert.ToInt32(splitLine[2]);
                string weaponName = splitLine[3];

                reportLoader.reportManager.GeneratorGui.SetWeaponDropdownValue(weaponIndex, weaponName);
            }
            else if (testWeaponSettings == Enum_SettingsWeapon.MOD) // used for knife-only/1-weapon-only, noweapon or other special ones in future.
            {
                // ..
            }
        }
    }
}
