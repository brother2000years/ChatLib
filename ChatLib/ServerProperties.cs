using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Xml.Serialization;
namespace ChatLib
{
    public class ServerProperties
    {
        public ServerPropertiesFields Fields { get; private set; }
        public ServerProperties()
        {
            Fields = new ServerPropertiesFields();
        }
        public ServerProperties(ServerPropertiesFields fields)
        {
            Fields = fields;
        }

        /// <summary>
        /// Запись настроек в файл
        /// </summary>
        public void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(ServerPropertiesFields));
            TextWriter wr = new StreamWriter(Fields.XMLFileName);
            ser.Serialize(wr, Fields);
            wr.Close();
        }

        /// <summary>
        /// Прочитать файл настроек
        /// </summary>
        public void ReadXML()
        {
            if (File.Exists(Fields.XMLFileName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(ServerPropertiesFields));
                TextReader rd = new StreamReader(Fields.XMLFileName);
                Fields = (ServerPropertiesFields)ser.Deserialize(rd);
                rd.Close();
            }
            else
            {
                WriteXml();
            }
        }
    }
}
