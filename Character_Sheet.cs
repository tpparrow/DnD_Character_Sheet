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
    public partial class Character_Sheet : Form
    {
        public Character_Sheet()
        {
            InitializeComponent();
        }

        int PointsDistributable = 28;

        int STRENGTH = 8;
        int DEXTERITY = 8;
        int CONSTITUTION = 8;
        int INTELLIGENCE = 8;
        int WISDOM = 8;
        int CHARISMA = 8;

        private void UpdateButton()
        {
            StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 20;
            StrDownButton.Enabled = STRENGTH > 8;

            DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 20;
            DexDownButton.Enabled = DEXTERITY > 8;

            ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 20;
            ConDownButton.Enabled = CONSTITUTION > 8;

            IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 20;
            IntDownButton.Enabled = INTELLIGENCE > 8;

            WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 20;
            WisDownButton.Enabled = WISDOM > 8;

            ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 20;
            ChaDownButton.Enabled = CHARISMA > 8;

        }

        private void Character_Sheet_Load(object sender, EventArgs e)
        {
            strLabel.Text = STRENGTH.ToString();
            dexLabel.Text = DEXTERITY.ToString();
            conLabel.Text = CONSTITUTION.ToString();
            intLabel.Text = INTELLIGENCE.ToString();
            wisLabel.Text = WISDOM.ToString();
            chaLabel.Text = CHARISMA.ToString();

            pointsLabel.Text = PointsDistributable.ToString();
            
            UpdateButton();
        }
        

        private void StrDownButton_Click(object sender, EventArgs e)
        {
            STRENGTH--;
            PointsDistributable++;

            strLabel.Text = STRENGTH.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();
        }

        private void StrUpButton_Click(object sender, EventArgs e)
        {
            STRENGTH++;
            PointsDistributable--;

            strLabel.Text = STRENGTH.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();
        }

        private void DexDownButton_Click(object sender, EventArgs e)
        {
            DEXTERITY--;
            PointsDistributable++;

            dexLabel.Text = DEXTERITY.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();

        }

        private void DexUpButton_Click(object sender, EventArgs e)
        {
            DEXTERITY++;
            PointsDistributable--;

            dexLabel.Text = DEXTERITY.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();

        }

        private void ConDownButton_Click(object sender, EventArgs e)
        {
            CONSTITUTION--;
            PointsDistributable++;

            conLabel.Text = CONSTITUTION.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();
        }

        private void ConUpButton_Click(object sender, EventArgs e)
        {
            CONSTITUTION++;
            PointsDistributable--;

            conLabel.Text = CONSTITUTION.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();

        }

        private void IntDownButton_Click(object sender, EventArgs e)
        {
            INTELLIGENCE--;
            PointsDistributable++;

            intLabel.Text = INTELLIGENCE.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();
        }

        private void IntUpButton_Click(object sender, EventArgs e)
        {
            INTELLIGENCE++;
            PointsDistributable--;

            intLabel.Text = INTELLIGENCE.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();

        }

        private void WisDownButton_Click(object sender, EventArgs e)
        {
            WISDOM--;
            PointsDistributable++;

            wisLabel.Text = WISDOM.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();
        }

        private void WisUpButton_Click(object sender, EventArgs e)
        {
            WISDOM++;
            PointsDistributable--;

            wisLabel.Text = WISDOM.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();

        }

        private void ChaDownButton_Click(object sender, EventArgs e)
        {
            CHARISMA--;
            PointsDistributable++;

            chaLabel.Text = CHARISMA.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
        }

        private void ChaUpButton_Click(object sender, EventArgs e)
        {
            CHARISMA++;
            PointsDistributable--;

            chaLabel.Text = CHARISMA.ToString();
            pointsLabel.Text = PointsDistributable.ToString();
            UpdateButton();

        }
    }
}
