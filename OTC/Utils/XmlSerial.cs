using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace OTC.Utils
{
    class XmlSerial
    {

        public T DeserializeObject<T>(string xmlObject)
        {
            T deserializedDto;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xmlObject);
            XmlTextReader xmlTextReader = new XmlTextReader(stringReader);

            deserializedDto = (T)xmlSerializer.Deserialize(xmlTextReader);
            xmlTextReader.Close();
            stringReader.Close();


            return deserializedDto;
        }

        public string SerializeObject<T>(T obj)
        {
            String serializedDto = string.Empty;

            StringWriter stringWriter = new StringWriter();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add("", "");

            using (XmlWriter writer = XmlWriter.Create(stringWriter, new XmlWriterSettings { OmitXmlDeclaration = true }))
            {
                xmlSerializer.Serialize(writer, obj, xmlNamespaces);
            }

            serializedDto = stringWriter.ToString();
            stringWriter.Close();

            return serializedDto;
        }
    }
}
