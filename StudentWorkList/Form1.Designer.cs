namespace StudentWorkList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButtonInp = new System.Windows.Forms.Button();
            this.clearButtonInp = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.dofDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patrTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studComboBox = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.outRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clearButtonOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите фамилию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Группа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButtonInp);
            this.groupBox1.Controls.Add(this.clearButtonInp);
            this.groupBox1.Controls.Add(this.groupComboBox);
            this.groupBox1.Controls.Add(this.dofDateTimePicker);
            this.groupBox1.Controls.Add(this.patrTextBox);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(609, 418);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // saveButtonInp
            // 
            this.saveButtonInp.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButtonInp.Location = new System.Drawing.Point(489, 373);
            this.saveButtonInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButtonInp.Name = "saveButtonInp";
            this.saveButtonInp.Size = new System.Drawing.Size(112, 35);
            this.saveButtonInp.TabIndex = 12;
            this.saveButtonInp.Text = "Save";
            this.saveButtonInp.UseVisualStyleBackColor = true;
            this.saveButtonInp.Click += new System.EventHandler(this.saveButtonInp_Click);
            // 
            // clearButtonInp
            // 
            this.clearButtonInp.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.clearButtonInp.Location = new System.Drawing.Point(15, 373);
            this.clearButtonInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonInp.Name = "clearButtonInp";
            this.clearButtonInp.Size = new System.Drawing.Size(112, 35);
            this.clearButtonInp.TabIndex = 11;
            this.clearButtonInp.Text = "Clear";
            this.clearButtonInp.UseVisualStyleBackColor = true;
            this.clearButtonInp.Click += new System.EventHandler(this.clearButtonInp_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "ДИ-35",
            "ДИ-31",
            "КИ-35",
            "КИ-21",
            "КИ-31"});
            this.groupComboBox.Location = new System.Drawing.Point(249, 173);
            this.groupComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(232, 31);
            this.groupComboBox.TabIndex = 10;
            // 
            // dofDateTimePicker
            // 
            this.dofDateTimePicker.Location = new System.Drawing.Point(249, 136);
            this.dofDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dofDateTimePicker.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.dofDateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dofDateTimePicker.Name = "dofDateTimePicker";
            this.dofDateTimePicker.Size = new System.Drawing.Size(232, 30);
            this.dofDateTimePicker.TabIndex = 9;
            this.dofDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // patrTextBox
            // 
            this.patrTextBox.Location = new System.Drawing.Point(249, 101);
            this.patrTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patrTextBox.Name = "patrTextBox";
            this.patrTextBox.Size = new System.Drawing.Size(232, 30);
            this.patrTextBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(249, 66);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(232, 30);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(249, 30);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 30);
            this.nameTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studComboBox);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.outRichTextBox);
            this.groupBox2.Controls.Add(this.clearButtonOut);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.groupBox2.Location = new System.Drawing.Point(636, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(609, 418);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // studComboBox
            // 
            this.studComboBox.FormattingEnabled = true;
            this.studComboBox.Location = new System.Drawing.Point(9, 25);
            this.studComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studComboBox.Name = "studComboBox";
            this.studComboBox.Size = new System.Drawing.Size(360, 31);
            this.studComboBox.TabIndex = 3;
            this.studComboBox.SelectedIndexChanged += new System.EventHandler(this.studComboBox_SelectedIndexChanged);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.editButton.Location = new System.Drawing.Point(377, 20);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 35);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // outRichTextBox
            // 
            this.outRichTextBox.Location = new System.Drawing.Point(9, 66);
            this.outRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outRichTextBox.Name = "outRichTextBox";
            this.outRichTextBox.ReadOnly = true;
            this.outRichTextBox.Size = new System.Drawing.Size(360, 178);
            this.outRichTextBox.TabIndex = 1;
            this.outRichTextBox.Text = "";
            // 
            // clearButtonOut
            // 
            this.clearButtonOut.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.clearButtonOut.Location = new System.Drawing.Point(9, 374);
            this.clearButtonOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonOut.Name = "clearButtonOut";
            this.clearButtonOut.Size = new System.Drawing.Size(112, 35);
            this.clearButtonOut.TabIndex = 0;
            this.clearButtonOut.Text = "Clear";
            this.clearButtonOut.UseVisualStyleBackColor = true;
            this.clearButtonOut.Click += new System.EventHandler(this.clearButtonOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox patrTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dofDateTimePicker;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButtonInp;
        private System.Windows.Forms.Button clearButtonInp;
        private System.Windows.Forms.Button clearButtonOut;
        private System.Windows.Forms.RichTextBox outRichTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox studComboBox;
    }
}

