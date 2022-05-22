Methods _key = new Methods();


Console.WriteLine(_key.FullName("Trevor", "Stuart"));

string first = "Taylor";
string last = "Dickens";

string fullName = _key.FullName(last, first);

Console.WriteLine(fullName);

public class Methods
{
//int x = ExplainMethod(3); //Variables must have the same datatype as the methods return type. 
    public void ExplainMethod(int x)
    {
            //Method Body
            Console.WriteLine("Public is the access modifier");
            Console.WriteLine("Void is the Return Type");
            Console.WriteLine("ExplainMethod is the Name");
            Console.WriteLine("int x is the Parameter");
            Console.WriteLine("NAME + PARAMS = SIGNATURE");
    }

    public string FullName(string first, string last)
    {
        return $"{first} {last}";
    }

   
}