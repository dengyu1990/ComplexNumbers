using System;

namespace ComplexNumbers
{
    class Program
    {
        static void doWork()
        {
            Complex first = new Complex(10, 4);
            Complex second = new Complex(5, 2);
            Console.WriteLine($"first is {first}");
            Console.WriteLine($"second is {second}");

            Complex temp = first + second;
            Console.WriteLine($"Add: result is {temp}");

            temp = first - second;
            Console.WriteLine($"Subtract: result is {temp}");

            temp = first * second;
            Console.WriteLine($"Multiply: result is {temp}");

            temp = first / second;
            Console.WriteLine($"Divide: result is {temp}");

            if (temp == first)
                Console.WriteLine("Comparsion:temp==first");
            else
                Console.WriteLine("Comparsion:temp!=first");
            if (temp == temp)
                Console.WriteLine("Comparsion:temp==temp");
            else
                Console.WriteLine("Comparsion:temp!=temp");

            Console.WriteLine($"Current value of temp is {temp}");
            if (temp == 2)
                Console.WriteLine("Comparison after conversion: temp==2");
            else
                Console.WriteLine("Comparison after conversion: temp!=2");

            temp += 2;
            Console.WriteLine($"Value after adding 2:temp={temp}");

            int tempInt = (int)temp;
            Console.WriteLine($"Int value after conversion:tempInt=={tempInt}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
