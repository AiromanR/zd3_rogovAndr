using zd3_RogovAndr;

namespace ComputersTests
{
    [TestClass]
    public sealed class ComputerTests
    {
        private Computer _computerManager;

        [TestInitialize]
        public void TestInitialize()
        {
            _computerManager = new Computer("", 0, 0, "", false);
        }

        //Проверяет, что компьютер добавляется
        [TestMethod]
        public void ДобавлениеКомпьютера_КорректныеДанные_УспешноеДобавление()
        {
            var computer = new Computer("Intel i7", 3.5, 16, "Dell", true);

            _computerManager.AddComputer(computer);

            Assert.AreEqual(1, _computerManager.AllComputers.Count,
                $"Ожидался 1 компьютер, но найдено {_computerManager.AllComputers.Count}.");
            Assert.AreEqual("Intel i7", _computerManager.AllComputers[0].GetProcessorName());
        }
        //Проверяется, что компьютер вставляется в указанный индекс
        [TestMethod]
        public void ДобавлениеКомпьютераПоИндексу_ВалидныйИндекс_КорректнаяВставка()
        {
            var comp1 = new Computer("CPU1", 2.5, 8, "Brand1", false);
            var comp2 = new Computer("CPU2", 3.0, 16, "Brand2", true);
            _computerManager.AddComputer(comp1);
            _computerManager.AddComputer(comp2, 0);

            Assert.AreEqual(2, _computerManager.AllComputers.Count);
            Assert.AreEqual("CPU2", _computerManager.AllComputers[0].GetProcessorName());
            Assert.AreEqual("CPU1", _computerManager.AllComputers[1].GetProcessorName());
            Assert.IsTrue(_computerManager.ComputersByProcessor.ContainsKey("CPU2"));
        }
        //Проверка, что индекс равен количеству компьютеров, чтоб добавить в конец
        [TestMethod]
        public void ДобавлениеКомпьютераПоИндексу_ИндексРавенКоличеству_ДобавлениеВКонец()
        {
            var comp1 = new Computer("CPU1", 2.5, 8, "Brand1", false);
            var comp2 = new Computer("CPU2", 3.0, 16, "Brand2", true);
            _computerManager.AddComputer(comp1);

            _computerManager.AddComputer(comp2, 1);

            Assert.AreEqual(2, _computerManager.AllComputers.Count);
            Assert.AreEqual("CPU2", _computerManager.AllComputers[1].GetProcessorName());
        }
        //Проверка, что создаётся в словаре
        [TestMethod]
        public void ДобавлениеВСловарь_НовыйПроцессор_СозданиеНовойЗаписи()
        {
            var comp = new Computer("NewCPU", 2.5, 8, "Brand", false);

            _computerManager.AddComputer(comp);

            Assert.IsTrue(_computerManager.ComputersByProcessor.ContainsKey("NewCPU"));
            Assert.AreEqual(1, _computerManager.ComputersByProcessor["NewCPU"].Count);
        }

        //Проверяет, что при добавлении компьютера он добавляется в существующий список
        [TestMethod]
        public void ДобавлениеВСловарь_СуществующийПроцессор_ДобавлениеВСуществующийСписок()
        {

            var comp1 = new Computer("SameCPU", 2.5, 8, "Brand1", false);
            var comp2 = new Computer("SameCPU", 3.0, 16, "Brand2", true);
            _computerManager.AddComputer(comp1);

            _computerManager.AddComputer(comp2);

            Assert.AreEqual(1, _computerManager.ComputersByProcessor.Count);
            Assert.AreEqual(2, _computerManager.ComputersByProcessor["SameCPU"].Count);
        }

        //Проверяет, что возвращает true при успешном удалении
        [TestMethod]
        public void УдалениеКомпьютера_СуществующийКомпьютер_ВозвращаетTrue()
        {
            var computer = new Computer("Intel i7", 3.5, 16, "Dell", true);
            _computerManager.AddComputer(computer);

            var result = _computerManager.RemoveComputer();

            Assert.IsTrue(result);
            Assert.AreEqual(0, _computerManager.AllComputers.Count);
        }

        //Проверяет, что при попытке удалить из пустого списка возвращает false
        [TestMethod]
        public void УдалениеКомпьютера_ПустойСписок_ВозвращаетFalse()
        {
            var result = _computerManager.RemoveComputer();

            Assert.IsFalse(result);
        }

        //Проверяет, что компьютер удаляется по названию процессора
        [TestMethod]
        public void УдалениеКомпьютера_ПоИмениПроцессора_УспешноеУдаление()
        {
            var manager = new Computer("", 0, 0, "", false);
            manager.AddComputer(new Computer("Intel i5", 2.5, 8, "Dell", false));

            bool result = manager.RemoveComputer("Intel i5");


            Assert.IsTrue(result);
            Assert.AreEqual(0, manager.AllComputers.Count);
        }

        //Проверяет, что при попытке удалить несуществующий процессор возвращает false
        [TestMethod]
        public void УдалениеКомпьютера_НесуществующийПроцессор_ВозвращаетFalse()
        {
            var manager = new Computer("", 0, 0, "", false);

            bool result = manager.RemoveComputer("AMD Ryzen");

            Assert.IsFalse(result);
        }

        //Проверяет, что поиск компьютеров по процессору возвращает корректный список с правильным количеством элементов.
        [TestMethod]
        public void ПоискКомпьютеровПоПроцессору_СуществующийПроцессор_ВозвращаетСписок()
        {
            var computer1 = new Computer("Ryzen 5", 3.2, 8, "HP", false);
            var computer2 = new Computer("Ryzen 5", 3.4, 16, "Lenovo", true);
            _computerManager.AddComputer(computer1);
            _computerManager.AddComputer(computer2);

            var result = _computerManager.FindComputersByProcessor("Ryzen 5");

            Assert.AreEqual(2, result.Count);
        }
        //Проверяет, формула расчёта правильно работает
        [TestMethod]
        public void РасчетКачества_ОбычныйКомпьютер_ВозвращаетКорректноеЗначение()
        {
            var computer = new Computer("Intel i5", 2.5, 8, "Acer", false);

            var quality = computer.CalculateQuality();

            Assert.AreEqual(8.75, quality);
        }

    }

    [TestClass]
    public sealed class ServiceComputerTests
    {
        private Computer _computerManager;

        [TestInitialize]
        public void TestInitialize()
        {
            _computerManager = new Computer("", 0, 0, "", false);
        }
        //Проверяет, формула расчёта серверного компьютера правильно работает
        [TestMethod]
        public void РасчетКачества_СерверныйКомпьютер_ВозвращаетКорректноеЗначение()
        {
            var serviceComputer = new ServiceComputer("Xeon", 3.0, 32, "IBM", true, 2000, true);

            var quality = serviceComputer.CalculateQuality();

            Assert.AreEqual(1032.9, quality, 0.001);
        }

        //Проверяет, что метод GetInfo() возвращает строку с корректной информацией о серверном компьютере
        [TestMethod]
        public void ПолучениеИнформации_СерверныйКомпьютер_ВозвращаетКорректнуюСтроку()
        {
            var serviceComputer = new ServiceComputer("Xeon", 3.0, 32, "IBM", true, 2000, true);

            var info = serviceComputer.GetInfo();

            StringAssert.Contains(info, "Серверный Компьютер: Xeon");
            StringAssert.Contains(info, "HDD: 2000 ГБ");
            StringAssert.Contains(info, "Наличие SSD: Имеется");
        }

        //Проверяет, что серверный компьютер корректно добавляется в общий список и сохраняет свой тип ServiceComputer.
        [TestMethod]
        public void ДобавлениеСерверногоКомпьютера_ВОбщийСписок_РаботаетКорректно()
        {
            var serviceComputer = new ServiceComputer("Xeon", 3.0, 32, "IBM", true, 2000, true);

            _computerManager.AddComputer(serviceComputer);

            Assert.AreEqual(1, _computerManager.AllComputers.Count);
            Assert.IsTrue(_computerManager.AllComputers[0] is ServiceComputer);
        }
    }
}