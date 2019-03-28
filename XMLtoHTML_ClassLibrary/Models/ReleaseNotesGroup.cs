using System.Xml;
using System.Xml.Serialization;

namespace XMLtoHTML_ClassLibrary.Models
{
    [XmlRoot(Namespace = "http://schema.MyCorp.at/ARLoader.xsd", ElementName = "ARLoader", IsNullable = true)]
    public class ReleaseNotesGroup
    {
        [XmlAnyElement]
        public XmlElement[] AllElements;
    }
}
