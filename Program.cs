using DataAbstraction;
using Encapsulation;
using inheritance;
using Polymorphism;

//Абстракция
Tesla tesla = new();
tesla.Brand = "Tesla";
tesla.Model = "model X";
tesla.ElectroEngine = "electro";


//Инкапсуляция
Person pers = new();
pers.ValuesForPerson("Firuz", 26);

//Наследование
Dog dog = new();
dog.Bark();// Метод Bark() определён в классе Dog
dog.Eat();//Метод Eat() унаследован от класса Animal

//Полиморфизм
MyDog myDog = new();
Cow cow = new();
myDog.MakeSound();
cow.MakeSound();
