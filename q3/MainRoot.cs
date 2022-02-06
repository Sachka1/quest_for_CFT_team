using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q3
{
    public partial class MainRoot : Form
    {
        public MainRoot()
        {
            InitializeComponent();
        }


        private void EditNote_Click(object sender, EventArgs e) // редактирование
        {
            if (File.Exists("Notes/" + comboBox2.Text + ".txt"))
            {
                TextNote.Text = File.ReadAllText("Notes/" + comboBox2.Text + ".txt");
            }
            else
                MessageBox.Show("Данная заметка не найдена(");

            // обновление комбобокса
            comboBox2.Items.Clear();
            string[] allfiles = Directory.GetFiles("Notes/", "*.txt");
            foreach (string filename in allfiles)
            {
                string str = Path.GetFileName(filename);
                string v = str.Remove(str.Length - 4);
                comboBox2.Items.Add(v);
            }

        }

        private void DeleteNote_Click(object sender, EventArgs e) // удаление 
        {
            if (File.Exists("Notes/" + comboBox2.Text + ".txt"))
            {
                File.Delete("Notes/" + comboBox2.Text + ".txt");
                // возвращаем исходные значения для новых записей
                TextNote.Text = "";
                comboBox2.Text = "Имя Заметки*";
            }
            else
                MessageBox.Show("Данная заметка не найдена(");

            // обновление комбобокса
            comboBox2.Items.Clear();
            string[] allfiles = Directory.GetFiles("Notes/", "*.txt");
            foreach (string filename in allfiles)
            {
                string str = Path.GetFileName(filename); // получение имени файла с расширением 
                string v = str.Remove(str.Length - 4);  // удаление расширения
                comboBox2.Items.Add(v);
            }
        }

        private void Exit_Click(object sender, EventArgs e) // выход из приложения
        {
            Application.Exit();
        }

        private void SaveNote_Click(object sender, EventArgs e) // Добавление + сохранение заметки
        {
            // проверка на символы недопустимые для названия файла
            if (comboBox2.Text.Contains('/') || comboBox2.Text.Contains('\\') || 
                comboBox2.Text.Contains(':') || comboBox2.Text.Contains('*') || 
                comboBox2.Text.Contains('?') || comboBox2.Text.Contains('<') || 
                comboBox2.Text.Contains('>') || comboBox2.Text.Contains('|'))
            {
                MessageBox.Show("Подберите другое название для заметки");
            }
            else
            {
                // запись в файл
                string path = $"Notes/{comboBox2.Text}.txt";
                string text = TextNote.Text;

                File.WriteAllText(path, text);
            }


            // возвращаем исходные значения для новых записей
            TextNote.Text = "";
            comboBox2.Text = "Имя заметки*";

            // обновление комбобокса
            comboBox2.Items.Clear();
            string[] allfiles = Directory.GetFiles("Notes/", "*.txt");
            foreach (string filename in allfiles)
            {
                string str = Path.GetFileName(filename);
                string v = str.Remove(str.Length - 4);
                comboBox2.Items.Add(v);
            }
        }

        private void MainRoot_Load(object sender, EventArgs e) // при загрузке формы
        {
            // создание одной простейшей заметки
            string path = $"Notes/FirstNote.txt";
            string text = "Привет ЦФТ!!";

            File.WriteAllText(path, text);

            comboBox2.Text = "Имя заметки*";

            // загрузка комбобокса
            string[] allfiles = Directory.GetFiles("Notes/", "*.txt");
            foreach (string filename in allfiles)
            {
                string str = Path.GetFileName(filename);
                string v = str.Remove(str.Length - 4);
                comboBox2.Items.Add(v);
            }
        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            comboBox2.Text = "";

            // обновление комбобокса
            comboBox2.Items.Clear();
            string[] allfiles = Directory.GetFiles("Notes/", "*.txt");
            foreach (string filename in allfiles)
            {
                string str = Path.GetFileName(filename);
                string v = str.Remove(str.Length - 4);
                comboBox2.Items.Add(v);
            }

        }
    }
}
