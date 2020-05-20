namespace PP_Z9_WinForms_
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
            this.Zadanie_1 = new System.Windows.Forms.GroupBox();
            this.Zadanie_2 = new System.Windows.Forms.GroupBox();
            this.num = new System.Windows.Forms.Label();
            this.enter_n = new System.Windows.Forms.TextBox();
            this.ogran_k = new System.Windows.Forms.Label();
            this.enter_k = new System.Windows.Forms.TextBox();
            this.arr_n = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.Button();
            this.injured_str = new System.Windows.Forms.Label();
            this.out_str = new System.Windows.Forms.RichTextBox();
            this.Print = new System.Windows.Forms.Button();
            this.Zadanie_1.SuspendLayout();
            this.Zadanie_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie_1
            // 
            this.Zadanie_1.Controls.Add(this.Result);
            this.Zadanie_1.Controls.Add(this.arr_n);
            this.Zadanie_1.Controls.Add(this.enter_k);
            this.Zadanie_1.Controls.Add(this.ogran_k);
            this.Zadanie_1.Controls.Add(this.enter_n);
            this.Zadanie_1.Controls.Add(this.num);
            this.Zadanie_1.Location = new System.Drawing.Point(2, 0);
            this.Zadanie_1.Name = "Zadanie_1";
            this.Zadanie_1.Size = new System.Drawing.Size(306, 276);
            this.Zadanie_1.TabIndex = 0;
            this.Zadanie_1.TabStop = false;
            this.Zadanie_1.Text = "Задание 1";
            // 
            // Zadanie_2
            // 
            this.Zadanie_2.Controls.Add(this.Print);
            this.Zadanie_2.Controls.Add(this.out_str);
            this.Zadanie_2.Controls.Add(this.injured_str);
            this.Zadanie_2.Location = new System.Drawing.Point(314, 0);
            this.Zadanie_2.Name = "Zadanie_2";
            this.Zadanie_2.Size = new System.Drawing.Size(306, 276);
            this.Zadanie_2.TabIndex = 1;
            this.Zadanie_2.TabStop = false;
            this.Zadanie_2.Text = "Задание 2";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(10, 16);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(205, 13);
            this.num.TabIndex = 0;
            this.num.Text = "Введите размер последовательности: ";
            // 
            // enter_n
            // 
            this.enter_n.Location = new System.Drawing.Point(221, 13);
            this.enter_n.Name = "enter_n";
            this.enter_n.Size = new System.Drawing.Size(52, 20);
            this.enter_n.TabIndex = 1;
            // 
            // ogran_k
            // 
            this.ogran_k.AutoSize = true;
            this.ogran_k.Location = new System.Drawing.Point(10, 39);
            this.ogran_k.Name = "ogran_k";
            this.ogran_k.Size = new System.Drawing.Size(94, 13);
            this.ogran_k.TabIndex = 2;
            this.ogran_k.Text = "Заданное число: ";
            // 
            // enter_k
            // 
            this.enter_k.Location = new System.Drawing.Point(221, 36);
            this.enter_k.Name = "enter_k";
            this.enter_k.Size = new System.Drawing.Size(52, 20);
            this.enter_k.TabIndex = 3;
            // 
            // arr_n
            // 
            this.arr_n.Location = new System.Drawing.Point(13, 58);
            this.arr_n.Name = "arr_n";
            this.arr_n.Size = new System.Drawing.Size(157, 212);
            this.arr_n.TabIndex = 4;
            this.arr_n.Text = "";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(176, 117);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(124, 46);
            this.Result.TabIndex = 5;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // injured_str
            // 
            this.injured_str.AutoSize = true;
            this.injured_str.Location = new System.Drawing.Point(15, 16);
            this.injured_str.Name = "injured_str";
            this.injured_str.Size = new System.Drawing.Size(98, 13);
            this.injured_str.TabIndex = 0;
            this.injured_str.Text = "Нечетные строки:";
            // 
            // out_str
            // 
            this.out_str.Location = new System.Drawing.Point(18, 39);
            this.out_str.Name = "out_str";
            this.out_str.Size = new System.Drawing.Size(282, 149);
            this.out_str.TabIndex = 1;
            this.out_str.Text = "";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(94, 208);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(124, 46);
            this.Print.TabIndex = 2;
            this.Print.Text = "Вывести";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 278);
            this.Controls.Add(this.Zadanie_2);
            this.Controls.Add(this.Zadanie_1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Практика 9";
            this.Zadanie_1.ResumeLayout(false);
            this.Zadanie_1.PerformLayout();
            this.Zadanie_2.ResumeLayout(false);
            this.Zadanie_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie_1;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.RichTextBox arr_n;
        private System.Windows.Forms.TextBox enter_k;
        private System.Windows.Forms.Label ogran_k;
        private System.Windows.Forms.TextBox enter_n;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.GroupBox Zadanie_2;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.RichTextBox out_str;
        private System.Windows.Forms.Label injured_str;
    }
}

