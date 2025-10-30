using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerHeroesOOP
{
    public class Monster // Základní třída Monster - odvíjí se od ní ostatní monstra a bossové 
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int RewardGold { get; set; }

        // KONSTRUKTOR 
        public Monster() { }

        // Hlavní konstruktor pro všechny monstra
        public Monster(string name, int level, int baseHP, int baseGold)
        {
            Name = name;
            Level = level;

            ScaleStats(level, baseHP, baseGold);
        }
        // virtuální metoda pro škálování aby se dala použít u Boss: Monster
        public virtual void ScaleStats(int level, int baseHP, int baseGold)
        {
            // HP roste rychlejš než gold 
            MaxHealth = (int)(baseHP * Math.Pow(1.6, level - 1));
            CurrentHealth = MaxHealth;

            // Gold roste pomalejc než HP 
            RewardGold = (int)(baseGold * Math.Pow(1.55, level - 1));
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
    } // konec třídy Monster

    public class Player // Třída hráče
    {
        public int ClickDamage { get; set; }
        public int PassiveDamage { get; set; }
        public int Gold { get; set; }

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
            { //check jestli mám dost goldů
                Gold -= DamageUpgradeCost;
                ClickDamage += 5;

                // růst cen
                DamageUpgradeCost = (int)(DamageUpgradeCost * 1.05 + 20);

                return true;
            }
            return false;
        }

        public bool BuyPassiveUpgrade()
        { //check jestli mám dost goldů
            if (Gold >= PassiveUpgradeCost)
            {
                Gold -= PassiveUpgradeCost;

                PassiveDamage += 2;

                // růst cen
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
    }// konec třídy Player

    //bossové abych měl víc tříd :)
    public class Boss : Monster
    {
        //konstruktor 
        public Boss(string name, int level, int baseHP, int baseGold) : base(name, level, baseHP, baseGold)
        {

        }
        public override void ScaleStats(int level, int baseHP, int baseGold)
        {
            // Bossové mají větší růst HP a Goldu než běžná monstra
            MaxHealth = (int)(baseHP * Math.Pow(1.6, level - 1));
            CurrentHealth = MaxHealth;
            RewardGold = (int)(baseGold * Math.Pow(1.5, level - 1));
        }
        // Bossové berou méně damage - použití OVERRIDE 
        public override void TakeDamage(int amount)
        {
            //dostane jen 80 % damage
            int reduced = (int)(amount * 0.8);
            base.TakeDamage(reduced);
        }
    }

    // Konkrétní třídy bossů
    public class Dragon : Boss
    {
        static int BaseHP = 1000;
        static int BaseGold = 500;

        public Dragon(int level) : base("Dragon", level, BaseHP, BaseGold) { }
    }
    public class Lich : Boss
    {
        static int BaseHP = 800;
        static int BaseGold = 400;
        public Lich(int level) : base("Lich", level, BaseHP, BaseGold) { }
    }

    // Konkrétní třídy monster
    public class Slime : Monster
    {// samotné int BaseHP by bylo instanční proměnná, ale volám ji už v :base()
     // musím použít static, protože jinak by to házelo chybu při volání konstruktoru
        private static int BaseHP = 50;
        private static int BaseGold = 10;

        public Slime(int level) : base("Slime", level, BaseHP, BaseGold) { }
    }

    public class Goblin : Monster
    {
        private static int BaseHP = 80;
        private static int BaseGold = 15;

        public Goblin(int level) : base("Goblin", level, BaseHP, BaseGold) { }
    }

    public class Tarantula : Monster
    {
        private static int BaseHP = 70;
        private static int BaseGold = 15;

        public Tarantula(int level) : base("Tarantula", level, BaseHP, BaseGold) { }
    }

    public class Beetle : Monster
    {
        private static int BaseHP = 100;
        private static int BaseGold = 25;

        public Beetle(int level) : base("Beetle", level, BaseHP, BaseGold) { }
    }

    public class Cactus : Monster
    {
        private static int BaseHP = 90;
        private static int BaseGold = 18;

        public Cactus(int level) : base("Cactus", level, BaseHP, BaseGold) { }
    }

    public class Rat : Monster
    {
        private static int BaseHP = 40;
        private static int BaseGold = 5;

        public Rat(int level) : base("Rat", level, BaseHP, BaseGold) { }
    }

    public class Scorpion : Monster
    {
        private static int BaseHP = 65;
        private static int BaseGold = 22;

        public Scorpion(int level) : base("Scorpion", level, BaseHP, BaseGold) { }
    }

    public class JackOLantern : Monster
    {
        private static int BaseHP = 200;
        private static int BaseGold = 100;

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
