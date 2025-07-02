namespace single_choice
{

//可改进：一屏一题，快速导航，上一题下一题，
//时间，得分，数组提词改
    public partial class Form1 : Form
    {
        int score = 0; // 用于记录得分
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // 假设 radioButton2（“上海”）为正确答案
            if (radioButton2.Checked)
            {
                score += 10;
                result.Text = "回答正确！解析：\n上海：\r\n上海是中国的经济、金融、贸易和航运中心，被誉为“东方明珠”。\r\n上海拥有中国最大的股票交易所——上海证券交易所，以及众多国内外金融机构总部，是全球重要的金融中心之一。\r\n上海港是世界上最大的集装箱港口之一，对中国的国际贸易具有举足轻重的地位。\r\n上海还拥有发达的制造业、服务业和高科技产业，吸引了大量国内外投资和人才。";
            }
            else if (radioButton1.Checked || radioButton3.Checked)
            {
                result.Text = "回答错误！解析：\n上海：\r\n上海是中国的经济、金融、贸易和航运中心，被誉为“东方明珠”。\r\n上海拥有中国最大的股票交易所——上海证券交易所，以及众多国内外金融机构总部，是全球重要的金融中心之一。\r\n上海港是世界上最大的集装箱港口之一，对中国的国际贸易具有举足轻重的地位。\r\n上海还拥有发达的制造业、服务业和高科技产业，吸引了大量国内外投资和人才。";
            }
            else
            {
                result.Text = "请选择一个选项！";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton27.Checked)
            {
                score += 10;
                richTextBox2.Text = "回答正确！\n解析： 扁鹊是春秋战国时期著名的医学家，被誉为“中华医祖”，他提出了中医诊断的“望闻问切”四诊法，至今仍是中医的基本诊断方式。";
            }
            else if (radioButton25.Checked || radioButton26.Checked)
            {
                richTextBox2.Text = "回答错误！\n解析： 扁鹊是春秋战国时期著名的医学家，被誉为“中华医祖”，他提出了中医诊断的“望闻问切”四诊法，至今仍是中医的基本诊断方式。";
            }
            else
            {
                richTextBox2.Text = "请选择一个选项！";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                score += 10;
                richTextBox3.Text = "回答正确！\n解析：长江：\r\n长江是中国第一大河，也是亚洲最长的河流，全长约6300公里。\r\n它发源于青藏高原的唐古拉山脉，流经青海、西藏、四川、云南、重庆、湖北、湖南、江西、安徽、江苏和上海等11个省、自治区和直辖市，最终注入东海。\r\n长江流域面积广阔，水资源丰富，对中国的经济、文化和社会发展具有极其重要的意义。";
            }
            else if (radioButton20.Checked || radioButton21.Checked)
            {
                richTextBox3.Text = "回答错误！\n解析：长江：\r\n长江是中国第一大河，也是亚洲最长的河流，全长约6300公里。\r\n它发源于青藏高原的唐古拉山脉，流经青海、西藏、四川、云南、重庆、湖北、湖南、江西、安徽、江苏和上海等11个省、自治区和直辖市，最终注入东海。\r\n长江流域面积广阔，水资源丰富，对中国的经济、文化和社会发展具有极其重要的意义。";
            }
            else
            {
                richTextBox3.Text = "请选择一个选项！";
            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                score += 10;
                richTextBox4.Text = "回答正确！\n解析：解析： 乒乓球被称为中国的“国球”，中国乒乓球队在国际比赛中长期占据统治地位，拥有众多世界冠军和传奇选手如马龙、张怡宁等。";
            }
            else if (radioButton14.Checked || radioButton15.Checked)
            {
                richTextBox4.Text = "回答错误！\n解析：解析： 乒乓球被称为中国的“国球”，中国乒乓球队在国际比赛中长期占据统治地位，拥有众多世界冠军和传奇选手如马龙、张怡宁等。";
            }
            else
            {
                richTextBox4.Text = "请选择一个选项！";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                score += 10;
                richTextBox5.Text = "回答正确！\n解析：解析：壮族是中国人口最多的少数民族，主要分布在广西壮族自治区及云南、贵州等地。";
            }
            else if (radioButton32.Checked || radioButton33.Checked)
            {
                richTextBox5.Text = "回答错误！\n解析：解析：壮族是中国人口最多的少数民族，主要分布在广西壮族自治区及云南、贵州等地。 ";
            }
            else
            {
                richTextBox5.Text = "请选择一个选项！";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton39.Checked)
            {
                score += 10;
                textBox1.Text= "得分：" + score.ToString();
                richTextBox6.Text = "回答正确！\n解析：解析：秦朝（公元前221年—前206年）是中国历史上第一个实现全国统一的中央集权制封建王朝，由秦始皇嬴政建立。";
            }
            else if (radioButton38.Checked || radioButton37.Checked)
            {
                textBox1.Text = "得分：" + score.ToString();
                richTextBox6.Text = "回答错误！\n解析：解析：秦朝（公元前221年—前206年）是中国历史上第一个实现全国统一的中央集权制封建王朝，由秦始皇嬴政建立。 ";
            }
            else
            {
                richTextBox6.Text = "请选择一个选项！";
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
