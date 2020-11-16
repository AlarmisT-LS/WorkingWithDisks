using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithDisks
{
    abstract class Storage
    {
        public string MediaName { get; set; }
        public string Model { get; set; }

        //получение объема памяти
        public abstract void GettingMemorySize();
        //копирование данных (файлов/папок) на устройство
        public abstract void CopyDataToDevice();
        //получение информации о свободном объеме памяти на устройстве
        public abstract void SpareMemoryOnTheDevice();
        //получение общей/полной информации об устройстве
        public abstract void GetInfoDevice();
    }
}
