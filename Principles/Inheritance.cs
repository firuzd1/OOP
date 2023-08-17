 namespace inheritance;

/*В этом примере класс Dog наследуется от базового класса Animal.
Класс Dog получает все методы и свойства, определённые в классе Animal.
Так же в файле DataAbstraction показаны примеры наследования*/
 class Animal
 {
    public void Eat()
    {
        System.Console.WriteLine("Животное ест");
    }
 }
 class Dog : Animal
    {
        public void Bark()
        {
            System.Console.WriteLine("Собака лает");
        }
    }