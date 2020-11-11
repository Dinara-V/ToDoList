namespace ToDoList
{
    partial class Login
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(47, 68);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 0;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(47, 126);
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '*';
            this.TBPass.Size = new System.Drawing.Size(100, 20);
            this.TBPass.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(47, 180);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(100, 23);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Войти";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // regBTN
            // 
            this.regBTN.Location = new System.Drawing.Point(47, 219);
            this.regBTN.Name = "regBTN";
            this.regBTN.Size = new System.Drawing.Size(100, 23);
            this.regBTN.TabIndex = 5;
            this.regBTN.Text = "Регистрация";
            this.regBTN.UseVisualStyleBackColor = true;
            this.regBTN.Click += new System.EventHandler(this.regBTN_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 294);
            this.Controls.Add(this.regBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regBTN;
    }
}

