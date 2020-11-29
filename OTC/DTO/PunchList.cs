using System;
using System.Xml.Serialization;

namespace OTC.DTO
{

    [Serializable]
    [XmlRoot("PunchList", Namespace = "")]
    public class PunchList
    {
        [XmlArray("PunchList")]
        public Punch[] punchList
        {
            get;
            set;
        }
    }
}
