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
            this.fileView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // fileView
            // 
            this.fileView.HideSelection = false;
            this.fileView.Location = new System.Drawing.Point(187, 40);
            this.fileView.Name = "fileView";
            this.fileView.Size = new System.Drawing.Size(569, 355);
            this.fileView.TabIndex = 0;
            this.fileView.UseCompatibleStateImageBehavior = false;
            // 
            // File_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileView);
            this.Name = "File_Manager";
            this.Text = "File_Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView fileView;
    }
}