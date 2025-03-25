using System;
class GradeCalculator{
    static void Main(){
        Console.WriteLine("Enter Your marks(1-100): ");
        int marks = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(marks.GetType()); //System.Int32

        if(marks >= 90){
            Console.WriteLine("A Grade");
        }
        else if(marks >= 75){
            Console.WriteLine("B Grade");
        }
        else if(marks >= 50){
            Console.WriteLine("C Grade");
        }
        else if(marks >= 33){
            Console.WriteLine("D Grade");
        }
        else{
            Console.WriteLine("Fail");
        }
    }
}
