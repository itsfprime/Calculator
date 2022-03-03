using System.Threading;
using System;
Console.SetWindowSize(180, 50);
int lmao = 1;

try
{
    while (lmao > 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please select an operation");
        Console.WriteLine("1.) Addition");
        Console.WriteLine("2.) Subtraction");
        Console.WriteLine("3.) Multiplication");
        Console.WriteLine("4.) Division");
        Console.WriteLine("5.) Square root");
        Console.WriteLine("6.) Exponent");
        Console.WriteLine("7.) Percent");
        Console.WriteLine("8.) Binary To Decimal");
        Console.WriteLine("9.) Decimal to Binary");
        Console.WriteLine("10.) Area of a geometric figure");
        Console.ForegroundColor = ConsoleColor.White;

        int x;
        x = int.Parse(Console.ReadLine());
        if (x == 1)
        {
            double aNum1;
            double aNum2;
            double sum;
            Console.WriteLine("What is the first number to add");
            aNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the second number to add?");
            aNum2 = int.Parse(Console.ReadLine());
            sum = (aNum1 + aNum2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The sum is " + sum);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        if (x == 2)
        {
            double sNum1;
            double sNum2;
            double difference;
            Console.WriteLine("What is the first number to subtract");
            sNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the second number to subtract?");
            sNum2 = int.Parse(Console.ReadLine());
            difference = (sNum1 - sNum2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The difference is " + difference);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        if (x == 3)
        {
            double mNum1;
            double mNum2;
            double product;
            Console.WriteLine("What is the first number to multiply?");
            mNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the second number to multiply?");
            mNum2 = int.Parse(Console.ReadLine());
            product = (mNum1 * mNum2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product is " + product);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        if (x == 4)
        {
            double dNum1;
            double dNum2;
            double quotient;
            Console.WriteLine("What is the first number to divide?");
            dNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the second number to divide?");
            dNum2 = int.Parse(Console.ReadLine());
            quotient = (dNum1 / dNum2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The quotient is " + quotient);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        if (x == 5)
        {
            double root;
            double rooted;
            Console.WriteLine("What number would you like to square root?");
            root = int.Parse(Console.ReadLine());
            rooted = (Math.Sqrt(root));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The result is " + rooted);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        if (x == 6)
        {
            double root;
            double rootBy;
            double result;
            Console.WriteLine("What number would you like to square?");
            root = int.Parse(Console.ReadLine());
            Console.WriteLine("To what power?");
            rootBy = int.Parse(Console.ReadLine());
            result = Math.Pow(root, rootBy);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The result is " + result);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        if (x == 7)
        {
            double num;
            double percent;
            double result;
            Console.WriteLine("What number would you like to take a percentage of");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine("What percent of this number would you like to take");
            percent = double.Parse(Console.ReadLine());
            result = (num * (percent / 100));
            Console.WriteLine("The result is " + result);
        }
        if (x == 8)
        {
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.WriteLine($"Decimal Value : {decimalValue} ");
        }
        if (x == 9)
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
        if (x == 10)
        {
            int y;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Choose from the list:");
            Console.WriteLine("1.) Square");
            Console.WriteLine("2.) Triangle");
            Console.WriteLine("3.) Rectangle");
            Console.WriteLine("4.) Circle");
            Console.ForegroundColor = ConsoleColor.White;
            y = int.Parse(Console.ReadLine());
            if (y == 1)
            {
                int answer;
                int l;
                Console.WriteLine("What is the length of one of the sides?");
                l = int.Parse(Console.ReadLine());
                answer = (l * l);
                Console.WriteLine("The area of the square is " + answer);
            }
            if (y == 2)
            {
                double preAnswer;
                double answer;
                double w;
                double h;
                Console.WriteLine("What is the height of the triangle");
                h = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the width of the triangle");
                w = int.Parse(Console.ReadLine());
                preAnswer = (.5 * w);
                answer = (preAnswer * h);
                Console.WriteLine("The area of the triangle is " + answer);
            }
            if (y == 3)
            {
                int w;
                int l;
                Console.WriteLine("What is the width of the rectangle");
                w = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of the rectangle");
                l = int.Parse(Console.ReadLine());
                Console.WriteLine("The area of the rectangle is " + w * l);
            }
            if (y == 4)
            {
                double r;
                double pi = 3.141592653589793238462643383279502884;
                Console.WriteLine("What is the radius of the circle");
                r = double.Parse(Console.ReadLine());
                double rSquare = r * r;
                Console.WriteLine("The area of the circle is " + rSquare * pi);

            }
        }
        if (x == 995821)
        {
            int kekw = 1;
            int kekvv = 1;
            while (kekw < 995822)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(kekvv);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("WYSI");
                kekvv++;
            }
        }
    }
}
catch
{
    Console.WriteLine("Invalid input. Terminating...");
    int lol = 0;
    while (lol <= 2)
    {
        Console.Beep();
        lol++;
    }
}