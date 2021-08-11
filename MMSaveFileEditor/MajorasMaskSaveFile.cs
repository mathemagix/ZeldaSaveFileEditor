using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSaveFileEditor
{
    class MajorasMaskSaveFile
    {

        public byte[] baseData;
        public int primaryFileAddress;
        public int secondaryFileAddress;    //every file has a duplicate of the save data for integrity
        List<SaveFileParameter> saveFileParameters;

        public MajorasMaskSaveFile(byte[] fullBaseData, int primaryAddress, int secondaryAddress)
        {
            
        }

        
    }
}
