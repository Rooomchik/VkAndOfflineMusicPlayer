using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace A_Player
{
    public static class SoundXml
    {
        public static void WriteXmlSound(this List<Sound> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Sound>));
            using (var stream = File.OpenWrite(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }

        public static void ReadXmlSound(this List<Sound> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Sound>));
            if (File.Exists(fileName))
            {
                using (var stream = File.OpenRead(fileName))
                {
                    var other = (List<Sound>)(serializer.Deserialize(stream));
                    list.Clear();
                    list.AddRange(other);
                }
            }
        }

        public static void DeleteXmlSound(this List<Sound> list, string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                list.Clear();
            }
        }
    }
}
