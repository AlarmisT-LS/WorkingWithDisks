using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithDisks
{
    class HDD : Storage
    {
        public string Speed { get; set; }
        public int NumberOfSections { get; set; }
        public int VolumeOfSections { get; set; }


        public override void CopyDataToDevice()
        {
            throw new NotImplementedException();
        }

        public override void GetInfoDevice()
        {
            throw new NotImplementedException();
        }

        public override void GettingMemorySize()
        {
            throw new NotImplementedException();
        }

        public override void SpareMemoryOnTheDevice()
        {
            throw new NotImplementedException();
        }
    }
}
