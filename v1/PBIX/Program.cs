using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation;
using System.Reflection;
using System.Windows.Forms;

namespace PBIAnalyzer
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            var ports = new List<string>();
            string daxFunctionsFile = @"Resources\dax-functions.txt";
            string daxFuncFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), daxFunctionsFile);

            string PSScript = @"$processids = Get-Process msmdsrv | Select-Object -ExpandProperty id 
                    if($processids)
                    {
                        foreach($processid in $processids)
                        {
                           Get-NetTCPConnection | ? {($_.State -eq 'Listen') -and ($_.RemoteAddress -eq '0.0.0.0') -and ($_.OwningProcess -eq $processid)} | Select-Object -ExpandProperty LocalPort 
                        } 
                    }";

            PowerShell ps = PowerShell.Create()
                       .AddScript(PSScript);

            var async = ps.BeginInvoke();

            foreach (PSObject result in ps.EndInvoke(async))
            {
                ports.Add($"localhost:{result.ToString()}");
            }

            var functions = File.ReadAllLines(daxFuncFilePath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(ports, functions));
        }
    }

}
