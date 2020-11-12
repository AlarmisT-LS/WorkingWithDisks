using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithDisks
{
    class DVD : Storage
    {
        public string ReadingSpeed { get; set; }
        public string RecordingSpeed { get; set; }
        public string Type { get; set; }


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
