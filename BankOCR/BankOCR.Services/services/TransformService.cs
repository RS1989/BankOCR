using BankOCR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOCR.Services.services
{
    public class TransformService: ITransformService
    {
        private readonly Zero _zero;
        private readonly One _one;
        private readonly Two _two;
        private readonly Three _three;
        private readonly Four _four;
        private readonly Five _five;
        private readonly Six _six;
        private readonly Seven _seven;
        private readonly Eight _eight;
        private readonly Nine _nine;
        public TransformService() 
        {
            _zero = new Zero();
            _one = new One();
            _two = new Two();
            _three = new Three();
            _four = new Four();
            _five = new Five();
            _six = new Six();
            _seven = new Seven();
            _eight = new Eight();
            _nine = new Nine();
        }

        public List<string> GetNumbers(List<List<Dictionary<int, string[,]>>> data)
        {
            var result = new List<string>();
            var numberCounter = 0;
            foreach (var row in data)
            {
                var numberString = string.Empty;
                var numberIsCorrect = true;
                for (int i=0; i < row.Count; i++)
                {                    
                    row[i].TryGetValue(numberCounter, out string [,] number);
                    numberCounter++;
                    if (IsArraysEquals(number, _zero.lines))
                    {
                        numberString = numberString + _zero.Digit;
                    }
                    else if (IsArraysEquals(number,_one.lines))
                    {
                        numberString = numberString + _one.Digit;
                    }
                    else if (IsArraysEquals(number,_two.lines))
                    {
                        numberString = numberString + _two.Digit;
                    }
                    else if (IsArraysEquals(number,_three.lines))
                    {
                        numberString = numberString + _three.Digit;
                    }
                    else if (IsArraysEquals(number,_four.lines))
                    {
                        numberString = numberString + _four.Digit;
                    }
                    else if (IsArraysEquals(number,_five.lines))
                    {
                        numberString = numberString + _five.Digit;
                    }
                    else if (IsArraysEquals(number,_six.lines))
                    {
                        numberString = numberString + _six.Digit;
                    }
                    else if (IsArraysEquals(number,_seven.lines))
                    {
                        numberString = numberString + _seven.Digit;
                    }
                    else if (IsArraysEquals(number, _eight.lines))
                    {
                        numberString = numberString + _eight.Digit;
                    }
                    else if (IsArraysEquals(number, _nine.lines))
                    {
                        numberString = numberString + _nine.Digit;
                    }
                    else 
                    {
                        numberIsCorrect = false;
                    }
                }
                if (numberIsCorrect)
                {
                    result.Add(numberString);
                }
                else 
                {
                    result.Add("Error in data");
                }
            }
            return result;
        }

        private bool IsArraysEquals(string[,] numbers, string[,] digist)
        {
            var result = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (numbers[i, j] != digist[i, j])
                    {
                        result = false;
                        break;
                    }
                    if (!result)
                        break;
                }
                if (!result)
                    break;
            }
            return result;
        }
    }
}
