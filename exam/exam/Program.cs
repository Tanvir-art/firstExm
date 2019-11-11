using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int month;
            int day;

            Console.Write("Please enter year:");
             year = Convert.ToInt32(Console.ReadLine());
            if (year>=1971 && year<=2019)
            {
                 
            }
            else
            {
                Console.WriteLine("Sorry, you provide an invalid year. Try again!");
                Console.Write("Please enter year:");
                year = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Please enter month:");
             month = Convert.ToInt32(Console.ReadLine());
            if (month >= 13)
            {
                Console.WriteLine("Sorry, you provide an invalid year. Try again!");
                Console.Write("Please enter month:");
                month = Convert.ToInt32(Console.ReadLine());
            }
            
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:

                        Console.Write("Please enter day:");
                        day = Convert.ToInt32(Console.ReadLine());
                        if (day >= 1 && day <= 31)
                        {
                        if (month == 1)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Jan-" + year);
                        }
                        else if (month == 3)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Mar-" + year);
                        }
                        else if (month == 5)
                        {
                            Console.WriteLine("Your Date is:" + day + "-May-" + year);
                        }
                        else if (month == 7)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Jul-" + year);
                        }
                        else if (month == 8)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Aug-" + year);
                        }
                        else if (month == 10)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Oct-" + year);
                        }
                        else if (month == 12)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Dec-" + year);
                        }
                    }
                        else
                        {
                            Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                            Console.Write("Please enter day:");
                            day = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 2:

                        Console.Write("Please enter day:");
                        day = Convert.ToInt32(Console.ReadLine());
                        if (day >= 1 && day <= 28)
                        {
                        if (month == 2)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Feb-" + year);
                        }
                    }
                        else
                        {
                            Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                            Console.Write("Please enter day:");
                            day = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.Write("Please enter day:");
                        day = Convert.ToInt32(Console.ReadLine());
                        if (day >= 1 && day <= 30)
                        {
                            if (month == 4)
                            {
                                Console.WriteLine("Your Date is:" + day + "-Apr-" + year);
                            }
                            else if (month == 6)
                            {
                                Console.WriteLine("Your Date is:" + day + "-Jun-" + year);
                            }
                        else if (month == 9)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Sep-" + year);
                        }
                        else if (month == 11)
                        {
                            Console.WriteLine("Your Date is:" + day + "-Nov-" + year);
                        }
                    }
                        else
                        {
                            Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                            Console.Write("Please enter day:");
                            day = Convert.ToInt32(Console.ReadLine());
                        
                    }

                        break;
                    default:
                        Console.WriteLine("Sorry, you provide an invalid month. Try again!");
                        break;
                }


           
            // day = Convert.ToInt32(Console.ReadLine());
            //if (day >= 1 && day <= 31)
            //{
            //    int[] thirtyOneMonth = { 1, 3, 5, 7, 8, 10, 12 };

            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you provide an invalid year. Try again!");
            //}
        }
    }
}
