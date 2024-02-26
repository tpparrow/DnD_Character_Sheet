using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Character_Sheet
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test Comment
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            //Fix
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opens the file manager in a new window
            //TP: Should we have the form load in the same window?
            File_Manager file_Manager = new File_Manager();
            file_Manager.Show();
        }
    }
}
