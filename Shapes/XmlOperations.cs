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
        
        internal static bool SaveToXml(string path, PolygonData save)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PolygonData));
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, save);
            writer.Close();
            return true;
        }

        internal static PolygonData LoadFromXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PolygonData));
            PolygonData save;
            try
            {
                using (Stream reader = new FileStream(path, FileMode.Open, FileAccess.Read))
                    save = (PolygonData) serializer.Deserialize(reader);
                return save;
            }
            catch
            {
                return null;
            }
        }
    }
}
