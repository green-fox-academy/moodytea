using System;
using System.Diagnostics;

namespace ProcessStartAndWrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProcess();
        }

        static void StartProcess()
        {
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.FileName = "cmd.exe";
            pro.WorkingDirectory = @"C:\";
            Process proStart = new Process();
            proStart.StartInfo = pro;
            proStart.Start();
            string output = proStart.StandardOutput.ReadToEnd();
            MessageBox.Show(output);
            proStart.WaitForExit();
        }
    }
}
