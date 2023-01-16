namespace FirstTask
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
            this.CreateFilesButton = new System.Windows.Forms.Button();
            this.CombineFilesButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClearFolderButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SumButton = new System.Windows.Forms.Button();
            this.MedianButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateFilesButton
            // 
            this.CreateFilesButton.Location = new System.Drawing.Point(199, 8);
            this.CreateFilesButton.Name = "CreateFilesButton";
            this.CreateFilesButton.Size = new System.Drawing.Size(74, 78);
            this.CreateFilesButton.TabIndex = 0;
            this.CreateFilesButton.Text = "Create files";
            this.CreateFilesButton.UseVisualStyleBackColor = true;
            this.CreateFilesButton.Click += new System.EventHandler(this.CreateFilesButton_Click);
            // 
            // CombineFilesButton
            // 
            this.CombineFilesButton.Location = new System.Drawing.Point(164, 128);
            this.CombineFilesButton.Name = "CombineFilesButton";
            this.CombineFilesButton.Size = new System.Drawing.Size(109, 23);
            this.CombineFilesButton.TabIndex = 1;
            this.CombineFilesButton.Text = "Combine files";
            this.CombineFilesButton.UseVisualStyleBackColor = true;
            this.CombineFilesButton.Click += new System.EventHandler(this.CombineFilesButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(12, 168);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(261, 36);
            this.ImportButton.TabIndex = 2;
            this.ImportButton.Text = "Import to Database";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 3;
            // 
            // ClearFolderButton
            // 
            this.ClearFolderButton.Location = new System.Drawing.Point(11, 254);
            this.ClearFolderButton.Name = "ClearFolderButton";
            this.ClearFolderButton.Size = new System.Drawing.Size(125, 38);
            this.ClearFolderButton.TabIndex = 4;
            this.ClearFolderButton.Text = "Clear the folder";
            this.ClearFolderButton.UseVisualStyleBackColor = true;
            this.ClearFolderButton.Click += new System.EventHandler(this.ClearFolderButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Location = new System.Drawing.Point(147, 254);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(125, 38);
            this.OpenFolderButton.TabIndex = 6;
            this.OpenFolderButton.Text = "Open the folder";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "How many files do you want?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "How many lines do you want?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Which lines do you want to deletewhen it`s combinig?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "  ";
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(11, 210);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(125, 25);
            this.SumButton.TabIndex = 13;
            this.SumButton.Text = "Sum of Int";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // MedianButton
            // 
            this.MedianButton.Location = new System.Drawing.Point(148, 210);
            this.MedianButton.Name = "MedianButton";
            this.MedianButton.Size = new System.Drawing.Size(125, 25);
            this.MedianButton.TabIndex = 14;
            this.MedianButton.Text = "Median of non-int";
            this.MedianButton.UseVisualStyleBackColor = true;
            this.MedianButton.Click += new System.EventHandler(this.MedianButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 364);
            this.Controls.Add(this.MedianButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OpenFolderButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ClearFolderButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.CombineFilesButton);
            this.Controls.Add(this.CreateFilesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateFilesButton;
        private System.Windows.Forms.Button CombineFilesButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ClearFolderButton;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button OpenFolderButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button MedianButton;
    }
}

