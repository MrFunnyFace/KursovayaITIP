namespace Kursach
{
    partial class MhetodForm
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
            comboBox1 = new ComboBox();
            Run = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 33);
            comboBox1.TabIndex = 0;
            // 
            // Run
            // 
            Run.Location = new Point(203, 140);
            Run.Name = "Run";
            Run.Size = new Size(112, 34);
            Run.TabIndex = 1;
            Run.Text = "Выполнить";
            Run.UseVisualStyleBackColor = true;
            // 
            // MhetodForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 250);
            Controls.Add(Run);
            Controls.Add(comboBox1);
            Name = "MhetodForm";
            Text = "MhetodForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button Run;
    }
}