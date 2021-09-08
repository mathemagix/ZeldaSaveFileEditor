using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N64SaveFileEditor
{
    class SaveFileParameter
    {
        public SaveFileParameter(string name, DataType type, object value)
        {
            this.name = name;
            this.type = type;
            switch (type)
            {
                case DataType.Bit:
                    this.bitValue = (bool)value;
                    break;
                case DataType.OneByteInteger:
                case DataType.TwoByteInteger:
                    this.intValue = (int)value;
                    break;
                case DataType.ASCII:
                    this.stringValue = (string)value;
                    break;
            }
        }
        public enum DataType
        {
            OneByteInteger = 0,
            TwoByteInteger = 1,
            Bit = 2,
            ASCII = 3
        }

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

        private DataType type = DataType.OneByteInteger;
        public DataType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        private int bitNumber = 0;
        public int BitNumber
        {
            get { return this.bitNumber; }
            set { this.bitNumber = value; }
        }

        private string stringValue = "";
        public string StringValue
        {
            get { return this.stringValue; }
            set { this.stringValue = value; }
        }

        private bool bitValue = false;
        public bool BitValue
        {
            get { return this.BitValue; }
            set { this.BitValue = value; }
        }

        private int intValue = 0;
        public int IntValue
        {
            get { return this.intValue; }
            set { this.intValue = value; }
        }

    }
}
