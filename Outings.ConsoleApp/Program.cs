﻿
// Komodo accountants need a list of all outings, the cost of all outings combined, and the cost of all types of outings combined.

// Here are the parts of an outing:
// Event Type:   Golf, Bowling, Amusement Park, Concert
// Number of people that attended
// Date
// Total cost per person for the event
// Total cost for the event


// Here's what they'd like:
// Display a list of all outings.
// Add individual outings to a list(don't need to worry about delete yet)
// Calculations:
// They 'd like to see a display for the combined cost for all outings.
// They 'd like to see a display of outing costs by type.
// For example, all bowling outings for the year were $2000.00. All Concert outings cost $5000.00.
using Outings.ConsoleApp;
Console.WriteLine("1. ENGLISH\n" +
                "2. ESPANOL\n");

string input = Console.ReadLine();

ICustomConsole console;

switch (input)
{
    case "1":
        console = new CustomConsole();
        break;
    case "2":
        console = new CustomConsoleSpanish();
        break;
    default:
        console = new CustomConsole();
        break;
}


UserInterface _ui = new UserInterface(console);

_ui.Run();
