namespace TypeOperationWorkshop;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int course = int.Parse(Console.ReadLine());
        string group = Console.ReadLine();
        bool hasHomePet = true;
        Console.WriteLine("Анкета студента:");
        Console.WriteLine("ФИО: "+ name);
        Console.WriteLine("Возраст: " + age + " лет");
        Console.WriteLine("Курс: " + course);
        Console.WriteLine("Группа: " + group);
        Console.WriteLine("Домашний питомец: " + hasHomePet);
    }
}
