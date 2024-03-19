using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LinGo
{
    public partial class MainForm : Form
    {
        DirectoryInfo dir;
        FileInfo file;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dir = new DirectoryInfo("lessons");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            LevelChoseButton btn = (LevelChoseButton)sender;
            string path = "lessons/lesson" + btn.PathLevel.ToString() + ".json";
            file = new FileInfo(path);
            if (!file.Exists)
            {
                MessageBox.Show("Фал не найден");
                return;
            }

            FormLesson form = new FormLesson(file);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        //открыть урок
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        //Delete please
        private void button1_Click(object sender, EventArgs e)
        {
            List<Exercise> list = new List<Exercise>
            {
                new Exercise("Words","You/ты",new List<string>{"Orange","I","Me"}),
            };

            string json = JsonSerializer.Serialize(list);
            StreamWriter streamWriter= new StreamWriter("lessons/lesson2.json");
            streamWriter.Write(json);
            streamWriter.Close();
        }
    }
}
