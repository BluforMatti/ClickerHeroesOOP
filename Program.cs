using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerHeroesOOP
{
    public class Monster
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int RewardGold { get; set; }

        protected int BaseHP;    // základní HP
        protected int BaseGold;  // základní gold

        // EXPLICITNÍ BEZPARAMETRICKÝ KONSTRUKTOR 
        public Monster() { }

        // Hlavní konstruktor pro všechny monstra
        public Monster(string name, int level, int baseHP, int baseGold)
        {
            Name = name;
            Level = level;
            BaseHP = baseHP;
            BaseGold = baseGold;

            ScaleStats(level);
        }

        protected void ScaleStats(int level)
        {
            // HP roste rychlejš než gold 
            MaxHealth = (int)(BaseHP * Math.Pow(1.6, level - 1));
            CurrentHealth = MaxHealth;

            // Gold roste pomalejc než HP 
            RewardGold = (int)(BaseGold * Math.Pow(1.55, level - 1));
        }

        public virtual void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            if (CurrentHealth < 0)
                CurrentHealth = 0;
        }

        public virtual string GetHP()
        {
            return $"{CurrentHealth}/{MaxHealth}";
        }

        public bool IsDead => CurrentHealth <= 0;
    }

    public class Player
    {
        public int ClickDamage { get; set; }
        public int PassiveDamage { get; set; }
        public int Gold { get;  set; }

        public int DamageUpgradeCost { get; set; }
        public int PassiveUpgradeCost { get; set; }

        public Player()
        {
            ClickDamage = 10;
            PassiveDamage = 0;
            Gold = 0;
            DamageUpgradeCost = 100;
            PassiveUpgradeCost = 200;
        }

        public void Attack(Monster monster)
        {
            monster.TakeDamage(ClickDamage);
        }

        public void AddGold(int amount)
        {
            Gold += amount;
        }

        public bool BuyDamageUpgrade()
        {
            if (Gold >= DamageUpgradeCost)
            {
                Gold -= DamageUpgradeCost;
                ClickDamage += 5;

                // Cena roste pomalu
                DamageUpgradeCost = (int)(DamageUpgradeCost * 1.05 + 20);

                return true;
            }
            return false;
        }

        public bool BuyPassiveUpgrade()
        {
            if (Gold >= PassiveUpgradeCost)
            {
                Gold -= PassiveUpgradeCost;

                PassiveDamage += 2;

                // Cena roste pomalu 
                PassiveUpgradeCost = (int)(PassiveUpgradeCost * 1.05 + 50);

                return true;
            }
            return false;
        }

        // Použít pasivní damage na aktuální monstrum
        public void ApplyPassiveDamage(Monster monster)
        {
            if (PassiveDamage > 0 && !monster.IsDead)
            {
                monster.TakeDamage(PassiveDamage);
            }
        }
    }
    public class Slime : Monster
    {
        private const int BaseHPConst = 50;
        private const int BaseGoldConst = 10;

        public Slime(int level) : base("Slime", level, BaseHPConst, BaseGoldConst) { }
    }

    public class Goblin : Monster
    {
        private new const int BaseHP = 80;
        private new const int BaseGold = 15;

        public Goblin(int level) : base("Goblin", level, BaseHP, BaseGold) { }
    }

    public class Tarantula : Monster
    {
        private new const int BaseHP = 70;
        private new const int BaseGold = 15;

        public Tarantula(int level) : base("Tarantula", level, BaseHP, BaseGold) { }
    }

    public class Beetle : Monster
    {
        private new const int BaseHP = 100;
        private new const int BaseGold = 25;

        public Beetle(int level) : base("Beetle", level, BaseHP, BaseGold) { }
    }

    public class Cactus : Monster
    {
        private new const int BaseHP = 90;
        private new const int BaseGold = 18;

        public Cactus(int level) : base("Cactus", level, BaseHP, BaseGold) { }
    }

    public class Rat : Monster
    {
        private new const int BaseHP = 40;
        private new const int BaseGold = 5;

        public Rat(int level) : base("Rat", level, BaseHP, BaseGold) { }
    }

    public class Scorpion : Monster
    {
        private new const int BaseHP = 65;
        private new const int BaseGold = 22;

        public Scorpion(int level) : base("Scorpion", level, BaseHP, BaseGold) { }
    }

    public class JackOLantern : Monster
    {
        private new const int BaseHP = 200;
        private new const int BaseGold = 100;

        public JackOLantern(int level) : base("Jack'O Lantern", level, BaseHP, BaseGold) { }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
