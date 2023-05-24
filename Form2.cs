using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form2 : Form
    {
        private List<string> imagePaths = new List<string>();
        private int index = 0;

        public Form2(List<string> imagePaths)
        {
            InitializeComponent();
            this.imagePaths = imagePaths;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Display();
            checkButtonPlaces();
        }

        private void Display()
        {
            // Index within bounds
            if (index >= 0 && index < imagePaths.Count)
            {
                // Update pictureBox with image
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(imagePaths[index]);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= imagePaths.Count)
            {
                index = 0;
            }
            Display();
            checkButtonPlaces();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = imagePaths.Count - 1;
            }
            Display();
            checkButtonPlaces();
        }

        // Determine if prev or next button should be grayed out
        private void checkButtonPlaces()
        {
            if (index == 0)
            {
                previousButton.Enabled = false;
            }
            else
            {
                previousButton.Enabled = true;
            }
            if (index == imagePaths.Count - 1)
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            pictureBox1.Left = (ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (ClientSize.Height - pictureBox1.Height - nextButton.Height - 10 - previousButton.Height) / 2;

            nextButton.Left = pictureBox1.Right - nextButton.Width;
            nextButton.Top = pictureBox1.Bottom + 10;

            previousButton.Left = pictureBox1.Left;
            previousButton.Top = pictureBox1.Bottom + 10;
        }
    }
}
