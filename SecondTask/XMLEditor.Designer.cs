namespace SecondTask
{
    partial class XMLEditor
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
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.SafeFileNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DisplayDataButton = new System.Windows.Forms.Button();
            this.FileVersionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeFileDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SetDataEnable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 38);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(152, 23);
            this.ChooseFileButton.TabIndex = 0;
            this.ChooseFileButton.Text = "Выбрать файл";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            // 
            // SafeFileNameTextBox
            // 
            this.SafeFileNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.SafeFileNameTextBox.Name = "SafeFileNameTextBox";
            this.SafeFileNameTextBox.Size = new System.Drawing.Size(370, 20);
            this.SafeFileNameTextBox.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // DisplayDataButton
            // 
            this.DisplayDataButton.Location = new System.Drawing.Point(13, 67);
            this.DisplayDataButton.Name = "DisplayDataButton";
            this.DisplayDataButton.Size = new System.Drawing.Size(151, 23);
            this.DisplayDataButton.TabIndex = 2;
            this.DisplayDataButton.Text = "Показать данные";
            this.DisplayDataButton.UseVisualStyleBackColor = true;
            // 
            // FileVersionTextBox
            // 
            this.FileVersionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FileVersionTextBox.Enabled = false;
            this.FileVersionTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FileVersionTextBox.Location = new System.Drawing.Point(116, 99);
            this.FileVersionTextBox.Name = "FileVersionTextBox";
            this.FileVersionTextBox.Size = new System.Drawing.Size(266, 20);
            this.FileVersionTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Версия файла";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Enabled = false;
            this.FileNameTextBox.Location = new System.Drawing.Point(116, 139);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(266, 20);
            this.FileNameTextBox.TabIndex = 5;
            // 
            // ChangeFileDate
            // 
            this.ChangeFileDate.Enabled = false;
            this.ChangeFileDate.Location = new System.Drawing.Point(116, 176);
            this.ChangeFileDate.Name = "ChangeFileDate";
            this.ChangeFileDate.Size = new System.Drawing.Size(266, 20);
            this.ChangeFileDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя файла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата изменения";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(12, 246);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(134, 23);
            this.SaveChangesButton.TabIndex = 9;
            this.SaveChangesButton.Text = "Сохранить";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // SetDataEnable
            // 
            this.SetDataEnable.Location = new System.Drawing.Point(12, 217);
            this.SetDataEnable.Name = "SetDataEnable";
            this.SetDataEnable.Size = new System.Drawing.Size(134, 23);
            this.SetDataEnable.TabIndex = 10;
            this.SetDataEnable.Text = "Редактировать";
            this.SetDataEnable.UseVisualStyleBackColor = true;
            // 
            // XMLEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetDataEnable);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeFileDate);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileVersionTextBox);
            this.Controls.Add(this.DisplayDataButton);
            this.Controls.Add(this.SafeFileNameTextBox);
            this.Controls.Add(this.ChooseFileButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "XMLEditor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.TextBox SafeFileNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button DisplayDataButton;
        private System.Windows.Forms.TextBox FileVersionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox ChangeFileDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button SetDataEnable;
    }
}

