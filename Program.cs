/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Type
{
    class Program
    {
        static void Main()
        {
            // C#'s string type immutable sequence of unicode characters.
            // A string literal is expressed inside double quotes:
            string a = "test";
            Console.WriteLine(a);
            // String is a reference type, rather than a value type.
            // Its equality operators, however, follow value-type semantics
            string b = "test";
            Console.WriteLine(b);
            Console.WriteLine(a == b);  // True
            // Escape sequences can be used inside strings:
            string c = "Here is a tab:\t";
            Console.WriteLine(c);
            // The cost of this is when you have to write a backslash, you have to use it twice:
            // This can be troublesome when trying to write file locations
            string d1 = "\\\\server\\fileshare\\helloworld.cs";
            Console.WriteLine(d1);
            // However, C# allows for verbatim string literals, which have to prefixed with @.
            string d2 = @"\\server\fileshare\helloworld.cs";
            Console.WriteLine(d2);
            // Verbatim string literals can also be used to span multiple lines:
            string escaped = "First Line\r\nSecond Line";
            Console.WriteLine(escaped);
            string verbatim = @"First Line
Second Line";
            Console.WriteLine(verbatim);
            // You can include the double-quote character in a verbatim literal by writing it twice:
            string xml = @"<customer id= ""123""></customer>";
            Console.WriteLine(xml);
        }
    }
}
