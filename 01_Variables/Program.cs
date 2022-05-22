// VALUE TYPES
// Value types are stored in the  STACK.

//BOOLS AND CHARS

bool isDeclared; //Declaring a variable and not assigning a value. 
isDeclared =  true; //assigning a value to an existing value. 

bool isDeclaredAndInitilized = true;
 char character = 'a'; //Single quotes for chars in c#. strings use double quotes. 
 char symbol = '?';
 char number = '7';
 char space = ' ';
 char specialCharacter = '\n'; //NEW LINE CHARACTER - \n breaks a line in the console. 


//WHOLE NUMBERS - bytes, shorts, ints, longs. 


byte age = 89; //BYTES can not be negative - max out at 255.
sbyte negativeAge = -20; //only way to use a negative byte. -128 - 127 number range. 
int someNumber = 12; //No quotes or suffixes for WHOLE NUMBERS.
int max = 2147483647; //biggest number you can use INT for. 
uint unsignedInt = 28; //int without a sign.  + or -

short shortExample = 3245;
long bigWholeNumber = 9223372036854775807; //largest number for long.




//FLOATING POINT NUMBERS - numbers that are not whole(decimal). floats, doubles, decimals.
//FLOATING POINT NUMBERS use suffixes.

float floatExample = 1.0457896f; //f
double doubleExample = 8.234234234234d;//d
decimal decimalExample = 2.4564745m;//m

float x = 1.123456789123456789123456789123456789123456789f; //OUTPUT 7 decimal places - 1.1234568
double y = 1.123456789123456789123456789123456789123456789d; //OUTPUT 17 decimal places - 1.1234567891234568
decimal z = 1.123456789123456789123456789123456789123456789m;//OUTPUT 28 decimal places - 1.1234567891234567891234567891

// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

//enum PastryType {cake, cupcake, eclaire, croissant};

//DATE VALUE TYPES

//DateTime today = DateTime.Today(); //must be in a namespace to work
// DateTimeOffSet today = DateTimeOffset.Today;




// REFERENCE TYPES - Reference Types are stored on the HEAP.

string firstName = "Bob";
string lastName = "Darryl";

string concatFullName = firstName + " " + lastName;
string compositeFullName = string.Format("Hi my name is {0} {1}", firstName, lastName);
string interpolFullName = $"{firstName} {lastName}";

Console.WriteLine(concatFullName);
Console.WriteLine(compositeFullName);
Console.WriteLine(interpolFullName);

string[] stringArray = { "hello", "world", "!"};
Console.WriteLine(stringArray[1]);

//LISTS

List<string> listOfStrings = new List<string>();
listOfStrings.Add("dog");
listOfStrings.Remove("dog");

List<int> listOfInts = new List<int>();

// QUEUES AND DICTIONARIES 
Queue<string> firstInFirstOut = new Queue<string>();

Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
keyAndValue.Add(7,"Agent");
keyAndValue.Add(17,"Spaghetti");

Console.WriteLine(keyAndValue[7]); //OUTPUT agent.   Pulls which ever line has an INT of 7 in it. 