﻿namespace ENG4810_Software
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
            this.lumR_Max = new System.Windows.Forms.TextBox();
            this.lumR_Min = new System.Windows.Forms.TextBox();
            this.dbaR_Max = new System.Windows.Forms.TextBox();
            this.dbaR_Min = new System.Windows.Forms.TextBox();
            this.magR_Max = new System.Windows.Forms.TextBox();
            this.gRang_Max = new System.Windows.Forms.TextBox();
            this.magR_Min = new System.Windows.Forms.TextBox();
            this.uvR_Max = new System.Windows.Forms.TextBox();
            this.uvR_Min = new System.Windows.Forms.TextBox();
            this.presR_Max = new System.Windows.Forms.TextBox();
            this.presR_Min = new System.Windows.Forms.TextBox();
            this.humR_Max = new System.Windows.Forms.TextBox();
            this.humR_Min = new System.Windows.Forms.TextBox();
            this.gRang_Min = new System.Windows.Forms.TextBox();
            this.tempR_Max = new System.Windows.Forms.TextBox();
            this.tempR_Min = new System.Windows.Forms.TextBox();
            this.lumRange = new Zzzz.ZzzzRangeBar();
            this.dbRang_Max = new System.Windows.Forms.Label();
            this.lumRang_Max = new System.Windows.Forms.Label();
            this.magRang_Max = new System.Windows.Forms.Label();
            this.UV = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.gForce = new System.Windows.Forms.Label();
            this.tempR = new System.Windows.Forms.Label();
            this.dbRange = new Zzzz.ZzzzRangeBar();
            this.magRange = new Zzzz.ZzzzRangeBar();
            this.uvRange = new Zzzz.ZzzzRangeBar();
            this.presRange = new Zzzz.ZzzzRangeBar();
            this.humRange = new Zzzz.ZzzzRangeBar();
            this.gForceRange = new Zzzz.ZzzzRangeBar();
            this.tempRange = new Zzzz.ZzzzRangeBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lumR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.lumR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.dbaR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.dbaR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.magR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.gRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.magR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.uvR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.uvR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.presR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.presR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.humR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.humR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.gRang_Min);
            this.splitContainer1.Panel1.Controls.Add(this.tempR_Max);
            this.splitContainer1.Panel1.Controls.Add(this.tempR_Min);
            this.splitContainer1.Panel1.Controls.Add(this.lumRange);
            this.splitContainer1.Panel1.Controls.Add(this.dbRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.lumRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.magRang_Max);
            this.splitContainer1.Panel1.Controls.Add(this.UV);
            this.splitContainer1.Panel1.Controls.Add(this.Pressure);
            this.splitContainer1.Panel1.Controls.Add(this.humidity);
            this.splitContainer1.Panel1.Controls.Add(this.gForce);
            this.splitContainer1.Panel1.Controls.Add(this.tempR);
            this.splitContainer1.Panel1.Controls.Add(this.dbRange);
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
            this.splitContainer1.Size = new System.Drawing.Size(856, 423);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lumR_Max
            // 
            this.lumR_Max.Location = new System.Drawing.Point(342, 390);
            this.lumR_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lumR_Max.Name = "lumR_Max";
            this.lumR_Max.Size = new System.Drawing.Size(47, 20);
            this.lumR_Max.TabIndex = 50;
            // 
            // lumR_Min
            // 
            this.lumR_Min.Location = new System.Drawing.Point(287, 390);
            this.lumR_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lumR_Min.Name = "lumR_Min";
            this.lumR_Min.Size = new System.Drawing.Size(47, 20);
            this.lumR_Min.TabIndex = 49;
            // 
            // dbaR_Max
            // 
            this.dbaR_Max.Location = new System.Drawing.Point(342, 339);
            this.dbaR_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dbaR_Max.Name = "dbaR_Max";
            this.dbaR_Max.Size = new System.Drawing.Size(47, 20);
            this.dbaR_Max.TabIndex = 48;
            // 
            // dbaR_Min
            // 
            this.dbaR_Min.Location = new System.Drawing.Point(287, 340);
            this.dbaR_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dbaR_Min.Name = "dbaR_Min";
            this.dbaR_Min.Size = new System.Drawing.Size(47, 20);
            this.dbaR_Min.TabIndex = 47;
            // 
            // magR_Max
            // 
            this.magR_Max.Location = new System.Drawing.Point(342, 290);
            this.magR_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.magR_Max.Name = "magR_Max";
            this.magR_Max.Size = new System.Drawing.Size(47, 20);
            this.magR_Max.TabIndex = 46;
            // 
            // gRang_Max
            // 
            this.gRang_Max.Location = new System.Drawing.Point(342, 93);
            this.gRang_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gRang_Max.Name = "gRang_Max";
            this.gRang_Max.Size = new System.Drawing.Size(47, 20);
            this.gRang_Max.TabIndex = 45;
            // 
            // magR_Min
            // 
            this.magR_Min.Location = new System.Drawing.Point(287, 291);
            this.magR_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.magR_Min.Name = "magR_Min";
            this.magR_Min.Size = new System.Drawing.Size(47, 20);
            this.magR_Min.TabIndex = 44;
            // 
            // uvR_Max
            // 
            this.uvR_Max.Location = new System.Drawing.Point(342, 241);
            this.uvR_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uvR_Max.Name = "uvR_Max";
            this.uvR_Max.Size = new System.Drawing.Size(47, 20);
            this.uvR_Max.TabIndex = 43;
            // 
            // uvR_Min
            // 
            this.uvR_Min.Location = new System.Drawing.Point(287, 241);
            this.uvR_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uvR_Min.Name = "uvR_Min";
            this.uvR_Min.Size = new System.Drawing.Size(47, 20);
            this.uvR_Min.TabIndex = 42;
            // 
            // presR_Max
            // 
            this.presR_Max.Location = new System.Drawing.Point(342, 192);
            this.presR_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.presR_Max.Name = "presR_Max";
            this.presR_Max.Size = new System.Drawing.Size(47, 20);
            this.presR_Max.TabIndex = 41;
            // 
            // presR_Min
            // 
            this.presR_Min.Location = new System.Drawing.Point(287, 192);
            this.presR_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.presR_Min.Name = "presR_Min";
            this.presR_Min.Size = new System.Drawing.Size(47, 20);
            this.presR_Min.TabIndex = 40;
            // 
            // humR_Max
            // 
            this.humR_Max.Location = new System.Drawing.Point(338, 142);
            this.humR_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.humR_Max.Name = "humR_Max";
            this.humR_Max.Size = new System.Drawing.Size(47, 20);
            this.humR_Max.TabIndex = 39;
            // 
            // humR_Min
            // 
            this.humR_Min.Location = new System.Drawing.Point(287, 142);
            this.humR_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.humR_Min.Name = "humR_Min";
            this.humR_Min.Size = new System.Drawing.Size(47, 20);
            this.humR_Min.TabIndex = 38;
            // 
            // gRang_Min
            // 
            this.gRang_Min.Location = new System.Drawing.Point(287, 93);
            this.gRang_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gRang_Min.Name = "gRang_Min";
            this.gRang_Min.Size = new System.Drawing.Size(47, 20);
            this.gRang_Min.TabIndex = 36;
            // 
            // tempR_Max
            // 
            this.tempR_Max.Location = new System.Drawing.Point(342, 43);
            this.tempR_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tempR_Max.Name = "tempR_Max";
            this.tempR_Max.Size = new System.Drawing.Size(47, 20);
            this.tempR_Max.TabIndex = 35;
            // 
            // tempR_Min
            // 
            this.tempR_Min.Location = new System.Drawing.Point(287, 43);
            this.tempR_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tempR_Min.Name = "tempR_Min";
            this.tempR_Min.Size = new System.Drawing.Size(47, 20);
            this.tempR_Min.TabIndex = 34;
            // 
            // lumRange
            // 
            this.lumRange.AutoSize = true;
            this.lumRange.DivisionNum = 10;
            this.lumRange.HeightOfBar = 10;
            this.lumRange.HeightOfMark = 20;
            this.lumRange.HeightOfTick = 1;
            this.lumRange.InnerColor = System.Drawing.Color.Yellow;
            this.lumRange.Location = new System.Drawing.Point(4, 374);
            this.lumRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lumRange.Name = "lumRange";
            this.lumRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.lumRange.RangeMaximum = 5;
            this.lumRange.RangeMinimum = 3;
            this.lumRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.lumRange.Size = new System.Drawing.Size(274, 50);
            this.lumRange.TabIndex = 16;
            this.lumRange.TotalMaximum = 10;
            this.lumRange.TotalMinimum = 0;
            this.lumRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.lumRange_RangeChanged);
            // 
            // dbRang_Max
            // 
            this.dbRang_Max.AutoSize = true;
            this.dbRang_Max.Location = new System.Drawing.Point(282, 324);
            this.dbRang_Max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbRang_Max.Name = "dbRang_Max";
            this.dbRang_Max.Size = new System.Drawing.Size(67, 13);
            this.dbRang_Max.TabIndex = 33;
            this.dbRang_Max.Text = "Sound Level";
            // 
            // lumRang_Max
            // 
            this.lumRang_Max.AutoSize = true;
            this.lumRang_Max.Location = new System.Drawing.Point(282, 374);
            this.lumRang_Max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lumRang_Max.Name = "lumRang_Max";
            this.lumRang_Max.Size = new System.Drawing.Size(56, 13);
            this.lumRang_Max.TabIndex = 31;
            this.lumRang_Max.Text = "Luminosity";
            // 
            // magRang_Max
            // 
            this.magRang_Max.AutoSize = true;
            this.magRang_Max.Location = new System.Drawing.Point(282, 275);
            this.magRang_Max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.magRang_Max.Name = "magRang_Max";
            this.magRang_Max.Size = new System.Drawing.Size(98, 13);
            this.magRang_Max.TabIndex = 29;
            this.magRang_Max.Text = "Magnetic Field (uT)";
            // 
            // UV
            // 
            this.UV.AutoSize = true;
            this.UV.Location = new System.Drawing.Point(282, 225);
            this.UV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UV.Name = "UV";
            this.UV.Size = new System.Drawing.Size(107, 13);
            this.UV.TabIndex = 27;
            this.UV.Text = "UV Light (mW/cm^2)";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(282, 176);
            this.Pressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(76, 13);
            this.Pressure.TabIndex = 26;
            this.Pressure.Text = "Pressure (kPa)";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Location = new System.Drawing.Point(282, 126);
            this.humidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(80, 13);
            this.humidity.TabIndex = 23;
            this.humidity.Text = "Humidity (%RH)";
            // 
            // gForce
            // 
            this.gForce.AutoSize = true;
            this.gForce.Location = new System.Drawing.Point(282, 76);
            this.gForce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gForce.Name = "gForce";
            this.gForce.Size = new System.Drawing.Size(60, 13);
            this.gForce.TabIndex = 21;
            this.gForce.Text = "G Force (g)";
            // 
            // tempR
            // 
            this.tempR.AutoSize = true;
            this.tempR.Location = new System.Drawing.Point(282, 27);
            this.tempR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempR.Name = "tempR";
            this.tempR.Size = new System.Drawing.Size(83, 13);
            this.tempR.TabIndex = 19;
            this.tempR.Text = "Temperature (C)";
            // 
            // dbRange
            // 
            this.dbRange.AutoSize = true;
            this.dbRange.DivisionNum = 10;
            this.dbRange.HeightOfBar = 10;
            this.dbRange.HeightOfMark = 20;
            this.dbRange.HeightOfTick = 1;
            this.dbRange.InnerColor = System.Drawing.Color.White;
            this.dbRange.Location = new System.Drawing.Point(4, 324);
            this.dbRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dbRange.Name = "dbRange";
            this.dbRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.dbRange.RangeMaximum = 5;
            this.dbRange.RangeMinimum = 3;
            this.dbRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.dbRange.Size = new System.Drawing.Size(274, 50);
            this.dbRange.TabIndex = 17;
            this.dbRange.TotalMaximum = 10;
            this.dbRange.TotalMinimum = 0;
            this.dbRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.dbRange_RangeChanged);
            // 
            // magRange
            // 
            this.magRange.AutoSize = true;
            this.magRange.DivisionNum = 10;
            this.magRange.HeightOfBar = 10;
            this.magRange.HeightOfMark = 20;
            this.magRange.HeightOfTick = 1;
            this.magRange.InnerColor = System.Drawing.Color.DeepPink;
            this.magRange.Location = new System.Drawing.Point(4, 275);
            this.magRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.magRange.Name = "magRange";
            this.magRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.magRange.RangeMaximum = 5;
            this.magRange.RangeMinimum = 3;
            this.magRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.magRange.Size = new System.Drawing.Size(274, 50);
            this.magRange.TabIndex = 15;
            this.magRange.TotalMaximum = 10;
            this.magRange.TotalMinimum = 0;
            this.magRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.magRange_RangeChanged);
            // 
            // uvRange
            // 
            this.uvRange.AutoSize = true;
            this.uvRange.DivisionNum = 10;
            this.uvRange.HeightOfBar = 10;
            this.uvRange.HeightOfMark = 20;
            this.uvRange.HeightOfTick = 1;
            this.uvRange.InnerColor = System.Drawing.Color.DarkViolet;
            this.uvRange.Location = new System.Drawing.Point(4, 225);
            this.uvRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uvRange.Name = "uvRange";
            this.uvRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.uvRange.RangeMaximum = 5;
            this.uvRange.RangeMinimum = 3;
            this.uvRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.uvRange.Size = new System.Drawing.Size(274, 50);
            this.uvRange.TabIndex = 14;
            this.uvRange.TotalMaximum = 10;
            this.uvRange.TotalMinimum = 0;
            this.uvRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.uvRange_RangeChanged);
            // 
            // presRange
            // 
            this.presRange.AutoSize = true;
            this.presRange.DivisionNum = 10;
            this.presRange.HeightOfBar = 10;
            this.presRange.HeightOfMark = 20;
            this.presRange.HeightOfTick = 1;
            this.presRange.InnerColor = System.Drawing.Color.Lime;
            this.presRange.Location = new System.Drawing.Point(4, 176);
            this.presRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.presRange.Name = "presRange";
            this.presRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.presRange.RangeMaximum = 5;
            this.presRange.RangeMinimum = 3;
            this.presRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.presRange.Size = new System.Drawing.Size(274, 50);
            this.presRange.TabIndex = 13;
            this.presRange.TotalMaximum = 10;
            this.presRange.TotalMinimum = 0;
            this.presRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.presRange_RangeChanged);
            this.presRange.Load += new System.EventHandler(this.presRange_Load);
            // 
            // humRange
            // 
            this.humRange.AutoSize = true;
            this.humRange.DivisionNum = 10;
            this.humRange.HeightOfBar = 10;
            this.humRange.HeightOfMark = 20;
            this.humRange.HeightOfTick = 1;
            this.humRange.InnerColor = System.Drawing.Color.DeepSkyBlue;
            this.humRange.Location = new System.Drawing.Point(4, 126);
            this.humRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.humRange.Name = "humRange";
            this.humRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.humRange.RangeMaximum = 5;
            this.humRange.RangeMinimum = 3;
            this.humRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.humRange.Size = new System.Drawing.Size(274, 50);
            this.humRange.TabIndex = 12;
            this.humRange.TotalMaximum = 10;
            this.humRange.TotalMinimum = 0;
            this.humRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.humRange_RangeChanged);
            // 
            // gForceRange
            // 
            this.gForceRange.AutoSize = true;
            this.gForceRange.DivisionNum = 10;
            this.gForceRange.HeightOfBar = 10;
            this.gForceRange.HeightOfMark = 20;
            this.gForceRange.HeightOfTick = 1;
            this.gForceRange.InnerColor = System.Drawing.SystemColors.MenuText;
            this.gForceRange.Location = new System.Drawing.Point(4, 76);
            this.gForceRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gForceRange.Name = "gForceRange";
            this.gForceRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.gForceRange.RangeMaximum = 5;
            this.gForceRange.RangeMinimum = 3;
            this.gForceRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.gForceRange.Size = new System.Drawing.Size(274, 50);
            this.gForceRange.TabIndex = 11;
            this.gForceRange.TotalMaximum = 10;
            this.gForceRange.TotalMinimum = 0;
            this.gForceRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.gForceRange_RangeChanged);
            // 
            // tempRange
            // 
            this.tempRange.AutoSize = true;
            this.tempRange.DivisionNum = 10;
            this.tempRange.HeightOfBar = 10;
            this.tempRange.HeightOfMark = 20;
            this.tempRange.HeightOfTick = 1;
            this.tempRange.InnerColor = System.Drawing.Color.Red;
            this.tempRange.Location = new System.Drawing.Point(4, 27);
            this.tempRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tempRange.Name = "tempRange";
            this.tempRange.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.tempRange.RangeMaximum = 5;
            this.tempRange.RangeMinimum = 3;
            this.tempRange.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.tempRange.Size = new System.Drawing.Size(274, 50);
            this.tempRange.TabIndex = 10;
            this.tempRange.TotalMaximum = 10;
            this.tempRange.TotalMinimum = 0;
            this.tempRange.RangeChanged += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.tempRange_RangeChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(423, 23);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFile
            // 
            this.openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(146, 22);
            this.openFile.Text = "&Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // zoomMin_B
            // 
            this.zoomMin_B.BackColor = System.Drawing.Color.Transparent;
            this.zoomMin_B.Location = new System.Drawing.Point(2, 2);
            this.zoomMin_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoomMin_B.Name = "zoomMin_B";
            this.zoomMin_B.Size = new System.Drawing.Size(23, 23);
            this.zoomMin_B.TabIndex = 5;
            this.zoomMin_B.Text = "\\u002d";
            this.zoomMin_B.UseVisualStyleBackColor = false;
            this.zoomMin_B.Click += new System.EventHandler(this.zoomMin_B_Click);
            // 
            // zoomPlu_B
            // 
            this.zoomPlu_B.AutoSize = true;
            this.zoomPlu_B.BackColor = System.Drawing.Color.Transparent;
            this.zoomPlu_B.Location = new System.Drawing.Point(26, 2);
            this.zoomPlu_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoomPlu_B.Name = "zoomPlu_B";
            this.zoomPlu_B.Size = new System.Drawing.Size(23, 23);
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
            this.gmap.Location = new System.Drawing.Point(2, 2);
            this.gmap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.gmap.Size = new System.Drawing.Size(430, 420);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 5D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 423);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.MinimumSize = new System.Drawing.Size(679, 462);
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
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
        private System.Windows.Forms.Label dbRang_Max;
        private System.Windows.Forms.Label lumRang_Max;
        private System.Windows.Forms.Label magRang_Max;
        private System.Windows.Forms.Label UV;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label gForce;
        private System.Windows.Forms.Label tempR;
        private System.Windows.Forms.TextBox lumR_Max;
        private System.Windows.Forms.TextBox lumR_Min;
        private System.Windows.Forms.TextBox dbaR_Max;
        private System.Windows.Forms.TextBox dbaR_Min;
        private System.Windows.Forms.TextBox magR_Max;
        private System.Windows.Forms.TextBox gRang_Max;
        private System.Windows.Forms.TextBox magR_Min;
        private System.Windows.Forms.TextBox uvR_Max;
        private System.Windows.Forms.TextBox uvR_Min;
        private System.Windows.Forms.TextBox presR_Max;
        private System.Windows.Forms.TextBox presR_Min;
        private System.Windows.Forms.TextBox humR_Max;
        private System.Windows.Forms.TextBox humR_Min;
        private System.Windows.Forms.TextBox gRang_Min;
        private System.Windows.Forms.TextBox tempR_Max;
        private System.Windows.Forms.TextBox tempR_Min;
        
    }
}

