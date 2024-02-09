namespace Bunker
{
    partial class BunkerForm
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
            components = new System.ComponentModel.Container();
            lSexName = new Label();
            lAgeName = new Label();
            lRaceName = new Label();
            lProfessionName = new Label();
            lHobbyName = new Label();
            lWeaknessName = new Label();
            lBagName = new Label();
            lHealthName = new Label();
            lbEventsHappened = new ListBox();
            label10 = new Label();
            bSkill1 = new Button();
            bSkill2 = new Button();
            tbWorld = new TextBox();
            lSkill1 = new Label();
            lSkill2 = new Label();
            lNicknameName = new Label();
            lNickname = new Label();
            lSex = new Label();
            lAge = new Label();
            lRace = new Label();
            lHealth = new Label();
            lProfession = new Label();
            lHobby = new Label();
            lWeakness = new Label();
            lBag = new Label();
            worker_readasync = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lSexName
            // 
            lSexName.AutoSize = true;
            lSexName.Location = new Point(66, 30);
            lSexName.Name = "lSexName";
            lSexName.Size = new Size(41, 21);
            lSexName.TabIndex = 0;
            lSexName.Text = "Пол:";
            // 
            // lAgeName
            // 
            lAgeName.AutoSize = true;
            lAgeName.Location = new Point(38, 51);
            lAgeName.Name = "lAgeName";
            lAgeName.Size = new Size(69, 21);
            lAgeName.TabIndex = 0;
            lAgeName.Text = "Возраст:";
            // 
            // lRaceName
            // 
            lRaceName.AutoSize = true;
            lRaceName.Location = new Point(62, 72);
            lRaceName.Name = "lRaceName";
            lRaceName.Size = new Size(45, 21);
            lRaceName.TabIndex = 0;
            lRaceName.Text = "Раса:";
            // 
            // lProfessionName
            // 
            lProfessionName.AutoSize = true;
            lProfessionName.Location = new Point(15, 114);
            lProfessionName.Name = "lProfessionName";
            lProfessionName.Size = new Size(92, 21);
            lProfessionName.TabIndex = 0;
            lProfessionName.Text = "Профессия:";
            // 
            // lHobbyName
            // 
            lHobbyName.AutoSize = true;
            lHobbyName.Location = new Point(49, 135);
            lHobbyName.Name = "lHobbyName";
            lHobbyName.Size = new Size(58, 21);
            lHobbyName.TabIndex = 0;
            lHobbyName.Text = "Хобби:";
            // 
            // lWeaknessName
            // 
            lWeaknessName.AutoSize = true;
            lWeaknessName.Location = new Point(28, 156);
            lWeaknessName.Name = "lWeaknessName";
            lWeaknessName.Size = new Size(79, 21);
            lWeaknessName.TabIndex = 0;
            lWeaknessName.Text = "Слабость:";
            // 
            // lBagName
            // 
            lBagName.AutoSize = true;
            lBagName.Location = new Point(51, 177);
            lBagName.Name = "lBagName";
            lBagName.Size = new Size(56, 21);
            lBagName.TabIndex = 0;
            lBagName.Text = "Багаж:";
            // 
            // lHealthName
            // 
            lHealthName.AutoSize = true;
            lHealthName.Location = new Point(25, 93);
            lHealthName.Name = "lHealthName";
            lHealthName.Size = new Size(82, 21);
            lHealthName.TabIndex = 0;
            lHealthName.Text = "Здоровье:";
            // 
            // lbEventsHappened
            // 
            lbEventsHappened.FormattingEnabled = true;
            lbEventsHappened.HorizontalScrollbar = true;
            lbEventsHappened.ItemHeight = 21;
            lbEventsHappened.Location = new Point(12, 264);
            lbEventsHappened.Name = "lbEventsHappened";
            lbEventsHappened.Size = new Size(268, 277);
            lbEventsHappened.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 240);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 2;
            label10.Text = "События:";
            // 
            // bSkill1
            // 
            bSkill1.Location = new Point(485, 12);
            bSkill1.Name = "bSkill1";
            bSkill1.Size = new Size(83, 46);
            bSkill1.TabIndex = 3;
            bSkill1.Text = "Карта 1";
            bSkill1.UseVisualStyleBackColor = true;
            // 
            // bSkill2
            // 
            bSkill2.Location = new Point(485, 125);
            bSkill2.Name = "bSkill2";
            bSkill2.Size = new Size(83, 46);
            bSkill2.TabIndex = 3;
            bSkill2.Text = "Карта 2";
            bSkill2.UseVisualStyleBackColor = true;
            // 
            // tbWorld
            // 
            tbWorld.BackColor = SystemColors.Window;
            tbWorld.Location = new Point(485, 264);
            tbWorld.Multiline = true;
            tbWorld.Name = "tbWorld";
            tbWorld.ReadOnly = true;
            tbWorld.ScrollBars = ScrollBars.Both;
            tbWorld.Size = new Size(509, 277);
            tbWorld.TabIndex = 4;
            tbWorld.Text = "--- Информация ---";
            tbWorld.TextAlign = HorizontalAlignment.Center;
            // 
            // lSkill1
            // 
            lSkill1.AutoSize = true;
            lSkill1.Location = new Point(574, 12);
            lSkill1.Name = "lSkill1";
            lSkill1.Size = new Size(81, 21);
            lSkill1.TabIndex = 5;
            lSkill1.Text = "Описание";
            // 
            // lSkill2
            // 
            lSkill2.AutoSize = true;
            lSkill2.Location = new Point(574, 125);
            lSkill2.Name = "lSkill2";
            lSkill2.Size = new Size(81, 21);
            lSkill2.TabIndex = 6;
            lSkill2.Text = "Описание";
            // 
            // lNicknameName
            // 
            lNicknameName.AutoSize = true;
            lNicknameName.Location = new Point(63, 9);
            lNicknameName.Name = "lNicknameName";
            lNicknameName.Size = new Size(44, 21);
            lNicknameName.TabIndex = 0;
            lNicknameName.Text = "Имя:";
            // 
            // lNickname
            // 
            lNickname.AutoSize = true;
            lNickname.Location = new Point(113, 9);
            lNickname.Name = "lNickname";
            lNickname.Size = new Size(48, 21);
            lNickname.TabIndex = 0;
            lNickname.Text = "None";
            // 
            // lSex
            // 
            lSex.AutoSize = true;
            lSex.Location = new Point(113, 30);
            lSex.Name = "lSex";
            lSex.Size = new Size(48, 21);
            lSex.TabIndex = 0;
            lSex.Text = "None";
            // 
            // lAge
            // 
            lAge.AutoSize = true;
            lAge.Location = new Point(113, 51);
            lAge.Name = "lAge";
            lAge.Size = new Size(48, 21);
            lAge.TabIndex = 0;
            lAge.Text = "None";
            // 
            // lRace
            // 
            lRace.AutoSize = true;
            lRace.Location = new Point(113, 72);
            lRace.Name = "lRace";
            lRace.Size = new Size(48, 21);
            lRace.TabIndex = 0;
            lRace.Text = "None";
            // 
            // lHealth
            // 
            lHealth.AutoSize = true;
            lHealth.Location = new Point(113, 93);
            lHealth.Name = "lHealth";
            lHealth.Size = new Size(48, 21);
            lHealth.TabIndex = 0;
            lHealth.Text = "None";
            // 
            // lProfession
            // 
            lProfession.AutoSize = true;
            lProfession.Location = new Point(113, 114);
            lProfession.Name = "lProfession";
            lProfession.Size = new Size(48, 21);
            lProfession.TabIndex = 0;
            lProfession.Text = "None";
            // 
            // lHobby
            // 
            lHobby.AutoSize = true;
            lHobby.Location = new Point(113, 135);
            lHobby.Name = "lHobby";
            lHobby.Size = new Size(48, 21);
            lHobby.TabIndex = 0;
            lHobby.Text = "None";
            // 
            // lWeakness
            // 
            lWeakness.AutoSize = true;
            lWeakness.Location = new Point(113, 156);
            lWeakness.Name = "lWeakness";
            lWeakness.Size = new Size(48, 21);
            lWeakness.TabIndex = 0;
            lWeakness.Text = "None";
            // 
            // lBag
            // 
            lBag.AutoSize = true;
            lBag.Location = new Point(113, 177);
            lBag.Name = "lBag";
            lBag.Size = new Size(48, 21);
            lBag.TabIndex = 0;
            lBag.Text = "None";
            // 
            // worker_readasync
            // 
            worker_readasync.Enabled = true;
            worker_readasync.Interval = 50;
            worker_readasync.Tick += worker_readasync_Tick;
            // 
            // BunkerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 558);
            Controls.Add(lSkill2);
            Controls.Add(lSkill1);
            Controls.Add(tbWorld);
            Controls.Add(bSkill2);
            Controls.Add(bSkill1);
            Controls.Add(label10);
            Controls.Add(lbEventsHappened);
            Controls.Add(lHealthName);
            Controls.Add(lBagName);
            Controls.Add(lWeaknessName);
            Controls.Add(lHobbyName);
            Controls.Add(lProfessionName);
            Controls.Add(lRaceName);
            Controls.Add(lAgeName);
            Controls.Add(lBag);
            Controls.Add(lWeakness);
            Controls.Add(lHobby);
            Controls.Add(lProfession);
            Controls.Add(lHealth);
            Controls.Add(lRace);
            Controls.Add(lAge);
            Controls.Add(lSex);
            Controls.Add(lNickname);
            Controls.Add(lNicknameName);
            Controls.Add(lSexName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "BunkerForm";
            Text = "Bunker";
            FormClosed += BunkerForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lSexName;
        private Label lAgeName;
        private Label lRaceName;
        private Label lProfessionName;
        private Label lHobbyName;
        private Label lWeaknessName;
        private Label lBagName;
        private Label lHealthName;
        private ListBox lbEventsHappened;
        private Label label10;
        private Button bSkill1;
        private Button bSkill2;
        private TextBox tbWorld;
        private Label lSkill1;
        private Label lSkill2;
        private Label lNicknameName;
        private Label lNickname;
        private Label lSex;
        private Label lAge;
        private Label lRace;
        private Label lHealth;
        private Label lProfession;
        private Label lHobby;
        private Label lWeakness;
        private Label lBag;
        private System.Windows.Forms.Timer worker_readasync;
    }
}