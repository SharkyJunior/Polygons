using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Shapes
{
    static internal class XmlOperations
    {
        
        internal static bool SaveToXml(string path, SaveLoadFormat save)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SaveLoadFormat));
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, save);
            writer.Close();
            return true;
        }

        internal static SaveLoadFormat LoadFromXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Main));
            SaveLoadFormat save;
            try
            {
                using (Stream reader = new FileStream(path, FileMode.Open, FileAccess.Read))
                    save = (SaveLoadFormat)serializer.Deserialize(reader);
                return save;
            }
            catch
            {
                return null;
            }
        }
    }
}
