namespace FC2SMG.GUI
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSaveSettings = new Glass.GlassButton();
            this.bServerLauncherPath = new Glass.GlassButton();
            this.lServerLauncherPathL = new System.Windows.Forms.Label();
            this.bGibbedPath = new Glass.GlassButton();
            this.lGibbedPathL = new System.Windows.Forms.Label();
            this.lGibbedPath = new System.Windows.Forms.Label();
            this.lServerLauncherPath = new System.Windows.Forms.Label();
            this.lExportPath = new System.Windows.Forms.Label();
            this.bExportFolder = new Glass.GlassButton();
            this.lExportPathL = new System.Windows.Forms.Label();
            this.lPatchFile = new System.Windows.Forms.Label();
            this.bPatchFile = new Glass.GlassButton();
            this.lPatchFileL = new System.Windows.Forms.Label();
            this.lGameFolder = new System.Windows.Forms.Label();
            this.bGameFolder = new Glass.GlassButton();
            this.lGameFolderL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSaveSettings
            // 
            this.bSaveSettings.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSaveSettings.Location = new System.Drawing.Point(380, 227);
            this.bSaveSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSaveSettings.Name = "bSaveSettings";
            this.bSaveSettings.Size = new System.Drawing.Size(49, 27);
            this.bSaveSettings.TabIndex = 37;
            this.bSaveSettings.Text = "SAVE";
            this.bSaveSettings.Click += new System.EventHandler(this.bSaveSettings_Click);
            // 
            // bServerLauncherPath
            // 
            this.bServerLauncherPath.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bServerLauncherPath.Location = new System.Drawing.Point(106, 87);
            this.bServerLauncherPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bServerLauncherPath.Name = "bServerLauncherPath";
            this.bServerLauncherPath.Size = new System.Drawing.Size(27, 23);
            this.bServerLauncherPath.TabIndex = 36;
            this.bServerLauncherPath.Text = "..";
            this.bServerLauncherPath.Click += new System.EventHandler(this.bServerLauncherPath_Click);
            // 
            // lServerLauncherPathL
            // 
            this.lServerLauncherPathL.AutoSize = true;
            this.lServerLauncherPathL.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lServerLauncherPathL.Location = new System.Drawing.Point(6, 90);
            this.lServerLauncherPathL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lServerLauncherPathL.Name = "lServerLauncherPathL";
            this.lServerLauncherPathL.Size = new System.Drawing.Size(100, 17);
            this.lServerLauncherPathL.TabIndex = 35;
            this.lServerLauncherPathL.Text = "ServerLauncher";
            // 
            // bGibbedPath
            // 
            this.bGibbedPath.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bGibbedPath.Location = new System.Drawing.Point(99, 5);
            this.bGibbedPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGibbedPath.Name = "bGibbedPath";
            this.bGibbedPath.Size = new System.Drawing.Size(27, 23);
            this.bGibbedPath.TabIndex = 34;
            this.bGibbedPath.Text = "..";
            this.bGibbedPath.Click += new System.EventHandler(this.bGibbedPath_Click);
            // 
            // lGibbedPathL
            // 
            this.lGibbedPathL.AutoSize = true;
            this.lGibbedPathL.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGibbedPathL.Location = new System.Drawing.Point(6, 8);
            this.lGibbedPathL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGibbedPathL.Name = "lGibbedPathL";
            this.lGibbedPathL.Size = new System.Drawing.Size(93, 17);
            this.lGibbedPathL.TabIndex = 33;
            this.lGibbedPathL.Text = "Gibbed Folder";
            // 
            // lGibbedPath
            // 
            this.lGibbedPath.AutoSize = true;
            this.lGibbedPath.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGibbedPath.Location = new System.Drawing.Point(6, 28);
            this.lGibbedPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGibbedPath.Name = "lGibbedPath";
            this.lGibbedPath.Size = new System.Drawing.Size(63, 16);
            this.lGibbedPath.TabIndex = 38;
            this.lGibbedPath.Text = "[none set]";
            // 
            // lServerLauncherPath
            // 
            this.lServerLauncherPath.AutoSize = true;
            this.lServerLauncherPath.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lServerLauncherPath.Location = new System.Drawing.Point(6, 110);
            this.lServerLauncherPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lServerLauncherPath.Name = "lServerLauncherPath";
            this.lServerLauncherPath.Size = new System.Drawing.Size(63, 16);
            this.lServerLauncherPath.TabIndex = 39;
            this.lServerLauncherPath.Text = "[none set]";
            // 
            // lExportPath
            // 
            this.lExportPath.AutoSize = true;
            this.lExportPath.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lExportPath.Location = new System.Drawing.Point(6, 151);
            this.lExportPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lExportPath.Name = "lExportPath";
            this.lExportPath.Size = new System.Drawing.Size(63, 16);
            this.lExportPath.TabIndex = 42;
            this.lExportPath.Text = "[none set]";
            // 
            // bExportFolder
            // 
            this.bExportFolder.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bExportFolder.Location = new System.Drawing.Point(94, 128);
            this.bExportFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bExportFolder.Name = "bExportFolder";
            this.bExportFolder.Size = new System.Drawing.Size(27, 23);
            this.bExportFolder.TabIndex = 41;
            this.bExportFolder.Text = "..";
            this.bExportFolder.Click += new System.EventHandler(this.bExportFolder_Click);
            // 
            // lExportPathL
            // 
            this.lExportPathL.AutoSize = true;
            this.lExportPathL.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lExportPathL.Location = new System.Drawing.Point(6, 131);
            this.lExportPathL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lExportPathL.Name = "lExportPathL";
            this.lExportPathL.Size = new System.Drawing.Size(88, 17);
            this.lExportPathL.TabIndex = 40;
            this.lExportPathL.Text = "Export Folder";
            // 
            // lPatchFile
            // 
            this.lPatchFile.AutoSize = true;
            this.lPatchFile.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPatchFile.Location = new System.Drawing.Point(6, 69);
            this.lPatchFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPatchFile.Name = "lPatchFile";
            this.lPatchFile.Size = new System.Drawing.Size(63, 16);
            this.lPatchFile.TabIndex = 45;
            this.lPatchFile.Text = "[none set]";
            // 
            // bPatchFile
            // 
            this.bPatchFile.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPatchFile.Location = new System.Drawing.Point(111, 46);
            this.bPatchFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bPatchFile.Name = "bPatchFile";
            this.bPatchFile.Size = new System.Drawing.Size(27, 23);
            this.bPatchFile.TabIndex = 44;
            this.bPatchFile.Text = "..";
            this.bPatchFile.Click += new System.EventHandler(this.bPatchFile_Click);
            // 
            // lPatchFileL
            // 
            this.lPatchFileL.AutoSize = true;
            this.lPatchFileL.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPatchFileL.Location = new System.Drawing.Point(6, 49);
            this.lPatchFileL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPatchFileL.Name = "lPatchFileL";
            this.lPatchFileL.Size = new System.Drawing.Size(106, 17);
            this.lPatchFileL.TabIndex = 43;
            this.lPatchFileL.Text = "Default PatchFile";
            // 
            // lGameFolder
            // 
            this.lGameFolder.AutoSize = true;
            this.lGameFolder.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGameFolder.Location = new System.Drawing.Point(6, 192);
            this.lGameFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGameFolder.Name = "lGameFolder";
            this.lGameFolder.Size = new System.Drawing.Size(63, 16);
            this.lGameFolder.TabIndex = 48;
            this.lGameFolder.Text = "[none set]";
            // 
            // bGameFolder
            // 
            this.bGameFolder.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bGameFolder.Location = new System.Drawing.Point(94, 169);
            this.bGameFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGameFolder.Name = "bGameFolder";
            this.bGameFolder.Size = new System.Drawing.Size(27, 23);
            this.bGameFolder.TabIndex = 47;
            this.bGameFolder.Text = "..";
            this.bGameFolder.Click += new System.EventHandler(this.bGameFolder_Click);
            // 
            // lGameFolderL
            // 
            this.lGameFolderL.AutoSize = true;
            this.lGameFolderL.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGameFolderL.Location = new System.Drawing.Point(6, 172);
            this.lGameFolderL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGameFolderL.Name = "lGameFolderL";
            this.lGameFolderL.Size = new System.Drawing.Size(84, 17);
            this.lGameFolderL.TabIndex = 46;
            this.lGameFolderL.Text = "Game Folder";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 259);
            this.Controls.Add(this.lGameFolder);
            this.Controls.Add(this.bGameFolder);
            this.Controls.Add(this.lGameFolderL);
            this.Controls.Add(this.lPatchFile);
            this.Controls.Add(this.bPatchFile);
            this.Controls.Add(this.lPatchFileL);
            this.Controls.Add(this.lExportPath);
            this.Controls.Add(this.bExportFolder);
            this.Controls.Add(this.lExportPathL);
            this.Controls.Add(this.lServerLauncherPath);
            this.Controls.Add(this.lGibbedPath);
            this.Controls.Add(this.bSaveSettings);
            this.Controls.Add(this.bServerLauncherPath);
            this.Controls.Add(this.lServerLauncherPathL);
            this.Controls.Add(this.bGibbedPath);
            this.Controls.Add(this.lGibbedPathL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Glass.GlassButton bSaveSettings;
        private Glass.GlassButton bServerLauncherPath;
        private Label lServerLauncherPathL;
        private Glass.GlassButton bGibbedPath;
        private Label lGibbedPathL;
        private Label lGibbedPath;
        private Label lServerLauncherPath;
        private Label lExportPath;
        private Glass.GlassButton bExportFolder;
        private Label lExportPathL;
        private Label lPatchFile;
        private Glass.GlassButton bPatchFile;
        private Label lPatchFileL;
        private Label lGameFolder;
        private Glass.GlassButton bGameFolder;
        private Label lGameFolderL;
    }
}