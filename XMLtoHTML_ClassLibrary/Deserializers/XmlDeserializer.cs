using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using XMLtoHTML_ClassLibrary.Models;

namespace XMLtoHTML_ClassLibrary.Deserializers
{
    public class XmlDeserializer : IXmlDeserializer
    {
        public List<ReleaseNote> Deserialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ReleaseNotesGroup));
            FileStream fileStream = new FileStream(path, FileMode.Open);
            ReleaseNotesGroup deserializedElements = (ReleaseNotesGroup)serializer.Deserialize(fileStream);
            List<ReleaseNote> releaseNotes = CreateReleaseNotes(deserializedElements);
            return releaseNotes;
        }

        private List<ReleaseNote> CreateReleaseNotes(ReleaseNotesGroup deserializedElements)
        {
            List<ReleaseNote> final = new List<ReleaseNote>();

            foreach (var note in deserializedElements.AllElements)
            {
                ReleaseNote releaseNote = new ReleaseNote();

                foreach (XmlAttribute attribute in note.Attributes)  // "Name" and "Value"
                {
                    if (attribute.Name == "ar:Key") releaseNote.Key = attribute.Value;
                    else if (attribute.Name == "ItemId") releaseNote.ItemId = attribute.Value;
                    else if (attribute.Name == "Subject") releaseNote.Subject = attribute.Value;
                    else if (attribute.Name == "Text") releaseNote.Text = attribute.Value;
                    else if (attribute.Name == "Release") releaseNote.Release = attribute.Value;
                    else if (attribute.Name == "Category") releaseNote.Category = attribute.Value;
                    else if (attribute.Name == "FixedAt") releaseNote.FixedAt = attribute.Value;
                    else if (attribute.Name == "TicketId") releaseNote.TicketId = attribute.Value;
                    else if (attribute.Name == "Priority") releaseNote.Priority = attribute.Value;
                    else if (attribute.Name == "CustomerId") releaseNote.CustomerId = attribute.Value;
                    else if (attribute.Name == "Classification") releaseNote.Classification = attribute.Value;
                }

                final.Add(releaseNote);
            }

            return final;
        }
    }
}
