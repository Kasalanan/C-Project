using System;   

namespace OOP
{
    class Program
    {

        public static int mainChoice;
        public static int subChoice;
        public static String input;

        public static void Main(String[] args)
        {
            Program obj = new Program();

            mainMenu();
        }

        public static void mainMenu()
        {
            bool b = true;

            while (b == true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Simple C# Program");
                Console.WriteLine("2. Selection Program");
                Console.WriteLine("3. Iteration Program");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option: ");

                string input = Console.ReadLine();
                bool result = Int32.TryParse(input, out mainChoice);

                Console.WriteLine("\n");

                if (mainChoice == 1)
                {
                    subSimple();
                }
                else if (mainChoice == 2)
                {
                    subSelection();
                }
                else if (mainChoice == 3)
                {
                    subIteration();
                }
            }//end while
        }//end mainMenu

        static void subSimple()
        {
            Simple obj = new Simple();

            Console.WriteLine("Simple C# Program");
            Console.WriteLine("1. Addition of three (3) numbers");
            Console.WriteLine("2. Compute for the area of the sphere");
            Console.WriteLine("3. Display the sum and average of a set of numbers from 1 - entered number");
            Console.WriteLine("4. Display input details");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Please select an option: ");

            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out subChoice);
            Console.WriteLine("\n");

            switch (subChoice)
            {
                case 1:
                    obj.getSum();
                break;

                case 2:
                obj.areaOfSphere();
                break;

                case 3:
                    obj.getAve();
                break;

                case 4:
                    obj.display();
                break;

                case 5:
                    mainMenu();
                break;

                default:
                Console.WriteLine("Invalid input\n");
                subSimple();
                break;
            }
        }//end subSimple

        static void subSelection()
        {
            Selection obj = new Selection();

            Console.WriteLine("Selection C# Program");
            Console.WriteLine("1. Pass or Failed");
            Console.WriteLine("2. Positive or Negative");
            Console.WriteLine("3. Leap year or not");
            Console.WriteLine("4. Find the highest number");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Please select an option: ");

            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out subChoice);
            Console.WriteLine("\n");

            switch (subChoice)
            {
                case 1:
                    obj.passFailed();
                break;

                case 2:
                    obj.positiveNegative();
                break;

                case 3:
                    obj.leapOrNot();
                break;

                case 4:
                    obj.highestNumber();
                break;

                case 5:
                    mainMenu();
                break;

                default:
                Console.WriteLine("Invalid input\n");
                subSimple();
                break;
            }
        }//end subSelection

        static void subIteration()
        {
            Iteration obj = new Iteration();

            Console.WriteLine("Iteration C# Program");
            Console.WriteLine("1. Display numbers from 1 - 50");
            Console.WriteLine("2. Display numbers from 50 - 1");
            Console.WriteLine("3. Display Odd or Even numbers from 1 - 100");
            Console.WriteLine("4. Display your name 10 times");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Please select an option: ");

            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out subChoice);
            Console.WriteLine("\n");

            switch (subChoice)
            {
                case 1:
                    obj.displayNumbers();
                    break;

                case 2:
                    obj.displayNumbersV2();
                    break;

                case 3:
                    obj.displayNumbersV3();
                    break;

                case 4:
                    obj.displayName();
                    break;

                case 5:
                    mainMenu();
                    break;

                default:
                    Console.WriteLine("Invalid input\n");
                    subSimple();
                    break;
            }
        }
    }// end class Program

    public class Simple
    {
        public static string input;
        public static bool result;

        public void getSum()
        {
            double num1, num2, num3;
            double sum = 0;

            do
            {
                Console.Write("Input num1: ");
                input = Console.ReadLine();
                result = Double.TryParse(input, out num1);
            } while (!result);

            do
            {
                Console.Write("Input num2: ");
                input = Console.ReadLine();
                result = Double.TryParse(input, out num2);
            } while (!result);

            do
            {
                Console.Write("Input num3: ");
                input = Console.ReadLine();
                result = Double.TryParse(input, out num3);
            } while (!result);

            sum = num1 + num2 + num3;

            Console.WriteLine("The sum of three number (" + num1 + ", " + num2 + " and " + num3 + ") is " + sum);
            Environment.Exit(0);
        }//end getSum

        public void areaOfSphere()
        {
            double r, r2, p, area;
            
            do 
            {
                Console.Write("Input value for radius: ");
                input = Console.ReadLine();
                result = Double.TryParse(input, out r);
            }while(!result);

            p = Math.PI;
            r2 = r * r;
            area = (4 * p) * r2;
            area = Math.Round(area, 2);
            Console.WriteLine("The area of the sphere is " + area);
            Environment.Exit(0);
        }//end areaOfSphere

        public void getAve()
        {
            double num, ave;
            double sum = 0;
            do
            {
                Console.Write("Input a number: ");
                input = Console.ReadLine();
                result = Double.TryParse(input, out num);
            } while (!result);

            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }

            ave = sum / num;

            Console.WriteLine("The sum of numbers from 1 to " + num + " is " + sum);
            Console.WriteLine("The average of numbers from 1 to " + num + " is " + ave);
            Environment.Exit(0);
        }//end getAve

        public void display()
        {
            string firstName, lastName, gender;
            int age;

            do
            {
                Console.Write("First Name: ");
                input = Console.ReadLine();
                firstName = input;
                foreach (char c in input)
                {
                    if (!Char.IsLetter(c))
                        result = false;
                    else
                        result = true;
                }
            } while (!result);

            do
            {
                Console.Write("Last Name: ");
                input = Console.ReadLine();
                lastName = input;
                foreach (char c in input)
                {
                    if (!Char.IsLetter(c))
                        result = false;
                    else
                        result = true;
                }
            } while (!result);

            do
            {
                Console.Write("Gender: ");
                input = Console.ReadLine().ToUpper();
                gender = input;
                foreach (char c in input)
                {
                    if (!Char.IsLetter(c))
                        result = false;
                    else
                        result = true;
                }
            } while (!result);

            do
            {
                Console.Write("Age: ");
                input = Console.ReadLine();
                result = Int32.TryParse(input, out age);
            } while (!result);

            Console.WriteLine("Information");
            Console.WriteLine("First Name:  " + firstName);
            Console.WriteLine("Last  Name:  " + lastName);
            Console.WriteLine("Age:         " + age);
            Console.WriteLine("Gender:      " + gender[0]);
            Environment.Exit(0);
        }//end display
    }//end class Simple

    public class Selection
    {
        public static string input;
        public static bool result;

        public void passFailed()
        {
            double grade;

            do
            {
                Console.Write("Input Grade: ");
                input = Console.ReadLine();
                result = Double.TryParse(input, out grade);
            } while (!result);
            if (grade >= 75 || grade <= 100)
            {
                Console.WriteLine("You've passed");
            }
            else if (grade > 0 || grade < 75)
            {
                Console.WriteLine("You've failed");
            }
            else
                Console.WriteLine("Invalid input");
            Environment.Exit(0);
        }//end passFailed

        public void positiveNegative()
        {
            double num;

            do
            {
                Console.Write("Input number: ");
                input = Console.ReadLine();
                result = Double.TryParse(input, out num);
            } while (!result);
            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("Number is neither positve or negative");
            }
            else
                Console.WriteLine("Invalid input");
            Environment.Exit(0);
        }//end positiveNegative

        public void leapOrNot()

        {
            int year;
            do
            {
                Console.Write("Enter a year: ");
                input = Console.ReadLine();
                result = Int32.TryParse(input, out year);
                if (year % 400 == 0)
                {
                    Console.WriteLine("Year " + year + " is a leap year");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine("Year " + year + " is not a leap year");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("Year " + year + " is a leap year");
                }
                else
                    Console.WriteLine("Year " + year + " is not a leap year");
            }while(!result);
            Environment.Exit(0);
        }//end leapOrNot

        public void highestNumber()
        {
            Double num1, num2, num3;

            do
            {
                Console.Write("Input first number: ");
                input = Console.ReadLine();
                result = double.TryParse(input, out num1);

                Console.Write("Input second number: ");
                input = Console.ReadLine();
                result = double.TryParse(input, out num2);

                Console.Write("Input third number: ");
                input = Console.ReadLine();
                result = double.TryParse(input, out num3);

                if(num1 >= num2 && num1 >= num3)
                {
                    Console.WriteLine("Number " + num1 + " is the highest");
                }
                else if(num2 >= num1 && num2 >= num3)
                {
                    Console.WriteLine("Number " + num2 + " is the highest number");
                }
                else if(num3 >= num1 && num3 >= num2)
                {
                    Console.WriteLine("Number " + num3 + " is the highest number");
                }
            } while (!result);
            Environment.Exit(0);
        }//end highestNumber
    }//end class Selection

    public class Iteration
    {
        public static string input;
        public static bool result;

        public void displayNumbers()
        {
            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i + ", ");
            }
            Environment.Exit(0);
        }//end displayNumbers

        public void displayNumbersV2()
        {
            for (int i = 50; i > 0; i--)
            {
                Console.WriteLine(i + ", ");
            }
            Environment.Exit(0);
        }//end V2

        public void displayNumbersV3()
        {
            Console.Write("Display [O] Odd or [E] Even: ");
            input = Console.ReadLine().ToUpper();
            char choice = input[0];
            if(choice == 'E')
            {
                for(int i = 0; i <= 100; i++)
                {
                    if(i % 2 == 0)
                        Console.WriteLine(i + ", ");
                }
            }
            if(choice == 'O')
            {
                for(int i = 1; i <= 100; i++)
                {
                    if (i % 2 != 0)
                    Console.WriteLine(i + ", ");
                }
            }
            Environment.Exit(0);
        }//end V3

        public void displayName()
        {
            string name;
            do
            {
                Console.Write("O namae wa?: ");
                input = Console.ReadLine();
                name = input;
                foreach (char c in name)
                {
                    if (!Char.IsLetter(c))
                        result = false;
                    else
                        result = true;
                }
            } while (!result);
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(name);
            Environment.Exit(0);
        }
    }//end class Iteration
}//end