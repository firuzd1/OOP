namespace Encapsulation;

// Пользователь передаёт данные через метод, но детали реализации скрыты от него

class Person
{
    //Переменные которые доступны только в классе
    private string? _name; 
    private int _age;

    public string Name 
    {
        get => _name;
        set => _name = value ?? string.Empty;
    }
    public int Age
    {
        get => _age;
        set => _age = value;
    }
    public void ValuesForPerson(string name, int age) //Данный метод единственное с чем взаимодействует пользователь
    {
        Name = name;
        Age = age;
    }
}