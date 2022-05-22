using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DailyChallenges;

ChallengeRepository scr = new ChallengeRepository();

// string teamOne = "Meatballs";
// string teamTwo = "Thunder Chickens";
// int scoreOne = 7;
// int scoreTwo = 3;
//string answerOne = scr.teams(scoreOne, scoreTwo);

// string phrase = "abcdefghijklmnopqrst";
// string output = scr.spongeBobCaser(phrase); 
//Console.WriteLine(output);

//float kmList = scr.KilometerConverter(miles);

//List<float> miles = new List<float>() { 1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f};

//List<float> kilometers = new List<float>();

//char input = ' ';
//char animal = scr.PrintMainMenu(input);
//scr.PrintMainMenu(input);

// int[] a = {1, 2, 3, 4, 5, 6, 7, 8};
// int sum = scr.Sum(a);
//  decimal average = scr.Average(a);
// Console.WriteLine(average);



// ChallengeRepository _cr = new ChallengeRepository(); (links our program to the repository)
// Create a list of floats that we will be later passing through our Method using a List<float>
// Create the method with access modifier of public and datatype as float, create its parameter with a datatype of float
// Create a new, empty list variable in the body of the method with type float.
// ^ This will capture the floats that will be returned
// We need to figure out the conversion of m to km, which is: distance in km = x miles * 1.609344
// Use a foreach loop that iterates through every item in the list
// Any figures that are under 0.5m/0.8km threshold are not included in the return
// Use a boolean to return measurements > 0.5m/0.8km if true, and do not return them if they are under the threshold
// Within the conditional, convert the values we kept and return those new values in km to the new list instantiated within the method
// Use List Variable += Measurement to add, to add the correct measurement to our list every time the condition is met.
// Pass the list through the method and print to the console



//Create a method with access modifier public and datatype string, create a parameter with a datatype of char in ChallengeRepository.cs called RandomChoice(char x)
// Create a private void method called PrintMainMenu() in Program.cs that will print to console "What do you choose? /n A. /n B. /n C."
//Create another method called GetInputFromUser() in Program.cs that will get input from user, returning a Console.ReadLine(); and convert .toUpper
// Save user input from Console.Readline(); into char userInput variable
//pass a switch case through RandomChoice(char x) with case 'A' returning "alligator", case 'B' returning "biscuit", case 'C' returning "chihuahua", and default returning "spaghetti"
// Initialize the RandomChoice(char x) in in Program.cs by passing userInput through it and printing the result to console

string input = "02/27/1989";
scr.TimeAliveInDays(input);