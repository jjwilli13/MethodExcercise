using System;

namespace MethodExcercise // Note: actual namespace depends on the project name.
{
    internal class Program



    {
       
        static void Main(string[] args)
        {
            //Exercise 1----------------
            MadLib();
            Console.ReadLine();

            //Excercise 2---------------

            Console.WriteLine(Addition(183, 268));

            Console.WriteLine(Muliply(4, 6, 9));

            Console.WriteLine(Subtract(365, 280));

            Console.WriteLine(Divide(40, 5));

            Console.WriteLine(Modulus(85, 10)); 


        }

        public static void MadLib()
        {

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine("What is you favorite animal?");
            var favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var favBand = Console.ReadLine();


            Console.Clear();

            Console.WriteLine($"{userName} was walking home from school wearing their favorite {favColor} shirt");
            Console.WriteLine($"listening to their favorite band {favBand}");
            Console.WriteLine($"when they were approached by a {favAnimal}.");
            Console.WriteLine($"The {favAnimal} asked {userName}");
            Console.WriteLine($"who they were listening to. {userName} responded.");
            Console.WriteLine($"{favBand} and the {favAnimal} was blown away");
            Console.WriteLine($"as they love them too. {userName} woke up");
            Console.WriteLine($"and relized it was just a dream");

        }

        public static int Addition(int num1, int num2)
        {

            return num1 + num2;

        }

        public static int Muliply(int num1, int num2, int num3)
        {


            return num1 * num2 * num3;


        }

        public static int Subtract(int num1, int num2)
        {

            return num1 - num2;

        }

        public static int Divide(int num1, int num2)
        {

            return num1 / num2;

        }

        public static int Modulus(int num1, int num2)
        {

            return num1 % num2;


        }
        



        

    }
}

