using System.Collections.Generic;
using XMLtoHTML_ClassLibrary.Models;

namespace XMLtoHTML_ClassLibrary.Deserializers
{
    public interface IXmlDeserializer
    {
        List<ReleaseNote> Deserialize(string path);
    }
}