namespace Abstraction_1216098
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
            btnTestAreaVolume = new Button();
            btnTestICloneable = new Button();
            btnTestICloneableAddr = new Button();
            btnTestComparable = new Button();
            SuspendLayout();
            // 
            // btnTestAreaVolume
            // 
            btnTestAreaVolume.Location = new Point(136, 55);
            btnTestAreaVolume.Name = "btnTestAreaVolume";
            btnTestAreaVolume.Size = new Size(244, 49);
            btnTestAreaVolume.TabIndex = 0;
            btnTestAreaVolume.Text = "Test Area Volume";
            btnTestAreaVolume.UseVisualStyleBackColor = true;
            btnTestAreaVolume.Click += btnTestAreaVolume_Click;
            // 
            // btnTestICloneable
            // 
            btnTestICloneable.Location = new Point(136, 125);
            btnTestICloneable.Name = "btnTestICloneable";
            btnTestICloneable.Size = new Size(244, 51);
            btnTestICloneable.TabIndex = 1;
            btnTestICloneable.Text = "Test ICloneable";
            btnTestICloneable.UseVisualStyleBackColor = true;
            btnTestICloneable.Click += btnTestICloneable_Click;
            // 
            // btnTestICloneableAddr
            // 
            btnTestICloneableAddr.Location = new Point(136, 201);
            btnTestICloneableAddr.Name = "btnTestICloneableAddr";
            btnTestICloneableAddr.Size = new Size(244, 53);
            btnTestICloneableAddr.TabIndex = 2;
            btnTestICloneableAddr.Text = "Test ICloneable Addr";
            btnTestICloneableAddr.UseVisualStyleBackColor = true;
            btnTestICloneableAddr.Click += btnTestICloneableAddr_Click;
            // 
            // btnTestComparable
            // 
            btnTestComparable.Location = new Point(136, 273);
            btnTestComparable.Name = "btnTestComparable";
            btnTestComparable.Size = new Size(244, 51);
            btnTestComparable.TabIndex = 3;
            btnTestComparable.Text = "Test Comparable";
            btnTestComparable.UseVisualStyleBackColor = true;
            btnTestComparable.Click += btnTestIComparable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTestComparable);
            Controls.Add(btnTestICloneableAddr);
            Controls.Add(btnTestICloneable);
            Controls.Add(btnTestAreaVolume);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTestAreaVolume;
        private Button btnTestICloneable;
        private Button btnTestICloneableAddr;
        private Button btnTestComparable;
    }
}