namespace ClickerHeroesOOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAttack = new System.Windows.Forms.Button();
            this.monsterName = new System.Windows.Forms.Label();
            this.monsterHPbar = new System.Windows.Forms.ProgressBar();
            this.monsterHPlabel = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.btnBuyDamage = new System.Windows.Forms.Button();
            this.lblClickDamage = new System.Windows.Forms.Label();
            this.btnCheats = new System.Windows.Forms.Button();
            this.btnInstaKill = new System.Windows.Forms.Button();
            this.btnInstaLevel = new System.Windows.Forms.Button();
            this.lblLvl = new System.Windows.Forms.Label();
            this.btnInstaGold = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBuyPassiveDamage = new System.Windows.Forms.Button();
            this.lblDamagePerSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(449, 45);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(275, 312);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // monsterName
            // 
            this.monsterName.AutoSize = true;
            this.monsterName.Location = new System.Drawing.Point(544, 360);
            this.monsterName.Name = "monsterName";
            this.monsterName.Size = new System.Drawing.Size(24, 13);
            this.monsterName.TabIndex = 1;
            this.monsterName.Text = "text";
            // 
            // monsterHPbar
            // 
            this.monsterHPbar.Location = new System.Drawing.Point(524, 376);
            this.monsterHPbar.Name = "monsterHPbar";
            this.monsterHPbar.Size = new System.Drawing.Size(100, 24);
            this.monsterHPbar.TabIndex = 2;
            // 
            // monsterHPlabel
            // 
            this.monsterHPlabel.AutoSize = true;
            this.monsterHPlabel.BackColor = System.Drawing.Color.White;
            this.monsterHPlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monsterHPlabel.Location = new System.Drawing.Point(557, 382);
            this.monsterHPlabel.Name = "monsterHPlabel";
            this.monsterHPlabel.Size = new System.Drawing.Size(35, 13);
            this.monsterHPlabel.TabIndex = 3;
            this.monsterHPlabel.Text = "label1";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.Color.Tan;
            this.lblGold.Location = new System.Drawing.Point(49, 21);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(71, 13);
            this.lblGold.TabIndex = 4;
            this.lblGold.Text = "Gold: 000000";
            // 
            // btnBuyDamage
            // 
            this.btnBuyDamage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuyDamage.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnBuyDamage.FlatAppearance.BorderSize = 5;
            this.btnBuyDamage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuyDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyDamage.Location = new System.Drawing.Point(44, 176);
            this.btnBuyDamage.Name = "btnBuyDamage";
            this.btnBuyDamage.Size = new System.Drawing.Size(150, 51);
            this.btnBuyDamage.TabIndex = 5;
            this.btnBuyDamage.Text = "LVL UP";
            this.btnBuyDamage.UseVisualStyleBackColor = false;
            this.btnBuyDamage.Click += new System.EventHandler(this.btnBuyDamage_Click);
            // 
            // lblClickDamage
            // 
            this.lblClickDamage.AutoSize = true;
            this.lblClickDamage.BackColor = System.Drawing.Color.Tan;
            this.lblClickDamage.Location = new System.Drawing.Point(49, 45);
            this.lblClickDamage.Name = "lblClickDamage";
            this.lblClickDamage.Size = new System.Drawing.Size(88, 13);
            this.lblClickDamage.TabIndex = 6;
            this.lblClickDamage.Text = "10 Click Damage";
            this.lblClickDamage.Click += new System.EventHandler(this.lblClickDamage_Click);
            // 
            // btnCheats
            // 
            this.btnCheats.Location = new System.Drawing.Point(12, 415);
            this.btnCheats.Name = "btnCheats";
            this.btnCheats.Size = new System.Drawing.Size(75, 23);
            this.btnCheats.TabIndex = 7;
            this.btnCheats.Text = "Cheats";
            this.btnCheats.UseVisualStyleBackColor = true;
            this.btnCheats.Click += new System.EventHandler(this.btnCheats_Click);
            // 
            // btnInstaKill
            // 
            this.btnInstaKill.Location = new System.Drawing.Point(93, 415);
            this.btnInstaKill.Name = "btnInstaKill";
            this.btnInstaKill.Size = new System.Drawing.Size(75, 23);
            this.btnInstaKill.TabIndex = 8;
            this.btnInstaKill.Text = "KILL";
            this.btnInstaKill.UseVisualStyleBackColor = true;
            this.btnInstaKill.Visible = false;
            this.btnInstaKill.Click += new System.EventHandler(this.btnInstaKill_Click);
            // 
            // btnInstaLevel
            // 
            this.btnInstaLevel.Location = new System.Drawing.Point(174, 415);
            this.btnInstaLevel.Name = "btnInstaLevel";
            this.btnInstaLevel.Size = new System.Drawing.Size(75, 23);
            this.btnInstaLevel.TabIndex = 9;
            this.btnInstaLevel.Text = "LVL UP";
            this.btnInstaLevel.UseVisualStyleBackColor = true;
            this.btnInstaLevel.Visible = false;
            this.btnInstaLevel.Click += new System.EventHandler(this.btnInstaLevel_Click);
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.BackColor = System.Drawing.Color.Tan;
            this.lblLvl.Location = new System.Drawing.Point(49, 71);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(35, 13);
            this.lblLvl.TabIndex = 10;
            this.lblLvl.Text = "label1";
            // 
            // btnInstaGold
            // 
            this.btnInstaGold.Location = new System.Drawing.Point(255, 415);
            this.btnInstaGold.Name = "btnInstaGold";
            this.btnInstaGold.Size = new System.Drawing.Size(75, 23);
            this.btnInstaGold.TabIndex = 11;
            this.btnInstaGold.Text = "GOLD";
            this.btnInstaGold.UseVisualStyleBackColor = true;
            this.btnInstaGold.Visible = false;
            this.btnInstaGold.Click += new System.EventHandler(this.btnInstaGold_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBuyPassiveDamage
            // 
            this.btnBuyPassiveDamage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuyPassiveDamage.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnBuyPassiveDamage.FlatAppearance.BorderSize = 5;
            this.btnBuyPassiveDamage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuyPassiveDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyPassiveDamage.Location = new System.Drawing.Point(44, 258);
            this.btnBuyPassiveDamage.Name = "btnBuyPassiveDamage";
            this.btnBuyPassiveDamage.Size = new System.Drawing.Size(150, 51);
            this.btnBuyPassiveDamage.TabIndex = 12;
            this.btnBuyPassiveDamage.Text = "LVL UP";
            this.btnBuyPassiveDamage.UseVisualStyleBackColor = false;
            this.btnBuyPassiveDamage.Click += new System.EventHandler(this.btnBuyPassiveDamage_Click);
            // 
            // lblDamagePerSec
            // 
            this.lblDamagePerSec.AutoSize = true;
            this.lblDamagePerSec.BackColor = System.Drawing.Color.Tan;
            this.lblDamagePerSec.Location = new System.Drawing.Point(171, 45);
            this.lblDamagePerSec.Name = "lblDamagePerSec";
            this.lblDamagePerSec.Size = new System.Drawing.Size(35, 13);
            this.lblDamagePerSec.TabIndex = 13;
            this.lblDamagePerSec.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(41, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Click damage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(41, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Passive damage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClickerHeroesOOP.Properties.Resources.wood;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 78);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDamagePerSec);
            this.Controls.Add(this.btnBuyPassiveDamage);
            this.Controls.Add(this.btnInstaGold);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.btnInstaLevel);
            this.Controls.Add(this.btnInstaKill);
            this.Controls.Add(this.btnCheats);
            this.Controls.Add(this.lblClickDamage);
            this.Controls.Add(this.btnBuyDamage);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.monsterHPlabel);
            this.Controls.Add(this.monsterHPbar);
            this.Controls.Add(this.monsterName);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OOP DU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label monsterName;
        private System.Windows.Forms.ProgressBar monsterHPbar;
        private System.Windows.Forms.Label monsterHPlabel;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Button btnBuyDamage;
        private System.Windows.Forms.Label lblClickDamage;
        private System.Windows.Forms.Button btnCheats;
        private System.Windows.Forms.Button btnInstaKill;
        private System.Windows.Forms.Button btnInstaLevel;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Button btnInstaGold;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBuyPassiveDamage;
        private System.Windows.Forms.Label lblDamagePerSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

