using System.Collections.Generic;
using XMLtoHTML_ClassLibrary.Deserializers;
using XMLtoHTML_ClassLibrary.Models;
using XMLtoHTML_ClassLibrary.Serializers;

namespace XMLtoHTML_ClassLibrary.Converters
{
    public class XmlToHtmlConverter : IXmlToHtmlConverter
    {
        private readonly IHtmlSerializer _htmlSerializer;
        private readonly IXmlDeserializer _xmlDeserializer;

        public XmlToHtmlConverter(IHtmlSerializer htmlSerializer, IXmlDeserializer xmlDeserializer)
        {
            _htmlSerializer = htmlSerializer;
            _xmlDeserializer = xmlDeserializer;
        }

        public void Convert(string path)
        {
            List<ReleaseNote> releaseNotes = _xmlDeserializer.Deserialize(path);
            _htmlSerializer.Serialize(releaseNotes, path);
        }
    }
}
