using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerModGenerator
{
    public class WeaponCollections
    {
        public WeaponCollections()
        {
            BuildDictionaries();
        }

        private string[] WeaponsPrimary = new string[] { WeaponName.G3, WeaponName.AK47, WeaponName.FNFAL,
                                                         WeaponName.M1903, WeaponName.Dragunov, WeaponName.AS50,
                                                         WeaponName.Homeland, WeaponName.SPAS, WeaponName.USAS,
                                                         WeaponName.Flamethrower, WeaponName.RPG, WeaponName.MGL,
                                                         WeaponName.PKM, WeaponName.CarlG, WeaponName.M249SAW,
                                                         WeaponName.Dart, WeaponName.MP5, WeaponName.AR
        };
        private string[] WeaponsPrimarySP = new string[] { WeaponName.SP_G3, WeaponName.SP_AK47, WeaponName.SP_FNFAL,
                                                           WeaponName.SP_M1903, WeaponName.SP_Dragunov, WeaponName.SP_AS50,
                                                           WeaponName.SP_Homeland, WeaponName.SP_SPAS, WeaponName.SP_USAS,
                                                           WeaponName.SP_Flamethrower, WeaponName.SP_RPG, WeaponName.SP_MGL,
                                                           WeaponName.SP_PKM, WeaponName.SP_CarlG, WeaponName.SP_M249SAW,
                                                           WeaponName.SP_Dart, WeaponName.SP_MP5, WeaponName.SP_AR
        };
        private string[] WeaponsSecondary = new string[] { WeaponName.Star45, WeaponName.GL,
                                                           WeaponName.Makarov, WeaponName.Flare,
                                                           WeaponName.MAC10, WeaponName.IED,
                                                           WeaponName.Uzi, WeaponName.Eagle, WeaponName.Silent6P9
        };
        private string[] WeaponsSecondarySP = new string[] { WeaponName.SP_Star45, WeaponName.SP_GL,
                                                             WeaponName.SP_Makarov, WeaponName.SP_Flare,
                                                             WeaponName.SP_MAC10, WeaponName.SP_IED,
                                                             WeaponName.SP_Uzi, WeaponName.SP_Eagle, WeaponName.SP_Silent6P9
        };
        private string[] WeaponsFortunes = new string[] { WeaponName.Crossbow, WeaponName.SilentShotgun, WeaponName.SawedOffShotgun,
                                                          WeaponName.SP_Crossbow, WeaponName.SP_SilentShotgun, WeaponName.SP_SawedOffShotgun
        };
        // Matches with combobox count/order!
        private string[] WeaponNames = new string[] { WeaponName.G3, WeaponName.AK47, WeaponName.FNFAL, WeaponName.Star45, WeaponName.GL,
                                                      WeaponName.M1903, WeaponName.Dragunov, WeaponName.AS50, WeaponName.Makarov, WeaponName.Flare,
                                                      WeaponName.Homeland, WeaponName.SPAS, WeaponName.USAS, WeaponName.MAC10, WeaponName.IED,
                                                      WeaponName.Flamethrower, WeaponName.RPG, WeaponName.MGL, WeaponName.Makarov, WeaponName.Uzi,
                                                      WeaponName.PKM, WeaponName.CarlG, WeaponName.M249SAW, WeaponName.Eagle, WeaponName.MAC10,
                                                      WeaponName.Dart, WeaponName.MP5, WeaponName.AR, WeaponName.Silent6P9, WeaponName.IED,
                                                      WeaponName.Crossbow, WeaponName.SilentShotgun, WeaponName.SawedOffShotgun
        };
        // Only FlameThrower doesn't use its own code, but the LPO50 value!
        private string[] WeaponCodes = new string[] { WeaponCode.G3, WeaponCode.AK47, WeaponCode.FNFAL, WeaponCode.Star45, WeaponCode.GL,
                                                      WeaponCode.M1903, WeaponCode.Dragunov, WeaponCode.AS50, WeaponCode.Makarov, WeaponCode.Flare,
                                                      WeaponCode.Homeland, WeaponCode.SPAS, WeaponCode.USAS, WeaponCode.MAC10, WeaponCode.IED,
                                                      WeaponCode.Flamethrower, WeaponCode.RPG, WeaponCode.MGL, WeaponCode.Makarov, WeaponCode.Uzi,
                                                      WeaponCode.PKM, WeaponCode.CarlG, WeaponCode.M249SAW, WeaponCode.Eagle, WeaponCode.MAC10,
                                                      WeaponCode.Dart, WeaponCode.MP5, WeaponCode.AR, WeaponCode.Silent6P9, WeaponCode.IED,
                                                      WeaponCode.Crossbow, WeaponCode.SilentShotgun, WeaponCode.SawedOffShotgun
        };
        private string[] WeaponArcheTypesSpecial = new string[] { WeaponName.M1903, WeaponName.Dart, WeaponName.PKM, WeaponName.RPG, WeaponName.Flamethrower, WeaponName.M249SAW, WeaponName.CarlG, WeaponName.Flare };

        private Dictionary<string, string> WeaponNameToCodeConverter = new();
        private Dictionary<string, string> WeaponCodeToNameConverter = new();

        private void BuildDictionaries()
        {
            for (int i = 0; i < WeaponNames.Length; i++)
            {
                if (!WeaponNameToCodeConverter.ContainsKey(WeaponNames[i]))
                {
                    WeaponNameToCodeConverter.Add(WeaponNames[i], WeaponCodes[i]);
                }
            }
            for (int i = 0; i < WeaponNames.Length; i++)
            {
                if (!WeaponCodeToNameConverter.ContainsKey(WeaponCodes[i]))
                {
                    WeaponCodeToNameConverter.Add(WeaponCodes[i], WeaponNames[i]);
                }
            }
        }

        public string[] GetWeaponsPrimary()
        {
            return WeaponsPrimary;
        }

        public string[] GetWeaponsPrimarySP()
        {
            return WeaponsPrimarySP;
        }

        public string[] GetWeaponsSecondary()
        {
            return WeaponsSecondary;
        }

        public string[] GetWeaponsSecondarySP()
        {
            return WeaponsSecondarySP;
        }

        public string[] GetWeaponsFortunes()
        {
            return WeaponsFortunes;
        }

        public string[] GetWeaponCodes()
        {
            return WeaponCodes;
        }

        public string[] GetWeaponArcheTypesSpecial()
        {
            return WeaponArcheTypesSpecial;
        }

        public Dictionary<string, string> GetWeaponNameToCodeConverter()
        {
            return WeaponNameToCodeConverter;
        }
        public Dictionary<string, string> GetWeaponCodeToNameConverter()
        {
            return WeaponCodeToNameConverter;
        }

        public string GetWeaponCategory(string newWeaponCode)
        {
            string weaponName = WeaponCodeToNameConverter[newWeaponCode];
            if (GetWeaponArcheTypesSpecial().Contains(weaponName))
            {
                return "Special";
            }
            else if (GetWeaponsPrimary().Contains(weaponName))
            {
                return "Primary";
            }
            else if (GetWeaponsSecondary().Contains(weaponName))
            {
                return "Secondary";
            }
            return "";
        }

        internal bool IsWeaponFortunes(string WeaponName)
        {
            return WeaponsFortunes.Contains(WeaponName);
        }
    }
}
