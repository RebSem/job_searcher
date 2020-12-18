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

namespace ПОПОИСКВАКАНСИЙ2
{
    public partial class Form1 : Form
    {

        int strchek = 0;//нужна для вывода вакансий из масива
        string path = @"D:\data base.txt";//путь к файлу
        public Form1()
        {
            InitializeComponent();
            waytextbox.Text = path;//для передачи на фтарую форму
            del1.Visible = false;//скрывает кнопки удаления
            del2.Visible = false;
            del3.Visible = false;
            del4.Visible = false;
            del5.Visible = false;
            loginlabel.Visible = false;//скрывает авторизацию
            logintextbox.Visible = false;
            paswordlabel.Visible = false;
            paswordtextbox.Visible = false;
            avtorez.Visible = false;
            waybutton.Visible = false;//скрывает изменение пути
            waylabel3.Visible = false;
            waylabel4.Visible = false;
            waylabel5.Visible = false;
            waytextbox.Visible = false;
            updatestr();//обновляет страницу с вакансиями
        }

        private void updatestr()
        {
            string[] masname = new string[100];//масив ФИО
            string[] mastel = new string[100];//масив телефоны
            string[] masmail = new string[100];//масив почты
            string[] masdescription = new string[100];//масив описания
            string[] maszp = new string[100];//масив зарплаты
            int i = 0;//отвечает за номер ичеки масива в который записывается стррока
            int j = 0;//отвечает за масив в который будет записана строка
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                while (true)//записывает все строки из файла в масивы пока строки не кончатся
                {
                    string str = sr.ReadLine();

                    if (str == null)
                    { break; }
                    switch (j % 5)
                    {
                        case 0:
                            {
                                masname[i] = str;
                                break;
                            }
                        case 1:
                            {
                                mastel[i] = str;
                                break;
                            }
                        case 2:
                            {
                                masmail[i] = str;
                                break;
                            }
                        case 3:
                            {
                                masdescription[i] = str;
                                break;
                            }
                        case 4:
                            {
                                maszp[i] = str;
                                i++;//после записи 5 строк в 5 масивов переключает ичейку масива
                                break;
                            }

                    }
                    j++;//переключает масив в каторый идёт запись
                }
            }
            i = strchek;//отвечает за 1 ячеку масивов с которого надо выводить данные
            name1.Text = masname[i];
            tel1.Text = mastel[i];
            mail1.Text = masmail[i];
            description1.Text = masdescription[i];
            zp1.Text = maszp[i];
            i++;
            name2.Text = masname[i];
            tel2.Text = mastel[i];
            mail2.Text = masmail[i];
            description2.Text = masdescription[i];
            zp2.Text = maszp[i];
            i++;
            name3.Text = masname[i];
            tel3.Text = mastel[i];
            mail3.Text = masmail[i];
            description3.Text = masdescription[i];
            zp3.Text = maszp[i];
            i++;
            name4.Text = masname[i];
            tel4.Text = mastel[i];
            mail4.Text = masmail[i];
            description4.Text = masdescription[i];
            zp4.Text = maszp[i];
            i++;
            name5.Text = masname[i];
            tel5.Text = mastel[i];
            mail5.Text = masmail[i];
            description5.Text = masdescription[i];
            zp5.Text = maszp[i];
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }//пустая

        private void str1_Click(object sender, EventArgs e)//отвечает за переключение страниц с вакансиями
        {
            strchek = 0;
            updatestr();
        }

        private void str2_Click(object sender, EventArgs e)//отвечает за переключение страниц с вакансиями
        {
            strchek = 5;
            updatestr();
        }

        private void str3_Click(object sender, EventArgs e)//отвечает за переключение страниц с вакансиями
        {
            strchek = 10;
            updatestr();
        }

        private void str4_Click(object sender, EventArgs e)//отвечает за переключение страниц с вакансиями
        {
            strchek = 15;
            updatestr();
        }

        private void button1_Click(object sender, EventArgs e)//вызывает Formedit
        {
            Formedit edit = new Formedit();
            edit.Owner = this;
            edit.ShowDialog();

        }

        int clickCount1 = 0;//отвечает за скрытие авторризации
        private void adminbatton_Click(object sender, EventArgs e)//переключает видимость кноок авторизации
        {
            ++clickCount1;
            switch (clickCount1)
            {
                case 1://при первом клике на кнопку 
                    {
                        loginlabel.Visible = true;
                        logintextbox.Visible = true;
                        paswordlabel.Visible = true;
                        paswordtextbox.Visible = true;
                        avtorez.Visible = true;
                        break;
                    }
                case 2:// при втором клике
                    {
                        loginlabel.Visible = false;
                        logintextbox.Visible = false;
                        paswordlabel.Visible = false;
                        paswordtextbox.Visible = false;
                        avtorez.Visible = false;
                        clickCount1 = 0;
                        break;
                    }

            }
        }
        int clickCount2 = 0;
        private void avtorez_Click(object sender, EventArgs e)//переключает видимость кнопок удаления и настройки пути в файлу
        {
            string logintrue = "admin";//логин для авторизпции
            string paswordtrue = "admin";//пароль для авторизации
            if (logintrue == logintextbox.Text)
            {
                if (paswordtrue == paswordtextbox.Text)
                {
                    ++clickCount2;
                    switch (clickCount2)
                    {
                        case 1://при первом клике на кнопку 
                            {
                                del1.Visible = true;
                                del2.Visible = true;
                                del3.Visible = true;
                                del4.Visible = true;
                                del5.Visible = true;
                                waybutton.Visible = true;
                                waylabel3.Visible = true;
                                waylabel4.Visible = true;
                                waylabel5.Visible = true;
                                waytextbox.Visible = true;
                                break;
                            }
                        case 2:// при втором клике
                            {
                                del1.Visible = false;
                                del2.Visible = false;
                                del3.Visible = false;
                                del4.Visible = false;
                                del5.Visible = false;
                                waybutton.Visible = false;
                                waylabel3.Visible = false;
                                waylabel4.Visible = false;
                                waylabel5.Visible = false;
                                waytextbox.Visible = false;
                                clickCount2 = 0;
                                break;
                            }

                    }

                }
            }

        }

        private void del1_Click(object sender, EventArgs e)//кнопка удаления первой вакансии
        {
            string[] lines = File.ReadAllLines(path);//ищет из лейблов в файле схожую страку и перезаписывает файл без неё
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines.Where(x => x != name1.Text))//удаляет имя
                    sw.WriteLine(line);
            }
            string[] lines1 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines1.Where(x => x != tel1.Text))//удаляет телефон
                    sw.WriteLine(line);
            }
            string[] lines2 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines2.Where(x => x != mail1.Text))//удаляет почту
                    sw.WriteLine(line);
            }
            string[] lines3 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines3.Where(x => x != description1.Text))//удаляет описание
                    sw.WriteLine(line);
            }
            string[] lines4 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines4.Where(x => x != zp1.Text))//удаляет инфу о зп
                    sw.WriteLine(line);
            }
            updatestr();//обновляет список вакансий
        }

        private void del2_Click(object sender, EventArgs e)//работает так же как del1
        {
            string[] lines = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines.Where(x => x != name2.Text))
                    sw.WriteLine(line);
            }
            string[] lines1 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines1.Where(x => x != tel2.Text))
                    sw.WriteLine(line);
            }
            string[] lines2 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines2.Where(x => x != mail2.Text))
                    sw.WriteLine(line);
            }
            string[] lines3 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines3.Where(x => x != description2.Text))
                    sw.WriteLine(line);
            }
            string[] lines4 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines4.Where(x => x != zp2.Text))
                    sw.WriteLine(line);
            }
            updatestr();
        }

        private void del3_Click(object sender, EventArgs e)//работает так же как del1
        {
            string[] lines = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines.Where(x => x != name3.Text))
                    sw.WriteLine(line);
            }
            string[] lines1 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines1.Where(x => x != tel3.Text))
                    sw.WriteLine(line);
            }
            string[] lines2 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines2.Where(x => x != mail3.Text))
                    sw.WriteLine(line);
            }
            string[] lines3 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines3.Where(x => x != description3.Text))
                    sw.WriteLine(line);
            }
            string[] lines4 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines4.Where(x => x != zp3.Text))
                    sw.WriteLine(line);
            }
            updatestr();
        }

        private void del4_Click(object sender, EventArgs e)//работает так же как del1
        {
            string[] lines = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines.Where(x => x != name4.Text))
                    sw.WriteLine(line);
            }
            string[] lines1 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines1.Where(x => x != tel4.Text))
                    sw.WriteLine(line);
            }
            string[] lines2 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines2.Where(x => x != mail4.Text))
                    sw.WriteLine(line);
            }
            string[] lines3 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines3.Where(x => x != description4.Text))
                    sw.WriteLine(line);
            }
            string[] lines4 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines4.Where(x => x != zp4.Text))
                    sw.WriteLine(line);
            }
            updatestr();
        }

        private void del5_Click(object sender, EventArgs e)//работает так же как del1
        {
            string[] lines = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines.Where(x => x != name5.Text))
                    sw.WriteLine(line);
            }
            string[] lines1 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines1.Where(x => x != tel5.Text))
                    sw.WriteLine(line);
            }
            string[] lines2 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines2.Where(x => x != mail5.Text))
                    sw.WriteLine(line);
            }
            string[] lines3 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines3.Where(x => x != description5.Text))
                    sw.WriteLine(line);
            }
            string[] lines4 = File.ReadAllLines(path);
            using (var sw = new StreamWriter(path))
            {
                foreach (var line in lines4.Where(x => x != zp5.Text))
                    sw.WriteLine(line);
            }
            updatestr();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }//пустая

        private void label16_Click(object sender, EventArgs e)
        {

        }//пустая

        private void button2_Click(object sender, EventArgs e)//записывает из waytextbox путь к файлу
        {
            path = waytextbox.Text;
            Formedit f2 = new Formedit();
            f2.path1.Text = waytextbox.Text;//передача на вторую форму
        }
    }
}
