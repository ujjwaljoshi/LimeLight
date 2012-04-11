using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimeLight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Case
            string mainString = "abcdefbc";
            string nullString = " ";
            Console.WriteLine(stringMatchingStringIndex(mainString, nullString));
            //Test Case            
            string emptyString = "";
            Console.WriteLine(stringMatchingStringIndex(mainString, emptyString));   
            //Test Case            
            string oneCharString = "e";
            Console.WriteLine(stringMatchingStringIndex(mainString, oneCharString));
            //Test Case            
            string subString = "def";
            Console.WriteLine(stringMatchingStringIndex(mainString, subString));
            //Test Case            
            string subString2 = "dfe";
            Console.WriteLine(stringMatchingStringIndex(mainString, subString2));
            //Test Case            
            string subString1 = "x";
            Console.WriteLine(stringMatchingStringIndex(mainString, subString1));
                 
            Console.Read();
        }

        private static int stringMatchingStringIndex(String mainStr, String subStr)
        {
            if ((mainStr == null) || (subStr == null) || mainStr.Length==0||subStr.Length==0|| (subStr.Length > mainStr.Length))
            {
                return -1;
            }
            int baseLength = mainStr.Length;
            int compareLength = subStr.Length;
            int startIndex = 0; int endIndex = 0;
            char[] mainStrCharArray = mainStr.ToCharArray();
            char[] subStrCharArray = subStr.ToCharArray();
            for (int i = 0; i <= baseLength - 1; i++)
            {
                if (mainStrCharArray[i] == subStrCharArray[0]) //Found first matching char; now start the index count
                {
                    startIndex = endIndex = i++;
                    if (compareLength != 1)//if string have just one character, should not go to this loop
                    {
                        for (int j = 1; (j < compareLength) && (i < baseLength); j++, i++)
                        {
                            if (mainStrCharArray[i] == subStrCharArray[j])
                            {
                                endIndex = i;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (((endIndex + 1) - startIndex) == compareLength)
                    {
                        Console.WriteLine("Found Match");
                        return startIndex;
                    }
                }
            }
            return -1;
        }

    }
}

/*Please write a method / function in your favorite language in less
than 50 lines of code that will return the index number (the position)
of a string within another string. Please do not use any pattern /
string matching library method, a sub string method, nor use regular
expressions, to solve this problem.         
         
Examples:
String 1: “abcdefg”
String 2: “bcd”
Returns: 1

String 1: “abcdefg”
String 2: “x”
Signal an error*/