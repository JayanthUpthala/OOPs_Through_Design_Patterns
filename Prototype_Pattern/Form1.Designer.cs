namespace PrototypePattern_1216098
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
            btnPrototype = new Button();
            btnPrototypeManage = new Button();
            SuspendLayout();
            // 
            // btnPrototype
            // 
            btnPrototype.Location = new Point(262, 89);
            btnPrototype.Name = "btnPrototype";
            btnPrototype.Size = new Size(176, 47);
            btnPrototype.TabIndex = 0;
            btnPrototype.Text = "Prototype";
            btnPrototype.UseVisualStyleBackColor = true;
            btnPrototype.Click += btnPrototype_Click;
            // 
            // btnPrototypeManage
            // 
            btnPrototypeManage.Location = new Point(262, 196);
            btnPrototypeManage.Name = "btnPrototypeManage";
            btnPrototypeManage.Size = new Size(176, 48);
            btnPrototypeManage.TabIndex = 1;
            btnPrototypeManage.Text = "Prototype Manage";
            btnPrototypeManage.UseVisualStyleBackColor = true;
            btnPrototypeManage.Click += btnPrototypeManage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrototypeManage);
            Controls.Add(btnPrototype);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrototype;
        private Button btnPrototypeManage;
    }
}