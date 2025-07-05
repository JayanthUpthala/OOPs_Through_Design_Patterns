namespace Generics_1216098
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
            btnExchange = new Button();
            btnGenericClass = new Button();
            btnInitArray = new Button();
            btnFindMaxScoreStudent = new Button();
            btnCompareGeneric = new Button();
            btnDictionary = new Button();
            SuspendLayout();
            // 
            // btnExchange
            // 
            btnExchange.Location = new Point(153, 52);
            btnExchange.Name = "btnExchange";
            btnExchange.Size = new Size(265, 46);
            btnExchange.TabIndex = 0;
            btnExchange.Text = "Exchange";
            btnExchange.UseVisualStyleBackColor = true;
            btnExchange.Click += btnExchange_Click;
            // 
            // btnGenericClass
            // 
            btnGenericClass.Location = new Point(153, 116);
            btnGenericClass.Name = "btnGenericClass";
            btnGenericClass.Size = new Size(265, 47);
            btnGenericClass.TabIndex = 1;
            btnGenericClass.Text = "GenericClass";
            btnGenericClass.UseVisualStyleBackColor = true;
            btnGenericClass.Click += btnGenericClass_Click;
            // 
            // btnInitArray
            // 
            btnInitArray.Location = new Point(153, 182);
            btnInitArray.Name = "btnInitArray";
            btnInitArray.Size = new Size(265, 41);
            btnInitArray.TabIndex = 2;
            btnInitArray.Text = "Test Init Array";
            btnInitArray.UseVisualStyleBackColor = true;
            btnInitArray.Click += btnInitArray_Click;
            // 
            // btnFindMaxScoreStudent
            // 
            btnFindMaxScoreStudent.Location = new Point(153, 243);
            btnFindMaxScoreStudent.Name = "btnFindMaxScoreStudent";
            btnFindMaxScoreStudent.Size = new Size(265, 41);
            btnFindMaxScoreStudent.TabIndex = 3;
            btnFindMaxScoreStudent.Text = "Find Max Score Student";
            btnFindMaxScoreStudent.UseVisualStyleBackColor = true;
            btnFindMaxScoreStudent.Click += btnFindMaxScoreStudent_Click;
            // 
            // btnCompareGeneric
            // 
            btnCompareGeneric.Location = new Point(153, 303);
            btnCompareGeneric.Name = "btnCompareGeneric";
            btnCompareGeneric.Size = new Size(265, 46);
            btnCompareGeneric.TabIndex = 4;
            btnCompareGeneric.Text = "Compare Generic";
            btnCompareGeneric.UseVisualStyleBackColor = true;
            btnCompareGeneric.Click += btnCompareGeneric_Click;
            // 
            // btnDictionary
            // 
            btnDictionary.Location = new Point(153, 369);
            btnDictionary.Name = "btnDictionary";
            btnDictionary.Size = new Size(265, 37);
            btnDictionary.TabIndex = 5;
            btnDictionary.Text = "Dictionary";
            btnDictionary.UseVisualStyleBackColor = true;
            btnDictionary.Click += btnDictionary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDictionary);
            Controls.Add(btnCompareGeneric);
            Controls.Add(btnFindMaxScoreStudent);
            Controls.Add(btnInitArray);
            Controls.Add(btnGenericClass);
            Controls.Add(btnExchange);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExchange;
        private Button btnGenericClass;
        private Button btnInitArray;
        private Button btnFindMaxScoreStudent;
        private Button btnCompareGeneric;
        private Button btnDictionary;
    }
}