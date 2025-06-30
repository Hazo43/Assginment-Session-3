using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assginment_Session_3
{
    internal class Program
    {
        static void Main(string[] args)


        {

            #region Q01

            //  1-	Write a program that allows the user to enter a number then print it.

            //Console.WriteLine(" Enter Your Number : ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //Console.Clear();
            //Console.WriteLine(" Number : " + Number);

            #endregion

            #region Q2


            //  2 - Write C# program that converts a string to an integer,
            //  but the string contains non-numeric characters. And mention what will happen 

            //Console.WriteLine("Enter Your String non-numeric");

            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" Number is : " + number);

            //  what will happen =>  System.FormatException: 'The input string 'lk' was not in a correct format.'
            #endregion

            #region Q03

            // 3-	Write C# program that Perform a simple arithmetic operation
            // with floating-point numbers And mention what will happen

            // num1 = 3.2f;
            //float num2 = 3.4f;
            //  int  result =num1 + num2;      // exceptions becouse int less than data type float
            //float result = num1 + num2;
            //Console.WriteLine(result );

            // if convert from decimal to double  => Exceptions   =>   must be Explicit Casting 
            // if convert from double to float  => Exceptions     =>  must be Explicit Casting 
            // if convert from float to int  => Exceptions        => must be Explicit Casting 


            #endregion

            #region Q04

            // 4-	Write C# program that Extract a substring from a given string.
            // 



            #endregion


            #region Q05

            //5-	Write C# program that Assigning one value type variable to another
            //     and modifying the value of one variable and mention what will happen
            // 

            //int x = 10;   //  x = 10 
            //int y = x;    //  copy(x) -> y     y = x = 10   becouse int => value type => تحزن في stack
            //y = 20;       //  y = 20  ,  x = 10  

            //Console.WriteLine(x);  // 10
            //Console.WriteLine(y);  // 10


            #endregion

            #region Q06

            ////  6-	Write C# program that Assigning one reference type variable to another and
            ////   modifying the object through one variable and mention what will happen

            //Point p01;        // => reference point p1 ,  stack => 4 Byte , Heaps => 0  

            //p01 = new Point();      // => Heaps => 8 Byte (x = 0 ,y = 0 ) defult , p1 =>  object بيشاور علي مكان ال  

            //Console.WriteLine(p01.X);   // 0 
            //Console.WriteLine(p01.Y);   // 0 



            //Point p02 =  new Point();           // بالظبط p1 هيعمل زي ما همل في ال 

            //Console.WriteLine(p02.X);     // 0 
            //Console.WriteLine(p02.Y);      // 0 


            //p02 = p01;    // p1&p2  unreachable object  <= p2 الاتنين هيشاورو علي نفس المكان و الي كان متخزن جوا ال  

            //p01.X = 50;                 // p01.X & p02.X => 50
            //p02.Y = 100;                // p01.Y & p02.Y => 110

            //Console.WriteLine(p02.X);       // 50
            //Console.WriteLine(p02.Y);      // 100

            #endregion


            #region Q07

            // 7-	Write C# program that take two string variables and print them as one variable 

            //solution 1  

            //string name1 =" Abdo "  , name2 = "Gaber" ;
            // Console.WriteLine(name1 + name2);

            //solution 2

            //string name1 = " Abdo ";
            //string name2 = "Gaber" ;
            //string result = name1 + name2;
            //Console.WriteLine(result);

            #endregion

            #region Q08
            //8 - Write a program that calculates the simple interest given the principal amount,
            //rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.



            //Console.WriteLine(" Enter the Principal Amount : ");
            // double principal=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(" Enter the Rate of Interest : ");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter The Time Years : ");
            //  double  time = Convert.ToDouble(Console.ReadLine());

            // double interest = (rate * time * principal) / 100;

            //Console.WriteLine(" Simple Interest = " + interest);

            // **********  or  ********* //

            //double interest, rate, time, principal;
            //rate = 5;
            //time = 2;
            //principal = 1000;

            //interest = (rate * time * principal) / 100;
            //Console.WriteLine(interest);


            #endregion

            #region Q09
            //9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms
            // and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)



            //Console.WriteLine(" Enter Weight In Kilograms -> ");
            //double Weight = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(" Enter Height In Meters -> ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double BMI = (Weight) / (height * height);

            //    Console.WriteLine(" BMI IS => " + BMI);



            #endregion

            #region Q10
            /*10-	Write a program that uses the ternary operator to 
             * check if the temperature is too hot, too cold, or
             * just good. Assign the result in a variable then 
             * display the result. Assume that below 10 degrees is
             * "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
             */

            //Console.WriteLine(" Enter the temperature degrees : ");
            //// int.TryParse(Console.ReadLine(), out var degree);    // => TryPars
            //// int degree = Convert.ToInt32(Console.ReadLine());    // => Convert 
            //// int degree= int.Parse(Console.ReadLine());           // => Parse 
            //if (degree < 10)
            //    Console.WriteLine(" \n Just Cold \n");
            //else if (degree > 30) 
            //    Console.WriteLine(" \n Just Hot \n");
            //else
            //    Console.WriteLine("\n Just Good \n");

            #endregion

            #region Q11

            /*
             11-	Write a program that takes the date from the user and displays
                    it in various formats using string interpolation.
                Ex :
                Today’s date : 20 , 11 , 2001
                Today's date : 20 / 11 / 2001
                Today's date : 20 – 11 – 2001
             */

            //Console.WriteLine(" Enter Your The day -> ");
            //int.TryParse(Console.ReadLine(), out int day);

            //Console.WriteLine(" Enter Your The Month -> ");
            //int.TryParse(Console.ReadLine(), out int month);

            //Console.WriteLine(" Enter Your The Years -> ");
            //int.TryParse(Console.ReadLine(),out int year);


            //    Console.WriteLine(" Today’s date : {0} , {1} , {2} ", day, month, year);
            // eny ony     //    Console.WriteLine(" Today’s date : {0} / {1} / {2} ", day, month, year);
            //  Console.WriteLine(" Today’s date : {0} - {1} - {2} ", day, month, year);

            #endregion

            #region Q12
            /*
            12-	 What is the output of the following C# code?

            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            a)	 The event is on 14/06/2024
            b)	 The event is on 2024-06-14
            c)	 The event is on 06/14/2024
            d)	 The event is on June ,4, 2024

             */


            //  a)	 The event is on 14/06/2024
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //// b)	 The event is on 2024-06-14
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:yyyy-MM-dd}");

            // c) The event is on 06/14/2024 
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM-dd-yyyy}");

          //  d)	 The event is on June ,4, 2024
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MMMM/dd/yyyy}");


            #endregion 


        }



    }

    

}
