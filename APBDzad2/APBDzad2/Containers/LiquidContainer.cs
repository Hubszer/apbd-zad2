namespace APBDzad2.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight, double height, double weight, double depth, string serNumb, double maxLoad, double type) : base(cargoWeight, height, weight, depth, serNumb, maxLoad, type)
    {
    }

    public override void Load(double cargoWeight)
    {
        
    }
}