namespace FC2SMG.GUI
{
    partial class fc2slPanel
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
            this.lPatchNameDefault = new System.Windows.Forms.Label();
            this.lHostNameDefault = new System.Windows.Forms.Label();
            this.cbHiddenUbiMaps = new System.Windows.Forms.CheckBox();
            this.tbPatchName = new System.Windows.Forms.TextBox();
            this.lPatchName = new System.Windows.Forms.Label();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.lHostName = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.lPatchNameDefault);
            this.pMain.Controls.Add(this.lHostNameDefault);
            this.pMain.Controls.Add(this.cbHiddenUbiMaps);
            this.pMain.Controls.Add(this.tbPatchName);
            this.pMain.Controls.Add(this.lPatchName);
            this.pMain.Controls.Add(this.tbHostName);
            this.pMain.Controls.Add(this.lHostName);
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(380, 158);
            this.pMain.TabIndex = 0;
            // 
            // lPatchNameDefault
            // 
            this.lPatchNameDefault.AutoSize = true;
            this.lPatchNameDefault.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPatchNameDefault.Location = new System.Drawing.Point(225, 37);
            this.lPatchNameDefault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPatchNameDefault.Name = "lPatchNameDefault";
            this.lPatchNameDefault.Size = new System.Drawing.Size(98, 17);
            this.lPatchNameDefault.TabIndex = 34;
            this.lPatchNameDefault.Text = "(default: patch)";
            // 
            // lHostNameDefault
            // 
            this.lHostNameDefault.AutoSize = true;
            this.lHostNameDefault.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHostNameDefault.Location = new System.Drawing.Point(225, 8);
            this.lHostNameDefault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHostNameDefault.Name = "lHostNameDefault";
            this.lHostNameDefault.Size = new System.Drawing.Size(137, 17);
            this.lHostNameDefault.TabIndex = 33;
            this.lHostNameDefault.Text = "(default: Anonymous)";
            // 
            // cbHiddenUbiMaps
            // 
            this.cbHiddenUbiMaps.AutoSize = true;
            this.cbHiddenUbiMaps.ForeColor = System.Drawing.Color.Gray;
            this.cbHiddenUbiMaps.Location = new System.Drawing.Point(6, 66);
            this.cbHiddenUbiMaps.Name = "cbHiddenUbiMaps";
            this.cbHiddenUbiMaps.Size = new System.Drawing.Size(158, 19);
            this.cbHiddenUbiMaps.TabIndex = 32;
            this.cbHiddenUbiMaps.Text = "Include hidden UBI maps";
            this.cbHiddenUbiMaps.UseVisualStyleBackColor = true;
            this.cbHiddenUbiMaps.CheckedChanged += new System.EventHandler(this.cbHiddenUbiMaps_CheckedChanged);
            // 
            // tbPatchName
            // 
            this.tbPatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPatchName.Location = new System.Drawing.Point(128, 34);
            this.tbPatchName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPatchName.MaxLength = 5;
            this.tbPatchName.Name = "tbPatchName";
            this.tbPatchName.Size = new System.Drawing.Size(93, 21);
            this.tbPatchName.TabIndex = 30;
            // 
            // lPatchName
            // 
            this.lPatchName.AutoSize = true;
            this.lPatchName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPatchName.Location = new System.Drawing.Point(4, 37);
            this.lPatchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPatchName.Name = "lPatchName";
            this.lPatchName.Size = new System.Drawing.Size(107, 17);
            this.lPatchName.TabIndex = 31;
            this.lPatchName.Text = "PatchName (<6):";
            // 
            // tbHostName
            // 
            this.tbHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHostName.Location = new System.Drawing.Point(128, 5);
            this.tbHostName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbHostName.MaxLength = 9;
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(93, 21);
            this.tbHostName.TabIndex = 27;
            // 
            // lHostName
            // 
            this.lHostName.AutoSize = true;
            this.lHostName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHostName.Location = new System.Drawing.Point(4, 8);
            this.lHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHostName.Name = "lHostName";
            this.lHostName.Size = new System.Drawing.Size(109, 17);
            this.lHostName.TabIndex = 28;
            this.lHostName.Text = "HostName (<10):";
            // 
            // fc2slPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pMain);
            this.Name = "fc2slPanel";
            this.Size = new System.Drawing.Size(390, 173);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pMain;
        private CheckBox cbHiddenUbiMaps;
        private TextBox tbPatchName;
        private Label lPatchName;
        private TextBox tbHostName;
        private Label lHostName;
        private Label lPatchNameDefault;
        private Label lHostNameDefault;
    }
}
