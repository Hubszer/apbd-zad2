using APBDzad2.Exeptions;
using APBDzad2.Interfaces;

namespace APBDzad2.Containers;

public class LiquidContainer : Container,IHazardNotifier
{
    private Container _containerImplementation;
    private IHazardNotifier _hazardNotifierImplementation;

    public LiquidContainer(double cargoWeight, double height, double weight, double depth, string serNumb, double maxLoad) : base(cargoWeight, height, weight, depth, serNumb, maxLoad)
    {
    }

    public override void Load(double weight)
    {
        cargoWeight += weight;
    }

    public override void Unload()
    {
        cargoWeight = 0;
    }

    public void CheckCargo()
    {
        if (maxLoad < (cargoWeight+weight))
        {
            throw new OverfillException();
        }
    
    }

    public void NotifyDanger(string serNumb)
    {
        Console.WriteLine("Danger in liquid container: " + serNumb);
    }
}