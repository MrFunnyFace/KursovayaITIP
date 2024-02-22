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
        public MhetodForm(List<Func<string>> lst) : this()
        {
            _delegates = lst;
            foreach (var i in _delegates)
            {
                comboBox1.Items.Add(i.Method.Name);
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                _result = _delegates[index]();
            }
            Close();
        }
    }
}
