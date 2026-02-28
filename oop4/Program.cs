namespace oop4
{
    #region Part 1 : Theoretical Questions

    // Question 1
    // Difference between Static Binding and Dynamic Binding

    // Static Binding: Happens at compile time.
    // Example: Method Overloading.
    //
    // Dynamic Binding: Happens at runtime.
    // Example: Method Overriding using virtual/override.

    // Question 2
    // Difference between Overloading and Overriding

    // Method Overloading:
    // Same method name, different parameters.
    // Happens in the same class.
    // Compile-time polymorphism.
    //
    // Method Overriding:
    // Same method name and same parameters.
    // Happens between base and derived classes.
    // Runtime polymorphism.


    // Question 3
    // Keywords used for Method Overriding

    // virtual  -> Allows method to be overridden.
    // override -> Provides new implementation in child class.
    // base     -> Calls base class version of method.

    #endregion
    #region Part 2 : Practical
    // Question 1 
    //public class Ticket
    //{
    //    private static int counter = 1;

    //    public int TicketId { get; }
    //    public string MovieName { get; set; }
    //    public decimal Price { get; protected set; }

    //    protected const decimal TaxRate = 0.14m;

    //    public Ticket(string movieName, decimal price)
    //    {
    //        TicketId = counter++;
    //        MovieName = movieName;
    //        SetPrice(price);
    //    }

    //    public decimal PriceAfterTax
    //    {
    //        get { return Price + (Price * TaxRate); }
    //    }

    //    public virtual void PrintTicket()
    //    {
    //        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP |" +
    //            $" After Tax: {PriceAfterTax:F2} EGP");
    //    }

    //    public void SetPrice(decimal price)
    //    {
    //        Price = price;
    //    }

    //    public void SetPrice(decimal basePrice, decimal multiplier)
    //    {
    //        Price = basePrice * multiplier;
    //    }
    //}
    //// Question 2 
    

    //public class StandardTicket : Ticket
    //{
    //    public string SeatNumber { get; set; }

    //    public StandardTicket(string movieName, decimal price, string seat)
    //        : base(movieName, price)
    //    {
    //        SeatNumber = seat;
    //    }

    //    public override void PrintTicket()
    //    {
    //        base.PrintTicket();
    //        Console.WriteLine($"  Seat: {SeatNumber}");
    //    }
    //}

    //public class VIPTicket : Ticket
    //{
    //    public bool LoungeAccess { get; set; }
    //    public decimal ServiceFee { get; set; }

    //    public VIPTicket(string movieName, decimal price, bool lounge, decimal fee)
    //        : base(movieName, price)
    //    {
    //        LoungeAccess = lounge;
    //        ServiceFee = fee;
    //    }

    //    public override void PrintTicket()
    //    {
    //        base.PrintTicket();
    //        Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
    //    }
    //}

    //public class IMAXTicket : Ticket
    //{
    //    public bool Is3D { get; set; }

    //    public IMAXTicket(string movieName, decimal price, bool is3D)
    //        : base(movieName, price)
    //    {
    //        Is3D = is3D;
    //    }

    //    public override void PrintTicket()
    //    {
    //        base.PrintTicket();
    //        Console.WriteLine($"  IMAX 3D: {(Is3D ? "Yes" : "No")}");
    //    }
    //}
    //// Question 3 

    //public class Cinema
    //{
    //    private Ticket[] tickets = new Ticket[10];
    //    private int count = 0;

    //    public void OpenCinema()
    //    {
    //        Console.WriteLine("========== Cinema Opened ==========");
    //        Console.WriteLine("Projector started.\n");
    //    }

    //    public void CloseCinema()
    //    {
    //        Console.WriteLine("\n========== Cinema Closed ==========");
    //        Console.WriteLine("Projector stopped.");
    //    }

    //    public void AddTicket(Ticket t)
    //    {
    //        tickets[count++] = t;
    //    }

    //    public void PrintAllTickets()
    //    {
    //        Console.WriteLine("========== All Tickets ==========\n");
    //        for (int i = 0; i < count; i++)
    //        {
    //            tickets[i].PrintTicket();
    //        }
    //    }
    //}
    //// Question 4 
    //public static class TicketProcessor
    //{
    //    public static void ProcessTicket(Ticket t)
    //    {
    //        Console.WriteLine("========== Process Single Ticket ==========\n");
    //        t.PrintTicket();
    //    }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cinema cinema = new Cinema();
            //cinema.OpenCinema();

            //StandardTicket t1 = new StandardTicket("Inception", 150, "A-5");
            //VIPTicket t2 = new VIPTicket("Avengers", 200, true, 50);
            //IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

            
            //Console.WriteLine("========== SetPrice Test ==========\n");

            //Console.WriteLine("Setting price directly: 150");
            //t1.SetPrice(150);

            //Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");
            //t1.SetPrice(100, 1.5m);

            //Console.WriteLine();
            //cinema.AddTicket(t1);
            //cinema.AddTicket(t2);
            //cinema.AddTicket(t3);

            //cinema.PrintAllTickets();

            //Console.WriteLine();

            //TicketProcessor.ProcessTicket(t2);

            //cinema.CloseCinema();
        }
    }
}
