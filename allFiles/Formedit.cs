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
    public partial class Formedit : Form
    {
        string path = @"D:\data base.txt";
        public Formedit()
        {
            InitializeComponent();
            path1.Visible = false;
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
            
            }
        }

        private void Formedit_Load(object sender, EventArgs e)
        {

        }

        private void create1_Click(object sender, EventArgs e)//создаёт строки из полей окна создания вакансии
        {
            path = path1.Text;//определяет путь к файлу
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                //sw.WriteLine(" ");
                sw.WriteLine(nametextBox.Text);
                sw.WriteLine(teltextBox.Text);
                sw.WriteLine(mailtextBox.Text);
                sw.WriteLine(descriptiontextBox.Text);
                sw.WriteLine(zptextBox.Text);
            }
            this.Close();
        }
    }
}
