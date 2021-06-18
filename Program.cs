using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, userInput;
            Console.WriteLine("Welcome to the Rectangle Program!!!");
            do
            {
                Console.WriteLine("Please enter the length of the Rectangle");
                Int32.TryParse(Console.ReadLine(), out length);
                if ( length <= 0)
                    Console.WriteLine("Please enter an integer value greater than 0");
            } while (length <= 0);
            do
            {
                Console.WriteLine("Please enter the width of the Rectangle");
                Int32.TryParse(Console.ReadLine(), out width);
                if ( width <= 0)
                    Console.WriteLine("Please enter an integer value greater than 0");
            } while (width <= 0);
            Rectangle rect = new Rectangle(length, width);

            do
            {
                Console.WriteLine("Please enter any number from 1 - 7 to choose the corresponding option shown below");
                Console.WriteLine("1.   Get Rectangle Length");
                Console.WriteLine("2.   Change Rectangle Length");
                Console.WriteLine("3.   Get Rectangle Width");
                Console.WriteLine("4.   Change Rectangle Width");
                Console.WriteLine("5.   Get Rectangle Perimeter");
                Console.WriteLine("6.   Get Rectangle Area");
                Console.WriteLine("7.   Exit");
                Int32.TryParse(Console.ReadLine(), out userInput);

                switch ( userInput)
                {
                    case 1:
                        Console.WriteLine("Length of the rectangle is {0}", rect.GetLength());
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("Please enter the new length of the Rectangle");
                            Int32.TryParse(Console.ReadLine(), out length);
                            if ( length <= 0)
                                Console.WriteLine("Please enter an integer value greater than 0");
                        } while (length <= 0);
                        rect.SetLength(length);
                        break;

                    case 3:
                        Console.WriteLine("Width of the rectangle is {0}", rect.GetWidth());
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("Please enter the new width of the Rectangle");
                            Int32.TryParse(Console.ReadLine(), out width);
                            if ( width <= 0)
                                Console.WriteLine("Please enter an integer value greater than 0");
                        } while (width <= 0);
                        rect.SetWidth(width);
                        break;
                    case 5:
                        Console.WriteLine("Perimeter of the rectangle is {0}", rect.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Area of the rectangle is {0}", rect.GetArea());
                        break;
                    case 7:
                        Console.WriteLine("Exiting!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            } while (userInput != 7);

        }
    }
}
