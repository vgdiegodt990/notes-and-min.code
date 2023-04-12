// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

logicalIfs.branchingIf.basicIf();
logicalIfs.branchingIf.switches();
looping.loops.loopingFor();

//seperatetest.thetest.typetesting();
Console.ReadKey();


namespace logicalIfs
{
    public class branchingIf
    {
        public static void basicIf()
        {
            Console.Write("Please Enter A Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thanks. Now Enter A Letter: ");
#pragma warning disable CS8604 // Possible null reference argument.
            char letter = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            if (num >= 6)
            {
                Console.WriteLine("\nNumber Exceeds 5");
                //Nest statement will be placed here
            }
            else
            {
                Console.WriteLine("\nNumber Is 5 Or Less");
            }
            if (letter == 'C')
            {
                Console.WriteLine("Letter Is 'C'");
            }
            else
            {
                Console.WriteLine("Disgusting letter.\n");
            }
        }

        public static void switches()
        {
            //declared
            int num = 3;
            string day = num switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                _ => "Weekend Day",
            };
            Console.WriteLine("Day " + num + ": " + day + "\n");
        }
    }
}

namespace looping
{
    public class loops {
        public static void loopingFor()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Loop Iteration: " + i);
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("\tInner Loop Iteration " + j);
                }
            }
        }
    }
}


//what I used to find help https://codeasy.net/lesson/input_validation
namespace seperatetest
{
    public class thetest
    {
        public static void typetesting()
        {
            /* FIRST SOLUTION 
            Console.WriteLine("Input your name: ");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty! Input your name again.");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hi, {name}");*/

            /* 2.1 SOLUTION 
            Console.WriteLine("Input your age");
            var ageAsString = Console.ReadLine();
            int age;
            bool parseSuccess = int.TryParse(ageAsString, out age);
            if (parseSuccess)
                Console.WriteLine($"Your age is: {age}");
            else
                Console.WriteLine("This is not a number!");
            */

            /*EXACTLY WHAT I WAS GOING FOR 
            Console.WriteLine("Input your age");
            var ageAsString = Console.ReadLine();

            int age;
            while(!int.TryParse(ageAsString, out age))
            {
                Console.WriteLine("This is not a number!");
                ageAsString = Console.ReadLine();
            }
            Console.WriteLine($"Your age is {age}");
            */
          
            /* practice 
            Console.Write("Please enter a number: ");
            string enterNum = Console.ReadLine();

            int num;
            //out keyword uses num in argument, assigns and checks value - TryParse apart of argument 
            while(!int.TryParse(enterNum, out num))
            {
                Console.WriteLine("That is not a number.");
                enterNum = Console.ReadLine();
            }
            Console.WriteLine($"Your number input was {num}");
            */

        }
    }
}
