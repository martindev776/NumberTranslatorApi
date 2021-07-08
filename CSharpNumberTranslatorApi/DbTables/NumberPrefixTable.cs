using System.Collections.Generic;
using CSharpNumberTranslatorApi.Models;

namespace CSharpNumberTranslatorApi.DbTables
{
    public static class NumberPrefixTable
    {
        public static List<NumberPrefix> Table => new()
        {
            new NumberPrefix { Number = 2, Text = "twen" },
            new NumberPrefix { Number = 3, Text = "thir" },
            new NumberPrefix { Number = 4, Text = "for" },
            new NumberPrefix { Number = 5, Text = "fif" },
            new NumberPrefix { Number = 8, Text = "eigh" }
        };
    }
}