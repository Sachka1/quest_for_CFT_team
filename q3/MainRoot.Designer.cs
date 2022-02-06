
namespace q3
{
    partial class MainRoot
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
            this.EditNote = new System.Windows.Forms.Button();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.TextNote = new System.Windows.Forms.TextBox();
            this.SaveNote = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EditNote
            // 
            this.EditNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditNote.Location = new System.Drawing.Point(225, 23);
            this.EditNote.Name = "EditNote";
            this.EditNote.Size = new System.Drawing.Size(176, 57);
            this.EditNote.TabIndex = 1;
            this.EditNote.Text = "Редактировать";
            this.EditNote.UseVisualStyleBackColor = true;
            this.EditNote.Click += new System.EventHandler(this.EditNote_Click);
            // 
            // DeleteNote
            // 
            this.DeleteNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteNote.Location = new System.Drawing.Point(431, 23);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(188, 57);
            this.DeleteNote.TabIndex = 3;
            this.DeleteNote.Text = "Удалить";
            this.DeleteNote.UseVisualStyleBackColor = true;
            this.DeleteNote.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // TextNote
            // 
            this.TextNote.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNote.Location = new System.Drawing.Point(12, 158);
            this.TextNote.Multiline = true;
            this.TextNote.Name = "TextNote";
            this.TextNote.Size = new System.Drawing.Size(607, 469);
            this.TextNote.TabIndex = 5;
            // 
            // SaveNote
            // 
            this.SaveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveNote.Location = new System.Drawing.Point(12, 23);
            this.SaveNote.Name = "SaveNote";
            this.SaveNote.Size = new System.Drawing.Size(194, 57);
            this.SaveNote.TabIndex = 6;
            this.SaveNote.Text = "Добавить";
            this.SaveNote.UseVisualStyleBackColor = true;
            this.SaveNote.Click += new System.EventHandler(this.SaveNote_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(396, 638);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(223, 57);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(305, 32);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.MouseHover += new System.EventHandler(this.comboBox2_MouseHover);
            // 
            // MainRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 707);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveNote);
            this.Controls.Add(this.TextNote);
            this.Controls.Add(this.DeleteNote);
            this.Controls.Add(this.EditNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заметки для ЦФТ";
            this.Load += new System.EventHandler(this.MainRoot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditNote;
        private System.Windows.Forms.Button DeleteNote;
        private System.Windows.Forms.TextBox TextNote;
        private System.Windows.Forms.Button SaveNote;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

