using System;
using System.Collections.Generic;

namespace LeetSpeakGenerator.Objects
{
    public class LeetSpeak
    {
        private char[] _userInput;
        private static string[] _newInput;

    public LeetSpeak(string userInput)
    {
        _userInput = userInput;
    }

    public static char[] letterToConvert = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};

    public static string[] leetLetter = {"4", "|3", "(", "|)", "3", "ph", "6", "|-|", "1", "_/", "|<", "|_", "|V|", "/V", "0", "|>", "O_", "|2", "§", "7", "|_|", "V", "VV", "><", "¥", "2", " "};


    public static string ArrayConversion(string disassembleInput)
    {
        var checkChars = disassembleInput.ToCharArray();
        _newInput = new string[checkChars.Length];
        for(var index1 = 0; index1 < checkChars.Length; index1++)
        {
            for(var index = 0; index < 27; index++)
            {
                if(checkChars[index1] == letterToConvert[index])
                {
                    _newInput[index1] = leetLetter[index];
                    Console.Write(_newInput[index1]);
                }
            }
        }
        return string.Join("", _newInput);
    }



    //
    //
    // //Getters and Setters
    public static char[] GetUserInput()
    {
        return _userInput;
    }
    public static void SetUserInput()
    {
        _userInput = userInput;
    }
    // public static string GetDisassembleInput()
    // {
    //     return _disassembleInput;
    // }
    // public static void SetUserInput()
    // {
    //     _disassembleInput = disassembleInput;
    // }
    // public static string GetUserInput()
    // {
    //     return _leetConversionResult;
    // }
    // public static void  SetUserInput()
    // {
    //     _leetConversionResult = _leetConversionResult;
    // }
    //
    //
    // //Function to take input and convert it to a character array that will be analyzed to determine which letters to replace.
    // public static var Conversion(disassembleInput)
    // {
    //     foreach( )
    // }
    }
}
