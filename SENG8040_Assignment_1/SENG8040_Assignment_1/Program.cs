using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040_Assignment_1
{
    class Program
    {
        public static int MenuSelection()
        {
            string InputOfUser = "";
            bool validMenuSelect = false;
            while (validMenuSelect == false)
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit\n");
                Console.WriteLine("Enter a valid menu option");
                InputOfUser = Console.ReadLine();

                if (InputOfUser != "1"
                    && InputOfUser != "2"
                    && InputOfUser != "3"
                    && InputOfUser != "4"
                    && InputOfUser != "5"
                    && InputOfUser != "6"
                    && InputOfUser != "7")
                {
                    Console.WriteLine("Yikes! Wrong Entry");
                }
                else
                {
                    validMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(InputOfUser);
        }
        public static double UserInputValidation(string numchosen)
        {
            double num = 1;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine($"Please do enter the {numchosen} ");
                string InputOfUser = Console.ReadLine();
                Console.WriteLine();

                bool res = double.TryParse(InputOfUser, out num);

                if (res == false)
                {
                    Console.WriteLine("This doesn't seem like a Valid Input, Try Again!!");
                }
                else
                {
                    valid = true;
                    Console.WriteLine($"The {numchosen} has been changed to: {num}");
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            Rect r = new Rect();
            int sel;
            Rect UserCustomRect = new Rect();
                r = UserCustomRect;
            
            sel = MenuSelection();
            while (sel != 9)
            {
                int res;
                switch (sel)
                {
                    case 1:
                        Console.WriteLine($"Length Is:{r.GetLen()}\n");
                        break;
                    case 2:
                        Console.WriteLine($"Width Is:{r.GetWid()}\n");
                        break;
                    case 3:
                        res = Convert.ToInt32(UserInputValidation("Length"));
                        r.SetLen(res);
                        break;
                    case 4:
                        res = Convert.ToInt32(UserInputValidation("Width"));
                        r.SetWid(res);
                        break;
                    case 5:
                        Console.WriteLine($"The Perimeter Is: {r.GetPeri()}");
                        break;
                    case 6:
                        Console.WriteLine($"The Area Is: {r.GetArea()}");
                        break;
                }
                sel = MenuSelection();
            }
        }
    }
}

                

        