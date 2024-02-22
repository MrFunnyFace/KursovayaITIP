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
    public partial class CreateForm : Form
    {
        public List<object> GetData()
        {
            List<object> res = new();
            //Проходим по всем контролям в форме
            //Нас интересуют текстовые поля и CheckBox
            //Если бы ещё что интересовало - был бы смысл использовать switch
            foreach (var c in Controls)
            {
                if (c is TextBox)
                    //Если текстовое поле - забираем текст
                    res.Add((c as TextBox).Text);
                else if (c is CheckBox)
                    //Если CheckBox - состояние
                    res.Add((c as CheckBox).Checked);
            }
            //Возвращаем полученный список
            return res;
        }

        public CreateForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label Number = new Label()
            {
                Location = new Point(190, 120),
                Text = "Количество фруктов",
                Size = new Size(800, 25)
            };
            TextBox txt = new TextBox() { Location = new Point(190, 148) };
            if (Health.Checked)
            {
                Controls.Add(txt);
                Controls.Add(Number);
                txt.ReadOnly = false;
            }
            else
            {
                Controls.RemoveAt(Controls.Count-1);
                Controls.RemoveAt(Controls.Count-1);
            }


        }

        private void Ready_Click(object sender, EventArgs e)
        {
            if (ObjName.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text==string.Empty)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
