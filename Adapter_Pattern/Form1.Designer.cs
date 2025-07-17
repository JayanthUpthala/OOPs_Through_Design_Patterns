namespace AdapterPattern
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
            btnAdapterMath = new Button();
            btnAdapterMath2 = new Button();
            btnAdapter2Way = new Button();
            SuspendLayout();
            // 
            // btnAdapterMath
            // 
            btnAdapterMath.Location = new Point(101, 60);
            btnAdapterMath.Name = "btnAdapterMath";
            btnAdapterMath.Size = new Size(182, 43);
            btnAdapterMath.TabIndex = 0;
            btnAdapterMath.Text = "Adapter Math";
            btnAdapterMath.UseVisualStyleBackColor = true;
            btnAdapterMath.Click += btnAdapterMath_Click;
            // 
            // btnAdapterMath2
            // 
            btnAdapterMath2.Location = new Point(101, 149);
            btnAdapterMath2.Name = "btnAdapterMath2";
            btnAdapterMath2.Size = new Size(194, 39);
            btnAdapterMath2.TabIndex = 1;
            btnAdapterMath2.Text = "Adapter Math 2";
            btnAdapterMath2.UseVisualStyleBackColor = true;
            btnAdapterMath2.Click += btnAdapterMath2_Click;
            // 
            // btnAdapter2Way
            // 
            btnAdapter2Way.Location = new Point(101, 241);
            btnAdapter2Way.Name = "btnAdapter2Way";
            btnAdapter2Way.Size = new Size(194, 42);
            btnAdapter2Way.TabIndex = 2;
            btnAdapter2Way.Text = "Adapter 2Way";
            btnAdapter2Way.UseVisualStyleBackColor = true;
            btnAdapter2Way.Click += btnAdapter2Way_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdapter2Way);
            Controls.Add(btnAdapterMath2);
            Controls.Add(btnAdapterMath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdapterMath;
        private Button btnAdapterMath2;
        private Button btnAdapter2Way;
    }
}