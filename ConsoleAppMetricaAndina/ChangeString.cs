using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetricaAndina
{
    public class ChangeString
    {
        public string build(string text) {
            var abecedario = new List<char>(){'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o','p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var result = "";
            foreach (var item in text.ToCharArray())
            {
                var charAfter = new char();
                if (Char.IsLetter(item))
                {
                    if (char.IsUpper(item))
                    {
                        charAfter = Char.ToUpper(char.ToLower(item)=='z'? 'A':abecedario[abecedario.IndexOf(char.ToLower(item)) + 1]);
                    }
                    else
                    {
                        charAfter = Char.ToLower(char.ToLower(item) == 'z' ? 'a' : abecedario[abecedario.IndexOf(char.ToLower(item)) + 1]);
                    }
                }
                else {

                    charAfter = item;
                }

                result = result + charAfter;
            }
            return result;
        }
    }
}
