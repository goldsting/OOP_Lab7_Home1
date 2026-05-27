namespace StudentApp;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(1, "Иван Петров", "Группа А-101", 4.8);
        Student student2 = new Student(2, "Мария Сидорова", "Группа Б-202", 3.9);
        Student student3 = new Student(3, "Алексей Иванов", "Группа А-101", 5.0);

        Console.WriteLine("Информация о студентах:");
        student1.DisplayInfo();
        student2.DisplayInfo();
        student3.DisplayInfo();

        Console.WriteLine("\nОбновление средних баллов:");
        student2.UpdateGrade(4.7);
        
        Console.WriteLine("\nОбновлённая информация:");
        student2.DisplayInfo();
        

        Console.WriteLine($"\n{student2.Name} теперь {(student2.IsExcellent() ? "отличник" : "не отличник")}");
    }
}