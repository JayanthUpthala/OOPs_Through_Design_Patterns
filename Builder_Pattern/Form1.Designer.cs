namespace BuilderPattern_1216098
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
            btnTestGradeReport = new Button();
            btnProgressReport = new Button();
            SuspendLayout();
            // 
            // btnTestGradeReport
            // 
            btnTestGradeReport.Location = new Point(230, 93);
            btnTestGradeReport.Name = "btnTestGradeReport";
            btnTestGradeReport.Size = new Size(197, 52);
            btnTestGradeReport.TabIndex = 0;
            btnTestGradeReport.Text = "Test Grade Report";
            btnTestGradeReport.UseVisualStyleBackColor = true;
            btnTestGradeReport.Click += btnTestGradeReport_Click;
            // 
            // btnProgressReport
            // 
            btnProgressReport.Location = new Point(230, 192);
            btnProgressReport.Name = "btnProgressReport";
            btnProgressReport.Size = new Size(197, 41);
            btnProgressReport.TabIndex = 1;
            btnProgressReport.Text = "Progress Report";
            btnProgressReport.UseVisualStyleBackColor = true;
            btnProgressReport.Click += btnProgressReport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProgressReport);
            Controls.Add(btnTestGradeReport);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTestGradeReport;
        private Button btnProgressReport;
    }
}