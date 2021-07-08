using CSharpNumberTranslatorApi.DbTables;
using CSharpNumberTranslatorApi.RepositoryContracts;

namespace CSharpNumberTranslatorApi.Repositories
{
    public class UniqueNumberRepository : IUniqueNumberRepository
    {
        public string Get(int number)
        {
            return UniqueNumbersTable.Table
                .Find(x => x.Number == number)
                ?.Text;
        }
    }
}