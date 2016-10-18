namespace Numbertoword
{
    partial class Numbertoword
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
            this.outBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.kindBox = new System.Windows.Forms.ComboBox();
            this.caseBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(311, 72);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.Size = new System.Drawing.Size(296, 170);
            this.outBox.TabIndex = 0;
            this.outBox.TextChanged += new System.EventHandler(this.outBox_TextChanged);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(51, 72);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(205, 20);
            this.numberBox.TabIndex = 1;
            this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            // 
            // kindBox
            // 
            this.kindBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kindBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kindBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Средний"});
            this.kindBox.Location = new System.Drawing.Point(51, 122);
            this.kindBox.Name = "kindBox";
            this.kindBox.Size = new System.Drawing.Size(121, 21);
            this.kindBox.TabIndex = 2;
            kindBox.SelectedIndex = 0;
            this.kindBox.SelectedIndexChanged += new System.EventHandler(this.kindBox_SelectedIndexChanged);
            // 
            // caseBox
            // 
            this.caseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caseBox.FormattingEnabled = true;
            this.caseBox.Items.AddRange(new object[] {
            "Именительный",
            "Родительный",
            "Дательный",
            "Винительный",
            "Творительный",
            "Предложный"});
            this.caseBox.Location = new System.Drawing.Point(51, 176);
            this.caseBox.Name = "caseBox";
            this.caseBox.Size = new System.Drawing.Size(121, 21);
            this.caseBox.TabIndex = 3;
            caseBox.SelectedIndex = 0;
            this.caseBox.SelectedIndexChanged += new System.EventHandler(this.caseBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Род";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Падеж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Число";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(262, 70);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(22, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "►";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Numbertoword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 342);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caseBox);
            this.Controls.Add(this.kindBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.outBox);
            this.Name = "Numbertoword";
            this.Text = "Numbertoword";
            this.Load += new System.EventHandler(this.Numbertoword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.ComboBox kindBox;
        private System.Windows.Forms.ComboBox caseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
    }
}

