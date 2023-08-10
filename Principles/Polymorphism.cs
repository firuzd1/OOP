namespace Polymorphism;
/*В этом примере у нас есть базовый класс Animal c виртуальным методом MakeSound().
Классы MyDog и Cow переопределяют этот метод, представляя собственную реализацию*/
class Animal
{
    public virtual void MakeSound()//Виртуальный метод
    {
        System.Console.WriteLine("The animal makes a sound");
    }
}

class MyDog : Animal
{
    public override void MakeSound()//Переопределение метода
    {
        System.Console.WriteLine("Bark");
    }
}
class Cow : Animal
{
    public override void MakeSound()//Переопределение метода
    {
        System.Console.WriteLine("MUUUUU");
    }
}