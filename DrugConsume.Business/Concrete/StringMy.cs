using DevFramework.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrugConsume.Business.Concrete
{
    public class StringMy
    {
        readonly string _value;
        public StringMy(string value)
        {
            this._value = value;
        }
        public static implicit operator string(StringMy stringX)
        {
            return stringX._value;
        }
        public static implicit operator StringMy(string stringX) { return new StringMy(stringX); }
        public static StringMy Parse(string text)
        {
            return new StringMy(text);
        }

        public string RemoveLanguageSensitivity()
        {
           return Tools.ReplaceTurkishCharacters(this._value);  
        }
    }
}
