using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithDisks
{
    class Flash : Storage
    {
        public long SpeedUsb3 { get; } = 5000000000; //TODO Usb 3.0 = 5.e+9 Бит
        //private decimal memorySize;
        //private decimal MemoryOccupied = 0;
        private Section section;

        public Flash(string mediaName, string model, Section section) : base(mediaName, model)
        {
            this.section = section;
        }

        public override void CopyDataToDevice(decimal bitfile)
        {
            if (bitfile < 0)
                throw new Exception("Не может быть вес файла меньше 0!");
            else if (SpareMemoryOnTheDevice() >= bitfile)
                section.BitBusy += bitfile;
            else if (SpareMemoryOnTheDevice() < bitfile)
                throw new Exception("Недостаточно памяти!");
        }

        public override string GetInfoDevice()
        {
            return
                $"Наименование носителя:{MediaName}\n" +
                $"Модель:{Model}\n" +
                $"Скорость USB 3.0:{SpeedUsb3}\n" +
                $"Объем памяти:{GettingMemorySize()} бит\n";
        }

        public override decimal GettingMemorySize()
        {
            return section.BitSize;
        }

        public override decimal SpareMemoryOnTheDevice()
        {
            return section.BitSize - section.BitBusy;
        }


    }
}
