namespace PrimaryStatisticProcessingApp.Views.Tabs
{
    partial class MainTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadButton = new System.Windows.Forms.Button();
            this.SampleInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SampleControl = new PrimaryStatisticProcessingApp.Views.Controls.SampleControl();
            this.SampleListGroupBox = new System.Windows.Forms.GroupBox();
            this.FilesGroupBox = new System.Windows.Forms.GroupBox();
            this.SampleListControl = new PrimaryStatisticProcessingApp.Views.Controls.SampleListControl();
            this.FileListControl = new PrimaryStatisticProcessingApp.Views.Controls.FileListControl();
            this.SampleInfoGroupBox.SuspendLayout();
            this.SampleListGroupBox.SuspendLayout();
            this.FilesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(171, 325);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // SampleInfoGroupBox
            // 
            this.SampleInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SampleInfoGroupBox.Controls.Add(this.SampleControl);
            this.SampleInfoGroupBox.Location = new System.Drawing.Point(258, 0);
            this.SampleInfoGroupBox.Name = "SampleInfoGroupBox";
            this.SampleInfoGroupBox.Size = new System.Drawing.Size(704, 526);
            this.SampleInfoGroupBox.TabIndex = 4;
            this.SampleInfoGroupBox.TabStop = false;
            this.SampleInfoGroupBox.Text = "Sample info";
            // 
            // SampleControl
            // 
            this.SampleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleControl.Location = new System.Drawing.Point(3, 16);
            this.SampleControl.Name = "SampleControl";
            this.SampleControl.Size = new System.Drawing.Size(698, 507);
            this.SampleControl.TabIndex = 3;
            // 
            // SampleListGroupBox
            // 
            this.SampleListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SampleListGroupBox.Controls.Add(this.SampleListControl);
            this.SampleListGroupBox.Location = new System.Drawing.Point(0, 360);
            this.SampleListGroupBox.Name = "SampleListGroupBox";
            this.SampleListGroupBox.Size = new System.Drawing.Size(252, 166);
            this.SampleListGroupBox.TabIndex = 5;
            this.SampleListGroupBox.TabStop = false;
            this.SampleListGroupBox.Text = "Sample list";
            // 
            // FilesGroupBox
            // 
            this.FilesGroupBox.Controls.Add(this.FileListControl);
            this.FilesGroupBox.Controls.Add(this.ReadButton);
            this.FilesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilesGroupBox.Name = "FilesGroupBox";
            this.FilesGroupBox.Size = new System.Drawing.Size(252, 354);
            this.FilesGroupBox.TabIndex = 6;
            this.FilesGroupBox.TabStop = false;
            this.FilesGroupBox.Text = "Files";
            // 
            // SampleListControl
            // 
            this.SampleListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleListControl.Location = new System.Drawing.Point(3, 16);
            this.SampleListControl.Name = "SampleListControl";
            this.SampleListControl.Size = new System.Drawing.Size(246, 147);
            this.SampleListControl.TabIndex = 4;
            this.SampleListControl.SelectedSampleChanged += new System.EventHandler(this.SampleListControl_SelectedSampleChanged);
            // 
            // FileListControl
            // 
            this.FileListControl.Location = new System.Drawing.Point(6, 19);
            this.FileListControl.Name = "FileListControl";
            this.FileListControl.SelectedIndex = -1;
            this.FileListControl.Size = new System.Drawing.Size(240, 300);
            this.FileListControl.TabIndex = 1;
            // 
            // MainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilesGroupBox);
            this.Controls.Add(this.SampleListGroupBox);
            this.Controls.Add(this.SampleInfoGroupBox);
            this.Name = "MainTab";
            this.Size = new System.Drawing.Size(962, 526);
            this.SampleInfoGroupBox.ResumeLayout(false);
            this.SampleListGroupBox.ResumeLayout(false);
            this.FilesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.GroupBox SampleInfoGroupBox;
        private Controls.SampleControl SampleControl;
        private System.Windows.Forms.GroupBox SampleListGroupBox;
        private Controls.SampleListControl SampleListControl;
        private System.Windows.Forms.GroupBox FilesGroupBox;
        private Controls.FileListControl FileListControl;
    }
}
