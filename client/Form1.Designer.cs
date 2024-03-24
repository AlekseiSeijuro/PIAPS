
namespace client
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
            this.setSizeButton = new System.Windows.Forms.Button();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.sendToServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setSizeButton
            // 
            this.setSizeButton.Location = new System.Drawing.Point(54, 74);
            this.setSizeButton.Name = "setSizeButton";
            this.setSizeButton.Size = new System.Drawing.Size(174, 48);
            this.setSizeButton.TabIndex = 0;
            this.setSizeButton.Text = "Установить размер";
            this.setSizeButton.UseVisualStyleBackColor = true;
            this.setSizeButton.Click += new System.EventHandler(this.setSizeButton_Click);
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(54, 22);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(176, 20);
            this.sizeInput.TabIndex = 1;
            this.sizeInput.TextChanged += new System.EventHandler(this.sizeInput_TextChanged);
            // 
            // sendToServerButton
            // 
            this.sendToServerButton.Location = new System.Drawing.Point(54, 162);
            this.sendToServerButton.Name = "sendToServerButton";
            this.sendToServerButton.Size = new System.Drawing.Size(174, 51);
            this.sendToServerButton.TabIndex = 2;
            this.sendToServerButton.Text = "Отправить на обработку";
            this.sendToServerButton.UseVisualStyleBackColor = true;
            this.sendToServerButton.Click += new System.EventHandler(this.sendToServerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendToServerButton);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.setSizeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setSizeButton;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.Button sendToServerButton;
    }
}

