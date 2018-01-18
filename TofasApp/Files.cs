using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace TofasApp
{
    public class Files
    {
        public static bool ReadyFiles(ComputerValues parameters)
        {
            try
            {
                if (Directory.Exists(Path.Combine(parameters.FolderLocation, parameters.OldFolderName)))
                {
                    Directory.Move(Path.Combine(parameters.FolderLocation, parameters.OldFolderName), Path.Combine(parameters.FolderLocation, parameters.NewFolderName));
                    File.Copy(Path.Combine(parameters.FolderLocation, parameters.CopyFileName), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), parameters.CopyFileName), true);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static IEnumerable<ComputerValues> ReadFiles()
        {
            try
            {
                var files = Directory.GetFiles("ComputerFiles", "*.xml").ToList();
                var returnValues = new List<ComputerValues>();
                foreach (var item in files)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ComputerValues));
                    using (FileStream fileStream = new FileStream(item, FileMode.Open))
                    {
                        ComputerValues result = (ComputerValues)serializer.Deserialize(fileStream);
                        if (string.IsNullOrWhiteSpace(result.ComputerName) || string.IsNullOrWhiteSpace(result.CopyFileName) ||
                            string.IsNullOrWhiteSpace(result.FileName) || string.IsNullOrWhiteSpace(result.FolderLocation) ||
                            string.IsNullOrWhiteSpace(result.Gateway) || string.IsNullOrWhiteSpace(result.IpAddress) ||
                            string.IsNullOrWhiteSpace(result.NetworkAdapter) || string.IsNullOrWhiteSpace(result.NewFolderName) ||
                            string.IsNullOrWhiteSpace(result.OldFolderName) || string.IsNullOrWhiteSpace(result.Subnet))
                        {
                            continue;
                        }
                        else
                        {
                            returnValues.Add(result);
                        }
                    }
                }
                return returnValues;
            }
            catch (Exception)
            {
                return new List<ComputerValues>();
            }
        }
    }
}
