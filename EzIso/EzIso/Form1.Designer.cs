namespace EzIso
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
			this.labelInputFolder = new System.Windows.Forms.Label();
			this.buttonBrowseInput = new System.Windows.Forms.Button();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.buttonBrowseOutput = new System.Windows.Forms.Button();
			this.labelOutputFile = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.labelImageName = new System.Windows.Forms.Label();
			this.textBoxImageName = new System.Windows.Forms.TextBox();
			this.checkBoxJoliet = new System.Windows.Forms.CheckBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelInputFolder
			// 
			this.labelInputFolder.AutoSize = true;
			this.labelInputFolder.Location = new System.Drawing.Point(12, 17);
			this.labelInputFolder.Name = "labelInputFolder";
			this.labelInputFolder.Size = new System.Drawing.Size(66, 13);
			this.labelInputFolder.TabIndex = 0;
			this.labelInputFolder.Text = "Input Folder:";
			// 
			// buttonBrowseInput
			// 
			this.buttonBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseInput.Location = new System.Drawing.Point(461, 12);
			this.buttonBrowseInput.Name = "buttonBrowseInput";
			this.buttonBrowseInput.Size = new System.Drawing.Size(24, 23);
			this.buttonBrowseInput.TabIndex = 2;
			this.buttonBrowseInput.Text = "...";
			this.buttonBrowseInput.UseVisualStyleBackColor = true;
			// 
			// textBoxInput
			// 
			this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInput.Location = new System.Drawing.Point(109, 14);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(346, 20);
			this.textBoxInput.TabIndex = 1;
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutput.Location = new System.Drawing.Point(109, 43);
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.Size = new System.Drawing.Size(346, 20);
			this.textBoxOutput.TabIndex = 4;
			// 
			// buttonBrowseOutput
			// 
			this.buttonBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseOutput.Location = new System.Drawing.Point(461, 41);
			this.buttonBrowseOutput.Name = "buttonBrowseOutput";
			this.buttonBrowseOutput.Size = new System.Drawing.Size(24, 23);
			this.buttonBrowseOutput.TabIndex = 5;
			this.buttonBrowseOutput.Text = "...";
			this.buttonBrowseOutput.UseVisualStyleBackColor = true;
			// 
			// labelOutputFile
			// 
			this.labelOutputFile.AutoSize = true;
			this.labelOutputFile.Location = new System.Drawing.Point(12, 46);
			this.labelOutputFile.Name = "labelOutputFile";
			this.labelOutputFile.Size = new System.Drawing.Size(61, 13);
			this.labelOutputFile.TabIndex = 3;
			this.labelOutputFile.Text = "Output File:";
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStart.Location = new System.Drawing.Point(410, 150);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 10;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// labelImageName
			// 
			this.labelImageName.AutoSize = true;
			this.labelImageName.Location = new System.Drawing.Point(12, 75);
			this.labelImageName.Name = "labelImageName";
			this.labelImageName.Size = new System.Drawing.Size(70, 13);
			this.labelImageName.TabIndex = 6;
			this.labelImageName.Text = "Image Name:";
			// 
			// textBoxImageName
			// 
			this.textBoxImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxImageName.Location = new System.Drawing.Point(109, 72);
			this.textBoxImageName.Name = "textBoxImageName";
			this.textBoxImageName.Size = new System.Drawing.Size(346, 20);
			this.textBoxImageName.TabIndex = 7;
			// 
			// checkBoxJoliet
			// 
			this.checkBoxJoliet.AutoSize = true;
			this.checkBoxJoliet.Location = new System.Drawing.Point(109, 98);
			this.checkBoxJoliet.Name = "checkBoxJoliet";
			this.checkBoxJoliet.Size = new System.Drawing.Size(182, 17);
			this.checkBoxJoliet.TabIndex = 8;
			this.checkBoxJoliet.Text = "Use Joliet File System Extensions";
			this.checkBoxJoliet.UseVisualStyleBackColor = true;
			// 
			// labelStatus
			// 
			this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelStatus.Location = new System.Drawing.Point(12, 118);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(392, 58);
			this.labelStatus.TabIndex = 9;
			this.labelStatus.Text = "Ready";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 185);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.checkBoxJoliet);
			this.Controls.Add(this.labelImageName);
			this.Controls.Add(this.textBoxImageName);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.labelOutputFile);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.buttonBrowseOutput);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.buttonBrowseInput);
			this.Controls.Add(this.labelInputFolder);
			this.Name = "Form1";
			this.Text = "EzIso";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelInputFolder;
		private System.Windows.Forms.Button buttonBrowseInput;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Button buttonBrowseOutput;
		private System.Windows.Forms.Label labelOutputFile;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label labelImageName;
		private System.Windows.Forms.TextBox textBoxImageName;
		private System.Windows.Forms.CheckBox checkBoxJoliet;
		private System.Windows.Forms.Label labelStatus;

	}
}

