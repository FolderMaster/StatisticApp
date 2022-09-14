namespace StatisticApp.View.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilesGroupBox = new System.Windows.Forms.GroupBox();
            this.FileListControl = new StatisticApp.View.Controls.FileListControl();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.FilesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesGroupBox
            // 
            this.FilesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesGroupBox.Controls.Add(this.FileListControl);
            this.FilesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FilesGroupBox.Name = "FilesGroupBox";
            this.FilesGroupBox.Size = new System.Drawing.Size(560, 608);
            this.FilesGroupBox.TabIndex = 1;
            this.FilesGroupBox.TabStop = false;
            this.FilesGroupBox.Text = "Files";
            // 
            // FileListControl
            // 
            this.FileListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListControl.Location = new System.Drawing.Point(3, 16);
            this.FileListControl.Name = "FileListControl";
            this.FileListControl.SelectedIndex = -1;
            this.FileListControl.Size = new System.Drawing.Size(554, 589);
            this.FileListControl.TabIndex = 0;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayButton.Location = new System.Drawing.Point(497, 626);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.FilesGroupBox);
            this.Name = "MainForm";
            this.Text = "StatisticApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FilesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.FileListControl FileListControl;
        private System.Windows.Forms.GroupBox FilesGroupBox;
        private System.Windows.Forms.Button DisplayButton;
    }
}

