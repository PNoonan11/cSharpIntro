//OPERATORS

//Arith



//ADDITION
int intA = 22;
int intB = 13;
int sum = intA + intB;
sum += 7;
//Console.WriteLine(sum);

//SUBTRACTION
int difference = intA - intB;
difference -= -7;
Console.WriteLine(difference);

//MULTIPLICATION
int product = intA * intB;
product *=2;
Console.WriteLine(product);

int quotent = intA / intB;
Console.WriteLine(quotent); // outcome is 1 because ints can not hold decimal places

//modulus
int remainder = intA % intB;

//DATES
DateTime today = DateTime.Now;
DateTime someOtherDay = new DateTime(1978, 1,1);
TimeSpan timeSpan = today - someOtherDay;
Console.WriteLine(timeSpan); //output 16188.17:55:00.0477515

//comparison Operators
int age = 25;
string userName ="Harry";
bool equals = age == 41; //false
bool isCorrectUserName = userName == "Lloyd"; //false
bool notEqual = age != 30; //checks to see if age is not equal to 30.  - true
bool isNotUser = userName != "Darryl";

bool greaterThan = age > 12;
bool lessThan = age < 98;
bool greaterThanOrEqual = age >= 2345;
bool lessThanOrEqual = age <= 1;

// || OR
// && and
bool trueValue = true;
bool falseValue = false;
bool trueAndFalse = trueValue && falseValue;
bool trueOrTrue = trueValue || falseValue; // true - atleast one is true. 
Console.WriteLine(trueAndFalse); 

int xyz = 10;
int abc = 12;

if (xyz > 9 || abc <14);{
    Console.WriteLine(true);
}


//Conditionals

bool isHungry = true;
if (isHungry){
    Console.WriteLine("Eat Something!");
    }

    if (isHungry && age >= 21){
        Console.WriteLine("Eat something!");
    }


    //IF ELSE STATEMENT

    bool tpsReportsAreFinished = true;

    if(tpsReportsAreFinished){
        Console.WriteLine("You dont have to work on Saturday.");
    }
    else{
        Console.WriteLine("were going to need you to come in on Saturday.");
    }

    //ELSE IF

     

    if(tpsReportsAreFinished){
        Console.WriteLine("You dont have to work on Saturday.");
    }
    else if (age >= 21){
Console.WriteLine("You dont have to come to work on Saturday, have fun on ST. Paddys");
    }
    else{
        Console.WriteLine("were going to need you to come in on Saturday.");
    }



    tpsReportsAreFinished = false;

    bool bossDoesntCare = true;

    if(tpsReportsAreFinished){
        Console.WriteLine("You Dont have to come in.");
    }
    else {
        if (bossDoesntCare){
Console.WriteLine("You Dont have to come in.");
        }
        else {
            Console.WriteLine("You gotta work saturday.");
        }
    }



    // SWITCH CASES
    int input = 1;

switch (input){
    case 1:
        Console.WriteLine("its a ONE.");
            break;
    case 2:
        Console.WriteLine("its a TWO.");
            break;
    case 3:
        Console.WriteLine("its a THREE.");
            break;
    default:
        Console.WriteLine("I dunno?"); //default is the catch all, generally used as error handling. 
            break;
}

//TERNARIES

// bool Variable = conditional ? output_if_true : output_if_false;

age = 35;
bool canDrinkAlcohol = (age >= 21) ? true : false;
string reaction = (age >= 21) ? "horray" : "bummer";