using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Variables;
using UserInputs;
using Conv;
using Array;
using Casting;
using Constants; 

//Initial Start

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VarTest.Second();
            UserData.Inputs();
            Conversion.Converting();
            TestArray.NumArray();
            TestCasting.ImpExp();
            ConstantTest.ConstEnum(); 
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }
    }
}

//Variables 

namespace Variables
{
    public class VarTest
    {
        public static void Second()
        {
            Console.Title = "Variables";
            //Declaring then initializing
            char letter; letter = 'A';
            int number; number = 100;
            float body = 98.6f;
            double pi = 3.14159;
            decimal sum = 1000.00m;
            bool flag = false;
            string text = "C# Is... Interesting";
            //In use
            Console.WriteLine("char letter:\t" + letter);
            Console.WriteLine("int number:\t" + number);
            Console.WriteLine("float body:\t" + body);
            Console.WriteLine("double pi:\t" + pi);
            Console.WriteLine("decimal sum:\t" + sum);
            Console.WriteLine("bool flag:\t" + flag);
            Console.WriteLine("string text:\t" + text);
        }
    }
} 
 
namespace UserInputs
{
#pragma warning disable CS8600
    public class UserData
    {
        public static void Inputs()
        {
            Console.Title = "Test to see if this'll override";
            Console.Write("Please Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "!");
        }
    }
#pragma warning restore CS8600
} 

namespace Conv
{
    public class Conversion
    {
        public static void Converting()
        {
            Console.Write("Please Enter A Number:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Now Enter Another Number:");
            double sum =
                num + Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total = " + sum);
        }
    }
}

namespace Array
{
    public class TestArray
    {
        public static void NumArray()
        {
            string[] cars = new string[3]
                { "BMW", "Ford", "Opel" };
            int[,] coords = new int[2, 3]
                { {1,2,3},{4,5,6} };
            Console.WriteLine("Second Car: " + cars[1]);
            Console.WriteLine("X1, XY2: " + coords[0, 0]);
            Console.WriteLine("X2, Y3: " + coords[1, 2]);
        }
    }
}

namespace Casting
{
    public class TestCasting
    {
        public static void ImpExp()
        {
            double impsum = (double)7 / 2; //Stores accurate floating-point results b/c cast into suitable data type 
            double nomsum = 7 / 2; //Not casted in suitable data type thus does not store accurate floating-point 
            // the 7/2 is a truncated integer, needs to be cast as a double, implicit 
            Console.WriteLine(impsum + " || Accurate floating point, was casted");
            Console.WriteLine(nomsum + " || Non-accurate floating point, was NOT casted");
            //Testing operator casting precendence 
            double prenum = (double)7 / 2.5; //2.5 is seen w/ it's floating point
            Console.WriteLine(prenum + " || Testing operator precendence");
            //int prenum = (int)7/2.5 would not work b/c the 2.5 int does not support floating points 
            //more exaples
            double num = 10.5;
            int integer = 2;
            //implicity casting the integer value into a double-precision value
            num = num + integer;
            Console.WriteLine("Implicit Cast: " + num);
            num = (double)7 / integer;
            //explicitly casting the result of an integer division into a double-precision value 
            Console.WriteLine("Explicit Cast: " + num);
            char letter = (char)65;
            //casting integer value into a char data type to display the ASCII equivalent character
            Console.WriteLine("Cast Integer: " + letter);
            int ascii = (int)'A';
            Console.WriteLine("Cast Letter: " + ascii);
            char symbol = (char)102;
            Console.WriteLine("Cast Symol " + symbol);
        }
    }
}

namespace Constants
{
    public static class ConstantTest
    {
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        public static void ConstEnum()
        {
            const double pi = 3.14158265358969;
            var daysType = typeof(Days);
            //revealing constant's data type and output value
            Console.WriteLine("Pi Type: " + pi.GetType() );
            Console.WriteLine("Circumference " + (pi * 3 ) );
            //adding statements to display the name and index position of the first item in the enumerator list 
            Console.WriteLine("\nFirst Name: " + Days.Sat);
            Console.WriteLine("1st Index " + (int)Days.Sat);
            //statements to display the name at the second index position and querying the enumerator list 
            string name = Enum.GetName(daysType, 1);
            Console.WriteLine("\n2nd Index: " + name);
            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("Contains Mon?: " + flag);
        }
        
    }
}