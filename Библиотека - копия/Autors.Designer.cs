namespace Библиотека
{
    partial class Autors
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
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new Библиотека.LibDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.autorTableAdapter = new Библиотека.LibDataSetTableAdapters.AutorTableAdapter();
            this.New_autor_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.del_autor_name = new System.Windows.Forms.ComboBox();
            this.fKBookIDAuthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Библиотека.LibDataSetTableAdapters.BookTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.UP_autor_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label_ADD = new System.Windows.Forms.Label();
            this.label_del = new System.Windows.Forms.Label();
            this.label_edit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBookIDAuthorBindingSource)).BeginInit();
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
            this.label1.Text = "Авторы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Введите ФИО автора:";
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // New_autor_name
            // 
            this.New_autor_name.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_autor_name.Location = new System.Drawing.Point(12, 146);
            this.New_autor_name.Multiline = true;
            this.New_autor_name.Name = "New_autor_name";
            this.New_autor_name.Size = new System.Drawing.Size(271, 24);
            this.New_autor_name.TabIndex = 30;
            this.New_autor_name.TextChanged += new System.EventHandler(this.New_autor_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Выберите автора:";
            // 
            // del_autor_name
            // 
            this.del_autor_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.del_autor_name.DataSource = this.autorBindingSource;
            this.del_autor_name.DisplayMember = "name";
            this.del_autor_name.FormattingEnabled = true;
            this.del_autor_name.Location = new System.Drawing.Point(16, 278);
            this.del_autor_name.Name = "del_autor_name";
            this.del_autor_name.Size = new System.Drawing.Size(271, 21);
            this.del_autor_name.TabIndex = 32;
            this.del_autor_name.ValueMember = "ID";
            this.del_autor_name.SelectedIndexChanged += new System.EventHandler(this.del_autor_name_SelectedIndexChanged);
            this.del_autor_name.Click += new System.EventHandler(this.Autor_load);
            // 
            // fKBookIDAuthorBindingSource
            // 
            this.fKBookIDAuthorBindingSource.DataMember = "FK_Book_ID_Author";
            this.fKBookIDAuthorBindingSource.DataSource = this.autorBindingSource;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(377, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 33);
            this.button3.TabIndex = 34;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(590, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(599, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 33);
            this.button4.TabIndex = 36;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_add_new_autor_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(599, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 33);
            this.button5.TabIndex = 37;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_del_autor_Click);
            // 
            // UP_autor_name
            // 
            this.UP_autor_name.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP_autor_name.Location = new System.Drawing.Point(16, 396);
            this.UP_autor_name.Multiline = true;
            this.UP_autor_name.Name = "UP_autor_name";
            this.UP_autor_name.Size = new System.Drawing.Size(271, 24);
            this.UP_autor_name.TabIndex = 41;
            this.UP_autor_name.TextChanged += new System.EventHandler(this.UP_autor_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Введите новое ФИО автора:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(599, 389);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 33);
            this.button6.TabIndex = 42;
            this.button6.Text = "Обновить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_edit_autor_Click);
            // 
            // label_ADD
            // 
            this.label_ADD.BackColor = System.Drawing.Color.LightGreen;
            this.label_ADD.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ADD.Location = new System.Drawing.Point(599, 190);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(193, 19);
            this.label_ADD.TabIndex = 43;
            this.label_ADD.Text = "Успешно!";
            this.label_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ADD.Visible = false;
            // 
            // label_del
            // 
            this.label_del.BackColor = System.Drawing.Color.LightGreen;
            this.label_del.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_del.Location = new System.Drawing.Point(599, 311);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(193, 19);
            this.label_del.TabIndex = 44;
            this.label_del.Text = "Успешно!";
            this.label_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_del.Visible = false;
            // 
            // label_edit
            // 
            this.label_edit.BackColor = System.Drawing.Color.LightGreen;
            this.label_edit.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_edit.Location = new System.Drawing.Point(599, 434);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(193, 19);
            this.label_edit.TabIndex = 45;
            this.label_edit.Text = "Успешно!";
            this.label_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_edit.Visible = false;
            // 
            // Autors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.ControlBox = false;
            this.Controls.Add(this.label_edit);
            this.Controls.Add(this.label_del);
            this.Controls.Add(this.label_ADD);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.UP_autor_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.del_autor_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.New_autor_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 540);
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "Autors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBookIDAuthorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private LibDataSet libDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private LibDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private System.Windows.Forms.TextBox New_autor_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox del_autor_name;
        private System.Windows.Forms.BindingSource fKBookIDAuthorBindingSource;
        private LibDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox UP_autor_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.Label label_edit;
    }
}