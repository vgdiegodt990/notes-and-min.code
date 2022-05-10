// See https://aka.ms/new-console-template for more information
/* Testing new format 
Console.WriteLine("Hello, World!");
string newFormat = "Testing the new format.";
Console.WriteLine(newFormat);
Testing.ContinualTest.FirstTest(); 
Console.ReadKey(); 

namespace Testing
{
    public class ContinualTest
    {
        public static void FirstTest()
        {
            string namesTest = "Testing if namespaces work.";
            Console.WriteLine(namesTest); 
        }
    }
} */

Console.WriteLine("Starting line.");
Arithmetic.Basics.ArithExamples();
Arithmetic.Basics.AssignValues();
Arithmetic.Basics.CompValues();
Arithmetic.Basics.AssessLogic();
Arithmetic.Basics.TernaryOp();
Arithmetic.Basics.OpPrecedence();
//Arithmetic.Basics.minorTest();
Console.ReadKey();

namespace Arithmetic
{
    public class Basics
    {
        public static void ArithExamples()
        {
            int a = 8;
            int b = 4;
            Console.WriteLine("Addition:\t " + (a + b));
            Console.WriteLine("Subtraction:\t " + (a - b));
            Console.WriteLine("Multiplication:\t " + (a * b));
            Console.WriteLine("Division:\t " + (a / b));
            Console.WriteLine("Modulus:\t " + (a % b));

            //Postfix Result
            Console.WriteLine("\nPostfix:\t " + (a++));
            Console.WriteLine("Postfix Result:\t " + a);

            //Prefix Result  
            Console.WriteLine("\nPrefix:\t " + (++b));
            Console.WriteLine("Prefix Result:\t " + b);
        }
        
        public static void AssignValues()
        {
            //Declaring then assigning 
            int a, b;
            Console.Write("Assign Values: ");
            Console.Write("\t a = " + (a = 8));
            Console.WriteLine("\t b = " + (b = 4));
            //Adding statements 
            Console.Write("\n\nAdd and Assign: ");
            Console.Write("\t a += b (8 += 4)\t a = " + (a += b));

            Console.Write("\nSubtract and Assign: ");
            Console.Write("\t a-= b (8 -= 4)\t\t a = " + (a -= b));

            Console.Write("\n\nMultiply and Assign: ");
            Console.Write("\t a *= b (8 *= 4)\t a = " + (a *= b));

            Console.Write("\n\nDivide and Assign: ");
            Console.Write("\t a /= b (8 /= 4)\t a = " + (a /= b));

            Console.Write("\n\nModulus and Assign: ");
            Console.Write("\t a %= b (8 %= b)\t a = " + (a %= b));
        }

        public static void CompValues()
        {
            //Declaring
            int nil = 0, num = 0, max = 1;
            char cap = 'A', low = 'a';
            //Equality comparison statements 
            Console.Write("\n\nEquality");
            Console.Write("\n(0 == 0): " + (nil == num));
            Console.Write("\n(A == a): " + (cap == low));
            //Other integer comparisons 
            Console.Write("\nInequality:");
            Console.Write("\t(0 != 1):" + (nil != max));

            Console.Write("\nGreater:");
            Console.Write("\t(0 > 1): " + (nil > max));

            Console.Write("\nLess: ");
            Console.Write("\t\t(0 < 1): " + (nil < max));

            Console.Write("\nGreater/Equal: ");
            Console.Write("\t(0 >= 0): " + (nil >= num));

            Console.Write("\nLess or Equal: ");
            Console.Write("\t(1 <= 0): " + (max <= nil));
        }

        public static void AssessLogic()
        {
            //Declare
            bool yes = true, no = false;
            //AND Logic
            Console.Write("\n\n\tAND Logic:");
            Console.Write("\n\t(yes && yes): " + (yes && yes)); //Expected: True
            Console.Write("\n\t(yes && no): " + (yes && no)); //False
            Console.Write("\n\t(no && no): " + (no && no)); //False

            //OR Logic
            Console.Write("\n\t(yes || yes): " + (yes || yes)); //True
            Console.Write("\n\t(yes || no): " + (yes || no)); //True
            Console.Write("\n\t(no || no): " + (no || no)); //False

            //NOT Logic 
            Console.Write("\n\t yes = " + yes); //true
            Console.Write("\n\t yes != " + !yes); //false
            Console.Write("\n\t no = " + no); //false
            Console.Write("\n\t no != " + !no); //true
        }

        public static void TernaryOp()
        {
            int a = 8, b = 3;
            string verb = (a != 1) ? " are " : " is ";
            Console.Write("\n\nThere" + verb + a + ".\n");

            string parity = (a % 2 != 0) ? "Odd" : "Even";
            Console.Write(a + " is " + parity + ".\n");
            parity = (b % 2 != 0) ? "Odd" : "Even";
            Console.Write(b + " is " + parity + ".\n");

            int max = (a > b) ? a : b;
            Console.Write("Maximum is " + max + ".");
        }

        public static void OpPrecedence()
        {
            int sum;
            sum = 1 + 4 * 3;
            Console.Write("\n\nDefault Order:\t\t" + sum); //15 (wrong, was 13 b/c of * multiplication operator precedence) 
            sum = (1 + 4) * 3; 
            Console.Write("\nForced Order:\t\t" + sum); //15
            sum = 7 - 4 + 2;
            Console.Write("\nDefault Direction:\t" + sum); //5
            sum = 7 - (4 + 2);
            Console.Write("\nForced Direction:\t" + sum); //1
        }

        /*
        public static void minorTest()
        {
            int sum = 1;
            Console.WriteLine(sum);
            int sum = 2; //already defined, test done -- was testing difference between defining off the bat vs previous excercise which declared int then used it as a shell
            Console.WriteLine(sum);
        }
        */
    }
}
