using System.Collections.Generic;
using System.Reflection;

namespace DxRep.Core.Extensions
{
    public class PropertyMapping
    {
        public string ClassName { get; set; }
        public PropertyInfo[] PropertyInfos { get; set; }
        public string PropertiesString { get; set; }
        public List<string> PropertiesList { get; set; }
        public string PrimaryKey { get; set; }
    }
}