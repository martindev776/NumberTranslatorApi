using System;
using CSharpNumberTranslatorApi.ExtensionMethods;
using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Services
{
    public class TeensTranslatorService : ITeensTranslatorService
    {
        private readonly IPrefixService _prefixService;

        public TeensTranslatorService(IPrefixService prefixService)
        {
            _prefixService = prefixService;
        }

        public string TranslateTeens(int number)
        {
            if (number.Between(13, 19))
                return _prefixService.GetPrefix(number) + "teen";

            throw new Exception($"(TranslateTeens) Can't translate the number: {number}");
        }
    }
}