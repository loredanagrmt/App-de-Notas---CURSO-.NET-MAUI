using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMauiApp.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://thecodercave.com";
        public string Message => "this app is written in MAUI"; 
    }
}
