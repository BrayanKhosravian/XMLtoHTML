using System.Collections.Generic;
using XMLtoHTML_ClassLibrary.Models;

namespace XMLtoHTML_ClassLibrary.Serializers
{
    public interface IHtmlSerializer
    {
        void Serialize(List<ReleaseNote> releaseNotes, string path);
    }
}