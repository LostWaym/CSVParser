using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public enum LexerToken
    {
        End,
        Quotation,//"
        Comma,//,
        Tab,//\t
        BreakLine,//\r || \n
        Space,//
        Literal,//others
    }
}
