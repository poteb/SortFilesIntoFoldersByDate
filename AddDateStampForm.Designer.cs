namespace SortFilesIntoFoldersByDate
{
	partial class AddDateStampForm
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
			this.bDoIt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bOpenSourceFolder
			// 
			this.bOpenSourceFolder.Location = new System.Drawing.Point(453, 6);
			this.bOpenSourceFolder.Name = "bOpenSourceFolder";
			this.bOpenSourceFolder.Size = new System.Drawing.Size(40, 20);
			this.bOpenSourceFolder.TabIndex = 100;
			this.bOpenSourceFolder.Text = "...";
			this.bOpenSourceFolder.UseVisualStyleBackColor = true;
			this.bOpenSourceFolder.Click += new System.EventHandler(this.bOpenSourceFolder_Click);
			// 
			// tbSourceFolder
			// 
			this.tbSourceFolder.Location = new System.Drawing.Point(57, 6);
			this.tbSourceFolder.Name = "tbSourceFolder";
			this.tbSourceFolder.Size = new System.Drawing.Size(390, 20);
			this.tbSourceFolder.TabIndex = 102;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 101;
			this.label2.Text = "Folder:";
			// 
			// bDoIt
			// 
			this.bDoIt.Location = new System.Drawing.Point(453, 32);
			this.bDoIt.Name = "bDoIt";
			this.bDoIt.Size = new System.Drawing.Size(40, 40);
			this.bDoIt.TabIndex = 103;
			this.bDoIt.Text = "Do it!";
			this.bDoIt.UseVisualStyleBackColor = true;
			this.bDoIt.Click += new System.EventHandler(this.bDoIt_Click);
			// 
			// AddDateStampForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 89);
			this.Controls.Add(this.bDoIt);
			this.Controls.Add(this.bOpenSourceFolder);
			this.Controls.Add(this.tbSourceFolder);
			this.Controls.Add(this.label2);
			this.Name = "AddDateStampForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddDateStamp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDateStampForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bOpenSourceFolder;
		private System.Windows.Forms.TextBox tbSourceFolder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bDoIt;
	}
}