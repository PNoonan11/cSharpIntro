using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyChallenges
{

    public class ChallengeRepository
    {
        //         //01
        //         //Write a method that each complete the following tasks:

        //         //Take in FOUR parameters: 2 strings and 2 ints. The strings being the names of two different soccer teams, and the ints being the teams' scores.

        //         //Method should return a string of either "{teamOne} won." or "{teamTwo} won." or "{teamOne} and {teamTwo} tied".

        //         //Invoke each method in Program.cs and print the returned results to the console.



        //         public string teams(int scoreOne, int scoreTwo, string teamOne, string teamTwo)
        //         {
        //             if (scoreOne < scoreTwo)
        //             {
        //                 Console.WriteLine($"{teamTwo} won!");
        //                 return teamTwo;
        //             }
        //             else if (scoreOne > scoreTwo)
        //             {
        //                 Console.WriteLine($"{teamOne} won!");
        //                 return teamOne;
        //             }
        //             else
        //             {
        //                 Console.WriteLine($"{teamOne} and {teamTwo} tied!");
        //                 return $"{teamOne} and {teamTwo} tied.";
        //             }
        //         }


        //         public string spongeBobCaser(string phrase)
        //         {
        //             string output = "";

        //             foreach (char x in phrase)
        //             {
        //                 if (phrase.IndexOf(x) % 2 == 0)
        //                 {
        //                     output += char.ToUpper(x); //ADDS to the output string
        //                 }
        //                 else
        //                 {
        //                     output += char.ToLower(x);
        //                 }
        //             }
        //             return output;

        //         }

        //         //  public List<float> KilometerConverter(List<float>)
        //         //     {

        //         //       List<float> kilometers = new List<float>() {};
        //         //   foreach (float x in miles)
        //         //       {
        //         //         if (x >= 0.5f)
        //         //         {
        //         //           kilometers.Add(x * 1.6f);
        //         //         }
        //         //       }
        //         //       return miles;


        //         //       float kilometers =  (x * 1.609344f);
        //         // Console.WriteLine(kilometers);

        //         // if(float y in x){
        //         //  kilometers += y * 1.609344f;

        //         // }



        //         public char PrintMainMenu(char x)
        //         {

        //             Console.WriteLine("What do you choose? \n A: \n B: \n C:");

        //             char input = Char.ToLower(Console.ReadKey().KeyChar);


        //             switch (input)
        //             {

        //                 case 'a':
        //                     Console.WriteLine("\n alligator");
        //                     return input;
        //                 case 'b':
        //                     Console.WriteLine("\n biscuit");
        //                     return input;
        //                 case 'c':
        //                     Console.WriteLine("\n chihuahua");
        //                     return input;
        //                 default:
        //                     Console.WriteLine("\n spaghetti");
        //                     return input;
        //             }
        //         }

        //         public int Sum(int[] intArr)
        //         {
        //             int sum = 0;


        //             foreach (int x in intArr)
        //             {
        //                 sum += x;
        //             }
        //             return sum;
        //         }


        //         public decimal Average(int[] intArr)
        //         {
        //             decimal sum = Sum(intArr);
        //             decimal arrayLength = intArr.Length;
        //             decimal average = (decimal)(sum / arrayLength); // CASTING - prevents sum / arrayLength from dropping the decimal 
        //             return average;
        //         }


        //         public decimal Average(int[] intArr, int max, int min)
        //         {
        //             decimal sum = 0;
        //             decimal arrayLength = 0;

        //             foreach (int x in intArr)
        //             {
        //                 if (x <= max && x >= min)
        //                 {
        //                     sum += x;
        //                     arrayLength++;
        //                 }
        //             }
        //             Console.WriteLine(sum / arrayLength);
        //             return sum / arrayLength;
        //         }
        // //         1. McDonald's hires you to create their new menu app. Create a Class object for a McDonald's value meal.
        // // 2. Write a method that takes in your birthday and returns how many days you have been alive.
        // // 3. Write a method that takes in a list of integers, and then returns a dictionary with three key/value pairs that represent the mean, median, and mode.You can write multiple methods to help out.
        // public class Menu
        // {
        // public string NameofMeal { get; set; }
        // public bool ComesWithDrink { get; set; }
        // public decimal Price { get; set; }
        // public string[] Toppings { get; set; }

        // public Menu(string nameOfMeal, bool comesWithDrink, decimal price, string[] toppings)
        // {
        // NameofMeal = nameOfMeal;
        // ComesWithDrink = comesWithDrink;
        // Price = price;
        // Toppings = toppings;
        // }
        // public Menu() {}
        // }
        //  public void SeedMenuData()
        //  {
        //   Menu valueMeal = new Menu("Value Meal", true, 3.43m, valueMealToppings);
        //  }
        //      string[] valueMealToppings = {"cheese", "onion", "pickle", "ketchup"};


        // DAYS ALIVE
        public void TimeAliveInDays(string inputBirthday)
        {
            DateTime userBdConverted = Convert.ToDateTime(inputBirthday);

            TimeSpan userAge = DateTime.Now.Subtract(userBdConverted);

            Console.WriteLine("You are " + userAge.TotalDays + " days old!");
        }





        public Dictionary<string, decimal> MeanMedianAndMode(List<int> nums)
        {

            //new dictionary to return
            Dictionary<string, decimal> meanMedianModeDictionary = new Dictionary<string, decimal>();



            //sort intlist
            intList.Sort();

            //variables of int mean/median/mode
            decimal mean = Mean(intList);
            decimal median = Median(intList);
            decimal mode = Mode(intList);
            //calculate mean, median, mode

            // add mean, median, mode to my dictionary with keys(string)
            meanMedianModeDictionary.Add("mean", mean);
            meanMedianModeDictionary.Add("median", median);
            meanMedianModeDictionary.Add("mode", mode);

            return meanMedianModeDictionary;


        }

        private decimal Mean(List<int> intList)
        {

            decimal mean = intList.Count > 0 ? (decimal)(intList.Average()) : 0.0m;
            return mean;
        }
        private decimal Median(List<int> intList)
        {
            intList.Sort();

            decimal median;
            if (intList.Count % 2 != 0)
            {
                //odd
                int x = intList[((intList.Count / 2))];
            }
            else
            {
                //EVEN
                int x = intList[((intList.Count / 2))];
                int y = intList[((intList.Count / 2)) - 1];
                median = (x + y) / 2;
            }
            return median;
        }
        private decimal Mode(List<int> intList)
        {
            int mode = intList.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;

            return mode;
        }

        List<int> intList = new List<int>() { 5, 7, 1, 9, 2, 8, 4, 8 };
        Dictionary<string, decimal> _dict = MeanMedianAndMode(intList);



        Console.WriteLine("MEAN = " + _dict["mean"]);
    }
}


















