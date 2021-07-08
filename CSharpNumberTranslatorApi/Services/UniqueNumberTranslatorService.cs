using System;
using CSharpNumberTranslatorApi.ExtensionMethods;
using CSharpNumberTranslatorApi.RepositoryContracts;
using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Services
{
    public class UniqueNumberTranslatorService : IUniqueNumberTranslatorService
    {
        private readonly IUniqueNumberRepository _uniqueNumberRepository;

        public UniqueNumberTranslatorService(IUniqueNumberRepository uniqueNumberRepository)
        {
            _uniqueNumberRepository = uniqueNumberRepository;
        }

        public string TranslateUniqueNumbers(int number)
        {
            return number.Between(0, 12)
                ? _uniqueNumberRepository.Get(number)
                : $"(TranslateOnes) Can't translate the number: {number}";
        }
    }
}