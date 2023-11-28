namespace UP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonRefresh = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_proizvoditel = new System.Windows.Forms.TextBox();
            this.textBox_opisanie = new System.Windows.Forms.TextBox();
            this.textBox_Discount = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_name_book = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(831, 29);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(146, 20);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(983, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.Image")));
            this.ButtonRefresh.Location = new System.Drawing.Point(1032, 12);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(47, 37);
            this.ButtonRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRefresh.TabIndex = 3;
            this.ButtonRefresh.TabStop = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.textBox_proizvoditel);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBox_opisanie);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_Discount);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.textBox_name_book);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 204);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 12;

            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID";
            // 
            // textBox_proizvoditel
            // 
            this.textBox_proizvoditel.Location = new System.Drawing.Point(376, 165);
            this.textBox_proizvoditel.Name = "textBox_proizvoditel";
            this.textBox_proizvoditel.Size = new System.Drawing.Size(205, 20);
            this.textBox_proizvoditel.TabIndex = 10;
            // 
            // textBox_opisanie
            // 
            this.textBox_opisanie.Location = new System.Drawing.Point(376, 137);
            this.textBox_opisanie.Name = "textBox_opisanie";
            this.textBox_opisanie.Size = new System.Drawing.Size(205, 20);
            this.textBox_opisanie.TabIndex = 9;
            // 
            // textBox_Discount
            // 
            this.textBox_Discount.Location = new System.Drawing.Point(376, 111);
            this.textBox_Discount.Name = "textBox_Discount";
            this.textBox_Discount.Size = new System.Drawing.Size(205, 20);
            this.textBox_Discount.TabIndex = 8;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(376, 82);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(205, 20);
            this.textBox_Price.TabIndex = 7;
            // 
            // textBox_name_book
            // 
            this.textBox_name_book.Location = new System.Drawing.Point(376, 55);
            this.textBox_name_book.Name = "textBox_name_book";
            this.textBox_name_book.Size = new System.Drawing.Size(205, 20);
            this.textBox_name_book.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "производитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "скидка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "цена";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(283, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "название книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить товар: ";
            this.label1.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Управление";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(18, 81);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(92, 21);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(116, 81);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(92, 21);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(18, 111);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(92, 22);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(116, 114);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(92, 20);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UP.Properties.Resources.Form2;
            this.ClientSize = new System.Drawing.Size(1091, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ButtonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_proizvoditel;
        private System.Windows.Forms.TextBox textBox_opisanie;
        private System.Windows.Forms.TextBox textBox_Discount;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_name_book;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}