namespace ProxyPattern
{
    public partial class Form1 : Form
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
            cmbPictures = new ComboBox();
            lblShortName = new Label();
            lblCategory = new Label();
            pic1 = new PictureBox();
            btnShowImage = new Button();
            lblWidth = new Label();
            lblHeight = new Label();
            btnProtectionProxy = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // cmbPictures
            // 
            cmbPictures.FormattingEnabled = true;
            cmbPictures.Location = new Point(12, 34);
            cmbPictures.Name = "cmbPictures";
            cmbPictures.Size = new Size(182, 33);
            cmbPictures.TabIndex = 0;
            cmbPictures.SelectedIndexChanged += cmbPictures_SelectedIndexChanged;
            // 
            // lblShortName
            // 
            lblShortName.AutoSize = true;
            lblShortName.Location = new Point(37, 105);
            lblShortName.Name = "lblShortName";
            lblShortName.Size = new Size(59, 25);
            lblShortName.TabIndex = 1;
            lblShortName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(37, 149);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(38, 25);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Cat";
            // 
            // pic1
            // 
            pic1.Location = new Point(227, 34);
            pic1.Name = "pic1";
            pic1.Size = new Size(546, 328);
            pic1.TabIndex = 3;
            pic1.TabStop = false;
            // 
            // btnShowImage
            // 
            btnShowImage.Location = new Point(37, 196);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(112, 34);
            btnShowImage.TabIndex = 4;
            btnShowImage.Text = "ShowImage";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(259, 365);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(0, 25);
            lblWidth.TabIndex = 5;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(461, 365);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(0, 25);
            lblHeight.TabIndex = 6;
            // 
            // btnProtectionProxy
            // 
            btnProtectionProxy.Location = new Point(37, 259);
            btnProtectionProxy.Name = "btnProtectionProxy";
            btnProtectionProxy.Size = new Size(112, 34);
            btnProtectionProxy.TabIndex = 7;
            btnProtectionProxy.Text = "ProtectionProxy";
            btnProtectionProxy.UseVisualStyleBackColor = true;
            btnProtectionProxy.Click += btnProtectionProxy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProtectionProxy);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Controls.Add(btnShowImage);
            Controls.Add(pic1);
            Controls.Add(lblCategory);
            Controls.Add(lblShortName);
            Controls.Add(cmbPictures);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPictures;
        private Label lblShortName;
        private Label lblCategory;
        private PictureBox pic1;
        private Button btnShowImage;
        private Label lblWidth;
        private Label lblHeight;
        private Button btnProtectionProxy;
    }
}