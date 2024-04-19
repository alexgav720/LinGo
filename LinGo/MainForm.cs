using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LinGo
{
    public partial class MainForm : Form
    {
        FileInfo file;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            LevelChoseButton btn = (LevelChoseButton)sender;
            string path = "lessons/md1/lesson" + btn.PathLevel.ToString() + ".json";
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
    }
}
