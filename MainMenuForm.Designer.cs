namespace DnD_Character_Sheet
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.BlurbLabel = new System.Windows.Forms.Label();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 142);
            this.label1.TabIndex = 0;
            this.label1.Text = "DnD Character Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.brownButton;
            this.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(161, 301);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(93, 42);
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
            this.BlurbLabel.Location = new System.Drawing.Point(58, 229);
            this.BlurbLabel.Name = "BlurbLabel";
            this.BlurbLabel.Size = new System.Drawing.Size(680, 69);
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
            this.CreditsLabel.Location = new System.Drawing.Point(1, 360);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(711, 54);
            this.CreditsLabel.TabIndex = 5;
            this.CreditsLabel.Text = "CSCI 3037 Final Project\r\nCreated by Natalie Padron, Tyler Parrow, Benit Mukendi, " +
    "Elaina Vogel, and Matthew Woodward";
            this.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.brownButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(347, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.rightSideUpSwirl;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(221, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 46);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.upsideDownSwirl;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(221, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 43);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::DnD_Character_Sheet.Properties.Resources.brownpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 439);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlurbLabel);
            this.Controls.Add(this.CreateButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label BlurbLabel;
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

