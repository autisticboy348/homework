public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 6 && value <= 100)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine($"Ошибка: возраст {value} некорректен. Возраст должен быть от 6 до 100 лет.");
            }
        }
    }

    public string FullName
    {
        get { return $"{FirstName} {LastName}"; }
    }

    public Student(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public Student() : this("", "", 0)
    {
    }
}