using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OTC.Utils
{
    class Functions
    {
        public static String GetCheckDigit(String Id)
        {
            int rut = int.Parse(Id);

            int digit;
            int counter;
            int multiple;
            int accumulator;
            String digitId;

            counter = 2;
            accumulator = 0;

            while (rut != 0)
            {
                multiple = (rut % 10) * counter;
                accumulator = accumulator + multiple;
                rut = rut / 10;
                counter = counter + 1;
                if (counter == 8)
                {
                    counter = 2;
                }
            }

            digit = 11 - (accumulator % 11);
            digitId = digit.ToString().Trim();
            if (digit == 10)
            {
                digitId = "K";
            }
            if (digit == 11)
            {
                digitId = "0";
            }
            return (digitId);
        }


        public static String SerializeObject(Object pObject)
        {
            try
            {
                String XmlizedString = null;
                MemoryStream memoryStream = new MemoryStream();
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;
                settings.Indent = true;

                using (XmlWriter writer = XmlWriter.Create(xmlTextWriter, settings))
                {
                    XmlSerializer serializer = new XmlSerializer(pObject.GetType());

                    XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);

                    serializer.Serialize(writer, pObject, namespaces);
                    memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
                    XmlizedString = UTF8ByteArrayToString(memoryStream.ToArray());
                }

                return XmlizedString;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }
        }

        public static object DeserializeObject<T>(String pXmlizedString)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(pXmlizedString));
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

            return xs.Deserialize(memoryStream);
        }

        public static String UTF8ByteArrayToString(Byte[] characters)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            String constructedString = encoding.GetString(characters);
            return (constructedString);
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static Byte[] StringToUTF8ByteArray(String pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }
    }
}
