using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AudioDeviceChanger
{
    class Settings
    {
        static public string headphones = "Headphones";
        static public string speakers = "Speakers";
        static public string defaultDevice = "headphones";
        static public System.IO.DirectoryInfo directory;
        static public void saveToXML(string xmlPath){
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode root = xmlDoc.CreateElement("settings");
            xmlDoc.AppendChild(root);

            XmlNode headphonesNode = xmlDoc.CreateElement("headphones");
            headphonesNode.InnerText = headphones;
            root.AppendChild(headphonesNode);

            XmlNode speakersNode = xmlDoc.CreateElement("speakers");
            speakersNode.InnerText = speakers;
            root.AppendChild(speakersNode);

            XmlNode defNode = xmlDoc.CreateElement("defaultDevice");
            defNode.InnerText = defaultDevice;
            root.AppendChild(defNode);

            xmlDoc.Save(xmlPath);
        }
        static public void updateFromXML(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlNode root = xmlDoc.FirstChild;
            foreach (XmlNode child in root.ChildNodes)
            {
                switch (child.Name)
                {
                    case "headphones":
                        headphones = child.InnerText;
                        break;
                    case "speakers":
                        speakers = child.InnerText;
                        break;
                    case "defaultDevice":
                        defaultDevice = child.InnerText;
                        break;
                    default:
                        break;
                }
            }
        }
        static public void updateSettings(string Headphones, string Speakers, bool isDefaultHeadphones)
        {
            headphones = Headphones;
            speakers = Speakers;
            defaultDevice = (isDefaultHeadphones ? "headphones" : "speakers");
            saveToXML(directory.FullName + "\\Settings.xml");
        }
    }
}
