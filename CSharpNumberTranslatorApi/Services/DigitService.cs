using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CSharpNumberTranslatorApi.Enums;
using CSharpNumberTranslatorApi.ExtensionMethods;
using CSharpNumberTranslatorApi.ServiceContracts;

namespace CSharpNumberTranslatorApi.Services
{
    public class DigitService : IDigitService
    {
        public int GetStartNumber(int number)
        {
            return number < 20
                ? number.GetDigit(DigitPlacesEnum.Ones)
                : number.GetDigit(DigitPlacesEnum.Tens);
        }
    }
}