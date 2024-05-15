namespace Reader
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
            mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            dataGridView1 = new DataGridView();
            Statisztika = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            Keresés = new Button();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateBatchSize = 0;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(529, 240);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Statisztika
            // 
            Statisztika.AutoSize = true;
            Statisztika.Location = new Point(554, 38);
            Statisztika.Name = "Statisztika";
            Statisztika.Size = new Size(59, 15);
            Statisztika.TabIndex = 1;
            Statisztika.Text = "Statisztika";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(572, 82);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Sorok száma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(719, 82);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "label";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(719, 112);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "label";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(719, 157);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "label";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(572, 112);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 6;
            label5.Text = "ERROROK száma:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(571, 157);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 7;
            label6.Text = "Debug-ok száma:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(580, 237);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 8;
            label7.Text = "Keresés:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 284);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 9;
            label8.Text = "Mező:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(587, 314);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 10;
            label9.Text = "Érték:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(658, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(658, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Keresés
            // 
            Keresés.Location = new Point(581, 354);
            Keresés.Name = "Keresés";
            Keresés.Size = new Size(75, 23);
            Keresés.TabIndex = 13;
            Keresés.Text = "Keresés";
            Keresés.UseVisualStyleBackColor = true;
            Keresés.Click += Keresés_Click;
            // 
            // button1
            // 
            button1.Location = new Point(704, 354);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Visszaállít";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(587, 399);
            button2.Name = "button2";
            button2.Size = new Size(180, 23);
            button2.TabIndex = 15;
            button2.Text = "Mentés másként";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(-1, 263);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 16;
            label10.Text = "Message:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(-1, 343);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 17;
            label11.Text = "Exception:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 255);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(446, 74);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 343);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(446, 74);
            textBox3.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Keresés);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Statisztika);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private DataGridView dataGridView1;
        private Label Statisztika;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button Keresés;
        private Button button1;
        private Button button2;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
