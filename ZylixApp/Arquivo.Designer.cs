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
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("000 - System Layout");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("100 - Pulse Inputs");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("200 - Pulse Outputs");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("300 - Digital Inputs");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("500 - Digital Outputs");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("900 - Analog I/O");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Config Directory", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Security Directory");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("100 - General Purpose");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("200 - Flow Control");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("300 - Volume Accuracy");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("400 - Temperature/Density");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("500 - Pressure");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("600 - Default Alarms");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("700 - Communications");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("800 - Additives (common)");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("1600 - Board Addresses");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("System Directory", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Arm 1");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Arm 2");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Arm 3");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Arm 4");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Arm 5");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Arm 6");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Recipe Directory");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Markings & Notices");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.janelaToolStripMenuItem});
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 36);
            this.treeView1.Name = "treeView1";
            treeNode27.Name = "000 - System Layout";
            treeNode27.Text = "000 - System Layout";
            treeNode28.Name = "100 - Pulse Inputs";
            treeNode28.Text = "100 - Pulse Inputs";
            treeNode29.Name = "200 - Pulse Outputs";
            treeNode29.Text = "200 - Pulse Outputs";
            treeNode30.Name = "300 - Digital Inputs";
            treeNode30.Text = "300 - Digital Inputs";
            treeNode31.Name = "500 - Digital Outputs";
            treeNode31.Text = "500 - Digital Outputs";
            treeNode32.Name = "900 - Analog I/O";
            treeNode32.Text = "900 - Analog I/O";
            treeNode33.Name = "Config Directory";
            treeNode33.Text = "Config Directory";
            treeNode34.Name = "Security Directory";
            treeNode34.Text = "Security Directory";
            treeNode35.Name = "100 - General Purpose";
            treeNode35.Text = "100 - General Purpose";
            treeNode36.Name = "200 - Flow Control";
            treeNode36.Text = "200 - Flow Control";
            treeNode37.Name = "300 - Volume Accuracy";
            treeNode37.Text = "300 - Volume Accuracy";
            treeNode38.Name = "400 - Temperature/Density";
            treeNode38.Text = "400 - Temperature/Density";
            treeNode39.Name = "500 - Pressure";
            treeNode39.Text = "500 - Pressure";
            treeNode40.Name = "600 - Default Alarms";
            treeNode40.Text = "600 - Default Alarms";
            treeNode41.Name = "700 - Communications";
            treeNode41.Text = "700 - Communications";
            treeNode42.Name = "800 - Additives (common)";
            treeNode42.Text = "800 - Additives (common)";
            treeNode43.Name = "1600 - Board Addresses";
            treeNode43.Text = "1600 - Board Addresses";
            treeNode44.Name = "System Directory";
            treeNode44.Text = "System Directory";
            treeNode45.Name = "Arm 1";
            treeNode45.Text = "Arm 1";
            treeNode46.Name = "Arm 2";
            treeNode46.Text = "Arm 2";
            treeNode47.Name = "Arm 3";
            treeNode47.Text = "Arm 3";
            treeNode48.Name = "Arm 4";
            treeNode48.Text = "Arm 4";
            treeNode49.Name = "Arm 5";
            treeNode49.Text = "Arm 5";
            treeNode50.Name = "Arm 6";
            treeNode50.Text = "Arm 6";
            treeNode51.Name = "Recipe Directory";
            treeNode51.Text = "Recipe Directory";
            treeNode52.Name = "Markings & Notices";
            treeNode52.Text = "Markings & Notices";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52});
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
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.janelaToolStripMenuItem.Text = "Janela";
            this.janelaToolStripMenuItem.Click += new System.EventHandler(this.janelaToolStripMenuItem_Click);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
    }
}

