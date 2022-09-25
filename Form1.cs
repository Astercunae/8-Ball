using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Reflection;

namespace Magic_8_Ball
{
    public partial class MagicEightBall : Form
    {
        Random random = new Random();
        Char[] thinkTxt = "����� ��� ��������...".ToCharArray();

        List<String> predictions = new List<String>()
        {
            "���������", "����������", "������� ��������",
            "���������� ��", "������ ���� ������ � ����", "��", "���� �� ����, �������� �����",
            "������ �����", "����� �� ������������", "������ ������ �����������", "��������������� � ������ �����",
            "���� �� �����", "��� ����� � ����", "�� ���� ������ � ����)", "����������� �� ����� �������", "������ �����������"
        };

        public MagicEightBall()
        {
            InitializeComponent();
        }

        async private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                for (int i = 0; i < 1; i++)
                {
                    foreach (var symbol in thinkTxt)
                    {
                        predictionText.Text += symbol;
                        await Task.Delay(100);
                    }
                    predictionText.Text = "";
                }
                String prediction = predictions[random.Next(predictions.Count)];
                predictionText.Text = prediction;
            }
            else
            {
                MessageBox.Show("�� �� �������� �������� �������, � �� ���� �������� �� �������", "��������",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}