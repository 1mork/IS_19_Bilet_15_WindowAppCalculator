using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;

namespace IS_19_Bilet_15_WindowAppCalculator
{

    public partial class Form1 : Form
    {
        Word._Application oWord = new Word.Application();
        public Form1()
        {
            InitializeComponent();
            //Установка картинок окон
            GluhoeRbutton.Tag = Image.FromFile("WindowGluhoe.jpg"); 
            GluhoeRbutton.CheckedChanged += GluhoeRbutton_CheckedChanged;
            PovorotnoeRbutton.Tag = Image.FromFile("WindowPovorotnoe.jpg");
            PovorotnoeRbutton.CheckedChanged += GluhoeRbutton_CheckedChanged;
            OtkidnoeRButton.Tag = Image.FromFile("WindowOtkidnoe.jpg");
            OtkidnoeRButton.CheckedChanged += GluhoeRbutton_CheckedChanged;
            FramuzhnoeRbutton.Tag = Image.FromFile("WindowFramuzhnoe.jpg");
            FramuzhnoeRbutton.CheckedChanged += GluhoeRbutton_CheckedChanged;
            RazdvizhnoeRbutton.Tag = Image.FromFile("WindowRazdizhnoe.jpg");
            RazdvizhnoeRbutton.CheckedChanged += GluhoeRbutton_CheckedChanged;
        }
        private void RaschetButton_Click(object sender, EventArgs e)
        {
            //Задаем цену за 1кв м
            double Windows = 1000;
            double balcony = 5000;
            double doors = 3000;
            if(UsliguComboBox.Text =="")
            {
                MessageBox.Show("Выберте услугу!");
            }
            else
            {
                if (UsliguComboBox.SelectedItem.ToString() == "Окна")
                {
                    //Расчет стоимости окон
                    if (GluhoeRbutton.Checked == true)
                    {
                        double summForGluhoe = Windows + 1000; // Цена за "Глухое" окно
                        var summForShirina = Convert.ToDouble(ShirinaTextBox.Text) * summForGluhoe; // Цена за ширину в кв м "Глухого" окна
                        var summForVysota = Convert.ToDouble(VysotaTextBox.Text) * summForGluhoe; // Цена за высоту в кв м "Глухого" окна
                        var ContrSumm = summForShirina + summForVysota; // Итоговая цена по ширине и высоте кв м "Глухого" окна
                        ControllSumma.Text = ContrSumm.ToString(); // Запись итоговой суммы в дфиуд                   
                    }
                    if (PovorotnoeRbutton.Checked == true)
                    {
                        double summForPovorotnoe = Windows + 3400.50;
                        var summForShirina = Convert.ToDouble(ShirinaTextBox.Text) * summForPovorotnoe;
                        var summForVysota = Convert.ToDouble(VysotaTextBox.Text) * summForPovorotnoe;
                        var ContrSumm = summForShirina + summForVysota;
                        ControllSumma.Text = ContrSumm.ToString();
                    }
                    if (OtkidnoeRButton.Checked == true)
                    {
                        double summForOtkidnoe = Windows + 2560;
                        var summForShirina = Convert.ToDouble(ShirinaTextBox.Text) * summForOtkidnoe;
                        var summForVysota = Convert.ToDouble(VysotaTextBox.Text) * summForOtkidnoe;
                        var ContrSumm = summForShirina + summForVysota;
                        ControllSumma.Text = ContrSumm.ToString();
                    }
                    if (FramuzhnoeRbutton.Checked == true)
                    {
                        double summForFramuzhnoe = Windows + 7900.90;
                        var summForShirina = Convert.ToDouble(ShirinaTextBox.Text) * summForFramuzhnoe;
                        var summForVysota = Convert.ToDouble(VysotaTextBox.Text) * summForFramuzhnoe;
                        var ContrSumm = summForShirina + summForVysota;
                        ControllSumma.Text = ContrSumm.ToString();
                    }
                    if (RazdvizhnoeRbutton.Checked == true)
                    {
                        double summForRazdvizhnoe = Windows + 6210.50;
                        var summForShirina = Convert.ToDouble(ShirinaTextBox.Text) * summForRazdvizhnoe;
                        var summForVysota = Convert.ToDouble(VysotaTextBox.Text) * summForRazdvizhnoe;
                        var ContrSumm = summForShirina + summForVysota;
                        ControllSumma.Text = ContrSumm.ToString();
                    }
                }
                //Расчет стоимости балконов
                else if (UsliguComboBox.SelectedItem.ToString() == "Балконы")
                {
                    var summForShirina = Convert.ToDouble(ShirinaTextBox.Text) * balcony;
                    var summForVysota = Convert.ToDouble(VysotaTextBox.Text) * balcony;
                    var ContrSumm = summForShirina + summForVysota;
                    ControllSumma.Text = ContrSumm.ToString();
                }
                //Расчет стоимости дверей
                else
                {
                    var summForShirina = Convert.ToDouble(ShirinaTextBox.Text) * doors;
                    var summForVysota = Convert.ToDouble(VysotaTextBox.Text) * doors;
                    var ContrSumm = summForShirina + summForVysota;
                    ControllSumma.Text = ContrSumm.ToString();
                }
            }

           
            
        }
        // Добавление фото компании
        private void PlusPhotoButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (ofd.ShowDialog(this) == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }
        // Вывод картины с видом окна по выбранному РадионБаттону
        private void GluhoeRbutton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                pictureBox2.Image = (Image)rb.Tag;
            }
            
        }
        //Класс для установки закладок ворда
        private void SetBookmarks(Word._Document oDoc)
        {
            Random rnd = new Random();

            oDoc.Bookmarks["number"].Range.Text = rnd.Next(1, 1000).ToString();
            oDoc.Bookmarks["date"].Range.Text = DateTime.Now.ToString();
            if (GluhoeRbutton.Checked == true)
            {
                oDoc.Bookmarks["item"].Range.Text = UsliguComboBox.SelectedItem.ToString() + " " + "Глухие";
            }
            else if (PovorotnoeRbutton.Checked == true)
            {
                oDoc.Bookmarks["item"].Range.Text = UsliguComboBox.SelectedItem.ToString() + " " + "Поворотные";
            }
            else if (OtkidnoeRButton.Checked == true)
            {
                oDoc.Bookmarks["item"].Range.Text = UsliguComboBox.SelectedItem.ToString() + " " + "Откидные";
            }
            else if (FramuzhnoeRbutton.Checked == true)
            {
                oDoc.Bookmarks["item"].Range.Text = UsliguComboBox.SelectedItem.ToString() + " " + "Фрамужные";
            }
            else if (RazdvizhnoeRbutton.Checked == true)
            {
                oDoc.Bookmarks["item"].Range.Text = UsliguComboBox.SelectedItem.ToString() + " " + "Раздвижные";
            }
            else
            {
                //
            }

            oDoc.Bookmarks["controlSum"].Range.Text = ControllSumma.Text + " " + "рублей";
            
        }
        //Путь
        private Word._Document GetDoc(string path)
        {
            Word._Document oDoc = oWord.Documents.Add(path);
            SetBookmarks(oDoc);
            return oDoc;
        }

        private void PlusCheckButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string savePath = Environment.CurrentDirectory + "\\" + rnd.Next(1, 1001).ToString() + "_ToPrint.docx";// Сохранение итогового чека

            Word._Document oDoc = GetDoc(Environment.CurrentDirectory + "\\check.docx"); // Выбор шаблона чека для заполнения
            oDoc.SaveAs(FileName: savePath);
            oDoc.Close();
            Process.Start(savePath);
        }
      
        //Ввод вещественных чисел в текс бокс c выбором ширины
        private void ShirinaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(ShirinaTextBox.Text) && e.KeyChar == ','))
            {

                return;
            }
            ShirinaTextBox.Clear();

            e.Handled = true;
        }
        //Ввод вещественных чисел в текс бокс c выбором высоты
        private void VysotaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(ShirinaTextBox.Text) && e.KeyChar == ','))
            {

                return;
            }
            ShirinaTextBox.Clear();

            e.Handled = true;
        }

        //Тест методы

        public static string testmethodOne(int VeshChar)
        {
            string result = null;
            if (VeshChar == 1)
            {
                result = "Успех!";
            }

            return result;
        }
        public static string testmethodTwo( int shirina, int vysota)
        {
            string result = null;
         
            if (shirina == 22222222 || vysota == 11111111)
            {
                result = "Введите настоящие размеры!";
            }
            return result;
        }
        public static string testmethodThree(int OtricChisla)
        {
            string result = null;
            if (OtricChisla == -1)
            {
                result = "Ввод отрицательных чисел запрещен!";
            }

            return result;
        }
    }
}
