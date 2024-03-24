using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DnD_Character_Sheet
{
    internal class FileManager
    {
        //FileName
        private string fileName;
        
        public FileManager() { }
        public FileManager(string fileName) { }
        
        public string GetFileName(string fileName)
        {
            return fileName;
        }

        public Character GetCharacter() {  return null; }
    }
}
