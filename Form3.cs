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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void предметыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предметыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.studentsDataSet.Предметы);

        }

        private void наименование_предметаTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
