
namespace lab6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.selectAll = new System.Windows.Forms.Button();
            this.buyInput = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.ticketArea = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(850, 76);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(132, 20);
            this.fromInput.TabIndex = 1;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(1028, 76);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(132, 20);
            this.toInput.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(932, 118);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(178, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Выбрать";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // selectAll
            // 
            this.selectAll.Location = new System.Drawing.Point(334, 466);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(170, 23);
            this.selectAll.TabIndex = 4;
            this.selectAll.Text = "Показать всё";
            this.selectAll.UseVisualStyleBackColor = true;
            // 
            // buyInput
            // 
            this.buyInput.Location = new System.Drawing.Point(962, 219);
            this.buyInput.Name = "buyInput";
            this.buyInput.Size = new System.Drawing.Size(100, 20);
            this.buyInput.TabIndex = 5;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(975, 267);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // ticketArea
            // 
            this.ticketArea.Location = new System.Drawing.Point(109, 26);
            this.ticketArea.Name = "ticketArea";
            this.ticketArea.ReadOnly = true;
            this.ticketArea.Size = new System.Drawing.Size(669, 420);
            this.ticketArea.TabIndex = 7;
            this.ticketArea.Text = "";
            this.ticketArea.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 618);
            this.Controls.Add(this.ticketArea);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.buyInput);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.TextBox buyInput;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.RichTextBox ticketArea;
    }
}

