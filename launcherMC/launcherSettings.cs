using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcherMC
{
    public static class launcherSettings
    {
        public static string USERNAME { get; set; }
        public static int MaximumRam { get; set; } = 4096;
        public static int MinimumRam { get; set; } = 512;
        public static int Width { get; set; } = 1200;
        public static int Height { get; set; } = 900;
        public static bool fullScreen { get; set; } = false;
        //if you want to join a server when minecraft open then delete the comment characters
        //public string joinServer { get; set; } = "server.org";

    }
}
