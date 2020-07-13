namespace Obsh.form
{
    partial class RoomForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.EditRoomButton = new System.Windows.Forms.Button();
            this.RemoveRoomButton = new System.Windows.Forms.Button();
            this.StudentsInRoom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddStudentButton.Location = new System.Drawing.Point(107, 13);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(88, 52);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Добавить студента";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddRoomButton.Location = new System.Drawing.Point(201, 12);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(88, 52);
            this.AddRoomButton.TabIndex = 1;
            this.AddRoomButton.Text = "Добавить команту";
            this.AddRoomButton.UseVisualStyleBackColor = false;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // EditRoomButton
            // 
            this.EditRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EditRoomButton.Location = new System.Drawing.Point(295, 12);
            this.EditRoomButton.Name = "EditRoomButton";
            this.EditRoomButton.Size = new System.Drawing.Size(88, 52);
            this.EditRoomButton.TabIndex = 1;
            this.EditRoomButton.Text = "Переселить студента";
            this.EditRoomButton.UseVisualStyleBackColor = false;
            this.EditRoomButton.Click += new System.EventHandler(this.EditRoomButton_Click);
            // 
            // RemoveRoomButton
            // 
            this.RemoveRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RemoveRoomButton.Location = new System.Drawing.Point(389, 12);
            this.RemoveRoomButton.Name = "RemoveRoomButton";
            this.RemoveRoomButton.Size = new System.Drawing.Size(88, 52);
            this.RemoveRoomButton.TabIndex = 1;
            this.RemoveRoomButton.Text = "Удалить комнату";
            this.RemoveRoomButton.UseVisualStyleBackColor = false;
            this.RemoveRoomButton.Click += new System.EventHandler(this.RemoveRoomButton_Click);
            // 
            // StudentsInRoom
            // 
            this.StudentsInRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StudentsInRoom.Location = new System.Drawing.Point(13, 12);
            this.StudentsInRoom.Name = "StudentsInRoom";
            this.StudentsInRoom.Size = new System.Drawing.Size(88, 52);
            this.StudentsInRoom.TabIndex = 1;
            this.StudentsInRoom.Text = "Студенты в комнате";
            this.StudentsInRoom.UseVisualStyleBackColor = false;
            this.StudentsInRoom.Click += new System.EventHandler(this.StudentsInRoom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(700, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Счета";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Obsh.Properties.Resources.st02_09;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveRoomButton);
            this.Controls.Add(this.EditRoomButton);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.StudentsInRoom);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomForm";
            this.Text = "Комнаты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button EditRoomButton;
        private System.Windows.Forms.Button RemoveRoomButton;
        private System.Windows.Forms.Button StudentsInRoom;
        private System.Windows.Forms.Button button1;
    }
}