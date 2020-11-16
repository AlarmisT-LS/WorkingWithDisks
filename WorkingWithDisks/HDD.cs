using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithDisks
{
    class HDD : Storage
    {
        public decimal SpeedUsb2 { get; } = 480000;
        List<Section> sections;

        public HDD(string mediaName, string model, Section memorySize) : base(mediaName, model)
        {
            sections.Add(memorySize);
        }
        public HDD(string mediaName, string model, List<Section> memorySize) : base(mediaName, model)
        {
            sections = memorySize;
        }

        public override decimal GettingMemorySize()
        {
            decimal sum = 0;
            foreach (var i in sections)
            {
                sum += i.BitSize;
            }
            return sum;
        }

        public override void CopyDataToDevice(decimal bitfile)
        {
            //TODO допустим файлы копируются на первый раздел на котором есть место под файл
            bool flagOperation = false;
            foreach (var i in sections)
            {
                try
                {
                    i.BitBusy += bitfile;
                    flagOperation = true;
                    break;
                }
                catch (Exception)
                {

                }
            }
            if (flagOperation == false)
            {
                throw new Exception("Нет разделов с достаточным количеством памяти для файла");
            }
        }

        public override decimal SpareMemoryOnTheDevice()
        {
            decimal sum = 0;
            foreach (var i in sections)
            {
                sum += (i.BitSize - i.BitBusy);
            }
            return sum;
        }

        public override string GetInfoDevice()
        {
            return
                $"Наименование носителя:{MediaName}\n" +
                $"Модель:{Model}\n" +
                $"Скорость USB 2.0:{SpeedUsb2}\n" +
                $"Кол-во разделов:{sections.Count}\n" +
                $"Объём разделов:{GettingMemorySize()} бит\n";
        }
    }
}
