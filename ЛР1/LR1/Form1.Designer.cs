
namespace LR1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочестьИнформациюОКлючеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.отобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(372, 225);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(499, 172);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(338, 225);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "бинарные файлы|*.bin|все файлы|*.*";
            this.saveFileDialog1.Title = "Выберите имя ключа";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифрованиеToolStripMenuItem,
            this.дешифрованиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 91);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКлючToolStripMenuItem,
            this.зашифроватьИнформациюToolStripMenuItem,
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem,
            this.отобразитьToolStripMenuItem});
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // создатьКлючToolStripMenuItem
            // 
            this.создатьКлючToolStripMenuItem.Name = "создатьКлючToolStripMenuItem";
            this.создатьКлючToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.создатьКлючToolStripMenuItem.Text = "Создать ключ";
            this.создатьКлючToolStripMenuItem.Click += new System.EventHandler(this.создатьКлючToolStripMenuItem_Click_1);
            // 
            // зашифроватьИнформациюToolStripMenuItem
            // 
            this.зашифроватьИнформациюToolStripMenuItem.Name = "зашифроватьИнформациюToolStripMenuItem";
            this.зашифроватьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.зашифроватьИнформациюToolStripMenuItem.Text = "Зашифровать информацию";
            this.зашифроватьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьИнформациюToolStripMenuItem_Click);
            // 
            // отобразитьШифрованнуюИнформациюToolStripMenuItem
            // 
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Name = "отобразитьШифрованнуюИнформациюToolStripMenuItem";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Text = "Отобразить зашифрованную информацию";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Click += new System.EventHandler(this.отобразитьШифрованнуюИнформациюToolStripMenuItem_Click);
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочестьИнформациюОКлючеToolStripMenuItem,
            this.расшифроватьФайлToolStripMenuItem});
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // прочестьИнформациюОКлючеToolStripMenuItem
            // 
            this.прочестьИнформациюОКлючеToolStripMenuItem.Name = "прочестьИнформациюОКлючеToolStripMenuItem";
            this.прочестьИнформациюОКлючеToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.прочестьИнформациюОКлючеToolStripMenuItem.Text = "Прочесть информацию о ключе";
            this.прочестьИнформациюОКлючеToolStripMenuItem.Click += new System.EventHandler(this.прочестьИнформациюОКлючеToolStripMenuItem_Click);
            // 
            // расшифроватьФайлToolStripMenuItem
            // 
            this.расшифроватьФайлToolStripMenuItem.Name = "расшифроватьФайлToolStripMenuItem";
            this.расшифроватьФайлToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.расшифроватьФайлToolStripMenuItem.Text = "Расшифровать файл";
            this.расшифроватьФайлToolStripMenuItem.Click += new System.EventHandler(this.расшифроватьФайлToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "бинарные файлы|*.bin";
            this.openFileDialog1.Title = "Выберите сохраненный ключ";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "текстовые файлы| *.txt|все файлы | *.*";
            this.openFileDialog2.Title = "Выберите файл для шифрования";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "текстовые файлы| *.txt|все файлы | *.*";
            this.saveFileDialog2.Title = "Выбирете куда сохранить шифр";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk_1);
            // 
            // отобразитьToolStripMenuItem
            // 
            this.отобразитьToolStripMenuItem.Name = "отобразитьToolStripMenuItem";
            this.отобразитьToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.отобразитьToolStripMenuItem.Text = "Отобразить файл для шифрования";
            this.отобразитьToolStripMenuItem.Click += new System.EventHandler(this.отобразитьToolStripMenuItem_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.Filter = "текстовые файлы| *.txt|все файлы | *.*";
            this.openFileDialog3.Title = "Выберите зашифрованный файл";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            this.openFileDialog4.Filter = "текстовые файлы| *.txt|все файлы | *.*";
            this.openFileDialog4.Title = "Выбор имени зашифрованного файла ";
            this.openFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog4_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьШифрованнуюИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочестьИнформациюОКлючеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьФайлToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem отобразитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
    }
}

