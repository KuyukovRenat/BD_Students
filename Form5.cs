using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Students
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet1.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.studentsDataSet1.Оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.studentsDataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            средний_баллTextBox.Text = ((Convert.ToInt32(оценка_1TextBox.Text)
            + Convert.ToInt32(оценка_2TextBox.Text) +
            Convert.ToInt32(оценка_3TextBox.Text)) / 3).ToString();
        }
    }
}
