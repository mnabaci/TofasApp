using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace TofasApp
{
    public class Computer
    {
        public static bool RenameAndChangeIpAddress(ComputerValues parameters)
        {
            bool rename = Rename(parameters.ComputerName);
            bool idAddressChangeResult = ChangeIpAddress(parameters.NetworkAdapter, parameters.IpAddress, parameters.Gateway, parameters.Subnet);
            return rename && idAddressChangeResult;
        }
        public static bool Restart()
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.FileName = "cmd";
                proc.Arguments = "/C shutdown -f -r";
                Process.Start(proc);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private static bool Rename(string newName)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;

                string activeComputerName = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName";
                RegistryKey activeCmpName = key.CreateSubKey(activeComputerName);
                activeCmpName.SetValue("ComputerName", newName);
                activeCmpName.Close();
                string computerName = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName";
                RegistryKey cmpName = key.CreateSubKey(computerName);
                cmpName.SetValue("ComputerName", newName);
                cmpName.Close();
                string _hostName = "SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters\\";
                RegistryKey hostName = key.CreateSubKey(_hostName);
                hostName.SetValue("Hostname", newName);
                hostName.SetValue("NV Hostname", newName);
                hostName.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private static bool ChangeIpAddress(string adapterName, string ipAddress, string gateway, string subnet)
        {
            try
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo("netsh", $"interface ip set address \"{adapterName}\" static {ipAddress} {subnet} {gateway}");
                p.StartInfo = psi;
                p.Start();
                p.WaitForExit(5000);
                while (!p.HasExited) ;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
