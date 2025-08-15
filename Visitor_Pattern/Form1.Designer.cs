namespace VisitorPattern_1216098
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
            btnVisitor = new Button();
            btnComputePayMethod = new Button();
            btnAddOverTime = new Button();
            SuspendLayout();
            // 
            // btnVisitor
            // 
            btnVisitor.Location = new Point(248, 100);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(179, 44);
            btnVisitor.TabIndex = 0;
            btnVisitor.Text = "Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // btnComputePayMethod
            // 
            btnComputePayMethod.Location = new Point(248, 197);
            btnComputePayMethod.Name = "btnComputePayMethod";
            btnComputePayMethod.Size = new Size(179, 45);
            btnComputePayMethod.TabIndex = 1;
            btnComputePayMethod.Text = " Compute Pay Method";
            btnComputePayMethod.UseVisualStyleBackColor = true;
            btnComputePayMethod.Click += btnComputePayMethod_Click;
            // 
            // btnAddOverTime
            // 
            btnAddOverTime.Location = new Point(248, 284);
            btnAddOverTime.Name = "btnAddOverTime";
            btnAddOverTime.Size = new Size(179, 39);
            btnAddOverTime.TabIndex = 2;
            btnAddOverTime.Text = "Add OverTime";
            btnAddOverTime.UseVisualStyleBackColor = true;
            btnAddOverTime.Click += btnAddOverTime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddOverTime);
            Controls.Add(btnComputePayMethod);
            Controls.Add(btnVisitor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVisitor;
        private Button btnComputePayMethod;
        private Button btnAddOverTime;
    }
}