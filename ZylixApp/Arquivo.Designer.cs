namespace ZylixApp
{
    partial class Arquivo
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
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("000 - System Layout");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("100 - Pulse Inputs");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("200 - Pulse Outputs");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("300 - Digital Inputs");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("500 - Digital Outputs");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("900 - Analog I/O");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Config Directory", new System.Windows.Forms.TreeNode[] {
            treeNode235,
            treeNode236,
            treeNode237,
            treeNode238,
            treeNode239,
            treeNode240});
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("Security Directory");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("100 - General Purpose");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("200 - Flow Control");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("300 - Volume Accuracy");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("400 - Temperature/Density");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("500 - Pressure");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("600 - Default Alarms");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("700 - Communications");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("800 - Additives (common)");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("1600 - Board Addresses");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("System Directory", new System.Windows.Forms.TreeNode[] {
            treeNode242,
            treeNode243,
            treeNode244,
            treeNode245,
            treeNode246,
            treeNode247,
            treeNode248,
            treeNode249,
            treeNode250,
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Arm 1");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Arm 2");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Arm 3");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("Arm 4");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Arm 5");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Arm 6");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Recipe Directory");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("Markings & Notices");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 613);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 36);
            this.treeView1.Name = "treeView1";
            treeNode235.Name = "000 - System Layout";
            treeNode235.Text = "000 - System Layout";
            treeNode236.Name = "100 - Pulse Inputs";
            treeNode236.Text = "100 - Pulse Inputs";
            treeNode237.Name = "200 - Pulse Outputs";
            treeNode237.Text = "200 - Pulse Outputs";
            treeNode238.Name = "300 - Digital Inputs";
            treeNode238.Text = "300 - Digital Inputs";
            treeNode239.Name = "500 - Digital Outputs";
            treeNode239.Text = "500 - Digital Outputs";
            treeNode240.Name = "900 - Analog I/O";
            treeNode240.Text = "900 - Analog I/O";
            treeNode241.Name = "Config Directory";
            treeNode241.Text = "Config Directory";
            treeNode242.Name = "Security Directory";
            treeNode242.Text = "Security Directory";
            treeNode243.Name = "100 - General Purpose";
            treeNode243.Text = "100 - General Purpose";
            treeNode244.Name = "200 - Flow Control";
            treeNode244.Text = "200 - Flow Control";
            treeNode245.Name = "300 - Volume Accuracy";
            treeNode245.Text = "300 - Volume Accuracy";
            treeNode246.Name = "400 - Temperature/Density";
            treeNode246.Text = "400 - Temperature/Density";
            treeNode247.Name = "500 - Pressure";
            treeNode247.Text = "500 - Pressure";
            treeNode248.Name = "600 - Default Alarms";
            treeNode248.Text = "600 - Default Alarms";
            treeNode249.Name = "700 - Communications";
            treeNode249.Text = "700 - Communications";
            treeNode250.Name = "800 - Additives (common)";
            treeNode250.Text = "800 - Additives (common)";
            treeNode251.Name = "1600 - Board Addresses";
            treeNode251.Text = "1600 - Board Addresses";
            treeNode252.Name = "System Directory";
            treeNode252.Text = "System Directory";
            treeNode253.Name = "Arm 1";
            treeNode253.Text = "Arm 1";
            treeNode254.Name = "Arm 2";
            treeNode254.Text = "Arm 2";
            treeNode255.Name = "Arm 3";
            treeNode255.Text = "Arm 3";
            treeNode256.Name = "Arm 4";
            treeNode256.Text = "Arm 4";
            treeNode257.Name = "Arm 5";
            treeNode257.Text = "Arm 5";
            treeNode258.Name = "Arm 6";
            treeNode258.Text = "Arm 6";
            treeNode259.Name = "Recipe Directory";
            treeNode259.Text = "Recipe Directory";
            treeNode260.Name = "Markings & Notices";
            treeNode260.Text = "Markings & Notices";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode241,
            treeNode252,
            treeNode253,
            treeNode254,
            treeNode255,
            treeNode256,
            treeNode257,
            treeNode258,
            treeNode259,
            treeNode260});
            this.treeView1.Size = new System.Drawing.Size(377, 671);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(733, 574);
            this.textBox1.TabIndex = 0;
            // 
            // Arquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 613);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Arquivo";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Arvore_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

