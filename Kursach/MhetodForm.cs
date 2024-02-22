using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class MhetodForm : Form
    {
        string _result = "Метод не выбран";
        public string GetResult()
        {
            return _result;
        }
        List<Func<string>> _delegates;
        public MhetodForm()
        {
            InitializeComponent();
        }
        //Тут будет нужен конструктор с параметрами
        //Чтобы не дублировать код, через список инициализации он вызовет обычный конструктор
        public MhetodForm(List<Func<string>> lst) : this()
        {
            //Делегаты сохраняются во внутреннем списке
            _delegates = lst;
            //Имена методов заносятся в комбобокс
            foreach (var i in _delegates)
            {
                comboBox1.Items.Add(i.Method.Name);
            }
        }

        //Конпка всего одна, так что умное имя не нужно:)

        private void Run_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                //Если выбран метод, то выполняется связанный с ним делегат и результат сохраняется
                _result = _delegates[index]();
            }
            //Форма закрывается
            Close();
        }
    }
}
