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

        private int AssignDice(string playerClass)
        {
            switch (playerClass)
            {
                case "Barbarian":
                    return 12;
                case "Fighter":
                case "Paladin":
                case "Ranger":
                    return 10;
                case "Bard":
                case "Cleric":
                case "Druid":
                case "Monk":
                case "Rogue":
                case "Warlock":
                    return 8;
                case "Sorcerer":
                case "Wizard":
                    return 6;
                default:
                    return -1;
            }
        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classBox.SelectedItem != null)
            {
                string playerClass = classBox.SelectedItem.ToString();
                int upperDice = AssignDice(playerClass);
            }
        }

        //initializing attributes and points to distribute
        int PointsDistributable = 28;

        int STRENGTH = 8;
        int DEXTERITY = 8;
        int CONSTITUTION = 8;
        int INTELLIGENCE = 8;
        int WISDOM = 8;
        int CHARISMA = 8;

        bool hasAcolyteBonus = false;
        bool hasCharlatanBonus = false;
        bool hasCriminalBonus = false;
        bool hasEntertainerBonus = false;
        bool hasFolkHeroBonus = false;
        bool hasGuildArtisanBonus = false;
        bool hasHermitBonus = false;
        bool hasNobleBonus = false;
        bool hasOutlanderBonus = false;
        bool hasSageBonus = false;
        bool hasSoldierBonus = false;
        bool hasSailorBonus = false;
        bool hasUrchinBonus = false;

        private void ResetBackgroundBonuses() {

            hasAcolyteBonus = false;
            hasCharlatanBonus = false;
            hasCriminalBonus = false;
            hasEntertainerBonus = false;
            hasFolkHeroBonus = false;
            hasGuildArtisanBonus = false;
            hasHermitBonus = false;
            hasNobleBonus = false;
            hasOutlanderBonus = false;
            hasSageBonus = false;
            hasSoldierBonus = false;
            hasSailorBonus = false;
            hasUrchinBonus = false;
        }
        private void UpdateAbilitiesByRace(string playerRace) {

            switch (playerRace)
            {
                case "Dwarf":
                    CONSTITUTION += 2;
                    break;
                case "Elf":
                case "Halfling":
                    DEXTERITY += 2;
                    break;
                case "Human":
                    STRENGTH += 1;
                    DEXTERITY += 1;
                    CONSTITUTION += 1;
                    INTELLIGENCE += 1;
                    WISDOM += 1;
                    CHARISMA += 1;
                    break;
                case "Dragonborn":
                    STRENGTH += 2;
                    CHARISMA += 1;
                    break;
                case "Gnome":
                    INTELLIGENCE += 2;
                    break;
                case "Half-Elf":
                    CHARISMA += 2;
                    PointsDistributable += 2;
                    break;
                case "Half-Orc":
                    STRENGTH += 2;
                    CONSTITUTION += 1;
                    break;
                case "Tiefling":
                    INTELLIGENCE += 1;
                    CHARISMA += 2;
                    break;
                default:
                    break;
            }
        }

        private void raceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classBox.SelectedItem != null)
            {
                string playerRace = raceBox.SelectedItem.ToString();
                UpdateAbilitiesByRace(playerRace);
            }
        }

        private void UpdateProficiencyByBackground(string playerBackground)
        {
            ResetBackgroundBonuses();

            switch (playerBackground)
            {
                case "Acolyte":
                    hasAcolyteBonus = true;
                    break;
                case "Charlatan":
                    hasCharlatanBonus = true;
                    break;
                case "Criminal":
                    hasCriminalBonus = true;
                    break;
                case "Entertainer":
                    hasEntertainerBonus = true;
                    break;
                case "Folk Hero":
                    hasFolkHeroBonus = true;
                    break;
                case "Guild Artisan":
                    hasGuildArtisanBonus = true;
                    break;
                case "Hermit":
                    hasHermitBonus = true;
                    break;
                case "Noble":
                    hasNobleBonus = true;
                    break;
                case "Outlander":
                    hasOutlanderBonus = true;
                    break;
                case "Sage":
                    hasSageBonus = true;
                    break;
                case "Sailor":
                    hasSailorBonus = true;
                    break;
                case "Soldier":
                    hasSoldierBonus = true;
                    break;
                case "Urchin":
                    hasUrchinBonus = true;
                    break;
                default: 
                    break;
            }
        }

        //method to enable and disable buttons
        private void UpdateButton()
        {
            StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 18;
            StrDownButton.Enabled = STRENGTH > 1;

            DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 18;
            DexDownButton.Enabled = DEXTERITY > 1;

            ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 18;
            ConDownButton.Enabled = CONSTITUTION > 1;

            IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 18;
            IntDownButton.Enabled = INTELLIGENCE > 1;

            WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
            WisDownButton.Enabled = WISDOM > 1;

            ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 18;
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
            int strengthValue = STRENGTH;
            int strengthModifier = CalculateSkillValue(STRENGTH);

            int AthleticsBonus = 0;
            if(hasUrchinBonus || hasSoldierBonus || hasOutlanderBonus)
            {
                AthleticsBonus += 2;
            }
            
            int TotalAthletics = strengthModifier + AthleticsBonus;
            Athletics.Text = TotalAthletics.ToString();

        }

        private void UpdateDexteritySkillLabels()
        {
            int dexterityValue = DEXTERITY;
            int dexterityModifier = CalculateSkillValue(DEXTERITY);

            int AcrobaticsBonus = 0;
            int SleightofHandBonus = 0;
            int StealthBonus = 0;

            if (hasEntertainerBonus)
            {
                AcrobaticsBonus += 2;
            }

            if (hasCharlatanBonus || hasUrchinBonus)
            {
                SleightofHandBonus += 2;
            }

            if(hasCriminalBonus || hasUrchinBonus)
            {
                StealthBonus += 2;
            }

            int TotalAcrobatics = dexterityModifier + AcrobaticsBonus;
            int TotalSleightofHand = dexterityModifier + SleightofHandBonus;
            int TotalStealth = dexterityModifier + StealthBonus;

            Acrobatics.Text = TotalAcrobatics.ToString();
            SleightofHand.Text = TotalSleightofHand.ToString();
            Stealth.Text = TotalStealth.ToString();

        }

        private void UpdateIntelligenceSkillLabels()
        {
            int intelligenceValue = INTELLIGENCE;
            int intelligenceModifier = CalculateSkillValue(INTELLIGENCE);

            int ArcanaBonus = 0;
            int HistoryBonus = 0;
            int ReligionBonus = 0;

            if (hasSageBonus)
            {
                ArcanaBonus += 2;
            }

            if (hasNobleBonus || hasSageBonus)
            {
                HistoryBonus += 2;
            }

            if (hasAcolyteBonus || hasHermitBonus)
            {
                ReligionBonus += 2;
            }
            
            int TotalArcana = intelligenceModifier + ArcanaBonus;
            int TotalHistory = intelligenceModifier + HistoryBonus;
            int TotalReligion = intelligenceModifier + ReligionBonus;


            Arcana.Text = TotalArcana.ToString();
            History.Text = TotalHistory.ToString();
            Investigation.Text = intelligenceModifier.ToString();
            Nature.Text = intelligenceModifier.ToString();
            Religion.Text = TotalReligion.ToString();

        }

        private void UpdateWisdomSkillLabels()
        {
            int wisdomValue = WISDOM;
            int wisdomModifier = CalculateSkillValue(WISDOM);

            int AnimalHandlingBonus = 0;
            int InsightBonus = 0;
            int MedicineBonus = 0;
            int PerceptionBonus = 0;
            int SurvivalBonus = 0;
            
            if (hasFolkHeroBonus)
            {
                AnimalHandlingBonus += 2;
            }

            if (hasAcolyteBonus || hasGuildArtisanBonus)
            {
                InsightBonus += 2;
            }

            if (hasHermitBonus)
            {
                MedicineBonus += 2;
            }

            if (hasSailorBonus)
            {
                PerceptionBonus += 2;
            }

            if (hasFolkHeroBonus || hasOutlanderBonus)
            {
                SurvivalBonus += 2;
            }

            int TotalAnimalHandling = wisdomModifier + AnimalHandlingBonus;
            int TotalInsight = wisdomModifier + InsightBonus;
            int TotalMedicine = wisdomModifier + MedicineBonus;
            int TotalPerception = wisdomModifier + PerceptionBonus;
            int TotalSurvival = wisdomModifier + SurvivalBonus;

            AnimalHandling.Text = TotalAnimalHandling.ToString();
            Insight.Text = TotalInsight.ToString();
            Medicine.Text = TotalMedicine.ToString();
            Perception.Text = TotalPerception.ToString();
            Survival.Text = TotalSurvival.ToString();

        }

        private void UpdateCharismaSkillLabels()
        {
            int charismaValue = CHARISMA;
            int charismaModifier = CalculateSkillValue(CHARISMA);

            int DeceptionBonus = 0;
            int IntimidationBonus = 0;
            int PerformanceBonus = 0;
            int PersuasionBonus = 0;

            if (hasCharlatanBonus || hasCriminalBonus)
            {
                DeceptionBonus += 2;
            }

            if (hasSoldierBonus)
            {
                IntimidationBonus += 2;
            }

            if (hasEntertainerBonus)
            {
                PerformanceBonus += 2;
            }

            if (hasGuildArtisanBonus || hasNobleBonus)
            {
                PersuasionBonus += 2;
            }

            int TotalDeception = charismaModifier + DeceptionBonus;
            int TotalIntimidation = charismaModifier + IntimidationBonus;
            int TotalPerformance = charismaModifier + PerformanceBonus;
            int TotalPersuasion = charismaModifier + PersuasionBonus;

            Deception.Text = TotalDeception.ToString();
            Intimidation.Text = TotalIntimidation.ToString();
            Performance.Text = TotalPerformance.ToString();
            Persuasion.Text = TotalPersuasion.ToString();
        }

        private void backgroundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (backgroundBox.SelectedItem != null)
            {
                string playerBackground = backgroundBox.SelectedItem.ToString();
                UpdateProficiencyByBackground(playerBackground);

                UpdateStrengthSkillLabels();
                UpdateDexteritySkillLabels();
                UpdateIntelligenceSkillLabels();
                UpdateWisdomSkillLabels();
                UpdateCharismaSkillLabels();
            }

        }
    }
}
