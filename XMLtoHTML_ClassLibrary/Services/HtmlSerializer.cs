using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using XMLtoHTML_ClassLibrary.Models;

namespace XMLtoHTML_ClassLibrary.Services
{
    public class HtmlSerializer
    {
        public void Serialize(List<ReleaseNote> releaseNotes)
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



            result.Save(@"D:\_Projects\_Visual Studio Projects\ConsoleApps\XMLtoHTML\Exercise\Sprint_11945.html");
        }

    }
}
