using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace single_choice
{
    public partial class Form2 : Form
    {
        // 定义二级联动数据
        private Dictionary<string, List<string>> comboData = new Dictionary<string, List<string>>()
        {
            { "🌄 自然风光", new List<string> { "山脉与峡谷", "海洋与湖泊", "森林与草原" } },
            { "🏙️ 城市景观", new List<string> { "现代建筑", "历史古迹", "夜景灯光" } },
            { "🧑 人物肖像", new List<string> { "职业人像", "街头抓拍", "艺术写真" } },
            { "🐾 动物世界", new List<string> { "野生动物", "家养宠物", "鸟类特写" } },
            { "✈️ 旅行记录", new List<string> { "东南亚之旅 (2023)", "欧洲行记 (2022)", "国内古镇巡游" } }
        };

        public Form2()
        {
            InitializeComponent();
            // 填充comboBox1
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(comboData.Keys.ToArray());
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button1.Click += button1_Click;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem != null && comboData.TryGetValue(comboBox1.SelectedItem.ToString(), out var subItems))
            {
                comboBox2.Items.AddRange(subItems.ToArray());
                if (comboBox2.Items.Count > 0)
                    comboBox2.SelectedIndex = 0;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 这里可以添加你点击图片后的逻辑，比如弹窗、切换图片等

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("请先选择一个分类！");
                return;
            }

            string resourceName = comboBox2.SelectedItem.ToString();

            // 通过资源管理器获取图片（Form2.resx 资源）
            var rm = new System.Resources.ResourceManager("single_choice.Properties.Resources", typeof(Form2).Assembly);
            var img = rm.GetObject(resourceName) as System.Drawing.Image;

            if (img != null)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = img;
            }
            else
            {
                MessageBox.Show($"未找到名为“{resourceName}”的图片资源！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var fullScreenForm = new FullScreenImageForm(pictureBox1.Image);
                fullScreenForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先加载一张图片！");
            }
        }
    }
}
