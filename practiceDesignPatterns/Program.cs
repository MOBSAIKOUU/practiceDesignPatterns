class Program

{
    static void Main()
    {
        //Factory Method Pattern
        Logistics logistics1 = new SeaLogistics();
        Logistics logistics2 = new RoadLogistics();
        Logistics logistics3 = new AirLogistics();

        ITransport transport1 = logistics1.CreateTransport();
        ITransport transport2 = logistics2.CreateTransport();
        ITransport transport3 = logistics3.CreateTransport();

        transport1.Deliver();
        transport2.Deliver();
        transport3.Deliver();

        Console.WriteLine();

        //Adapter Pattern
        OldPaymentSystem oldSystem = new OldPaymentSystem();

        IPayment oldPayment = new PaymentAdapter(oldSystem);
        IPayment newPayment = new NewPaymentSystem();


        Console.WriteLine("Using the old payment system:");
        oldPayment.Pay();
        Console.WriteLine("Using the new payment system:");
        newPayment.Pay();

        Console.WriteLine();

        //Strategy Pattern

        Navigator navigator = new Navigator(new DrivingStrategy());

        navigator.BuildRoute();
        navigator = new Navigator(new WalkingStrategy());
        navigator.BuildRoute();
    }
}