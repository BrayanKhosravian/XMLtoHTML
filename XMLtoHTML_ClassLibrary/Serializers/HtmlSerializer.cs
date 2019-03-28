using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XMLtoHTML_ClassLibrary.Models;

namespace XMLtoHTML_ClassLibrary.Serializers
{
    public class HtmlSerializer : IHtmlSerializer
    {
        public void Serialize(List<ReleaseNote> releaseNotes, string path)
        {
            List<ReleaseNote> releaseNotesWithCustomerId = new List<ReleaseNote>();
            List<ReleaseNote> releaseNotesWithoutCustomerId = new List<ReleaseNote>();

            foreach (var releaseNote in releaseNotes)
            {
                if (string.IsNullOrEmpty(releaseNote.CustomerId))
                    releaseNotesWithoutCustomerId.Add(releaseNote);
                else
                    releaseNotesWithCustomerId.Add(releaseNote);
            }

            this.CreateHtmlFile(releaseNotesWithoutCustomerId, path);

            foreach (var releaseNote in releaseNotesWithCustomerId)
            {
                this.CreateHtmlFile(releaseNote, path);
            }
        }

        private void CreateHtmlFile(List<ReleaseNote> releaseNotes, string path)
        {
            XDocument result = new XDocument(
                            new XElement("table", new XAttribute("border", 1),
                                new XElement("thead",
                                    new XElement("tr",
                                        new XElement("td", "ar:Key"),
                                        new XElement("td", "ItemId"),
                                        new XElement("td", "Subject"),
                                        new XElement("td", "Text"),
                                        new XElement("td", "Release"),
                                        new XElement("td", "Category"),
                                        new XElement("td", "FixedAt"),
                                        new XElement("td", "TicketId"),
                                        new XElement("td", "Priority"),
                                        new XElement("td", "CustomerId"),
                                        new XElement("td", "Classification"))),
                                new XElement("tbody",
                                    from releaseNote in releaseNotes
                                    select new XElement("tr",
                                        new XElement("td", releaseNote.Key),
                                        new XElement("td", releaseNote.ItemId),
                                        new XElement("td", releaseNote.Subject),
                                        new XElement("td", releaseNote.Text),
                                        new XElement("td", releaseNote.Release),
                                        new XElement("td", releaseNote.Category),
                                        new XElement("td", releaseNote.FixedAt),
                                        new XElement("td", releaseNote.TicketId),
                                        new XElement("td", releaseNote.Priority),
                                        new XElement("td", releaseNote.CustomerId),
                                        new XElement("td", releaseNote.Classification))
                                    )
                                )
                            );

            path = path.Replace(".xml", ".html");
            result.Save(path);
        }

        private void CreateHtmlFile(ReleaseNote releaseNote, string path)
        {
            XDocument result = new XDocument(
                            new XElement("table", new XAttribute("border", 1),
                                new XElement("thead",
                                    new XElement("tr",
                                        new XElement("td", "ar:Key"),
                                        new XElement("td", "ItemId"),
                                        new XElement("td", "Subject"),
                                        new XElement("td", "Text"),
                                        new XElement("td", "Release"),
                                        new XElement("td", "Category"),
                                        new XElement("td", "FixedAt"),
                                        new XElement("td", "TicketId"),
                                        new XElement("td", "Priority"),
                                        new XElement("td", "CustomerId"),
                                        new XElement("td", "Classification"))),
                                new XElement("tbody",
                                    new XElement("tr",
                                        new XElement("td", releaseNote.Key),
                                        new XElement("td", releaseNote.ItemId),
                                        new XElement("td", releaseNote.Subject),
                                        new XElement("td", releaseNote.Text),
                                        new XElement("td", releaseNote.Release),
                                        new XElement("td", releaseNote.Category),
                                        new XElement("td", releaseNote.FixedAt),
                                        new XElement("td", releaseNote.TicketId),
                                        new XElement("td", releaseNote.Priority),
                                        new XElement("td", releaseNote.CustomerId),
                                        new XElement("td", releaseNote.Classification))
                                    )
                                )
                            );

            path = path.Replace(".xml", "");
            path += "_" + releaseNote.CustomerId + ".html";
            result.Save(path);
        }
    }
}
