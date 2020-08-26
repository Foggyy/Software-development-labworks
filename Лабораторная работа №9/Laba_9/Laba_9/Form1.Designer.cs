namespace Laba_9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FiletoolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxBusCondition = new System.Windows.Forms.TextBox();
            this.textBoxPathNumber = new System.Windows.Forms.TextBox();
            this.textBoxBusNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPathNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FiletoolStripDropDownButton1
            // 
            this.FiletoolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FiletoolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.CreateToolStripMenuItem});
            this.FiletoolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiletoolStripDropDownButton1.Name = "FiletoolStripDropDownButton1";
            this.FiletoolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
            this.FiletoolStripDropDownButton1.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // AboutProgramtoolStripButton1
            // 
            this.AboutProgramtoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutProgramtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("AboutProgramtoolStripButton1.Image")));
            this.AboutProgramtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutProgramtoolStripButton1.Name = "AboutProgramtoolStripButton1";
            this.AboutProgramtoolStripButton1.Size = new System.Drawing.Size(108, 24);
            this.AboutProgramtoolStripButton1.Text = "О программе";
            this.AboutProgramtoolStripButton1.Click += new System.EventHandler(this.AboutProgramtoolStripButton1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiletoolStripDropDownButton1,
            this.AboutProgramtoolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1304, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnSecondName,
            this.ColumnMiddleName,
            this.ColumnBusCondition,
            this.ColumnBusNumber,
            this.ColumnPathNumber});
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1146, 173);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(131, 45);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1146, 251);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 45);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CorrectButton
            // 
            this.CorrectButton.Location = new System.Drawing.Point(1157, 332);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(110, 43);
            this.CorrectButton.TabIndex = 4;
            this.CorrectButton.Text = "Изменить";
            this.CorrectButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1146, 416);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(131, 45);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(886, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(1045, 70);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 22);
            this.textBoxSecondName.TabIndex = 7;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(1177, 70);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMiddleName.TabIndex = 8;
            // 
            // textBoxBusCondition
            // 
            this.textBoxBusCondition.Location = new System.Drawing.Point(886, 113);
            this.textBoxBusCondition.Name = "textBoxBusCondition";
            this.textBoxBusCondition.Size = new System.Drawing.Size(100, 22);
            this.textBoxBusCondition.TabIndex = 9;
            // 
            // textBoxPathNumber
            // 
            this.textBoxPathNumber.Location = new System.Drawing.Point(1174, 116);
            this.textBoxPathNumber.Name = "textBoxPathNumber";
            this.textBoxPathNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxPathNumber.TabIndex = 10;
            // 
            // textBoxBusNumber
            // 
            this.textBoxBusNumber.Location = new System.Drawing.Point(1045, 116);
            this.textBoxBusNumber.Name = "textBoxBusNumber";
            this.textBoxBusNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxBusNumber.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1042, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1174, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(883, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Состояние автобуса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1171, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Номер маршрута";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1042, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Номер автобуса";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "В конец",
            "В начало",
            "С заданным номером"});
            this.comboBox1.Location = new System.Drawing.Point(886, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(886, 196);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 22);
            this.textBoxPosition.TabIndex = 19;
            this.textBoxPosition.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "По номеру",
            "По фамилии",
            "По номеру маршрута",
            "По номеру автобуса"});
            this.comboBox2.Location = new System.Drawing.Point(886, 262);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 24);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(886, 303);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(100, 22);
            this.textBoxDelete.TabIndex = 21;
            this.textBoxDelete.Visible = false;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSecondName
            // 
            this.ColumnSecondName.HeaderText = "Фамилия";
            this.ColumnSecondName.Name = "ColumnSecondName";
            // 
            // ColumnMiddleName
            // 
            this.ColumnMiddleName.HeaderText = "Отчество";
            this.ColumnMiddleName.Name = "ColumnMiddleName";
            // 
            // ColumnBusCondition
            // 
            this.ColumnBusCondition.HeaderText = "Состояние автобуса";
            this.ColumnBusCondition.Name = "ColumnBusCondition";
            // 
            // ColumnBusNumber
            // 
            this.ColumnBusNumber.HeaderText = "Номер автобуса";
            this.ColumnBusNumber.Name = "ColumnBusNumber";
            // 
            // ColumnPathNumber
            // 
            this.ColumnPathNumber.HeaderText = "Номер маршрута";
            this.ColumnPathNumber.Name = "ColumnPathNumber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 671);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBusNumber);
            this.Controls.Add(this.textBoxPathNumber);
            this.Controls.Add(this.textBoxBusCondition);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CorrectButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton FiletoolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AboutProgramtoolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxBusCondition;
        private System.Windows.Forms.TextBox textBoxPathNumber;
        private System.Windows.Forms.TextBox textBoxBusNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBusCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPathNumber;
    }
}

