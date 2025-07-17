namespace BridgePattern
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
            btnBridgeBasic = new Button();
            btnRefinedAbstraction = new Button();
            SuspendLayout();
            // 
            // btnBridgeBasic
            // 
            btnBridgeBasic.Location = new Point(177, 53);
            btnBridgeBasic.Margin = new Padding(2, 2, 2, 2);
            btnBridgeBasic.Name = "btnBridgeBasic";
            btnBridgeBasic.Size = new Size(174, 38);
            btnBridgeBasic.TabIndex = 0;
            btnBridgeBasic.Text = "Bridge Basic";
            btnBridgeBasic.UseVisualStyleBackColor = true;
            btnBridgeBasic.Click += btnBridgeBasic_Click;
            // 
            // btnRefinedAbstraction
            // 
            btnRefinedAbstraction.Location = new Point(177, 142);
            btnRefinedAbstraction.Margin = new Padding(2, 2, 2, 2);
            btnRefinedAbstraction.Name = "btnRefinedAbstraction";
            btnRefinedAbstraction.Size = new Size(174, 36);
            btnRefinedAbstraction.TabIndex = 1;
            btnRefinedAbstraction.Text = "Refined Abstraction";
            btnRefinedAbstraction.UseVisualStyleBackColor = true;
            btnRefinedAbstraction.Click += btnRefinedAbstraction_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnRefinedAbstraction);
            Controls.Add(btnBridgeBasic);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBridgeBasic;
        private Button btnRefinedAbstraction;
    }
}