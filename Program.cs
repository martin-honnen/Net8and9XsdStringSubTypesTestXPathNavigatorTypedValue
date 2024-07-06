using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

var xmlSchemaSet = new XmlSchemaSet();
xmlSchemaSet.Add(null, "schema1.xsd");

var xmlReaderSettings = new XmlReaderSettings()
{
    ValidationType = ValidationType.Schema,
    Schemas = xmlSchemaSet
};

using var xmlReader = XmlReader.Create("sample1.xml", xmlReaderSettings);

var xmlDoc = new XmlDocument();

xmlDoc.Load(xmlReader);

var xpathNav = xmlDoc.CreateNavigator();

var leafElements = xpathNav.Select("//*[not(*)]");

foreach (XPathNavigator leafElement in leafElements)
{
    Console.WriteLine($"{leafElement.NodeType} {leafElement.Name} has typed value |{leafElement.TypedValue}| of type {leafElement.TypedValue.GetType()}");
}