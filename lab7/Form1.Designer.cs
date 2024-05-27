
namespace lab7
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
            this.discipName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labNum = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.TextBox();
            this.yourFio = new System.Windows.Forms.TextBox();
            this.groupName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teacherFio = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // discipName
            // 
            this.discipName.Location = new System.Drawing.Point(31, 42);
            this.discipName.Name = "discipName";
            this.discipName.Size = new System.Drawing.Size(239, 20);
            this.discipName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название дисциплины:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "№";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название лабы:";
            // 
            // labNum
            // 
            this.labNum.Location = new System.Drawing.Point(31, 89);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(37, 20);
            this.labNum.TabIndex = 4;
            // 
            // labName
            // 
            this.labName.Location = new System.Drawing.Point(94, 89);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(176, 20);
            this.labName.TabIndex = 5;
            // 
            // yourFio
            // 
            this.yourFio.Location = new System.Drawing.Point(94, 147);
            this.yourFio.Name = "yourFio";
            this.yourFio.Size = new System.Drawing.Size(176, 20);
            this.yourFio.TabIndex = 6;
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(31, 147);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(42, 20);
            this.groupName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Твое ФИО:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Группа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ФИО преподавателя:";
            // 
            // teacherFio
            // 
            this.teacherFio.Location = new System.Drawing.Point(31, 202);
            this.teacherFio.Name = "teacherFio";
            this.teacherFio.Size = new System.Drawing.Size(239, 20);
            this.teacherFio.TabIndex = 11;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(94, 237);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(119, 23);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Сгенерировать";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab7.Properties.Resources.raiden2;
            this.ClientSize = new System.Drawing.Size(318, 307);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.teacherFio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.yourFio);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discipName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox discipName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labNum;
        private System.Windows.Forms.TextBox labName;
        private System.Windows.Forms.TextBox yourFio;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teacherFio;
        private System.Windows.Forms.Button createButton;
    }
}

