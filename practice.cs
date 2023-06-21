using System;
using System.Collections;

//////////////////////////////
// -- CREATING VARIABLES -- //

// class MainClass {
//     // CREATING A CONSTANT VARIABLE
//     public const int MY_CONSTANT = 1;

//     public static void Main (string[] args) {
//         // CREATING A STRING VARIABLE
//         string myVariable = "Hello World";
//         // SIMILAR TO CONSOLE.LOG
//         Console.WriteLine(myVariable + " " + MY_CONSTANT);
//     }
// }

// RECEIVING INPUT

// class MainClass {
//     public static void Main (string[] args) {
//         // Create Vaiable to hold input
//         string input;
//         // Prompt user for input
//         Console.WriteLine("What is your name>");
//         // Receive input
//         input = Console.ReadLine();
//         // Print message
//         Console.WriteLine("Hey there " + input);
//     }
// }

////////////////////////
// -- CONDITIONALS -- //

// if statements
// class MainClass {
//     public static void Main (string[] args) {
//         int num = 5;

//         if (num > 3) {
//             Console.WriteLine("num is greater than 3");
//         } else if (num > 1) {
//             Console.WriteLine("num is greater than 1");
//         } else {
//             Console.WriteLine("num is 1 or less");
//         }
//     }
// }

///////////////////////
// -- WHILE LOOPS -- //

// class MainClass {
//     public static void Main (string[] args) {
//         int counter = 0;

//         //this will loop 10 times
//         while(counter < 10) {
//             Console.WriteLine(counter);
//             counter += 1;

//             if (counter % 2 == 0) {
//                 Console.WriteLine("It's even");
//             } else if (counter % 3 == 0) {
//                 Console.WriteLine("meow");
//             } else {
//                 Console.WriteLine(counter);
//             }
//         }
//     }
// }
///////////////////////
// -- Collections -- //
class MainClass {
    public static void Main (string[] args) {

        // Create a new ArrayList
        ArrayList my_list = new ArrayList();

        //Add Elements to Array List
        my_list.Add(1);
        my_list.Add(2);
        my_list.Add(3);

        // Printing the whole list, just shows the object type
        Console.WriteLine(my_list);
        // Printing an individual item
        Console.WriteLine(my_list[0]);

        //Create a new Hashtable
        Hashtable my_hashtable = new Hashtable();

        //Add properties to Hashtable
        my_hashtable.Add("cheese", "gouda");
        my_hashtable.Add("bread", "rye");

        // Printing the whole hashtable
        Console.WriteLine(my_hashtable);
        // accessing one value from the hashtable
        Console.WriteLine(my_hashtable["cheese"]);
        Console.WriteLine(my_hashtable["bread"]);
    }
}