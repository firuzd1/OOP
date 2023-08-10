namespace DataAbstraction;
/*В данном случае, класс "Tesla" и "Opel" 
являются производными от базового класса 
"vehicle". Класс "Tesla" и "Opel" также имеют 
дополнительное свойство "Engine и ElectroEngine", 
которое отсутствует в базовом классе.*/
class Vehicle //Абстрактный класс
{
    public string Brand{ get; set; }
    public string Model{ get; set; }
}

class Tesla : Vehicle //объявление производного класса "Tesla", который наследует свойства и методы базового класса "vehicle".
{
    public string ElectroEngine{ get; set; } // дополнительное свойство которое присуще в тесле, но не в Opel
}

class Opel : Vehicle //объявление производного класса "Opel", который наследует свойства и методы базового класса "vehicle".
{
    public string Transmission{ get; set; } // дополнительное свойство которое присуще в Opel, но не в Tesla
}