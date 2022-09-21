namespace StatisticApp.View.Forms
{
    partial class InfoForm
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
            this.ScheduleInfoControl = new StatisticApp.View.Controls.ScheduleInfoControl();
            this.SuspendLayout();
            // 
            // ScheduleInfoControl
            // 
            this.ScheduleInfoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleInfoControl.Location = new System.Drawing.Point(0, 0);
            this.ScheduleInfoControl.Name = "ScheduleInfoControl";
            this.ScheduleInfoControl.Size = new System.Drawing.Size(800, 633);
            this.ScheduleInfoControl.TabIndex = 0;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.ScheduleInfoControl);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ScheduleInfoControl ScheduleInfoControl;
    }
}