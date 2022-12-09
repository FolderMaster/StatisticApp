namespace PrimaryStatisticProcessingApp.Views.Controls
{
    partial class SampleControl
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
            this.SortedSampleGridView = new System.Windows.Forms.DataGridView();
            this.SortedSampleGroupBox = new System.Windows.Forms.GroupBox();
            this.MinGroupBox = new System.Windows.Forms.GroupBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.VariationalTableGroupBox = new System.Windows.Forms.GroupBox();
            this.VariationalTableGridView = new System.Windows.Forms.DataGridView();
            this.MaxGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.RangeGroupBox = new System.Windows.Forms.GroupBox();
            this.RangeTextBox = new System.Windows.Forms.TextBox();
            this.IntervalCountGroupBox = new System.Windows.Forms.GroupBox();
            this.IntervalCountTextBox = new System.Windows.Forms.TextBox();
            this.IntervalRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.IntervalRangeTextBox = new System.Windows.Forms.TextBox();
            this.MeanGroupBox = new System.Windows.Forms.GroupBox();
            this.MeanTextBox = new System.Windows.Forms.TextBox();
            this.MedianGroupBox = new System.Windows.Forms.GroupBox();
            this.MeadianTextBox = new System.Windows.Forms.TextBox();
            this.VarianceGroupBox = new System.Windows.Forms.GroupBox();
            this.VarianceTextBox = new System.Windows.Forms.TextBox();
            this.StandardDeviationGroupBox = new System.Windows.Forms.GroupBox();
            this.StandardDeviationTextBox = new System.Windows.Forms.TextBox();
            this.ThirdOrderMomentGroupBox = new System.Windows.Forms.GroupBox();
            this.ThirdOrderMomentTextBox = new System.Windows.Forms.TextBox();
            this.FourthOrderMomentGroupBox = new System.Windows.Forms.GroupBox();
            this.FourthOrderMomentTextBox = new System.Windows.Forms.TextBox();
            this.AsymmetryGroupBox = new System.Windows.Forms.GroupBox();
            this.AsymmetryTextBox = new System.Windows.Forms.TextBox();
            this.ExcessGroupBox = new System.Windows.Forms.GroupBox();
            this.ExcessTextBox = new System.Windows.Forms.TextBox();
            this.BarChartGroupBox = new System.Windows.Forms.GroupBox();
            this.BarChartDisplayControl = new PrimaryStatisticProcessingApp.View.Controls.DisplayControl();
            ((System.ComponentModel.ISupportInitialize)(this.SortedSampleGridView)).BeginInit();
            this.SortedSampleGroupBox.SuspendLayout();
            this.MinGroupBox.SuspendLayout();
            this.VariationalTableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariationalTableGridView)).BeginInit();
            this.MaxGroupBox.SuspendLayout();
            this.RangeGroupBox.SuspendLayout();
            this.IntervalCountGroupBox.SuspendLayout();
            this.IntervalRangeGroupBox.SuspendLayout();
            this.MeanGroupBox.SuspendLayout();
            this.MedianGroupBox.SuspendLayout();
            this.VarianceGroupBox.SuspendLayout();
            this.StandardDeviationGroupBox.SuspendLayout();
            this.ThirdOrderMomentGroupBox.SuspendLayout();
            this.FourthOrderMomentGroupBox.SuspendLayout();
            this.AsymmetryGroupBox.SuspendLayout();
            this.ExcessGroupBox.SuspendLayout();
            this.BarChartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortedSampleGridView
            // 
            this.SortedSampleGridView.AllowUserToAddRows = false;
            this.SortedSampleGridView.AllowUserToDeleteRows = false;
            this.SortedSampleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SortedSampleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortedSampleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortedSampleGridView.Location = new System.Drawing.Point(3, 16);
            this.SortedSampleGridView.Name = "SortedSampleGridView";
            this.SortedSampleGridView.ReadOnly = true;
            this.SortedSampleGridView.Size = new System.Drawing.Size(164, 670);
            this.SortedSampleGridView.TabIndex = 0;
            // 
            // SortedSampleGroupBox
            // 
            this.SortedSampleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SortedSampleGroupBox.Controls.Add(this.SortedSampleGridView);
            this.SortedSampleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SortedSampleGroupBox.Name = "SortedSampleGroupBox";
            this.SortedSampleGroupBox.Size = new System.Drawing.Size(170, 689);
            this.SortedSampleGroupBox.TabIndex = 1;
            this.SortedSampleGroupBox.TabStop = false;
            this.SortedSampleGroupBox.Text = "Sorted sample";
            // 
            // MinGroupBox
            // 
            this.MinGroupBox.Controls.Add(this.MinTextBox);
            this.MinGroupBox.Location = new System.Drawing.Point(176, 42);
            this.MinGroupBox.Name = "MinGroupBox";
            this.MinGroupBox.Size = new System.Drawing.Size(112, 40);
            this.MinGroupBox.TabIndex = 2;
            this.MinGroupBox.TabStop = false;
            this.MinGroupBox.Text = "Min";
            // 
            // MinTextBox
            // 
            this.MinTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinTextBox.Location = new System.Drawing.Point(3, 16);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.ReadOnly = true;
            this.MinTextBox.Size = new System.Drawing.Size(106, 20);
            this.MinTextBox.TabIndex = 0;
            // 
            // VariationalTableGroupBox
            // 
            this.VariationalTableGroupBox.Controls.Add(this.VariationalTableGridView);
            this.VariationalTableGroupBox.Location = new System.Drawing.Point(291, 0);
            this.VariationalTableGroupBox.Name = "VariationalTableGroupBox";
            this.VariationalTableGroupBox.Size = new System.Drawing.Size(170, 269);
            this.VariationalTableGroupBox.TabIndex = 7;
            this.VariationalTableGroupBox.TabStop = false;
            this.VariationalTableGroupBox.Text = "Variational table";
            // 
            // VariationalTableGridView
            // 
            this.VariationalTableGridView.AllowUserToAddRows = false;
            this.VariationalTableGridView.AllowUserToDeleteRows = false;
            this.VariationalTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VariationalTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VariationalTableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariationalTableGridView.Location = new System.Drawing.Point(3, 16);
            this.VariationalTableGridView.Name = "VariationalTableGridView";
            this.VariationalTableGridView.ReadOnly = true;
            this.VariationalTableGridView.Size = new System.Drawing.Size(164, 250);
            this.VariationalTableGridView.TabIndex = 0;
            // 
            // MaxGroupBox
            // 
            this.MaxGroupBox.Controls.Add(this.MaxTextBox);
            this.MaxGroupBox.Location = new System.Drawing.Point(176, 0);
            this.MaxGroupBox.Name = "MaxGroupBox";
            this.MaxGroupBox.Size = new System.Drawing.Size(112, 40);
            this.MaxGroupBox.TabIndex = 12;
            this.MaxGroupBox.TabStop = false;
            this.MaxGroupBox.Text = "Max";
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxTextBox.Location = new System.Drawing.Point(3, 16);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.ReadOnly = true;
            this.MaxTextBox.Size = new System.Drawing.Size(106, 20);
            this.MaxTextBox.TabIndex = 0;
            // 
            // RangeGroupBox
            // 
            this.RangeGroupBox.Controls.Add(this.RangeTextBox);
            this.RangeGroupBox.Location = new System.Drawing.Point(176, 91);
            this.RangeGroupBox.Name = "RangeGroupBox";
            this.RangeGroupBox.Size = new System.Drawing.Size(112, 40);
            this.RangeGroupBox.TabIndex = 13;
            this.RangeGroupBox.TabStop = false;
            this.RangeGroupBox.Text = "Range";
            // 
            // RangeTextBox
            // 
            this.RangeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RangeTextBox.Location = new System.Drawing.Point(3, 16);
            this.RangeTextBox.Name = "RangeTextBox";
            this.RangeTextBox.ReadOnly = true;
            this.RangeTextBox.Size = new System.Drawing.Size(106, 20);
            this.RangeTextBox.TabIndex = 0;
            // 
            // IntervalCountGroupBox
            // 
            this.IntervalCountGroupBox.Controls.Add(this.IntervalCountTextBox);
            this.IntervalCountGroupBox.Location = new System.Drawing.Point(176, 183);
            this.IntervalCountGroupBox.Name = "IntervalCountGroupBox";
            this.IntervalCountGroupBox.Size = new System.Drawing.Size(112, 40);
            this.IntervalCountGroupBox.TabIndex = 14;
            this.IntervalCountGroupBox.TabStop = false;
            this.IntervalCountGroupBox.Text = "Interval count";
            // 
            // IntervalCountTextBox
            // 
            this.IntervalCountTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntervalCountTextBox.Location = new System.Drawing.Point(3, 16);
            this.IntervalCountTextBox.Name = "IntervalCountTextBox";
            this.IntervalCountTextBox.ReadOnly = true;
            this.IntervalCountTextBox.Size = new System.Drawing.Size(106, 20);
            this.IntervalCountTextBox.TabIndex = 0;
            // 
            // IntervalRangeGroupBox
            // 
            this.IntervalRangeGroupBox.Controls.Add(this.IntervalRangeTextBox);
            this.IntervalRangeGroupBox.Location = new System.Drawing.Point(176, 229);
            this.IntervalRangeGroupBox.Name = "IntervalRangeGroupBox";
            this.IntervalRangeGroupBox.Size = new System.Drawing.Size(112, 40);
            this.IntervalRangeGroupBox.TabIndex = 15;
            this.IntervalRangeGroupBox.TabStop = false;
            this.IntervalRangeGroupBox.Text = "Interval range";
            // 
            // IntervalRangeTextBox
            // 
            this.IntervalRangeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntervalRangeTextBox.Location = new System.Drawing.Point(3, 16);
            this.IntervalRangeTextBox.Name = "IntervalRangeTextBox";
            this.IntervalRangeTextBox.ReadOnly = true;
            this.IntervalRangeTextBox.Size = new System.Drawing.Size(106, 20);
            this.IntervalRangeTextBox.TabIndex = 0;
            // 
            // MeanGroupBox
            // 
            this.MeanGroupBox.Controls.Add(this.MeanTextBox);
            this.MeanGroupBox.Location = new System.Drawing.Point(467, 0);
            this.MeanGroupBox.Name = "MeanGroupBox";
            this.MeanGroupBox.Size = new System.Drawing.Size(112, 40);
            this.MeanGroupBox.TabIndex = 16;
            this.MeanGroupBox.TabStop = false;
            this.MeanGroupBox.Text = "Mean";
            // 
            // MeanTextBox
            // 
            this.MeanTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeanTextBox.Location = new System.Drawing.Point(3, 16);
            this.MeanTextBox.Name = "MeanTextBox";
            this.MeanTextBox.ReadOnly = true;
            this.MeanTextBox.Size = new System.Drawing.Size(106, 20);
            this.MeanTextBox.TabIndex = 0;
            // 
            // MedianGroupBox
            // 
            this.MedianGroupBox.Controls.Add(this.MeadianTextBox);
            this.MedianGroupBox.Location = new System.Drawing.Point(176, 137);
            this.MedianGroupBox.Name = "MedianGroupBox";
            this.MedianGroupBox.Size = new System.Drawing.Size(112, 40);
            this.MedianGroupBox.TabIndex = 17;
            this.MedianGroupBox.TabStop = false;
            this.MedianGroupBox.Text = "Median";
            // 
            // MeadianTextBox
            // 
            this.MeadianTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeadianTextBox.Location = new System.Drawing.Point(3, 16);
            this.MeadianTextBox.Name = "MeadianTextBox";
            this.MeadianTextBox.ReadOnly = true;
            this.MeadianTextBox.Size = new System.Drawing.Size(106, 20);
            this.MeadianTextBox.TabIndex = 0;
            // 
            // VarianceGroupBox
            // 
            this.VarianceGroupBox.Controls.Add(this.VarianceTextBox);
            this.VarianceGroupBox.Location = new System.Drawing.Point(585, 0);
            this.VarianceGroupBox.Name = "VarianceGroupBox";
            this.VarianceGroupBox.Size = new System.Drawing.Size(112, 40);
            this.VarianceGroupBox.TabIndex = 18;
            this.VarianceGroupBox.TabStop = false;
            this.VarianceGroupBox.Text = "Variance";
            // 
            // VarianceTextBox
            // 
            this.VarianceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarianceTextBox.Location = new System.Drawing.Point(3, 16);
            this.VarianceTextBox.Name = "VarianceTextBox";
            this.VarianceTextBox.ReadOnly = true;
            this.VarianceTextBox.Size = new System.Drawing.Size(106, 20);
            this.VarianceTextBox.TabIndex = 0;
            // 
            // StandardDeviationGroupBox
            // 
            this.StandardDeviationGroupBox.Controls.Add(this.StandardDeviationTextBox);
            this.StandardDeviationGroupBox.Location = new System.Drawing.Point(585, 46);
            this.StandardDeviationGroupBox.Name = "StandardDeviationGroupBox";
            this.StandardDeviationGroupBox.Size = new System.Drawing.Size(112, 40);
            this.StandardDeviationGroupBox.TabIndex = 19;
            this.StandardDeviationGroupBox.TabStop = false;
            this.StandardDeviationGroupBox.Text = "Standard deviation";
            // 
            // StandardDeviationTextBox
            // 
            this.StandardDeviationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandardDeviationTextBox.Location = new System.Drawing.Point(3, 16);
            this.StandardDeviationTextBox.Name = "StandardDeviationTextBox";
            this.StandardDeviationTextBox.ReadOnly = true;
            this.StandardDeviationTextBox.Size = new System.Drawing.Size(106, 20);
            this.StandardDeviationTextBox.TabIndex = 0;
            // 
            // ThirdOrderMomentGroupBox
            // 
            this.ThirdOrderMomentGroupBox.Controls.Add(this.ThirdOrderMomentTextBox);
            this.ThirdOrderMomentGroupBox.Location = new System.Drawing.Point(467, 179);
            this.ThirdOrderMomentGroupBox.Name = "ThirdOrderMomentGroupBox";
            this.ThirdOrderMomentGroupBox.Size = new System.Drawing.Size(112, 40);
            this.ThirdOrderMomentGroupBox.TabIndex = 20;
            this.ThirdOrderMomentGroupBox.TabStop = false;
            this.ThirdOrderMomentGroupBox.Text = "Third order moment";
            // 
            // ThirdOrderMomentTextBox
            // 
            this.ThirdOrderMomentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdOrderMomentTextBox.Location = new System.Drawing.Point(3, 16);
            this.ThirdOrderMomentTextBox.Name = "ThirdOrderMomentTextBox";
            this.ThirdOrderMomentTextBox.ReadOnly = true;
            this.ThirdOrderMomentTextBox.Size = new System.Drawing.Size(106, 20);
            this.ThirdOrderMomentTextBox.TabIndex = 0;
            // 
            // FourthOrderMomentGroupBox
            // 
            this.FourthOrderMomentGroupBox.Controls.Add(this.FourthOrderMomentTextBox);
            this.FourthOrderMomentGroupBox.Location = new System.Drawing.Point(467, 225);
            this.FourthOrderMomentGroupBox.Name = "FourthOrderMomentGroupBox";
            this.FourthOrderMomentGroupBox.Size = new System.Drawing.Size(112, 40);
            this.FourthOrderMomentGroupBox.TabIndex = 21;
            this.FourthOrderMomentGroupBox.TabStop = false;
            this.FourthOrderMomentGroupBox.Text = "Fourth order moment";
            // 
            // FourthOrderMomentTextBox
            // 
            this.FourthOrderMomentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourthOrderMomentTextBox.Location = new System.Drawing.Point(3, 16);
            this.FourthOrderMomentTextBox.Name = "FourthOrderMomentTextBox";
            this.FourthOrderMomentTextBox.ReadOnly = true;
            this.FourthOrderMomentTextBox.Size = new System.Drawing.Size(106, 20);
            this.FourthOrderMomentTextBox.TabIndex = 0;
            // 
            // AsymmetryGroupBox
            // 
            this.AsymmetryGroupBox.Controls.Add(this.AsymmetryTextBox);
            this.AsymmetryGroupBox.Location = new System.Drawing.Point(585, 179);
            this.AsymmetryGroupBox.Name = "AsymmetryGroupBox";
            this.AsymmetryGroupBox.Size = new System.Drawing.Size(112, 40);
            this.AsymmetryGroupBox.TabIndex = 22;
            this.AsymmetryGroupBox.TabStop = false;
            this.AsymmetryGroupBox.Text = "Asymmetry";
            // 
            // AsymmetryTextBox
            // 
            this.AsymmetryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsymmetryTextBox.Location = new System.Drawing.Point(3, 16);
            this.AsymmetryTextBox.Name = "AsymmetryTextBox";
            this.AsymmetryTextBox.ReadOnly = true;
            this.AsymmetryTextBox.Size = new System.Drawing.Size(106, 20);
            this.AsymmetryTextBox.TabIndex = 0;
            // 
            // ExcessGroupBox
            // 
            this.ExcessGroupBox.Controls.Add(this.ExcessTextBox);
            this.ExcessGroupBox.Location = new System.Drawing.Point(585, 225);
            this.ExcessGroupBox.Name = "ExcessGroupBox";
            this.ExcessGroupBox.Size = new System.Drawing.Size(112, 40);
            this.ExcessGroupBox.TabIndex = 23;
            this.ExcessGroupBox.TabStop = false;
            this.ExcessGroupBox.Text = "Excess";
            // 
            // ExcessTextBox
            // 
            this.ExcessTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcessTextBox.Location = new System.Drawing.Point(3, 16);
            this.ExcessTextBox.Name = "ExcessTextBox";
            this.ExcessTextBox.ReadOnly = true;
            this.ExcessTextBox.Size = new System.Drawing.Size(106, 20);
            this.ExcessTextBox.TabIndex = 0;
            // 
            // BarChartGroupBox
            // 
            this.BarChartGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarChartGroupBox.Controls.Add(this.BarChartDisplayControl);
            this.BarChartGroupBox.Location = new System.Drawing.Point(176, 272);
            this.BarChartGroupBox.Name = "BarChartGroupBox";
            this.BarChartGroupBox.Size = new System.Drawing.Size(803, 417);
            this.BarChartGroupBox.TabIndex = 24;
            this.BarChartGroupBox.TabStop = false;
            this.BarChartGroupBox.Text = "Bar chart";
            // 
            // BarChartDisplayControl
            // 
            this.BarChartDisplayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarChartDisplayControl.LineXSize = 20;
            this.BarChartDisplayControl.LineYSize = 20;
            this.BarChartDisplayControl.Location = new System.Drawing.Point(3, 16);
            this.BarChartDisplayControl.Name = "BarChartDisplayControl";
            this.BarChartDisplayControl.Size = new System.Drawing.Size(797, 398);
            this.BarChartDisplayControl.TabIndex = 0;
            this.BarChartDisplayControl.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            // 
            // SampleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BarChartGroupBox);
            this.Controls.Add(this.ExcessGroupBox);
            this.Controls.Add(this.AsymmetryGroupBox);
            this.Controls.Add(this.FourthOrderMomentGroupBox);
            this.Controls.Add(this.ThirdOrderMomentGroupBox);
            this.Controls.Add(this.StandardDeviationGroupBox);
            this.Controls.Add(this.VarianceGroupBox);
            this.Controls.Add(this.MedianGroupBox);
            this.Controls.Add(this.MeanGroupBox);
            this.Controls.Add(this.IntervalRangeGroupBox);
            this.Controls.Add(this.IntervalCountGroupBox);
            this.Controls.Add(this.RangeGroupBox);
            this.Controls.Add(this.MaxGroupBox);
            this.Controls.Add(this.VariationalTableGroupBox);
            this.Controls.Add(this.MinGroupBox);
            this.Controls.Add(this.SortedSampleGroupBox);
            this.Name = "SampleControl";
            this.Size = new System.Drawing.Size(979, 689);
            ((System.ComponentModel.ISupportInitialize)(this.SortedSampleGridView)).EndInit();
            this.SortedSampleGroupBox.ResumeLayout(false);
            this.MinGroupBox.ResumeLayout(false);
            this.MinGroupBox.PerformLayout();
            this.VariationalTableGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VariationalTableGridView)).EndInit();
            this.MaxGroupBox.ResumeLayout(false);
            this.MaxGroupBox.PerformLayout();
            this.RangeGroupBox.ResumeLayout(false);
            this.RangeGroupBox.PerformLayout();
            this.IntervalCountGroupBox.ResumeLayout(false);
            this.IntervalCountGroupBox.PerformLayout();
            this.IntervalRangeGroupBox.ResumeLayout(false);
            this.IntervalRangeGroupBox.PerformLayout();
            this.MeanGroupBox.ResumeLayout(false);
            this.MeanGroupBox.PerformLayout();
            this.MedianGroupBox.ResumeLayout(false);
            this.MedianGroupBox.PerformLayout();
            this.VarianceGroupBox.ResumeLayout(false);
            this.VarianceGroupBox.PerformLayout();
            this.StandardDeviationGroupBox.ResumeLayout(false);
            this.StandardDeviationGroupBox.PerformLayout();
            this.ThirdOrderMomentGroupBox.ResumeLayout(false);
            this.ThirdOrderMomentGroupBox.PerformLayout();
            this.FourthOrderMomentGroupBox.ResumeLayout(false);
            this.FourthOrderMomentGroupBox.PerformLayout();
            this.AsymmetryGroupBox.ResumeLayout(false);
            this.AsymmetryGroupBox.PerformLayout();
            this.ExcessGroupBox.ResumeLayout(false);
            this.ExcessGroupBox.PerformLayout();
            this.BarChartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SortedSampleGridView;
        private System.Windows.Forms.GroupBox SortedSampleGroupBox;
        private System.Windows.Forms.GroupBox MinGroupBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.GroupBox VariationalTableGroupBox;
        private System.Windows.Forms.DataGridView VariationalTableGridView;
        private System.Windows.Forms.GroupBox MaxGroupBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.GroupBox RangeGroupBox;
        private System.Windows.Forms.TextBox RangeTextBox;
        private System.Windows.Forms.GroupBox IntervalCountGroupBox;
        private System.Windows.Forms.TextBox IntervalCountTextBox;
        private System.Windows.Forms.GroupBox IntervalRangeGroupBox;
        private System.Windows.Forms.TextBox IntervalRangeTextBox;
        private System.Windows.Forms.GroupBox MeanGroupBox;
        private System.Windows.Forms.TextBox MeanTextBox;
        private System.Windows.Forms.GroupBox MedianGroupBox;
        private System.Windows.Forms.TextBox MeadianTextBox;
        private System.Windows.Forms.GroupBox VarianceGroupBox;
        private System.Windows.Forms.TextBox VarianceTextBox;
        private System.Windows.Forms.GroupBox StandardDeviationGroupBox;
        private System.Windows.Forms.TextBox StandardDeviationTextBox;
        private System.Windows.Forms.GroupBox ThirdOrderMomentGroupBox;
        private System.Windows.Forms.TextBox ThirdOrderMomentTextBox;
        private System.Windows.Forms.GroupBox FourthOrderMomentGroupBox;
        private System.Windows.Forms.TextBox FourthOrderMomentTextBox;
        private System.Windows.Forms.GroupBox AsymmetryGroupBox;
        private System.Windows.Forms.TextBox AsymmetryTextBox;
        private System.Windows.Forms.GroupBox ExcessGroupBox;
        private System.Windows.Forms.TextBox ExcessTextBox;
        private System.Windows.Forms.GroupBox BarChartGroupBox;
        private View.Controls.DisplayControl BarChartDisplayControl;
    }
}
