
using Cs_class_task.Models;

//task1

//PointClass point1 = new PointClass();
//point1.x = 10;
//point1.y = -5;
//Console.WriteLine(point1.x);
//point1.ShowData();

//------------------------------------------------------------------------------------------------
//task2
//Counter counter1= new Counter(10,20);

//for(int i = 0; i < 10; i++) { counter1.Increment(); }
//counter1.Decrement();

//Console.WriteLine(counter1.GetCurrent());

//------------------------------------------------------------------------------------------------

//task 3

Fraction f1 = new(3, 5);
Fraction f2 = new(3, 4);

//Fraction result=f1.Add(f2);
//Fraction result=f1.Subtract(f2);
//Fraction result=f1.Multiply(f2);
Fraction result=f1.Divide(f2);
result.Simplify();
result.print();