namespace ServerModGenerator.GUI
{
    partial class WeaponPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pMain = new Panel();
            lLoadoutPrimary = new Label();
            lLoadoutSecondary = new Label();
            comboxPrimary1 = new ComboBox();
            comboxPrimary2 = new ComboBox();
            comboxPrimary3 = new ComboBox();
            comboxSecondary1 = new ComboBox();
            comboxSecondary2 = new ComboBox();
            lClassName = new Label();
            pMain.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(lLoadoutPrimary);
            pMain.Controls.Add(lLoadoutSecondary);
            pMain.Controls.Add(comboxPrimary1);
            pMain.Controls.Add(comboxPrimary2);
            pMain.Controls.Add(comboxPrimary3);
            pMain.Controls.Add(comboxSecondary1);
            pMain.Controls.Add(comboxSecondary2);
            pMain.Controls.Add(lClassName);
            pMain.Location = new Point(0, 0);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(350, 137);
            pMain.TabIndex = 17;
            // 
            // lLoadoutPrimary
            // 
            lLoadoutPrimary.AutoSize = true;
            lLoadoutPrimary.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lLoadoutPrimary.Location = new Point(4, 18);
            lLoadoutPrimary.Margin = new Padding(4, 0, 4, 0);
            lLoadoutPrimary.Name = "lLoadoutPrimary";
            lLoadoutPrimary.Size = new Size(52, 17);
            lLoadoutPrimary.TabIndex = 1;
            lLoadoutPrimary.Text = "Primary";
            // 
            // lLoadoutSecondary
            // 
            lLoadoutSecondary.AutoSize = true;
            lLoadoutSecondary.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lLoadoutSecondary.Location = new Point(178, 18);
            lLoadoutSecondary.Margin = new Padding(4, 0, 4, 0);
            lLoadoutSecondary.Name = "lLoadoutSecondary";
            lLoadoutSecondary.Size = new Size(70, 17);
            lLoadoutSecondary.TabIndex = 2;
            lLoadoutSecondary.Text = "Secondary";
            // 
            // comboxPrimary1
            // 
            comboxPrimary1.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxPrimary1.FormattingEnabled = true;
            comboxPrimary1.Location = new Point(8, 40);
            comboxPrimary1.Margin = new Padding(4, 3, 4, 3);
            comboxPrimary1.Name = "comboxPrimary1";
            comboxPrimary1.Size = new Size(165, 21);
            comboxPrimary1.TabIndex = 3;
            comboxPrimary1.SelectedIndexChanged += ComboBox_IndexChanged;
            comboxPrimary1.Click += CacheCurrentIndex;
            // 
            // comboxPrimary2
            // 
            comboxPrimary2.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxPrimary2.FormattingEnabled = true;
            comboxPrimary2.Location = new Point(8, 71);
            comboxPrimary2.Margin = new Padding(4, 3, 4, 3);
            comboxPrimary2.Name = "comboxPrimary2";
            comboxPrimary2.Size = new Size(165, 21);
            comboxPrimary2.TabIndex = 4;
            comboxPrimary2.SelectedIndexChanged += ComboBox_IndexChanged;
            comboxPrimary2.Click += CacheCurrentIndex;
            // 
            // comboxPrimary3
            // 
            comboxPrimary3.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxPrimary3.FormattingEnabled = true;
            comboxPrimary3.Location = new Point(8, 103);
            comboxPrimary3.Margin = new Padding(4, 3, 4, 3);
            comboxPrimary3.Name = "comboxPrimary3";
            comboxPrimary3.Size = new Size(165, 21);
            comboxPrimary3.TabIndex = 5;
            comboxPrimary3.SelectedIndexChanged += ComboBox_IndexChanged;
            comboxPrimary3.Click += CacheCurrentIndex;
            // 
            // comboxSecondary1
            // 
            comboxSecondary1.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxSecondary1.FormattingEnabled = true;
            comboxSecondary1.Location = new Point(181, 40);
            comboxSecondary1.Margin = new Padding(4, 3, 4, 3);
            comboxSecondary1.Name = "comboxSecondary1";
            comboxSecondary1.Size = new Size(165, 21);
            comboxSecondary1.TabIndex = 6;
            comboxSecondary1.SelectedIndexChanged += ComboBox_IndexChanged;
            comboxSecondary1.Click += CacheCurrentIndex;
            // 
            // comboxSecondary2
            // 
            comboxSecondary2.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboxSecondary2.FormattingEnabled = true;
            comboxSecondary2.Location = new Point(181, 71);
            comboxSecondary2.Margin = new Padding(4, 3, 4, 3);
            comboxSecondary2.Name = "comboxSecondary2";
            comboxSecondary2.Size = new Size(165, 21);
            comboxSecondary2.TabIndex = 7;
            comboxSecondary2.SelectedIndexChanged += ComboBox_IndexChanged;
            comboxSecondary2.Click += CacheCurrentIndex;
            // 
            // lClassName
            // 
            lClassName.AutoSize = true;
            lClassName.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lClassName.Location = new Point(3, -3);
            lClassName.Margin = new Padding(4, 0, 4, 0);
            lClassName.Name = "lClassName";
            lClassName.Size = new Size(93, 21);
            lClassName.TabIndex = 0;
            lClassName.Text = "ClassName";
            // 
            // WeaponPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "WeaponPanel";
            Size = new Size(355, 140);
            pMain.ResumeLayout(false);
            pMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lLoadoutPrimary;
        private System.Windows.Forms.Label lLoadoutSecondary;
        private System.Windows.Forms.ComboBox comboxPrimary1;
        private System.Windows.Forms.ComboBox comboxPrimary2;
        private System.Windows.Forms.ComboBox comboxPrimary3;
        private System.Windows.Forms.ComboBox comboxSecondary1;
        private System.Windows.Forms.ComboBox comboxSecondary2;
        private System.Windows.Forms.Label lClassName;
    }
}
