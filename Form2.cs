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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void специальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специальностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.studentsDataSet.Специальности);

        }
    }
}
