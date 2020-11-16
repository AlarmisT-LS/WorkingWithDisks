using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithDisks
{
    class DVD : Storage
    {
        public int ReadingSpeed { get; } = 1385000;
        public int RecordingSpeed { get; } = 1385000;
        public string Type { get; set; }
        private Section section;

        public DVD(string mediaName, string model, string type, Section section) : base(mediaName, model)
        {
            this.section = section;
            Type = type;
        }

        public override void CopyDataToDevice(decimal bitfile)
        {
            section.BitBusy += bitfile;
        }

        public override string GetInfoDevice()
        {
            return
                $"Наименование носителя:{MediaName}\n" +
                $"Модель:{Model}\n" +
                $"Скорость чтения:{ReadingSpeed} бит" +
                $"Скорость записи:{RecordingSpeed} бит" +
                $"Объем памяти:{GettingMemorySize()} бит";
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
