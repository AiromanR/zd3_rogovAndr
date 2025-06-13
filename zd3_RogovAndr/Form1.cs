namespace zd3_RogovAndr
{
    public partial class Form1 : Form
    {
        private Computer _computerManager = new Computer("", 0, 0, "", false);

        public Form1()
        {
            InitializeComponent();
        }

        //Обновление ListBox
        private void UpdateListBox()
        {
            numericUpDownIndex.Maximum = _computerManager.AllComputers.Count;
            listBoxComputers.Items.Clear();
            foreach (var comp in _computerManager.AllComputers)
            {
                listBoxComputers.Items.Add(comp.GetInfo());
            }
        }

        //Валидация TextBox
        private bool ValidateInputs()
        {
            //Проверка полей
            if (string.IsNullOrWhiteSpace(textProcessorName.Text) ||
                string.IsNullOrWhiteSpace(textClockSpeed.Text) ||
                string.IsNullOrWhiteSpace(textRamSize.Text) ||
                string.IsNullOrWhiteSpace(textManufacturer.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка");
                return false;
            }

            //Проверка числовых значений
            if (!double.TryParse(textClockSpeed.Text, out double speed) || speed <= 0 ||
                !int.TryParse(textRamSize.Text, out int ram) || ram <= 0)
            {
                MessageBox.Show("Частота и ОЗУ должны быть положительными числами!", "Ошибка");
                return false;
            }

            //Для серверного компьютера проверяем HDD
            if (rbService.Checked && (!int.TryParse(textHddSize.Text, out int hdd) || hdd <= 0))
            {
                MessageBox.Show("Объем HDD должен быть положительным числом!", "Ошибка");
                return false;
            }

            return true;
        }

        //Кнопка добавления
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

        //Кнопка добавления по индексу
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

        //Кнопка удаления последнего
        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            if (_computerManager.RemoveComputer())
            {
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Нет компьютеров для удаления", "Информация");
            }
        }

        //Кнопка удаления по имени
        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textProcessorName.Text))
            {
                MessageBox.Show("Введите название процессора", "Ошибка");
                return;
            }

            if (_computerManager.RemoveComputer(textProcessorName.Text))
            {
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Компьютер с таким процессором не найден", "Ошибка");
            }
        }

        //Кнопка поиска по процессору
        private void btnSearchByProcessor_Click(object sender, EventArgs e)
        {
            string searchName = textSearchProcessor.Text;

            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Введите название процессора для поиска");
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
                MessageBox.Show($"Компьютеров с процессором {searchName} не найдено");
            }
        }

        //Радио кнопка
        private void rbBasic_CheckedChanged(object sender, EventArgs e)
        {
            textHddSize.Enabled = !rbBasic.Checked;
            chkSSD.Enabled = !rbBasic.Checked;
        }
    }
}
