using System;
using System.Collections.Generic;
using System.Linq;

namespace DivideAndMaximize.App
{
    public class FindingTheGreatestSumFromDivideAndMultipleMethod : IFindingTheGreatestSumFromDivideAndMultipleMethod
    {
        private List<long> CalculatingNewArray(long[] numbers)
        {
            Array.Sort(numbers);
            var listOfNumbers = numbers.ToList();

            var multipleValue = listOfNumbers[listOfNumbers.Count - 1] * 2;

            //if(multipleValue > Math.Pow(10, 9))
            //{
            //    return listOfNumbers;
            //}

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if(listOfNumbers[i] % 2 == 0)
                {
                    listOfNumbers[i] /= 2;
                    break;
                }
            }

            listOfNumbers[listOfNumbers.Count - 1] = multipleValue;

            return listOfNumbers;

        }

        public int DivideAndMultiplyMethod(long[] numbers)
        {
            Array.Sort(numbers);
            var listOfNumbers = numbers.ToList();
            var ListToReturn = new List<long>();
            long minimumEvenNumber = 0;
            int count = 0;

            foreach (var number in listOfNumbers)
            {
                if (number % 2 != 0 && number != 1)
                {
                    count += 1;
                }
            }

            if(count > 0)
            {
                long value = 0;
                for (int i = listOfNumbers.Count; i > 0; i--)
                {
                    if (listOfNumbers[i-1] % 2 != 0)
                    {
                        listOfNumbers[i-1] *= 2;
                        value = listOfNumbers[i - 1];
                        break;
                    }   
                }

                for (int i = 0; i < listOfNumbers.Count; i++)
                {
                    if (listOfNumbers[i] % 2 == 0 && listOfNumbers[i] != value)
                    {
                        listOfNumbers[i] /= 2;
                        break;
                    }
                }
            }

            if (numbers.Length == 1)
            {
                return (int)numbers.Sum();
            }

            var stopping = false;
            
            while(stopping != true)
            {
                var listOfNumbers1 = listOfNumbers;
                listOfNumbers = CalculatingNewArray(listOfNumbers.ToArray());

                //if(listOfNumbers.Max() == listOfNumbers1.Max())
                //{
                //    stopping = true;
                //    break;
                //}

                foreach (var number in listOfNumbers)
                {
                    if (number % 2 == 0)
                    {
                        minimumEvenNumber = number;
                        break;
                    }
                }
                

                if (listOfNumbers.Max() == minimumEvenNumber)
                {
                    stopping = true;
                }

                
            }
            
            long sum = listOfNumbers.Sum();

            if( sum > 1000000007)
            {
                long value = sum % 1000000007;
                return (int)value;
            }

            return (int)sum;
            
        }
    }
}
