using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BisMaker
{
    static class Validator
    {
        static public void Validate(BisFile file, BisTypes type)
        {
            if (file == null)
                throw new Exception($"No {type} has been selected!");

            if (!File.Exists(file.path))
                throw new Exception($"Invalid path for {type}");
        }
        static public void ValidateVersion(string version)
        {
            if (string.IsNullOrEmpty(version))
                throw new Exception("Version string is nothing");

            if (version.Length > 0xF)
                throw new Exception("Version string too long (max 15 characters)");
        }
    }
}
