using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Utilities
{
    public class Tools
    {
        public static string MakePlural(string text)
        {
            text = text.EndsWith("y") ? text.Substring(0, text.Length - 1) + "ies" : text + "s";
            return text;
        }
        public static string ReplaceTurkishCharacters(string text)
        {
            char[] turkishCharacters = new char[13] { 'ı', 'ğ', 'ü', 'ş', 'ö', 'ç','I', 'İ', 'Ğ', 'Ü', 'Ş', 'Ö', 'Ç' };
            char[] englishCharacters = new char[13] { 'i', 'g', 'u', 's', 'o', 'c','i','i', 'g', 'u', 's', 'o', 'c' };
            for (int i = 0; i < turkishCharacters.Length; i++)
            {
                text = text.Replace(turkishCharacters[i], englishCharacters[i]);
            }
            return text;
        }
        public static string GetSqlType(PropertyInfo propertyInfo)
        {
            string type = "";
            switch (propertyInfo.PropertyType.ToString())
            {
                case
                    "System.Int32":
                    type = "int";
                    break;
                case
                    "System.String":
                    type = "nvarchar(50)";
                    break;
                case
                    "System.Decimal":
                    type = "money";
                    break;
                case
                    "System.Int16":
                    type = "SmallInt";
                    break;
                case
                    "System.Boolean":
                    type = "bit";
                    break;
                case
                    "System.Byte":
                    type = "tinyint";
                    break;
                case
                    "System.DateTime":
                    type = "date";
                    break;
                case
                    "System.Double":
                    type = "float";
                    break;
            }
            return type;
        }
    }
}
