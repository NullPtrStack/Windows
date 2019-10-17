using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//new project -> C# Console App (.NET Framework) -> .Net 4.0
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This runs powershell script:\n" + System.AppDomain.CurrentDomain.BaseDirectory + "payload.ps1");
            string strCmdText;
            strCmdText = "-executionpolicy bypass -file " + System.AppDomain.CurrentDomain.BaseDirectory + "payload.ps1";
            System.Diagnostics.Process.Start("powershell.exe", strCmdText);
            Console.WriteLine("\n\nEnd of program\nCurrent Folder: " + System.AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine("Run:\npowershell " + strCmdText);
        }
    }
}
