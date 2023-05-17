using System;

class Program
{
    static string NumberToWords(int number)
    {
        if (number < 0 || number > 999)
        {
            return "out of ability";
        }

        if (number == 0)
        {
            return "Zero";
        }

        string result = "";

        // Handle hundreds place
        if (number >= 100)
        {
            int hundreds = number / 100;
            result += NumberToWordsOnes(hundreds) + " Hundred and ";
            number %= 100;
        }

        // Handle tens and ones place
        if (number >= 20)
        {
            int tens = number / 10;
            result += NumberToWordsTens(tens);
            number %= 10;
        }

        // Handle ones place
        if (number > 0)
        {
            result += NumberToWordsOnes(number);
        }

        return result.Trim();
    }

    static string NumberToWordsOnes(int number)
    {
        switch (number)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            case 10:
                return "Ten";
            case 11:
                return "Eleven";
            case 12:
                return "Twelve";
            case 13:
                return "Thirteen";
            case 14:
                return "Fourteen";
            case 15:
                return "Fifteen";
            case 16:
                return "Sixteen";
            case 17:
                return "Seventeen";
            case 18:
                return "Eighteen";
            case 19:
                return "Nineteen";
            default:
                return "";
        }
    }

    static string NumberToWordsTens(int number)
    {
        switch (number)
        {
            case 2:
                return "Twenty ";
            case 3:
                return "Thirty ";
            case 4:
                return "Forty ";
            case 5:
                return "Fifty ";
            case 6:
                return "Sixty ";
            case 7:
                return "Seventy ";
            case 8:
                return "Eighty ";
            case 9:
                return "Ninety ";
            default:
                return "";
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter a number with up to 3 digits");
        int number = int.Parse(Console.ReadLine());
        string words = NumberToWords(number);
        Console.WriteLine(words);
        Console.ReadKey();
    }
}
