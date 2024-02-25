namespace DnD_Character_Sheet
{
    partial class File_Manager
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
            this.characterView = new System.Windows.Forms.ListView();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // characterView
            // 
            this.characterView.CheckBoxes = true;
            this.characterView.HideSelection = false;
            this.characterView.Location = new System.Drawing.Point(187, 40);
            this.characterView.Name = "characterView";
            this.characterView.Size = new System.Drawing.Size(569, 355);
            this.characterView.TabIndex = 0;
            this.characterView.UseCompatibleStateImageBehavior = false;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(35, 84);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(118, 80);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Save";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(35, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 73);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Load";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // File_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.characterView);
            this.Name = "File_Manager";
            this.Text = "File_Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView characterView;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
    }
}