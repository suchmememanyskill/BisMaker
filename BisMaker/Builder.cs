using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BisMaker
{
    class Builder
    {
        private BisFile boot0, boot1, bcpkg2_1, bcpkg2_3;
        private List<byte> bytes;

        public Builder(BisFile boot0, BisFile boot1, BisFile bcpkg2_1, BisFile bcpkg2_3)
        {
            this.boot0 = boot0;
            this.boot1 = boot1;
            this.bcpkg2_1 = bcpkg2_1;
            this.bcpkg2_3 = bcpkg2_3;

            bytes = new List<byte>();
        }

        public void Build(string path, string version, ref ProgressBar progressBar)
        {
            byte[] text = new byte[0x10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Encoding.UTF8.GetBytes(version).CopyTo(text, 0);

            bytes.AddRange(text);
            bytes.Add(0xf0);

            uint[] starts = new uint[4];

            starts[0] = (uint)boot0.size;
            starts[1] = (uint)boot1.size;
            starts[2] = (uint)bcpkg2_1.size;
            starts[3] = (uint)bcpkg2_3.size;

            foreach (uint i in starts)
                bytes.AddRange(ConvertInt(i));

            progressBar.Value = 10;

            bytes.AddRange(boot0.GetAllBytes());
            progressBar.Value = 20;

            bytes.AddRange(boot1.GetAllBytes());
            progressBar.Value = 30;

            bytes.AddRange(bcpkg2_1.GetAllBytes());
            progressBar.Value = 50;

            bytes.AddRange(bcpkg2_3.GetAllBytes());
            progressBar.Value = 70;

            if (File.Exists(path))
                File.Delete(path);

            using (Stream file = File.OpenWrite(path))
            {
                file.Write(bytes.ToArray(), 0, bytes.Count);
            }
            progressBar.Value = 100;

        }
        private byte[] ConvertInt(uint data)
        {
            byte[] convert = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                convert[i] = (byte)(data >> ((3 - i) * 8));
            }

            return convert;
        }
    }
}
