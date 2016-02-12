namespace ZOTE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.autoFillReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rtEdit = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.nLocation = new System.Windows.Forms.NumericUpDown();
			this.rtDisplay = new System.Windows.Forms.RichTextBox();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.dumpDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.dicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nLocation)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ediToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(394, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openROMToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openROMToolStripMenuItem
			// 
			this.openROMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openROMToolStripMenuItem.Image")));
			this.openROMToolStripMenuItem.Name = "openROMToolStripMenuItem";
			this.openROMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openROMToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.openROMToolStripMenuItem.Text = "Open ROM...";
			this.openROMToolStripMenuItem.Click += new System.EventHandler(this.openROMToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// ediToolStripMenuItem
			// 
			this.ediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchWordToolStripMenuItem,
            this.toolStripMenuItem2,
            this.autoFillReferencesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.dumpDictionaryToolStripMenuItem});
			this.ediToolStripMenuItem.Name = "ediToolStripMenuItem";
			this.ediToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.ediToolStripMenuItem.Text = "&Edit";
			// 
			// searchWordToolStripMenuItem
			// 
			this.searchWordToolStripMenuItem.Enabled = false;
			this.searchWordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchWordToolStripMenuItem.Image")));
			this.searchWordToolStripMenuItem.Name = "searchWordToolStripMenuItem";
			this.searchWordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.searchWordToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.searchWordToolStripMenuItem.Text = "Search Phrase";
			this.searchWordToolStripMenuItem.Click += new System.EventHandler(this.searchWordToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
			// 
			// autoFillReferencesToolStripMenuItem
			// 
			this.autoFillReferencesToolStripMenuItem.Checked = true;
			this.autoFillReferencesToolStripMenuItem.CheckOnClick = true;
			this.autoFillReferencesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autoFillReferencesToolStripMenuItem.Name = "autoFillReferencesToolStripMenuItem";
			this.autoFillReferencesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.autoFillReferencesToolStripMenuItem.Text = "Auto-Fill References";
			this.autoFillReferencesToolStripMenuItem.Click += new System.EventHandler(this.autoFillReferencesToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forumsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.dicToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// forumsToolStripMenuItem
			// 
			this.forumsToolStripMenuItem.Name = "forumsToolStripMenuItem";
			this.forumsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.forumsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.forumsToolStripMenuItem.Text = "Forums";
			this.forumsToolStripMenuItem.Click += new System.EventHandler(this.forumsToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Text Location:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 539);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(394, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rtEdit);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.nLocation);
			this.panel1.Controls.Add(this.rtDisplay);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Enabled = false;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(394, 515);
			this.panel1.TabIndex = 4;
			// 
			// rtEdit
			// 
			this.rtEdit.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtEdit.Location = new System.Drawing.Point(15, 30);
			this.rtEdit.Multiline = true;
			this.rtEdit.Name = "rtEdit";
			this.rtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.rtEdit.Size = new System.Drawing.Size(367, 164);
			this.rtEdit.TabIndex = 9;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(282, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Update Visual";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(201, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Go";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// nLocation
			// 
			this.nLocation.Hexadecimal = true;
			this.nLocation.Location = new System.Drawing.Point(93, 4);
			this.nLocation.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            0});
			this.nLocation.Name = "nLocation";
			this.nLocation.Size = new System.Drawing.Size(102, 20);
			this.nLocation.TabIndex = 10;
			this.nLocation.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// rtDisplay
			// 
			this.rtDisplay.BackColor = System.Drawing.Color.Black;
			this.rtDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtDisplay.ForeColor = System.Drawing.Color.White;
			this.rtDisplay.Location = new System.Drawing.Point(15, 200);
			this.rtDisplay.Name = "rtDisplay";
			this.rtDisplay.ReadOnly = true;
			this.rtDisplay.Size = new System.Drawing.Size(367, 312);
			this.rtDisplay.TabIndex = 13;
			this.rtDisplay.Text = "";
			this.rtDisplay.WordWrap = false;
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 6);
			// 
			// dumpDictionaryToolStripMenuItem
			// 
			this.dumpDictionaryToolStripMenuItem.Enabled = false;
			this.dumpDictionaryToolStripMenuItem.Name = "dumpDictionaryToolStripMenuItem";
			this.dumpDictionaryToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.dumpDictionaryToolStripMenuItem.Text = "Dump Dictionary";
			this.dumpDictionaryToolStripMenuItem.Click += new System.EventHandler(this.dumpDictionaryToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(169, 6);
			// 
			// dicToolStripMenuItem
			// 
			this.dicToolStripMenuItem.Enabled = false;
			this.dicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dicToolStripMenuItem.Image")));
			this.dicToolStripMenuItem.Name = "dicToolStripMenuItem";
			this.dicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.dicToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.dicToolStripMenuItem.Text = "Dictionary";
			this.dicToolStripMenuItem.Click += new System.EventHandler(this.dicToolStripMenuItem_Click);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(218, 17);
			this.toolStripStatusLabel1.Text = "Please visit and register on the forums! (F2)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ZOTE - Zelda Oracles Text Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nLocation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openROMToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox rtDisplay;
		private System.Windows.Forms.NumericUpDown nLocation;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TextBox rtEdit;
		private System.Windows.Forms.ToolStripMenuItem ediToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchWordToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem autoFillReferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem forumsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem dumpDictionaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem dicToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
	}
}

