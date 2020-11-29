using System;
using System.Xml.Serialization;

namespace OTC.DTO
{
    [Serializable]
    [XmlRoot("Staff", Namespace = "")]
    public class StaffMember
    {
        [XmlAttribute("Name")]
        public string name
        {
            get;
            set;
        }

        [XmlElement("DocumentNumber")]
        public string documentNumber
        {
            get;
            set;
        }

        [XmlElement("Fingerprint")]
        public byte[] fingerprint
        {
            get;
            set;
        }

        [XmlElement("FingerprintTemplateBytes")]
        public byte[] fingerprintTemplateBytes
        {
            get;
            set;
        }

        [XmlElement("FingerprintTemplateSize")]
        public int fingerprintTemplateSize
        {
            get;
            set;
        }
    }
}
