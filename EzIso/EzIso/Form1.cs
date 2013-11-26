using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiscUtils.Iso9660;
using System.IO;

namespace EzIso
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.inputController = new FileSelectionController(this.buttonBrowseInput, this.textBoxInput);
			this.inputController.SelectFolders = true;

			this.outputController = new FileSelectionController(this.buttonBrowseOutput, this.textBoxOutput);
			this.outputController.Saving = true;
			this.outputController.FileDialogFilter = "ISO images|*.iso|All files|*.*";
		}

		protected override void OnDragEnter(DragEventArgs drgevent)
		{
			base.OnDragEnter(drgevent);

			if (CheckAllowDrop(drgevent))
			{
				drgevent.Effect = DragDropEffects.Copy;
			}
			else
			{
				drgevent.Effect = DragDropEffects.None;
			}
		}

		private static bool CheckAllowDrop(DragEventArgs drgevent)
		{
			if (!drgevent.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return false;
			}

			var files = (string[])drgevent.Data.GetData(DataFormats.FileDrop);
			if (files.Length != 1)
			{
				return false;
			}

			var attributes = File.GetAttributes(files[0]);
			if (!attributes.HasFlag(FileAttributes.Directory))
			{
				return false;
			}

			return true;
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			base.OnDragDrop(drgevent);

			var files = (string[])drgevent.Data.GetData(DataFormats.FileDrop);
			var file = files[0];

			this.inputController.SelectedFile = file;

			if (String.IsNullOrWhiteSpace(this.outputController.SelectedFile))
			{
				var targetIso = file + ".iso";
				this.outputController.SelectedFile = targetIso;
			}

			if (String.IsNullOrWhiteSpace(this.textBoxImageName.Text))
			{
				var title = Path.GetFileName(file);
				if (title.Length > 24)
				{
					title = title.Substring(0, 24);
				}

				this.textBoxImageName.Text = title;
			}
		}

		private readonly FileSelectionController inputController;
		private readonly FileSelectionController outputController;

		private void SetStatus(string text)
		{
			this.labelStatus.Text = text;
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			this.StartOperation();
		}

		private void StartOperation()
		{
			var input = this.inputController.SelectedFile;
			var output = this.outputController.SelectedFile;
			var imageName = this.textBoxImageName.Text;
			var joliet = this.checkBoxJoliet.Checked;

			if (String.IsNullOrWhiteSpace(input))
			{
				this.SetStatus("Cannot start operation: No input folder selected.");
				return;
			}

			if (String.IsNullOrWhiteSpace(output))
			{
				this.SetStatus("Cannot start operation: No output file selected.");
				return;
			}

			var worker = new BackgroundWorker();
			worker.DoWork += (sender, e) => Operation(input, output, imageName, joliet);
			worker.RunWorkerCompleted += HandleOperationCompleted;
			worker.RunWorkerAsync();

			this.SetControls(false);
		}

		private void SetControls(bool enabled)
		{
			this.buttonStart.Enabled = enabled;
		}

		private void HandleOperationCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.SetControls(true);

			if (e.Error != null)
			{
				this.SetStatus("Operation failed: " + Environment.NewLine + e.Error.Message);
				return;
			}

			this.SetStatus("Operation completed successfully.");
		}

		private static void Operation(string inputFolder, string outputFile, string imageName, bool joliet)
		{
			using (var outStream = File.OpenWrite(outputFile))
			{
				var builder = new CDBuilder();
				if (!String.IsNullOrWhiteSpace(imageName))
				{
					builder.VolumeIdentifier = imageName;
				}
				builder.UseJoliet = joliet;
				var files = GetFilesRecursive(inputFolder, null, null);
				foreach (var file in files)
				{
					var absolute = Path.Combine(inputFolder, file);
					var content = File.ReadAllBytes(absolute);
					builder.AddFile(file, content);
				}
				builder.Build(outStream);
			}
		}

		public static List<string> GetFilesRecursive(string root, string dir, List<string> files)
		{
			string absolute;
			if (dir != null)
			{
				absolute = Path.Combine(root, dir);
			}
			else
			{
				absolute = root;
			}

			if (files == null)
			{
				files = new List<string>();
			}

			foreach (var file in Directory.GetFiles(absolute).Select(Path.GetFileName))
			{
				string relative;
				if (dir != null)
				{
					relative = Path.Combine(dir, file);
				}
				else
				{
					relative = file;
				}
				files.Add(relative);
			}

			foreach (var subDir in Directory.GetDirectories(absolute).Select(Path.GetFileName))
			{
				string relative;
				if (dir != null)
				{
					relative = Path.Combine(dir, subDir);
				}
				else
				{
					relative = subDir;
				}
				GetFilesRecursive(root, relative, files);
			}

			return files;
		}
	}
}
