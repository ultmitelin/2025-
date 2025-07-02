using System;
using System.Drawing;
using System.Windows.Forms;

namespace single_choice
{
    public partial class FullScreenImageForm : Form
    {
        private PictureBox pictureBox;

        public FullScreenImageForm(Image img)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;
            this.KeyDown += (s, e) => { if (e.KeyCode == Keys.Escape) this.Close(); };

            pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = img,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Black
            };
            this.Controls.Add(pictureBox);
        }
    }
}