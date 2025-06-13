using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_RogovAndr
{
    public class Computer
    {
        //Приватные поля
        private string _processorName;
        private double _clockSpeed;
        private int _ramSize;
        private string _manufacturer;
        private bool _hasDiscreteGraphics;

        //Публичные коллекции
        public List<Computer> AllComputers { get; } = new List<Computer>();
        public Dictionary<string, List<Computer>> ComputersByProcessor { get; } = new Dictionary<string, List<Computer>>();

        public Computer(string processorName, double clockSpeed, int ramSize,
                      string manufacturer, bool hasDiscreteGraphics)
        {
            _processorName = processorName;
            _clockSpeed = clockSpeed;
            _ramSize = ramSize;
            _manufacturer = manufacturer;
            _hasDiscreteGraphics = hasDiscreteGraphics;
        }

        //Методы для доступа к полям
        public string GetProcessorName() => _processorName;
        public double GetClockSpeed() => _clockSpeed;
        public int GetRamSize() => _ramSize;
        public string GetManufacturer() => _manufacturer;
        public bool HasDiscreteGraphics() => _hasDiscreteGraphics;

        //Получение качества компьютера
        public virtual double CalculateQuality()
        {
            return 0.3 * _clockSpeed + _ramSize;
        }

        //Получение информации компьютера
        public virtual string GetInfo()
        {
            string graphics = _hasDiscreteGraphics ? "Имеется" : "Отсутствует";
            return $"Компьютер: {_processorName}, Частота: {_clockSpeed} МГц, ОЗУ: {_ramSize} МБ, " +
                  $"Производитель: {_manufacturer}, Дискретная графика: {graphics}, Q: {CalculateQuality():F2}";
        }

        //Добавление компьютера
        public void AddComputer(Computer comp)
        {
            AllComputers.Add(comp);
            AddToDictionary(comp);
        }

        //Добавление по индексу(перегрузка)
        public void AddComputer(Computer comp, int index)
        {
            AllComputers.Insert(index, comp);
            AddToDictionary(comp);
        }

        //Добавление в словарь для точечного поиска
        private void AddToDictionary(Computer comp)
        {
            if (!ComputersByProcessor.ContainsKey(comp._processorName))
            {
                ComputersByProcessor[comp._processorName] = new List<Computer>();
            }
            ComputersByProcessor[comp._processorName].Add(comp);
        }

        //Удаление компьютера 
        public bool RemoveComputer()
        {
            if (AllComputers.Count == 0) return false;

            var lastComp = AllComputers.Last();
            ComputersByProcessor[lastComp._processorName].Remove(lastComp);

            if (ComputersByProcessor[lastComp._processorName].Count == 0)
            {
                ComputersByProcessor.Remove(lastComp._processorName);
            }

            AllComputers.Remove(lastComp);
            return true;
        }

        //Удаление компьютера по индексу (перегрузка)
        public bool RemoveComputer(string processorName)
        {
            if (string.IsNullOrEmpty(processorName) || !ComputersByProcessor.ContainsKey(processorName))
                return false;

            var computersToRemove = AllComputers
                .Where(c => c._processorName == processorName)
                .ToList();

            if (computersToRemove.Count == 0)
                return false;

            foreach (var comp in computersToRemove)
            {
                AllComputers.Remove(comp);
            }

            //Обновляем словарь
            ComputersByProcessor[processorName].Clear();
            if (ComputersByProcessor[processorName].Count == 0)
            {
                ComputersByProcessor.Remove(processorName);
            }

            return true;
        }

        //Поиск по процессору в Dictionary
        public List<Computer> FindComputersByProcessor(string processorName)
        {
            if (ComputersByProcessor.TryGetValue(processorName, out var computers))
                return new List<Computer>(computers); // Возвращаем копию
            return null;
        }

        //Отчистка коллекций
        public void ClearAllComputers()
        {
            AllComputers.Clear();
            ComputersByProcessor.Clear();
        }
    }
}
