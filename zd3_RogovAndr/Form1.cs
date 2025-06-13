namespace zd3_RogovAndr
{
    public partial class Form1 : Form
    {
        private Computer _computerManager = new Computer("", 0, 0, "", false);

        public Form1()
        {
            InitializeComponent();
        }

        //���������� ListBox
        private void UpdateListBox()
        {
            numericUpDownIndex.Maximum = _computerManager.AllComputers.Count;
            listBoxComputers.Items.Clear();
            foreach (var comp in _computerManager.AllComputers)
            {
                listBoxComputers.Items.Add(comp.GetInfo());
            }
        }

        //��������� TextBox
        private bool ValidateInputs()
        {
            //�������� �����
            if (string.IsNullOrWhiteSpace(textProcessorName.Text) ||
                string.IsNullOrWhiteSpace(textClockSpeed.Text) ||
                string.IsNullOrWhiteSpace(textRamSize.Text) ||
                string.IsNullOrWhiteSpace(textManufacturer.Text))
            {
                MessageBox.Show("��������� ��� ������������ ����!", "������");
                return false;
            }

            //�������� �������� ��������
            if (!double.TryParse(textClockSpeed.Text, out double speed) || speed <= 0 ||
                !int.TryParse(textRamSize.Text, out int ram) || ram <= 0)
            {
                MessageBox.Show("������� � ��� ������ ���� �������������� �������!", "������");
                return false;
            }

            //��� ���������� ���������� ��������� HDD
            if (rbService.Checked && (!int.TryParse(textHddSize.Text, out int hdd) || hdd <= 0))
            {
                MessageBox.Show("����� HDD ������ ���� ������������� ������!", "������");
                return false;
            }

            return true;
        }

        //������ ����������
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (rbBasic.Checked)
            {
                var computer = new Computer(
                    textProcessorName.Text,
                    double.Parse(textClockSpeed.Text),
                    int.Parse(textRamSize.Text),
                    textManufacturer.Text,
                    chkDiscrete.Checked);

                _computerManager.AddComputer(computer);
            }
            else
            {
                var serviceComp = new ServiceComputer(
                    textProcessorName.Text,
                    double.Parse(textClockSpeed.Text),
                    int.Parse(textRamSize.Text),
                    textManufacturer.Text,
                    chkDiscrete.Checked,
                    int.Parse(textHddSize.Text),
                    chkSSD.Checked);

                _computerManager.AddComputer(serviceComp);
            }

            UpdateListBox();
        }

        //������ ���������� �� �������
        private void btnAddAtIndex_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int index = (int)numericUpDownIndex.Value;

            if (rbBasic.Checked)
            {
                var computer = new Computer(
                    textProcessorName.Text,
                    double.Parse(textClockSpeed.Text),
                    int.Parse(textRamSize.Text),
                    textManufacturer.Text,
                    chkDiscrete.Checked);

                _computerManager.AddComputer(computer, index);
            }
            else
            {
                var serviceComp = new ServiceComputer(
                    textProcessorName.Text,
                    double.Parse(textClockSpeed.Text),
                    int.Parse(textRamSize.Text),
                    textManufacturer.Text,
                    chkDiscrete.Checked,
                    int.Parse(textHddSize.Text),
                    chkSSD.Checked);

                _computerManager.AddComputer(serviceComp, index);
            }

            UpdateListBox();
        }

        //������ �������� ����������
        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            if (_computerManager.RemoveComputer())
            {
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("��� ����������� ��� ��������", "����������");
            }
        }

        //������ �������� �� �����
        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textProcessorName.Text))
            {
                MessageBox.Show("������� �������� ����������", "������");
                return;
            }

            if (_computerManager.RemoveComputer(textProcessorName.Text))
            {
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("��������� � ����� ����������� �� ������", "������");
            }
        }

        //������ ������ �� ����������
        private void btnSearchByProcessor_Click(object sender, EventArgs e)
        {
            string searchName = textSearchProcessor.Text;

            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("������� �������� ���������� ��� ������");
                return;
            }

            listBoxComputers.Items.Clear();

            var computers = _computerManager.FindComputersByProcessor(searchName);
            if (computers != null)
            {
                foreach (var comp in computers)
                {
                    listBoxComputers.Items.Add(comp.GetInfo());
                }
            }
            else
            {
                MessageBox.Show($"����������� � ����������� {searchName} �� �������");
            }
        }

        //����� ������
        private void rbBasic_CheckedChanged(object sender, EventArgs e)
        {
            textHddSize.Enabled = !rbBasic.Checked;
            chkSSD.Enabled = !rbBasic.Checked;
        }
    }
}
