using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Blog
{
    public partial class Form1 : Form
    {
        List<RichTextBox> rtbList = new List<RichTextBox>();
        List<Color> colorList = new List<Color>();


        public Form1()
        {
            InitializeComponent();
            preload();
        }

        public void preload()
        {
            populateColorList();
            
            foreach(Color color in colorList)
            {
                cmbTextColor.Items.Add(color.Name);
                cmbBackColor.Items.Add(color.Name);
            }

            cmbTextColor.SelectedIndex = 0;
            cmbBackColor.SelectedIndex = 1;

        }

        public void populateColorList()
        {
            colorList.Add(Color.Black);
            colorList.Add(Color.White);
            colorList.Add(Color.Red);
            colorList.Add(Color.Orange);
            colorList.Add(Color.LightBlue);
            colorList.Add(Color.Pink);
            colorList.Add(Color.Green);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            generateBlogPost();
        }

        public void generateBlogPost()
        {
            int textColor = cmbTextColor.SelectedIndex;
            int backColor = cmbBackColor.SelectedIndex;

            panel2.Controls.Add(createTextBox(formattedText(), colorList[textColor], colorList[backColor]));
        }

        public string formattedText()
        {
            string title = txtTitle.Text;
            string dtp = dtpBlogPostDate.Text;
            string blogContent = rtbContent.Text;

            return $"Title: {title}\n\n" +
                $"Date: {dtp}\n\n" +
                $"{blogContent}";
        }

        private RichTextBox createTextBox(string text, Color textColor, Color backgroundColor)
        {
            RichTextBox rtb = new RichTextBox();

            int height = 300;
            int margin = 20;

            rtb.Location = new Point(0, (height + margin) * rtbList.Count);
            rtb.Size = new Size(1045, 300);
            panel2.Controls.Add(rtb);
            rtb.ForeColor = textColor;
            rtb.BackColor = backgroundColor;

            rtb.Text = formattedText();
            rtbList.Add(rtb);

            return rtb;
        }

            //       this.rtbContent.Location = new System.Drawing.Point(25, 109);
            //this.rtbContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.rtbContent.Name = "rtbContent";
            //this.rtbContent.Size = new System.Drawing.Size(1045, 484);
            //this.rtbContent.TabIndex = 1;
            //this.rtbContent.Text = "";
    } // class
} // namespace
