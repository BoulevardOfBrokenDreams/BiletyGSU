namespace BiletyGSU
{
    public partial class Form1 : Form
    {
        public string PathToFile { get; set; }
        public string[] Str { get; set; }
        protected Ticket[] Tickets { get; set; }

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;

            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "������.txt")))
            {
                File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "������.txt")).Close();
            }

            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "����������.txt")))
            {
                File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "����������.txt")).Close();
            }

            var reader = new StreamReader("������.txt");
            var lines = reader.ReadToEnd().Split('\n');
            foreach (var line in lines)
            {
                if (line != "")
                {
                    SpecialityComboBox.Items.Add(line);
                }
            }
            reader.Close();

            reader = new StreamReader("����������.txt");
            lines = reader.ReadToEnd().Split('\n');
            foreach (var line in lines)
            {
                if (line != "")
                {
                    DisciplineComboBox.Items.Add(line);
                }
            }
            reader.Close();
        }

        private void AddSpecialityButton_Click(object sender, EventArgs e)
        {
            SpecialityComboBox.Items.Add(SpecialityComboBox.Text);
            var writer = new StreamWriter("������.txt", true);
            writer.WriteLine(SpecialityComboBox.Text);
            writer.Close();
        }

        private void AddDisciplineButton_Click(object sender, EventArgs e)
        {
            DisciplineComboBox.Items.Add(DisciplineComboBox.Text);
            var writer = new StreamWriter("����������.txt", true);
            writer.WriteLine(DisciplineComboBox.Text);
            writer.Close();
        }

        private void NumeratedQuestions_Click(object sender, EventArgs e)
        {
            var OPF = new OpenFileDialog();

            if (OPF.ShowDialog() == DialogResult.OK)
            {
                Str = Generate.ReadFile(OPF.FileName);
                listBox1.Items.AddRange(Generate.ReadFile(OPF.FileName));
            }
            PathLabel.Text = OPF.FileName;
        }

        private void CheckTicketsAlgorithmButton_Click(object sender, EventArgs e)
        {
            Tickets = Generate.GetTickets(Generate.GetQuestions(Str));
            dataGridView1.DataSource = Tickets;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var file = new SaveFileDialog();
            file.Filter = "�������� Word|*.docx|�������� Word 97-2003|*.doc";
            file.Title = "��������� �������� Word";
            file.ShowDialog();
            if (file.FileName != "")
            {
                SaveFilePath.Text = file.FileName;
                Generate.GenerateFile(Tickets, file.FileName, DisciplineComboBox.SelectedItem.ToString(), int.Parse(CourseTB.Text), SpecialityComboBox.SelectedItem.ToString(), AcademicYearTB.Text, ApprovalDayTB.Text, ApprovalMonthTB.Text, ApprovalYearTB.Text, ZaochnikiGroupCB.Checked);
                this.Text = file.FileName;
            }
        }

        private void DeleteSpeciality_Click(object sender, EventArgs e)
        {
            SpecialityComboBox.Items.Remove(SpecialityComboBox.SelectedItem);

            var writer = new StreamWriter("������.txt", false);
            foreach (var item in SpecialityComboBox.Items)
            {
                writer.Write(item.ToString());
            }
            writer.Close();
        }

        private void DeleteDisciplineButton_Click(object sender, EventArgs e)
        {
            DisciplineComboBox.Items.Remove(DisciplineComboBox.SelectedItem);

            var writer = new StreamWriter("����������.txt", false);
            foreach (var item in DisciplineComboBox.Items)
            {
                writer.Write(item.ToString());
            }
            writer.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var writer = new StreamWriter("����������.txt");
            foreach (var item in DisciplineComboBox.Items) { writer.WriteLine(item.ToString().Replace("\r", "")); }
            writer.Close();

            writer = new StreamWriter("������.txt");
            foreach (var item in SpecialityComboBox.Items) { writer.WriteLine(item.ToString().Replace("\r", "")); }
            writer.Close();
        }

        private void CheckTicketsRandom_Click(object sender, EventArgs e)
        {
            Tickets = Generate.GenerateRandomTickets(Generate.GetQuestions(Str));
            dataGridView1.DataSource = Tickets;
        }
    }
}