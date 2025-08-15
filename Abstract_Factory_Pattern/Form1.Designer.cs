namespace AbstractFactoryPattern_1216098
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
            btnAbstractFactoryUS = new Button();
            btnAbstactFactoryCanada = new Button();
            SuspendLayout();
            // 
            // btnAbstractFactoryUS
            // 
            btnAbstractFactoryUS.Location = new Point(241, 90);
            btnAbstractFactoryUS.Name = "btnAbstractFactoryUS";
            btnAbstractFactoryUS.Size = new Size(204, 48);
            btnAbstractFactoryUS.TabIndex = 0;
            btnAbstractFactoryUS.Text = "Abstract Factory US";
            btnAbstractFactoryUS.UseVisualStyleBackColor = true;
            btnAbstractFactoryUS.Click += btnAbstractFactoryUS_Click;
            // 
            // btnAbstactFactoryCanada
            // 
            btnAbstactFactoryCanada.Location = new Point(241, 184);
            btnAbstactFactoryCanada.Name = "btnAbstactFactoryCanada";
            btnAbstactFactoryCanada.Size = new Size(204, 50);
            btnAbstactFactoryCanada.TabIndex = 1;
            btnAbstactFactoryCanada.Text = "Abstract Factory Canda";
            btnAbstactFactoryCanada.UseVisualStyleBackColor = true;
            btnAbstactFactoryCanada.Click += btnAbstactFactoryCanada_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbstactFactoryCanada);
            Controls.Add(btnAbstractFactoryUS);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbstractFactoryUS;
        private Button btnAbstactFactoryCanada;
    }
}