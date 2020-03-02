using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SecondTask
{
    public class File
    {
        public string SafeFileName { get; set; }
        public string FileName { get; set; }

        public File(string safeFileName, string fileName)
        {
            SafeFileName = safeFileName;
            FileName = fileName;
        }
        public bool IsValid(PatternFileName pattern)
        {
            if (string.IsNullOrEmpty(pattern.Pattern)) return false;
            else if (Regex.IsMatch(SafeFileName, pattern.Pattern, RegexOptions.IgnoreCase))
                return true;

            return false;

        }
    }
}
