using System;
using System.Xml.Serialization;

namespace OTC.DTO
{

    [Serializable]
    [XmlRoot("Punch", Namespace = "")]
    public class Punch
    {

        [XmlAttribute("DocumentNumber")]
        public string documentNumber
        {
            get;
            set;
        }

        [XmlElement("CreatedAt")]
        public string createdAt
        {
            get;
            set;
        }

        [XmlElement("Type")]
        public string type
        {
            get;
            set;
        }

    }
}
