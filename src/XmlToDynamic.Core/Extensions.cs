using System;
using System.Dynamic;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace XmlToDynamic.Core
{
    public static class Extensions
    {
        public static dynamic ToDynamic(this XDocument xmlDocuemnt)
        {
            var jsonText = JsonConvert.SerializeXNode(xmlDocuemnt);
            return JsonConvert.DeserializeObject<ExpandoObject>(jsonText);
        }
    }
}
