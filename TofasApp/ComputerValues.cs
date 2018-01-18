using System.Xml.Serialization;

namespace TofasApp
{
    [XmlRoot("settings")]
    public class ComputerValues
    {
        [XmlElement("fileName")]
        public string FileName { get; set; }
        [XmlElement("computerName")]
        public string ComputerName { get; set; }
        [XmlElement("ipAddress")]
        public string IpAddress { get; set; }
        [XmlElement("subnet")]
        public string Subnet { get; set; }
        [XmlElement("gateway")]
        public string Gateway { get; set; }
        [XmlElement("networkAdapter")]
        public string NetworkAdapter { get; set; }
        [XmlElement("oldFolderName")]
        public string OldFolderName { get; set; }
        [XmlElement("newFolderName")]
        public string NewFolderName { get; set; }
        [XmlElement("folderLocation")]
        public string FolderLocation { get; set; }
        [XmlElement("copyFileName")]
        public string CopyFileName { get; set; }
        public override string ToString()
        {
            return FileName;
        }
    }
}
