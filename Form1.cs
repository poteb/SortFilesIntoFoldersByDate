using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SortFilesIntoFoldersByDate
{
  public partial class Form1 : Form
  {
    public delegate void IntDeletegate(int value);

    private DateTime dt = DateTime.MinValue;
    private DirectoryInfo sourceFolder;
    private DirectoryInfo destinationFolder;
    private readonly BackgroundWorker worker = new BackgroundWorker();
    private int target;


    public Form1()
    {
      InitializeComponent();

      if (Properties.Settings.Default.SourceFolder != string.Empty && Directory.Exists(Properties.Settings.Default.SourceFolder))
        SourceFolderSelected(Properties.Settings.Default.SourceFolder);
      if (Properties.Settings.Default.DestinationFolder != string.Empty && Directory.Exists(Properties.Settings.Default.DestinationFolder))
        DestinationFolderSelected(Properties.Settings.Default.DestinationFolder);

      this.worker.WorkerReportsProgress = true;
      this.worker.DoWork += worker_DoWork;
      this.worker.ProgressChanged += worker_ProgressChanged;
      this.worker.RunWorkerCompleted += worker_RunWorkerCompleted;
    }

    
    private void UpdateProgressBar(int value)
    {
      if (this.InvokeRequired)
      {
        Invoke(new IntDeletegate(UpdateProgressBar), value);
        return;
      }
      this.progressBar1.Value = value;
    }
    void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      UpdateProgressBar(100);
    }
    void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      UpdateProgressBar(e.ProgressPercentage);
    }
    void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.worker.ReportProgress(0);
      
      string dirName = string.Empty;
      this.dt = DateTime.MinValue;
      List<TreeNode> treeNodes = new List<TreeNode>();

      FileInfo[] files = this.sourceFolder.GetFiles("*", SearchOption.TopDirectoryOnly);
      this.target = files.Length;
      decimal i = 0;
      TreeNode node = new TreeNode();
      foreach (FileInfo fi in this.sourceFolder.GetFiles("*", SearchOption.TopDirectoryOnly))
      {
        if (fi.LastWriteTime.Date != this.dt.Date)
        {
          string month = fi.LastWriteTime.Month.ToString();
          if (fi.LastWriteTime.Month < 10)
            month = "0" + month;
          string day = fi.LastWriteTime.Day.ToString();
          if (fi.LastWriteTime.Day < 10)
            day = "0" + day;
          dirName = Path.Combine(this.destinationFolder.FullName, fi.LastWriteTime.Year.ToString().Substring(2, 2) + month + day);

          if (!Directory.Exists(dirName))
          {
            Directory.CreateDirectory(dirName);
            node = new TreeNode(dirName);
            treeNodes.Add(node);
          }

          this.dt = fi.LastWriteTime;
        }
        if (dirName == string.Empty) continue;
        string fileName = dirName + "/" + fi.Name;
        int c = 1;
        while (File.Exists(fileName))
          fileName = dirName + "/" + Path.GetFileNameWithoutExtension(fi.FullName) + "__" + (c++) + fi.Extension;
        if (this.rbCopy.Checked)
          File.Copy(fi.FullName, fileName);
        else
          File.Move(fi.FullName, fileName);
        node.Nodes.Add(new FileInfo(fileName).Name);
        i++;
        this.worker.ReportProgress((int)((i/target)*100));
      }
      EndOfDoIt(treeNodes);
    }

    public delegate void EndOfDoItDel(List<TreeNode> nodes);
    private void EndOfDoIt(List<TreeNode> nodes)
    {
      if (this.InvokeRequired)
      {
        Invoke(new EndOfDoItDel(EndOfDoIt), nodes);
        return;
      }
      this.linkLabelReport.Enabled = true;
      this.tvReport.Nodes.Clear();
      this.tvReport.Nodes.AddRange(nodes.ToArray());
    }

    private void SourceFolderSelected(string folder)
    {
      if (Directory.Exists(folder))
      {
        this.sourceFolder = new DirectoryInfo(folder);
        this.tbSourceFolder.Text = this.sourceFolder.FullName;
      }
    }
    private void DestinationFolderSelected(string folder)
    {
      if (Directory.Exists(folder))
      {
        this.destinationFolder = new DirectoryInfo(folder);
        this.tbDestinationFolder.Text = this.destinationFolder.FullName;
      }
    }

    private void bOpenSourceFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Source folder" };
      if (this.sourceFolder != null)
        fbd.SelectedPath = this.sourceFolder.FullName;
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        SourceFolderSelected(fbd.SelectedPath);
        if (this.destinationFolder == null)
          DestinationFolderSelected(fbd.SelectedPath);
      }
    }

    private void bOpenDestinationFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer, Description="Destination folder" };
      if (this.destinationFolder != null)
        fbd.SelectedPath = this.destinationFolder.FullName;
      if (fbd.ShowDialog() == DialogResult.OK)
        DestinationFolderSelected(fbd.SelectedPath);
    }

    private void bDoIt_Click(object sender, EventArgs e)
    {
      this.worker.RunWorkerAsync();
      /*string dirName = string.Empty;
      this.tvReport.Nodes.Clear();
      
      TreeNode node = new TreeNode();
      foreach (FileInfo fi in this.sourceFolder.GetFiles("*", SearchOption.TopDirectoryOnly))
      {
        if (fi.LastWriteTime.Date != this.dt.Date)
        {
          string month = fi.LastWriteTime.Month.ToString();
          if (fi.LastWriteTime.Month < 10)
            month = "0" + month;
          string day = fi.LastWriteTime.Day.ToString();
          if (fi.LastWriteTime.Day < 10)
            day = "0" + day;
          dirName = Path.Combine(this.destinationFolder.FullName, fi.LastWriteTime.Year.ToString().Substring(2, 2) + month + day);

          if (!Directory.Exists(dirName))
          {
            Directory.CreateDirectory(dirName);
            node = new TreeNode(dirName);
            //node.Text = dirName;
            this.tvReport.Nodes.Add(node);
          }

          this.dt = fi.LastWriteTime;
        }
        if (dirName != string.Empty)
        {
          string fileName = dirName + "/" + fi.Name;
          int c = 1;
          while (File.Exists(fileName))
            fileName = dirName + "/" + Path.GetFileNameWithoutExtension(fi.FullName) + "__" + (c++) + fi.Extension;
          if (this.rbCopy.Checked)
            File.Copy(fi.FullName, fileName);
          else
            File.Move(fi.FullName, fileName);
          //TreeNode tn = new TreeNode(new FileInfo(fileName).Name);
          //tn.Tag = 
          node.Nodes.Add(new FileInfo(fileName).Name);
        }
      }
      //ForLoop(dirName, node);
      this.linkLabelReport.Enabled = true;*/
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.sourceFolder != null)
        Properties.Settings.Default.SourceFolder = this.sourceFolder.FullName;
      if (this.destinationFolder != null)
        Properties.Settings.Default.DestinationFolder = this.destinationFolder.FullName;
      Properties.Settings.Default.Save();
    }

    private void linkLabelReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.Height = this.Height >= 560 ? 150 : 560;
    }

    private void linkLabelBrowseSourceFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("explorer.exe", "/n," + this.sourceFolder);
    }

    private void linkLabelBrowseDestinationFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("explorer.exe", "/n," + this.destinationFolder);
    }

    private void tbSourceFolder_Validated(object sender, EventArgs e)
    {
      SourceFolderSelected(this.tbSourceFolder.Text);
    }

    private void tbDestinationFolder_Validated(object sender, EventArgs e)
    {
      DestinationFolderSelected(this.tbDestinationFolder.Text);
    }

    private void tvReport_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Node.Parent != null)
        Process.Start(Path.Combine(e.Node.Parent.Text, e.Node.Text));
      /*else
      {
        ProcessStartInfo pi = new ProcessStartInfo("explorer.exe", "/n, " + e.Node.Text) { CreateNoWindow = true, UseShellExecute = false };
        Process.Start(pi);
      }*/
    }

    private void bAddDateStamp_Click(object sender, EventArgs e)
    {
      var f = new AddDateStampForm();
      f.ShowDialog();
    }

    private void bCorrectDateStamp_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Source folder" };
      if (Directory.Exists(this.destinationFolder.FullName))
        fbd.SelectedPath = this.destinationFolder.FullName;
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        DirectoryInfo dir = new DirectoryInfo(fbd.SelectedPath);
        string dirName = dir.Name.Split(' ')[0];
        DateTime dirDate = new DateTime(Int32.Parse(dirName.Substring(0,2))+2000,Int32.Parse(dirName.Substring(2,2)), Int32.Parse(dirName.Substring(4, 2)));
        FileInfo[] f = dir.GetFiles("*.jpg");
        foreach (FileInfo fi in f)
        {
          if (fi.LastWriteTime.Year != dirDate.Year || fi.LastWriteTime.Month != dirDate.Month || fi.LastWriteTime.Day != dirDate.Day)
          {
            DateTime fileDate = new DateTime(fi.LastWriteTime.Ticks);
            fileDate = fileDate.AddYears(dirDate.Year - fi.LastWriteTime.Year);
            fileDate = fileDate.AddMonths(dirDate.Month - fi.LastWriteTime.Month);
            fileDate = fileDate.AddDays(dirDate.Day - fi.LastWriteTime.Day);
            FileSystemInfo fsi = fi;
            fsi.LastWriteTime = fileDate;
          }
            
          /*Bitmap image = new Bitmap(fi.FullName);
            Bitmap newImage = new Bitmap(image);
            foreach (PropertyItem propertyItem in image.PropertyItems)
            {
              newImage.SetPropertyItem(propertyItem);
              if (propertyItem.Id == 306)
              {
                string sdate = Encoding.UTF8.GetString(propertyItem.Value).Trim();
                propertyItem.Value = new ASCIIEncoding().GetBytes(sdate);
                newImage.SetPropertyItem(propertyItem);
              }
            }
            //PropertyItem propItem = newImage.GetPropertyItem(306);
            //string sdate = Encoding.UTF8.GetString(propItem.Value).Trim();
            //System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            //propItem.Value = encoding.GetBytes(sdate);
            //newImage.SetPropertyItem(propItem);
            image.Dispose();
            newImage.Save(fi.FullName + "2.jpg");*/
        }
      }
    }

    private void linkSilje_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tbDestinationFolder.Text = "D:\\Silje\\Billeder og video";
    }

    private void linkAsger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tbDestinationFolder.Text = "D:\\Asger\\Billeder og video";
    }
  }
}