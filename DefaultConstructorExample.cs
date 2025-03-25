using System;
// System-Defined Implicit Default Constructor in C#
class Employee1{
    public int Id;
    public string name;
    public bool isParmanent;
}

//User-defined Default Constructor in C#
class Employee2{
    public int Id;
    public string name;
    public bool isParmanent;

    public Employee2(){
        Id = 101;
        name = "Varsha";
        isParmanent = true;
    }
    public void Display(){
        Console.WriteLine("Employee Id: " + Id);
        Console.WriteLine("Employee name: " + name);
        Console.WriteLine("Employee isParmanent: " + isParmanent);
    }
}

class DefaultConstructor{
    static void Main(){

        Employee1 obj = new Employee1();
        Console.WriteLine("Employee Id: " + obj.Id);
        Console.WriteLine("Employee Name: " + obj.name);
        Console.WriteLine("Employee isParmanent: " + obj.isParmanent);


        Employee2 obj2 = new Employee2();
        obj2.Display();
        
    }
}
