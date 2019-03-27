using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XMLtoHTML_ClassLibrary.Models
{
    [XmlRoot(Namespace = "http://schema.MyCorp.at/ARLoader.xsd", ElementName = "ARLoader", IsNullable = true)]
    public class ReleaseNotes
    {
        [XmlAnyElement]
        public XmlElement[] AllElements;
    }
}
