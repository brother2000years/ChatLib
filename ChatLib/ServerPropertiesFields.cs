using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
namespace ChatLib
{
    /// <summary>
    /// Класс настроек файла
    /// </summary>
    [Serializable]
    public class ServerPropertiesFields
    {
        public string ServerName = "MyServer";        
        public int Port = 11000;
        public ServerPropertiesFields() { }
        public ServerPropertiesFields(string serverName, int port)
        {
            ServerName = serverName;
            Port = port;
        }
        [XmlIgnore]
        public string XMLFileName = Path.Combine(Directory.GetCurrentDirectory(), "server_properties.xml");
    }
}
