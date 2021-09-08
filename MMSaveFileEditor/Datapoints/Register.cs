using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSaveFileEditor.Datapoints
{
    public class Register
    {
        private string name = "";
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int address = 0;
        public int Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        private byte[] data = new byte[1];
        public byte[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        private registerType type = registerType.Byte;
        public registerType Type
        { 
            get { return this.type; }
            set { this.type = value; }
        }

        private string stringValue = "";
        public string StringValue
        {
            get { return this.stringValue; }
            set { this.stringValue = value; }
        }

    }

    public enum registerType
    { 
        Bit=0,
        Byte=1,
        Integer16=2,
        String=3
    }

}
