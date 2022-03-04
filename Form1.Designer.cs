namespace CMS_Blog
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
            this.dtpBlogPostDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.lblFontColor = new System.Windows.Forms.Label();
            this.cmbBackColor = new System.Windows.Forms.ComboBox();
            this.cmbTextColor = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.rtbBlogPost = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBlogPostDate
            // 
            this.dtpBlogPostDate.Location = new System.Drawing.Point(672, 31);
            this.dtpBlogPostDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBlogPostDate.Name = "dtpBlogPostDate";
            this.dtpBlogPostDate.Size = new System.Drawing.Size(383, 35);
            this.dtpBlogPostDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblBackgroundColor);
            this.panel1.Controls.Add(this.lblFontColor);
            this.panel1.Controls.Add(this.cmbBackColor);
            this.panel1.Controls.Add(this.cmbTextColor);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.rtbContent);
            this.panel1.Controls.Add(this.dtpBlogPostDate);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 662);
            this.panel1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(923, 606);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 50);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Create";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 30);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(105, 36);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(455, 35);
            this.txtTitle.TabIndex = 7;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(434, 616);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(178, 30);
            this.lblBackgroundColor.TabIndex = 6;
            this.lblBackgroundColor.Text = "Background Color";
            // 
            // lblFontColor
            // 
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.Location = new System.Drawing.Point(20, 616);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(114, 30);
            this.lblFontColor.TabIndex = 5;
            this.lblFontColor.Text = "Font Color:";
            // 
            // cmbBackColor
            // 
            this.cmbBackColor.FormattingEnabled = true;
            this.cmbBackColor.Location = new System.Drawing.Point(625, 612);
            this.cmbBackColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBackColor.Name = "cmbBackColor";
            this.cmbBackColor.Size = new System.Drawing.Size(279, 38);
            this.cmbBackColor.TabIndex = 4;
            // 
            // cmbTextColor
            // 
            this.cmbTextColor.FormattingEnabled = true;
            this.cmbTextColor.Location = new System.Drawing.Point(145, 612);
            this.cmbTextColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTextColor.Name = "cmbTextColor";
            this.cmbTextColor.Size = new System.Drawing.Size(266, 38);
            this.cmbTextColor.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(595, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 30);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(25, 109);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(1045, 484);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // rtbBlogPost
            // 
            this.rtbBlogPost.AutoSize = true;
            this.rtbBlogPost.Location = new System.Drawing.Point(13, 701);
            this.rtbBlogPost.Name = "rtbBlogPost";
            this.rtbBlogPost.Size = new System.Drawing.Size(99, 30);
            this.rtbBlogPost.TabIndex = 5;
            this.rtbBlogPost.Text = "Blog Post";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(19, 758);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 775);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 1586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtbBlogPost);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Blog Content Managment System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBlogPostDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Label lblFontColor;
        private System.Windows.Forms.ComboBox cmbBackColor;
        private System.Windows.Forms.ComboBox cmbTextColor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label rtbBlogPost;
        private System.Windows.Forms.Panel panel2;
    }
}
