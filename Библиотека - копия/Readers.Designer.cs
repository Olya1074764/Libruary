namespace Библиотека
{
    partial class Readers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.combobox_student = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new Библиотека.LibDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new Библиотека.LibDataSetTableAdapters.StudentTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.читателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читателиTableAdapter = new Библиотека.LibDataSetTableAdapters.ЧитателиTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.книгиTableAdapter = new Библиотека.LibDataSetTableAdapters.КнигиTableAdapter();
            this.label_del = new System.Windows.Forms.Label();
            this.label_ADD = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.списокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокTableAdapter = new Библиотека.LibDataSetTableAdapters.СписокTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 89);
            this.panel1.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.BackgroundImage = global::Библиотека.Properties.Resources.close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(752, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 33;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Читатели";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(599, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 33);
            this.button1.TabIndex = 53;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(386, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 33);
            this.button3.TabIndex = 52;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // combobox_student
            // 
            this.combobox_student.DataSource = this.studentBindingSource;
            this.combobox_student.DisplayMember = "name";
            this.combobox_student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_student.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combobox_student.FormattingEnabled = true;
            this.combobox_student.Location = new System.Drawing.Point(10, 114);
            this.combobox_student.Name = "combobox_student";
            this.combobox_student.Size = new System.Drawing.Size(359, 21);
            this.combobox_student.TabIndex = 74;
            this.combobox_student.ValueMember = "ID";
            this.combobox_student.SelectedIndexChanged += new System.EventHandler(this.combobox_student_SelectedIndexChanged_1);
            this.combobox_student.Click += new System.EventHandler(this.NOTREADERS_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.libDataSet;
            // 
            // libDataSet
            // 
            this.libDataSet.DataSetName = "LibDataSet";
            this.libDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 73;
            this.label4.Text = "Выберите учащегося:";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "Выберите читателя:";
            // 
            // читателиBindingSource
            // 
            this.читателиBindingSource.DataMember = "Читатели";
            this.читателиBindingSource.DataSource = this.libDataSet;
            // 
            // читателиTableAdapter
            // 
            this.читателиTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.книгиBindingSource;
            this.comboBox2.DisplayMember = "Книга";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(359, 21);
            this.comboBox2.TabIndex = 80;
            this.comboBox2.ValueMember = "ID_book";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Click += new System.EventHandler(this.fillBy_Книга_принять_Click);
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.libDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Выберите книгу, которую нужно принять:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.книгиBindingSource;
            this.comboBox3.DisplayMember = "Книга";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(10, 208);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(359, 21);
            this.comboBox3.TabIndex = 78;
            this.comboBox3.ValueMember = "ID_book";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.Click += new System.EventHandler(this.ByКнига_датьClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 21);
            this.label5.TabIndex = 77;
            this.label5.Text = "Выберите книгу, которую нужно выдать:";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.читателиBindingSource;
            this.comboBox4.DisplayMember = "name";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(10, 160);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(359, 21);
            this.comboBox4.TabIndex = 81;
            this.comboBox4.ValueMember = "ID";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.Click += new System.EventHandler(this.READERS_Click);
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // label_del
            // 
            this.label_del.BackColor = System.Drawing.Color.LightGreen;
            this.label_del.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_del.Location = new System.Drawing.Point(589, 199);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(193, 19);
            this.label_del.TabIndex = 85;
            this.label_del.Text = "Успешно!";
            this.label_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_del.Visible = false;
            // 
            // label_ADD
            // 
            this.label_ADD.BackColor = System.Drawing.Color.LightGreen;
            this.label_ADD.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ADD.Location = new System.Drawing.Point(589, 141);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(193, 19);
            this.label_ADD.TabIndex = 84;
            this.label_ADD.Text = "Успешно!";
            this.label_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ADD.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(589, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 33);
            this.button5.TabIndex = 83;
            this.button5.Text = "Добавить запрос";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(589, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 33);
            this.button4.TabIndex = 82;
            this.button4.Text = "Добавить читателя";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_add_new_reader_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightGreen;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(589, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 19);
            this.label10.TabIndex = 87;
            this.label10.Text = "Успешно!";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(589, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 33);
            this.button6.TabIndex = 86;
            this.button6.Text = "Удалить запрос";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.классDataGridViewTextBoxColumn,
            this.фИОЧитателяDataGridViewTextBoxColumn,
            this.названиеКнигиDataGridViewTextBoxColumn,
            this.фИОАвтораDataGridViewTextBoxColumn,
            this.годКнигиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(803, 180);
            this.dataGridView1.TabIndex = 88;
            // 
            // списокBindingSource
            // 
            this.списокBindingSource.DataMember = "Список";
            this.списокBindingSource.DataSource = this.libDataSet;
            // 
            // списокTableAdapter
            // 
            this.списокTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "№";
            this.dataGridViewTextBoxColumn1.FillWeight = 37.84079F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // классDataGridViewTextBoxColumn
            // 
            this.классDataGridViewTextBoxColumn.DataPropertyName = "Класс";
            this.классDataGridViewTextBoxColumn.FillWeight = 45.68529F;
            this.классDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.классDataGridViewTextBoxColumn.Name = "классDataGridViewTextBoxColumn";
            // 
            // фИОЧитателяDataGridViewTextBoxColumn
            // 
            this.фИОЧитателяDataGridViewTextBoxColumn.DataPropertyName = "ФИО читателя";
            this.фИОЧитателяDataGridViewTextBoxColumn.FillWeight = 156.6988F;
            this.фИОЧитателяDataGridViewTextBoxColumn.HeaderText = "ФИО читателя";
            this.фИОЧитателяDataGridViewTextBoxColumn.Name = "фИОЧитателяDataGridViewTextBoxColumn";
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.FillWeight = 156.6988F;
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            // 
            // фИОАвтораDataGridViewTextBoxColumn
            // 
            this.фИОАвтораDataGridViewTextBoxColumn.DataPropertyName = "ФИО автора";
            this.фИОАвтораDataGridViewTextBoxColumn.FillWeight = 156.6988F;
            this.фИОАвтораDataGridViewTextBoxColumn.HeaderText = "ФИО автора";
            this.фИОАвтораDataGridViewTextBoxColumn.Name = "фИОАвтораDataGridViewTextBoxColumn";
            // 
            // годКнигиDataGridViewTextBoxColumn
            // 
            this.годКнигиDataGridViewTextBoxColumn.DataPropertyName = "Год книги";
            this.годКнигиDataGridViewTextBoxColumn.FillWeight = 46.3776F;
            this.годКнигиDataGridViewTextBoxColumn.HeaderText = "Год книги";
            this.годКнигиDataGridViewTextBoxColumn.Name = "годКнигиDataGridViewTextBoxColumn";
            // 
            // Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label_del);
            this.Controls.Add(this.label_ADD);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox_student);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(820, 540);
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "Readers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Readers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox combobox_student;
        private System.Windows.Forms.Label label4;
        private LibDataSet libDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LibDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource читателиBindingSource;
        private LibDataSetTableAdapters.ЧитателиTableAdapter читателиTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private LibDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource списокBindingSource;
        private LibDataSetTableAdapters.СписокTableAdapter списокTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn классDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годКнигиDataGridViewTextBoxColumn;
    }
}