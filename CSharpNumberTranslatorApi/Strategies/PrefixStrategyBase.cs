using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Strategies
{
    public abstract class PrefixStrategyBase
    {
        private readonly IDigitService _digitService;

        protected PrefixStrategyBase(IDigitService digitService)
        {
            _digitService = digitService;
        }

        public int GetStartNumber(int number)
        {
            return _digitService.GetStartNumber(number);
        }
    }
}