namespace single_choice
{

//�ɸĽ���һ��һ�⣬���ٵ�������һ����һ�⣬
//ʱ�䣬�÷֣�������ʸ�
    public partial class Form1 : Form
    {
        int score = 0; // ���ڼ�¼�÷�
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
            // ���� radioButton2�����Ϻ�����Ϊ��ȷ��
            if (radioButton2.Checked)
            {
                score += 10;
                result.Text = "�ش���ȷ��������\n�Ϻ���\r\n�Ϻ����й��ľ��á����ڡ�ó�׺ͺ������ģ�����Ϊ���������顱��\r\n�Ϻ�ӵ���й����Ĺ�Ʊ�����������Ϻ�֤ȯ���������Լ��ڶ��������ڻ����ܲ�����ȫ����Ҫ�Ľ�������֮һ��\r\n�Ϻ��������������ļ�װ��ۿ�֮һ�����й��Ĺ���ó�׾��о������صĵ�λ��\r\n�Ϻ���ӵ�з��������ҵ������ҵ�͸߿Ƽ���ҵ�������˴���������Ͷ�ʺ��˲š�";
            }
            else if (radioButton1.Checked || radioButton3.Checked)
            {
                result.Text = "�ش���󣡽�����\n�Ϻ���\r\n�Ϻ����й��ľ��á����ڡ�ó�׺ͺ������ģ�����Ϊ���������顱��\r\n�Ϻ�ӵ���й����Ĺ�Ʊ�����������Ϻ�֤ȯ���������Լ��ڶ��������ڻ����ܲ�����ȫ����Ҫ�Ľ�������֮һ��\r\n�Ϻ��������������ļ�װ��ۿ�֮һ�����й��Ĺ���ó�׾��о������صĵ�λ��\r\n�Ϻ���ӵ�з��������ҵ������ҵ�͸߿Ƽ���ҵ�������˴���������Ͷ�ʺ��˲š�";
            }
            else
            {
                result.Text = "��ѡ��һ��ѡ�";
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
                richTextBox2.Text = "�ش���ȷ��\n������ ��ȵ�Ǵ���ս��ʱ��������ҽѧ�ң�����Ϊ���л�ҽ�桱�����������ҽ��ϵġ��������С����﷨������������ҽ�Ļ�����Ϸ�ʽ��";
            }
            else if (radioButton25.Checked || radioButton26.Checked)
            {
                richTextBox2.Text = "�ش����\n������ ��ȵ�Ǵ���ս��ʱ��������ҽѧ�ң�����Ϊ���л�ҽ�桱�����������ҽ��ϵġ��������С����﷨������������ҽ�Ļ�����Ϸ�ʽ��";
            }
            else
            {
                richTextBox2.Text = "��ѡ��һ��ѡ�";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                score += 10;
                richTextBox3.Text = "�ش���ȷ��\n������������\r\n�������й���һ��ӣ�Ҳ��������ĺ�����ȫ��Լ6300���\r\n����Դ����ظ�ԭ���ƹ���ɽ���������ຣ�����ء��Ĵ������ϡ����졢���������ϡ����������ա����պ��Ϻ���11��ʡ����������ֱϽ�У�����ע�붫����\r\n�����������������ˮ��Դ�ḻ�����й��ľ��á��Ļ�����ᷢչ���м�����Ҫ�����塣";
            }
            else if (radioButton20.Checked || radioButton21.Checked)
            {
                richTextBox3.Text = "�ش����\n������������\r\n�������й���һ��ӣ�Ҳ��������ĺ�����ȫ��Լ6300���\r\n����Դ����ظ�ԭ���ƹ���ɽ���������ຣ�����ء��Ĵ������ϡ����졢���������ϡ����������ա����պ��Ϻ���11��ʡ����������ֱϽ�У�����ע�붫����\r\n�����������������ˮ��Դ�ḻ�����й��ľ��á��Ļ�����ᷢչ���м�����Ҫ�����塣";
            }
            else
            {
                richTextBox3.Text = "��ѡ��һ��ѡ�";
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
                richTextBox4.Text = "�ش���ȷ��\n������������ ƹ���򱻳�Ϊ�й��ġ����򡱣��й�ƹ������ڹ��ʱ����г���ռ��ͳ�ε�λ��ӵ���ڶ�����ھ��ʹ���ѡ�����������������ȡ�";
            }
            else if (radioButton14.Checked || radioButton15.Checked)
            {
                richTextBox4.Text = "�ش����\n������������ ƹ���򱻳�Ϊ�й��ġ����򡱣��й�ƹ������ڹ��ʱ����г���ռ��ͳ�ε�λ��ӵ���ڶ�����ھ��ʹ���ѡ�����������������ȡ�";
            }
            else
            {
                richTextBox4.Text = "��ѡ��һ��ѡ�";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                score += 10;
                richTextBox5.Text = "�ش���ȷ��\n������������׳�����й��˿������������壬��Ҫ�ֲ��ڹ���׳�������������ϡ����ݵȵء�";
            }
            else if (radioButton32.Checked || radioButton33.Checked)
            {
                richTextBox5.Text = "�ش����\n������������׳�����й��˿������������壬��Ҫ�ֲ��ڹ���׳�������������ϡ����ݵȵء� ";
            }
            else
            {
                richTextBox5.Text = "��ѡ��һ��ѡ�";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton39.Checked)
            {
                score += 10;
                textBox1.Text= "�÷֣�" + score.ToString();
                richTextBox6.Text = "�ش���ȷ��\n�������������س�����Ԫǰ221�ꡪǰ206�꣩���й���ʷ�ϵ�һ��ʵ��ȫ��ͳһ�����뼯Ȩ�Ʒ⽨����������ʼ������������";
            }
            else if (radioButton38.Checked || radioButton37.Checked)
            {
                textBox1.Text = "�÷֣�" + score.ToString();
                richTextBox6.Text = "�ش����\n�������������س�����Ԫǰ221�ꡪǰ206�꣩���й���ʷ�ϵ�һ��ʵ��ȫ��ͳһ�����뼯Ȩ�Ʒ⽨����������ʼ������������ ";
            }
            else
            {
                richTextBox6.Text = "��ѡ��һ��ѡ�";
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
