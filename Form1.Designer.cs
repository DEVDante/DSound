namespace DSound
{
    partial class mainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.graphSplitContainer = new System.Windows.Forms.SplitContainer();
            this.waveViewer = new DSound.CustomWaveViewer();
            this.buttonCSG = new System.Windows.Forms.Button();
            this.buttonCPG = new System.Windows.Forms.Button();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonLowPass = new System.Windows.Forms.Button();
            this.buttonHighPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CutoffNumeric = new System.Windows.Forms.NumericUpDown();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphSplitContainer)).BeginInit();
            this.graphSplitContainer.Panel1.SuspendLayout();
            this.graphSplitContainer.Panel2.SuspendLayout();
            this.graphSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutoffNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(976, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.graphSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.stopButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.playButton);
            this.mainSplitContainer.Size = new System.Drawing.Size(976, 412);
            this.mainSplitContainer.SplitterDistance = 818;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // graphSplitContainer
            // 
            this.graphSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.graphSplitContainer.Name = "graphSplitContainer";
            this.graphSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // graphSplitContainer.Panel1
            // 
            this.graphSplitContainer.Panel1.Controls.Add(this.waveViewer);
            // 
            // graphSplitContainer.Panel2
            // 
            this.graphSplitContainer.Panel2.Controls.Add(this.buttonCSG);
            this.graphSplitContainer.Panel2.Controls.Add(this.buttonCPG);
            this.graphSplitContainer.Panel2.Controls.Add(this.buttonClearFilters);
            this.graphSplitContainer.Panel2.Controls.Add(this.buttonLowPass);
            this.graphSplitContainer.Panel2.Controls.Add(this.buttonHighPass);
            this.graphSplitContainer.Panel2.Controls.Add(this.label2);
            this.graphSplitContainer.Panel2.Controls.Add(this.QNumeric);
            this.graphSplitContainer.Panel2.Controls.Add(this.label1);
            this.graphSplitContainer.Panel2.Controls.Add(this.CutoffNumeric);
            this.graphSplitContainer.Size = new System.Drawing.Size(818, 412);
            this.graphSplitContainer.SplitterDistance = 241;
            this.graphSplitContainer.TabIndex = 0;
            // 
            // waveViewer
            // 
            this.waveViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveViewer.Location = new System.Drawing.Point(0, 0);
            this.waveViewer.Name = "waveViewer";
            this.waveViewer.PenColor = System.Drawing.Color.DodgerBlue;
            this.waveViewer.PenWidth = 1F;
            this.waveViewer.SamplesPerPixel = 128;
            this.waveViewer.Size = new System.Drawing.Size(818, 241);
            this.waveViewer.StartPosition = ((long)(0));
            this.waveViewer.TabIndex = 0;
            this.waveViewer.WaveStream = null;
            // 
            // buttonCSG
            // 
            this.buttonCSG.Location = new System.Drawing.Point(405, 97);
            this.buttonCSG.Name = "buttonCSG";
            this.buttonCSG.Size = new System.Drawing.Size(119, 23);
            this.buttonCSG.TabIndex = 8;
            this.buttonCSG.Text = "Constant skirt gain";
            this.buttonCSG.UseVisualStyleBackColor = true;
            this.buttonCSG.Click += new System.EventHandler(this.buttonCSG_Click);
            // 
            // buttonCPG
            // 
            this.buttonCPG.Location = new System.Drawing.Point(280, 97);
            this.buttonCPG.Name = "buttonCPG";
            this.buttonCPG.Size = new System.Drawing.Size(119, 23);
            this.buttonCPG.TabIndex = 7;
            this.buttonCPG.Text = "Constant peak gain";
            this.buttonCPG.UseVisualStyleBackColor = true;
            this.buttonCPG.Click += new System.EventHandler(this.buttonCPG_Click);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Location = new System.Drawing.Point(740, 97);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFilters.TabIndex = 6;
            this.buttonClearFilters.Text = "Clear filters";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // buttonLowPass
            // 
            this.buttonLowPass.Location = new System.Drawing.Point(155, 97);
            this.buttonLowPass.Name = "buttonLowPass";
            this.buttonLowPass.Size = new System.Drawing.Size(119, 23);
            this.buttonLowPass.TabIndex = 5;
            this.buttonLowPass.Text = "Low pass filter";
            this.buttonLowPass.UseVisualStyleBackColor = true;
            this.buttonLowPass.Click += new System.EventHandler(this.buttonLowPass_Click);
            // 
            // buttonHighPass
            // 
            this.buttonHighPass.Location = new System.Drawing.Point(30, 97);
            this.buttonHighPass.Name = "buttonHighPass";
            this.buttonHighPass.Size = new System.Drawing.Size(119, 23);
            this.buttonHighPass.TabIndex = 4;
            this.buttonHighPass.Text = "High pass filter";
            this.buttonHighPass.UseVisualStyleBackColor = true;
            this.buttonHighPass.Click += new System.EventHandler(this.buttonHighPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Q parameter:";
            // 
            // QNumeric
            // 
            this.QNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.QNumeric.Location = new System.Drawing.Point(107, 71);
            this.QNumeric.Name = "QNumeric";
            this.QNumeric.Size = new System.Drawing.Size(57, 20);
            this.QNumeric.TabIndex = 2;
            this.QNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cutoff frequency:";
            // 
            // CutoffNumeric
            // 
            this.CutoffNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CutoffNumeric.Location = new System.Drawing.Point(107, 42);
            this.CutoffNumeric.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.CutoffNumeric.Name = "CutoffNumeric";
            this.CutoffNumeric.Size = new System.Drawing.Size(57, 20);
            this.CutoffNumeric.TabIndex = 0;
            this.CutoffNumeric.Value = new decimal(new int[] {
            48000,
            0,
            0,
            0});
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(13, 32);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(129, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(13, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(129, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Wave files|*.wav|MP3 files|*.mp3";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 436);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainWindow";
            this.Text = "DSound";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.graphSplitContainer.Panel1.ResumeLayout(false);
            this.graphSplitContainer.Panel2.ResumeLayout(false);
            this.graphSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphSplitContainer)).EndInit();
            this.graphSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutoffNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer graphSplitContainer;
        private CustomWaveViewer waveViewer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.NumericUpDown CutoffNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown QNumeric;
        private System.Windows.Forms.Button buttonLowPass;
        private System.Windows.Forms.Button buttonHighPass;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonCPG;
        private System.Windows.Forms.Button buttonCSG;
    }
}

