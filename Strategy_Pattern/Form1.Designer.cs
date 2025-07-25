namespace StrategyPattern
{
    partial class Form1
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
            this.btnStrategySort = new System.Windows.Forms.Button();
            this.btnSrategySort2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStrategySort
            // 
            this.btnStrategySort.Location = new System.Drawing.Point(310, 50);
            this.btnStrategySort.Name = "btnStrategySort";
            this.btnStrategySort.Size = new System.Drawing.Size(150, 45);
            this.btnStrategySort.TabIndex = 0;
            this.btnStrategySort.Text = "Strategy Pattern Student";
            this.btnStrategySort.UseVisualStyleBackColor = true;
            this.btnStrategySort.Click += new System.EventHandler(this.btnStrategySort_Click);
            // 
            // btnSrategySort2
            // 
            this.btnSrategySort2.Location = new System.Drawing.Point(310, 112);
            this.btnSrategySort2.Name = "btnSrategySort2";
            this.btnSrategySort2.Size = new System.Drawing.Size(150, 40);
            this.btnSrategySort2.TabIndex = 1;
            this.btnSrategySort2.Text = "Strategy University";
            this.btnSrategySort2.UseVisualStyleBackColor = true;
            this.btnSrategySort2.Click += new System.EventHandler(this.btnSrategySort2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSrategySort2);
            this.Controls.Add(this.btnStrategySort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStrategySort;
        private System.Windows.Forms.Button btnSrategySort2;
    }
}

