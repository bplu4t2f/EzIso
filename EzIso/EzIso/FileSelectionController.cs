using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EzIso
{
	public class FileSelectionController
	{
		public FileSelectionController(Control browseButton, Control textBox)
		{
			if (browseButton == null) throw new ArgumentNullException("browseButton");
			if (textBox == null) throw new ArgumentNullException("textBox");

			this.BrowseButton = browseButton;
			this.TextBox = textBox;

			this.Initialize();
		}

		private void Initialize()
		{
			this.BrowseButton.Click += this.HandleButtonClick;
		}

		public Control BrowseButton { get; private set; }
		public Control TextBox { get; private set; }

		public bool SelectFolders { get; set; }
		public bool Saving { get; set; }
		public string FileDialogFilter { get; set; }

		public string SelectedFile
		{
			get { return this.TextBox.Text; }
			set { this.TextBox.Text = value; }
		}

		private void HandleButtonClick(object sender, EventArgs e)
		{
			if (this.SelectFolders)
			{
				this.UseDirectoryDialog();
			}
			else
			{
				if (this.Saving)
				{
					this.UseSaveFileDialog();
				}
				else
				{
					this.UseOpenFileDialog();
				}
			}
		}

		public void UseOpenFileDialog()
		{
			using (var dialog = new OpenFileDialog())
			{
				dialog.Filter = this.FileDialogFilter;
				dialog.FileName = this.SelectedFile;
				var result = dialog.ShowDialog();
				if (result != DialogResult.OK)
				{
					return;
				}

				this.SelectedFile = dialog.FileName;
			}
		}

		public void UseSaveFileDialog()
		{
			using (var dialog = new SaveFileDialog())
			{
				dialog.Filter = this.FileDialogFilter;
				dialog.FileName = this.SelectedFile;
				var result = dialog.ShowDialog();
				if (result != DialogResult.OK)
				{
					return;
				}

				this.SelectedFile = dialog.FileName;
			}
		}

		public void UseDirectoryDialog()
		{
			using (var dialog = new FolderBrowserDialog())
			{
				dialog.ShowNewFolderButton = this.Saving;
				dialog.SelectedPath = this.SelectedFile;
				var result = dialog.ShowDialog();
				if (result != DialogResult.OK)
				{
					return;
				}

				this.SelectedFile = dialog.SelectedPath;
			}
		}
	}
}
