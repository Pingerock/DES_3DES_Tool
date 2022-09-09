namespace DES_3DES
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_FileDialog = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.radioButton_Encode = new System.Windows.Forms.RadioButton();
            this.radioButton_Decode = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_3DES = new System.Windows.Forms.RadioButton();
            this.radioButton_DES = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source file path:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button_FileDialog
            // 
            this.button_FileDialog.Location = new System.Drawing.Point(492, 37);
            this.button_FileDialog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_FileDialog.Name = "button_FileDialog";
            this.button_FileDialog.Size = new System.Drawing.Size(100, 28);
            this.button_FileDialog.TabIndex = 2;
            this.button_FileDialog.Text = "Explore";
            this.button_FileDialog.UseVisualStyleBackColor = true;
            this.button_FileDialog.Click += new System.EventHandler(this.button_FileDialog_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(499, 368);
            this.button_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(100, 28);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // radioButton_Encode
            // 
            this.radioButton_Encode.AutoSize = true;
            this.radioButton_Encode.Location = new System.Drawing.Point(8, 23);
            this.radioButton_Encode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Encode.Name = "radioButton_Encode";
            this.radioButton_Encode.Size = new System.Drawing.Size(73, 20);
            this.radioButton_Encode.TabIndex = 4;
            this.radioButton_Encode.TabStop = true;
            this.radioButton_Encode.Text = "Encrypt";
            this.radioButton_Encode.UseVisualStyleBackColor = true;
            // 
            // radioButton_Decode
            // 
            this.radioButton_Decode.AutoSize = true;
            this.radioButton_Decode.Location = new System.Drawing.Point(8, 52);
            this.radioButton_Decode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Decode.Name = "radioButton_Decode";
            this.radioButton_Decode.Size = new System.Drawing.Size(83, 20);
            this.radioButton_Decode.TabIndex = 5;
            this.radioButton_Decode.TabStop = true;
            this.radioButton_Decode.Text = "Decipher";
            this.radioButton_Decode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the fisrt key";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(17, 91);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(575, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter the second key(*)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(17, 145);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(575, 22);
            this.numericUpDown2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter the third key(*)";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(17, 199);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(575, 22);
            this.numericUpDown3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_3DES);
            this.groupBox1.Controls.Add(this.radioButton_DES);
            this.groupBox1.Location = new System.Drawing.Point(17, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(273, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption method";
            // 
            // radioButton_3DES
            // 
            this.radioButton_3DES.AutoSize = true;
            this.radioButton_3DES.Location = new System.Drawing.Point(8, 54);
            this.radioButton_3DES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_3DES.Name = "radioButton_3DES";
            this.radioButton_3DES.Size = new System.Drawing.Size(99, 20);
            this.radioButton_3DES.TabIndex = 1;
            this.radioButton_3DES.TabStop = true;
            this.radioButton_3DES.Text = "3DES(EDE)";
            this.radioButton_3DES.UseVisualStyleBackColor = true;
            // 
            // radioButton_DES
            // 
            this.radioButton_DES.AutoSize = true;
            this.radioButton_DES.Location = new System.Drawing.Point(9, 25);
            this.radioButton_DES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_DES.Name = "radioButton_DES";
            this.radioButton_DES.Size = new System.Drawing.Size(91, 20);
            this.radioButton_DES.TabIndex = 0;
            this.radioButton_DES.TabStop = true;
            this.radioButton_DES.Text = "DES(ECB)";
            this.radioButton_DES.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Encode);
            this.groupBox2.Controls.Add(this.radioButton_Decode);
            this.groupBox2.Location = new System.Drawing.Point(300, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(292, 123);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "(*) - uses only during 3DES encryption/decryption";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 407);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_FileDialog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DES / 3DES Tool";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_FileDialog;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.RadioButton radioButton_Encode;
        private System.Windows.Forms.RadioButton radioButton_Decode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_3DES;
        private System.Windows.Forms.RadioButton radioButton_DES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}

