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
    public partial class MainForm : Form
    {
        List<IKurs> Obj;
        public MainForm()
        {
            InitializeComponent();
            Obj = new List<IKurs>();
        }

        private void ViewProperties_Click(object sender, EventArgs e)
        {

        }

        private void RunMethod_Click(object sender, EventArgs e)
        {
            MhetodForm mhetodForm = new MhetodForm();
            mhetodForm.ShowDialog();
        }

        private void AddObj_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }
    }
}
