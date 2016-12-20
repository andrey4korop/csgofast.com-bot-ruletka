namespace Бот_для_казино
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.redX = new System.Windows.Forms.TextBox();
            this.redY = new System.Windows.Forms.TextBox();
            this.blackY = new System.Windows.Forms.TextBox();
            this.blackX = new System.Windows.Forms.TextBox();
            this.krugY = new System.Windows.Forms.TextBox();
            this.krugX = new System.Windows.Forms.TextBox();
            this.moneyY = new System.Windows.Forms.TextBox();
            this.moneyX = new System.Windows.Forms.TextBox();
            this.money2Y = new System.Windows.Forms.TextBox();
            this.money2X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.countmoney = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.korzinaY = new System.Windows.Forms.TextBox();
            this.korzinaX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.minute = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maxmoney = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "го";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // redX
            // 
            this.redX.Location = new System.Drawing.Point(29, 31);
            this.redX.Name = "redX";
            this.redX.Size = new System.Drawing.Size(52, 20);
            this.redX.TabIndex = 4;
            this.redX.Text = "740";
            // 
            // redY
            // 
            this.redY.Location = new System.Drawing.Point(29, 57);
            this.redY.Name = "redY";
            this.redY.Size = new System.Drawing.Size(52, 20);
            this.redY.TabIndex = 4;
            this.redY.Text = "600";
            this.redY.TextChanged += new System.EventHandler(this.redY_TextChanged);
            // 
            // blackY
            // 
            this.blackY.Location = new System.Drawing.Point(97, 57);
            this.blackY.Name = "blackY";
            this.blackY.Size = new System.Drawing.Size(52, 20);
            this.blackY.TabIndex = 4;
            this.blackY.Text = "600";
            // 
            // blackX
            // 
            this.blackX.Location = new System.Drawing.Point(97, 31);
            this.blackX.Name = "blackX";
            this.blackX.Size = new System.Drawing.Size(52, 20);
            this.blackX.TabIndex = 4;
            this.blackX.Text = "984";
            // 
            // krugY
            // 
            this.krugY.Location = new System.Drawing.Point(168, 57);
            this.krugY.Name = "krugY";
            this.krugY.Size = new System.Drawing.Size(52, 20);
            this.krugY.TabIndex = 4;
            this.krugY.Text = "554";
            // 
            // krugX
            // 
            this.krugX.Location = new System.Drawing.Point(168, 31);
            this.krugX.Name = "krugX";
            this.krugX.Size = new System.Drawing.Size(52, 20);
            this.krugX.TabIndex = 4;
            this.krugX.Text = "428";
            // 
            // moneyY
            // 
            this.moneyY.Location = new System.Drawing.Point(237, 57);
            this.moneyY.Name = "moneyY";
            this.moneyY.Size = new System.Drawing.Size(52, 20);
            this.moneyY.TabIndex = 4;
            this.moneyY.Text = "411";
            // 
            // moneyX
            // 
            this.moneyX.Location = new System.Drawing.Point(237, 31);
            this.moneyX.Name = "moneyX";
            this.moneyX.Size = new System.Drawing.Size(52, 20);
            this.moneyX.TabIndex = 4;
            this.moneyX.Text = "823";
            // 
            // money2Y
            // 
            this.money2Y.Location = new System.Drawing.Point(307, 57);
            this.money2Y.Name = "money2Y";
            this.money2Y.Size = new System.Drawing.Size(52, 20);
            this.money2Y.TabIndex = 4;
            this.money2Y.Text = "462";
            // 
            // money2X
            // 
            this.money2X.Location = new System.Drawing.Point(307, 31);
            this.money2X.Name = "money2X";
            this.money2X.Size = new System.Drawing.Size(52, 20);
            this.money2X.TabIndex = 4;
            this.money2X.Text = "945";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Красный*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Черный*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Круг*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ввод суммы*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "х2*";
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // countmoney
            // 
            this.countmoney.Location = new System.Drawing.Point(36, 262);
            this.countmoney.Name = "countmoney";
            this.countmoney.Size = new System.Drawing.Size(79, 20);
            this.countmoney.TabIndex = 4;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // korzinaY
            // 
            this.korzinaY.Location = new System.Drawing.Point(375, 57);
            this.korzinaY.Name = "korzinaY";
            this.korzinaY.Size = new System.Drawing.Size(52, 20);
            this.korzinaY.TabIndex = 4;
            this.korzinaY.Text = "462";
            // 
            // korzinaX
            // 
            this.korzinaX.Location = new System.Drawing.Point(375, 31);
            this.korzinaX.Name = "korzinaX";
            this.korzinaX.Size = new System.Drawing.Size(52, 20);
            this.korzinaX.TabIndex = 4;
            this.korzinaX.Text = "724";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Корзина*";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "стоп";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(49, 112);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(100, 20);
            this.minute.TabIndex = 8;
            this.minute.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Обновление страници (мин)*";
            // 
            // maxmoney
            // 
            this.maxmoney.Location = new System.Drawing.Point(193, 112);
            this.maxmoney.Name = "maxmoney";
            this.maxmoney.Size = new System.Drawing.Size(100, 20);
            this.maxmoney.TabIndex = 10;
            this.maxmoney.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Максимальная ставка*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Х=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Y=";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(448, 32);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(221, 323);
            this.log.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 358);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maxmoney);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.korzinaX);
            this.Controls.Add(this.korzinaY);
            this.Controls.Add(this.money2X);
            this.Controls.Add(this.money2Y);
            this.Controls.Add(this.moneyX);
            this.Controls.Add(this.moneyY);
            this.Controls.Add(this.krugX);
            this.Controls.Add(this.krugY);
            this.Controls.Add(this.blackX);
            this.Controls.Add(this.blackY);
            this.Controls.Add(this.redX);
            this.Controls.Add(this.redY);
            this.Controls.Add(this.countmoney);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Бот CSGOfast.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox redX;
        private System.Windows.Forms.TextBox redY;
        private System.Windows.Forms.TextBox blackY;
        private System.Windows.Forms.TextBox blackX;
        private System.Windows.Forms.TextBox krugY;
        private System.Windows.Forms.TextBox krugX;
        private System.Windows.Forms.TextBox moneyY;
        private System.Windows.Forms.TextBox moneyX;
        private System.Windows.Forms.TextBox money2Y;
        private System.Windows.Forms.TextBox money2X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox countmoney;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox korzinaY;
        private System.Windows.Forms.TextBox korzinaX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maxmoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox log;
    }
}

