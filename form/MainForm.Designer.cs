namespace Obsh
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
            this.RoomButton = new System.Windows.Forms.Button();
            this.StudentButtom = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomButton
            // 
            this.RoomButton.Location = new System.Drawing.Point(13, 13);
            this.RoomButton.Name = "RoomButton";
            this.RoomButton.Size = new System.Drawing.Size(268, 33);
            this.RoomButton.TabIndex = 0;
            this.RoomButton.Text = "Комнаты";
            this.RoomButton.UseVisualStyleBackColor = true;
            this.RoomButton.Click += new System.EventHandler(this.RoomButton_Click);
            // 
            // StudentButtom
            // 
            this.StudentButtom.Location = new System.Drawing.Point(13, 52);
            this.StudentButtom.Name = "StudentButtom";
            this.StudentButtom.Size = new System.Drawing.Size(268, 33);
            this.StudentButtom.TabIndex = 0;
            this.StudentButtom.Text = "Студенты";
            this.StudentButtom.UseVisualStyleBackColor = true;
            this.StudentButtom.Click += new System.EventHandler(this.StudentButtom_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(13, 91);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(268, 33);
            this.HelpButton.TabIndex = 0;
            this.HelpButton.Text = "Справка";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(13, 130);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(268, 33);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Obsh.Properties.Resources.st02_09;
            this.ClientSize = new System.Drawing.Size(293, 251);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.StudentButtom);
            this.Controls.Add(this.RoomButton);
            this.Name = "Form1";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RoomButton;
        private System.Windows.Forms.Button StudentButtom;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

