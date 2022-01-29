
namespace lab2tiGot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cipher_txt = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Frequency_txt = new System.Windows.Forms.TextBox();
            this.Raed_file_button = new System.Windows.Forms.Button();
            this.Decryption_button = new System.Windows.Forms.Button();
            this.Plane_txt_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Plane_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зашифрованный текст\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Какую букву";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(499, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Расшифровать текст\r\n";
            // 
            // Cipher_txt
            // 
            this.Cipher_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Cipher_txt.Location = new System.Drawing.Point(13, 55);
            this.Cipher_txt.Multiline = true;
            this.Cipher_txt.Name = "Cipher_txt";
            this.Cipher_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Cipher_txt.Size = new System.Drawing.Size(295, 323);
            this.Cipher_txt.TabIndex = 3;
            this.Cipher_txt.TextChanged += new System.EventHandler(this.Cipher_txt_TextChanged);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.start.Location = new System.Drawing.Point(324, 28);
            this.start.Multiline = true;
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(113, 38);
            this.start.TabIndex = 4;
            this.start.TextChanged += new System.EventHandler(this.start_TextChanged);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.end.Location = new System.Drawing.Point(324, 98);
            this.end.Multiline = true;
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(113, 31);
            this.end.TabIndex = 5;
            this.end.TextChanged += new System.EventHandler(this.end_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(366, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "на\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(324, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Поменять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Frequency_txt
            // 
            this.Frequency_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Frequency_txt.Location = new System.Drawing.Point(314, 231);
            this.Frequency_txt.Multiline = true;
            this.Frequency_txt.Name = "Frequency_txt";
            this.Frequency_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Frequency_txt.Size = new System.Drawing.Size(141, 93);
            this.Frequency_txt.TabIndex = 8;
            this.Frequency_txt.TextChanged += new System.EventHandler(this.Frequency_txt_TextChanged);
            // 
            // Raed_file_button
            // 
            this.Raed_file_button.Location = new System.Drawing.Point(13, 396);
            this.Raed_file_button.Name = "Raed_file_button";
            this.Raed_file_button.Size = new System.Drawing.Size(164, 52);
            this.Raed_file_button.TabIndex = 9;
            this.Raed_file_button.Text = "Считать с файла\r\n";
            this.Raed_file_button.UseVisualStyleBackColor = true;
            this.Raed_file_button.Click += new System.EventHandler(this.Raed_file_button_Click);
            // 
            // Decryption_button
            // 
            this.Decryption_button.Location = new System.Drawing.Point(313, 331);
            this.Decryption_button.Name = "Decryption_button";
            this.Decryption_button.Size = new System.Drawing.Size(138, 47);
            this.Decryption_button.TabIndex = 10;
            this.Decryption_button.Text = "Расшифровать\r\n";
            this.Decryption_button.UseVisualStyleBackColor = true;
            this.Decryption_button.Click += new System.EventHandler(this.Decryption_button_Click);
            // 
            // Plane_txt_button
            // 
            this.Plane_txt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plane_txt_button.Location = new System.Drawing.Point(314, 174);
            this.Plane_txt_button.Name = "Plane_txt_button";
            this.Plane_txt_button.Size = new System.Drawing.Size(143, 34);
            this.Plane_txt_button.TabIndex = 11;
            this.Plane_txt_button.Text = "Исходный текст";
            this.Plane_txt_button.UseVisualStyleBackColor = true;
            this.Plane_txt_button.Click += new System.EventHandler(this.Plane_txt_button_Click_1);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(668, 401);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(110, 47);
            this.Clear_button.TabIndex = 12;
            this.Clear_button.Text = "Очистить\r\n";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click_1);
            // 
            // Plane_txt
            // 
            this.Plane_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Plane_txt.Location = new System.Drawing.Point(461, 55);
            this.Plane_txt.Multiline = true;
            this.Plane_txt.Name = "Plane_txt";
            this.Plane_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Plane_txt.Size = new System.Drawing.Size(327, 323);
            this.Plane_txt.TabIndex = 13;
            this.Plane_txt.TextChanged += new System.EventHandler(this.Plane_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(344, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "частота\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Plane_txt);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Plane_txt_button);
            this.Controls.Add(this.Decryption_button);
            this.Controls.Add(this.Raed_file_button);
            this.Controls.Add(this.Frequency_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Cipher_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cipher_txt;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Frequency_txt;
        private System.Windows.Forms.Button Raed_file_button;
        private System.Windows.Forms.Button Decryption_button;
        private System.Windows.Forms.Button Plane_txt_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.TextBox Plane_txt;
        private System.Windows.Forms.Label label5;
    }
}

