﻿namespace Nucleus.Coop
{
    partial class MainForm
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
            this.StepPanel = new System.Windows.Forms.Panel();
            this.panelGameName = new System.Windows.Forms.Panel();
            this.label_GameTitle = new System.Windows.Forms.Label();
            this.pic_Game = new System.Windows.Forms.PictureBox();
            this.list_Games = new Nucleus.Gaming.ControlListBox();
            this.label_StepTitle = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAutoSearch = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btnShowTaskbar = new System.Windows.Forms.Button();
            this.panelGameName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Game)).BeginInit();
            this.SuspendLayout();
            // 
            // StepPanel
            // 
            this.StepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StepPanel.Location = new System.Drawing.Point(254, 101);
            this.StepPanel.Name = "StepPanel";
            this.StepPanel.Size = new System.Drawing.Size(788, 588);
            this.StepPanel.TabIndex = 0;
            // 
            // panelGameName
            // 
            this.panelGameName.AutoSize = true;
            this.panelGameName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGameName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelGameName.Controls.Add(this.label_GameTitle);
            this.panelGameName.Controls.Add(this.pic_Game);
            this.panelGameName.Location = new System.Drawing.Point(254, 14);
            this.panelGameName.Name = "panelGameName";
            this.panelGameName.Size = new System.Drawing.Size(178, 46);
            this.panelGameName.TabIndex = 1;
            // 
            // label_GameTitle
            // 
            this.label_GameTitle.AutoSize = true;
            this.label_GameTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label_GameTitle.Location = new System.Drawing.Point(49, 7);
            this.label_GameTitle.Name = "label_GameTitle";
            this.label_GameTitle.Size = new System.Drawing.Size(126, 32);
            this.label_GameTitle.TabIndex = 1;
            this.label_GameTitle.Text = "No Games";
            // 
            // pic_Game
            // 
            this.pic_Game.Location = new System.Drawing.Point(3, 3);
            this.pic_Game.Name = "pic_Game";
            this.pic_Game.Size = new System.Drawing.Size(40, 40);
            this.pic_Game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Game.TabIndex = 0;
            this.pic_Game.TabStop = false;
            // 
            // list_Games
            // 
            this.list_Games.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_Games.AutoScroll = true;
            this.list_Games.Border = 1;
            this.list_Games.Location = new System.Drawing.Point(12, 12);
            this.list_Games.Name = "list_Games";
            this.list_Games.Offset = new System.Drawing.Size(0, 2);
            this.list_Games.Size = new System.Drawing.Size(236, 592);
            this.list_Games.TabIndex = 2;
            this.list_Games.SelectedChanged += new System.Action<object, System.Windows.Forms.Control>(this.list_Games_SelectedChanged);
            // 
            // label_StepTitle
            // 
            this.label_StepTitle.AutoSize = true;
            this.label_StepTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label_StepTitle.Location = new System.Drawing.Point(257, 66);
            this.label_StepTitle.Name = "label_StepTitle";
            this.label_StepTitle.Size = new System.Drawing.Size(198, 32);
            this.label_StepTitle.TabIndex = 3;
            this.label_StepTitle.Text = "Nothing selected";
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Play.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(945, 63);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(97, 35);
            this.btn_Play.TabIndex = 4;
            this.btn_Play.Text = "P L A Y";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Visible = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(12, 610);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 35);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Game";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(906, 63);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 35);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.arrow_Back_Click);
            // 
            // btnAutoSearch
            // 
            this.btnAutoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutoSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoSearch.Location = new System.Drawing.Point(133, 610);
            this.btnAutoSearch.Name = "btnAutoSearch";
            this.btnAutoSearch.Size = new System.Drawing.Size(115, 35);
            this.btnAutoSearch.TabIndex = 10;
            this.btnAutoSearch.Text = "Auto Search";
            this.btnAutoSearch.UseVisualStyleBackColor = true;
            this.btnAutoSearch.Click += new System.EventHandler(this.btnAutoSearch_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(945, 101);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(97, 35);
            this.btn_Next.TabIndex = 11;
            this.btn_Next.Text = "N E X T";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Visible = false;
            this.btn_Next.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShowTaskbar
            // 
            this.btnShowTaskbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowTaskbar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowTaskbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTaskbar.Location = new System.Drawing.Point(12, 651);
            this.btnShowTaskbar.Name = "btnShowTaskbar";
            this.btnShowTaskbar.Size = new System.Drawing.Size(236, 35);
            this.btnShowTaskbar.TabIndex = 12;
            this.btnShowTaskbar.Text = "Show Taskbar";
            this.btnShowTaskbar.UseVisualStyleBackColor = true;
            this.btnShowTaskbar.Click += new System.EventHandler(this.btnShowTaskbar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 701);
            this.Controls.Add(this.btnShowTaskbar);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btnAutoSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.label_StepTitle);
            this.Controls.Add(this.list_Games);
            this.Controls.Add(this.panelGameName);
            this.Controls.Add(this.StepPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(275, 360);
            this.Name = "MainForm";
            this.Text = "Nucleus Coop";
            this.panelGameName.ResumeLayout(false);
            this.panelGameName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel StepPanel;
        private System.Windows.Forms.Panel panelGameName;
        private System.Windows.Forms.PictureBox pic_Game;
        private System.Windows.Forms.Label label_GameTitle;
        private Gaming.ControlListBox list_Games;
        private System.Windows.Forms.Label label_StepTitle;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAutoSearch;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btnShowTaskbar;
    }
}