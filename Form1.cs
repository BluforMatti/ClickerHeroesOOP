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
        }

        //aby se nestalo, že kliknu na tlačítko a zároveň zemře monstrum pasivně a duplikuju drops, používám handle,ten volám po každé smrti monstra
        private void HandleMonsterDeath()
        {
            hrac.AddGold(currentMonster.RewardGold);
            monstersKilled++;
            // každých 10 monster level up
            if (monstersKilled > 0)
            {
                if (monstersKilled % 10 == 0)
                {
                    level++;
                    MessageBox.Show($"Level up! Teď jsi na levelu {level}");
                }
            }
            currentMonster = SpawnMonster(level);
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
