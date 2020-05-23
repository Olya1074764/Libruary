namespace Библиотека
{
    partial class Books
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
            this.labe_edit_name = new System.Windows.Forms.Label();
            this.label_del = new System.Windows.Forms.Label();
            this.label_ADD = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.UP_autor_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new Библиотека.LibDataSet();
            this.add_book_name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.book_year_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.autorTableAdapter = new Библиотека.LibDataSetTableAdapters.AutorTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Библиотека.LibDataSetTableAdapters.BookTableAdapter();
            this.fKBookstatusIDbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_statusTableAdapter = new Библиотека.LibDataSetTableAdapters.Book_statusTableAdapter();
            this.labe_edit_year = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.new_year_book_texbox = new System.Windows.Forms.TextBox();
            this.del_book_name_comboBox = new System.Windows.Forms.ComboBox();
            this.add_book_autor_name_combobox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBookstatusIDbookBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 26;
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
            this.label1.Text = "Книги";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labe_edit_name
            // 
            this.labe_edit_name.BackColor = System.Drawing.Color.LightGreen;
            this.labe_edit_name.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_edit_name.Location = new System.Drawing.Point(599, 337);
            this.labe_edit_name.Name = "labe_edit_name";
            this.labe_edit_name.Size = new System.Drawing.Size(193, 19);
            this.labe_edit_name.TabIndex = 59;
            this.labe_edit_name.Text = "Успешно!";
            this.labe_edit_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labe_edit_name.Visible = false;
            // 
            // label_del
            // 
            this.label_del.BackColor = System.Drawing.Color.LightGreen;
            this.label_del.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_del.Location = new System.Drawing.Point(599, 254);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(193, 19);
            this.label_del.TabIndex = 58;
            this.label_del.Text = "Успешно!";
            this.label_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_del.Visible = false;
            // 
            // label_ADD
            // 
            this.label_ADD.BackColor = System.Drawing.Color.LightGreen;
            this.label_ADD.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ADD.Location = new System.Drawing.Point(599, 163);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(193, 19);
            this.label_ADD.TabIndex = 57;
            this.label_ADD.Text = "Успешно!";
            this.label_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ADD.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(599, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 33);
            this.button6.TabIndex = 56;
            this.button6.Text = "Обновить название";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_edit_name_Click);
            // 
            // UP_autor_name
            // 
            this.UP_autor_name.Enabled = false;
            this.UP_autor_name.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP_autor_name.Location = new System.Drawing.Point(8, 310);
            this.UP_autor_name.Multiline = true;
            this.UP_autor_name.Name = "UP_autor_name";
            this.UP_autor_name.Size = new System.Drawing.Size(271, 24);
            this.UP_autor_name.TabIndex = 55;
            this.UP_autor_name.TextChanged += new System.EventHandler(this.UP_autor_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "2) Введите другое название книги:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(599, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 33);
            this.button5.TabIndex = 53;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_del_book_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(599, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 33);
            this.button4.TabIndex = 52;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_add_new_book_Click);
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
            this.button1.TabIndex = 51;
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
            this.button3.TabIndex = 50;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.libDataSet;
            // 
            // libDataSet
            // 
            this.libDataSet.DataSetName = "LibDataSet";
            this.libDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_book_name_textbox
            // 
            this.add_book_name_textbox.Enabled = false;
            this.add_book_name_textbox.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_book_name_textbox.Location = new System.Drawing.Point(8, 163);
            this.add_book_name_textbox.Multiline = true;
            this.add_book_name_textbox.Name = "add_book_name_textbox";
            this.add_book_name_textbox.Size = new System.Drawing.Size(269, 24);
            this.add_book_name_textbox.TabIndex = 47;
            this.add_book_name_textbox.TextChanged += new System.EventHandler(this.add_book_name_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "2!) Введите название книги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "1!) Выберите автора:";
            // 
            // book_year_textbox
            // 
            this.book_year_textbox.Enabled = false;
            this.book_year_textbox.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_year_textbox.Location = new System.Drawing.Point(342, 116);
            this.book_year_textbox.Multiline = true;
            this.book_year_textbox.Name = "book_year_textbox";
            this.book_year_textbox.Size = new System.Drawing.Size(174, 24);
            this.book_year_textbox.TabIndex = 62;
            this.book_year_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_year_textbox.TextChanged += new System.EventHandler(this.book_year_textbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "3!) Введите год книги:";
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 65;
            this.label7.Text = "1!) Выберите книгу:";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // fKBookstatusIDbookBindingSource
            // 
            this.fKBookstatusIDbookBindingSource.DataMember = "FK_Book_status_ID_book";
            this.fKBookstatusIDbookBindingSource.DataSource = this.bookBindingSource;
            // 
            // book_statusTableAdapter
            // 
            this.book_statusTableAdapter.ClearBeforeFill = true;
            // 
            // labe_edit_year
            // 
            this.labe_edit_year.BackColor = System.Drawing.Color.LightGreen;
            this.labe_edit_year.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_edit_year.Location = new System.Drawing.Point(599, 417);
            this.labe_edit_year.Name = "labe_edit_year";
            this.labe_edit_year.Size = new System.Drawing.Size(193, 19);
            this.labe_edit_year.TabIndex = 69;
            this.labe_edit_year.Text = "Успешно!";
            this.labe_edit_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labe_edit_year.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.Enabled = false;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(599, 381);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(193, 33);
            this.button7.TabIndex = 68;
            this.button7.Text = "Обновить год";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_edit_year_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 21);
            this.label10.TabIndex = 66;
            this.label10.Text = "3) Введите другой год:";
            // 
            // new_year_book_texbox
            // 
            this.new_year_book_texbox.Enabled = false;
            this.new_year_book_texbox.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_year_book_texbox.Location = new System.Drawing.Point(8, 388);
            this.new_year_book_texbox.Multiline = true;
            this.new_year_book_texbox.Name = "new_year_book_texbox";
            this.new_year_book_texbox.Size = new System.Drawing.Size(174, 24);
            this.new_year_book_texbox.TabIndex = 70;
            this.new_year_book_texbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_year_book_texbox.TextChanged += new System.EventHandler(this.new_year_book_texbox_TextChanged);
            // 
            // del_book_name_comboBox
            // 
            this.del_book_name_comboBox.DataSource = this.bookBindingSource;
            this.del_book_name_comboBox.DisplayMember = "name";
            this.del_book_name_comboBox.FormattingEnabled = true;
            this.del_book_name_comboBox.Location = new System.Drawing.Point(10, 232);
            this.del_book_name_comboBox.Name = "del_book_name_comboBox";
            this.del_book_name_comboBox.Size = new System.Drawing.Size(269, 21);
            this.del_book_name_comboBox.TabIndex = 71;
            this.del_book_name_comboBox.ValueMember = "ID";
            this.del_book_name_comboBox.SelectedIndexChanged += new System.EventHandler(this.del_book_name_comboBox_SelectedIndexChanged);
            this.del_book_name_comboBox.Click += new System.EventHandler(this.Book_name_year_loud);
            // 
            // add_book_autor_name_combobox
            // 
            this.add_book_autor_name_combobox.DataSource = this.autorBindingSource;
            this.add_book_autor_name_combobox.DisplayMember = "name";
            this.add_book_autor_name_combobox.FormattingEnabled = true;
            this.add_book_autor_name_combobox.Location = new System.Drawing.Point(8, 119);
            this.add_book_autor_name_combobox.Name = "add_book_autor_name_combobox";
            this.add_book_autor_name_combobox.Size = new System.Drawing.Size(271, 21);
            this.add_book_autor_name_combobox.TabIndex = 72;
            this.add_book_autor_name_combobox.ValueMember = "ID";
            this.add_book_autor_name_combobox.SelectedIndexChanged += new System.EventHandler(this.add_book_autor_name_combobox_SelectedIndexChanged);
            this.add_book_autor_name_combobox.Click += new System.EventHandler(this.Autor_load);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.ControlBox = false;
            this.Controls.Add(this.add_book_autor_name_combobox);
            this.Controls.Add(this.del_book_name_comboBox);
            this.Controls.Add(this.new_year_book_texbox);
            this.Controls.Add(this.labe_edit_year);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.book_year_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labe_edit_name);
            this.Controls.Add(this.label_del);
            this.Controls.Add(this.label_ADD);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.UP_autor_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.add_book_name_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(820, 540);
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Books_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBookstatusIDbookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labe_edit_name;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox UP_autor_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox add_book_name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox book_year_textbox;
        private System.Windows.Forms.Label label6;
        private LibDataSet libDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private LibDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource fKBookstatusIDbookBindingSource;
        private LibDataSetTableAdapters.Book_statusTableAdapter book_statusTableAdapter;
        private System.Windows.Forms.Label labe_edit_year;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox new_year_book_texbox;
        private System.Windows.Forms.ComboBox del_book_name_comboBox;
        private System.Windows.Forms.ComboBox add_book_autor_name_combobox;
    }
}