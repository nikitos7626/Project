namespace UP
{
    partial class Buy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            this.buttonBackToProfile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьВКорзинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОТовареToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTovar = new System.Windows.Forms.ListView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTovar = new System.Windows.Forms.ListView();
            this.Zakaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackToProfile
            // 
            this.buttonBackToProfile.Location = new System.Drawing.Point(16, 511);
            this.buttonBackToProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBackToProfile.Name = "buttonBackToProfile";
            this.buttonBackToProfile.Size = new System.Drawing.Size(100, 28);
            this.buttonBackToProfile.TabIndex = 0;
            this.buttonBackToProfile.Text = "Назад";
            this.buttonBackToProfile.UseVisualStyleBackColor = true;
            this.buttonBackToProfile.Click += new System.EventHandler(this.buttonBackToProfile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 277);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВКорзинуToolStripMenuItem,
            this.информацияОТовареToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 52);
            // 
            // добавитьВКорзинуToolStripMenuItem
            // 
            this.добавитьВКорзинуToolStripMenuItem.Name = "добавитьВКорзинуToolStripMenuItem";
            this.добавитьВКорзинуToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.добавитьВКорзинуToolStripMenuItem.Text = "Добавить в корзину";
            this.добавитьВКорзинуToolStripMenuItem.Click += new System.EventHandler(this.добавитьВКорзинуToolStripMenuItem_Click);
            // 
            // информацияОТовареToolStripMenuItem
            // 
            this.информацияОТовареToolStripMenuItem.Name = "информацияОТовареToolStripMenuItem";
            this.информацияОТовареToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.информацияОТовареToolStripMenuItem.Text = "Информация о товаре";
            this.информацияОТовареToolStripMenuItem.Click += new System.EventHandler(this.информацияОТовареToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 510);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Корзина";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTovar
            // 
            this.nameTovar.ContextMenuStrip = this.contextMenuStrip2;
            this.nameTovar.HideSelection = false;
            this.nameTovar.Location = new System.Drawing.Point(780, 342);
            this.nameTovar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTovar.Name = "nameTovar";
            this.nameTovar.Size = new System.Drawing.Size(269, 118);
            this.nameTovar.TabIndex = 4;
            this.nameTovar.UseCompatibleStateImageBehavior = false;
            this.nameTovar.View = System.Windows.Forms.View.List;
            this.nameTovar.SelectedIndexChanged += new System.EventHandler(this.nameTovar_SelectedIndexChanged);
            this.nameTovar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nameTovar_MouseUp);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьТоварToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(179, 28);
            // 
            // удалитьТоварToolStripMenuItem
            // 
            this.удалитьТоварToolStripMenuItem.Name = "удалитьТоварToolStripMenuItem";
            this.удалитьТоварToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.удалитьТоварToolStripMenuItem.Text = "Удалить товар";
            this.удалитьТоварToolStripMenuItem.Click += new System.EventHandler(this.удалитьТоварToolStripMenuItem_Click);
            // 
            // infoTovar
            // 
            this.infoTovar.HideSelection = false;
            this.infoTovar.Location = new System.Drawing.Point(16, 342);
            this.infoTovar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoTovar.Name = "infoTovar";
            this.infoTovar.Size = new System.Drawing.Size(755, 118);
            this.infoTovar.TabIndex = 5;
            this.infoTovar.UseCompatibleStateImageBehavior = false;
            this.infoTovar.View = System.Windows.Forms.View.List;
            // 
            // Zakaz
            // 
            this.Zakaz.Location = new System.Drawing.Point(889, 507);
            this.Zakaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zakaz.Name = "Zakaz";
            this.Zakaz.Size = new System.Drawing.Size(161, 28);
            this.Zakaz.TabIndex = 6;
            this.Zakaz.Text = "Оформить заказ";
            this.Zakaz.UseVisualStyleBackColor = true;
            this.Zakaz.Click += new System.EventHandler(this.Zakaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 513);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Итог корзины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Описание товара";
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Zakaz);
            this.Controls.Add(this.infoTovar);
            this.Controls.Add(this.nameTovar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBackToProfile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Buy";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.Buy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToProfile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView nameTovar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВКорзинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОТовареToolStripMenuItem;
        private System.Windows.Forms.ListView infoTovar;
        private System.Windows.Forms.Button Zakaz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem удалитьТоварToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}