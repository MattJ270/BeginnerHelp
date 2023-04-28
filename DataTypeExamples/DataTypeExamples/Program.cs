using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This project will be demostrating different data types
            //Feel free to change them around to see what happens

            //This is a string variable.  A String in C# is actually an object.  This string object contains methods and properties that allows you to perform operations on strings.
            string exampleString = "Hello! ";

            //Since it is an object you can do operations like this.
            Console.WriteLine("This is the length of exampleString: " + exampleString.Length);
            //This is just displaying to the console the length of exampleString.  If you are in visual studio you can hover over 'length' and you get a brief description of it

            string exampleString2 = "How are you?";

            //You can also 'add strings' together. this is called Concatenation
            Console.WriteLine(exampleString + exampleString2);

            //We can also change the casing of strings
            Console.WriteLine(exampleString.ToLower() + exampleString2.ToUpper());

            //There is a lot you can do with even just these three methods but there are many more things you can do with strings

            //Next up will be ints.  Basically ints are whole number values only.  There are different types of ints that hold different sizes.

            int exampleInt = 10;

            //You can do math operations with ints
            //You can not multiply a string value, it is not a whole number.  Delete the '//' below to see the error
            //Console.WriteLine(exampleString * 2); 
            //But with an int value we can do
            Console.WriteLine(exampleInt * 2);
            Console.WriteLine(exampleInt / 2);

            //You can also of course do these operations with other ints like so
            int exampleInt2 = 2;

            Console.WriteLine(exampleInt * exampleInt2);
            Console.WriteLine(exampleInt / exampleInt2);

            //Similar to ints there is also doubles
            double exampleDouble = 3.3;
            //Doubles hold decimal values.  In beginner terms think of them as ints that have a decimal
            //Delete the '//' below to see the error
            //int exampleInt3 = 3.3;

            //You can still do the same math operations with doubles as you can ints
            Console.WriteLine(exampleDouble * 2);

            //Booleans.  Booleans are a TRUE or FALSE variable.
            bool exampleBool = false;

            Console.WriteLine(exampleBool);

            //Bools can be great for checks.  This hasnt covered IF statements but this is an example of how you could use a bool

            if (5 + 5 == 10)
            {
                exampleBool = true;
            }
            if(exampleBool == true)
            {
                Console.WriteLine("5 + 5 does equal 10!");
            }

            //Clearly this will always be true but it shows how bools can be used to trigger a response based off of true or false

            //CHAR. Char is like a string but it is instead a single character. It also has to be surronded by single quotes.
            //This data type could be used for something like LetterGrades.

            char exampleChar = 'a';
            Console.WriteLine(exampleChar);


            //To pause the console from closing till you hit a key
            Console.ReadLine();
        }
    }
}
