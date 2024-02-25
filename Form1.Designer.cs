namespace DnD_Character_Sheet
{
    partial class Form1
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BlurbLabel = new System.Windows.Forms.Label();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "D and D Character Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(178, 210);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(90, 33);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(300, 210);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(90, 33);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(425, 210);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 33);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // BlurbLabel
            // 
            this.BlurbLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BlurbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CreditsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CreditsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreditsLabel.Location = new System.Drawing.Point(84, 283);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(524, 68);
            this.CreditsLabel.TabIndex = 5;
            this.CreditsLabel.Text = "CSCI 3037 Final Project\r\nCreated by Natalie Padron, Tyler Parrow, Benit Mukendi, " +
    "Elaina Vogel, and Matthew Woodward";
            this.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlurbLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.CreateButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label BlurbLabel;
        private System.Windows.Forms.Label CreditsLabel;
    }
}

