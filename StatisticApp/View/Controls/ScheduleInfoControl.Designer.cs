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
            this.PointsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsTextBox.Location = new System.Drawing.Point(0, 16);
            this.PointsTextBox.Multiline = true;
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.ReadOnly = true;
            this.PointsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PointsTextBox.Size = new System.Drawing.Size(518, 208);
            this.PointsTextBox.TabIndex = 0;
            // 
            // LineSegmentsTextBox
            // 
            this.LineSegmentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineSegmentsTextBox.Location = new System.Drawing.Point(0, 243);
            this.LineSegmentsTextBox.Multiline = true;
            this.LineSegmentsTextBox.Name = "LineSegmentsTextBox";
            this.LineSegmentsTextBox.ReadOnly = true;
            this.LineSegmentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LineSegmentsTextBox.Size = new System.Drawing.Size(518, 253);
            this.LineSegmentsTextBox.TabIndex = 1;
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Location = new System.Drawing.Point(-3, 0);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(39, 13);
            this.PointsLabel.TabIndex = 2;
            this.PointsLabel.Text = "Points:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LineSegments:";
            // 
            // ScheduleInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.LineSegmentsTextBox);
            this.Controls.Add(this.PointsTextBox);
            this.Name = "ScheduleInfoControl";
            this.Size = new System.Drawing.Size(518, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PointsTextBox;
        private System.Windows.Forms.TextBox LineSegmentsTextBox;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label label1;
    }
}
