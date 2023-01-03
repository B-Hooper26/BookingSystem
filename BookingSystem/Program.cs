using System.Net.Http.Headers;

namespace BookingSystem
{
    public class program
    {

        static void Main(string[] args)
        {
            //Asking user for custome name
            Console.Write("please enter customer name: ");
            string name = Console.ReadLine();
            //Customer address
            Console.Write("Please enter the customers' address: ");
            string address = Console.ReadLine();
            //Customer email
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            //customer phone number
            Console.Write("Enter phone number: ");
            string phonenumber = Console.ReadLine();
            //creating a customer
            Customer c1 = new Customer(name, address, email, phonenumber, 0);


            //creating a interface where users can see the list of
            Console.Clear();
            Console.WriteLine(c1);
            Console.WriteLine("press ANY key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("            List of options             ");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("DVD's:\n-Smurfs(Out of stock)\n-Pirates of the carribean\n-Toy Story\n-Smile\n-Friday the 13th\n");
            Console.WriteLine("CD's:\n-Cold Play\n-Queen\n-Magnum\n-Imagine Dragons(Out of stock)\n-Oasis\n");
            Console.WriteLine("Books's:\n-Harry Potter\n-Diary of the Whimpy kid\n-Gangster Granny\n-Little Red Riding Hood\n-Romeo and Juliet (Out of stock)");
            Console.WriteLine("\nSelect ANY key to continue with booking");
            Console.ReadKey();
            //will be used to calculate all fees
            double FeeAmmount = 0;
            //asking user how many items they want to loan
            Console.Write("Please enter how many CD's you would like to loan; ");
            int AmountOfCD = Convert.ToInt32(Console.ReadLine());
            //enables loop to restart when an invalid answer is invalid
            bool RestLoop = false;
            //Enbales us to loop x amount of times
            int NumOfCDs = 0;

            while (RestLoop == false)
            {
                //setting varibales here so it can be accessed outside the loop
                string title = "";
                string CDcode = "";
                string CDsize = "";
                while (NumOfCDs < AmountOfCD)
                {
                    Console.Write("Please enter the title of the CD you would like to loan out: ");
                     title = Console.ReadLine();

                    if (title == "Imagine Dragons")
                    {
                        Console.WriteLine("It seems like you have gone over the 2 week loan spell");
                        Console.Write("You have not returned this item from before, please enter the date you loaned this out: ");
                        DateTime CDstartDate = Convert.ToDateTime(Console.ReadLine());
                        //Calculating when the book was supposed to be in by
                        DateTime LoanSpell = CDstartDate;

                        Console.Write($"The CD was supposed to be handed back on: {LoanSpell.AddDays(14)}\n please enter todays date: ");
                        //working out the fee
                        DateTime ReturnedBydate = Convert.ToDateTime(Console.ReadLine());
                        DateTime DurationDate = LoanSpell.AddDays(14);
                        int OverdueBy =  ReturnedBydate.Day - DurationDate.Day;
                        FeeAmmount = OverdueBy * 0.25;
                        Console.WriteLine($"Your Fee Total: £{FeeAmmount}");
                        RestLoop = false;
                    }
                    else
                    {
                        Console.Write("Please enter the CD's 10 digit unique code:");
                        CDcode = Console.ReadLine();
                        if (CDcode.Length != 10)
                        {
                            Console.WriteLine("Enter a valid code!");
                            RestLoop = false;
                        }
                        else
                        {
                            Console.Write("Please enter the size of the CD (S- small, M- medium, L- large: ");
                            CDsize = Console.ReadLine();
                            if (CDsize.ToUpper() != "S" && CDsize.ToUpper() != "M" && CDsize.ToUpper() != "L" )
                            {
                                //error checking
                                Console.WriteLine("Invalid input");
                                RestLoop = false;
                            }
                        }
                        //change the colout to show the loaned was successfull
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CD successfully loaned! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        CD cd = new CD(CDcode, CDsize, title);
                        Console.WriteLine(cd);
                        NumOfCDs++;
                    }

                }
                

                
                RestLoop = true;
            }


        }
    }
}