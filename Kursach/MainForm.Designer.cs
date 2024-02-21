namespace Kursach
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            AddObj = new Button();
            ViewProperties = new Button();
            RunMethod = new Button();
            DelObj = new Button();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, загрузитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(200, 34);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(200, 34);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1020, 519);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Blue;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(comboBox2, 0, 4);
            tableLayoutPanel2.Controls.Add(AddObj, 0, 2);
            tableLayoutPanel2.Controls.Add(ViewProperties, 0, 5);
            tableLayoutPanel2.Controls.Add(RunMethod, 0, 6);
            tableLayoutPanel2.Controls.Add(DelObj, 0, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tableLayoutPanel2.ForeColor = Color.Chartreuse;
            tableLayoutPanel2.Location = new Point(717, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            tableLayoutPanel2.Size = new Size(300, 513);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 71);
            label1.TabIndex = 0;
            label1.Text = "Выберите клас для создания";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(3, 173);
            label2.Name = "label2";
            label2.Size = new Size(294, 35);
            label2.TabIndex = 1;
            label2.Text = "Выберите объект";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 33);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 211);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(294, 33);
            comboBox2.TabIndex = 3;
            // 
            // AddObj
            // 
            AddObj.Dock = DockStyle.Fill;
            AddObj.FlatStyle = FlatStyle.System;
            AddObj.ForeColor = Color.DarkOrange;
            AddObj.Location = new Point(3, 125);
            AddObj.Name = "AddObj";
            AddObj.Size = new Size(294, 45);
            AddObj.TabIndex = 4;
            AddObj.Text = "Создать";
            AddObj.UseVisualStyleBackColor = true;
            AddObj.Click += AddObj_Click;
            // 
            // ViewProperties
            // 
            ViewProperties.Dock = DockStyle.Fill;
            ViewProperties.FlatStyle = FlatStyle.System;
            ViewProperties.ForeColor = Color.DarkOrange;
            ViewProperties.Location = new Point(3, 262);
            ViewProperties.Name = "ViewProperties";
            ViewProperties.Size = new Size(294, 45);
            ViewProperties.TabIndex = 5;
            ViewProperties.Text = "Показать свойства";
            ViewProperties.UseVisualStyleBackColor = true;
            ViewProperties.Click += ViewProperties_Click;
            // 
            // RunMethod
            // 
            RunMethod.Dock = DockStyle.Fill;
            RunMethod.FlatStyle = FlatStyle.System;
            RunMethod.ForeColor = Color.DarkOrange;
            RunMethod.Location = new Point(3, 313);
            RunMethod.Name = "RunMethod";
            RunMethod.Size = new Size(294, 45);
            RunMethod.TabIndex = 6;
            RunMethod.Text = "Методы";
            RunMethod.UseVisualStyleBackColor = true;
            RunMethod.Click += RunMethod_Click;
            // 
            // DelObj
            // 
            DelObj.Dock = DockStyle.Fill;
            DelObj.FlatStyle = FlatStyle.System;
            DelObj.ForeColor = Color.DarkOrange;
            DelObj.Location = new Point(3, 364);
            DelObj.Name = "DelObj";
            DelObj.Size = new Size(294, 45);
            DelObj.TabIndex = 7;
            DelObj.Text = "Удалить";
            DelObj.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.Dock = DockStyle.Fill;
            textBox1.ForeColor = Color.GreenYellow;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(708, 513);
            textBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 552);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button AddObj;
        private Button ViewProperties;
        private Button RunMethod;
        private Button DelObj;
        private TextBox textBox1;
    }
}