using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        //initializing attributes and points to distribute
        int PointsDistributable = 28;

        int STRENGTH = 8;
        int DEXTERITY = 8;
        int CONSTITUTION = 8;
        int INTELLIGENCE = 8;
        int WISDOM = 8;
        int CHARISMA = 8;

        //method to enable and disable buttons
        private void UpdateButton()
        {
            StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 20;
            StrDownButton.Enabled = STRENGTH > 1;

            DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 20;
            DexDownButton.Enabled = DEXTERITY > 1;

            ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 20;
            ConDownButton.Enabled = CONSTITUTION > 1;

            IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 20;
            IntDownButton.Enabled = INTELLIGENCE > 1;

            WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 20;
            WisDownButton.Enabled = WISDOM > 1;

            ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 20;
            ChaDownButton.Enabled = CHARISMA > 1;

        }

        //Character Sheet on load
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
            UpdateStrengthSkillLabels();
            UpdateDexteritySkillLabels();
            UpdateIntelligenceSkillLabels();
            UpdateWisdomSkillLabels();
            UpdateCharismaSkillLabels();
        }
        
        //Attribute buttons
        private void StrDownButton_Click(object sender, EventArgs e)
        {
            STRENGTH--;
            PointsDistributable++;

            strLabel.Text = STRENGTH.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateStrengthSkillLabels();
        }

        private void StrUpButton_Click(object sender, EventArgs e)
        {
            STRENGTH++;
            PointsDistributable--;

            strLabel.Text = STRENGTH.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateStrengthSkillLabels();
        }

        private void DexDownButton_Click(object sender, EventArgs e)
        {
            DEXTERITY--;
            PointsDistributable++;

            dexLabel.Text = DEXTERITY.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateDexteritySkillLabels();

        }

        private void DexUpButton_Click(object sender, EventArgs e)
        {
            DEXTERITY++;
            PointsDistributable--;

            dexLabel.Text = DEXTERITY.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateDexteritySkillLabels();

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
            UpdateIntelligenceSkillLabels();
        }

        private void IntUpButton_Click(object sender, EventArgs e)
        {
            INTELLIGENCE++;
            PointsDistributable--;

            intLabel.Text = INTELLIGENCE.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateIntelligenceSkillLabels();

        }

        private void WisDownButton_Click(object sender, EventArgs e)
        {
            WISDOM--;
            PointsDistributable++;

            wisLabel.Text = WISDOM.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateWisdomSkillLabels();
        }

        private void WisUpButton_Click(object sender, EventArgs e)
        {
            WISDOM++;
            PointsDistributable--;

            wisLabel.Text = WISDOM.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateWisdomSkillLabels();

        }

        private void ChaDownButton_Click(object sender, EventArgs e)
        {
            CHARISMA--;
            PointsDistributable++;

            chaLabel.Text = CHARISMA.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateCharismaSkillLabels();
        }

        private void ChaUpButton_Click(object sender, EventArgs e)
        {
            CHARISMA++;
            PointsDistributable--;

            chaLabel.Text = CHARISMA.ToString();
            pointsLabel.Text = PointsDistributable.ToString();

            UpdateButton();
            UpdateCharismaSkillLabels();

        }

        //updating skills
        private int CalculateSkillValue(int abilityScore)
        {
            if (abilityScore == 20)
            {
                return 5;
            }
            else if (abilityScore >= 18)
            {
                return 4;
            }
            else if (abilityScore >= 16)
            {
                return 3;
            }
            else if (abilityScore >= 14)
            {
                return 2;
            }
            else if (abilityScore >= 12)
            {
                return 1;
            }
            else if (abilityScore >= 10)
            {
                return 0;
            }
            else if (abilityScore >= 8) {
                return -1; 
            }
            else if(abilityScore >= 6)
            {
                return -2;
            }
            else if(abilityScore >= 4)
            {
                return -3;
            }
            else if(abilityScore >= 2)
            {
                return -4;
            }
            else if(abilityScore == 1)
            {
                return -5;
            }
            else
            {
                return 0;
            }
        }



        private void UpdateStrengthSkillLabels()
        {
            int athleticsValue = CalculateSkillValue(STRENGTH);
            Athletics.Text = athleticsValue.ToString();

        }

        private void UpdateDexteritySkillLabels()
        {
            int dexterityValue = CalculateSkillValue(DEXTERITY);
            Acrobatics.Text = dexterityValue.ToString();
            SleightofHand.Text = dexterityValue.ToString();
            Stealth.Text = dexterityValue.ToString();

        }

        private void UpdateIntelligenceSkillLabels()
        {
            int intelligenceValue = CalculateSkillValue(INTELLIGENCE);
            Arcana.Text = intelligenceValue.ToString();
            History.Text = intelligenceValue.ToString();
            Investigation.Text = intelligenceValue.ToString();
            Nature.Text = intelligenceValue.ToString();
            Religion.Text = intelligenceValue.ToString();

        }

        private void UpdateWisdomSkillLabels()
        {
            int wisdomValue = CalculateSkillValue(WISDOM);
            AnimalHandling.Text = wisdomValue.ToString();
            Insight.Text = wisdomValue.ToString();
            Medicine.Text = wisdomValue.ToString();
            Perception.Text = wisdomValue.ToString();
            Survival.Text = wisdomValue.ToString();

        }

        private void UpdateCharismaSkillLabels()
        {
            int charismaValue = CalculateSkillValue(CHARISMA);
            Deception.Text = charismaValue.ToString();
            Intimidation.Text = charismaValue.ToString();
            Performance.Text = charismaValue.ToString();
            Persuasion.Text = charismaValue.ToString();
        }

    }
}
