using System;
using System.Xml.Serialization;

namespace OTC.DTO
{
    [Serializable]
    [XmlRoot("StaffMemberList", Namespace = "")]
    public class StaffMemberList
    {
        [XmlArray("StaffMemberList")]
        public StaffMember[] staffMemberList
        {
            get;
            set;
        }
    }
}
