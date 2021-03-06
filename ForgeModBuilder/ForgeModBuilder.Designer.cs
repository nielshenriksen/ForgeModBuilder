﻿using System.Windows.Forms;

namespace ForgeModBuilder
{
    partial class FMB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMB));
            this.OptionsMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeProjectVersionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsoleFontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectVersionsToCheckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearConsoleOnProjectOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearConsoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearProjectCacheMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearVersionsCacheMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckVersionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.OpenProjectButton = new System.Windows.Forms.Button();
            this.BuildProjectButton = new System.Windows.Forms.Button();
            this.UpdateProjectButton = new System.Windows.Forms.Button();
            this.SetupProjectButton = new System.Windows.Forms.Button();
            this.RefreshProjectButton = new System.Windows.Forms.Button();
            this.NewProjectButton = new System.Windows.Forms.Button();
            this.ChangeProjectVersionButton = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ConsoleTab = new System.Windows.Forms.TabPage();
            this.BuildFileTab = new System.Windows.Forms.TabPage();
            this.UploadBuildFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.BuildFile = new System.Windows.Forms.RichTextBox();
            this.UploadLogButton = new System.Windows.Forms.Button();
            this.OptionsMenu.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.ConsoleTab.SuspendLayout();
            this.BuildFileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OptionsMenu.Location = new System.Drawing.Point(0, 0);
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(809, 24);
            this.OptionsMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProjectMenuItem,
            this.OpenProjectMenuItem,
            this.BuildProjectMenuItem,
            this.SetupProjectMenuItem,
            this.UpdateProjectMenuItem,
            this.ChangeProjectVersionMenuItem,
            this.RefreshProjectMenuItem,
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewProjectMenuItem
            // 
            this.NewProjectMenuItem.Name = "NewProjectMenuItem";
            this.NewProjectMenuItem.Size = new System.Drawing.Size(196, 22);
            this.NewProjectMenuItem.Text = "New Project";
            this.NewProjectMenuItem.Click += new System.EventHandler(this.NewProjectClick);
            // 
            // OpenProjectMenuItem
            // 
            this.OpenProjectMenuItem.Name = "OpenProjectMenuItem";
            this.OpenProjectMenuItem.Size = new System.Drawing.Size(196, 22);
            this.OpenProjectMenuItem.Text = "Open Project";
            this.OpenProjectMenuItem.Click += new System.EventHandler(this.OpenProjectClick);
            // 
            // BuildProjectMenuItem
            // 
            this.BuildProjectMenuItem.Name = "BuildProjectMenuItem";
            this.BuildProjectMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BuildProjectMenuItem.Text = "Build Project";
            this.BuildProjectMenuItem.Click += new System.EventHandler(this.BuildProjectClick);
            // 
            // SetupProjectMenuItem
            // 
            this.SetupProjectMenuItem.Name = "SetupProjectMenuItem";
            this.SetupProjectMenuItem.Size = new System.Drawing.Size(196, 22);
            this.SetupProjectMenuItem.Text = "Setup Project";
            this.SetupProjectMenuItem.Click += new System.EventHandler(this.SetupProjectClick);
            // 
            // UpdateProjectMenuItem
            // 
            this.UpdateProjectMenuItem.Name = "UpdateProjectMenuItem";
            this.UpdateProjectMenuItem.Size = new System.Drawing.Size(196, 22);
            this.UpdateProjectMenuItem.Text = "Update Project";
            this.UpdateProjectMenuItem.Click += new System.EventHandler(this.UpdateProjectClick);
            // 
            // ChangeProjectVersionMenuItem
            // 
            this.ChangeProjectVersionMenuItem.Name = "ChangeProjectVersionMenuItem";
            this.ChangeProjectVersionMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ChangeProjectVersionMenuItem.Text = "Change Project Version";
            this.ChangeProjectVersionMenuItem.Click += new System.EventHandler(this.ChangeProjectVersionClick);
            // 
            // RefreshProjectMenuItem
            // 
            this.RefreshProjectMenuItem.Name = "RefreshProjectMenuItem";
            this.RefreshProjectMenuItem.Size = new System.Drawing.Size(196, 22);
            this.RefreshProjectMenuItem.Text = "Refresh Project";
            this.RefreshProjectMenuItem.Click += new System.EventHandler(this.RefreshProjectClick);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ExitMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsoleFontMenuItem,
            this.SelectVersionsToCheckMenuItem,
            this.ClearConsoleOnProjectOpenMenuItem,
            this.ClearConsoleMenuItem,
            this.ClearProjectCacheMenuItem,
            this.ClearVersionsCacheMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ConsoleFontMenuItem
            // 
            this.ConsoleFontMenuItem.Name = "ConsoleFontMenuItem";
            this.ConsoleFontMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ConsoleFontMenuItem.Text = "Console Font";
            this.ConsoleFontMenuItem.Click += new System.EventHandler(this.ConsoleFontMenuItem_Click);
            // 
            // SelectVersionsToCheckMenuItem
            // 
            this.SelectVersionsToCheckMenuItem.Name = "SelectVersionsToCheckMenuItem";
            this.SelectVersionsToCheckMenuItem.Size = new System.Drawing.Size(232, 22);
            this.SelectVersionsToCheckMenuItem.Text = "Check Versions";
            // 
            // ClearConsoleOnProjectOpenMenuItem
            // 
            this.ClearConsoleOnProjectOpenMenuItem.Name = "ClearConsoleOnProjectOpenMenuItem";
            this.ClearConsoleOnProjectOpenMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ClearConsoleOnProjectOpenMenuItem.Text = "Clear console on project open";
            this.ClearConsoleOnProjectOpenMenuItem.Click += new System.EventHandler(this.ClearConsoleOnProjectOpenMenuItem_Click);
            // 
            // ClearConsoleMenuItem
            // 
            this.ClearConsoleMenuItem.Name = "ClearConsoleMenuItem";
            this.ClearConsoleMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ClearConsoleMenuItem.Text = "Clear console";
            this.ClearConsoleMenuItem.Click += new System.EventHandler(this.ClearConsoleMenuItem_Click);
            // 
            // ClearProjectCacheMenuItem
            // 
            this.ClearProjectCacheMenuItem.Name = "ClearProjectCacheMenuItem";
            this.ClearProjectCacheMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ClearProjectCacheMenuItem.Text = "Clear project cache";
            this.ClearProjectCacheMenuItem.Click += new System.EventHandler(this.ClearProjectCacheMenuItem_Click);
            // 
            // ClearVersionsCacheMenuItem
            // 
            this.ClearVersionsCacheMenuItem.Name = "ClearVersionsCacheMenuItem";
            this.ClearVersionsCacheMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ClearVersionsCacheMenuItem.Text = "Clear versions cache";
            this.ClearVersionsCacheMenuItem.Click += new System.EventHandler(this.ClearVersionsCacheMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdatesMenuItem,
            this.CheckVersionsMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // CheckForUpdatesMenuItem
            // 
            this.CheckForUpdatesMenuItem.Name = "CheckForUpdatesMenuItem";
            this.CheckForUpdatesMenuItem.Size = new System.Drawing.Size(170, 22);
            this.CheckForUpdatesMenuItem.Text = "Check for updates";
            this.CheckForUpdatesMenuItem.Click += new System.EventHandler(this.CheckForUpdatesMenuItem_Click);
            // 
            // CheckVersionsMenuItem
            // 
            this.CheckVersionsMenuItem.Name = "CheckVersionsMenuItem";
            this.CheckVersionsMenuItem.Size = new System.Drawing.Size(170, 22);
            this.CheckVersionsMenuItem.Text = "Check versions";
            this.CheckVersionsMenuItem.Click += new System.EventHandler(this.CheckVersionsMenuItem_Click);
            // 
            // Console
            // 
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Console.Dock = System.Windows.Forms.DockStyle.Top;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Console.Location = new System.Drawing.Point(3, 3);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(795, 392);
            this.Console.TabIndex = 1;
            this.Console.Text = "";
            this.Console.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ConsoleLinkClicked);
            // 
            // OpenProjectButton
            // 
            this.OpenProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OpenProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenProjectButton.Location = new System.Drawing.Point(124, 490);
            this.OpenProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.OpenProjectButton.Name = "OpenProjectButton";
            this.OpenProjectButton.Size = new System.Drawing.Size(113, 59);
            this.OpenProjectButton.TabIndex = 2;
            this.OpenProjectButton.Text = "Open Project";
            this.OpenProjectButton.UseVisualStyleBackColor = true;
            this.OpenProjectButton.Click += new System.EventHandler(this.OpenProjectClick);
            // 
            // BuildProjectButton
            // 
            this.BuildProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BuildProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BuildProjectButton.Location = new System.Drawing.Point(243, 490);
            this.BuildProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.BuildProjectButton.Name = "BuildProjectButton";
            this.BuildProjectButton.Size = new System.Drawing.Size(113, 59);
            this.BuildProjectButton.TabIndex = 3;
            this.BuildProjectButton.Text = "Build Project";
            this.BuildProjectButton.UseVisualStyleBackColor = true;
            this.BuildProjectButton.Click += new System.EventHandler(this.BuildProjectClick);
            // 
            // UpdateProjectButton
            // 
            this.UpdateProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateProjectButton.Location = new System.Drawing.Point(481, 490);
            this.UpdateProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.UpdateProjectButton.Name = "UpdateProjectButton";
            this.UpdateProjectButton.Size = new System.Drawing.Size(113, 59);
            this.UpdateProjectButton.TabIndex = 4;
            this.UpdateProjectButton.Text = "Update Project";
            this.UpdateProjectButton.UseVisualStyleBackColor = true;
            this.UpdateProjectButton.Click += new System.EventHandler(this.UpdateProjectClick);
            // 
            // SetupProjectButton
            // 
            this.SetupProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SetupProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SetupProjectButton.Location = new System.Drawing.Point(362, 490);
            this.SetupProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.SetupProjectButton.Name = "SetupProjectButton";
            this.SetupProjectButton.Size = new System.Drawing.Size(113, 59);
            this.SetupProjectButton.TabIndex = 5;
            this.SetupProjectButton.Text = "Setup Project";
            this.SetupProjectButton.UseVisualStyleBackColor = true;
            this.SetupProjectButton.Click += new System.EventHandler(this.SetupProjectClick);
            // 
            // RefreshProjectButton
            // 
            this.RefreshProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RefreshProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshProjectButton.Location = new System.Drawing.Point(600, 490);
            this.RefreshProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.RefreshProjectButton.Name = "RefreshProjectButton";
            this.RefreshProjectButton.Size = new System.Drawing.Size(113, 59);
            this.RefreshProjectButton.TabIndex = 6;
            this.RefreshProjectButton.Text = "Refresh Project";
            this.RefreshProjectButton.UseVisualStyleBackColor = true;
            this.RefreshProjectButton.Click += new System.EventHandler(this.RefreshProjectClick);
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewProjectButton.Location = new System.Drawing.Point(5, 490);
            this.NewProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(113, 59);
            this.NewProjectButton.TabIndex = 7;
            this.NewProjectButton.Text = "New Project";
            this.NewProjectButton.UseVisualStyleBackColor = true;
            this.NewProjectButton.Click += new System.EventHandler(this.NewProjectClick);
            // 
            // ChangeProjectVersionButton
            // 
            this.ChangeProjectVersionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeProjectVersionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChangeProjectVersionButton.Location = new System.Drawing.Point(719, 490);
            this.ChangeProjectVersionButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.ChangeProjectVersionButton.Name = "ChangeProjectVersionButton";
            this.ChangeProjectVersionButton.Size = new System.Drawing.Size(113, 59);
            this.ChangeProjectVersionButton.TabIndex = 8;
            this.ChangeProjectVersionButton.Text = "Change Project Version";
            this.ChangeProjectVersionButton.UseVisualStyleBackColor = true;
            this.ChangeProjectVersionButton.Click += new System.EventHandler(this.ChangeProjectVersionClick);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ConsoleTab);
            this.Tabs.Controls.Add(this.BuildFileTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabs.Location = new System.Drawing.Point(0, 24);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(809, 460);
            this.Tabs.TabIndex = 9;
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.Controls.Add(this.UploadLogButton);
            this.ConsoleTab.Controls.Add(this.Console);
            this.ConsoleTab.Location = new System.Drawing.Point(4, 22);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConsoleTab.Size = new System.Drawing.Size(801, 434);
            this.ConsoleTab.TabIndex = 0;
            this.ConsoleTab.Text = "Console";
            this.ConsoleTab.UseVisualStyleBackColor = true;
            // 
            // BuildFileTab
            // 
            this.BuildFileTab.Controls.Add(this.UploadBuildFileButton);
            this.BuildFileTab.Controls.Add(this.SaveFileButton);
            this.BuildFileTab.Controls.Add(this.BuildFile);
            this.BuildFileTab.Location = new System.Drawing.Point(4, 22);
            this.BuildFileTab.Name = "BuildFileTab";
            this.BuildFileTab.Padding = new System.Windows.Forms.Padding(3);
            this.BuildFileTab.Size = new System.Drawing.Size(801, 434);
            this.BuildFileTab.TabIndex = 1;
            this.BuildFileTab.Text = "Build File";
            this.BuildFileTab.UseVisualStyleBackColor = true;
            // 
            // UploadBuildFileButton
            // 
            this.UploadBuildFileButton.Location = new System.Drawing.Point(88, 401);
            this.UploadBuildFileButton.Name = "UploadBuildFileButton";
            this.UploadBuildFileButton.Size = new System.Drawing.Size(76, 27);
            this.UploadBuildFileButton.TabIndex = 4;
            this.UploadBuildFileButton.Text = "Upload File";
            this.UploadBuildFileButton.UseVisualStyleBackColor = true;
            this.UploadBuildFileButton.Click += new System.EventHandler(this.UploadBuildFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(6, 401);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(76, 27);
            this.SaveFileButton.TabIndex = 3;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // BuildFile
            // 
            this.BuildFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BuildFile.Location = new System.Drawing.Point(3, 3);
            this.BuildFile.Name = "BuildFile";
            this.BuildFile.ReadOnly = true;
            this.BuildFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BuildFile.Size = new System.Drawing.Size(795, 392);
            this.BuildFile.TabIndex = 2;
            this.BuildFile.Text = "";
            this.BuildFile.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ConsoleLinkClicked);
            // 
            // UploadLogButton
            // 
            this.UploadLogButton.Location = new System.Drawing.Point(6, 401);
            this.UploadLogButton.Name = "UploadLogButton";
            this.UploadLogButton.Size = new System.Drawing.Size(80, 26);
            this.UploadLogButton.TabIndex = 2;
            this.UploadLogButton.Text = "Upload Log";
            this.UploadLogButton.UseVisualStyleBackColor = true;
            this.UploadLogButton.Click += new System.EventHandler(this.UploadLogButton_Click);
            // 
            // FMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 561);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.ChangeProjectVersionButton);
            this.Controls.Add(this.NewProjectButton);
            this.Controls.Add(this.RefreshProjectButton);
            this.Controls.Add(this.SetupProjectButton);
            this.Controls.Add(this.UpdateProjectButton);
            this.Controls.Add(this.BuildProjectButton);
            this.Controls.Add(this.OpenProjectButton);
            this.Controls.Add(this.OptionsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.OptionsMenu;
            this.MinimumSize = new System.Drawing.Size(825, 600);
            this.Name = "FMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forge Mod Builder";
            this.OptionsMenu.ResumeLayout(false);
            this.OptionsMenu.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.ConsoleTab.ResumeLayout(false);
            this.BuildFileTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetupProjectMenuItem;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Button OpenProjectButton;
        private System.Windows.Forms.Button BuildProjectButton;
        private System.Windows.Forms.Button UpdateProjectButton;
        private System.Windows.Forms.Button SetupProjectButton;
        private System.Windows.Forms.ToolStripMenuItem UpdateProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem ConsoleFontMenuItem;
        private Button RefreshProjectButton;
        private ToolStripMenuItem RefreshProjectMenuItem;
        private ToolStripMenuItem NewProjectMenuItem;
        private Button NewProjectButton;
        private ToolStripMenuItem ClearConsoleMenuItem;
        private ToolStripMenuItem ClearProjectCacheMenuItem;
        private ToolStripMenuItem ClearVersionsCacheMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem CheckForUpdatesMenuItem;
        private ToolStripMenuItem CheckVersionsMenuItem;
        private Button ChangeProjectVersionButton;
        private ToolStripMenuItem ChangeProjectVersionMenuItem;
        private TabControl Tabs;
        private TabPage ConsoleTab;
        private TabPage BuildFileTab;
        private RichTextBox BuildFile;
        private ToolStripMenuItem ClearConsoleOnProjectOpenMenuItem;
        public ToolStripMenuItem SelectVersionsToCheckMenuItem;
        private Button SaveFileButton;
        private Button UploadBuildFileButton;
        private Button UploadLogButton;
    }
}

