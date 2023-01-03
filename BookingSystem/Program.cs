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
            Console.WriteLine("CD's:\n-Cold Play\n--Queen\n-Magnum\n-Imagine Dragons(Out of stock)\n-Oasis\n");
            Console.WriteLine("Books's:\n-Harry Potter\n-Diary of the Whimpy kid\n-Gangster Granny\n-Little Red Riding Hood\n-Romeo and Juliet (Out of stock)");
            Console.WriteLine("\nSelect ANY key to continue with booking");
            Console.ReadKey();
            //asking user how many items they want to loan
            Console.Write("Please enter how many CD's you would like to loan; ");
            int AmountOfCD = Convert.ToInt32(Console.ReadLine());
            //enables loop to restart when an invalid answer is invalid
            bool RestLoop = false;
            //Enbales us to loop x amount of times
            int NumOfCDs = 0;

           while (RestLoop == false)
            {
                while (NumOfCDs < AmountOfCD)
                {
                    
                }
            }


        }
    }
}