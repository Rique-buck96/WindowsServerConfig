using System;
using System.Management.Automation;

namespace ServerSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a server type to configure\nApp\nWeb");
            var input = Console.ReadLine();

            using (var powerShellInstance = PowerShell.Create())
            {
                switch (input)
                {
                    case "Web":
                        try
                        {
                            powerShellInstance.AddScript(
                                "Install-WindowsFeature Web-Server\r\nInstall-WindowsFeature File-Services\r\nInstall-WindowsFeature Web-App-Dev\r\nInstall-WindowsFeature Web-asp-net45\r\nInstall-WindowsFeature Web-Mgmt-tools\r\nInstall-WindowsFeature Web-Mgmt-Console\r\nInstall-WindowsFeature Web-Mgmt-service\r\nInstall-WindowsFeature Web-Scripting-Tools\r\nInstall-WindowsFeature As-Web-Support\r\nInstall-WindowsFeature Web-WebSockets");
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        break;
                    case "App":
                        try
                        {
                            powerShellInstance.AddScript(
                                "Install-WindowsFeature Application-Server\r\nInstall-WindowsFeature Web-Server\r\nInstall-WindowsFeature File-Services\r\nInstall-WindowsFeature Web-App-Dev\r\nInstall-WindowsFeature Web-asp-net45\r\nInstall-WindowsFeature Web-Mgmt-tools\r\nInstall-WindowsFeature Web-Mgmt-Console\r\nInstall-WindowsFeature Web-Mgmt-service\r\nInstall-WindowsFeature Web-Scripting-Tools\r\nInstall-WindowsFeature As-Web-Support\r\nInstall-WindowsFeature Web-WebSockets\r\n");
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please specify a server type to configure");
                        break;
                }
            }
        }
    }
}
