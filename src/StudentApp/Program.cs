namespace StudentApp;

class Program
{
    static void Main(string[] args)
    {
        // Создайте 3 объекта класса Student с разными данными
        Student student1 = new Student(1, "Иван Петров", "Группа А-101", 4.8);
        Student student2 = new Student(2, "Мария Сидорова", "Группа Б-202", 3.9);
        Student student3 = new Student(3, "Алексей Иванов", "Группа А-101", 5.0);

        // Выведите информацию о каждом студенте
        Console.WriteLine("Информация о студентах:");
        
        student1.DisplayInfo();
        student2.DisplayInfo();
        student3.DisplayInfo();

        // Проверьте, кто из них отличник
        Console.WriteLine("\nРезультаты проверки на отличника:");
        Console.WriteLine($"{student1.Name}: {(student1.IsExcellent() ? "Отличник" : "Не отличник")}");
        Console.WriteLine($"{student2.Name}: {(student2.IsExcellent() ? "Отличник" : "Не отличник")}");
        Console.WriteLine($"{student3.Name}: {(student3.IsExcellent() ? "Отличник" : "Не отличник")}");
    }
}