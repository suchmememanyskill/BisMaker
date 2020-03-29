using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BisMaker
{
    enum BisTypes
    {
        BOOT0 = 0,
        BOOT1,
        BCPKG2_1,
        BCPKG2_3
    };
    class BisFile
    {
        public string path;
        public BisTypes type;
        public ulong size;

        public BisFile(string path, BisTypes type, ulong size)
        {
            this.path = path;
            this.size = size;
            this.type = type;
        }
        public BisFile(ref OpenFileDialog fileDialog, BisTypes type)
        {
            path = fileDialog.FileName;
            this.type = type;

            size = (ulong)new FileInfo(path).Length;
        }
        public byte[] GetAllBytes()
        {
            return File.ReadAllBytes(path);
        }
    }
}
