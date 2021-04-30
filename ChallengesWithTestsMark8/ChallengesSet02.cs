using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }



        public bool CountOfElementsIsEven(string[] vals)
        {
            var i = vals.Length;

            if (i % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //return number % 2 == 0; (another way)



        public bool IsNumberOdd(int num)
        { if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();

            double min = 1000;
            double max = 0;

            foreach(var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return max + min;
        }



        public int GetLengthOfShortestString(string str1, string str2)
        {
            var s1 = str1.Length;
            var s2 = str2.Length;

            if (s1 < s2)
            {
                return s1;
            }
            else
                return s2;
        }


        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

                return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            int evens = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens += num;
                }
            }

            return evens;

        }
        //call each number
        //if number % 2 = 0, number is even
        //add evens to new array
        //add array


        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);

        }



        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            } 
        }

    
        }
    }

