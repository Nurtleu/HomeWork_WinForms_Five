namespace WinForms5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_fuel = new System.Windows.Forms.Label();
            this.label_fueling = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox4_Eat = new System.Windows.Forms.CheckBox();
            this.checkBox3_Eat = new System.Windows.Forms.CheckBox();
            this.checkBox2_Eat = new System.Windows.Forms.CheckBox();
            this.checkBox_Eat = new System.Windows.Forms.CheckBox();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.minicafelabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_fuel);
            this.panel1.Controls.Add(this.label_fueling);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 280);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена";
            // 
            // label_fuel
            // 
            this.label_fuel.AutoSize = true;
            this.label_fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fuel.Location = new System.Drawing.Point(3, 34);
            this.label_fuel.Name = "label_fuel";
            this.label_fuel.Size = new System.Drawing.Size(57, 16);
            this.label_fuel.TabIndex = 1;
            this.label_fuel.Text = "Бензин";
            // 
            // label_fueling
            // 
            this.label_fueling.AutoSize = true;
            this.label_fueling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fueling.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_fueling.Location = new System.Drawing.Point(3, 0);
            this.label_fueling.Name = "label_fueling";
            this.label_fueling.Size = new System.Drawing.Size(103, 16);
            this.label_fueling.TabIndex = 0;
            this.label_fueling.Text = "Автозаправка";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkBox4_Eat);
            this.panel2.Controls.Add(this.checkBox3_Eat);
            this.panel2.Controls.Add(this.checkBox2_Eat);
            this.panel2.Controls.Add(this.checkBox_Eat);
            this.panel2.Controls.Add(this.quantitylabel);
            this.panel2.Controls.Add(this.pricelabel);
            this.panel2.Controls.Add(this.minicafelabel);
            this.panel2.Location = new System.Drawing.Point(310, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 280);
            this.panel2.TabIndex = 1;
            // 
            // checkBox4_Eat
            // 
            this.checkBox4_Eat.AutoSize = true;
            this.checkBox4_Eat.Location = new System.Drawing.Point(7, 159);
            this.checkBox4_Eat.Name = "checkBox4_Eat";
            this.checkBox4_Eat.Size = new System.Drawing.Size(79, 17);
            this.checkBox4_Eat.TabIndex = 7;
            this.checkBox4_Eat.Text = "Кока-Кола";
            this.checkBox4_Eat.UseVisualStyleBackColor = true;
            // 
            // checkBox3_Eat
            // 
            this.checkBox3_Eat.AutoSize = true;
            this.checkBox3_Eat.Location = new System.Drawing.Point(6, 127);
            this.checkBox3_Eat.Name = "checkBox3_Eat";
            this.checkBox3_Eat.Size = new System.Drawing.Size(99, 17);
            this.checkBox3_Eat.TabIndex = 6;
            this.checkBox3_Eat.Text = "Карточка-Фри";
            this.checkBox3_Eat.UseVisualStyleBackColor = true;
            // 
            // checkBox2_Eat
            // 
            this.checkBox2_Eat.AutoSize = true;
            this.checkBox2_Eat.Location = new System.Drawing.Point(6, 94);
            this.checkBox2_Eat.Name = "checkBox2_Eat";
            this.checkBox2_Eat.Size = new System.Drawing.Size(80, 17);
            this.checkBox2_Eat.TabIndex = 5;
            this.checkBox2_Eat.Text = "Гамбургер";
            this.checkBox2_Eat.UseVisualStyleBackColor = true;
            // 
            // checkBox_Eat
            // 
            this.checkBox_Eat.AutoSize = true;
            this.checkBox_Eat.Location = new System.Drawing.Point(6, 62);
            this.checkBox_Eat.Name = "checkBox_Eat";
            this.checkBox_Eat.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Eat.TabIndex = 4;
            this.checkBox_Eat.Text = "Хот-Дог";
            this.checkBox_Eat.UseVisualStyleBackColor = true;
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantitylabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.quantitylabel.Location = new System.Drawing.Point(152, 31);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(86, 16);
            this.quantitylabel.TabIndex = 3;
            this.quantitylabel.Text = "Количество";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pricelabel.Location = new System.Drawing.Point(105, 31);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(41, 16);
            this.pricelabel.TabIndex = 2;
            this.pricelabel.Text = "Цена";
            // 
            // minicafelabel
            // 
            this.minicafelabel.AutoSize = true;
            this.minicafelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minicafelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.minicafelabel.Location = new System.Drawing.Point(3, 0);
            this.minicafelabel.Name = "minicafelabel";
            this.minicafelabel.Size = new System.Drawing.Size(82, 16);
            this.minicafelabel.TabIndex = 1;
            this.minicafelabel.Text = "Мини-Кафе";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(12, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 68);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(569, 418);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_fueling;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label minicafelabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox4_Eat;
        private System.Windows.Forms.CheckBox checkBox3_Eat;
        private System.Windows.Forms.CheckBox checkBox2_Eat;
        private System.Windows.Forms.CheckBox checkBox_Eat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_fuel;
    }
}

