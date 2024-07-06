# Net8and9XsdStringSubTypesTestXPathNavigatorTypedValue

Sample .NET 8 console app that shows that, for XSD schema validated XML, .NET's XPathNavigator.TypedValue fails to normalize the XSD xs:string subtypes like xs:token, xs:language, xs:Name.
In contrast, when using .NET's XmlSerializer with classes and properties/fields annotated with those type, the values are normalized.