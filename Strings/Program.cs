namespace Strings;

class Program
{
  //число - палидром ли до 4 знаков
    static void Main(string[] args)
    {
        //Console.WriteLine(GetUniqueSymbols("Hello", "Any", "People"));
        //Console.WriteLine(CheckPalidrome(int.Parse(args[0])));
        //Console.WriteLine(ReverseWords("hello world i love you!!"));
        Console.WriteLine(GetYearsForAge(int.Parse(args[0])));
    }

    static bool CheckPalidrome(int n)
    {
        int rightNumber = n % 10 * 10 + (n / 100 % 10);
        int leftNumber = ((n / 100) % 10) + (n / 1000) * 10;
        if (rightNumber == leftNumber)
          return true;
        else if (n > 9999 || n < 1)
          throw new ArgumentException();
        else
          return false;
    }

    static bool CheckSymbol(char symbol, string str1, string str2)
    {
        return (!str2.Contains(symbol) && !str1.Contains(symbol));
    }

    static int isLetterInWord(char letter, string word)
    {
        return word.Contains(letter) ? 1 : 0;
    }

    static string GetUniqueSymbols(string str1, string str2, string str3)
    {
        string result = "";
        string s = $"{str1}{str2}{str3}";
        foreach (var symbol in s)
        {
            if (isLetterInWord(symbol, str1) +
                isLetterInWord(symbol, str2) +
                isLetterInWord(symbol, str3) == 1)
                result += symbol;
        }
        return result;

        /*foreach (var ch in str1)
        {
             if (CheckSymbol(ch, str2, str3))
              result += ch;
        }
        foreach (var ch in str2)
        {
            if (CheckSymbol(ch, str1, str3))
              result += ch;
        }
        foreach (var ch in str3)
        {
            if (CheckSymbol(ch, str1, str2))
              result += ch;
        }
        return result;*/
    }

    static string ReverseWords(string text)
    {
        string[] words = text.Split();
        if (words.Length < 2)
          throw new ArgumentException("Неподходящая строка");
        string result = $"{words[words.Length - 1]} ";
        for (int i = 1; i < words.Length - 1; i++)
        {
            result += $"{words[i]} ";
        }
        result += words[0];
        return result;
    }
    /*
    Дано натуральное n (n <= 100),
    определяющее возраст человека (в годах).
    Дать для этого числа наименования «год», «года» или «лет»:
    например, 1 год, 23 года, 45 лет и т. д. (метод ConvertAgeInFullName,
    в случае неправильного числа выбросить ошибку ArgumentException)
    1 -> год
    2 -> года
    3 -> года
    4 -> года
    5 6 7 8 9 0 -> лет


    */

    static string GetYearsForAge (int n)
    {
        if (n > 100 || n < 0)
          throw new ArgumentException("Неправильный возраст");
        return n % 10 == 1 ? "год" :
                            (n % 10 <= 4 && n % 10 >= 2) ? "года" :
                                                          "лет";

    }
}
