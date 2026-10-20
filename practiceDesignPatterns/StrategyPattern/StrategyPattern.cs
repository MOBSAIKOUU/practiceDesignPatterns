
//=====================================================================
// Strategy Pattern Example
//=====================================================================
interface IRouteStrategy
{
    void BuildRoute();
}

class DrivingStrategy : IRouteStrategy
{
    public void BuildRoute()
    {
        Console.WriteLine("Calculating a driving route...");
    }
}

class WalkingStrategy : IRouteStrategy
{
    public void BuildRoute()
    {
        Console.WriteLine("Calculating a walking route...");
    }
}

class Navigator
{
    private IRouteStrategy strategy;

    public Navigator(IRouteStrategy selectedStrategy)
    {
        strategy = selectedStrategy;
    }

    public void BuildRoute()
    {
        strategy.BuildRoute();
    }
}