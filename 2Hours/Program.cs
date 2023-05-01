using System.Threading.Channels;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {

        #region type casting
        /*
        double a = 3.14;
        int b = Convert.ToInt32(a);

        int c = 23231;
        double d = Convert.ToDouble(c) +0.1;

        int e = 321;
        String f = Convert.ToString(e);

        String g = "$";
        char h = Convert.ToChar(g);

        String i = "true";
        bool j = Convert.ToBoolean(i);

        Console.WriteLine(b.GetType());
        Console.WriteLine(d.GetType());
        Console.WriteLine(f.GetType());
        Console.WriteLine(h.GetType());
        Console.WriteLine(j.GetType());
        */
        #endregion

        #region how to accept user input
        /*
        Console.WriteLine("What's your name");
        String name = Console.ReadLine();

        Console.WriteLine("What's your age");
        int age = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Hello " + name);
        Console.WriteLine("You are  " + age + " Years old");
        */
        #endregion

        #region basic arithmetic

        // int friends = 10;

        //friends = friends + 2;
        //friends += 2;
        //friends++;

        //friends = friends = 1;
        //friends -= 1;
        //friends--;

        //friends = friends  * 2;
        //friends *= 2;

        //friends = friends / 2;
        //friends /= 2;

        //int remainder = friends % 3;


        //Console.WriteLine(remainder);

        #endregion

        #region math class
        /*
        double x = 3.99;
        double y = 5;

        //double a = Math.Pow(x, 2);
        //double b = Math.Sqrt(x);
        //double c = Math.Abs(x);
        // double d = Math.Round(x);
        //double e = Math.Ceiling(x);
        //double f = Math.Floor(x);
        //double g = Math.Max(x, y);
        //double h = Math.Min(x, y);

        Console.WriteLine(h);
        */
        #endregion

        #region how to generate random numbers
        /*
                Random random = new Random();

                int num1 = random.Next(1, 21);
                int num2 = random.Next(1, 21);
                int num3 = random.Next(1, 21);


                //double num = random.NextDouble();

                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
        */
        #endregion

        #region find the hypotenuse of the right triangle
        /*
         Console.WriteLine("Enter side A: ");
         double a = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Enter side B: ");
         double b = Convert.ToDouble(Console.ReadLine());

         double c = Math.Sqrt((a + a) + (b * b));

         Console.WriteLine("The hypotenuse is: " + c);
        */
        #endregion

        #region useful string method
        /*
         String fullName = "Hermar hehe";

        string phoneNumber = "123-1233-3232";

        fullName = fullName.ToUpper();
        fullName = fullName.ToLower();
        Console.WriteLine(fullName);

        phoneNumber = phoneNumber.Replace("-", "/");
        Console.WriteLine(phoneNumber);

        string userName = fullName.Insert(0, "MR.");
        Console.WriteLine(userName);

        Console.Write(fullName.Length);

         String firstName = fullName.Substring(0, 6);
         String lastName = fullName.Substring(7, 4);

          Console.WriteLine(firstName);
          Console.WriteLine(lastName);
        */

        #endregion

        #region if statements

        /* Console.WriteLine("Please enter your age: ");
         int age = Convert.ToInt32(Console.ReadLine());

         if (age >= 100)
         {
             Console.WriteLine("You are to old to sign up!");
         }
         else if (age >= 18)
         {
             Console.WriteLine("You are signed up");
         }
         else if (age < 0)
         {
             Console.WriteLine("You haven't been born yet!");
         }
         else
         {
             Console.WriteLine("You must be 18+ to sign up!");
         }
       

        Console.WriteLine("Please enter your name:");
        String name = Console.ReadLine();

        if (name != "")
        {  
            Console.WriteLine("Hello " + name);
        }
        else
        {
            Console.WriteLine("You did not enter your name!");
        }
        */
        #endregion

        #region switches
        /*
                Console.WriteLine("What day is today?");
                String day = Console.ReadLine();

                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("It's monday!");
                        break;      
                    case "Tuesday":
                        Console.WriteLine("It's Tuesday!");
                        break;        
                    case "wednesday":
                        Console.WriteLine("It's wednesday!");
                        break;      
                   case "Thursday":
                        Console.WriteLine("It's Thursday!");
                        break;
                    case "Friday":
                       Console.WriteLine("It's Friday!");
                        break;
                    case "Sunday":
                        Console.WriteLine("It's Sunday!");
                        break;
                    case "Saturday":
                        Console.WriteLine("It's Saturday!");
                        break;
                    default:
                        Console.WriteLine(day + "is not a day!");
                        break;
                }
        */

        #endregion

        #region logical operator &&(AND) ||(OR)

        /* Console.WriteLine("What's the tempereture outside: (C)");
         double temp = Convert.ToDouble(Console.ReadLine());


         if (temp >= 10 && temp <= 25)
         {
             Console.WriteLine("It's warm outside");
         }
         else if (temp <= -50 || temp >= 50)
         {
             Console.WriteLine("DO NOT GO OUTSIDE");
         }
         */

        #endregion

        #region while loop = repeats some codes while some conditions remains true
        /*
                 String name = "";

                while (name == "")
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                }


                Console.WriteLine("Hello " + name);
        */

        #endregion

        #region for loop = repeats some codes a FINITE amount of times

        /*
         for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        

        for (int i = 10; i >  0; i--)
        {
        Console.WriteLine(i);
        }
        Console.WriteLine("HAPPY NEW YEAR!!!");
        */
        #endregion

        #region --WHAT DAY IS TODAY--
        /*
                Console.WriteLine("What day is today!");
                Console.WriteLine("===============================================================");
                Console.WriteLine("Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday");
                Console.WriteLine("================================================================");

                String day = Console.ReadLine();

                switch(day)
                {
                    case "Monday":
                        Console.WriteLine("To day It's Monday!");
                        break;
                    case "Tuesday":
                        Console.WriteLine("To day It's Tuesday!");
                        break;
                    case "Wednesday":
                        Console.WriteLine("To day It's Wednesday!");
                        break;
                    case "Thursday":
                        Console.WriteLine("To day It's Thursday!");
                        break;
                    case "Friday":
                        Console.WriteLine("To day It's Friday!");
                        break;
                    case "Saturday":
                        Console.WriteLine("To day It's Saturday!");
                        break;
                    case "Sunday":
                        Console.WriteLine("To day It's Sunday!");
                        break;
                    default:
                        Console.WriteLine(day + "It's not a day!!");
                        break;
                }
        */
        #endregion

        #region

        Console.WriteLine("What day is today?");

        var day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("Today is Monday!!");
                break;
            case "Tuesday":
                Console.WriteLine("Today is Tuesday!!");
                break;
            case "Wednesday":
                Console.WriteLine("Today is Wednesday!!");
                break;
            case "Thursday":
                Console.WriteLine("Today is Thursday!!");
                break;
            case "Friday":
                Console.WriteLine("Today is Friday!!");
                break;
            case "Saturday":
                Console.WriteLine("Today is Saturday!!");
                break;
            case "Sunday":
                Console.WriteLine("Today is Sunday!!");
                break;
            default:
                Console.WriteLine(day + " is not a day!!!!");
                break;
        }

        #endregion

        Console.ReadKey();
    }
  
 
       
    
}