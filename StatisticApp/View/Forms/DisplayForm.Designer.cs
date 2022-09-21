﻿namespace StatisticApp.View.Forms
{
    partial class DisplayForm
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
            this.DisplayControl = new StatisticApp.View.Controls.DisplayControl();
            this.SuspendLayout();
            // 
            // DisplayControl
            // 
            this.DisplayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayControl.Location = new System.Drawing.Point(0, 0);
            this.DisplayControl.Name = "DisplayControl";
            this.DisplayControl.Size = new System.Drawing.Size(1035, 352);
            this.DisplayControl.TabIndex = 0;
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 352);
            this.Controls.Add(this.DisplayControl);
            this.Name = "DisplayForm";
            this.Text = "Display";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DisplayControl DisplayControl;
    }
}