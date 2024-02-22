namespace Kursach
{
    partial class CreateForm
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
            Ready = new Button();
            Age = new Label();
            Height = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Health = new CheckBox();
            ObjName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Ready
            // 
            Ready.Location = new Point(37, 237);
            Ready.Name = "Ready";
            Ready.Size = new Size(112, 34);
            Ready.TabIndex = 0;
            Ready.Text = "Готово";
            Ready.UseVisualStyleBackColor = true;
            Ready.Click += Ready_Click;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(37, 36);
            Age.Name = "Age";
            Age.Size = new Size(76, 25);
            Age.TabIndex = 4;
            Age.Text = "Возраст";
            // 
            // Height
            // 
            Height.AutoSize = true;
            Height.Location = new Point(37, 120);
            Height.Name = "Height";
            Height.Size = new Size(70, 25);
            Height.TabIndex = 5;
            Height.Text = "Высота";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(37, 64);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(112, 31);
            textBox4.TabIndex = 9;
            // 
            // Health
            // 
            Health.AutoSize = true;
            Health.Location = new Point(37, 202);
            Health.Name = "Health";
            Health.Size = new Size(94, 29);
            Health.TabIndex = 10;
            Health.Text = "Живое";
            Health.UseVisualStyleBackColor = true;
            Health.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ObjName
            // 
            ObjName.Location = new Point(190, 64);
            ObjName.Name = "ObjName";
            ObjName.Size = new Size(150, 31);
            ObjName.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 12;
            label1.Text = "Имя";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 288);
            Controls.Add(label1);
            Controls.Add(ObjName);
            Controls.Add(Health);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(Height);
            Controls.Add(Age);
            Controls.Add(Ready);

            Text = "CreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ready;
        private Label label2;
        private Label label3;
        private Label Age;
        private Label Height;
        private TextBox ObjName;
        private TextBox textBox3;
        private TextBox textBox4;
        private CheckBox Health;
        private Label label1;
    }
}