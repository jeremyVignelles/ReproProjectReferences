using System;
using System.Diagnostics;

namespace RootProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var childProcess = Process.Start(new ProcessStartInfo
            {
                FileName = "ChildProcess.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true
            });

            Console.Out.Write(childProcess.StandardOutput.ReadToEnd());
        }
    }
}
