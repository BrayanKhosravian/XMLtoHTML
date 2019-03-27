using XMLtoHTML.Services;
using XMLtoHTML_ClassLibrary;
using XMLtoHTML_ClassLibrary.Services;

namespace XMLtoHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputManager inputManager = new InputManager();

            string path = @"D:\_Projects\_Visual Studio Projects\ConsoleApps\XMLtoHTML\Exercise\Sprint_11945.xml";

            // string path = inputManager.GetPath("Enter a path of a .xml file! Format: X:\\..\\..\\filename.xml \n");

            XmlDeserializer xmlDeserializer = new XmlDeserializer();
            xmlDeserializer.Run(path);
           
        }
    }

   
}
