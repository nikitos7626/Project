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
            this.buttonBackToProfile.Location = new System.Drawing.Point(12, 415);
            this.buttonBackToProfile.Name = "buttonBackToProfile";
            this.buttonBackToProfile.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
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
            this.dataGridView1.Size = new System.Drawing.Size(776, 225);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВКорзинуToolStripMenuItem,
            this.информацияОТовареToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 48);
            // 
            // добавитьВКорзинуToolStripMenuItem
            // 
            this.добавитьВКорзинуToolStripMenuItem.Name = "добавитьВКорзинуToolStripMenuItem";
            this.добавитьВКорзинуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.добавитьВКорзинуToolStripMenuItem.Text = "Добавить в корзину";
            this.добавитьВКорзинуToolStripMenuItem.Click += new System.EventHandler(this.добавитьВКорзинуToolStripMenuItem_Click);
            // 
            // информацияОТовареToolStripMenuItem
            // 
            this.информацияОТовареToolStripMenuItem.Name = "информацияОТовареToolStripMenuItem";
            this.информацияОТовареToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.информацияОТовареToolStripMenuItem.Text = "Информация о товаре";
            this.информацияОТовареToolStripMenuItem.Click += new System.EventHandler(this.информацияОТовареToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Корзина";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTovar
            // 
            this.nameTovar.ContextMenuStrip = this.contextMenuStrip2;
            this.nameTovar.HideSelection = false;
            this.nameTovar.Location = new System.Drawing.Point(585, 278);
            this.nameTovar.Name = "nameTovar";
            this.nameTovar.Size = new System.Drawing.Size(203, 97);
            this.nameTovar.TabIndex = 4;
            this.nameTovar.UseCompatibleStateImageBehavior = false;
            this.nameTovar.View = System.Windows.Forms.View.List;
            this.nameTovar.SelectedIndexChanged += new System.EventHandler(this.nameTovar_SelectedIndexChanged);
            this.nameTovar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nameTovar_MouseUp);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьТоварToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 26);
            // 
            // удалитьТоварToolStripMenuItem
            // 
            this.удалитьТоварToolStripMenuItem.Name = "удалитьТоварToolStripMenuItem";
            this.удалитьТоварToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.удалитьТоварToolStripMenuItem.Text = "Удалить товар";
            this.удалитьТоварToolStripMenuItem.Click += new System.EventHandler(this.удалитьТоварToolStripMenuItem_Click);
            // 
            // infoTovar
            // 
            this.infoTovar.HideSelection = false;
            this.infoTovar.Location = new System.Drawing.Point(12, 278);
            this.infoTovar.Name = "infoTovar";
            this.infoTovar.Size = new System.Drawing.Size(567, 97);
            this.infoTovar.TabIndex = 5;
            this.infoTovar.UseCompatibleStateImageBehavior = false;
            this.infoTovar.View = System.Windows.Forms.View.List;
            // 
            // Zakaz
            // 
            this.Zakaz.Location = new System.Drawing.Point(667, 412);
            this.Zakaz.Name = "Zakaz";
            this.Zakaz.Size = new System.Drawing.Size(121, 23);
            this.Zakaz.TabIndex = 6;
            this.Zakaz.Text = "Оформить заказ";
            this.Zakaz.UseVisualStyleBackColor = true;
            this.Zakaz.Click += new System.EventHandler(this.Zakaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Итог корзины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Описание товара";
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UP.Properties.Resources._9b625d42db115ccd1d56ab1c7c132d86;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Zakaz);
            this.Controls.Add(this.infoTovar);
            this.Controls.Add(this.nameTovar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBackToProfile);
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