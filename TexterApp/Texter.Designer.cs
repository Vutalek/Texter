namespace TexterApp
{
    partial class Texter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFile = new Button();
            AppName = new Label();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            fileName = new TextBox();
            Render = new Button();
            browseDirectory = new Button();
            directoryName = new TextBox();
            shortName = new TextBox();
            label1 = new Label();
            done = new Label();
            SuspendLayout();
            // 
            // openFile
            // 
            openFile.BackColor = Color.Purple;
            openFile.FlatAppearance.BorderColor = SystemColors.ControlText;
            openFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 192);
            openFile.FlatStyle = FlatStyle.Flat;
            openFile.ForeColor = SystemColors.Control;
            openFile.Location = new Point(12, 248);
            openFile.Name = "openFile";
            openFile.Size = new Size(175, 92);
            openFile.TabIndex = 0;
            openFile.Text = "Open File";
            openFile.UseVisualStyleBackColor = false;
            openFile.Click += openFile_Click;
            // 
            // AppName
            // 
            AppName.AutoSize = true;
            AppName.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AppName.ForeColor = SystemColors.Control;
            AppName.Location = new Point(12, 9);
            AppName.Name = "AppName";
            AppName.Size = new Size(191, 81);
            AppName.TabIndex = 1;
            AppName.Text = "Texter";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileName
            // 
            fileName.Location = new Point(193, 248);
            fileName.Name = "fileName";
            fileName.ReadOnly = true;
            fileName.Size = new Size(232, 27);
            fileName.TabIndex = 2;
            // 
            // Render
            // 
            Render.BackColor = Color.Purple;
            Render.FlatAppearance.BorderColor = SystemColors.ControlText;
            Render.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 192);
            Render.FlatStyle = FlatStyle.Flat;
            Render.ForeColor = SystemColors.Control;
            Render.Location = new Point(485, 248);
            Render.Name = "Render";
            Render.Size = new Size(175, 92);
            Render.TabIndex = 3;
            Render.Text = "Render";
            Render.UseVisualStyleBackColor = false;
            Render.Click += Render_Click;
            // 
            // browseDirectory
            // 
            browseDirectory.BackColor = Color.Purple;
            browseDirectory.FlatAppearance.BorderColor = SystemColors.ControlText;
            browseDirectory.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 192);
            browseDirectory.FlatStyle = FlatStyle.Flat;
            browseDirectory.ForeColor = SystemColors.Control;
            browseDirectory.Location = new Point(12, 106);
            browseDirectory.Name = "browseDirectory";
            browseDirectory.Size = new Size(175, 92);
            browseDirectory.TabIndex = 4;
            browseDirectory.Text = "Browse Directory";
            browseDirectory.UseVisualStyleBackColor = false;
            browseDirectory.Click += browseDirectory_Click;
            // 
            // directoryName
            // 
            directoryName.Location = new Point(193, 106);
            directoryName.Name = "directoryName";
            directoryName.ReadOnly = true;
            directoryName.Size = new Size(232, 27);
            directoryName.TabIndex = 5;
            // 
            // shortName
            // 
            shortName.Location = new Point(485, 106);
            shortName.Name = "shortName";
            shortName.Size = new Size(175, 27);
            shortName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(485, 52);
            label1.Name = "label1";
            label1.Size = new Size(137, 38);
            label1.TabIndex = 7;
            label1.Text = "File name";
            // 
            // done
            // 
            done.AutoSize = true;
            done.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            done.ForeColor = SystemColors.Control;
            done.Location = new Point(485, 175);
            done.Name = "done";
            done.Size = new Size(92, 38);
            done.TabIndex = 8;
            done.Text = "Done!";
            done.Visible = false;
            // 
            // Texter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(673, 353);
            Controls.Add(done);
            Controls.Add(label1);
            Controls.Add(shortName);
            Controls.Add(directoryName);
            Controls.Add(browseDirectory);
            Controls.Add(Render);
            Controls.Add(fileName);
            Controls.Add(AppName);
            Controls.Add(openFile);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Texter";
            Opacity = 0.95D;
            ShowIcon = false;
            Text = "Texter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFile;
        private Label AppName;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox fileName;
        private Button Render;
        private Button browseDirectory;
        private TextBox directoryName;
        private TextBox shortName;
        private Label label1;
        private Label done;
    }
}
