using System.Drawing;

namespace Session2c_
{
    internal class Program
    {

        static int sum(int x , int y)
        {
                return x - y;
        }
        static void Main(string[] args)
        {

            //************************************************* Demo_Session_2_C# ******************************************//
            //Console.WriteLine("Hello, World!");
            //Console.ReadLine();


            // 3shan akteb  region  (ctrl+k) b3daha  (ctrl+s)

            #region Error Type
            #region Syntax Error-Compilation Error
            //console.WriteLine("Hello in c#");
            //iint x;
            #endregion

            #region Runtime-Error
            //int x = 5;
            //int y = 0;

            //Console.WriteLine(x/y);
            #endregion


            #region Logical-Error
            //int a = 8;
            //int b = 10;
            //Console.WriteLine(sum(a,b));
            #endregion

            #region Warrning
            int u;

            #endregion

            #endregion


            #region Variables
            ////5
            //int number=5   //4 byte
            #endregion

            #region CTS - CLS
            //int c = 5;// 4byte

            //string sd = "test";  //  8 byte      (2 byte * 4 char)
            //string fd = "testing";  //  14 byte
            #endregion


            #region ValueType
            //int x;
            //x = 4;
            //int y=9;
            //y = x;
            //x++;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion

            #region Refrence-Type
            //Ponit p01;

            //p01 = new Ponit();

            //Ponit p02 = new Ponit();


            //p02 = p01;

            //p01.e = 10;
            //Console.WriteLine(p02.e);
            #endregion


            #region Object
            Object obj1 = new Object();
            //obj1 = 1;
            //obj1 = "ali";
            //obj1 = 'A';
            //obj1 = true;


            //Object obj2 = new Object(); 
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());



            //obj2 = obj1;
            //Console.WriteLine("***************************");
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());


            #endregion



            #region Fractions abd Discard
            //// int num01=3333333333333333333
            //long num02 = 333333333333333333;

            //double d = 22.2;
            //float f = 22.2f;
            //decimal o = 22.35m;

            //int dis = 1_000_000_000;

            //Console.WriteLine(dis);
            #endregion








            //******************************************** Assingment_1_C# **********************************************//
            // 1-Write a program that allows the user to enter a number then print it.
            #region Qustion_one

            //Console.WriteLine("Enter your number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("you Entered :" + number);

            #endregion

            // 2-Write C# program that Assigning one value type variable to another and
            // modifying the value of one variable and mention what will happen
            #region Qustion_two
            //// Declare and initialize a value type variable
            //int number1 = 10;

            //// Assign the value of number1 to another variable
            //int number2 = number1;

            //// Modify the value of number1
            //number1 = 20;

            //// Display the values of both variables
            //Console.WriteLine($"Value of number1: {number1}");
            //Console.WriteLine($"Value of number2: {number2}");
            #endregion


            // 3-Write C# program that Assigning one reference type variable to another and
            // modifying the object through one variable and mention what will happen
            #region Qustion_Three
            //Person person1 = new Person { Name = "Alice" };

            //Person person2 = person1;


            //person1.Name = "Bob";

            //// Display the values of both variables
            //Console.WriteLine($"person1.Name: {person1.Name}");
            //Console.WriteLine($"person2.Name: {person2.Name}");
            #endregion




        }
    }
}
