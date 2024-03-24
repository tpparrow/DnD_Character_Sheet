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
        private string fileName { get; set; }
        bool isOpen { get; set; }
        
        //Default constructors
        public FileManager() { }
        public FileManager(string fileName) { }
        
       

        public Character GetCharacter() 
        { 
            //temporary null return
            return null; 
        }

        //Get Character by index
        public Character GetCharacter(int index)
        {
            //temporary null return
            return null;
        }

        public Character GetCharacter(string charID)
        {
            //temporary null return
            return null;
        }

        public bool SaveCharacter(Character character)
        {
            //temporary false return
            return false;
        }
    }

}
