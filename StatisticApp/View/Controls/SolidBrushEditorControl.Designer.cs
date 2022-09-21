namespace StatisticApp.View.Controls
{
    partial class SolidBrushEditorControl
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
            this.ColorEditorControl = new StatisticApp.View.Controls.ColorEditorControl();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorEditorControl
            // 
            this.ColorEditorControl.Color = System.Drawing.Color.Empty;
            this.ColorEditorControl.Location = new System.Drawing.Point(37, 0);
            this.ColorEditorControl.Name = "ColorEditorControl";
            this.ColorEditorControl.Size = new System.Drawing.Size(75, 23);
            this.ColorEditorControl.TabIndex = 1;
            this.ColorEditorControl.ColorChanged += new System.EventHandler(this.ColorEditorControl_ColorChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(-3, 5);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color:";
            // 
            // SolidBrushEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.ColorEditorControl);
            this.Name = "SolidBrushEditorControl";
            this.Size = new System.Drawing.Size(112, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorEditorControl ColorEditorControl;
        private System.Windows.Forms.Label ColorLabel;
    }
}
