using System;
using System.Collections.Generic;
using System.Linq;
using CSharpNumberTranslatorApi.Enums;

namespace CSharpNumberTranslatorApi.ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool Between(this int number, int min, int max)
        {
            return min <= number && number <= max;
        }

        public static int GetDigit(this int number, DigitPlacesEnum digitPlace)
        {
            static DigitPlacesEnum MapDigitPlaces(int digit)
            {
                switch (digit)
                {
                    case 0:
                        return DigitPlacesEnum.Ones;
                    case 1:
                        return DigitPlacesEnum.Tens;
                    default:
                        return DigitPlacesEnum.None;
                }
            }

            static IDictionary<DigitPlacesEnum, int> IntToDictionary(int number)
            {
                var numberAsCharArray = number.ToString().ToCharArray();

                var count = 0;
                var dictionary = new Dictionary<DigitPlacesEnum, int>();
                foreach (var c in numberAsCharArray.Reverse())
                {
                    var digit = Convert.ToInt32(c.ToString());
                    var digitPlace = MapDigitPlaces(count);
                    count++;
                    dictionary.Add(digitPlace, digit);
                }

                return dictionary;
            }

            var digitDictionary = IntToDictionary(number);
            return digitDictionary[digitPlace];
        }
    }
}