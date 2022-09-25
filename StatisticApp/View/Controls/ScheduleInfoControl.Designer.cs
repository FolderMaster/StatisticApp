namespace StatisticApp.View.Controls
{
    partial class ScheduleInfoControl
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
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.LineSegmentsTextBox = new System.Windows.Forms.TextBox();
            this.PointsGroupBox = new System.Windows.Forms.GroupBox();
            this.LineSegmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.PointsGroupBox.SuspendLayout();
            this.LineSegmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointsTextBox.Location = new System.Drawing.Point(3, 16);
            this.PointsTextBox.Multiline = true;
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.ReadOnly = true;
            this.PointsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PointsTextBox.Size = new System.Drawing.Size(318, 618);
            this.PointsTextBox.TabIndex = 0;
            // 
            // LineSegmentsTextBox
            // 
            this.LineSegmentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineSegmentsTextBox.Location = new System.Drawing.Point(3, 16);
            this.LineSegmentsTextBox.Multiline = true;
            this.LineSegmentsTextBox.Name = "LineSegmentsTextBox";
            this.LineSegmentsTextBox.ReadOnly = true;
            this.LineSegmentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LineSegmentsTextBox.Size = new System.Drawing.Size(318, 618);
            this.LineSegmentsTextBox.TabIndex = 1;
            // 
            // PointsGroupBox
            // 
            this.PointsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsGroupBox.Controls.Add(this.PointsTextBox);
            this.PointsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PointsGroupBox.Name = "PointsGroupBox";
            this.PointsGroupBox.Size = new System.Drawing.Size(324, 637);
            this.PointsGroupBox.TabIndex = 4;
            this.PointsGroupBox.TabStop = false;
            this.PointsGroupBox.Text = "Points";
            // 
            // LineSegmentsGroupBox
            // 
            this.LineSegmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineSegmentsGroupBox.Controls.Add(this.LineSegmentsTextBox);
            this.LineSegmentsGroupBox.Location = new System.Drawing.Point(327, 0);
            this.LineSegmentsGroupBox.Name = "LineSegmentsGroupBox";
            this.LineSegmentsGroupBox.Size = new System.Drawing.Size(324, 637);
            this.LineSegmentsGroupBox.TabIndex = 5;
            this.LineSegmentsGroupBox.TabStop = false;
            this.LineSegmentsGroupBox.Text = "Line segments";
            // 
            // ScheduleInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LineSegmentsGroupBox);
            this.Controls.Add(this.PointsGroupBox);
            this.Name = "ScheduleInfoControl";
            this.Size = new System.Drawing.Size(651, 637);
            this.PointsGroupBox.ResumeLayout(false);
            this.PointsGroupBox.PerformLayout();
            this.LineSegmentsGroupBox.ResumeLayout(false);
            this.LineSegmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PointsTextBox;
        private System.Windows.Forms.TextBox LineSegmentsTextBox;
        private System.Windows.Forms.GroupBox PointsGroupBox;
        private System.Windows.Forms.GroupBox LineSegmentsGroupBox;
    }
}
