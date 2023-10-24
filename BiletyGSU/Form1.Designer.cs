namespace BiletyGSU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            NumeratedQuestions = new Button();
            SpecialityComboBox = new ComboBox();
            AddSpecialityButton = new Button();
            DeleteSpeciality = new Button();
            label1 = new Label();
            label2 = new Label();
            DeleteDisciplineButton = new Button();
            AddDisciplineButton = new Button();
            DisciplineComboBox = new ComboBox();
            CheckTicketsAlgorithmButton = new Button();
            CheckTicketsRandom = new Button();
            PathLabel = new Label();
            SaveButton = new Button();
            SaveFilePath = new Label();
            label3 = new Label();
            CourseTB = new TextBox();
            AcademicYearTB = new TextBox();
            label4 = new Label();
            label5 = new Label();
            fontDialog1 = new FontDialog();
            ApprovalDayTB = new TextBox();
            label6 = new Label();
            ApprovalMonthTB = new TextBox();
            label7 = new Label();
            ApprovalYearTB = new TextBox();
            label8 = new Label();
            ZaochnikiGroupCB = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(477, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(995, 274);
            listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(477, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(995, 346);
            dataGridView1.TabIndex = 2;
            // 
            // NumeratedQuestions
            // 
            NumeratedQuestions.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumeratedQuestions.Location = new Point(12, 12);
            NumeratedQuestions.Name = "NumeratedQuestions";
            NumeratedQuestions.Size = new Size(450, 40);
            NumeratedQuestions.TabIndex = 4;
            NumeratedQuestions.Text = "Выбрать файл с вопросами";
            NumeratedQuestions.UseVisualStyleBackColor = true;
            NumeratedQuestions.Click += NumeratedQuestions_Click;
            // 
            // SpecialityComboBox
            // 
            SpecialityComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialityComboBox.FormattingEnabled = true;
            SpecialityComboBox.Location = new Point(12, 114);
            SpecialityComboBox.Name = "SpecialityComboBox";
            SpecialityComboBox.Size = new Size(450, 36);
            SpecialityComboBox.TabIndex = 6;
            // 
            // AddSpecialityButton
            // 
            AddSpecialityButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddSpecialityButton.Location = new Point(12, 156);
            AddSpecialityButton.Name = "AddSpecialityButton";
            AddSpecialityButton.Size = new Size(220, 38);
            AddSpecialityButton.TabIndex = 7;
            AddSpecialityButton.Text = "Добавить специальность";
            AddSpecialityButton.UseVisualStyleBackColor = true;
            AddSpecialityButton.Click += AddSpecialityButton_Click;
            // 
            // DeleteSpeciality
            // 
            DeleteSpeciality.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteSpeciality.Location = new Point(242, 156);
            DeleteSpeciality.Name = "DeleteSpeciality";
            DeleteSpeciality.Size = new Size(220, 38);
            DeleteSpeciality.TabIndex = 8;
            DeleteSpeciality.Text = "Удалить специальность";
            DeleteSpeciality.UseVisualStyleBackColor = true;
            DeleteSpeciality.Click += DeleteSpeciality_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 9;
            label1.Text = "Специальность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 13;
            label2.Text = "Дисциплина";
            // 
            // DeleteDisciplineButton
            // 
            DeleteDisciplineButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteDisciplineButton.Location = new Point(242, 270);
            DeleteDisciplineButton.Name = "DeleteDisciplineButton";
            DeleteDisciplineButton.Size = new Size(220, 36);
            DeleteDisciplineButton.TabIndex = 12;
            DeleteDisciplineButton.Text = "Удалить";
            DeleteDisciplineButton.UseVisualStyleBackColor = true;
            DeleteDisciplineButton.Click += DeleteDisciplineButton_Click;
            // 
            // AddDisciplineButton
            // 
            AddDisciplineButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddDisciplineButton.Location = new Point(12, 270);
            AddDisciplineButton.Name = "AddDisciplineButton";
            AddDisciplineButton.Size = new Size(220, 36);
            AddDisciplineButton.TabIndex = 11;
            AddDisciplineButton.Text = "Добавить дисциплину";
            AddDisciplineButton.UseVisualStyleBackColor = true;
            AddDisciplineButton.Click += AddDisciplineButton_Click;
            // 
            // DisciplineComboBox
            // 
            DisciplineComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DisciplineComboBox.FormattingEnabled = true;
            DisciplineComboBox.Location = new Point(12, 228);
            DisciplineComboBox.Name = "DisciplineComboBox";
            DisciplineComboBox.Size = new Size(450, 36);
            DisciplineComboBox.TabIndex = 10;
            // 
            // CheckTicketsAlgorithmButton
            // 
            CheckTicketsAlgorithmButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CheckTicketsAlgorithmButton.Location = new Point(12, 507);
            CheckTicketsAlgorithmButton.Name = "CheckTicketsAlgorithmButton";
            CheckTicketsAlgorithmButton.Size = new Size(450, 43);
            CheckTicketsAlgorithmButton.TabIndex = 14;
            CheckTicketsAlgorithmButton.Text = "Генерация билетов алгоритмически";
            CheckTicketsAlgorithmButton.UseVisualStyleBackColor = true;
            CheckTicketsAlgorithmButton.Click += CheckTicketsAlgorithmButton_Click;
            // 
            // CheckTicketsRandom
            // 
            CheckTicketsRandom.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CheckTicketsRandom.Location = new Point(12, 556);
            CheckTicketsRandom.Name = "CheckTicketsRandom";
            CheckTicketsRandom.Size = new Size(450, 38);
            CheckTicketsRandom.TabIndex = 15;
            CheckTicketsRandom.Text = "Генерация билетов случайным образом";
            CheckTicketsRandom.UseVisualStyleBackColor = true;
            CheckTicketsRandom.Click += CheckTicketsRandom_Click;
            // 
            // PathLabel
            // 
            PathLabel.AutoSize = true;
            PathLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PathLabel.Location = new Point(12, 55);
            PathLabel.Name = "PathLabel";
            PathLabel.Size = new Size(54, 28);
            PathLabel.TabIndex = 16;
            PathLabel.Text = "Путь";
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(12, 600);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(450, 38);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Сохранить билеты как";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SaveFilePath
            // 
            SaveFilePath.AutoSize = true;
            SaveFilePath.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveFilePath.Location = new Point(12, 724);
            SaveFilePath.Name = "SaveFilePath";
            SaveFilePath.Size = new Size(54, 28);
            SaveFilePath.TabIndex = 18;
            SaveFilePath.Text = "Путь";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 315);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 19;
            label3.Text = "Курс";
            // 
            // CourseTB
            // 
            CourseTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CourseTB.Location = new Point(73, 312);
            CourseTB.Name = "CourseTB";
            CourseTB.Size = new Size(389, 34);
            CourseTB.TabIndex = 20;
            // 
            // AcademicYearTB
            // 
            AcademicYearTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AcademicYearTB.Location = new Point(199, 352);
            AcademicYearTB.Name = "AcademicYearTB";
            AcademicYearTB.Size = new Size(263, 34);
            AcademicYearTB.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 355);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 21;
            label4.Text = "Академиеский год";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 392);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 23;
            label5.Text = "Дата утверждения";
            // 
            // ApprovalDayTB
            // 
            ApprovalDayTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ApprovalDayTB.Location = new Point(76, 429);
            ApprovalDayTB.Name = "ApprovalDayTB";
            ApprovalDayTB.Size = new Size(58, 34);
            ApprovalDayTB.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 432);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 24;
            label6.Text = "День";
            // 
            // ApprovalMonthTB
            // 
            ApprovalMonthTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ApprovalMonthTB.Location = new Point(217, 429);
            ApprovalMonthTB.Name = "ApprovalMonthTB";
            ApprovalMonthTB.Size = new Size(58, 34);
            ApprovalMonthTB.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(140, 432);
            label7.Name = "label7";
            label7.Size = new Size(71, 28);
            label7.TabIndex = 26;
            label7.Text = "Месяц";
            // 
            // ApprovalYearTB
            // 
            ApprovalYearTB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ApprovalYearTB.Location = new Point(331, 429);
            ApprovalYearTB.Name = "ApprovalYearTB";
            ApprovalYearTB.Size = new Size(58, 34);
            ApprovalYearTB.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(281, 432);
            label8.Name = "label8";
            label8.Size = new Size(44, 28);
            label8.TabIndex = 28;
            label8.Text = "Год";
            // 
            // ZaochnikiGroupCB
            // 
            ZaochnikiGroupCB.AutoSize = true;
            ZaochnikiGroupCB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ZaochnikiGroupCB.Location = new Point(12, 469);
            ZaochnikiGroupCB.Name = "ZaochnikiGroupCB";
            ZaochnikiGroupCB.Size = new Size(176, 32);
            ZaochnikiGroupCB.TabIndex = 31;
            ZaochnikiGroupCB.Text = "Заочная группа";
            ZaochnikiGroupCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 647);
            Controls.Add(ZaochnikiGroupCB);
            Controls.Add(ApprovalYearTB);
            Controls.Add(label8);
            Controls.Add(ApprovalMonthTB);
            Controls.Add(label7);
            Controls.Add(ApprovalDayTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(AcademicYearTB);
            Controls.Add(label4);
            Controls.Add(CourseTB);
            Controls.Add(label3);
            Controls.Add(SaveFilePath);
            Controls.Add(SaveButton);
            Controls.Add(PathLabel);
            Controls.Add(CheckTicketsRandom);
            Controls.Add(CheckTicketsAlgorithmButton);
            Controls.Add(label2);
            Controls.Add(DeleteDisciplineButton);
            Controls.Add(AddDisciplineButton);
            Controls.Add(DisciplineComboBox);
            Controls.Add(label1);
            Controls.Add(DeleteSpeciality);
            Controls.Add(AddSpecialityButton);
            Controls.Add(SpecialityComboBox);
            Controls.Add(NumeratedQuestions);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button NumeratedQuestions;
        private ComboBox SpecialityComboBox;
        private Button AddSpecialityButton;
        private Button DeleteSpeciality;
        private Label label1;
        private Label label2;
        private Button DeleteDisciplineButton;
        private Button AddDisciplineButton;
        private ComboBox DisciplineComboBox;
        private Button CheckTicketsAlgorithmButton;
        private Button CheckTicketsRandom;
        private Label PathLabel;
        private Button SaveButton;
        private Label SaveFilePath;
        private Label label3;
        private TextBox CourseTB;
        private TextBox AcademicYearTB;
        private Label label4;
        private Label label5;
        private FontDialog fontDialog1;
        private TextBox ApprovalDayTB;
        private Label label6;
        private TextBox ApprovalMonthTB;
        private Label label7;
        private TextBox ApprovalYearTB;
        private Label label8;
        private CheckBox ZaochnikiGroupCB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}