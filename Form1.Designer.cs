namespace CTRPFTool
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cheatList = new System.Windows.Forms.ListBox();
            this.B_AddCheat = new System.Windows.Forms.Button();
            this.B_RemoveCheat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_32 = new System.Windows.Forms.RadioButton();
            this.RB_16 = new System.Windows.Forms.RadioButton();
            this.RB_8 = new System.Windows.Forms.RadioButton();
            this.TB_CheatValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_CheatAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_CheatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.B_OpenFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_SaveCheat = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.megaMewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rydoginatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nanquitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gBATempThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheatList
            // 
            this.cheatList.FormattingEnabled = true;
            this.cheatList.Location = new System.Drawing.Point(3, 25);
            this.cheatList.Name = "cheatList";
            this.cheatList.Size = new System.Drawing.Size(197, 199);
            this.cheatList.TabIndex = 0;
            this.cheatList.SelectedIndexChanged += new System.EventHandler(this.cheatList_SelectedIndexChanged);
            // 
            // B_AddCheat
            // 
            this.B_AddCheat.Location = new System.Drawing.Point(3, 229);
            this.B_AddCheat.Name = "B_AddCheat";
            this.B_AddCheat.Size = new System.Drawing.Size(95, 23);
            this.B_AddCheat.TabIndex = 1;
            this.B_AddCheat.Text = "Add";
            this.B_AddCheat.UseVisualStyleBackColor = true;
            this.B_AddCheat.Click += new System.EventHandler(this.B_AddCheat_Click);
            // 
            // B_RemoveCheat
            // 
            this.B_RemoveCheat.Location = new System.Drawing.Point(104, 229);
            this.B_RemoveCheat.Name = "B_RemoveCheat";
            this.B_RemoveCheat.Size = new System.Drawing.Size(96, 23);
            this.B_RemoveCheat.TabIndex = 2;
            this.B_RemoveCheat.Text = "Remove";
            this.B_RemoveCheat.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.B_OpenFile,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(420, 22);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_SaveCheat);
            this.groupBox1.Controls.Add(this.RB_32);
            this.groupBox1.Controls.Add(this.RB_16);
            this.groupBox1.Controls.Add(this.RB_8);
            this.groupBox1.Controls.Add(this.TB_CheatValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_CheatAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_CheatName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(206, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheats";
            // 
            // RB_32
            // 
            this.RB_32.AutoSize = true;
            this.RB_32.Location = new System.Drawing.Point(128, 100);
            this.RB_32.Name = "RB_32";
            this.RB_32.Size = new System.Drawing.Size(60, 17);
            this.RB_32.TabIndex = 8;
            this.RB_32.TabStop = true;
            this.RB_32.Text = "4 Bytes";
            this.RB_32.UseVisualStyleBackColor = true;
            // 
            // RB_16
            // 
            this.RB_16.AutoSize = true;
            this.RB_16.Location = new System.Drawing.Point(72, 100);
            this.RB_16.Name = "RB_16";
            this.RB_16.Size = new System.Drawing.Size(60, 17);
            this.RB_16.TabIndex = 7;
            this.RB_16.TabStop = true;
            this.RB_16.Text = "2 Bytes";
            this.RB_16.UseVisualStyleBackColor = true;
            // 
            // RB_8
            // 
            this.RB_8.AutoSize = true;
            this.RB_8.Location = new System.Drawing.Point(19, 100);
            this.RB_8.Name = "RB_8";
            this.RB_8.Size = new System.Drawing.Size(55, 17);
            this.RB_8.TabIndex = 6;
            this.RB_8.TabStop = true;
            this.RB_8.Text = "1 Byte";
            this.RB_8.UseVisualStyleBackColor = true;
            this.RB_8.CheckedChanged += new System.EventHandler(this.RB_8_CheckedChanged);
            // 
            // TB_CheatValue
            // 
            this.TB_CheatValue.Location = new System.Drawing.Point(70, 69);
            this.TB_CheatValue.Name = "TB_CheatValue";
            this.TB_CheatValue.Size = new System.Drawing.Size(100, 20);
            this.TB_CheatValue.TabIndex = 5;
            this.TB_CheatValue.TextChanged += new System.EventHandler(this.TB_CheatValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value:";
            // 
            // TB_CheatAddress
            // 
            this.TB_CheatAddress.Location = new System.Drawing.Point(70, 43);
            this.TB_CheatAddress.Name = "TB_CheatAddress";
            this.TB_CheatAddress.Size = new System.Drawing.Size(100, 20);
            this.TB_CheatAddress.TabIndex = 3;
            this.TB_CheatAddress.TextChanged += new System.EventHandler(this.TB_CheatAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_CheatName
            // 
            this.TB_CheatName.Location = new System.Drawing.Point(70, 17);
            this.TB_CheatName.Name = "TB_CheatName";
            this.TB_CheatName.Size = new System.Drawing.Size(100, 20);
            this.TB_CheatName.TabIndex = 1;
            this.TB_CheatName.TextChanged += new System.EventHandler(this.TB_CheatName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(206, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 74);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(154, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Auto load favorites at starts";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(187, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Auto load enabled cheats at starts";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Auto save favorites";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Auto save enabled cheats";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // B_OpenFile
            // 
            this.B_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.B_OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.B_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_OpenFile.Name = "B_OpenFile";
            this.B_OpenFile.Size = new System.Drawing.Size(38, 19);
            this.B_OpenFile.Text = "File";
            this.B_OpenFile.ToolTipText = "File";
            this.B_OpenFile.Click += new System.EventHandler(this.B_OpenFile_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // b_SaveCheat
            // 
            this.b_SaveCheat.Location = new System.Drawing.Point(35, 123);
            this.b_SaveCheat.Name = "b_SaveCheat";
            this.b_SaveCheat.Size = new System.Drawing.Size(135, 23);
            this.b_SaveCheat.TabIndex = 6;
            this.b_SaveCheat.Text = "Save Cheat";
            this.b_SaveCheat.UseVisualStyleBackColor = true;
            this.b_SaveCheat.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megaMewToolStripMenuItem,
            this.rydoginatorToolStripMenuItem,
            this.nanquitasToolStripMenuItem,
            this.toolStripSeparator1,
            this.gBATempThreadToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 19);
            this.toolStripButton1.Text = "About";
            this.toolStripButton1.ToolTipText = "Credits";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // megaMewToolStripMenuItem
            // 
            this.megaMewToolStripMenuItem.Name = "megaMewToolStripMenuItem";
            this.megaMewToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.megaMewToolStripMenuItem.Text = "Mega Mew";
            // 
            // rydoginatorToolStripMenuItem
            // 
            this.rydoginatorToolStripMenuItem.Name = "rydoginatorToolStripMenuItem";
            this.rydoginatorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rydoginatorToolStripMenuItem.Text = "rydoginator";
            // 
            // nanquitasToolStripMenuItem
            // 
            this.nanquitasToolStripMenuItem.Name = "nanquitasToolStripMenuItem";
            this.nanquitasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nanquitasToolStripMenuItem.Text = "Nanquitas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // gBATempThreadToolStripMenuItem
            // 
            this.gBATempThreadToolStripMenuItem.Name = "gBATempThreadToolStripMenuItem";
            this.gBATempThreadToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gBATempThreadToolStripMenuItem.Text = "GBATemp Thread";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 295);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.B_RemoveCheat);
            this.Controls.Add(this.B_AddCheat);
            this.Controls.Add(this.cheatList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CTRPF Data Tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cheatList;
        private System.Windows.Forms.Button B_AddCheat;
        private System.Windows.Forms.Button B_RemoveCheat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_CheatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_CheatAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_CheatValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_32;
        private System.Windows.Forms.RadioButton RB_16;
        private System.Windows.Forms.RadioButton RB_8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolStripDropDownButton B_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.Button b_SaveCheat;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem megaMewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rydoginatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nanquitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gBATempThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
    }
}

