namespace Tyuiu.ZjatkovDV.Sprint6.Task7.V19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewOut = new DataGridView();
            dataGridViewIn = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            aboutButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1207, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(0, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1201, 123);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewOut);
            groupBox2.Controls.Add(dataGridViewIn);
            groupBox2.Location = new Point(12, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1207, 452);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результат";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(592, 22);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.Size = new Size(609, 424);
            dataGridViewOut.TabIndex = 1;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToDeleteRows = false;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(6, 22);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.Size = new Size(580, 424);
            dataGridViewIn.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(68, 49);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(86, 3);
            button2.Name = "button2";
            button2.Size = new Size(64, 49);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // aboutButton
            // 
            aboutButton.Image = (Image)resources.GetObject("aboutButton.Image");
            aboutButton.Location = new Point(1166, 6);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(53, 51);
            aboutButton.TabIndex = 4;
            aboutButton.UseMnemonic = false;
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 674);
            Controls.Add(aboutButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Зятьков Д.В.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button aboutButton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private DataGridView dataGridViewOut;
        private DataGridView dataGridViewIn;
    }
}
