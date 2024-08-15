using FC2modHandler;
using FC2SMG.Enums;

namespace ServerModGenerator
{
    class XMLParser
    {
        private GeneratorGUI Generatorgui;
        private WeaponCollections weaponCollections;

        public XMLParser(GeneratorGUI Generatorgui)
        {
            this.Generatorgui = Generatorgui;
            weaponCollections = Generatorgui.GetWeaponCollections();
        }

        string[] content;
        int currentLine = 0;
        public void ParseXML(GibbedPatchHandler gibbedPatchHandler, string outputName)
        {
            ModesXMLhandler XMLReader = new();

            string unpackedGameModesXMLfilePath = gibbedPatchHandler.GetPathgamemodesconfig(Strings.SelectedPatchFileName);

            content = File.ReadAllLines(unpackedGameModesXMLfilePath);
            currentLine = 0;

            int LastUsedSetting = 0;

            // Handle Collections
            if (Generatorgui.GetPreRoundTimeCollection() != "")
            {
                string[] values = Generatorgui.GetPreRoundTimeCollection().Split(';');
                LastUsedSetting = XMLReader.GetIndexOfSettingPreRoundTime(content);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetPreRoundTimeDefaultValue(), LastUsedSetting);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.PREROUND, Generatorgui.GetPreRoundTimeCollection(), Generatorgui.GetPreRoundTimeDefaultValue());
            }
            if (Generatorgui.GetPostRoundTimeCollection() != "")
            {
                string[] values = Generatorgui.GetPostRoundTimeCollection().Split(';');
                LastUsedSetting = XMLReader.GetIndexOfSettingPostRoundTime(content);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetPostRoundTimeDefaultValue(), LastUsedSetting);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.POSTROUND, Generatorgui.GetPostRoundTimeCollection(), Generatorgui.GetPostRoundTimeDefaultValue());
            }
            if (Generatorgui.GetRespawnTimeCollection() != "")
            {
                string[] values = Generatorgui.GetRespawnTimeCollection().Split(';');
                LastUsedSetting = XMLReader.GetIndexOfSettingRespawnTime(content);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetRespawnTimeDefaultValue(), LastUsedSetting);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.RESPAWN, Generatorgui.GetRespawnTimeCollection(), Generatorgui.GetRespawnTimeDefaultValue());
            }
            if (Generatorgui.GetSpawnShieldCollection() != "")
            {
                string[] values = Generatorgui.GetSpawnShieldCollection().Split(';');
                LastUsedSetting = XMLReader.GetIndexOfSettingRespawnShield(content, LastUsedSetting);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetSpawnShieldDefaultValue(), LastUsedSetting);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.SHIELD, Generatorgui.GetSpawnShieldCollection(), Generatorgui.GetSpawnShieldDefaultValue());
            }
            if (Generatorgui.GetDaytimeSpeedCollection() != "")
            {
                string[] values = Generatorgui.GetDaytimeSpeedCollection().Split(';');
                LastUsedSetting = XMLReader.GetIndexOfSettingDaytimeSpeed(content, LastUsedSetting);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetDaytimeSpeedDefaultValue(), LastUsedSetting);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.DAYSPEED, Generatorgui.GetDaytimeSpeedCollection(), Generatorgui.GetDaytimeSpeedDefaultValue());
            }
            if (Generatorgui.GetZoneDeathTimeCollection() != "")
            {
                string[] values = Generatorgui.GetZoneDeathTimeCollection().Split(';');
                LastUsedSetting = XMLReader.GetIndexOfSettingZoneDeathTimeout(content, LastUsedSetting);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetZoneDeathTimeDefaultValue(), LastUsedSetting);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.ZONE, Generatorgui.GetZoneDeathTimeCollection(), Generatorgui.GetZoneDeathTimeDefaultValue());
            }
            if (Generatorgui.GetRespawnTimeCollection() != "") // Add same collection as RespawnTime in RespawnWave
            {
                string[] values = Generatorgui.GetRespawnTimeCollection().Split(';');
                LastUsedSetting = XMLReader.GetIndexOfSettingRespawnWave(content, LastUsedSetting);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetRespawnTimeDefaultValue(), LastUsedSetting);
            }
            // SCORE collections
            if (Generatorgui.GetScoresDMCollection() != "")
            {
                string[] values = Generatorgui.GetScoresDMCollection().Split(';');
                int IndexDMScores = XMLReader.GetIndexOfScoresGameMode("DM", content);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetScoresDMDefaultValue(), IndexDMScores);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.SCOREDM, Generatorgui.GetScoresDMCollection(), Generatorgui.GetScoresDMDefaultValue());
            }
            if (Generatorgui.GetScoresTDMCollection() != "")
            {
                string[] values = Generatorgui.GetScoresTDMCollection().Split(';');
                int IndexTDMScores = XMLReader.GetIndexOfScoresGameMode("TDM", content);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetScoresTDMDefaultValue(), IndexTDMScores);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.SCORETDM, Generatorgui.GetScoresTDMCollection(), Generatorgui.GetScoresTDMDefaultValue());
            }
            if (Generatorgui.GetScoresCTDCollection() != "")
            {
                string[] values = Generatorgui.GetScoresCTDCollection().Split(';');
                int IndexCTDScores = XMLReader.GetIndexOfScoresGameMode("CTD", content);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetScoresCTDDefaultValue(), IndexCTDScores);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.SCORECTD, Generatorgui.GetScoresCTDCollection(), Generatorgui.GetScoresCTDDefaultValue());
            }
            if (Generatorgui.GetScoresUPRCollection() != "")
            {
                string[] values = Generatorgui.GetScoresUPRCollection().Split(';');
                int IndexUPRScores = XMLReader.GetIndexOfScoresGameMode("UPR", content);
                content = XMLReader.AddSettingValues(content, values, Generatorgui.GetScoresUPRDefaultValue(), IndexUPRScores);
                Generatorgui.reportManager.builder.AddReportLineForCollection(Enum_ModType.GAMESETTING, Enum_SettingsGame.SCOREUPR, Generatorgui.GetScoresUPRCollection(), Generatorgui.GetScoresUPRDefaultValue());
            }

            HandleWeaponChanges(XMLReader);

            File.WriteAllLines(unpackedGameModesXMLfilePath, content);
        }

        private void HandleWeaponChanges(ModesXMLhandler XMLReader)
        {
            int IndexLoadOutService = XMLReader.GetIndexOfLoadOutService(content);
            if (IndexLoadOutService != -1)
            {
                currentLine = IndexLoadOutService;
                // Browse through lines to change weapons till Equipment-tag closes.
                while (!content[currentLine + 1].Contains("</Equipment>"))
                {
                    currentLine++;
                    CheckWeaponLine();
                }
                currentLine++;
                //MessageBox.Show("End of <Equipment> reached at line " + (currentLine + 1));
            }
        }

        private void CheckWeaponLine()
        {
            string trimmedLine = content[currentLine].TrimStart();
            if (trimmedLine.StartsWith("<Item name="))
            {
                ReplaceWeapon(trimmedLine);
            }
        }

        private void ReplaceWeapon(string trimmedLine)
        {
            //<Item name="MP5" locId="Items;mp5" category="Primary"      archetype="weapons.Primary.MP5.Multi"                   icon="gun_icon_MP5SD">
            string[] splitWeaponLine = trimmedLine.Split('"');
            string weaponCode = splitWeaponLine[1];
            int weaponIndex = Array.IndexOf(weaponCollections.GetWeaponCodes(), weaponCode);
            if (weaponIndex != -1)
            {
                if (Generatorgui.WeaponDropdownAll[weaponIndex].SelectedIndex == 0)
                {                    
                    return;
                }

                if (Generatorgui.WeaponDropdownAll[weaponIndex].Text != "Disable")
                {
                    string selectedWeaponName = Generatorgui.WeaponDropdownAll[weaponIndex].Text;
                    string weaponState = selectedWeaponName.StartsWith("SP_") ? "" : ".Multi";
                    string pureWeaponName = selectedWeaponName.StartsWith("SP_") ? selectedWeaponName[3..] : selectedWeaponName;
                    string newWeaponCode;
                    string newArcheType;
                    if (weaponCollections.IsWeaponFortunes(selectedWeaponName))
                    {
                        newWeaponCode = weaponCollections.GetWeaponNameToCodeConverter()[pureWeaponName];
                        newArcheType = "DLC1Weapons.DLC1." + newWeaponCode + weaponState;
                    }
                    else
                    {
                        newWeaponCode = weaponCollections.GetWeaponNameToCodeConverter()[pureWeaponName];
                        string finalWeaponCode = CheckAlternateWeaponCode(newWeaponCode);
                        newArcheType = "weapons." + weaponCollections.GetWeaponCategory(newWeaponCode) + "." + finalWeaponCode + weaponState;
                    }

                    splitWeaponLine[7] = newArcheType;
                    Generatorgui.reportManager.builder.AddReportLineForWeapon(Enum_ModType.WEAPON, Enum_SettingsWeapon.GUN, weaponIndex, Generatorgui.WeaponDropdownAll[weaponIndex].Text);
                }
                else
                {
                    splitWeaponLine[7] = "weapons." + weaponCollections.GetWeaponCategory(weaponCode) + ".None";
                    Generatorgui.reportManager.builder.AddReportLineForWeapon(Enum_ModType.WEAPON, Enum_SettingsWeapon.GUN, weaponIndex, "Disable");
                }

                content[currentLine] = "                    " + string.Join("\"", splitWeaponLine);
            }
        }

        private string CheckAlternateWeaponCode(string newWeaponCode)
        {
            //MessageBox.Show("Got newWeaponCode to (change &) place: " + newWeaponCode);
            if (newWeaponCode == WeaponCode.Flamethrower)
            {
                return "LPO50";
            }
            else if (newWeaponCode == WeaponCode.Flare)
            {
                return "Flare_Gun";
            }
            else if (newWeaponCode == WeaponCode.Silent6P9)
            {
                return "SilencedMakarov_6P9";
            }
            else
            {
                return newWeaponCode.Replace(' ', '_');
            }
        }
    }
}
