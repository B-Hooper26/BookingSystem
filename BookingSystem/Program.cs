using System.Drawing;
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
            

            //creating list of each Item
            List<string> CustomerD = new List<string>();
            CustomerD.Add(Convert.ToString(c1));
            List<string>CdSummary = new List<string>();
            List<string>DvdSummary = new List<string>();
            List<string>Booksummary = new List<string>();
            //creating a interface where users can see the list of
            Console.Clear();
            Console.WriteLine(c1);
            Console.WriteLine("press ANY key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("            List of CD options       ");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("CD's:\n-Cold Play\n-Queen\n-Magnum\n-Imagine Dragons(OVER DUE)\n-Oasis\n");
            Console.WriteLine("\nSelect ANY key to continue with booking");
            Console.ReadKey();
            //will be used to calculate all fees
            double FeeAmmount = 0;
            int AmountOfCD = 0;
            //asking user how many items they want to loan
            Console.Write("Please enter how many CD's you would like to loan: ");
            AmountOfCD = Convert.ToInt32(Console.ReadLine());

            //enables loop to restart when an invalid answer is invalid
            bool RestLoop = false;
            //Enbales us to loop x amount of times
            int NumOfCDs = 0;

            while (RestLoop == false)
            {
                //setting varibales here so it can be accessed outside the loop
                string CDtitle = "";
                string CDcode = "";
                string CDsize = "";
                while (NumOfCDs < AmountOfCD)
                {
                    Console.Write("Please enter the title of the CD you would like to loan out: ");
                    CDtitle = Console.ReadLine();

                    if (CDtitle == "Imagine Dragons")
                    {
                        Console.WriteLine("It seems like you have gone over the 2 week loan spell");
                        Console.Write("You have not returned this item from before, please enter the date you loaned this out: ");
                        DateTime CDstartDate = Convert.ToDateTime(Console.ReadLine());
                        //Calculating when the book was supposed to be in by
                        DateTime LoanSpell = CDstartDate;

                        Console.Write($"The CD was supposed to be handed back on: {LoanSpell.AddDays(14)}\n please enter todays date: ");
                        //working out the fee
                        DateTime ReturnedBydate = Convert.ToDateTime(Console.ReadLine());
                        DateTime DurationDate = LoanSpell;
                        int OverdueBy =  ReturnedBydate.Day - DurationDate.Day;
                        FeeAmmount = OverdueBy * 0.25;
                        
                        
                    }
                    else if(CDtitle == null)
                    {
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
                            //change the colout to show the loaned was successfull
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("CD successfully loaned! ");
                            Console.ForegroundColor = ConsoleColor.White;
                            CD cd = new CD(CDcode, CDsize, CDtitle); 
                            CdSummary.Add(Convert.ToString(cd));
                            NumOfCDs++;
                        }

                        
                    }

                }
                RestLoop = true;
            }
            Console.WriteLine("Please Press any key to continue!\n");
            Console.ReadKey();
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("           List of DVD options       ");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("DVD's:\n-Smurfs(OVER DUE)\n-Pirates of the carribean\n-Toy Story\n-Smile\n-Friday the 13th\n");
            //assign value to nothing so usser can input later on
            string DvdTitle = "";
            int AgeLimit = 0;
            string DVDtype = "";
            string DvdSize = "";
            //Enables for repeat of loop without ending for any overdue books or incorrect input
            bool RestartLoop = false;
            //Loops through the number of DVD the user wants
            int NumOfDVD = 0;
            //Loop incramentation

            int DVDcount = 0;
            //DVD code
            Console.Write("\nPlease Input the amount of DVD's you would like to loan: ");
            NumOfDVD = Convert.ToInt32(Console.ReadLine());
            while (RestartLoop == false)
            {
                while (DVDcount < NumOfDVD)
                {
                    Console.Write("Please Input the DVD you would like to loan: ");
                    DvdTitle = Console.ReadLine();
                    RestartLoop = false;
                    if (DvdTitle == "Smurfs")
                    {
                        Console.WriteLine("It seems like you have gone over the 2 week loan spell.");
                        Console.Write("You have not returned this item from before, please enter the date you loaned this out: ");
                        DateTime BookstartDate = Convert.ToDateTime(Console.ReadLine());
                        //Calculating when the book was supposed to be in by
                        DateTime LoanSpell = BookstartDate;

                        Console.Write($"The DVD was supposed to be handed back on: {LoanSpell.AddDays(14)}\n please enter todays date: ");
                        //working out the fee
                        DateTime ReturnedBydate = Convert.ToDateTime(Console.ReadLine());
                        DateTime DurationDate = LoanSpell.AddDays(14);
                        int OverdueBy = ReturnedBydate.Day - DurationDate.Day;
                        double DvdFee = OverdueBy * 0.25;
                        //updating the fee
                        FeeAmmount = FeeAmmount + DvdFee;
                        RestartLoop = false;

                    }
                    else if (DvdTitle == null)
                    {
                        RestartLoop = false;
                    }
                    else
                    {
                        //setting the 
                        if (DvdTitle == "Pirates of the carribean"  )
                        {
                            AgeLimit = 12;
                            
                        }
                        else if (DvdTitle == "Toy Story")
                        {
                            AgeLimit = 4;
                        }
                        else if (DvdTitle == "Smile" || DvdTitle == "Friday the 13th")
                        {
                            AgeLimit = 18;
                        }
                        else
                        {
                            //error handling
                            Console.WriteLine("No valid movie was selected");
                            RestartLoop = false;
                        }
                        RestartLoop = false;
                        Console.WriteLine("\nDVD Types:\n-Normal\n-Blue Ray");
                        Console.Write("Please select (N) for normal and (B) for Blueray: ");
                        DVDtype = Console.ReadLine().ToUpper();//converts user input to upper case 
                        if (DVDtype != "N" && DVDtype != "B")
                        {
                            Console.WriteLine("Invalid dvd type!");
                            RestartLoop = false;
                        }
                        else
                        {
                            Console.Write("Please enter the size of the CD (S- small, M- medium, L- large: ");
                            DvdSize = Console.ReadLine();
                            if (DvdSize.ToUpper() != "S" && DvdSize.ToUpper() != "M" && DvdSize.ToUpper() != "L")
                            {
                                //error checking
                                Console.WriteLine("Invalid input");
                                RestLoop = false;
                            }
                            //change the colout to show the loaned was successfull
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DVD successfully loaned! ");
                            Console.ForegroundColor = ConsoleColor.White;
                            DVD dvd = new DVD(AgeLimit, DVDtype, DvdSize, DvdTitle);
                            DvdSummary.Add(Convert.ToString(dvd));
                            DVDcount++;
                        }

                    }

                    RestartLoop = true;
                }
            }
            Console.WriteLine("\nSelect ANY key to continue to the last part of the booking");
            Console.ReadKey();
            string BookTitle = "";
            int Pages = 0;
            string BookID = "";
            
            //Enables for repeat of loop without ending for any overdue books or incorrect input
            RestartLoop = false;
            //Loops through the number of DVD the user wants
            int NumberOfBooks = 0;
            //Loop incramentation
            int Bookcount = 0;
            //Books
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("          List of Book options       ");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("Books's:\n-Harry Potter\n-Collin The Snake\n-Gangster Granny\n-Monkey Time\n-Jungle Book\n-Romeo and Juliet (OVER DUE)");

            Console.Write("How many books would you like to loan out: ");
            NumberOfBooks = Convert.ToInt32(Console.ReadLine());
            while (RestartLoop == false)
            {
                while (Bookcount < NumberOfBooks)
                {
                  Console.Write("Please enter the title of the book you would like to loan: ");
                  BookTitle = Convert.ToString(Console.ReadLine());
                    if (BookTitle.ToLower() == "romeo and juliet")
                    {
                        Console.WriteLine("It seems like you have gone over the 2 week loan spell.");
                        Console.Write("You have not returned this item from before, please enter the date you loaned this out: ");
                        DateTime BookstartDate = Convert.ToDateTime(Console.ReadLine());
                        //Calculating when the book was supposed to be in by
                        DateTime LoanSpell = BookstartDate;

                        Console.Write($"The Book was supposed to be handed back on: {LoanSpell.AddDays(14)}\n please enter todays date: ");
                        //working out the fee
                        DateTime ReturnedBydate = Convert.ToDateTime(Console.ReadLine());
                        DateTime DurationDate = LoanSpell.AddDays(14);
                        int OverdueBy = ReturnedBydate.Day - DurationDate.Day;
                        double BookFee = OverdueBy * 0.25;
                        //updating the fee
                        FeeAmmount = FeeAmmount + BookFee;
                        RestartLoop = false;
                        
                    }
                    else if( BookTitle == null)
                    {
                        //restarts the loop 
                        RestartLoop = false;
                    }
                    else
                    {
                        //manually setting the pages instead of user
                        if(BookTitle.ToLower() == "harry potter")
                        {
                            Pages = 1000;
                        }
                        else if (BookTitle.ToLower() == "collin the snake")
                        {
                            Pages = 32;
                        }
                        else if (BookTitle.ToLower() == "gangster granny")
                        {
                            Pages = 150;
                        }
                        else if (BookTitle.ToLower() == "monkey time")
                        {
                            Pages = 20;
                        }
                        else if ( BookTitle.ToLower() == "jungle book")
                        {
                            Pages = 200;
                        }
                        else
                        {
                            RestartLoop=false;
                        }
                        //Book ID
                        Console.Write("Please input the book ID, it should be between 5 and 10 characters long: ");
                        BookID = Console.ReadLine();

                        if (BookID.Length < 5 || BookID.Length > 10)
                        {
                            RestartLoop = false;
                        }
                        //change the colout to show the loaned was successfull
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Book successfully loaned! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Book book = new Book(Pages, BookID, BookTitle);
                        Booksummary.Add(Convert.ToString(book));
                        Bookcount++;
                    }
                }
                RestartLoop = true;
            }
            //Outputting everything to the user
            Console.WriteLine("-------------ORDER SUMMARY-------------\n");
            //customer detail
            Console.WriteLine("Customer Details:\n");
            foreach (var item in CustomerD)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Fee amount to be paied back: £{FeeAmmount}");
            }
            //booking details
            //CD
            Console.WriteLine("\nCD Details:\n");
            foreach (var item in CdSummary)
            {
                Console.WriteLine(item);
            }
            //DVD
            Console.WriteLine("\nDVD details:\n");
            foreach (var item in DvdSummary)
            {
                Console.WriteLine(item);
            }
            //Book
            Console.WriteLine("\nBook Details:\n");
            foreach (var item in Booksummary)
            {
                Console.WriteLine(item);
            }


        }
    }
}