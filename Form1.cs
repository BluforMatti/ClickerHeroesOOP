using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerHeroesOOP
{
    public partial class Form1 : Form
    {
        private int level = 1;
        private int monstersKilled = 0;
        private bool handlingDeath = false;
        Player hrac = new Player();
        Monster currentMonster = new Monster();
        Random rnd = new Random();
        private List<string> monsterNames = new List<string>
        {
          "Slime",
          "Tarantula",
          "Goblin",
          "Beetle",
          "Cactus",
          "Rat",
          "Scorpion",
          "Jack'O Lantern"
        };
        public Form1()
        {
            InitializeComponent();
            currentMonster = SpawnMonster(level);
            UpdateUI();
            timer1.Start();
        }
        public Monster SpawnMonster(int level)
        {
            // Každé 10. monstrum bude boss
            if ((monstersKilled + 1) % 10 == 0) // +1 protože ještě nebylo přičteno
            {
                // Náhodně vyber bosse: Dragon nebo Lich
                int bossType = rnd.Next(0, 2); // 0 = Dragon, 1 = Lich
                if (bossType == 0)
                    return new Dragon(level);
                else
                    return new Lich(level);
            }
            else
            {
                // Běžná monstra
                int type = rnd.Next(0, 8);
                switch (type)
                {
                    case 0: return new Slime(level);
                    case 1: return new Goblin(level);
                    case 2: return new Tarantula(level);
                    case 3: return new Beetle(level);
                    case 4: return new Cactus(level);
                    case 5: return new Rat(level);
                    case 6: return new Scorpion(level);
                    case 7: return new JackOLantern(level);
                    default: return new Slime(level);
                }
            }
        }

        private void UpdateUI()
        {
            monsterName.Text = $"{currentMonster.Name}";
            monsterHPbar.Maximum = currentMonster.MaxHealth;
            monsterHPbar.Value = currentMonster.CurrentHealth;
            lblGold.Text = $"Gold: {hrac.Gold}";
            lblClickDamage.Text = $"Click Damage: {hrac.ClickDamage}";
            btnBuyDamage.Text = $"LVL UP\n{hrac.DamageUpgradeCost}";
            monsterHPlabel.Text = currentMonster.GetHP();
            lblLvl.Text = $"Level: {level}";
            btnBuyPassiveDamage.Text = $"LVL UP\n{hrac.PassiveUpgradeCost}";
            lblDamagePerSec.Text = $"DPS: {hrac.PassiveDamage*10}";

            //Nastavení obrázku podle aktuálního mosntra
            if (currentMonster is Slime)
                btnAttack.BackgroundImage = Properties.Resources.Slime;
            else if (currentMonster is Goblin)
                btnAttack.BackgroundImage = Properties.Resources.Goblin;
            else if (currentMonster is Tarantula)
                btnAttack.BackgroundImage = Properties.Resources.Tarantula;
            else if (currentMonster is Beetle)
                btnAttack.BackgroundImage = Properties.Resources.Beetle;
            else if (currentMonster is Cactus)
                btnAttack.BackgroundImage = Properties.Resources.Cactus;
            else if (currentMonster is Rat)
                btnAttack.BackgroundImage = Properties.Resources.Rat;
            else if (currentMonster is Scorpion)
                btnAttack.BackgroundImage = Properties.Resources.Scorpion;
            else if (currentMonster is JackOLantern)
                btnAttack.BackgroundImage = Properties.Resources.Pumpkin;
            else if (currentMonster is Dragon)
                btnAttack.BackgroundImage = Properties.Resources.Dragon;
            else if (currentMonster is Lich)
                btnAttack.BackgroundImage = Properties.Resources.Lich;

            btnAttack.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // volám po každé smrti monstra
        private void HandleMonsterDeath()
        {
            if (handlingDeath) return; // už se zpracovává smrt
            handlingDeath = true;
            hrac.AddGold(currentMonster.RewardGold);
            monstersKilled++; //zvyšuje počet zabitých monster
            // Level-up každých 10 monster, nezávisle na typu
            if (monstersKilled > 0 && monstersKilled % 10 == 0)
            {
                level++;
                MessageBox.Show($"Level up! Teď jsi na levelu {level}");
            }
            // Spawn nového monstra
            currentMonster = SpawnMonster(level);
            handlingDeath = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hrac.ApplyPassiveDamage(currentMonster);
            if (currentMonster.IsDead)
            {
               HandleMonsterDeath();
            }
            UpdateUI();
        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
           currentMonster.TakeDamage(hrac.ClickDamage);
            if (currentMonster.IsDead)
            {
                HandleMonsterDeath();
            }
            UpdateUI();
        }

        private void btnBuyDamage_Click(object sender, EventArgs e)
        {

            if (!hrac.BuyDamageUpgrade())
            {
                MessageBox.Show("Nedostatek goldů!");
            }
            UpdateUI();

        }

        private void btnBuyPassiveDamage_Click(object sender, EventArgs e)
        {
            if (!hrac.BuyPassiveUpgrade())
                MessageBox.Show("Nedostatek goldů!");
            UpdateUI();
        }

        /*------------ CHEAT BUTTONS -------------*/
        private void btnCheats_Click(object sender, EventArgs e)
        {
            if (btnInstaLevel.Visible == true)
            {
                btnInstaLevel.Visible = false;
                btnInstaKill.Visible = false;
                btnInstaGold.Visible = false;
                return;
            }
            else
            {
                btnInstaLevel.Visible = true;
                btnInstaKill.Visible = true;
                btnInstaGold.Visible = true;
            }
        }

        private void btnInstaKill_Click(object sender, EventArgs e)
        {
            currentMonster.CurrentHealth = 0;
            UpdateUI();
        }

        private void btnInstaLevel_Click(object sender, EventArgs e)
        {
            level++;
            MessageBox.Show($"Level up! Teď jsi na levelu {level}");
            UpdateUI();
        }

        private void btnInstaGold_Click(object sender, EventArgs e)
        {
            hrac.AddGold(100000);
            UpdateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblClickDamage_Click(object sender, EventArgs e)
        {

        }
    }
}
