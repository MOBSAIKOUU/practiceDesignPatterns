
using System;

//=====================================================================
// Adapter Pattern Example
//=====================================================================
 
interface IPayment
{
    void Pay();
}

class PaymentAdapter : IPayment
{
    private OldPaymentSystem oldSystem;

    public PaymentAdapter(OldPaymentSystem system)
    {
        oldSystem = system;
    }

    public void Pay()
    {
        oldSystem.MakePayment();
    }
}

class OldPaymentSystem
{
    public void MakePayment()
    {
        Console.WriteLine("Payment processed by old system!");
    }
}

class NewPaymentSystem : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment processed by new system!");
    }
}






