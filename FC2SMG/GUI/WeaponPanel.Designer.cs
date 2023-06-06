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
            this.pMain = new System.Windows.Forms.Panel();
            this.lLoadoutPrimary = new System.Windows.Forms.Label();
            this.lLoadoutSecondary = new System.Windows.Forms.Label();
            this.comboxPrimary1 = new System.Windows.Forms.ComboBox();
            this.comboxPrimary2 = new System.Windows.Forms.ComboBox();
            this.comboxPrimary3 = new System.Windows.Forms.ComboBox();
            this.comboxSecondary1 = new System.Windows.Forms.ComboBox();
            this.comboxSecondary2 = new System.Windows.Forms.ComboBox();
            this.lClassName = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.lLoadoutPrimary);
            this.pMain.Controls.Add(this.lLoadoutSecondary);
            this.pMain.Controls.Add(this.comboxPrimary1);
            this.pMain.Controls.Add(this.comboxPrimary2);
            this.pMain.Controls.Add(this.comboxPrimary3);
            this.pMain.Controls.Add(this.comboxSecondary1);
            this.pMain.Controls.Add(this.comboxSecondary2);
            this.pMain.Controls.Add(this.lClassName);
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(310, 137);
            this.pMain.TabIndex = 17;
            // 
            // lLoadoutPrimary
            // 
            this.lLoadoutPrimary.AutoSize = true;
            this.lLoadoutPrimary.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lLoadoutPrimary.Location = new System.Drawing.Point(4, 18);
            this.lLoadoutPrimary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLoadoutPrimary.Name = "lLoadoutPrimary";
            this.lLoadoutPrimary.Size = new System.Drawing.Size(52, 17);
            this.lLoadoutPrimary.TabIndex = 1;
            this.lLoadoutPrimary.Text = "Primary";
            // 
            // lLoadoutSecondary
            // 
            this.lLoadoutSecondary.AutoSize = true;
            this.lLoadoutSecondary.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lLoadoutSecondary.Location = new System.Drawing.Point(155, 18);
            this.lLoadoutSecondary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLoadoutSecondary.Name = "lLoadoutSecondary";
            this.lLoadoutSecondary.Size = new System.Drawing.Size(70, 17);
            this.lLoadoutSecondary.TabIndex = 2;
            this.lLoadoutSecondary.Text = "Secondary";
            // 
            // comboxPrimary1
            // 
            this.comboxPrimary1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxPrimary1.FormattingEnabled = true;
            this.comboxPrimary1.Location = new System.Drawing.Point(8, 40);
            this.comboxPrimary1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxPrimary1.Name = "comboxPrimary1";
            this.comboxPrimary1.Size = new System.Drawing.Size(142, 21);
            this.comboxPrimary1.TabIndex = 3;
            this.comboxPrimary1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IndexChanged);
            this.comboxPrimary1.Click += new System.EventHandler(this.CacheCurrentIndex);
            // 
            // comboxPrimary2
            // 
            this.comboxPrimary2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxPrimary2.FormattingEnabled = true;
            this.comboxPrimary2.Location = new System.Drawing.Point(8, 71);
            this.comboxPrimary2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxPrimary2.Name = "comboxPrimary2";
            this.comboxPrimary2.Size = new System.Drawing.Size(142, 21);
            this.comboxPrimary2.TabIndex = 4;
            this.comboxPrimary2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IndexChanged);
            this.comboxPrimary2.Click += new System.EventHandler(this.CacheCurrentIndex);
            // 
            // comboxPrimary3
            // 
            this.comboxPrimary3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxPrimary3.FormattingEnabled = true;
            this.comboxPrimary3.Location = new System.Drawing.Point(8, 103);
            this.comboxPrimary3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxPrimary3.Name = "comboxPrimary3";
            this.comboxPrimary3.Size = new System.Drawing.Size(142, 21);
            this.comboxPrimary3.TabIndex = 5;
            this.comboxPrimary3.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IndexChanged);
            this.comboxPrimary3.Click += new System.EventHandler(this.CacheCurrentIndex);
            // 
            // comboxSecondary1
            // 
            this.comboxSecondary1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxSecondary1.FormattingEnabled = true;
            this.comboxSecondary1.Location = new System.Drawing.Point(158, 40);
            this.comboxSecondary1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxSecondary1.Name = "comboxSecondary1";
            this.comboxSecondary1.Size = new System.Drawing.Size(142, 21);
            this.comboxSecondary1.TabIndex = 6;
            this.comboxSecondary1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IndexChanged);
            this.comboxSecondary1.Click += new System.EventHandler(this.CacheCurrentIndex);
            // 
            // comboxSecondary2
            // 
            this.comboxSecondary2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxSecondary2.FormattingEnabled = true;
            this.comboxSecondary2.Location = new System.Drawing.Point(158, 71);
            this.comboxSecondary2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboxSecondary2.Name = "comboxSecondary2";
            this.comboxSecondary2.Size = new System.Drawing.Size(142, 21);
            this.comboxSecondary2.TabIndex = 7;
            this.comboxSecondary2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IndexChanged);
            this.comboxSecondary2.Click += new System.EventHandler(this.CacheCurrentIndex);
            // 
            // lClassName
            // 
            this.lClassName.AutoSize = true;
            this.lClassName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lClassName.Location = new System.Drawing.Point(3, -3);
            this.lClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lClassName.Name = "lClassName";
            this.lClassName.Size = new System.Drawing.Size(93, 21);
            this.lClassName.TabIndex = 0;
            this.lClassName.Text = "ClassName";
            // 
            // WeaponPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WeaponPanel";
            this.Size = new System.Drawing.Size(315, 144);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

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
