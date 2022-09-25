using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Reflection;

namespace Magic_8_Ball
{
    public partial class MagicEightBall : Form
    {
        Random random = new Random();
        Char[] thinkTxt = "Думаю над вопросом...".ToCharArray();

        List<String> predictions = new List<String>()
        {
            "Бесспорно", "Предрешено", "Никаких сомнений",
            "Определённо да", "Можешь быть уверен в этом", "Да", "Пока не ясно, попробуй снова",
            "Спроси позже", "Лучше не рассказывать", "Сейчас нельзя предсказать", "Сконцентрируйся и спроси опять",
            "Даже не думай", "Мой ответ — «нет»", "По моим данным — «нет»)", "Перспективы не очень хорошие", "Весьма сомнительно"
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
                MessageBox.Show("Вы не написали никакого вопроса, я не могу отвечать на пустоту", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}