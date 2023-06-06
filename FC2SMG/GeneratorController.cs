using FC2SMG.Enums;
using ServerModGenerator.GUI;

namespace ServerModGenerator
{
    class GeneratorController
    {
        private GeneratorGUI Generatorgui;
        int rowIndex = 0;
        int ColumnIndex = 0;
        readonly int WeaponPanelWidth = 310;
        readonly int WeaponPanelHeight = 137;
        readonly int spaceBetweenPanels = 5;

        ComboBox[] linkedComboBoxesBomb = new ComboBox[2];
        ComboBox[] linkedComboBoxesPistol = new ComboBox[2];
        ComboBox[] linkedComboBoxesMAC = new ComboBox[2];

        public GeneratorController(GeneratorGUI Generatorgui)
        {
            this.Generatorgui = Generatorgui;
        }

        public void AddDefaultLoadout()
        {
            WeaponPanel commando = new();
            commando.SetClassName("Commando");
            commando.SetDefaultWeapon(Enum_LoadOut.Primary1, WeaponName.G3);
            commando.SetDefaultWeapon(Enum_LoadOut.Primary2, WeaponName.AK47);
            commando.SetDefaultWeapon(Enum_LoadOut.Primary3, WeaponName.FNFAL);
            commando.SetDefaultWeapon(Enum_LoadOut.Secondary1, WeaponName.Star45);
            commando.SetDefaultWeapon(Enum_LoadOut.Secondary2, WeaponName.GL);
            commando.Location = GetLocationForPlacement();
            Generatorgui.AddWeaponPanel(commando);
            IncreaseColumnIndex();
            WeaponPanel sniper = new();
            sniper.SetClassName("Sharpshooter");
            sniper.SetDefaultWeapon(Enum_LoadOut.Primary1, WeaponName.M1903);
            sniper.SetDefaultWeapon(Enum_LoadOut.Primary2, WeaponName.Dragunov);
            sniper.SetDefaultWeapon(Enum_LoadOut.Primary3, WeaponName.AS50);
            sniper.SetDefaultWeapon(Enum_LoadOut.Secondary1, WeaponName.Makarov);
            sniper.SetDefaultWeapon(Enum_LoadOut.Secondary2, WeaponName.Flare);
            sniper.Location = GetLocationForPlacement();
            Generatorgui.AddWeaponPanel(sniper);
            IncreaseColumnIndex();
            WeaponPanel shotgun = new();
            shotgun.SetClassName("Guerilla");
            shotgun.SetDefaultWeapon(Enum_LoadOut.Primary1, WeaponName.Homeland);
            shotgun.SetDefaultWeapon(Enum_LoadOut.Primary2, WeaponName.SPAS);
            shotgun.SetDefaultWeapon(Enum_LoadOut.Primary3, WeaponName.USAS);
            shotgun.SetDefaultWeapon(Enum_LoadOut.Secondary1, WeaponName.MAC10);
            shotgun.SetDefaultWeapon(Enum_LoadOut.Secondary2, WeaponName.IED);
            shotgun.Location = GetLocationForPlacement();
            Generatorgui.AddWeaponPanel(shotgun);
            IncreaseColumnIndex();
            WeaponPanel rebel = new();
            rebel.SetClassName("Rebel");
            rebel.SetDefaultWeapon(Enum_LoadOut.Primary1, WeaponName.Flamethrower);
            rebel.SetDefaultWeapon(Enum_LoadOut.Primary2, WeaponName.RPG);
            rebel.SetDefaultWeapon(Enum_LoadOut.Primary3, WeaponName.MGL);
            rebel.SetDefaultWeapon(Enum_LoadOut.Secondary1, WeaponName.Makarov);
            rebel.SetDefaultWeapon(Enum_LoadOut.Secondary2, WeaponName.Uzi);
            rebel.Location = GetLocationForPlacement();
            Generatorgui.AddWeaponPanel(rebel);
            IncreaseColumnIndex();
            WeaponPanel gunner = new();
            gunner.SetClassName("Gunner");
            gunner.SetDefaultWeapon(Enum_LoadOut.Primary1, WeaponName.PKM);
            gunner.SetDefaultWeapon(Enum_LoadOut.Primary2, WeaponName.CarlG);
            gunner.SetDefaultWeapon(Enum_LoadOut.Primary3, WeaponName.M249SAW);
            gunner.SetDefaultWeapon(Enum_LoadOut.Secondary1, WeaponName.Eagle);
            gunner.SetDefaultWeapon(Enum_LoadOut.Secondary2, WeaponName.MAC10);
            gunner.Location = GetLocationForPlacement();
            Generatorgui.AddWeaponPanel(gunner);
            IncreaseColumnIndex();
            WeaponPanel saboteur = new();
            saboteur.SetClassName("Saboteur");
            saboteur.SetDefaultWeapon(Enum_LoadOut.Primary1, WeaponName.Dart);
            saboteur.SetDefaultWeapon(Enum_LoadOut.Primary2, WeaponName.MP5);
            saboteur.SetDefaultWeapon(Enum_LoadOut.Primary3, WeaponName.AR);
            saboteur.SetDefaultWeapon(Enum_LoadOut.Secondary1, WeaponName.Silent6P9);
            saboteur.SetDefaultWeapon(Enum_LoadOut.Secondary2, WeaponName.IED);
            saboteur.Location = GetLocationForPlacement();
            Generatorgui.AddWeaponPanel(saboteur);

            linkedComboBoxesBomb[0] = shotgun.GetUpgradedSecondaryWeapon();
            linkedComboBoxesBomb[1] = saboteur.GetUpgradedSecondaryWeapon();
            shotgun.GetUpgradedSecondaryWeapon().SelectedIndexChanged += new(comboxUpgradedSecondaryWeapon_SelectedIndexChanged);
            saboteur.GetUpgradedSecondaryWeapon().SelectedIndexChanged += new(comboxUpgradedSecondaryWeapon_SelectedIndexChanged);

            linkedComboBoxesPistol[0] = sniper.GetFirstSecondaryWeapon();
            linkedComboBoxesPistol[1] = rebel.GetFirstSecondaryWeapon();
            sniper.GetFirstSecondaryWeapon().SelectedIndexChanged += new(comboxFirstSecondaryWeapon_SelectedIndexChanged);
            rebel.GetFirstSecondaryWeapon().SelectedIndexChanged += new(comboxFirstSecondaryWeapon_SelectedIndexChanged);

            linkedComboBoxesMAC[0] = shotgun.GetFirstSecondaryWeapon();
            linkedComboBoxesMAC[1] = gunner.GetUpgradedSecondaryWeapon();
            shotgun.GetFirstSecondaryWeapon().SelectedIndexChanged += new(comboxMixedSecondaryWeapon_SelectedIndexChanged);
            gunner.GetUpgradedSecondaryWeapon().SelectedIndexChanged += new(comboxMixedSecondaryWeapon_SelectedIndexChanged);

            //IncreaseColumnIndex();
            //WeaponPanel fake = new();
            //fake.SetClassName("Fake");
            //fake.SetDefaultWeapon(Enum_LoadOut.Primary1, WeaponName.M1903);
            //fake.SetDefaultWeapon(Enum_LoadOut.Primary2, WeaponName.Dragunov);
            //fake.SetDefaultWeapon(Enum_LoadOut.Primary3, WeaponName.AS50);
            //fake.SetDefaultWeapon(Enum_LoadOut.Secondary1, WeaponName.Makarov);
            //fake.SetDefaultWeapon(Enum_LoadOut.Secondary2, WeaponName.Flare);
            //fake.Location = GetLocationForPlacement();
            //Generatorgui.AddWeaponPanel(fake);
        }

        private void comboxUpgradedSecondaryWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox weaponBox = (ComboBox)sender;
            if (weaponBox == linkedComboBoxesBomb[0])
            {
                linkedComboBoxesBomb[1].SelectedIndex = weaponBox.SelectedIndex;
            }
            else if (weaponBox == linkedComboBoxesBomb[1])
            {
                linkedComboBoxesBomb[0].SelectedIndex = weaponBox.SelectedIndex;
            }
        }

        private void comboxFirstSecondaryWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox weaponBox = (ComboBox)sender;
            if (weaponBox == linkedComboBoxesPistol[0])
            {
                linkedComboBoxesPistol[1].SelectedIndex = weaponBox.SelectedIndex;
            }
            else if (weaponBox == linkedComboBoxesPistol[1])
            {
                linkedComboBoxesPistol[0].SelectedIndex = weaponBox.SelectedIndex;
            }
        }

        private void comboxMixedSecondaryWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox weaponBox = (ComboBox)sender;
            if (weaponBox == linkedComboBoxesMAC[0])
            {
                linkedComboBoxesMAC[1].SelectedIndex = weaponBox.SelectedIndex;
            }
            else if (weaponBox == linkedComboBoxesMAC[1])
            {
                linkedComboBoxesMAC[0].SelectedIndex = weaponBox.SelectedIndex;
            }
        }

        private Point GetLocationForPlacement()
        {
            return new Point(ColumnIndex * WeaponPanelWidth + ColumnIndex * spaceBetweenPanels, rowIndex * WeaponPanelHeight + rowIndex * spaceBetweenPanels);
        }

        private void IncreaseColumnIndex()
        {
            if (ColumnIndex < 2)
            {
                ColumnIndex++;
                return;
            }
            ColumnIndex = 0;
            rowIndex++;
        }

        public void FillDropDowns()
        {
            AddWeaponsPrimary();
            AddWeaponsSecondary();
            AddWeaponDisableOption();
        }

        private void AddWeaponsPrimary()
        {
            foreach (ComboBox primaryWeaponBox in Generatorgui.WeaponDropDownPrimary)
            {
                primaryWeaponBox.Items.Add("=== PRIMARY ===");

                foreach (string primaryWeapon in Generatorgui.GetWeaponCollections().GetWeaponsPrimary())
                {
                    if ((string)primaryWeaponBox.Items[0] != primaryWeapon)
                    {
                        primaryWeaponBox.Items.Add(primaryWeapon);
                    }
                }

                primaryWeaponBox.Items.Add("== SECONDARY ==");

                foreach (string secondaryWeapon in Generatorgui.GetWeaponCollections().GetWeaponsSecondary())
                {
                    primaryWeaponBox.Items.Add(secondaryWeapon);
                }
            }
        }

        private void AddWeaponsSecondary()
        {
            foreach (ComboBox secondaryWeaponBox in Generatorgui.WeaponDropDownSecondary)
            {
                secondaryWeaponBox.Items.Add("== SECONDARY ==");

                foreach (string secondaryWeapon in Generatorgui.GetWeaponCollections().GetWeaponsSecondary())
                {
                    if ((string)secondaryWeaponBox.Items[0] != secondaryWeapon)
                    {
                        secondaryWeaponBox.Items.Add(secondaryWeapon);
                    }
                }

                secondaryWeaponBox.Items.Add("=== PRIMARY ===");

                foreach (string primaryWeapon in Generatorgui.GetWeaponCollections().GetWeaponsPrimary())
                {
                    secondaryWeaponBox.Items.Add(primaryWeapon);
                }
            }
        }

        private void AddWeaponDisableOption()
        {
            foreach (ComboBox combobox in Generatorgui.WeaponDropDownPrimary)
            {
                combobox.Items.Add("=== OTHERS ===");
                combobox.Items.Add("Disable");
            }
            foreach (ComboBox combobox in Generatorgui.WeaponDropDownSecondary)
            {
                combobox.Items.Add("=== OTHERS ===");
                combobox.Items.Add("Disable");
            }
        }
    }
}
