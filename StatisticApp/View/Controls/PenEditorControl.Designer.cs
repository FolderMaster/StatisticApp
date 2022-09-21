namespace StatisticApp.View.Controls
{
    partial class PenEditorControl
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
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorEditorControl = new StatisticApp.View.Controls.ColorEditorControl();
            this.SuspendLayout();
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(41, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 1;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(-3, 5);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(147, 5);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color:";
            // 
            // ColorEditorControl
            // 
            this.ColorEditorControl.Color = System.Drawing.Color.Empty;
            this.ColorEditorControl.Location = new System.Drawing.Point(187, 0);
            this.ColorEditorControl.Name = "ColorEditorControl";
            this.ColorEditorControl.Size = new System.Drawing.Size(75, 23);
            this.ColorEditorControl.TabIndex = 4;
            this.ColorEditorControl.ColorChanged += new System.EventHandler(this.ColorEditorControl_ColorChanged);
            // 
            // PenEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorEditorControl);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Name = "PenEditorControl";
            this.Size = new System.Drawing.Size(262, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label ColorLabel;
        private ColorEditorControl ColorEditorControl;
    }
}
