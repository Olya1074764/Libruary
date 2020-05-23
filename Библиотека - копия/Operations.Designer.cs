namespace Библиотека
{
    partial class Operations
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
            this.button_autors = new System.Windows.Forms.Button();
            this.button_books = new System.Windows.Forms.Button();
            this.button_readers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_autors
            // 
            this.button_autors.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_autors.Location = new System.Drawing.Point(239, 377);
            this.button_autors.Name = "button_autors";
            this.button_autors.Size = new System.Drawing.Size(304, 66);
            this.button_autors.TabIndex = 16;
            this.button_autors.Text = "Авторы";
            this.button_autors.UseVisualStyleBackColor = true;
            this.button_autors.Click += new System.EventHandler(this.button_autors_Click);
            // 
            // button_books
            // 
            this.button_books.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_books.Location = new System.Drawing.Point(239, 277);
            this.button_books.Name = "button_books";
            this.button_books.Size = new System.Drawing.Size(304, 66);
            this.button_books.TabIndex = 15;
            this.button_books.Text = "Книги";
            this.button_books.UseVisualStyleBackColor = true;
            this.button_books.Click += new System.EventHandler(this.button_books_Click);
            // 
            // button_readers
            // 
            this.button_readers.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_readers.Location = new System.Drawing.Point(239, 170);
            this.button_readers.Name = "button_readers";
            this.button_readers.Size = new System.Drawing.Size(304, 66);
            this.button_readers.TabIndex = 14;
            this.button_readers.Text = "Читатели";
            this.button_readers.UseVisualStyleBackColor = true;
            this.button_readers.Click += new System.EventHandler(this.button_readers_Click);
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
            this.panel1.TabIndex = 13;
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
            this.label1.Text = "Выбор операции";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.ControlBox = false;
            this.Controls.Add(this.button_autors);
            this.Controls.Add(this.button_books);
            this.Controls.Add(this.button_readers);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(820, 540);
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "Operations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_autors;
        private System.Windows.Forms.Button button_books;
        private System.Windows.Forms.Button button_readers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}