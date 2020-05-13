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
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("000 - System Layout");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("100 - Pulse Inputs");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("200 - Pulse Outputs");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("300 - Digital Inputs");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("500 - Digital Outputs");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("900 - Analog I/O");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Config Directory", new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Security Directory");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("100 - General Purpose");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("200 - Flow Control");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("300 - Volume Accuracy");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("400 - Temperature/Density");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("500 - Pressure");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("600 - Default Alarms");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("700 - Communications");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("800 - Additives (common)");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("1600 - Board Addresses");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("System Directory", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Arm 1");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Arm 2");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Arm 3");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Arm 4");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Arm 5");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Arm 6");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Recipe Directory");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Markings & Notices");
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\gusta\\Desktop";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
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
            treeNode79.Name = "000 - System Layout";
            treeNode79.Text = "000 - System Layout";
            treeNode80.Name = "100 - Pulse Inputs";
            treeNode80.Text = "100 - Pulse Inputs";
            treeNode81.Name = "200 - Pulse Outputs";
            treeNode81.Text = "200 - Pulse Outputs";
            treeNode82.Name = "300 - Digital Inputs";
            treeNode82.Text = "300 - Digital Inputs";
            treeNode83.Name = "500 - Digital Outputs";
            treeNode83.Text = "500 - Digital Outputs";
            treeNode84.Name = "900 - Analog I/O";
            treeNode84.Text = "900 - Analog I/O";
            treeNode85.Name = "Config Directory";
            treeNode85.Text = "Config Directory";
            treeNode86.Name = "Security Directory";
            treeNode86.Text = "Security Directory";
            treeNode87.Name = "100 - General Purpose";
            treeNode87.Text = "100 - General Purpose";
            treeNode88.Name = "200 - Flow Control";
            treeNode88.Text = "200 - Flow Control";
            treeNode89.Name = "300 - Volume Accuracy";
            treeNode89.Text = "300 - Volume Accuracy";
            treeNode90.Name = "400 - Temperature/Density";
            treeNode90.Text = "400 - Temperature/Density";
            treeNode91.Name = "500 - Pressure";
            treeNode91.Text = "500 - Pressure";
            treeNode92.Name = "600 - Default Alarms";
            treeNode92.Text = "600 - Default Alarms";
            treeNode93.Name = "700 - Communications";
            treeNode93.Text = "700 - Communications";
            treeNode94.Name = "800 - Additives (common)";
            treeNode94.Text = "800 - Additives (common)";
            treeNode95.Name = "1600 - Board Addresses";
            treeNode95.Text = "1600 - Board Addresses";
            treeNode96.Name = "System Directory";
            treeNode96.Text = "System Directory";
            treeNode97.Name = "Arm 1";
            treeNode97.Text = "Arm 1";
            treeNode98.Name = "Arm 2";
            treeNode98.Text = "Arm 2";
            treeNode99.Name = "Arm 3";
            treeNode99.Text = "Arm 3";
            treeNode100.Name = "Arm 4";
            treeNode100.Text = "Arm 4";
            treeNode101.Name = "Arm 5";
            treeNode101.Text = "Arm 5";
            treeNode102.Name = "Arm 6";
            treeNode102.Text = "Arm 6";
            treeNode103.Name = "Recipe Directory";
            treeNode103.Text = "Recipe Directory";
            treeNode104.Name = "Markings & Notices";
            treeNode104.Text = "Markings & Notices";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode96,
            treeNode97,
            treeNode98,
            treeNode99,
            treeNode100,
            treeNode101,
            treeNode102,
            treeNode103,
            treeNode104});
            this.treeView1.Size = new System.Drawing.Size(377, 671);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
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
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.abrirToolStripMenuItem.Text = "Abrir";
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
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

