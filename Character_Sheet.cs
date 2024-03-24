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

        //assigning class dice based on player's class
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

        //initializing attributes and points to distribute
        int PointsDistributable = 28;

        int STRENGTH = 8;
        int DEXTERITY = 8;
        int CONSTITUTION = 8;
        int INTELLIGENCE = 8;
        int WISDOM = 8;
        int CHARISMA = 8;

        //initializing background flags for skill bonuses
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

        //resetting attributes
        private void ResetAttributes()
        {
            STRENGTH = 8;
            strLabel.Text = STRENGTH.ToString();

            DEXTERITY = 8;
            dexLabel.Text = DEXTERITY.ToString();

            CONSTITUTION = 8;
            conLabel.Text = CONSTITUTION.ToString();

            INTELLIGENCE = 8;
            intLabel.Text = INTELLIGENCE.ToString();

            WISDOM = 8;
            wisLabel.Text = WISDOM.ToString();

            CHARISMA = 8;
            chaLabel.Text = CHARISMA.ToString();

            PointsDistributable = 28;
            pointsLabel.Text = PointsDistributable.ToString();
        }

        //method for resetting background flags
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

        //giving ability bonuses depending on player's race
        private void UpdateAbilitiesByRace(string playerRace) {
            
            switch (playerRace)
            {
                case "Dwarf":
                    int strength = int.Parse(strLabel.Text);
                    strength += 2;
                    strLabel.Text = strength.ToString();
                    break;

                case "Elf":
                case "Halfling":
                    int dexterity = int.Parse(dexLabel.Text);
                    dexterity += 2;
                    dexLabel.Text = dexterity.ToString();
                    break;

                case "Human":
                    strength = int.Parse(strLabel.Text);
                    dexterity = int.Parse(dexLabel.Text);
                    int constitution = int.Parse(conLabel.Text);
                    int intelligence = int.Parse(intLabel.Text);
                    int wisdom = int.Parse(wisLabel.Text);
                    int charisma = int.Parse(chaLabel.Text);

                    strength += 1;
                    dexterity += 1;
                    constitution += 1;
                    intelligence += 1;
                    wisdom += 1;
                    charisma += 1;

                    strLabel.Text = strength.ToString();
                    dexLabel.Text = dexterity.ToString();
                    conLabel.Text = constitution.ToString();
                    intLabel.Text = intelligence.ToString();
                    wisLabel.Text = wisdom.ToString();
                    chaLabel.Text = charisma.ToString();
                    break;

                case "Dragonborn":
                    strength = int.Parse(strLabel.Text);
                    charisma = int.Parse(chaLabel.Text);

                    strength += 2;
                    charisma += 1;

                    strLabel.Text = strength.ToString();
                    chaLabel.Text = charisma.ToString();

                    break;

                case "Gnome":
                    intelligence = int.Parse(intLabel.Text);
                    intelligence += 2;
                    intLabel.Text = intelligence.ToString();
                    break;

                case "Half-Elf":
                    charisma = int.Parse(chaLabel.Text);
                    charisma += 2;
                    PointsDistributable += 2;

                    chaLabel.Text = charisma.ToString();
                    pointsLabel.Text = PointsDistributable.ToString();
                    break;

                case "Half-Orc":
                    strength = int.Parse(strLabel.Text);
                    constitution = int.Parse(conLabel.Text);

                    strength += 2;
                    constitution += 1;

                    strLabel.Text = strength.ToString();
                    conLabel.Text = constitution.ToString();
                    break;
                case "Tiefling":
                    intelligence = int.Parse(intLabel.Text);
                    charisma = int.Parse(chaLabel.Text);

                    intelligence += 1;
                    charisma += 2;

                    intLabel.Text = intelligence.ToString();
                    chaLabel.Text = charisma.ToString();
                    break;
                default:
                    break;
            }
        }

        private void UpdateProficiencyByBackground(string playerBackground)
        {
            ResetBackgroundBonuses();
            proficiencies.Text = "";

            switch (playerBackground)
            {
                case "Acolyte":
                    hasAcolyteBonus = true;
                    proficiencies.Text = "Insight, Religion";
                    break;

                case "Charlatan":
                    hasCharlatanBonus = true;
                    proficiencies.Text = "Deception, Sleight of Hand";
                    break;

                case "Criminal":
                    hasCriminalBonus = true;
                    proficiencies.Text = "Deception, Stealth";
                    break;

                case "Entertainer":
                    hasEntertainerBonus = true;
                    proficiencies.Text = "Acrobatics, Performance";
                    break;

                case "Folk Hero":
                    hasFolkHeroBonus = true;
                    proficiencies.Text = "Animal Handling, Survival";
                    break;

                case "Guild Artisan":
                    hasGuildArtisanBonus = true;
                    proficiencies.Text = "Insight, Persuasion";
                    break;

                case "Hermit":
                    hasHermitBonus = true;
                    proficiencies.Text = "Medicine, Religion";
                    break;

                case "Noble":
                    hasNobleBonus = true;
                    proficiencies.Text = "History, Persuasion";
                    break;

                case "Outlander":
                    hasOutlanderBonus = true;
                    proficiencies.Text = "Athletics, Survival";
                    break;

                case "Sage":
                    hasSageBonus = true;
                    proficiencies.Text = "Arcana, History";
                    break;

                case "Sailor":
                    hasSailorBonus = true;
                    proficiencies.Text = "Athletics, Perception";
                    break;

                case "Soldier":
                    hasSoldierBonus = true;
                    proficiencies.Text = "Athletics, Intimidation";
                    break;

                case "Urchin":
                    hasUrchinBonus = true;
                    proficiencies.Text = "Sleight of Hand, Stealth";
                    break;

                default: 
                    break;
            }
        }

        //method to enable and disable buttons
        private void UpdateButton()
        {
            if (raceBox.SelectedItem != null)
            {
                string playerRace = raceBox.SelectedItem.ToString();

                if (playerRace == "Dwarf")
                {
                    StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 18;
                    StrDownButton.Enabled = STRENGTH > 1;

                    DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 18;
                    DexDownButton.Enabled = DEXTERITY > 1;

                    ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 20;
                    ConDownButton.Enabled = CONSTITUTION > 3;

                    IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 18;
                    IntDownButton.Enabled = INTELLIGENCE > 1;

                    WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
                    WisDownButton.Enabled = WISDOM > 1;

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 18;
                    ChaDownButton.Enabled = CHARISMA > 1;
                } 
                else if (playerRace == "Elf" || playerRace == "Halfling" )
                {
                    StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 18;
                    StrDownButton.Enabled = STRENGTH > 1;

                    DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 20;
                    DexDownButton.Enabled = DEXTERITY > 3;

                    ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 18;
                    ConDownButton.Enabled = CONSTITUTION > 1;

                    IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 18;
                    IntDownButton.Enabled = INTELLIGENCE > 1;

                    WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
                    WisDownButton.Enabled = WISDOM > 1;

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 18;
                    ChaDownButton.Enabled = CHARISMA > 1;
                }
                else if(playerRace == "Human")
                {
                    StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 18;
                    StrDownButton.Enabled = STRENGTH > 2;

                    DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 18;
                    DexDownButton.Enabled = DEXTERITY > 2;

                    ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 18;
                    ConDownButton.Enabled = CONSTITUTION > 2;

                    IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 18;
                    IntDownButton.Enabled = INTELLIGENCE > 2;

                    WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
                    WisDownButton.Enabled = WISDOM > 2;

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 18;
                    ChaDownButton.Enabled = CHARISMA > 2;
                }
                else if(playerRace == "Dragonborn")
                {
                    StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 20;
                    StrDownButton.Enabled = STRENGTH > 3;

                    DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 18;
                    DexDownButton.Enabled = DEXTERITY > 1;

                    ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 18;
                    ConDownButton.Enabled = CONSTITUTION > 1;

                    IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 18;
                    IntDownButton.Enabled = INTELLIGENCE > 1;

                    WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
                    WisDownButton.Enabled = WISDOM > 1;

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 19;
                    ChaDownButton.Enabled = CHARISMA > 2;
                }
                else if (playerRace == "Gnome")
                {
                    StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 18;
                    StrDownButton.Enabled = STRENGTH > 1;

                    DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 18;
                    DexDownButton.Enabled = DEXTERITY > 1;

                    ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 18;
                    ConDownButton.Enabled = CONSTITUTION > 1;

                    IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 20;
                    IntDownButton.Enabled = INTELLIGENCE > 3;

                    WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
                    WisDownButton.Enabled = WISDOM > 1;

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 18;
                    ChaDownButton.Enabled = CHARISMA > 1;
                }
                else if (playerRace == "Half-Elf")
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

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 20;
                    ChaDownButton.Enabled = CHARISMA > 3;
                }
                else if (playerRace == "Half-Orc")
                {
                    StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 20;
                    StrDownButton.Enabled = STRENGTH > 3;

                    DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 18;
                    DexDownButton.Enabled = DEXTERITY > 1;

                    ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 19;
                    ConDownButton.Enabled = CONSTITUTION > 2;

                    IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 18;
                    IntDownButton.Enabled = INTELLIGENCE > 1;

                    WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
                    WisDownButton.Enabled = WISDOM > 1;

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 18;
                    ChaDownButton.Enabled = CHARISMA > 1;
                }
                else if (playerRace == "Tiefling")
                {
                    StrUpButton.Enabled = PointsDistributable > 0 && STRENGTH < 18;
                    StrDownButton.Enabled = STRENGTH > 1;

                    DexUpButton.Enabled = PointsDistributable > 0 && DEXTERITY < 18;
                    DexDownButton.Enabled = DEXTERITY > 1;

                    ConUpButton.Enabled = PointsDistributable > 0 && CONSTITUTION < 18;
                    ConDownButton.Enabled = CONSTITUTION > 1;

                    IntUpButton.Enabled = PointsDistributable > 0 && INTELLIGENCE < 19;
                    IntDownButton.Enabled = INTELLIGENCE > 2;

                    WisUpButton.Enabled = PointsDistributable > 0 && WISDOM < 18;
                    WisDownButton.Enabled = WISDOM > 1;

                    ChaUpButton.Enabled = PointsDistributable > 0 && CHARISMA < 20;
                    ChaDownButton.Enabled = CHARISMA > 3;
                }
            }
            else
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

        private void raceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAttributes();
            UpdateButton();
            if (raceBox.SelectedItem != null)
            {
                string playerRace = raceBox.SelectedItem.ToString();
                UpdateAbilitiesByRace(playerRace);
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
    }
}
