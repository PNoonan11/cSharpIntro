//using Internal;
using System;
// LOOPS

// TYPES OF LOOPS: FOR, FOREACH, WHILE, DO-WHILE

//WHILE

int total = 1;

// while (total != 8){ //while loops condition must be able to evaluate to TRUE or FALSE.
//     Console.WriteLine("Just keep swimming....");
//     Console.ReadKey(); 
//     total += 1; 
// }

bool isRunning = true;

total = 1;
while (isRunning){
    System.Console.WriteLine("Just keep swimming");
    if (total == 4){
        isRunning = false;
    }

    total++;
}

// DO WHILE - will always excute at least once.  WHILE loop does not have to execute.  

int iterator = 0;

do{
    System.Console.WriteLine("Hello World!");
    iterator++;
}
while (iterator < -1);

// FOR LOOP

total = 10;

for (int i = 0; i < total; i++){ // i is a new variable, i < total is the condition to be checked, i++ adds one to each I after the loop is ran. 
    Console.WriteLine("Another one - DJ Khaled");
}

string[] students = { "Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry" };

for (int i = 0; i < students.Length; i++){
    System.Console.WriteLine($"Welcome to EFA, {students[i]}");
}

List<string> roster = new List<string>() { "Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry" };
for (int i = 0; i < roster.Count(); i++){
    System.Console.WriteLine($"Welcome to EFA, {roster[i]}");}

    //FOREACH LOOP

    foreach (string name in roster){
        foreach (char x in name){
            Console.Write(char.ToUpper(x));
        }
            Console.Write("\n");
    }

    