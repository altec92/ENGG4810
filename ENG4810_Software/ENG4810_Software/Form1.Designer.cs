namespace ENG4810_Software
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dbRange = new Zzzz.ZzzzRangeBar();
            this.lumRange = new Zzzz.ZzzzRangeBar();
            this.magRange = new Zzzz.ZzzzRangeBar();
            this.uvRange = new Zzzz.ZzzzRangeBar();
            this.presRange = new Zzzz.ZzzzRangeBar();
            this.humRange = new Zzzz.ZzzzRangeBar();
            this.gForceRange = new Zzzz.ZzzzRangeBar();
            this.tempRange = new Zzzz.ZzzzRangeBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomMin_B = new System.Windows.Forms.Button();
            this.zoomPlu_B = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tempR_Max = new System.Windows.Forms.Label();
            this.tempR_Min = new System.Windows.Forms.Label();
            this.gRang_Max = new System.Windows.Forms.Label();
            this.gRang_Min = new System.Windows.Forms.Label();
            this.humRang_Max = new System.Windows.Forms.Label();
            this.humRang_Min = new System.Windows.Forms.Label();
            this.PresRange_Max = new System.Windows.Forms.Label();
            this.PresRange_Min = new System.Windows.Forms.Label();
            this.uvRange_Max = new System.Windows.Forms.Label();
            this.uvRange_Min = new System.Windows.Forms.Label();
            this.magRang_Max = new System.Windows.Forms.Label();
            this.magRang_Min = new System.Windows.Forms.Label();
            this.lumRang_Max = new System.Windows.Forms.Label();
            this.lumRang_Min = new System.Windows.Forms.Label();
            this.dbRang_Max = new System.Windows.Forms.Label();
            this.dbRange_Max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dbRange_Max);
            this.splitContainer1.Panel1.Controls.Add(this.dbRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.lumRang_Min);
            this.splitContainer1.Panel1.Controls.Add(this.lumRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.magRang_Min);
            this.splitContainer1.Panel1.Controls.Add(this.magRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.uvRange_Min);
            this.splitContainer1.Panel1.Controls.Add(this.uvRange_Max);
            this.splitContainer1.Panel1.Controls.Add(this.PresRange_Min);
            this.splitContainer1.Panel1.Controls.Add(this.PresRange_Max);
            this.splitContainer1.Panel1.Controls.Add(this.humRang_Min);
            this.splitContainer1.Panel1.Controls.Add(this.humRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.gRang_Min);
            this.splitContainer1.Panel1.Controls.Add(this.gRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.tempR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.tempR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.dbRange);
            this.splitContainer1.Panel1.Controls.Add(this.lumRange);
            this.splitContainer1.Panel1.Controls.Add(this.magRange);
            this.splitContainer1.Panel1.Controls.Add(this.uvRange);
            this.splitContainer1.Panel1.Controls.Add(this.presRange);
            this.splitContainer1.Panel1.Controls.Add(this.humRange);
            this.splitContainer1.Panel1.Controls.Add(this.gForceRange);
            this.splitContainer1.Panel1.Controls.Add(this.tempRange);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.zoomMin_B);
            this.splitContainer1.Panel2.Controls.Add(this.zoomPlu_B);
            this.splitContainer1.Panel2.Controls.Add(this.gmap);
            this.splitContainer1.Size = new System.Drawing.Size(1142, 513);
            this.splitContainer1.SplitterDistance = 647;
            this.splitContainer1.TabIndex = 0;
            // 
            // dbRange
            // 
            this.dbRange.AutoSize = true;
            this.dbRange.DivisionNum = 10;
            this.dbRange.HeightOfBar = 10;
            this.dbRange.HeightOfMark = 20;
            this.dbRange.HeightOfTick = 1;
            this.dbRange.InnerColor = System.Drawing.Color.White;
            this.dbRange.Location = new System.Drawing.Point(577, 31);
            this.dbRange.Name = "dbRange";
            this.dbRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.dbRange.RangeMaximum = 5;
            this.dbRange.RangeMinimum = 3;
            this.dbRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.dbRange.Size = new System.Drawing.Size(37, 431);
            this.dbRange.TabIndex = 17;
            this.dbRange.TotalMaximum = 10;
            this.dbRange.TotalMinimum = 0;
            // 
            // lumRange
            // 
            this.lumRange.AutoSize = true;
            this.lumRange.DivisionNum = 10;
            this.lumRange.HeightOfBar = 10;
            this.lumRange.HeightOfMark = 20;
            this.lumRange.HeightOfTick = 1;
            this.lumRange.InnerColor = System.Drawing.Color.Yellow;
            this.lumRange.Location = new System.Drawing.Point(495, 31);
            this.lumRange.Name = "lumRange";
            this.lumRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.lumRange.RangeMaximum = 5;
            this.lumRange.RangeMinimum = 3;
            this.lumRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.lumRange.Size = new System.Drawing.Size(37, 431);
            this.lumRange.TabIndex = 16;
            this.lumRange.TotalMaximum = 10;
            this.lumRange.TotalMinimum = 0;
            // 
            // magRange
            // 
            this.magRange.AutoSize = true;
            this.magRange.DivisionNum = 10;
            this.magRange.HeightOfBar = 10;
            this.magRange.HeightOfMark = 20;
            this.magRange.HeightOfTick = 1;
            this.magRange.InnerColor = System.Drawing.Color.DeepPink;
            this.magRange.Location = new System.Drawing.Point(413, 31);
            this.magRange.Name = "magRange";
            this.magRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.magRange.RangeMaximum = 5;
            this.magRange.RangeMinimum = 3;
            this.magRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.magRange.Size = new System.Drawing.Size(37, 431);
            this.magRange.TabIndex = 15;
            this.magRange.TotalMaximum = 10;
            this.magRange.TotalMinimum = 0;
            // 
            // uvRange
            // 
            this.uvRange.AutoSize = true;
            this.uvRange.DivisionNum = 10;
            this.uvRange.HeightOfBar = 10;
            this.uvRange.HeightOfMark = 20;
            this.uvRange.HeightOfTick = 1;
            this.uvRange.InnerColor = System.Drawing.Color.DarkViolet;
            this.uvRange.Location = new System.Drawing.Point(331, 31);
            this.uvRange.Name = "uvRange";
            this.uvRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.uvRange.RangeMaximum = 5;
            this.uvRange.RangeMinimum = 3;
            this.uvRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.uvRange.Size = new System.Drawing.Size(37, 431);
            this.uvRange.TabIndex = 14;
            this.uvRange.TotalMaximum = 10;
            this.uvRange.TotalMinimum = 0;
            // 
            // presRange
            // 
            this.presRange.AutoSize = true;
            this.presRange.DivisionNum = 10;
            this.presRange.HeightOfBar = 10;
            this.presRange.HeightOfMark = 20;
            this.presRange.HeightOfTick = 1;
            this.presRange.InnerColor = System.Drawing.Color.Lime;
            this.presRange.Location = new System.Drawing.Point(249, 31);
            this.presRange.Name = "presRange";
            this.presRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.presRange.RangeMaximum = 5;
            this.presRange.RangeMinimum = 3;
            this.presRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.presRange.Size = new System.Drawing.Size(37, 431);
            this.presRange.TabIndex = 13;
            this.presRange.TotalMaximum = 10;
            this.presRange.TotalMinimum = 0;
            // 
            // humRange
            // 
            this.humRange.AutoSize = true;
            this.humRange.DivisionNum = 10;
            this.humRange.HeightOfBar = 10;
            this.humRange.HeightOfMark = 20;
            this.humRange.HeightOfTick = 1;
            this.humRange.InnerColor = System.Drawing.Color.DeepSkyBlue;
            this.humRange.Location = new System.Drawing.Point(167, 31);
            this.humRange.Name = "humRange";
            this.humRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.humRange.RangeMaximum = 5;
            this.humRange.RangeMinimum = 3;
            this.humRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.humRange.Size = new System.Drawing.Size(37, 431);
            this.humRange.TabIndex = 12;
            this.humRange.TotalMaximum = 10;
            this.humRange.TotalMinimum = 0;
            // 
            // gForceRange
            // 
            this.gForceRange.AutoSize = true;
            this.gForceRange.DivisionNum = 10;
            this.gForceRange.HeightOfBar = 10;
            this.gForceRange.HeightOfMark = 20;
            this.gForceRange.HeightOfTick = 1;
            this.gForceRange.InnerColor = System.Drawing.SystemColors.MenuText;
            this.gForceRange.Location = new System.Drawing.Point(85, 31);
            this.gForceRange.Name = "gForceRange";
            this.gForceRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.gForceRange.RangeMaximum = 5;
            this.gForceRange.RangeMinimum = 3;
            this.gForceRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.gForceRange.Size = new System.Drawing.Size(37, 431);
            this.gForceRange.TabIndex = 11;
            this.gForceRange.TotalMaximum = 10;
            this.gForceRange.TotalMinimum = 0;
            // 
            // tempRange
            // 
            this.tempRange.AutoSize = true;
            this.tempRange.DivisionNum = 10;
            this.tempRange.HeightOfBar = 10;
            this.tempRange.HeightOfMark = 20;
            this.tempRange.HeightOfTick = 1;
            this.tempRange.InnerColor = System.Drawing.Color.Red;
            this.tempRange.Location = new System.Drawing.Point(3, 31);
            this.tempRange.Name = "tempRange";
            this.tempRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.vertical;
            this.tempRange.RangeMaximum = 5;
            this.tempRange.RangeMinimum = 3;
            this.tempRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.tempRange.Size = new System.Drawing.Size(37, 431);
            this.tempRange.TabIndex = 10;
            this.tempRange.TotalMaximum = 10;
            this.tempRange.TotalMinimum = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFile
            // 
            this.openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(167, 24);
            this.openFile.Text = "&Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // zoomMin_B
            // 
            this.zoomMin_B.BackColor = System.Drawing.Color.Transparent;
            this.zoomMin_B.Location = new System.Drawing.Point(3, 3);
            this.zoomMin_B.Name = "zoomMin_B";
            this.zoomMin_B.Size = new System.Drawing.Size(26, 27);
            this.zoomMin_B.TabIndex = 5;
            this.zoomMin_B.Text = "\\u002d";
            this.zoomMin_B.UseVisualStyleBackColor = false;
            this.zoomMin_B.Click += new System.EventHandler(this.zoomMin_B_Click);
            // 
            // zoomPlu_B
            // 
            this.zoomPlu_B.AutoSize = true;
            this.zoomPlu_B.BackColor = System.Drawing.Color.Transparent;
            this.zoomPlu_B.Location = new System.Drawing.Point(35, 3);
            this.zoomPlu_B.Name = "zoomPlu_B";
            this.zoomPlu_B.Size = new System.Drawing.Size(26, 27);
            this.zoomPlu_B.TabIndex = 3;
            this.zoomPlu_B.Text = "+";
            this.zoomPlu_B.UseVisualStyleBackColor = false;
            this.zoomPlu_B.Click += new System.EventHandler(this.zoomPlu_B_Click);
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.AutoSize = true;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.GrayScaleMode = false;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(3, 3);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 0;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(492, 510);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 5D;
            // 
            // tempR_Max
            // 
            this.tempR_Max.AutoSize = true;
            this.tempR_Max.Location = new System.Drawing.Point(33, 31);
            this.tempR_Max.Name = "tempR_Max";
            this.tempR_Max.Size = new System.Drawing.Size(46, 17);
            this.tempR_Max.TabIndex = 19;
            this.tempR_Max.Text = "label2";
            // 
            // tempR_Min
            // 
            this.tempR_Min.AutoSize = true;
            this.tempR_Min.Location = new System.Drawing.Point(33, 445);
            this.tempR_Min.Name = "tempR_Min";
            this.tempR_Min.Size = new System.Drawing.Size(46, 17);
            this.tempR_Min.TabIndex = 20;
            this.tempR_Min.Text = "label3";
            // 
            // gRang_Max
            // 
            this.gRang_Max.AutoSize = true;
            this.gRang_Max.Location = new System.Drawing.Point(115, 31);
            this.gRang_Max.Name = "gRang_Max";
            this.gRang_Max.Size = new System.Drawing.Size(46, 17);
            this.gRang_Max.TabIndex = 21;
            this.gRang_Max.Text = "label4";
            // 
            // gRang_Min
            // 
            this.gRang_Min.AutoSize = true;
            this.gRang_Min.Location = new System.Drawing.Point(118, 444);
            this.gRang_Min.Name = "gRang_Min";
            this.gRang_Min.Size = new System.Drawing.Size(46, 17);
            this.gRang_Min.TabIndex = 22;
            this.gRang_Min.Text = "label5";
            // 
            // humRang_Max
            // 
            this.humRang_Max.AutoSize = true;
            this.humRang_Max.Location = new System.Drawing.Point(197, 31);
            this.humRang_Max.Name = "humRang_Max";
            this.humRang_Max.Size = new System.Drawing.Size(46, 17);
            this.humRang_Max.TabIndex = 23;
            this.humRang_Max.Text = "label6";
            // 
            // humRang_Min
            // 
            this.humRang_Min.AutoSize = true;
            this.humRang_Min.Location = new System.Drawing.Point(200, 444);
            this.humRang_Min.Name = "humRang_Min";
            this.humRang_Min.Size = new System.Drawing.Size(46, 17);
            this.humRang_Min.TabIndex = 24;
            this.humRang_Min.Text = "label7";
            // 
            // PresRange_Max
            // 
            this.PresRange_Max.AutoSize = true;
            this.PresRange_Max.Location = new System.Drawing.Point(279, 31);
            this.PresRange_Max.Name = "PresRange_Max";
            this.PresRange_Max.Size = new System.Drawing.Size(46, 17);
            this.PresRange_Max.TabIndex = 25;
            this.PresRange_Max.Text = "label8";
            // 
            // PresRange_Min
            // 
            this.PresRange_Min.AutoSize = true;
            this.PresRange_Min.Location = new System.Drawing.Point(279, 445);
            this.PresRange_Min.Name = "PresRange_Min";
            this.PresRange_Min.Size = new System.Drawing.Size(46, 17);
            this.PresRange_Min.TabIndex = 26;
            this.PresRange_Min.Text = "label9";
            // 
            // uvRange_Max
            // 
            this.uvRange_Max.AutoSize = true;
            this.uvRange_Max.Location = new System.Drawing.Point(363, 31);
            this.uvRange_Max.Name = "uvRange_Max";
            this.uvRange_Max.Size = new System.Drawing.Size(54, 17);
            this.uvRange_Max.TabIndex = 27;
            this.uvRange_Max.Text = "label10";
            // 
            // uvRange_Min
            // 
            this.uvRange_Min.AutoSize = true;
            this.uvRange_Min.Location = new System.Drawing.Point(363, 444);
            this.uvRange_Min.Name = "uvRange_Min";
            this.uvRange_Min.Size = new System.Drawing.Size(54, 17);
            this.uvRange_Min.TabIndex = 28;
            this.uvRange_Min.Text = "label11";
            // 
            // magRang_Max
            // 
            this.magRang_Max.AutoSize = true;
            this.magRang_Max.Location = new System.Drawing.Point(444, 31);
            this.magRang_Max.Name = "magRang_Max";
            this.magRang_Max.Size = new System.Drawing.Size(54, 17);
            this.magRang_Max.TabIndex = 29;
            this.magRang_Max.Text = "label12";
            // 
            // magRang_Min
            // 
            this.magRang_Min.AutoSize = true;
            this.magRang_Min.Location = new System.Drawing.Point(447, 444);
            this.magRang_Min.Name = "magRang_Min";
            this.magRang_Min.Size = new System.Drawing.Size(54, 17);
            this.magRang_Min.TabIndex = 30;
            this.magRang_Min.Text = "label13";
            // 
            // lumRang_Max
            // 
            this.lumRang_Max.AutoSize = true;
            this.lumRang_Max.Location = new System.Drawing.Point(527, 31);
            this.lumRang_Max.Name = "lumRang_Max";
            this.lumRang_Max.Size = new System.Drawing.Size(54, 17);
            this.lumRang_Max.TabIndex = 31;
            this.lumRang_Max.Text = "label14";
            // 
            // lumRang_Min
            // 
            this.lumRang_Min.AutoSize = true;
            this.lumRang_Min.Location = new System.Drawing.Point(530, 444);
            this.lumRang_Min.Name = "lumRang_Min";
            this.lumRang_Min.Size = new System.Drawing.Size(54, 17);
            this.lumRang_Min.TabIndex = 32;
            this.lumRang_Min.Text = "label15";
            // 
            // dbRang_Max
            // 
            this.dbRang_Max.AutoSize = true;
            this.dbRang_Max.Location = new System.Drawing.Point(608, 32);
            this.dbRang_Max.Name = "dbRang_Max";
            this.dbRang_Max.Size = new System.Drawing.Size(54, 17);
            this.dbRang_Max.TabIndex = 33;
            this.dbRang_Max.Text = "label16";
            // 
            // dbRange_Max
            // 
            this.dbRange_Max.AutoSize = true;
            this.dbRange_Max.Location = new System.Drawing.Point(611, 444);
            this.dbRange_Max.Name = "dbRange_Max";
            this.dbRange_Max.Size = new System.Drawing.Size(54, 17);
            this.dbRange_Max.TabIndex = 34;
            this.dbRange_Max.Text = "label17";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1142, 513);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "Form1";
            this.Text = "Route Tracker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button zoomPlu_B;
        private System.Windows.Forms.Button zoomMin_B;
        private Zzzz.ZzzzRangeBar tempRange;
        private Zzzz.ZzzzRangeBar humRange;
        private Zzzz.ZzzzRangeBar gForceRange;
        private Zzzz.ZzzzRangeBar lumRange;
        private Zzzz.ZzzzRangeBar magRange;
        private Zzzz.ZzzzRangeBar uvRange;
        private Zzzz.ZzzzRangeBar presRange;
        private Zzzz.ZzzzRangeBar dbRange;
        private System.Windows.Forms.Label dbRange_Max;
        private System.Windows.Forms.Label dbRang_Max;
        private System.Windows.Forms.Label lumRang_Min;
        private System.Windows.Forms.Label lumRang_Max;
        private System.Windows.Forms.Label magRang_Min;
        private System.Windows.Forms.Label magRang_Max;
        private System.Windows.Forms.Label uvRange_Min;
        private System.Windows.Forms.Label uvRange_Max;
        private System.Windows.Forms.Label PresRange_Min;
        private System.Windows.Forms.Label PresRange_Max;
        private System.Windows.Forms.Label humRang_Min;
        private System.Windows.Forms.Label humRang_Max;
        private System.Windows.Forms.Label gRang_Min;
        private System.Windows.Forms.Label gRang_Max;
        private System.Windows.Forms.Label tempR_Min;
        private System.Windows.Forms.Label tempR_Max;
        
    }
}

