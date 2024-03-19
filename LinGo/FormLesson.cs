using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Drawing.Text;

namespace LinGo
{

    public partial class FormLesson : Form
    {


        StreamReader reader;
        Random random;
        int rightAnswer = 0;
        int wrongAnswer = 0;
        List<Exercise> lesson;
        string currentType = "";
        string rightText;
        string curentText;


        public FormLesson(FileInfo file)
        {
            InitializeComponent();
            reader = new StreamReader(file.FullName);
            string les = reader.ReadToEnd();
            reader.Close();
            this.lesson = JsonSerializer.Deserialize<List<Exercise>>(les);
            random = new Random();
            linearProgressBar1.ValueMaximum = lesson.Count;
            getExercise();
        }

        //генерация упражнения
        private void getExercise()
        {
            SentensesPanel.Visible = false;
            WordsPanel.Visible = false;
            ComparisonPanel.Visible = false;

            currentType = lesson[0].type;
            switch (currentType)
            {
                case "Sentenses":
                    SentensesPanel.Visible = true;
                    GetSentenceWord(lesson[0]);
                    break;
                case "Words":
                    WordsPanel.Visible = true;
                    GetWords(lesson[0]);
                    break;
                case "Comparison":
                    ComparisonPanel.Visible = true;
                    GetComparisonWord(lesson[0]);
                    break;
            }
            lesson.RemoveAt(0);
        }

        #region Sentences ex
        //создание кнопок со словами
        private void GetSentenceWord(Exercise ex)
        {

            rightText = ex.words.Split('/')[0];
            label1.Text = ex.words.Split('/')[1];
            RightAnswerLabel.Text = rightText;


            List<string> data = rightText.Split(' ').ToList();
            data.AddRange(ex.trash);


            for (int i = data.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                var temp = data[j];
                data[j] = data[i];
                data[i] = temp;
            }

            foreach (string word in data)
            {
                RoundedButton btn = new RoundedButton();
                btn.Text = word;
                btn.AutoSize = true;
                btn.Height = 40;
                btn.Color = Color.LightGray;
                btn.ButtonRoundRadius = 10;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Microsoft YaHei UI", 14);


                btn.Click += wordClick;
                ChoiseflowLayoutPanel.Controls.Add(btn);
            }
        }

        //нажатие на слово в панели
        private void wordClick(object sender, EventArgs e)
        {
            if (ChoiseflowLayoutPanel.Contains((RoundedButton)sender))
            {
                InspectflowLayoutPanel.Controls.Add((RoundedButton)sender);
            }
            else if (InspectflowLayoutPanel.Contains((RoundedButton)sender))
            {
                ChoiseflowLayoutPanel.Controls.Add((RoundedButton)sender);
            }
        }

        //проверка предложения
        private bool CheckSentense()
        {
            string currentText = "";
            rightText = rightText.Replace(" ", "");
            foreach (RoundedButton item in InspectflowLayoutPanel.Controls)
            {
                currentText += item.Text;
            }

            if (currentText == rightText)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Words ex

        private void GetWords(Exercise ex)
        {
            rightText = ex.words.Split('/')[0];
            WordsLabelHead.Text = ex.words.Split('/')[1];
            RightAnswerLabel.Text = rightText;

            List<string> data = new List<string> {
                rightText,
                ex.trash[random.Next(0,ex.trash.Count)],
                ex.trash[random.Next(0,ex.trash.Count)] };

            for (int i = data.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                var temp = data[j];
                data[j] = data[i];
                data[i] = temp;
            }
            WordsBtn1.Text = data[0];
            WordsBtn2.Text = data[1];
            WordsBtn3.Text = data[2];
        }

        private void WordsBtnClick(object sender, EventArgs e)
        {
            RoundedButton btn = (RoundedButton)sender;
            curentText = btn.Text;
        }

        private void WordsBtn_Enter(object sender, EventArgs e)
        {
            RoundedButton btn = (RoundedButton)sender;
            btn.Color = Color.FromArgb(28, 176, 246);
            btn.ForeColor = Color.FromArgb(28, 176, 246);
        }

        private void WordsBtn_Leave(object sender, EventArgs e)
        {
            RoundedButton btn = (RoundedButton)sender;
            btn.Color = Color.FromArgb(229, 229, 229);
            btn.ForeColor = Color.FromArgb(75, 75, 75);
        }

        private bool CheckWords()
        {
            if (curentText == rightText)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Comparison ex

        Dictionary<string, string> words;
        RoundedButton comparisonCurrentWord = null;

        private void GetComparisonWord(Exercise ex)
        {
            buttonCheck.Enabled= false;

            List<string> words1 = ex.words.Split('/')[0].Split(' ').ToList();
            List<string> words2 = ex.words.Split('/')[1].Split(' ').ToList();
            words = new Dictionary<string, string>();
            for (int i = 0; i < words1.Count; i++)
            {
                words.Add(words1[i], words2[i]);
            }

            RightAnswerLabel.Text = "";

            for (int i = words1.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                var temp = words1[j];
                words1[j] = words1[i];
                words1[i] = temp;
            }

            for (int i = words2.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                var temp = words2[j];
                words2[j] = words2[i];
                words2[i] = temp;
            }

            foreach (string word in words1)
            {
                RoundedButton btn = new RoundedButton();
                btn.Text = word;
                btn.AutoSize = true;
                btn.Height = 40;
                btn.Color = Color.LightGray;
                btn.ButtonRoundRadius = 10;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Microsoft YaHei UI", 14);

                btn.Click += ComparisonWordClick;
                ComparisonFlPanel1.Controls.Add(btn);
            }

            foreach (string word in words2)
            {
                RoundedButton btn = new RoundedButton();
                btn.Text = word;
                btn.AutoSize = true;
                btn.Height = 40;
                btn.Color = Color.LightGray;
                btn.ButtonRoundRadius = 10;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Microsoft YaHei UI", 14);

                btn.Click += ComparisonWordClick;
                ComparisonFlPanel2.Controls.Add(btn);
            }
        }

        //нажатие на слово в панели
        private void ComparisonWordClick(object sender, EventArgs e)
        {
            RoundedButton btn = (RoundedButton)sender;
            btn.BackColor = Color.FromArgb(211, 244, 255);
            btn.Color = Color.FromArgb(28, 176, 246);
            btn.ForeColor = Color.FromArgb(28, 176, 246);

            if (comparisonCurrentWord == null)
            {
                if (btn.Parent == ComparisonFlPanel2) { return; }
                comparisonCurrentWord = btn;
                return;
            }
            if (CheckComparison(btn.Text))
            {
                btn.BackColor = Color.FromArgb(215, 255, 184);
                btn.Color = Color.FromArgb(88, 167, 0);
                btn.ForeColor = Color.FromArgb(88, 167, 0);

                comparisonCurrentWord.BackColor = Color.FromArgb(215, 255, 184);
                comparisonCurrentWord.Color = Color.FromArgb(88, 167, 0);
                comparisonCurrentWord.ForeColor = Color.FromArgb(88, 167, 0);

                comparisonCurrentWord.Enabled = false;
                btn.Enabled = false;
            }
            else
            {
                btn.BackColor = Color.White;
                btn.Color = Color.FromArgb(229, 229, 229);
                btn.ForeColor = Color.Black;

                comparisonCurrentWord.BackColor = Color.White;
                comparisonCurrentWord.Color = Color.FromArgb(229, 229, 229);
                comparisonCurrentWord.ForeColor = Color.Black;

            }
            comparisonCurrentWord = null;

            foreach(RoundedButton rbtn in ComparisonFlPanel1.Controls)
            {
                if (rbtn.Enabled == true) { return; }
            }
                 buttonCheck.Enabled= true;
        }

        private bool CheckComparison(string text)
        {
            if (words[comparisonCurrentWord.Text] == text)
            {
                return true;
            }
            return false;
        }

        #endregion


        //кнопка проверить
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            bool isRightAnswer = false;
            switch (currentType)
            {
                case "Sentenses":
                    isRightAnswer = CheckSentense();
                    break;
                case "Words":
                    isRightAnswer = CheckWords();
                    break;
                case "Comparison":
                    isRightAnswer = true;
                    break;
            }

            if (isRightAnswer)
            {
                panel1.BackColor = Color.FromArgb(215, 255, 184);
                label2.ForeColor = Color.FromArgb(88, 167, 0);
                RightAnswerLabel.ForeColor = Color.FromArgb(88, 167, 0);
                label2.Text = "Верно";
                RightAnswerLabel.Visible = true;
                rightAnswer++;
            }
            else
            {
                panel1.BackColor = Color.FromArgb(255, 223, 224);
                label2.ForeColor = Color.FromArgb(234, 43, 43);
                RightAnswerLabel.ForeColor = Color.FromArgb(234, 43, 43);
                label2.Text = "Неверно";
                RightAnswerLabel.Visible = true;
                wrongAnswer++;
            }

            linearProgressBar1.Value++;
            buttonCheck.Visible = false;
            buttonCheck.Enabled = false;
            NextBtn.Enabled = true;
        }

        // кнопка далее
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (lesson.Count == 0)
            {
                FinishPanel.Visible = true;
                RightLabel.Text = rightAnswer.ToString();
                WrongLabel.Text = wrongAnswer.ToString();
                return;
            };
            panel1.BackColor = Color.White;
            label2.Text = "";
            RightAnswerLabel.Visible = false;
            buttonCheck.Visible = true;
            buttonCheck.Enabled = true;
            InspectflowLayoutPanel.Controls.Clear();
            ChoiseflowLayoutPanel.Controls.Clear();
            ComparisonFlPanel1.Controls.Clear();
            ComparisonFlPanel2.Controls.Clear();
            NextBtn.Enabled = false;
            getExercise();
        }

        private void ToMainBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
