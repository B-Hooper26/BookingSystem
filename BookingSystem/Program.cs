namespace BookingSystem
{
    public class program
    {

        static void Main(string[] args)
        {
            //creating a customer
            Customer c1 = new Customer("Ben", "21 tod road", "BH23@123.com", "07411993082", 0);

            Console.WriteLine(c1);
        }
    }
}