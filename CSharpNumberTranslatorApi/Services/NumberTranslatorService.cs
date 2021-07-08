using CSharpNumberTranslatorApi.ExtensionMethods;
using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Services
{
    public class NumberTranslatorService : INumberTranslatorService
    {
        private readonly IUniqueNumberTranslatorService _uniqueNumberTranslatorService;
        private readonly ITeensTranslatorService _teensTranslatorService;
        private readonly ITensTranslatorService _tensTranslatorService;

        public NumberTranslatorService(IUniqueNumberTranslatorService uniqueNumberTranslatorService,
                                       ITeensTranslatorService teensTranslatorService,
                                       ITensTranslatorService tensTranslatorService)
        {
            _uniqueNumberTranslatorService = uniqueNumberTranslatorService;
            _teensTranslatorService = teensTranslatorService;
            _tensTranslatorService = tensTranslatorService;
        }

        public string Translate(int number)
        {
            if (number.Between(0, 12))
                return _uniqueNumberTranslatorService.TranslateUniqueNumbers(number);
            
            if (number.Between(13, 19))
                return _teensTranslatorService.TranslateTeens(number);
            
            if (number.Between(20, 99))
                return _tensTranslatorService.TranslateTens(number);

            return $"(Translate) Can't translate the number: {number}";
        }
    }
}