using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf
{
    class ChromeProcessInfo
    {
        public DirectoryInfo ChromeUserDirectory { get; set; }
        public Process ChromeProcess { get; set; }
    }
}
