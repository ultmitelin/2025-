using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace single_choice
{
    public partial class FullScreenImageForm : Form
    {
        private Image originalImage;
        private float currentAngle = 0f;
        private float currentScale = 1f;

        public FullScreenImageForm()
        {
            InitializeComponent();
        }

        public FullScreenImageForm(Image img)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;
            this.KeyPreview = true;
            this.KeyDown += FullScreenImageForm_KeyDown;

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            originalImage = (Image)img.Clone();
            pictureBox1.Image = (Image)img.Clone();
        }

        private void FullScreenImageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.A) // 左旋转
            {
                currentAngle -= 90f;
                UpdateImage();
            }
            else if (e.KeyCode == Keys.D) // 右旋转
            {
                currentAngle += 90f;
                UpdateImage();
            }
            else if (e.KeyCode == Keys.W) // 放大
            {
                currentScale += 0.1f;
                UpdateImage();
            }
            else if (e.KeyCode == Keys.S) // 缩小
            {
                currentScale = Math.Max(0.1f, currentScale - 0.1f);
                UpdateImage();
            }
        }

        private void UpdateImage()
        {
            if (originalImage == null) return;

            // 旋转
            Bitmap rotated = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.Clear(Color.Black);
                g.TranslateTransform(originalImage.Width / 2f, originalImage.Height / 2f);
                g.RotateTransform(currentAngle);
                g.ScaleTransform(currentScale, currentScale);
                g.TranslateTransform(-originalImage.Width / 2f, -originalImage.Height / 2f);
                g.DrawImage(originalImage, new Point(0, 0));
            }
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = rotated;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 这里可以添加你想要的点击事件逻辑
        }
    }
}
