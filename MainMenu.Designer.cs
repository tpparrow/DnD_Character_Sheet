﻿namespace DnD_Character_Sheet
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.BlurbLabel = new System.Windows.Forms.Label();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "D and D Character Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateButton.BackgroundImage")));
            this.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(164, 205);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(93, 42);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "CREATE";
            this.CreateButton.UseVisualStyleBackColor = false;

            // 
            // BlurbLabel
            // 
            this.BlurbLabel.BackColor = System.Drawing.Color.Transparent;
            this.BlurbLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurbLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlurbLabel.Location = new System.Drawing.Point(83, 106);
            this.BlurbLabel.Name = "BlurbLabel";
            this.BlurbLabel.Size = new System.Drawing.Size(527, 73);
            this.BlurbLabel.TabIndex = 4;
            this.BlurbLabel.Text = "This is an application made specifically to help you manage your character sheets" +
    " so you can spend more time focusing on your next adventure.\r\n";
            this.BlurbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BlurbLabel.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.BackColor = System.Drawing.Color.LightGray;
            this.CreditsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLabel.ForeColor = System.Drawing.Color.Black;
            this.CreditsLabel.Location = new System.Drawing.Point(180, 307);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(360, 54);
            this.CreditsLabel.TabIndex = 5;
            this.CreditsLabel.Text = "CSCI 3037 Final Project\r\nCreated by Natalie Padron, Tyler Parrow, Benit Mukendi, " +
    "Elaina Vogel, and Matthew Woodward";
            this.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Transparent;
            this.loadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadButton.BackgroundImage")));
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(304, 205);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(93, 42);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(447, 205);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 42);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.arcanRooftop;
            this.ClientSize = new System.Drawing.Size(735, 383);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlurbLabel);
            this.Controls.Add(this.CreateButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label BlurbLabel;
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button exitButton;
    }
}

