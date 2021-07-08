using System.Collections.Generic;
using CSharpNumberTranslatorApi.Models;

namespace CSharpNumberTranslatorApi.DbTables
{
    public static class UniqueNumbersTable
    {
        public static List<UniqueNumber> Table => new()
        {
            new UniqueNumber { Number = 0, Text = "zero"},
            new UniqueNumber { Number = 1, Text = "one" },
            new UniqueNumber { Number = 2, Text = "two" },
            new UniqueNumber { Number = 3, Text = "three" },
            new UniqueNumber { Number = 4, Text = "four" },
            new UniqueNumber { Number = 5, Text = "five" },
            new UniqueNumber { Number = 6, Text = "six" },
            new UniqueNumber { Number = 7, Text = "seven" },
            new UniqueNumber { Number = 8, Text = "eight" },
            new UniqueNumber { Number = 9, Text = "nine" },
            new UniqueNumber { Number = 10, Text = "ten" },
            new UniqueNumber { Number = 11, Text = "eleven" },
            new UniqueNumber { Number = 12, Text = "twelve" },
        };
    }
}