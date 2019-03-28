using System.Xml.Serialization;

namespace XMLtoHTML_ClassLibrary.Models
{
    public class ReleaseNote
    {
        [XmlAttribute(AttributeName = "Key")]
        public string Key { get; set; }

        [XmlAttribute(AttributeName = "ItemId")]
        public string ItemId { get; set; }

        [XmlAttribute(AttributeName = "Subject")]
        public string Subject { get; set; }

        [XmlAttribute(AttributeName = "Text")]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "Release")]
        public string Release { get; set; }

        [XmlAttribute(AttributeName = "Category")]
        public string Category { get; set; }

        [XmlAttribute(AttributeName = "FixedAt")]
        public string FixedAt { get; set; }

        [XmlAttribute(AttributeName = "TicketId")]
        public string TicketId { get; set; }

        [XmlAttribute(AttributeName = "Priority")]
        public string Priority { get; set; }

        [XmlAttribute(AttributeName = "CustomerId")]
        public string CustomerId { get; set; }

        [XmlAttribute(AttributeName = "Classification")]
        public string Classification { get; set; }

       
    }
}
