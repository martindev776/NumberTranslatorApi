using System.Linq;
using CSharpNumberTranslatorApi.DbTables;
using CSharpNumberTranslatorApi.RepositoryContracts;

namespace CSharpNumberTranslatorApi.Repositories
{
    public class NumberPrefixRepository : INumberPrefixRepository
    {
        public string Get(int number)
        {
            return NumberPrefixTable.Table
                .Find(x => x.Number == number)
                ?.Text;
        }
    }
}