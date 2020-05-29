namespace Задание_1_г
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
            this.FilePathlabel = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.Yzn = new System.Windows.Forms.Button();
            this.FiguresInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FilePathlabel
            // 
            this.FilePathlabel.AutoSize = true;
            this.FilePathlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathlabel.Location = new System.Drawing.Point(12, 14);
            this.FilePathlabel.Name = "FilePathlabel";
            this.FilePathlabel.Size = new System.Drawing.Size(167, 28);
            this.FilePathlabel.TabIndex = 0;
            this.FilePathlabel.Text = "Путь к файлу";
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePath.Location = new System.Drawing.Point(194, 11);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(457, 36);
            this.FilePath.TabIndex = 1;
            this.FilePath.Text = "..\\\\..\\\\..\\\\fileinfo.txt";
            // 
            // Yzn
            // 
            this.Yzn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yzn.Location = new System.Drawing.Point(65, 63);
            this.Yzn.Name = "Yzn";
            this.Yzn.Size = new System.Drawing.Size(462, 59);
            this.Yzn.TabIndex = 2;
            this.Yzn.Text = "Иинформация о фигурах из файла";
            this.Yzn.UseVisualStyleBackColor = true;
            this.Yzn.Click += new System.EventHandler(this.Yzn_Click);
            // 
            // FiguresInfo
            // 
            this.FiguresInfo.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiguresInfo.Location = new System.Drawing.Point(12, 128);
            this.FiguresInfo.Name = "FiguresInfo";
            this.FiguresInfo.Size = new System.Drawing.Size(639, 273);
            this.FiguresInfo.TabIndex = 3;
            this.FiguresInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 413);
            this.Controls.Add(this.FiguresInfo);
            this.Controls.Add(this.Yzn);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FilePathlabel);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilePathlabel;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button Yzn;
        private System.Windows.Forms.RichTextBox FiguresInfo;
    }
}

