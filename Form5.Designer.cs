
namespace BD_Students
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_студентаLabel;
            System.Windows.Forms.Label дата_экзамена_1Label;
            System.Windows.Forms.Label код_предмета_1Label;
            System.Windows.Forms.Label оценка_1Label;
            System.Windows.Forms.Label дата_экзамена_2Label;
            System.Windows.Forms.Label код_предмета_2Label;
            System.Windows.Forms.Label оценка_2Label;
            System.Windows.Forms.Label дата_экзамена_3Label;
            System.Windows.Forms.Label код_предмета_3Label;
            System.Windows.Forms.Label оценка_3Label;
            System.Windows.Forms.Label средний_баллLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.оценкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.оценкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_студентаTextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_1TextBox = new System.Windows.Forms.TextBox();
            this.оценка_1TextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_2TextBox = new System.Windows.Forms.TextBox();
            this.оценка_2TextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_3TextBox = new System.Windows.Forms.TextBox();
            this.оценка_3TextBox = new System.Windows.Forms.TextBox();
            this.средний_баллTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new BD_Students.StudentsDataSet();
            this.оценкиTableAdapter = new BD_Students.StudentsDataSetTableAdapters.ОценкиTableAdapter();
            this.tableAdapterManager = new BD_Students.StudentsDataSetTableAdapters.TableAdapterManager();
            this.studentsDataSet1 = new BD_Students.StudentsDataSet();
            this.оценкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            код_студентаLabel = new System.Windows.Forms.Label();
            дата_экзамена_1Label = new System.Windows.Forms.Label();
            код_предмета_1Label = new System.Windows.Forms.Label();
            оценка_1Label = new System.Windows.Forms.Label();
            дата_экзамена_2Label = new System.Windows.Forms.Label();
            код_предмета_2Label = new System.Windows.Forms.Label();
            оценка_2Label = new System.Windows.Forms.Label();
            дата_экзамена_3Label = new System.Windows.Forms.Label();
            код_предмета_3Label = new System.Windows.Forms.Label();
            оценка_3Label = new System.Windows.Forms.Label();
            средний_баллLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingNavigator)).BeginInit();
            this.оценкиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_студентаLabel
            // 
            код_студентаLabel.AutoSize = true;
            код_студентаLabel.Location = new System.Drawing.Point(78, 86);
            код_студентаLabel.Name = "код_студентаLabel";
            код_студентаLabel.Size = new System.Drawing.Size(101, 17);
            код_студентаLabel.TabIndex = 2;
            код_студентаLabel.Text = "Код студента:";
            // 
            // дата_экзамена_1Label
            // 
            дата_экзамена_1Label.AutoSize = true;
            дата_экзамена_1Label.Location = new System.Drawing.Point(78, 120);
            дата_экзамена_1Label.Name = "дата_экзамена_1Label";
            дата_экзамена_1Label.Size = new System.Drawing.Size(124, 17);
            дата_экзамена_1Label.TabIndex = 4;
            дата_экзамена_1Label.Text = "Дата экзамена 1:";
            // 
            // код_предмета_1Label
            // 
            код_предмета_1Label.AutoSize = true;
            код_предмета_1Label.Location = new System.Drawing.Point(78, 164);
            код_предмета_1Label.Name = "код_предмета_1Label";
            код_предмета_1Label.Size = new System.Drawing.Size(117, 17);
            код_предмета_1Label.TabIndex = 6;
            код_предмета_1Label.Text = "Код предмета 1:";
            // 
            // оценка_1Label
            // 
            оценка_1Label.AutoSize = true;
            оценка_1Label.Location = new System.Drawing.Point(78, 205);
            оценка_1Label.Name = "оценка_1Label";
            оценка_1Label.Size = new System.Drawing.Size(74, 17);
            оценка_1Label.TabIndex = 8;
            оценка_1Label.Text = "Оценка 1:";
            // 
            // дата_экзамена_2Label
            // 
            дата_экзамена_2Label.AutoSize = true;
            дата_экзамена_2Label.Location = new System.Drawing.Point(78, 265);
            дата_экзамена_2Label.Name = "дата_экзамена_2Label";
            дата_экзамена_2Label.Size = new System.Drawing.Size(124, 17);
            дата_экзамена_2Label.TabIndex = 10;
            дата_экзамена_2Label.Text = "Дата экзамена 2:";
            // 
            // код_предмета_2Label
            // 
            код_предмета_2Label.AutoSize = true;
            код_предмета_2Label.Location = new System.Drawing.Point(78, 304);
            код_предмета_2Label.Name = "код_предмета_2Label";
            код_предмета_2Label.Size = new System.Drawing.Size(117, 17);
            код_предмета_2Label.TabIndex = 12;
            код_предмета_2Label.Text = "Код предмета 2:";
            // 
            // оценка_2Label
            // 
            оценка_2Label.AutoSize = true;
            оценка_2Label.Location = new System.Drawing.Point(78, 347);
            оценка_2Label.Name = "оценка_2Label";
            оценка_2Label.Size = new System.Drawing.Size(74, 17);
            оценка_2Label.TabIndex = 14;
            оценка_2Label.Text = "Оценка 2:";
            // 
            // дата_экзамена_3Label
            // 
            дата_экзамена_3Label.AutoSize = true;
            дата_экзамена_3Label.Location = new System.Drawing.Point(78, 412);
            дата_экзамена_3Label.Name = "дата_экзамена_3Label";
            дата_экзамена_3Label.Size = new System.Drawing.Size(124, 17);
            дата_экзамена_3Label.TabIndex = 16;
            дата_экзамена_3Label.Text = "Дата экзамена 3:";
            // 
            // код_предмета_3Label
            // 
            код_предмета_3Label.AutoSize = true;
            код_предмета_3Label.Location = new System.Drawing.Point(78, 455);
            код_предмета_3Label.Name = "код_предмета_3Label";
            код_предмета_3Label.Size = new System.Drawing.Size(117, 17);
            код_предмета_3Label.TabIndex = 18;
            код_предмета_3Label.Text = "Код предмета 3:";
            // 
            // оценка_3Label
            // 
            оценка_3Label.AutoSize = true;
            оценка_3Label.Location = new System.Drawing.Point(78, 499);
            оценка_3Label.Name = "оценка_3Label";
            оценка_3Label.Size = new System.Drawing.Size(74, 17);
            оценка_3Label.TabIndex = 20;
            оценка_3Label.Text = "Оценка 3:";
            // 
            // средний_баллLabel
            // 
            средний_баллLabel.AutoSize = true;
            средний_баллLabel.Location = new System.Drawing.Point(74, 572);
            средний_баллLabel.Name = "средний_баллLabel";
            средний_баллLabel.Size = new System.Drawing.Size(105, 17);
            средний_баллLabel.TabIndex = 22;
            средний_баллLabel.Text = "Средний балл:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(268, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Оценки\"";
            // 
            // оценкиBindingNavigator
            // 
            this.оценкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оценкиBindingNavigator.BindingSource = this.оценкиBindingSource;
            this.оценкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оценкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оценкиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.оценкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.оценкиBindingNavigatorSaveItem});
            this.оценкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.оценкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оценкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оценкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оценкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оценкиBindingNavigator.Name = "оценкиBindingNavigator";
            this.оценкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оценкиBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.оценкиBindingNavigator.TabIndex = 1;
            this.оценкиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // оценкиBindingNavigatorSaveItem
            // 
            this.оценкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оценкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оценкиBindingNavigatorSaveItem.Image")));
            this.оценкиBindingNavigatorSaveItem.Name = "оценкиBindingNavigatorSaveItem";
            this.оценкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.оценкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.оценкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.оценкиBindingNavigatorSaveItem_Click);
            // 
            // код_студентаTextBox
            // 
            this.код_студентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код студента", true));
            this.код_студентаTextBox.Location = new System.Drawing.Point(246, 81);
            this.код_студентаTextBox.Name = "код_студентаTextBox";
            this.код_студентаTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_студентаTextBox.TabIndex = 3;
            // 
            // дата_экзамена_1DateTimePicker
            // 
            this.дата_экзамена_1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата экзамена 1", true));
            this.дата_экзамена_1DateTimePicker.Location = new System.Drawing.Point(246, 120);
            this.дата_экзамена_1DateTimePicker.Name = "дата_экзамена_1DateTimePicker";
            this.дата_экзамена_1DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_экзамена_1DateTimePicker.TabIndex = 5;
            // 
            // код_предмета_1TextBox
            // 
            this.код_предмета_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 1", true));
            this.код_предмета_1TextBox.Location = new System.Drawing.Point(246, 164);
            this.код_предмета_1TextBox.Name = "код_предмета_1TextBox";
            this.код_предмета_1TextBox.Size = new System.Drawing.Size(100, 22);
            this.код_предмета_1TextBox.TabIndex = 7;
            // 
            // оценка_1TextBox
            // 
            this.оценка_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 1", true));
            this.оценка_1TextBox.Location = new System.Drawing.Point(246, 215);
            this.оценка_1TextBox.Name = "оценка_1TextBox";
            this.оценка_1TextBox.Size = new System.Drawing.Size(100, 22);
            this.оценка_1TextBox.TabIndex = 9;
            // 
            // дата_экзамена_2DateTimePicker
            // 
            this.дата_экзамена_2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата экзамена 2", true));
            this.дата_экзамена_2DateTimePicker.Location = new System.Drawing.Point(246, 265);
            this.дата_экзамена_2DateTimePicker.Name = "дата_экзамена_2DateTimePicker";
            this.дата_экзамена_2DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_экзамена_2DateTimePicker.TabIndex = 11;
            // 
            // код_предмета_2TextBox
            // 
            this.код_предмета_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 2", true));
            this.код_предмета_2TextBox.Location = new System.Drawing.Point(246, 301);
            this.код_предмета_2TextBox.Name = "код_предмета_2TextBox";
            this.код_предмета_2TextBox.Size = new System.Drawing.Size(100, 22);
            this.код_предмета_2TextBox.TabIndex = 13;
            // 
            // оценка_2TextBox
            // 
            this.оценка_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 2", true));
            this.оценка_2TextBox.Location = new System.Drawing.Point(246, 347);
            this.оценка_2TextBox.Name = "оценка_2TextBox";
            this.оценка_2TextBox.Size = new System.Drawing.Size(100, 22);
            this.оценка_2TextBox.TabIndex = 15;
            // 
            // дата_экзамена_3DateTimePicker
            // 
            this.дата_экзамена_3DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата экзамена 3", true));
            this.дата_экзамена_3DateTimePicker.Location = new System.Drawing.Point(246, 412);
            this.дата_экзамена_3DateTimePicker.Name = "дата_экзамена_3DateTimePicker";
            this.дата_экзамена_3DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_экзамена_3DateTimePicker.TabIndex = 17;
            // 
            // код_предмета_3TextBox
            // 
            this.код_предмета_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 3", true));
            this.код_предмета_3TextBox.Location = new System.Drawing.Point(246, 455);
            this.код_предмета_3TextBox.Name = "код_предмета_3TextBox";
            this.код_предмета_3TextBox.Size = new System.Drawing.Size(100, 22);
            this.код_предмета_3TextBox.TabIndex = 19;
            // 
            // оценка_3TextBox
            // 
            this.оценка_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 3", true));
            this.оценка_3TextBox.Location = new System.Drawing.Point(246, 499);
            this.оценка_3TextBox.Name = "оценка_3TextBox";
            this.оценка_3TextBox.Size = new System.Drawing.Size(100, 22);
            this.оценка_3TextBox.TabIndex = 21;
            // 
            // средний_баллTextBox
            // 
            this.средний_баллTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource1, "Средний балл", true));
            this.средний_баллTextBox.Location = new System.Drawing.Point(246, 569);
            this.средний_баллTextBox.Name = "средний_баллTextBox";
            this.средний_баллTextBox.Size = new System.Drawing.Size(100, 22);
            this.средний_баллTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BD_Students.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = this.оценкиTableAdapter;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            // 
            // studentsDataSet1
            // 
            this.studentsDataSet1.DataSetName = "StudentsDataSet";
            this.studentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оценкиBindingSource1
            // 
            this.оценкиBindingSource1.DataMember = "Оценки";
            this.оценкиBindingSource1.DataSource = this.studentsDataSet1;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(средний_баллLabel);
            this.Controls.Add(this.средний_баллTextBox);
            this.Controls.Add(оценка_3Label);
            this.Controls.Add(this.оценка_3TextBox);
            this.Controls.Add(код_предмета_3Label);
            this.Controls.Add(this.код_предмета_3TextBox);
            this.Controls.Add(дата_экзамена_3Label);
            this.Controls.Add(this.дата_экзамена_3DateTimePicker);
            this.Controls.Add(оценка_2Label);
            this.Controls.Add(this.оценка_2TextBox);
            this.Controls.Add(код_предмета_2Label);
            this.Controls.Add(this.код_предмета_2TextBox);
            this.Controls.Add(дата_экзамена_2Label);
            this.Controls.Add(this.дата_экзамена_2DateTimePicker);
            this.Controls.Add(оценка_1Label);
            this.Controls.Add(this.оценка_1TextBox);
            this.Controls.Add(код_предмета_1Label);
            this.Controls.Add(this.код_предмета_1TextBox);
            this.Controls.Add(дата_экзамена_1Label);
            this.Controls.Add(this.дата_экзамена_1DateTimePicker);
            this.Controls.Add(код_студентаLabel);
            this.Controls.Add(this.код_студентаTextBox);
            this.Controls.Add(this.оценкиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingNavigator)).EndInit();
            this.оценкиBindingNavigator.ResumeLayout(false);
            this.оценкиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private StudentsDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оценкиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton оценкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_студентаTextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_1DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_1TextBox;
        private System.Windows.Forms.TextBox оценка_1TextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_2DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_2TextBox;
        private System.Windows.Forms.TextBox оценка_2TextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_3DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_3TextBox;
        private System.Windows.Forms.TextBox оценка_3TextBox;
        private System.Windows.Forms.TextBox средний_баллTextBox;
        private System.Windows.Forms.Button button1;
        private StudentsDataSet studentsDataSet1;
        private System.Windows.Forms.BindingSource оценкиBindingSource1;
    }
}