using System;
class Car{
    public string Compnay;
    public string Model;
    public int Year;

    public Car(string c, string m, int y)
    {
        Compnay = c;
        Model = m;
        Year = y;
    }
    public Car(Car car){
        Compnay = car.Compnay;
        Model = car.Model;
        Year = car.Year;
    }
    public void Display(){
        Console.WriteLine(Compnay);
        Console.WriteLine(Model);
        Console.WriteLine(Year);
    }
}
class CopyConstructor{

    static void Main(){
        Car obj = new Car("Suzuki","Maruti Suzuki Alto", 1979);
        obj.Display();

        Car obj1 = new Car(obj);
        obj1.Display();
    }
}

