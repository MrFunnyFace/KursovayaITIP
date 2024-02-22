using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                        int number=0,age=0;
                        bool health=false;
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
                default : { textBox1.Clear();textBox1.AppendText("Выберете класс"); break; }
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
                //Создание формы и передача в неё делегатов
                MhetodForm form = new(lst);
                form.ShowDialog();
                //Вывод результата в "консоль"
                textBox1.AppendText(form.GetResult() + Environment.NewLine);
                
            }
        }

    }
}
