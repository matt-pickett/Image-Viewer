namespace WinForm
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
            addImages = new Button();
            addImageLabel = new Label();
            viewButton = new Button();
            imageList = new ListBox();
            SuspendLayout();
            // 
            // addImages
            // 
            addImages.Location = new Point(252, 191);
            addImages.Name = "addImages";
            addImages.Size = new Size(75, 23);
            addImages.TabIndex = 0;
            addImages.Text = "Add Image";
            addImages.UseVisualStyleBackColor = true;
            addImages.Click += addImages_Click;
            // 
            // addImageLabel
            // 
            addImageLabel.AutoSize = true;
            addImageLabel.Location = new Point(201, 163);
            addImageLabel.Name = "addImageLabel";
            addImageLabel.Size = new Size(183, 15);
            addImageLabel.TabIndex = 1;
            addImageLabel.Text = "Add as many images as you want";
            // 
            // viewButton
            // 
            viewButton.Location = new Point(252, 320);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(75, 23);
            viewButton.TabIndex = 2;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // imageList
            // 
            imageList.FormattingEnabled = true;
            imageList.ItemHeight = 15;
            imageList.Location = new Point(201, 220);
            imageList.MultiColumn = true;
            imageList.Name = "imageList";
            imageList.Size = new Size(183, 94);
            imageList.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 461);
            Controls.Add(imageList);
            Controls.Add(viewButton);
            Controls.Add(addImageLabel);
            Controls.Add(addImages);
            Name = "Form1";
            Text = "Image Viewer";
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addImages;
        private Label addImageLabel;
        private Button viewButton;
        private ListBox imageList;
    }
}