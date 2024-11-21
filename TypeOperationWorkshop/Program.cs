namespace TypeOperationWorkshop;

class Program
{
    static void Main(string[] args)
    {
        /*string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int course = int.Parse(Console.ReadLine());
        string group = Console.ReadLine();
        bool hasHomePet = true;
        Console.WriteLine("Анкета студента:");
        Console.WriteLine("ФИО: "+ name);
        Console.WriteLine("Возраст: " + age + " лет");
        Console.WriteLine("Курс: " + course);
        Console.WriteLine("Группа: " + group);
        Console.WriteLine("Домашний питомец: " + hasHomePet);*/
        try
        {
          Console.WriteLine(CalculateOp(10, 5, '-'));
          Console.WriteLine(CalculateOp(10, 5, '+'));
          Console.WriteLine(CalculateOp(10, 5, '*'));
          Console.WriteLine(CalculateOp(10, 5, '^'));
          Console.WriteLine(CalculateOp(13, 3, '/'));
          Console.WriteLine(CalculateOp(10, 5, '&'));
        }
        catch (DivideByZeroException ex)
        {
          Console.WriteLine("Произошла ошибка - нельзя делить на 0!");
        }
        catch (Exception ex)
        {
          Console.WriteLine("Произошла ошибка: " + ex.Message);
        }

    }

    static double CalculateOp(long a, long b, char operand)
    {
        return operand == '+'
          ? a + b
          : operand == '-'
            ? a - b
            : operand == '*'
              ? a * b
              : operand == '/'
                ? (double) a / b
                :
        switch (operand)
        {
            case '+':
              return a + b;
            case '-':
              return a - b;
            case '/':
              return ((double)a / b);
            case '*':
              return (a * b);
            case '^':
              return Math.Pow(a, b);
            default:
              throw new NotSupportedException("operand is not supported!");
        }
    }
}
