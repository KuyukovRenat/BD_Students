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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.studentsDataSet.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.studentsDataSet.Студенты);

        }

        private void очная_форма_обученияCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            студентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            студентыBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Validate();
            студентыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(studentsDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show();
        }
    }
}
