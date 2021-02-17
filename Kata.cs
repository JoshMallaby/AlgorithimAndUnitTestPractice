using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            String[] vowels = { "a", "e", "i", "o", "u" };
 
            foreach (String vowel in vowels)
            {
                str = str.Replace(vowel, "", true, culture: System.Globalization.CultureInfo.CurrentCulture);
            }

            return str;
        }
        public static string HighAndLow(string numbers)
        {
            String[] stringArray = numbers.Split(" ");
            int[] intArray = new int[stringArray.Length];
            
            for(int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }

            int highest = intArray[0];
            int lowest = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if(intArray[i] > highest)
                {
                    highest = intArray[i];
                }
                if (intArray[i] < lowest)
                {
                    lowest = intArray[i];
                }
            }

            return highest + " " + lowest;
        }
        public static long FindNextSquare(long num)
        {
            bool foundSquare = false;
            int counter = 1;
            double testValue = 0;

            if(Math.Sqrt(num) % 1 != 0)
            {
                return -1;
            }
            while (!foundSquare)
            {
                testValue = Math.Sqrt(num + counter);

                if (testValue % 1 == 0)
                {
                    foundSquare = true;
                }

                counter++;
            }

            return (long)(testValue * testValue);
        }
        public static string AlphabetPosition(string text)
        {
            string returnText = "";

            for (int i = 0; i < text.Length; i++)
            {
                int test = (int)text[i];
                if (64 < test && test < 91)
                {               
                    returnText += test - 64 + " ";
                }
                else if (96 < test && test < 123)
                {
                    returnText += test - 96 + " ";
                }
            }

            return returnText.TrimEnd();

            /*Dictionary<String, int> alphaMap = new Dictionary<string, int>();

            int j = 65;
            int k = 97;

            for(int i = 1; i < 27; i++)
            {
                char cUpper = (char)j;
                string upperString = cUpper.ToString();
                alphaMap.Add(upperString, i);

                char cLower = (char)k;
                string lowerString = cLower.ToString();
                alphaMap.Add(lowerString, i);
                j++;
                k++;
            }

            string returnText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (alphaMap.TryGetValue(text[i].ToString(), out int mapValue))
                {
                    returnText += mapValue + " ";
                }
            }

            return returnText.Trim();*/
        }
        public static int DuplicateCount(string str)
        {
            int duplicateCounter = 0;
            str = str.ToLower();
            string[] uniqueArray = new string[str.Length];
            string[] duplicateArray = new string[str.Length];

            for(int i = 0; i < str.Length; i++)
            {
                if (uniqueArray.Contains(str[i].ToString()))
                {
                    if (!duplicateArray.Contains(str[i].ToString()))
                    {
                        duplicateArray[i] = str[i].ToString();
                        duplicateCounter++;
                    }
                }
                else
                {
                    uniqueArray[i] = str[i].ToString();
                }
            }
            return duplicateCounter;
        }
        public static int DescendingOrder(int num)
        {
            string numString = num.ToString();
            int[] numArray = new int[numString.Length];

            for(int i=0; i < numString.Length; i++)
            {
                numArray[i] = (int)numString[i] - '0';
            }

            Array.Sort(numArray);
            Array.Reverse(numArray);
            string numStringFormat = "";

            var sortedStr = from i in numArray
                            orderby i descending
                            select i;

            foreach(int number in sortedStr)
            {
                numStringFormat += number;
            }
            numStringFormat = "";
            foreach (int number in numArray)
            {
                numStringFormat += number;
            }
            int returnValue = int.Parse(numStringFormat);

            return returnValue;
        }
        public static string MakeComplement(string dna)
        {
            char[] charArray = dna.ToCharArray();
            string returnValue = "";
            foreach(char c in charArray)
            {
                if(c == 'A')
                {
                    returnValue += 'T';
                }
                else if(c== 'T')
                {
                    returnValue += 'A';
                }
                else if(c == 'G')
                {
                    returnValue += 'C';
                }
                else if(c == 'C')
                {
                    returnValue += 'G';
                }

            }
            return returnValue;
        }
        public static string ToJadenCase(this string phrase)
        {
            string[] words = phrase.Split(" ");
            string stringFinal = "";

            foreach (string word in words)
            {
                stringFinal += char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ";
            }

            return stringFinal.TrimEnd();
        }
        public static IEnumerable<String> FriendOrFoe(String[] names)
        {
            return from a in names
                   where a.Length == 4
                   select a;
        }
        public static String Accum(string s)
        {
            s = s.ToLower();

            char[] charArrray = s.ToCharArray();

            string returnString = "";

            for (int i = 0; i < s.Length; i++)
            {
                returnString += charArrray[i].ToString().ToUpper();

                for(int k = 0; k < i; k++)
                {
                    returnString += charArrray[i].ToString();
                }

                if(i != s.Length - 1)
                {
                    returnString += "-";
                }             
            }

            return returnString;
        }
        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];
            for(int i = 0; i < nFloors; i++)
            {
                int numSpaces = nFloors - i;
                for(int s = numSpaces; s > 1; s--)
                {
                    tower[i] += " ";
                }

                int numAst = (2 * (i + 1)) - 1;

                for (int k = 0; k < numAst; k++)
                {
                    tower[i] += "*";
                }
                for (int s = numSpaces; s > 1; s--)
                {
                    tower[i] += " ";
                }

            }
            return tower;
        }
        public static string AddBinary(int a, int b)
        {
            int c = a + b;
            return Convert.ToString(c, 2); 
        }
        public static long digPow(int n, int p)
        {
            string stringN = n.ToString();
            char[] nArray = stringN.ToCharArray();

            double total = 0;
            for(int i = 0; i < stringN.Length; i++)
            {
                total += Math.Pow(Convert.ToDouble(nArray[i].ToString()), Convert.ToDouble(p + i));
            }

            double k = -1;
            if((total/Convert.ToDouble(n)) % 1 == 0)
            {
                k = total / Convert.ToDouble(n);
            }
            return Convert.ToInt64(k);
        }
        public static string ReverseWords(string str)
        {
            string[] stringArray = str.Split(" ");
            string finalString = "";

            foreach(string s in stringArray)
            {
                for(int i = s.Length - 1; i >= 0; i--)
                {
                    finalString += s.ElementAt(i);
                }
                finalString += " ";
          
            }

            return finalString.Trim();
        }
        public static bool IsPangram(string str)
        {
            char[] cArray = str.ToCharArray();
            char[] alphabetArray = new char[str.Length];
            int h = 0;

            foreach(char c in cArray)
            {
                if((c >= 65 && c <= 97) || c >= 97 && c <= 122)
                {
                    if (!alphabetArray.Contains(c))
                    {
                        alphabetArray[h] = c;
                    }
                }
                h++;
            }

            for(int i = 65; i < 91; i++)
            {             
                if (!alphabetArray.Contains(Convert.ToChar(i)) && !alphabetArray.Contains(Convert.ToChar(i + 32)))
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> intList = new List<int>();
            foreach(int initialArrayInt in arr)
            {
                int duplicateCounter = 0;

                foreach(int i in intList)
                {
                    if(i == initialArrayInt)
                    {
                        duplicateCounter++;
                    }                 
                }
                if (!(duplicateCounter > (x - 1)))
                {
                    intList.Add(initialArrayInt);
                }
            }
            return intList.ToArray();
        }
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            List<int> numList = new List<int>();

            foreach(int i in numbers)
            {
                numList.Add(i);
            }
            numList.Sort();
            return numList.ElementAt(0) + numList.ElementAt(1);
        }
        public static string ExpandedForm(long num)
        {
            char[] numbers = num.ToString().ToCharArray();
            string numString = "";

            for(int i = 0; i < numbers.Length; i++)
            {
                if(!(Convert.ToInt32(numbers[i].ToString()) == 0))
                {
                    numString += numbers[i].ToString();
                    int t = numbers.Length - i - 1;
                    for (int k = 0; k < t; k++)
                    {
                        numString += "0";
                    }
                    bool addPlus = false;
                    if(!(i == numbers.Length - 1))
                    {
                        for(int z = i + 1; z < numbers.Length; z++)
                        {
                            if(numbers[z] != '0')
                            {
                                addPlus = true;
                                break;
                            }
                        }
                        if (addPlus)
                        {
                            numString += " + ";
                        }
                        
                    }

                }
            }
            return numString;
        }
        public class StockList
        {
            public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
            {
                if(lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
                {
                    return "";
                }

                string returnString = "";
                
                foreach(string letter in lstOf1stLetter)
                {
                    int quantity = 0;

                    foreach (string stock in lstOfArt)
                    {
                        if(stock[0] == Convert.ToChar(letter))
                        {
                            string[] split = stock.Split(" ");
                            quantity += int.Parse(split[1]);
                        }
                    }
                    returnString += "(" + letter + " : " + quantity + ") - ";

                }

                return returnString.Trim(new char[] {'-', ' ' });
            }

        }
        public class Decompose
        {
            public string decompose(long n)
            {
                for(int i = 0; i < n; i++)
                {
                    long testNum = n - i;
                    long testPow = testNum * testNum;

                }
                return "";
            }
        }
        public static double[] Averages(int[] numbers)
        {
            if(numbers == null || numbers.Length < 2)
            {
                return new double[0];
            }
            double[] output = new double[numbers.Length - 1];
            int k = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                int[] intArray = new int[2] { numbers[k], numbers[k + 1]};
                output[i] = intArray.Average();
                k++;
            }
         
            return output;
        }
    }

}
