using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kursach
{
    public partial class MainForm : Form
    {
        List<IKurs> Obj;
        public MainForm()
        {
            InitializeComponent();
            Obj = new List<IKurs>();
        }
        List<Func<string>> _getDelegateList(IKurs obj)
        {
            return obj.GenerateDelegateList();
        }
        private void AddObj_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0://лимонное дерево
                    {
                        CreateForm createForm = new CreateForm();
                        int number = 0, age = 0;
                        bool health = false;
                        double height = 0;
                        if (createForm.ShowDialog() == DialogResult.OK)
                        {
                            var lst = createForm.GetData();
                            string name = "";
                            name = lst[0].ToString();
                            health = bool.Parse(lst[1].ToString());
                            age = int.Parse(lst[2].ToString());
                            height = double.Parse(lst[3].ToString());
                            if (lst.Count == 5)
                            {
                                number = int.Parse(lst[4].ToString());
                            }
                            LemonTree obj = new LemonTree(name, number, health, height, age);
                            Obj.Add(obj);
                            comboBox2.Items.Add(obj.Name);
                        }
                        break;
                    }
                case 1://яблоня
                    {
                        CreateForm createForm = new CreateForm();
                        int number = 0, age = 0;
                        bool health = false;
                        double height = 0;
                        if (createForm.ShowDialog() == DialogResult.OK)
                        {
                            var lst = createForm.GetData();
                            string name = "";
                            name = lst[0].ToString();
                            health = bool.Parse(lst[1].ToString());
                            age = int.Parse(lst[2].ToString());
                            height = double.Parse(lst[3].ToString());
                            if (lst.Count == 5)
                            {
                                number = int.Parse(lst[4].ToString());
                            }
                            var obj = new AppleTree(name, number, health, height, age);
                            Obj.Add(obj);
                            comboBox2.Items.Add(obj.Name);
                        }
                        break;
                    }
                case 2://груша
                    {
                        CreateForm createForm = new CreateForm();
                        int number = 0, age = 0;
                        bool health = false;
                        double height = 0;
                        string name = "";
                        if (createForm.ShowDialog() == DialogResult.OK)
                        {
                            var lst = createForm.GetData();
                            name = lst[0].ToString();
                            health = bool.Parse(lst[1].ToString());
                            age = int.Parse(lst[2].ToString());
                            height = double.Parse(lst[3].ToString());
                            if (lst.Count == 5)
                            {
                                number = int.Parse(lst[4].ToString());
                            }
                            var obj = new PearTree(name, number, health, height, age);
                            Obj.Add(obj);
                            comboBox2.Items.Add(obj.Name);
                        }
                        break;
                    }
                case 3://апельсин
                    {
                        CreateForm createForm = new CreateForm();
                        int number = 0, age = 0;
                        bool health = false;
                        double height = 0;
                        if (createForm.ShowDialog() == DialogResult.OK)
                        {
                            var lst = createForm.GetData();
                            string name = "";
                            name = lst[0].ToString();
                            health = bool.Parse(lst[1].ToString());
                            age = int.Parse(lst[2].ToString());
                            height = double.Parse(lst[3].ToString());
                            if (lst.Count == 5)
                            {
                                number = int.Parse(lst[4].ToString());
                            }

                            var obj = new OrangeTree(name, number, health, height, age);
                            Obj.Add(obj);
                            comboBox2.Items.Add(obj.Name);
                        }
                        break;
                    }
                case 4://арбуз
                    {
                        Watermelon obj = new Watermelon();
                        Obj.Add(obj);
                        comboBox2.Items.Add(obj.Name);
                        break;
                    }
                default: { textBox1.Clear(); textBox1.AppendText("Выберете класс"); break; }
            }
        }
        private void ViewProperties_Click(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            if (index != -1)
            {
                textBox1.Clear();
                textBox1.AppendText(Obj[comboBox2.SelectedIndex].ToString());
            }
        }

        private void RunMethod_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int index = comboBox2.SelectedIndex;
            if (index != -1)
            {
                var lst = _getDelegateList(Obj[index]);
                MhetodForm form = new(lst);
                form.ShowDialog();
                textBox1.AppendText(form.GetResult() + Environment.NewLine);

            }
        }

        private void DelObj_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int index = comboBox2.SelectedIndex;
            if (index != -1)
            {
                textBox1.AppendText(comboBox2.Text + " удален");
                Obj.RemoveAt(index);
                comboBox2.Items.RemoveAt(index);
            }
        }
        public static object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
#pragma warning disable SYSLIB0011 // Тип или член устарел
                var binForm = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Тип или член устарел
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog FileDialog = new())
            {
                FileDialog.Filter = "dat (*.dat)|*.dat";
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Теперь у нас есть путь!
                    string filePath = FileDialog.FileName;
                    //Создаём файл
                    using (BinaryWriter sr = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                    {
                        //Сначала запишем заранее придуманный идентификатор формата
                        //Да, есть и другие способы узнать формат, но это самый простой
                        string Ident = "MAGIDATA0451";
                        sr.Write(Ident);
                        foreach (var obj in Obj)
                        {
                            //Для каждого элемента сериализуем в массив байт
                            var b = obj.GetByteArray();
                            //Записываем длину массива в файл
                            sr.Write(b.Length);
                            //Записываем сам массив
                            sr.Write(b);
                        }
                    }
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog FileDialog = new())
            {
                FileDialog.Filter = "dat (*.dat)|*.dat";
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = FileDialog.FileName;
                    using (BinaryReader sr = new BinaryReader(File.Open(filePath, FileMode.Open)))
                    {
                        //Для надёжности проверим формат файла - есть ли в начале волшебная строчка
                        var Ident = sr.ReadString();
                        if (Ident == "MAGIDATA0451")
                        {
                            //Если есть - для начала очищаем списки
                            Obj.Clear();
                            comboBox2.Items.Clear();
                            //Проверяем что файл ещё не закончился. Для этого смотрим позицию в файле
                            while (sr.BaseStream.Position != sr.BaseStream.Length)
                            {
                                //Считываем размер массива
                                var arsize = sr.ReadInt32();
                                //Считываем сам массив
                                var byteArray = sr.ReadBytes(arsize);
                                //Десериализуем из массива байт
                                var res = ByteArrayToObject(byteArray);
                                //Добавления элемента с его преобразованием
                                Obj.Add(res as IKurs);
                                comboBox2.Items.Add(res.ToString);
                            }
                        }
                        else
                            textBox1.AppendText("Неверный формат файла" + Environment.NewLine);
                    }
                }
            }
        }
    
    }
}
