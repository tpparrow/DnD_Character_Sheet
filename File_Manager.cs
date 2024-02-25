using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DnD_Character_Sheet
{
    public partial class File_Manager : Form
    {
        public File_Manager()
        {
            InitializeComponent();
            characterView.Items.Clear();
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] files = Directory.GetFiles(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"/Characters");
            foreach (string file in files)
            {

                string fileName = Path.GetFileNameWithoutExtension(file);
                ListViewItem item = new ListViewItem(fileName);
                item.Tag = file;

                characterView.Items.Add(item);

            }
        }
    }
}
