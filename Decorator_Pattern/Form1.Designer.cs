namespace DecoratorPattern_1216098
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
            btnDecoratorSample = new Button();
            btnSubClassing = new Button();
            SuspendLayout();
            // 
            // btnDecoratorSample
            // 
            btnDecoratorSample.Location = new Point(209, 98);
            btnDecoratorSample.Name = "btnDecoratorSample";
            btnDecoratorSample.Size = new Size(187, 49);
            btnDecoratorSample.TabIndex = 0;
            btnDecoratorSample.Text = "Decorator Sample";
            btnDecoratorSample.UseVisualStyleBackColor = true;
            btnDecoratorSample.Click += btnDecoratorSample_Click;
            // 
            // btnSubClassing
            // 
            btnSubClassing.Location = new Point(209, 198);
            btnSubClassing.Name = "btnSubClassing";
            btnSubClassing.Size = new Size(187, 45);
            btnSubClassing.TabIndex = 1;
            btnSubClassing.Text = "SubClassing";
            btnSubClassing.UseVisualStyleBackColor = true;
            btnSubClassing.Click += btnSubClassing_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubClassing);
            Controls.Add(btnDecoratorSample);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDecoratorSample;
        private Button btnSubClassing;
    }
}