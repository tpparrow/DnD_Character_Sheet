namespace DnD_Character_Sheet
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
<<<<<<< HEAD:MainMenu.Designer.cs
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
=======
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
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
<<<<<<< HEAD:MainMenu.Designer.cs
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 74);
            this.label1.TabIndex = 0;
<<<<<<< HEAD
            this.label1.Text = "D&&D Character Manager";
=======
            this.label1.Font = new System.Drawing.Font("Algerian", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 142);
            this.label1.TabIndex = 0;
            this.label1.Text = "DnD Character Manager";
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
=======
            this.label1.Text = "D and D Character Manager";
>>>>>>> master
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.brownButton;
            this.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD:MainMenu.Designer.cs
            this.CreateButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(184, 256);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(161, 301);
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(105, 52);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "CREATE";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BlurbLabel
            // 
            this.BlurbLabel.BackColor = System.Drawing.Color.Transparent;
            this.BlurbLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurbLabel.ForeColor = System.Drawing.SystemColors.ControlText;
<<<<<<< HEAD:MainMenu.Designer.cs
            this.BlurbLabel.Location = new System.Drawing.Point(93, 132);
            this.BlurbLabel.Name = "BlurbLabel";
            this.BlurbLabel.Size = new System.Drawing.Size(593, 91);
=======
            this.BlurbLabel.Location = new System.Drawing.Point(58, 212);
            this.BlurbLabel.Name = "BlurbLabel";
            this.BlurbLabel.Size = new System.Drawing.Size(680, 69);
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
            this.BlurbLabel.TabIndex = 4;
            this.BlurbLabel.Text = "This is an application made specifically to help you manage your character sheets" +
    " so you can spend more time focusing on your next adventure.\r\n";
            this.BlurbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BlurbLabel.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLabel.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD:MainMenu.Designer.cs
            this.CreditsLabel.Location = new System.Drawing.Point(202, 384);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(405, 68);
=======
            this.CreditsLabel.Location = new System.Drawing.Point(1, 360);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(711, 54);
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
            this.CreditsLabel.TabIndex = 5;
            this.CreditsLabel.Text = "CSCI 3037 Final Project\r\nCreated by Natalie Padron, Tyler Parrow, Benit Mukendi, " +
    "Elaina Vogel, and Matthew Woodward";
            this.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loadButton
            // 
<<<<<<< HEAD
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.brownButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD:MainMenu.Designer.cs
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(347, 301);
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = false;
=======
            this.loadButton.BackColor = System.Drawing.Color.Transparent;
            this.loadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadButton.BackgroundImage")));
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(342, 256);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(105, 52);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
>>>>>>> master
            // 
            // exitButton
            // 
<<<<<<< HEAD:MainMenu.Designer.cs
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(503, 256);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 52);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
=======
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.brownButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(530, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
            // 
            // MainMenu
            // 
<<<<<<< HEAD:MainMenu.Designer.cs
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.arcanRooftop;
            this.ClientSize = new System.Drawing.Size(827, 479);
            this.Controls.Add(this.exitButton);
<<<<<<< HEAD
=======
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.Screenshot_2024_03_11_182324;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 434);
            this.Controls.Add(this.button2);
>>>>>>> f08b63d67ac90463f10b976a64a73ff5d2b23873:Form1.Designer.cs
            this.Controls.Add(this.button1);
=======
            this.Controls.Add(this.loadButton);
>>>>>>> master
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlurbLabel);
            this.Controls.Add(this.CreateButton);
            this.DoubleBuffered = true;
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

