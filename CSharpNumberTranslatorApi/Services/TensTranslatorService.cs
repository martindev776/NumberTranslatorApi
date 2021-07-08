using CSharpNumberTranslatorApi.Enums;
using CSharpNumberTranslatorApi.ExtensionMethods;
using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Services
{
    public class TensTranslatorService : ITensTranslatorService
    {
        private readonly IPrefixService _prefixService;
        private readonly IUniqueNumberTranslatorService _uniqueNumberTranslatorService;

        public TensTranslatorService(IPrefixService prefixService,
                                     IUniqueNumberTranslatorService uniqueNumberTranslatorService)
        {
            _prefixService = prefixService;
            _uniqueNumberTranslatorService = uniqueNumberTranslatorService;
        }

        public string TranslateTens(int number)
        {
            var prefix = _prefixService.GetPrefix(number);
            var suffix = "ty";

            var onesDigit = number.GetDigit(DigitPlacesEnum.Ones);

            var onesNumber = onesDigit == 0
                ? ""
                : "-" + (_uniqueNumberTranslatorService.TranslateUniqueNumbers(onesDigit));

            return prefix + suffix + onesNumber;
        }
    }
}