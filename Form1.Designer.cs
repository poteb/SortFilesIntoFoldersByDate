namespace SortFilesIntoFoldersByDate
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
      this.bOpenSourceFolder = new System.Windows.Forms.Button();
      this.tbSourceFolder = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tbDestinationFolder = new System.Windows.Forms.TextBox();
      this.bOpenDestinationFolder = new System.Windows.Forms.Button();
      this.bDoIt = new System.Windows.Forms.Button();
      this.rbCopy = new System.Windows.Forms.RadioButton();
      this.rbMove = new System.Windows.Forms.RadioButton();
      this.tvReport = new System.Windows.Forms.TreeView();
      this.linkLabelReport = new System.Windows.Forms.LinkLabel();
      this.linkLabelBrowseSourceFolder = new System.Windows.Forms.LinkLabel();
      this.linkLabelBrowseDestinationFolder = new System.Windows.Forms.LinkLabel();
      this.bAddDateStamp = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.bCorrectDateStamp = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.linkSilje = new System.Windows.Forms.LinkLabel();
      this.linkAsger = new System.Windows.Forms.LinkLabel();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // bOpenSourceFolder
      // 
      this.bOpenSourceFolder.Location = new System.Drawing.Point(506, 11);
      this.bOpenSourceFolder.Name = "bOpenSourceFolder";
      this.bOpenSourceFolder.Size = new System.Drawing.Size(40, 20);
      this.bOpenSourceFolder.TabIndex = 1;
      this.bOpenSourceFolder.Text = "...";
      this.bOpenSourceFolder.UseVisualStyleBackColor = true;
      this.bOpenSourceFolder.Click += new System.EventHandler(this.bOpenSourceFolder_Click);
      // 
      // tbSourceFolder
      // 
      this.tbSourceFolder.Location = new System.Drawing.Point(110, 11);
      this.tbSourceFolder.Name = "tbSourceFolder";
      this.tbSourceFolder.Size = new System.Drawing.Size(390, 20);
      this.tbSourceFolder.TabIndex = 99;
      this.tbSourceFolder.Validated += new System.EventHandler(this.tbSourceFolder_Validated);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Source folder:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Destination folder:";
      // 
      // tbDestinationFolder
      // 
      this.tbDestinationFolder.Location = new System.Drawing.Point(110, 37);
      this.tbDestinationFolder.Name = "tbDestinationFolder";
      this.tbDestinationFolder.Size = new System.Drawing.Size(390, 20);
      this.tbDestinationFolder.TabIndex = 99;
      this.tbDestinationFolder.Validated += new System.EventHandler(this.tbDestinationFolder_Validated);
      // 
      // bOpenDestinationFolder
      // 
      this.bOpenDestinationFolder.Location = new System.Drawing.Point(506, 37);
      this.bOpenDestinationFolder.Name = "bOpenDestinationFolder";
      this.bOpenDestinationFolder.Size = new System.Drawing.Size(40, 20);
      this.bOpenDestinationFolder.TabIndex = 2;
      this.bOpenDestinationFolder.Text = "...";
      this.bOpenDestinationFolder.UseVisualStyleBackColor = true;
      this.bOpenDestinationFolder.Click += new System.EventHandler(this.bOpenDestinationFolder_Click);
      // 
      // bDoIt
      // 
      this.bDoIt.Location = new System.Drawing.Point(506, 63);
      this.bDoIt.Name = "bDoIt";
      this.bDoIt.Size = new System.Drawing.Size(40, 40);
      this.bDoIt.TabIndex = 6;
      this.bDoIt.Text = "Do it!";
      this.bDoIt.UseVisualStyleBackColor = true;
      this.bDoIt.Click += new System.EventHandler(this.bDoIt_Click);
      // 
      // rbCopy
      // 
      this.rbCopy.AutoSize = true;
      this.rbCopy.Location = new System.Drawing.Point(448, 86);
      this.rbCopy.Name = "rbCopy";
      this.rbCopy.Size = new System.Drawing.Size(49, 17);
      this.rbCopy.TabIndex = 5;
      this.rbCopy.Text = "Copy";
      this.rbCopy.UseVisualStyleBackColor = true;
      // 
      // rbMove
      // 
      this.rbMove.AutoSize = true;
      this.rbMove.Location = new System.Drawing.Point(448, 63);
      this.rbMove.Name = "rbMove";
      this.rbMove.Size = new System.Drawing.Size(52, 17);
      this.rbMove.TabIndex = 5;
      this.rbMove.Text = "Move";
      this.rbMove.UseVisualStyleBackColor = true;
      // 
      // tvReport
      // 
      this.tvReport.Location = new System.Drawing.Point(15, 122);
      this.tvReport.Name = "tvReport";
      this.tvReport.Size = new System.Drawing.Size(531, 392);
      this.tvReport.TabIndex = 100;
      this.tvReport.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvReport_NodeMouseDoubleClick);
      // 
      // linkLabelReport
      // 
      this.linkLabelReport.AutoSize = true;
      this.linkLabelReport.Enabled = false;
      this.linkLabelReport.Location = new System.Drawing.Point(15, 89);
      this.linkLabelReport.Name = "linkLabelReport";
      this.linkLabelReport.Size = new System.Drawing.Size(94, 13);
      this.linkLabelReport.TabIndex = 101;
      this.linkLabelReport.TabStop = true;
      this.linkLabelReport.Text = "Show/hide Report";
      this.linkLabelReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReport_LinkClicked);
      // 
      // linkLabelBrowseSourceFolder
      // 
      this.linkLabelBrowseSourceFolder.AutoSize = true;
      this.linkLabelBrowseSourceFolder.Location = new System.Drawing.Point(552, 14);
      this.linkLabelBrowseSourceFolder.Name = "linkLabelBrowseSourceFolder";
      this.linkLabelBrowseSourceFolder.Size = new System.Drawing.Size(51, 13);
      this.linkLabelBrowseSourceFolder.TabIndex = 102;
      this.linkLabelBrowseSourceFolder.TabStop = true;
      this.linkLabelBrowseSourceFolder.Text = "Browse...";
      this.linkLabelBrowseSourceFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBrowseSourceFolder_LinkClicked);
      // 
      // linkLabelBrowseDestinationFolder
      // 
      this.linkLabelBrowseDestinationFolder.AutoSize = true;
      this.linkLabelBrowseDestinationFolder.Location = new System.Drawing.Point(552, 40);
      this.linkLabelBrowseDestinationFolder.Name = "linkLabelBrowseDestinationFolder";
      this.linkLabelBrowseDestinationFolder.Size = new System.Drawing.Size(51, 13);
      this.linkLabelBrowseDestinationFolder.TabIndex = 102;
      this.linkLabelBrowseDestinationFolder.TabStop = true;
      this.linkLabelBrowseDestinationFolder.Text = "Browse...";
      this.linkLabelBrowseDestinationFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBrowseDestinationFolder_LinkClicked);
      // 
      // bAddDateStamp
      // 
      this.bAddDateStamp.Location = new System.Drawing.Point(6, 19);
      this.bAddDateStamp.Name = "bAddDateStamp";
      this.bAddDateStamp.Size = new System.Drawing.Size(112, 23);
      this.bAddDateStamp.TabIndex = 103;
      this.bAddDateStamp.Text = "Add date stamp...";
      this.bAddDateStamp.UseVisualStyleBackColor = true;
      this.bAddDateStamp.Click += new System.EventHandler(this.bAddDateStamp_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.bAddDateStamp);
      this.groupBox1.Location = new System.Drawing.Point(622, 11);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 46);
      this.groupBox1.TabIndex = 104;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Folder Stuff";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.bCorrectDateStamp);
      this.groupBox2.Location = new System.Drawing.Point(622, 63);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(200, 49);
      this.groupBox2.TabIndex = 105;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Files Stuff";
      // 
      // bCorrectDateStamp
      // 
      this.bCorrectDateStamp.Location = new System.Drawing.Point(6, 19);
      this.bCorrectDateStamp.Name = "bCorrectDateStamp";
      this.bCorrectDateStamp.Size = new System.Drawing.Size(188, 23);
      this.bCorrectDateStamp.TabIndex = 0;
      this.bCorrectDateStamp.Text = "Correct date stamp of files...";
      this.bCorrectDateStamp.UseVisualStyleBackColor = true;
      this.bCorrectDateStamp.Click += new System.EventHandler(this.bCorrectDateStamp_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(206, 79);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(131, 23);
      this.progressBar1.TabIndex = 106;
      // 
      // linkSilje
      // 
      this.linkSilje.AutoSize = true;
      this.linkSilje.Location = new System.Drawing.Point(111, 56);
      this.linkSilje.Name = "linkSilje";
      this.linkSilje.Size = new System.Drawing.Size(26, 13);
      this.linkSilje.TabIndex = 107;
      this.linkSilje.TabStop = true;
      this.linkSilje.Text = "Silje";
      this.linkSilje.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSilje_LinkClicked);
      // 
      // linkAsger
      // 
      this.linkAsger.AutoSize = true;
      this.linkAsger.Location = new System.Drawing.Point(139, 56);
      this.linkAsger.Name = "linkAsger";
      this.linkAsger.Size = new System.Drawing.Size(34, 13);
      this.linkAsger.TabIndex = 108;
      this.linkAsger.TabStop = true;
      this.linkAsger.Text = "Asger";
      this.linkAsger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAsger_LinkClicked);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(839, 116);
      this.Controls.Add(this.linkAsger);
      this.Controls.Add(this.linkSilje);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.linkLabelBrowseDestinationFolder);
      this.Controls.Add(this.linkLabelBrowseSourceFolder);
      this.Controls.Add(this.linkLabelReport);
      this.Controls.Add(this.tvReport);
      this.Controls.Add(this.rbMove);
      this.Controls.Add(this.rbCopy);
      this.Controls.Add(this.bDoIt);
      this.Controls.Add(this.bOpenDestinationFolder);
      this.Controls.Add(this.bOpenSourceFolder);
      this.Controls.Add(this.tbDestinationFolder);
      this.Controls.Add(this.tbSourceFolder);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Name = "Form1";
      this.Text = "Dild";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bOpenSourceFolder;
		private System.Windows.Forms.TextBox tbSourceFolder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDestinationFolder;
		private System.Windows.Forms.Button bOpenDestinationFolder;
		private System.Windows.Forms.Button bDoIt;
		private System.Windows.Forms.RadioButton rbCopy;
		private System.Windows.Forms.RadioButton rbMove;
		private System.Windows.Forms.TreeView tvReport;
		private System.Windows.Forms.LinkLabel linkLabelReport;
		private System.Windows.Forms.LinkLabel linkLabelBrowseSourceFolder;
		private System.Windows.Forms.LinkLabel linkLabelBrowseDestinationFolder;
		private System.Windows.Forms.Button bAddDateStamp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button bCorrectDateStamp;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.LinkLabel linkSilje;
    private System.Windows.Forms.LinkLabel linkAsger;
	}
}

