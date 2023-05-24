using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addImages_Click(object sender, EventArgs e)
        {
            // Allows user to enter files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string imagePath in openFileDialog.FileNames)
                {
                    imagePaths.Add(imagePath);
                    imageList.Items.Add(Path.GetFileName(imagePath));
                }
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                Form2 form2 = new Form2(imagePaths);
                form2.Show();
            }
            else
            {
                MessageBox.Show("No images selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            addImageLabel.Left = (ClientSize.Width - addImageLabel.Width) / 2;
            addImageLabel.Top = (ClientSize.Height - addImages.Height - addImageLabel.Height - 10 - viewButton.Height - 10 - imageList.Height) / 2;

            addImages.Left = (ClientSize.Width - addImages.Width) / 2;
            addImages.Top = addImageLabel.Bottom + 10;

            imageList.Left = (ClientSize.Width - imageList.Width) / 2;
            imageList.Top = addImages.Bottom + 10;

            viewButton.Left = (ClientSize.Width - viewButton.Width) / 2;
            viewButton.Top = imageList.Bottom + 10;
        }

    }
}
