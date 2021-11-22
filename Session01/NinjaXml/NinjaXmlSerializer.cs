using System;
using System.Reflection;
using System.Text;

namespace NinjaXml
{
    public static class NinjaXmlSerializer
    {
        public static string Serialize(object instance)
        {
            if (instance == null) return string.Empty;

            var outputXml = new StringBuilder();

            var typeOfObject = instance.GetType();
            var nameOfType = typeOfObject.Name;

            outputXml.Append(OpenTag(nameOfType));
            outputXml = AppendProperties(instance, typeOfObject, outputXml);
            outputXml.Append(CloseTag(nameOfType));

            return outputXml.ToString();
        }
        private static StringBuilder AppendProperties(object instance, Type typeOfObject, StringBuilder outputXml)
        {
            var properties = typeOfObject.GetProperties();

            foreach (var propertyInfo in properties)
            {
                var nameOfProperty = propertyInfo.Name;
                var valueOfProperty = propertyInfo.GetValue(instance, null);

                outputXml.Append($"{OpenTag(nameOfProperty)}{valueOfProperty}{CloseTag(nameOfProperty)}");
            }
            return outputXml;
        }

        private static string OpenTag(string nameOfType)
        {
            return $"<{nameOfType}>";
        }
        private static string CloseTag(string nameOfType)
        {
            return $"</{nameOfType}>";
        }
    }
}
