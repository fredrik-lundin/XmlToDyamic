using System.Xml.Linq;
using Xunit;

namespace XmlToDynamic.Core.Test
{
    public class ExtensionsTests
    {
        [Fact]
        public void ToDynamic__ShouldReturnDyanmicObject__WhenValidXmlDocument()
        {
            var xml = @"
                        <note>
                            <to>Tove</to>
                            <from>Jani</from>
                            <heading>Reminder</heading>
                            <body>Don't forget me this weekend!</body>
                        </note>
                     ";
            var xmlDoc = XDocument.Parse(xml);

            var dynamicObject = xmlDoc.ToDynamic();

            var to = dynamicObject.note.to;
            Assert.Equal("Tove", to);
        }
    }
}
