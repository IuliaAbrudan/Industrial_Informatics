namespace WinFormsApp4
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Programari Online";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(183, 215);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ana Doina", "Maria Papuc", "Dorina Iancu", "Anamaria Repciuc" });
            comboBox1.Location = new Point(183, 308);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 569);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(651, 598);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 5;
            button1.Text = "Programeaza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 626);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 215);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 7;
            label2.Text = "Alege data: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 308);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 8;
            label3.Text = "Alege specialustul: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 381);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 9;
            label4.Text = "Alege serviciul: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 575);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 10;
            label5.Text = "Nume: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 632);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 11;
            label6.Text = "Prenume: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(518, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1040, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(183, 381);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(202, 29);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Oja semipermanenta";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(182, 429);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(165, 29);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Oja permanenta";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(182, 474);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(197, 29);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "Indepartare material";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(181, 519);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(255, 29);
            checkBox4.TabIndex = 18;
            checkBox4.Text = "Pedichiura semipermanenta";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 715);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
