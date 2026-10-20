using System;

//=====================================================================
// Factory Methods Pattern Example
//=====================================================================
interface ITransport
{
    void Deliver();
}

    class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by truck!");
        }
    }

    class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by ship!");
        }
    }

    class Plane : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by plane!");
        }
    }




abstract class Logistics
{
    public abstract ITransport CreateTransport();
}

    class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }

    class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }

    class AirLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Plane();
        }
    }