using System;
using System.Windows.Forms;
using System.IO;

namespace SortFilesIntoFoldersByDate
{
	public partial class AddDateStampForm : Form
	{
		public AddDateStampForm()
		{
			InitializeComponent();

			if (Properties.Settings.Default.DateStamp != string.Empty && Directory.Exists(Properties.Settings.Default.DateStamp))
			{
				this.tbSourceFolder.Text = Properties.Settings.Default.DateStamp;
			}
		}

		private void bOpenSourceFolder_Click(object sender, EventArgs e)
		{
			var fbd = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Source folder" };
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				this.tbSourceFolder.Text = fbd.SelectedPath;
			}
		}

		private void bDoIt_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(this.tbSourceFolder.Text) && Directory.Exists(this.tbSourceFolder.Text))
			{
				var di = new DirectoryInfo(this.tbSourceFolder.Text);
				FileInfo[] fis = di.GetFiles();
				foreach(FileInfo fi in fis)
				{
					DateTime mod = fi.LastWriteTime;
					string yy = mod.Year.ToString().Substring(2);
					string mm = (mod.Month < 10 ? "0" : "") + mod.Month;
					string dd = (mod.Day < 10 ? "0" : "") + mod.Day;
					string newFilename = yy + mm + dd + " " + fi.Name;
					newFilename = Path.Combine(fi.DirectoryName, newFilename);
					File.Move(fi.FullName, newFilename);
				}
			}
		}

		private void AddDateStampForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!String.IsNullOrEmpty(this.tbSourceFolder.Text))
				Properties.Settings.Default.DateStamp = this.tbSourceFolder.Text;
			Properties.Settings.Default.Save();
		}
	}
}
