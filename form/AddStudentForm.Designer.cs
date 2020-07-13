namespace Obsh.form
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.midNameBox = new System.Windows.Forms.TextBox();
            this.midname = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.RoomBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(83, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(10, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Имя";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(83, 75);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 20);
            this.surnameBox.TabIndex = 0;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.BackColor = System.Drawing.Color.Transparent;
            this.surname.Location = new System.Drawing.Point(10, 78);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(56, 13);
            this.surname.TabIndex = 1;
            this.surname.Text = "Фамилия";
            // 
            // midNameBox
            // 
            this.midNameBox.Location = new System.Drawing.Point(83, 110);
            this.midNameBox.Name = "midNameBox";
            this.midNameBox.Size = new System.Drawing.Size(100, 20);
            this.midNameBox.TabIndex = 0;
            // 
            // midname
            // 
            this.midname.AutoSize = true;
            this.midname.BackColor = System.Drawing.Color.Transparent;
            this.midname.Location = new System.Drawing.Point(10, 113);
            this.midname.Name = "midname";
            this.midname.Size = new System.Drawing.Size(54, 13);
            this.midname.TabIndex = 1;
            this.midname.Text = "Отчество";
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(11, 152);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(189, 65);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // RoomBox
            // 
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.Location = new System.Drawing.Point(121, 12);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(83, 21);
            this.RoomBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Свободные комнаты";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Obsh.Properties.Resources.st02_09;
            this.ClientSize = new System.Drawing.Size(214, 226);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.midname);
            this.Controls.Add(this.midNameBox);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameBox);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox midNameBox;
        private System.Windows.Forms.Label midname;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ComboBox RoomBox;
        private System.Windows.Forms.Label label1;
    }
}