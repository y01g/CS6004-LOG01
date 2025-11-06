// task 1

using System.Reflection.Metadata;

class Program
{

    public static void Main()
    {   
        // task 1
        // declaring a variable named userName to store name and initialize
        string userName = "Chiran Rai";
        // declaring a variable named luckyNumber to store an integer and initialize it to your favorite single-digit number.
        int luckyNumber = 0;
        // string interpolation to print a single line of output to the console
        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

        //----------------------------------------------------------------------------------------------------

        // task 2
        // const value cannot be changed
        const double Pi = 3.14;
        double radius = 4;
        double area = Pi * radius * radius;
        double perimeter = 2 * Pi * radius;

        Console.WriteLine($"Area: {getArea(Pi, radius)}");
        Console.WriteLine($"Perimeter: {getPerimeter(Pi, radius)}");

        //----------------------------------------------------------------------------------------------------

        // task 3
        byte byteValue = 11;
        short shortValue = 22;
        int intValue = 33;
        long longValue = 44;
        float floatValue = 5.5f;
        double doubleValue = 6.6;
        decimal decimalValue = 7.7m;
        char charValue = 'A';
        bool boolValue = true;

        // convert integer 42 to string
        int number = 42;
        string numberAsString = number.ToString();

        // convert string "3.14" to double
        string strValue = "3.14";
        double convertedDouble = Convert.ToDouble(strValue);

        // print all variables
        Console.WriteLine($"byte: {byteValue})");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");
        Console.WriteLine($"Converted int to string: {numberAsString}");
        Console.WriteLine($"Converted string to double: {convertedDouble}");

        //----------------------------------------------------------------------------------------------------

        // task 4
        // create a single-dimensional integer array containing 5 favorite numbers
        int[] singleArray = { 7, 51, 13, 99, 21 };

        // sort the array in ascending order
        Array.Sort(singleArray);

        // reverse the sorted array (so it becomes descending)
        Array.Reverse(singleArray);

        // print each element using a for loop
        for (int i = 0; i < singleArray.Length; i++)
        {
            Console.WriteLine($"Index {i}: {singleArray[i]}");
        }

        // use Array.IndexOf() to find the position of a specific number
        int searchNumber = 99;
        int numberPosition = Array.IndexOf(singleArray, searchNumber);
        Console.WriteLine($"The position of {searchNumber} is {numberPosition}.");

        //----------------------------------------------------------------------------------------------------

        // task 5
        // create a DateTime variable representing your birthdate
        DateTime birthDate = new DateTime(1990, 1, 11);

        // create another DateTime variable representing the current date and time
        DateTime currentDate = DateTime.Now;

        // calculate your age using TimeSpan
        TimeSpan ageSpan = currentDate - birthDate;
        double ageInYears = ageSpan.TotalDays / 365.25;

        // print birthdate, current date, and age in years
        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Age: {(int)ageInYears} years");

        // add 10 days to your birthdate and print the result
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");

        //----------------------------------------------------------------------------------------------------

        // task 6
        // create a List<string> containing 3 favorite fruits
        List<string> fruits = new List<string> { "Watermelon", "Mango", "Banana" };

        // add a new fruit to the list
        fruits.Add("Orange");

        // remove one fruit from the list
        fruits.Remove("Banana");

        // print all fruits using a foreach loop
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(); // blank line for spacing

        // create a Dictionary<int, string> for fruit IDs and names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Orange" }
        };

        // add a new entry to the dictionary
        fruitDictionary.Add(4, "Litchi");

        // print all key-value pairs
        foreach (KeyValuePair<int, string> pair in fruitDictionary)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
        }
    }

    // method to get the area of a circle
    public static double getArea(double Pi, double radius)
    {

        return Pi * radius * radius;
    }
    
    // method to get the perimeter of a circle

    public static double getPerimeter(double Pi, double radius)
    {

        return 2 * Pi * radius;
    }

}

    
            

