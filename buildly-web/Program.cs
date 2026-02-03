using System;
using System.Diagnostics;

namespace Buildly.React
{
    class Program
    {
        static void Main(string[] args)
        {
            var psi = new ProcessStartInfo("cmd", "/c npm start")
            {
                WorkingDirectory = AppContext.BaseDirectory,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
