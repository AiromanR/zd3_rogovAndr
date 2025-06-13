using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_RogovAndr
{
    public class ServiceComputer : Computer
    {
        //Дополнительные приватные поля для серверного компьютера
        private int _hddSize;
        private bool _hasSSD;

        public ServiceComputer(string processorName, double clockSpeed, int ramSize,
                             string manufacturer, bool hasDiscreteGraphics,
                             int hddSize, bool hasSSD)
            : base(processorName, clockSpeed, ramSize, manufacturer, hasDiscreteGraphics)
        {
            _hddSize = hddSize;
            _hasSSD = hasSSD;
        }

        //Методы доступа к полям
        public int GetHddSize() => _hddSize;
        public bool HasSSD() => _hasSSD;

        //Получение качества серверного компьютера
        public override double CalculateQuality()
        {
            return base.CalculateQuality() + 0.5 * _hddSize;
        }
        //Получение информации серверного компьютера
        public override string GetInfo()
        {
            string ssd = _hasSSD ? "Имеется" : "Отсутствует";
            return $"Серверный " + base.GetInfo() +
                  $", HDD: {_hddSize} ГБ, Наличие SSD: {ssd}, Qp: {CalculateQuality():F2}";
        }
    }
}
