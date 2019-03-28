using XMLtoHTML.Services;
using XMLtoHTML_ClassLibrary.Converters;
using XMLtoHTML_ClassLibrary.Deserializers;
using XMLtoHTML_ClassLibrary.Serializers;

namespace XMLtoHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputManager inputManager = new InputManager();

            // string path = @"D:\_Projects\_Visual Studio Projects\ConsoleApps\XMLtoHTML\Exercise\Sprint_11945.xml"; // Debug

            string path = inputManager.GetPath("Enter a path of a .xml file! Format: X:\\..\\..\\filename.xml \n");

            HtmlSerializer htmlSerializer = new HtmlSerializer();
            XmlDeserializer xmlDeserializer = new XmlDeserializer();
            XmlToHtmlConverter xmlToHtmlConverter = new XmlToHtmlConverter(htmlSerializer, xmlDeserializer);

            xmlToHtmlConverter.Convert(path);
           
        }
    }

    
   
}
