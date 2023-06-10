using System;

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

class MainClass {
    public static void Main (string[] args) {
        // Create Vaiable to hold input
        string input;
        // Prompt user for input
        Console.WriteLine("What is your name>");
        // Receive input
        input = Console.ReadLine();
        // Print message
        Console.WriteLine("Hey there " + input);
    }
}