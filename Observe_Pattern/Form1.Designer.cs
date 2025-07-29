namespace ObserverPattern_1216098
{
    partial class Form1
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
            btnObserverPattern = new Button();
            SuspendLayout();
            // 
            // btnObserverPattern
            // 
            btnObserverPattern.Location = new Point(235, 127);
            btnObserverPattern.Name = "btnObserverPattern";
            btnObserverPattern.Size = new Size(176, 55);
            btnObserverPattern.TabIndex = 0;
            btnObserverPattern.Text = "Test Observer Pattern";
            btnObserverPattern.UseVisualStyleBackColor = true;
            btnObserverPattern.Click += btnObserverPattern_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnObserverPattern);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnObserverPattern;
    }
}