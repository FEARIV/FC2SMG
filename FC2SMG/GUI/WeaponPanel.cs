using FC2SMG.Enums;
using System;
using System.Windows.Forms;

namespace ServerModGenerator.GUI
{
    public partial class WeaponPanel : UserControl
    {
        private ComboBox[] LoadOutDropdowns;
        private ComboBox[] PrimaryWeaponDropdowns;
        private ComboBox[] SecondaryWeaponDropdowns;
        private int CachedDropDownIndex = -1;

        public WeaponPanel()
        {
            InitializeComponent();
            ColorGUI();
            
            LoadOutDropdowns = new ComboBox[] { comboxPrimary1, comboxPrimary2, comboxPrimary3, comboxSecondary1, comboxSecondary2 };
            PrimaryWeaponDropdowns = new ComboBox[] { comboxPrimary1, comboxPrimary2, comboxPrimary3 };
            SecondaryWeaponDropdowns = new ComboBox[] { comboxSecondary1, comboxSecondary2 };
        }

        private void ColorGUI()
        {
            pMain.BackColor = ColorBox.backGround;
            lClassName.ForeColor = ColorBox.textContent;
            comboxPrimary1.BackColor = ColorBox.backGround;
            comboxPrimary2.BackColor = ColorBox.backGround;
            comboxPrimary3.BackColor = ColorBox.backGround;
            comboxSecondary1.BackColor = ColorBox.backGround;
            comboxSecondary2.BackColor = ColorBox.backGround;
            comboxPrimary1.ForeColor = ColorBox.textContent;
            comboxPrimary2.ForeColor = ColorBox.textContent;
            comboxPrimary3.ForeColor = ColorBox.textContent;
            comboxSecondary1.ForeColor = ColorBox.textContent;
            comboxSecondary2.ForeColor = ColorBox.textContent;
            lLoadoutPrimary.ForeColor = ColorBox.textTitle;
            lLoadoutSecondary.ForeColor = ColorBox.textTitle;
        }

        internal ComboBox[] GetAllWeaponDropDowns()
        {
            return LoadOutDropdowns;
        }

        internal ComboBox[] GetPrimaryWeaponDropDowns()
        {
            return PrimaryWeaponDropdowns;
        }

        internal ComboBox GetFirstPrimaryWeaponDropDown()
        {
            return PrimaryWeaponDropdowns[0];
        }

        internal ComboBox GetSecondPrimaryWeaponDropDown()
        {
            return PrimaryWeaponDropdowns[1];
        }

        internal ComboBox GetFinalPrimaryWeaponDropDown()
        {
            return PrimaryWeaponDropdowns[2];
        }

        internal ComboBox[] GetSecondaryWeaponDropDowns()
        {
            return SecondaryWeaponDropdowns;
        }

        internal ComboBox GetFirstSecondaryWeaponDropdown()
        {
            return SecondaryWeaponDropdowns[0];
        }

        internal ComboBox GetUpgradedSecondaryWeaponDropdown()
        {
            return SecondaryWeaponDropdowns[1];
        }

        internal void SetClassName(string ClassName)
        {
            lClassName.Text = ClassName;
        }

        internal void SetDefaultWeapon(Enum_LoadOut loadOut, string WeaponName)
        {
            ComboBox selectedLoadOutDropdown = LoadOutDropdowns[(int)loadOut];
            if (selectedLoadOutDropdown.Items.Count == 0)
            {
                selectedLoadOutDropdown.Items.Add(WeaponName);
            }
        }

        private void CacheCurrentIndex(object sender, EventArgs e)
        {
            ComboBox activeBox = (ComboBox)sender;
            CachedDropDownIndex = activeBox.SelectedIndex;
        }

        private void ComboBox_IndexChanged(object sender, EventArgs e)
        {
            ComboBox activeBox = (ComboBox)sender;
            if (activeBox.Text.StartsWith("="))
            {
                activeBox.SelectedIndex = CachedDropDownIndex;
            }
        }
    }
}
