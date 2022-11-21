// C# program to illustrate the
// Lambda Expression

//Lambda expressions can also be used with user-defined classes.
//The code given below shows how to sort through a list
//based on an attribute of the class that the list is defined upon.

using System;
using System.Collections.Generic;
using System.Linq;

// User defined class Student
class Student
{

    // properties rollNo and name
    public int rollNo {
        get;
        set;
    }

    public string name {
        get;
        set;
    }
}

class GFG
{

    // Main Method
    static void Main(string[] args) {
        // List with each element of type Student
        List<Student> details = new List<Student>() {
            new Student{ rollNo = 1, name = "Prajwal" },
                new Student{ rollNo = 2, name = "Vaibhav" },
                new Student{ rollNo = 3, name = "Shreyas" },
                new Student{ rollNo = 4, name = "Hiamgirish" },
                new Student { rollNo = 5, name = "Avi" }
        };

        //‘=>’ is the lambda operator which is used in all lambda expressions.
        //The Lambda expression is divided into two parts, 
        //the left side is the input and the right is the expression.
        // To sort the details list
        // based on name of student
        // in ascending order

        var newDetails = details.OrderBy(x => x.name);

        foreach (var value in newDetails) {
            Console.WriteLine(value.rollNo + " " + value.name);
        }
    }
}

